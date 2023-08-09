using DocuViewareBlazor.Component.Configuration;
using DocuViewareBlazor.Component.Helpers;
using GdPicture14;
using GdPicture14.WEB;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.AspNetCore.Components.Server.Circuits;
using Microsoft.Extensions.Logging;
using Microsoft.JSInterop;
using System.Text.Json;

namespace DocuViewareBlazor.Component
{
    public class DocuviewareComponent : ComponentBase
    {
        #region Constructors
        public DocuviewareComponent()
        {
            DocuViewareComponentReference = DotNetObjectReference.Create(this);
        }
        #endregion

        #region Private Reference

        List<string> _JavascriptToRegister { get; set; } = new List<string>();
        readonly DotNetObjectReference<DocuviewareComponent> DocuViewareComponentReference;

        [Inject] IJSRuntime _JSRuntime { get; set; }

        [Inject] IEnumerable<CircuitHandler> CircuitHandlers { get; set; }

        [Inject] ILogger<DocuviewareComponent> _logger { get; set; }

        [Inject] DocuViewareConfiguration dvConfig { get; set; }

        #endregion

        #region Component Parameters

        /// <summary>
        /// The client identifier assigned to the DocuviewareControl instance.
        /// </summary>
        [Parameter] public string ControlId { get; set; } = "DocuVieware1";

        [Parameter] public string Height { get; set; } = "100%";

        [Parameter] public string Width { get; set; } = "100%";

        /// <summary>
        /// Specifies the user preference information related to the user's language.
        /// </summary>
        /// <remarks>
        /// Default value is DocuViewareLocale.Auto.
        /// </remarks>
        [Parameter] public DocuViewareLocale? Locale { get; set; } = null;

        /// <summary>
        /// Specifies whether form fields can be edited into the client browser or not.
        /// </summary>
        /// <remarks>Default value is true.</remarks>
        [Parameter] public bool EnableFormFieldsEdition { get; set; } = true;

        #endregion

        #region Component Event

        [Parameter] public EventCallback<GdPictureRotateFlipType> OnRotation { get; set; }
        [Parameter] public EventCallback<JsonElement> OnAnnotationAdded { get; set; }

        #endregion

        #region Blazor Component methods
        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            UserScopedCircuitHandler? userScopedCircuitHandler = CircuitHandlers.FirstOrDefault(ch => ch is UserScopedCircuitHandler) as UserScopedCircuitHandler;
            base.BuildRenderTree(builder);

            var sessionId = userScopedCircuitHandler != null ? userScopedCircuitHandler.CircuitId : Guid.NewGuid().ToString();

            using StringWriter htmlWriter = new();
            using var docuVieware = new DocuViewareControl(sessionId, ControlId, dvConfig.SessionTimeout)
            {
                Height = Height,
                Width = Width,
                ForceScrollBars = false,
                AllowedExportFormats = "*",
                MaxUploadSize = 52428800,
                CollapsedSnapIn = true,
                EnableMouseModeButtons = false,
                EnableFormFieldsEdition = EnableFormFieldsEdition,
                Locale = Locale ?? DocuViewareLocale.Auto
            };

            docuVieware.RenderControl(htmlWriter);
            string controlRawOutput = htmlWriter.GetStringBuilder().ToString();

            //** IMPORTANT - must separate <script>...</script> content because it is not recommended to dynamically render script tags/content here.
            //see this github article  https://github.com/dotnet/aspnetcore/issues/14201
            //Supposed to inject the script via the JSInterop
            var htmlMarkup = ExtractJavascriptFromHTMLMarkup(controlRawOutput, out var scripts);

            //add control's html to builder as just content
            builder.AddMarkupContent(0, htmlMarkup);

            //now pull off script tags and we have the javascript that needs to be run through 'eval' in jsinterop onafterrender
            _JavascriptToRegister = scripts;
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                //probably only do this once on first render?
                //NOTE** I have pre-render turned off so this is ok.  This would be a problem if it were on since I don't think you can interact with jsinterop till after pre-render
                foreach (var script in _JavascriptToRegister)
                {
                    await _JSRuntime.InvokeVoidAsync("window.eval", script);
                }

                // Insert Javascript code that will allow us to warn DoNet code that the DV Control is ready
                await _JSRuntime.InvokeVoidAsync("window.eval", OnDVReadyScript);

                // Call the previously inserted code with the necessary DotNetRef
                await _JSRuntime.InvokeVoidAsync("window.onDocuViewareLoad", DocuViewareComponentReference);

                /// Add DotNet reviver to allow usage of <see cref="CallBackInteropWrapper"/>
                await _JSRuntime.InvokeVoidAsync("window.eval", "DotNet.attachReviver(function (key, value) { if (value && typeof value === 'object' && value.hasOwnProperty(\"__isCallBackWrapper\")) { var netObjectRef = value.callbackRef; return function () { netObjectRef.invokeMethodAsync('Invoke', ...arguments); }; } else { return value; }});");
            }

            await base.OnAfterRenderAsync(firstRender);
        }

        protected override Task OnInitializedAsync()
        {
            return base.OnInitializedAsync();
        }

        [JSInvokable("OnViewerReady")]
        public async void OnViewerReady()
        {
            await InvokeDocuViewareMethod("RegisterOnRotationChanged", GetCallback(OnRotation));
            await InvokeDocuViewareMethod("RegisterOnAnnotationAdded", GetCallback(OnAnnotationAdded));
        }

        private CallBackInteropWrapper GetCallback<T>(EventCallback<T> callback)
        {
            return CallBackInteropWrapper.Create<T>(async val =>
            {
                if (callback.HasDelegate)
                {
                    await callback.InvokeAsync(val);
                }
            });
        }

        #endregion

        #region DocuVieware JS Bridge

        public Task<GdPictureStatus> RotatePage(GdPictureRotateFlipType rotation = GdPictureRotateFlipType.GdPictureRotate90FlipNone)
        {
            return InvokeDocuViewareMethod("RotatePage", rotation);
        }

        public Task<int> GetCurrentPage()
        {
            return InvokeDocuViewareMethod<int>("GetCurrentPage");
        }

        #endregion

        #region Private methods

        private Task<GdPictureStatus> InvokeDocuViewareMethod(string command, params object[] parameters)
        {
            return InvokeDocuViewareMethod<GdPictureStatus>(command, parameters);
        }

        private async Task<T> InvokeDocuViewareMethod<T>(string command, params object[] parameters)
        {
            string method = $"window.DocuViewareAPI.{command}";

            List<object> args = new(parameters.Length + 1)
            {
                ControlId
            };
            args.AddRange(parameters);


            T result = await _JSRuntime.InvokeAsync<T>(method, args.ToArray());

            _logger.LogTrace("command {0}({1}), result value {2}", method, string.Join(',', args), result);

            return result;
        }

        /// <summary>
        /// Extract the script markup from the HTML markup 
        /// </summary>
        /// <param name="htmlMarkup">the original HTML markup with script</param>
        /// <param name="scriptMarkupExtracted">the javascript that will need to be executed</param>
        /// <returns>the HTML markup without script tag</returns>
        private string ExtractJavascriptFromHTMLMarkup(string htmlMarkup, out List<string> scriptMarkupExtracted)
        {
            scriptMarkupExtracted = new List<string>();
            var startScriptTag = "<script>";
            var endScriptTag = "</script>";

            do
            {
                var javascriptWithScriptTags = htmlMarkup.Substring(htmlMarkup.IndexOf(startScriptTag), htmlMarkup.IndexOf(endScriptTag) - htmlMarkup.IndexOf(startScriptTag) + endScriptTag.Length);

                scriptMarkupExtracted.Add(javascriptWithScriptTags.Replace(startScriptTag, "").Replace(endScriptTag, ""));
                //pull script content out to separate it from the control's html

                htmlMarkup = htmlMarkup.Replace(javascriptWithScriptTags, "");

            } while (htmlMarkup.IndexOf(startScriptTag) != -1);

            return htmlMarkup;
        }

        private string OnDVReadyScript => "window.onDocuViewareLoad = dotNetRef => { " +
        " window.docuViewareComponentReference = dotNetRef;" +
        " function RegisterOnRotationChangedOnDocuViewareAPIReady() {" +
       $"    if (typeof DocuViewareAPI !== \"undefined\" && DocuViewareAPI.IsLoaded(\"{ControlId}\")) {{ " +
        "        dotNetRef.invokeMethodAsync('OnViewerReady');" +
        "    } " +
        "     else { " +
        "        setTimeout(function () { RegisterOnRotationChangedOnDocuViewareAPIReady() }, 10);" +
        "    }" +
        " }" +
        " RegisterOnRotationChangedOnDocuViewareAPIReady(); " +
        "}";

        #endregion
    }
}
