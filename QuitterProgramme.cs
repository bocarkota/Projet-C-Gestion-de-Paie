using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetFinal
{
    public class QuitterProgramme
    {
        public static void Quitter()
        {
            Console.WriteLine("AU REVOIR  ! APPUYEZ SUR UNR...");
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}
