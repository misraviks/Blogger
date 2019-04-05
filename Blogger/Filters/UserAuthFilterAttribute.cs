using System;
using System.Web.Mvc;

namespace Blogger.Controllers
{
    internal class UserAuthFilterAttribute : Attribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationContext filterContext)
        {
            throw new NotImplementedException();
        }
    }
}