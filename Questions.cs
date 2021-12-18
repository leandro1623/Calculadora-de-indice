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
    public partial class Questions : Form
    {
        public Questions()
        {
            InitializeComponent();
            refresh();
        }

        private void refresh()
        {
            btnok.Enabled = txtHowManySubjects.Text.Length > 0 ? true : false;
            txtHowManySubjects.Focus();
        }

        private bool Confirm()
        {
            int value;
            if(int.TryParse(txtHowManySubjects.Text,out value))
            {
                return true;
            }
            return false;
        }

        public string ReturntxtValue()
        {
            return txtHowManySubjects.Text;
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            ReturntxtValue();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtHowManySubjects_TextChanged(object sender, EventArgs e)
        {
            refresh();
        }

        private void Questions_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Confirm())
            {
                MessageBox.Show("The value typed heven't the corret format","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtHowManySubjects.Text = "0";
            }
        }
    }
}
