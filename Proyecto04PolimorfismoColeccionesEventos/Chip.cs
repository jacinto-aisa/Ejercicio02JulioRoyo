using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proyecto04
{
    public class Chip : IPesable
    {
        public decimal Peso;
        /// <summary>
        /// Constructor de la clase
        /// </summary>
        /// <param name="peso"></param>
        public Chip(decimal peso)
        {
            Peso = peso;
        }
        /// <summary>
        /// Devuelve el peso en decimal para poder hacer calculos exactos y no variables
        /// </summary>
        /// <returns>Peso</returns>
        public decimal DevolverPeso()
        {
            return Peso;
        }
    }
}