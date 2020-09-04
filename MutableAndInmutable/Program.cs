using System;
using System.Text;

namespace MutableAndInmutable
{
    class Program
    {
        static void Main(string[] args)
        {


            for (int k = 0; k < 10; k++)
            {
                DateTime dtini = DateTime.Now;

                string sStringBasico = string.Empty;



                //Inmutable
                for (int i = 0; i < 10000; i++)
                {
                    sStringBasico += "Modified ";
                }




                DateTime dtfin = DateTime.Now;

                int difS = dtfin.Second - dtini.Second;
                int difmS = dtfin.Millisecond - dtini.Millisecond;

                Console.WriteLine("Inmutable time: " + difmS.ToString() + " - " + difS.ToString());
            }


            for (int k = 0;k < 10; k++)
            {
                DateTime dtini = DateTime.Now;

                StringBuilder strB = new StringBuilder();

                //Mutable
                for (int i = 0; i < 10000; i++)
                {
                    strB.Append("Modified ");
                }

                DateTime dtfin = DateTime.Now;

                int difS = dtfin.Second - dtini.Second;
                int difmS = dtfin.Millisecond - dtini.Millisecond;

                Console.WriteLine("Mutable time: " + difmS.ToString() + " - " + difS.ToString());
            }
            Console.ReadLine();
        }
    }
}
