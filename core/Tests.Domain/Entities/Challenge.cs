using Tests.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Domain.Entities
{
    public class Challenge : Test
    {
        public string Location { get; set; } = "Novocherkassk";

        public string Date { get; set; } = "May 25, 2023";

        public int PassingScore { get; set;}
    }
}
