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
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
            ShowResult();
        }

        private void ShowResult()//show the result
        {
            float Index, Prom;
            ProcesingResult(out Index, out Prom);
            txtAverage.Text = Prom.ToString();
            txtIndex.Text = Index.ToString();
        }


        private string HowManySubjectsShowForm()//ask how many subjects 
        {
            Questions questions = new Questions();
            return (questions.ShowDialog() == DialogResult.OK) ? questions.ReturntxtValue() : "0";
        }

        private Subject SubjectsData()//get and return a subject
        {
            DataSubjet dataSubjet = new DataSubjet();
            dataSubjet.ShowDialog();
            return dataSubjet.Subject;
        }

        private List<Subject> GettingSubjectsData()//get and return the list of subjects
        {
            int Count = int.Parse(this.HowManySubjectsShowForm());
            List<Subject> subjects = new List<Subject>();

            for(int i = 0; i < Count; i++)
            {
                subjects.Add(SubjectsData());
            }
            return subjects;
        }

        private void ProcesingResult(out float IndexResult,out float PromResult)//get the quater promedi and the index of quater
        {
            List<Subject> subjects = this.GettingSubjectsData();
            if(subjects.Count > 0)
            {
                float resultQualifications = 0, ResultCredits = 0;

                foreach (Subject subject in subjects)
                {
                    resultQualifications += (subject.Qualification * subject.Credits);
                    ResultCredits += subject.Credits;
                }

                //PROMEDIO DE 0 A 100
                PromResult = resultQualifications / ResultCredits;
                //indice cuatrimestral
                IndexResult = (PromResult * 4) / 100;
            }
            else
            {
                IndexResult = 0;
                PromResult = 0;
            }

        }

        private void btnLeave_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
