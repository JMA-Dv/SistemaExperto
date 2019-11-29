using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using SbsSW.SwiPlCs;

namespace Branch
{
    public partial class juego : Form
    {
        private int semestreA=0, semestreB=0, semestreC=0;
        public juego()
        {
            InitializeComponent();
            load();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void CerrarVentana_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }



        private void Juego_Load(object sender, EventArgs e)
        {

        }

        void load()
        {
            try
            {
                Environment.SetEnvironmentVariable("SWI_HOME_DIR", @"C:\Program Files (x86)\pl");
                Environment.SetEnvironmentVariable("Path", @"C:\Program Files (x86)\pl\bin");
                string[] data = { "-q", "-f", @"branch.pl" };
                PlEngine.Initialize(data);
                
            }
            catch (Exception)
            {

            }
        }
        public List<String> consulta(string context)
        {
            List<String> allElements = new List<String>();
            PlQuery generalConsult = new PlQuery(context);
            foreach (PlQueryVariables elements in generalConsult.SolutionVariables)
            {
                //allElements.Add(elements["A"].ToString());
                allElements.Add(elements["B"].ToString());

            }
            PlEngine.PlThreadDestroyEngine();

            return allElements;
        }

        private void telecomunicacionesBox_CheckedChanged(object sender, EventArgs e)
        {
            List<string> arquitectura = consulta("quien_gana('Fundamentos De Telecomunicaciones',B)");
            if (telecomunicacionesBox.Checked == true)
            {
                foreach (string vari in arquitectura)
                {
                    switch (vari)
                    {
                        case "semestre5":
                            semestreA++;
                            Console.WriteLine(vari);
                            break;
                        case "semestre4":
                            semestreB++;
                            break;
                        case "semestre7":
                            semestreC++;
                            break;
                    }

                }
            }
            else
            {
                foreach (string vari in arquitectura)
                {
                    switch (vari)
                    {
                        case "semestre5":
                            semestreA--;
                            Console.WriteLine(vari);
                            break;
                        case "semestre4":
                            semestreB--;
                            break;
                        case "semestre7":
                            semestreC--;
                            break;
                    }

                }
            }

        }

        private void fundamentosIngenieriaBox_Click(object sender, EventArgs e)
        {
            List<string> arquitectura = consulta("quien_gana('Fundamentos De Ingenieria De Software',B)");
            if (fundamentosIngenieriaBox.Checked == true)
            {
                
                foreach (string vari in arquitectura)
                {
                    switch (vari)
                    {
                        case "semestre5":
                            semestreA++;
                            Console.WriteLine(vari);
                            break;
                        case "semestre4":
                            semestreB++;
                            break;
                        case "semestre7":
                            semestreC++;
                            break;
                    }
                }

            }
            else
            {
                foreach (string vari in arquitectura)
                {
                    switch (vari)
                    {
                        case "semestre5":
                            semestreA--;
                            Console.WriteLine(vari);
                            break;
                        case "semestre4":
                            semestreB--;
                            break;
                        case "semestre7":
                            semestreC--;
                            break;
                    }
                }
            }
        }

        private void baseDeDatoBox_Click(object sender, EventArgs e)
        {
            List<string> arquitectura = consulta("quien_gana('Programacion de base de datos',B)");
            if (baseDeDatoBox.Checked == true)
            {
                
                foreach (string vari in arquitectura)
                {
                    switch (vari)
                    {
                        case "semestre5":
                            semestreA++;
                            Console.WriteLine(vari);
                            break;
                        case "semestre4":
                            semestreB++;
                            break;
                        case "semestre7":
                            semestreC++;
                            break;
                    }
                }

            }
            else
            {
                foreach (string vari in arquitectura)
                {
                    switch (vari)
                    {
                        case "semestre5":
                            semestreA--;
                            Console.WriteLine(vari);
                            break;
                        case "semestre4":
                            semestreB--;
                            break;
                        case "semestre7":
                            semestreC--;
                            break;
                    }
                }
            }
        }

        private void conmutacionBox_Click(object sender, EventArgs e)
        {
            List<string> arquitectura = consulta("quien_gana('Conmutacion de Redes',B)");
            if (conmutacionBox.Checked == true)
            {
                
                foreach (string vari in arquitectura)
                {
                    switch (vari)
                    {
                        case "semestre5":
                            semestreA++;
                            Console.WriteLine(vari);
                            break;
                        case "semestre4":
                            semestreB++;
                            break;
                        case "semestre7":
                            semestreC++;
                            break;
                    }
                }

            }
            else
            {
                foreach (string vari in arquitectura)
                {
                    switch (vari)
                    {
                        case "semestre5":
                            semestreA--;
                            Console.WriteLine(vari);
                            break;
                        case "semestre4":
                            semestreB--;
                            break;
                        case "semestre7":
                            semestreC--;
                            break;
                    }
                }
            }
        }

        private void gestionBox_Click(object sender, EventArgs e)
        {
            List<string> arquitectura = consulta("quien_gana('Gestion de proyectos de software',B)");
            if (gestionBox.Checked == true)
            {
                
                foreach (string vari in arquitectura)
                {
                    switch (vari)
                    {
                        case "semestre5":
                            semestreA++;
                            Console.WriteLine(vari);
                            break;
                        case "semestre4":
                            semestreB++;
                            break;
                        case "semestre7":
                            semestreC++;
                            break;
                    }
                }

            }
            else
            {
                foreach (string vari in arquitectura)
                {
                    switch (vari)
                    {
                        case "semestre5":
                            semestreA--;
                            Console.WriteLine(vari);
                            break;
                        case "semestre4":
                            semestreB--;
                            break;
                        case "semestre7":
                            semestreC--;
                            break;
                    }
                }
            }
        }

        private void webBox_Click(object sender, EventArgs e)
        {
            List<string> arquitectura = consulta("quien_gana('Programacion web',B)");
            if (webBox.Checked == true)
            {
                
                foreach (string vari in arquitectura)
                {
                    switch (vari)
                    {
                        case "semestre5":
                            semestreA++;
                            Console.WriteLine(vari);
                            break;
                        case "semestre4":
                            semestreB++;
                            break;
                        case "semestre7":
                            semestreC++;
                            break;
                    }
                }

            }
            else
            {
                foreach (string vari in arquitectura)
                {
                    switch (vari)
                    {
                        case "semestre5":
                            semestreA--;
                            Console.WriteLine(vari);
                            break;
                        case "semestre4":
                            semestreB--;
                            break;
                        case "semestre7":
                            semestreC--;
                            break;
                    }
                }

            }
        }

        private void jugarButton_Click(object sender, EventArgs e)
        {
            string ganador;
            if (semestreA > semestreB)
            {
                ganador = "Semestre 5";
            }else if(semestreB > semestreC)
            {
                ganador = "Semestre 4";
            }
            else if(semestreA==0 ||semestreB==0 || semestreC==0)
            {
                ganador = "Empate";
            }
            else
            {
                ganador = "Semestre 7";
            }
            winner win = new winner(ganador);
            win.ShowDialog();
        }

        private void prologBox_Click(object sender, EventArgs e)
        {
            List<string> prolog = consulta("quien_gana('Programacion logica y funcional',B)");
            if (prologBox.Checked == true)
            {
                
                foreach (string vari in prolog)
                {
                    switch (vari)
                    {
                        case "semestre5":
                            semestreA++;
                            Console.WriteLine(vari);
                            break;
                        case "semestre4":
                            semestreB++;
                            break;
                        case "semestre7":
                            semestreC++;
                            break;
                    }
                }

            }
            else
            {
                foreach (string vari in prolog)
                {
                    switch (vari)
                    {
                        case "semestre5":
                            semestreA--;
                            Console.WriteLine(vari);
                            break;
                        case "semestre4":
                            semestreB--;
                            break;
                        case "semestre7":
                            semestreC--;
                            break;
                    }
                }
            }
        }

        private void arquitecturaBox_CheckedChanged(object sender, EventArgs e)
        {
            List<string> arquitectura = consulta("quien_gana('Arquitectura de Computadoras',B).");
            if (arquitecturaBox.Checked == true)
            {
                
                foreach (string vari in arquitectura)
                {
                    switch (vari)
                    {
                        case "semestre5":
                            semestreA++;
                            Console.WriteLine(vari);
                            break;
                        case "semestre4":
                            semestreB++;
                            break;
                        case "semestre7":
                            semestreC++;
                            break;
                    }
                }

            }
            else
            {
                foreach (string vari in arquitectura)
                {
                    switch (vari)
                    {
                        case "semestre5":
                            semestreA--;
                            Console.WriteLine(vari);
                            break;
                        case "semestre4":
                            semestreB--;
                            break;
                        case "semestre7":
                            semestreC--;
                            break;
                    }
                }
            }

        }
    }
}
