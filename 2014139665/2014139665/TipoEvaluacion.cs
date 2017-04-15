using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139665
{
    public class TipoEvaluacion
    {
        private string tipoEvaluacion;

        public string TipoEval
        {
            get{
                return tipoEvaluacion;
            }
            set{                
                tipoEvaluacion = value;
            }
        }

        public TipoEvaluacion(string tipEvaluac)
        {
            TipoEval = tipEvaluac;
        }
    }
}
