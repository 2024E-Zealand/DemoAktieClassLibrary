using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAktieClassLibrary
{
    /// <summary>
    /// Klasse der indeholder aktioeoplysninger
    /// </summary>
    public class Aktie
    {
        /// <summary>
        /// navnet på aktien
        /// </summary>
        public string Navn { get; set; }

        /// <summary>
        /// constructor 
        /// </summary>
        /// <param name="navn">navnet på aktien</param>
        public Aktie(string navn)
        {
            this.Navn = navn;
        }

    }
}
