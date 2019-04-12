using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace avp.Models
{
    public class ProjectViewModel
    {
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal EstimatedCost { get; set; }
        public decimal PredictedCost { get; set; }
        public List<KeyWordViewModel> lstKeyWord { get; set; }
        public string UserID { get; set; }
    }

    public class KeyWordViewModel
    {
        public string KeyWord { get; set; }
    }
}