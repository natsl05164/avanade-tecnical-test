using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using avp.Models;

namespace avp.Repo
{
    public class ProjectRepo
    {
        public List<ProjectViewModel> GetAllProjects()
        {

            List<ProjectViewModel> lst = new List<ProjectViewModel>();

            ProjectViewModel vm = new ProjectViewModel
            {
                Name = "Primary project",
                StartDate = new DateTime(2005, 12, 20),
                EndDate = new DateTime(2006, 12, 20),
                EstimatedCost = 200000,
                PredictedCost = 222000
            };

            vm.lstKeyWord = new List<KeyWordViewModel>();
            vm.lstKeyWord.Add(new KeyWordViewModel
            {
                KeyWord = "Cost Study"
            });
             
            lst.Add(vm);

            vm = new ProjectViewModel
            {
                Name = "Secondary project",
                StartDate = new DateTime(2004, 12, 20),
                EndDate = new DateTime(2006, 12, 20),
                EstimatedCost = 1110100,
                PredictedCost = 2222000
            };
            vm.lstKeyWord = new List<KeyWordViewModel>();
            vm.lstKeyWord.Add(new KeyWordViewModel
            {
                KeyWord = "Cost Study"
            });
            vm.lstKeyWord.Add(new KeyWordViewModel
            {
                KeyWord = "Offset Study"
            });


            lst.Add(vm);


            vm = new ProjectViewModel
            {
                Name = "Third project",
                StartDate = new DateTime(2019, 12, 20),
                EndDate = new DateTime(2020, 12, 20),
                EstimatedCost = 20023000,
                PredictedCost = 22222000
            };
            vm.lstKeyWord = new List<KeyWordViewModel>();
            vm.lstKeyWord.Add(new KeyWordViewModel
            {
                KeyWord = "Cost Study"
            });
            vm.lstKeyWord.Add(new KeyWordViewModel
            {
                KeyWord = "Offset Study"
            });

            lst.Add(vm);


            vm = new ProjectViewModel
            {
                Name = "Fourth project",
                StartDate = new DateTime(2017, 12, 20),
                EndDate = new DateTime(2018, 12, 20),
                EstimatedCost = 200000,
                PredictedCost = 222000
            };
            vm.lstKeyWord = new List<KeyWordViewModel>();
            vm.lstKeyWord.Add(new KeyWordViewModel
            {
                KeyWord = "Cost Study"
            });
            vm.lstKeyWord.Add(new KeyWordViewModel
            {
                KeyWord = "Offset Study"
            });

            lst.Add(vm);


            vm = new ProjectViewModel
            {
                Name = "Fifth project",
                StartDate = new DateTime(2015, 12, 20),
                EndDate = new DateTime(2018, 12, 20),
                EstimatedCost = 2030000,
                PredictedCost = 2220300
            };
            vm.lstKeyWord = new List<KeyWordViewModel>();
            vm.lstKeyWord.Add(new KeyWordViewModel
            {
                KeyWord = "Offset Study"
            });

            lst.Add(vm);
            return lst;
        }
    }
}