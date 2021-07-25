using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proyecto04
{
    public interface IPesable
    {
        /// <summary>
        /// Devuelve el peso en decimal para poder hacer calculos exactos y no variables
        /// </summary>
        /// <returns>Peso</returns>
        decimal DevolverPeso();

    }
}