using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dish
{
    class Kokteyl
    {
        public string Name { set; get; }
        //public List<string> ingrid;
        public string[] mass;
        public Kokteyl(string name,params string[] str)
        {
            this.Name = name;
            mass = new string[str.Length];
            str.CopyTo(mass, 0);
            //ingrid = new List<string>(str.Length);
            //foreach (var s in str)
            //{
            //    ingrid.Add(s);
            //}


        }
    }
}
