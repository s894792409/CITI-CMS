using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.Models.ViewModels
{
    public class ImportInfo
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Name { get; set; }
        public int Pax { get; set; }
        public string SIC { get; set; }
        public string Host { get; set; }
        public bool ForeignVisit { get; set; }
    }
}
