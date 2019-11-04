using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.Models.ViewModels
{
    public class Card
    {
        public int cardId { get; set; }
        public string title { get; set; }
        public string color { get; set; }
        public string value { get; set; }
        public string icon { get; set; }
        public int boxId { get; set; }
        public DateTime dateCreated { get; set; }
    }
}
