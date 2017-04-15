using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _2014139665
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = 3000;

            var plan1 = "Pre-pago";
            var plan2 = "Post-pago";

            var eva = "Renovacion de contrato";
            var eva1 = "Portabilidad";
            var eva2 = "Linea nueva";

            var state1 = "Aprobado";
            var state2 = "Desaprobado";
                       
            Evaluacion eval;           
            
            Console.WriteLine("*****************************************");
            Plan plan = new Plan(plan1);
            eval = new Evaluacion(plan1,null);
            plan.evaluacion(plan1);
            Thread.Sleep(time);

            eval = new Evaluacion(plan2,eva);
            Console.WriteLine("*****************************************");
            plan.evaluacion(plan2);
            eval.agregarEvaluacion(eva);
            eval.testLineas(state1);
            Thread.Sleep(time);

            eval = new Evaluacion(plan2, eva1);
            Console.WriteLine("*****************************************");
            plan.evaluacion(plan2);
            eval.agregarEvaluacion(eva1);
            eval.testLineas(state1);
            Thread.Sleep(time);

            eval = new Evaluacion(plan2, eva2);
            Console.WriteLine("*****************************************");
            plan.evaluacion(plan2);
            eval.agregarEvaluacion(eva2);
            eval.testLineas(state1);
            Thread.Sleep(time);

            eval = new Evaluacion(plan2, eva1);
            Console.WriteLine("*****************************************");
            plan.evaluacion(plan2);
            eval.agregarEvaluacion(eva1);
            eval.testLineas(state2);
            Thread.Sleep(time);

            eval = new Evaluacion(plan2, eva2);
            Console.WriteLine("*****************************************");
            plan.evaluacion(plan2);
            eval.agregarEvaluacion(eva2);
            eval.testLineas(state2);
            
        }
    }
}
