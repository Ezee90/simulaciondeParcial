using System.Data;
using System.Runtime.CompilerServices;

namespace simulaciondeParcial.consola
{
    internal class Program
    {   static void Main(string[] args)
        {   
            

            double radio = Pedirdouble("ingrese el valor del radio del cono:");
            double generatriz = Pedirdouble("ingrese el valor de la generatriz del cono:");

            double generatriz = CalcularGeneratriz(radio, altura);

            double ara = CalcularArea(radio, generatriz);
            Double Volumen = CalcularVolumen(radio, altura);
            Console.WriteLine($"El area del cono es {area}");
            Console.WriteLine($"El volumen del cono es {Volumen}");
        }

        private static double CalcularVolumen(double radio, object altura)
        {
            return (Math.Pi *Math.pow(radio,2 * altura) / 3;
        }

        private static double CalcularArea(double radio, double generatriz)
        {
            return Math.PI * radio * (radio + generatriz);
        }

        private static double CalcularGeneratriz(double radio, double altura)
        {

            return Math.Sqrt(Math.pow(radio, 2) + Math.pow(altura, 2));
        }

        private static double Pedirdouble(string Mensaje)
    }   {
           double nro = 0;
}          do
           {
             Console.Write(Mensaje);
             string strConsola = Console.ReadLine();
             if (!double.TryParse(strConsola, out nro))
             {
                Console.WriteLine("numero mal ingresado");
             }
             else
             {
                 break;
             }
   
          } while (true);
          return nro;
       private static double PedirdoubleEntreMinYMax(string Mensaje, double);
       {
         double nro = 0;
    do
    {
        Console.Write(Mensaje);
        string strConsola = Console.ReadLine();
        strConsola = strConsola.Replace(".", ".",);
        if (!double.TryParse(strConsola, out nro))
        {
            Console.WriteLine("Numero mal ingresado");
        }
        else if (nro >= Min nro >= Max)
         {
            break;
        }
        else
        {
            Console.WriteLine($El numero debe estar entre Min y Max);
        }

    } while (true);
    return nro;
}