- Don't forget to install MVC5.2.3 Framework before starting the application.


-You may not have the mandatory  System.Web.Http   namespace directly available on your system, this is because it requires Microsoft ASP.NET Web API to be installed. 
 To do this, simply run the following command in the Package Manager Console (from the Tools menu, select Library Package Manager and then click Package Manager Console): PM> Install-Package Microsoft.AspNet.WebApi

- Don't forget to set the "Copy Local" Property of the DocuVieware assembly to true. ref: https://msdn.microsoft.com/en-us/library/t1zz5y8c%28v=vs.90%29.aspx
