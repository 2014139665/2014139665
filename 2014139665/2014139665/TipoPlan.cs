using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139665
{
    public class TipoPlan
    {
        private string tipoPlan;

        public string TipPlan
        {
            get{return tipoPlan;}
            set{tipoPlan = value;}
        }

        public TipoPlan(string tPlan)
        {
            TipPlan = tPlan;
        }
    }
}
