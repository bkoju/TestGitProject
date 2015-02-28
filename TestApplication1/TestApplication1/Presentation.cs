using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTest
{
    public class Presentation
    {
        public int PresentationId { get; set; }

        public DateTime? Date { get; set; }

        public string Presenter { get; set; }

        public string Description { get; set; }
    
    }
}
