using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B4.PE1.DellobelI
{

    public class WikiPageMenuItem
    {
        public WikiPageMenuItem()
        {
            TargetType = typeof(WikiPageDetail);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}