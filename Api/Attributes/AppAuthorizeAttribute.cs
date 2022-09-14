using Microsoft.AspNetCore.Mvc.Filters;
using Model.Common;

namespace Api.Attributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class AppAuthorizeAttribute : Attribute, IAuthorizationFilter
    {
        private readonly IList<string> _roles;

        public AppAuthorizeAttribute(params string[] roles)
        {
            _roles = roles ?? new string[] { };
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            // skip authorization if action is decorated with [AllowAnonymous] attribute
            var allowAnonymous = context
                .ActionDescriptor
                .EndpointMetadata
                .OfType<AllowAnonymousAttribute>()
                .Any();
            if (allowAnonymous)
                return;

            bool isAuthorize = isAuthorizedAccount(context);
            if (!isAuthorize)
            {
                throw new ApplicationException("Unauthorized account");
            }
        }


        #region Private Methods

        private bool isAuthorizedAccount(AuthorizationFilterContext context)
        {
            var appAccountItem = context.HttpContext.Items["AppAccount"];
            var appAccount = appAccountItem != null ? (AppAccount)appAccountItem : null;

            // Return false if token not valid (determine by null appAccount)
            if (appAccount == null) { return false; }

            // return true if there are no roles to authorise by 
            if (!_roles.Any()) { return true; }

            // return false if app count has no role to do the role authorisation
            if (appAccount.Role == null) { return false; }

            bool isAuthoriseRole = _roles.Contains(appAccount.Role);

            return isAuthoriseRole;
        }

        #endregion
    }
}
