using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139665
{
    public class Plan
    {
        private TipoPlan plan;
        

        public Plan(string pln)
        {
            Planes = new TipoPlan(pln);
        }

        public TipoPlan Planes
        {
            get { return plan; }
            private set { plan = value; }
        }

        public void evaluacion(string tipPlan)
        {
            if (tipPlan == "Pre-pago")
            {
                Console.WriteLine("Linea Pre-pago seleccionada, no es necesaria la evaluacion.\nSe aprobo la adquisicion de la linea.\n");                
            }
            else
            {
                Console.Write("Linea Post-pago seleccionada, se evaluara para ver si procede.\n");
            }
        }
    }
}
