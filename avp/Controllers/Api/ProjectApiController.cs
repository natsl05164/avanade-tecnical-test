using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using avp.Models;
using avp.Services;

namespace avp.Controllers.Api
{
    public class ProjectApiController : ApiController
    {
        private Services.ProjectService svc = new Services.ProjectService();

        [HttpGet]
        public IHttpActionResult GetAllProjects()
        { 
            var data = svc.GetAllProjects();

            return Json(data);
        }
    }
}
