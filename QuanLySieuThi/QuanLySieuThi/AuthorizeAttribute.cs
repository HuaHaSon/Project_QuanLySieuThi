using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http.Controllers;

namespace QuanLySieuThi
{
    public class AuthorizeAttribute:System.Web.Http.AuthorizeAttribute
    {
        protected override void HandleUnauthorizedRequest(HttpActionContext actionContext)
        {
            if (!HttpContext.Current.User.Identity.IsAuthenticated)
            {
                base.HandleUnauthorizedRequest(actionContext);
            }
            else
            {
                actionContext.Response = new System.Net.Http.HttpResponseMessage
                {
                    StatusCode = System.Net.HttpStatusCode.Forbidden,
                    Content = new StringContent("Truy cập đã bị chặn", System.Text.Encoding.UTF8, "application/json")
                };    
            }
        }
    }
}