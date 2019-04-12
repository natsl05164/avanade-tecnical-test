using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using avp.Repo;
using avp.Models;

namespace avp.Services
{
    public class ProjectService
    {
        private Repo.ProjectRepo repo = new Repo.ProjectRepo();

        public List<ProjectViewModel> GetAllProjects()
        {
            List<ProjectViewModel> lstProject = new List<ProjectViewModel>();
            lstProject = repo.GetAllProjects();


            return lstProject;
        }
    }
}