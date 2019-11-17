using SbsSW.SwiPlCs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Branch
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            load();
        }
        void load()
        {
            try
            {
                Environment.SetEnvironmentVariable("SWI_HOME_DIR", @"C:\Program Files (x86)\pl");
                Environment.SetEnvironmentVariable("Path", @"C:\Program Files (x86)\pl\bin");
                string[] data = { "-q", "-f", @"base_de_conocimiento.pl" };
                PlEngine.Initialize(data);
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string valorObtenido = textBox1.Text;

            
            PlQuery cargar = new PlQuery("cargar('base_de_conocimiento.bd')");
            cargar.NextSolution();

            PlQuery consulta1 = new PlQuery("amigos_solteros(X,Y)");
            foreach (PlQueryVariables z in consulta1.SolutionVariables)
                listBox1.Items.Add(z["X"].ToString());


            PlEngine.PlCleanup();
            cargar.Dispose();
            
        }
    }
}
