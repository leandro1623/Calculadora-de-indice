using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_de_indice
{
    public sealed class Subject
    {
        public string Name { get; set; }
        public float Qualification { get; set; }
        public int Credits { get; set; }

        public float Total()
        {
            return this.Qualification * this.Credits;
        }
    }
}
