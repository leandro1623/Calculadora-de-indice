using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_de_indice
{
    public partial class DataSubjet : Form
    {
        private Subject _subject;
        private static int Count = 0;
        public Subject Subject { get { return _subject; } set { _subject = value; BindSource.Add(_subject); } }
        
        public DataSubjet()
        {
            InitializeComponent();
            Count++;
            label4.Text = string.Format("Escriba los datos de la materia\nType the data of the Subject #{0}", Count);
            Subject = new Subject();
        }

        
    }
}
