using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139665
{
    public class Evaluacion
    {
        private TipoEvaluacion tipoEvaluac;
        private TipoPlan tipoPlan;
        

        public Evaluacion(string plan, string evaluacion)
        {
            tipoEvaluacion = new TipoEvaluacion(evaluacion);
            tipPlan = new TipoPlan(plan);
        }

        public TipoEvaluacion tipoEvaluacion
        {
            get { return tipoEvaluac; }
            private set { tipoEvaluac = value; }
        }

        public TipoPlan tipPlan
        {
            get { return tipoPlan; }
            private set { tipoPlan = value; }
        }

        public void agregarEvaluacion(string tipEv)
        {
            if (tipEv == "Renovacion de contrato")
            {
                Console.WriteLine("Se evaluara la {0}.", tipEv);
            }
            else if (tipEv == "Portabilidad")
            {
                Console.WriteLine("Se evaluara la {0}.", tipEv);
            }
            else if(tipEv=="Linea nueva")
                Console.WriteLine("Se evaluara la {0}.", tipEv);
        }

        public void testLineas(string state)
        {
            if (state == "Aprobado")
                 Console.WriteLine("Se aprobo la evaluacion de la linea.\n");
                
            else
                Console.WriteLine("Se desaprobo la evaluacion de la linea.\n");
              
        }
    }
}
