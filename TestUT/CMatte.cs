using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestUT
{
    /// <summary>
    /// Klass med matematiska metoder
    /// </summary>
    public class CMatte
    {
        /// <summary>
        /// Metod som adderar två tal
        /// </summary>
        /// <param name="Tal1">Första talet</param>
        /// <param name="Tal2">Andra talet</param>
        /// <returns>Summan av Tal1 och Tal2</returns>
        public double Add(double Tal1, double Tal2)
        {
            return Tal1 + Tal2;
        }
        /// <summary>
        /// Metod som subtraherar Tal2 från Tal1
        /// </summary>
        /// <param name="Tal1">Första talet</param>
        /// <param name="Tal2">Andra talet</param>
        /// <returns>Differensen av de två talen</returns>
        public double Sub(double Tal1,double Tal2)
        {
            return Tal1 - Tal2;
        }

        public double Mult(double Tal1, double Tal2)
        {
            return Tal1 * Tal2;
        }

        public bool Prim(int Tal)
        {
            bool resultat = true;
            if (Tal > 1)
            {
                for (int i = 2; i <= Tal / 2; i++)
                {
                    if (Tal % i == 0)
                    {
                        resultat = false;
                        break;
                    }
                }
                return resultat;
            }
            else
                return false;
        }

    }
}
