using Microsoft.JSInterop;
using System.Text.Json.Serialization;

namespace DocuViewareBlazor.Component.Helpers
{
    internal class CallBackInteropWrapper
    {

        [JsonPropertyName("__isCallBackWrapper")]
        public string IsCallBackWrapper { get; set; } = "";

        public static CallBackInteropWrapper Create<T>(Func<T, Task> callback)
        {
            var res = new CallBackInteropWrapper
            {
                CallbackRef = DotNetObjectReference.Create(new JSInteropActionWrapper<T>(callback))
            };
            return res;
        }

        public static CallBackInteropWrapper Create(Func<Task> callback)
        {
            var res = new CallBackInteropWrapper
            {
                CallbackRef = DotNetObjectReference.Create(new JSInteropActionWrapper(callback))
            };
            return res;
        }

        public object CallbackRef { get; set; }


        private class JSInteropActionWrapper
        {
            private readonly Func<Task> toDo;

            internal JSInteropActionWrapper(Func<Task> toDo)
            {
                this.toDo = toDo;
            }
            [JSInvokable]
            public async Task Invoke()
            {
                await toDo.Invoke();
            }
        }

        private class JSInteropActionWrapper<T>
        {
            private readonly Func<T, Task> toDo;

            internal JSInteropActionWrapper(Func<T, Task> toDo)
            {
                this.toDo = toDo;
            }
            [JSInvokable]
            public async Task Invoke(T arg1)
            {
                await toDo.Invoke(arg1);
            }
        }
    }
}
