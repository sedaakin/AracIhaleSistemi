using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http.Controllers;

namespace AracIhaleSistemi.Service.Filtrers
{
	public class ModelValidAttribute : ActionFilterAttribute
	{
		//public override void OnActionExecuting(HttpActionContext actionContext)
		//{
		//	if (!actionContext.ModelState.IsValid)
		//	{
		//		actionContext.Response = actionContext.Request.CreateResponse(System.Net.HttpStatusCode.BadRequest, actionContext.ModelState);
		//	}

		//}
	}
}