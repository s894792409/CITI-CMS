using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.Models.ViewModels
{
    public class Box
    {
        public int boxId { get; set; }
        public int presetId { get; set; }
        public string GUID { get; set; }
        public string localBoxId { get; set; }
    }
}
