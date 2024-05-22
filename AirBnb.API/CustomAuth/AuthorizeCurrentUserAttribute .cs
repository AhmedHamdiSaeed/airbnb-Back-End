using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace AirBnb.API.CustomAuth
{
	public class AuthorizeCurrentUserAttribute : Attribute, IAuthorizationFilter
	{
		public void OnAuthorization(AuthorizationFilterContext context)
		{
			if (context.HttpContext.User.Identity.IsAuthenticated == false)
			{
				context.Result = new UnauthorizedResult();
			}
		}

	}
}
