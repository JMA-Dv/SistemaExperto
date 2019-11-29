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
using System.Runtime.InteropServices;

namespace Branch
{
    public partial class Home : Form
    {

        int contador = 0;
        Form3 materias = new Form3();
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            load();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        void load()
        {
            try
            {
                Environment.SetEnvironmentVariable("SWI_HOME_DIR", @"C:\Program Files (x86)\pl");
                Environment.SetEnvironmentVariable("Path", @"C:\Program Files (x86)\pl\bin");
                string[] data = { "-q", "-f", @"branch.pl" };
                PlEngine.Initialize(data);
            }
            catch (Exception e)
            {

            }

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void CerrarVentana_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ExtenderVentana_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            extenderVentana.Visible = false;
            minimizarventana.Visible = true;

        }

        private void Minimizarventana_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            minimizarventana.Visible = false;
            extenderVentana.Visible = true;
        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
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
            

            return allElements;
        }

        private void calidadCard_Click(object sender, EventArgs e)
        {
            List<string> allSignatures = consulta("locacion(calidad,B,C)");
            
            foreach(string s in allSignatures)
                Console.WriteLine(s);

            materias.materiasCalidad(allSignatures);
            materias.ShowDialog();

            
        }

        private void documentadorCard_Click(object sender, EventArgs e)
        {
            List<string> allSignatures = consulta("locacion(documentador,B,C)");
            materias.materiasDocumentador(allSignatures);
            materias.ShowDialog();
            
        }

        private void backendCard_Click(object sender, EventArgs e)
        {
            List<string> allSignatures = consulta("locacion(backend,B,C)");
            materias.materiasBackend();
            materias.ShowDialog();
        }

        private void analistaCard_Click(object sender, EventArgs e)
        {
            List<string> allSignatures = consulta("locacion(analista,B,C)");
            materias.materiasAnalista();
            materias.ShowDialog();

        }

        private void adminbdCard_Click(object sender, EventArgs e)
        {
            List<string> allSignatures = consulta("locacion(administrador_de_base_de_datos,B,C)");
            materias.materiasABD(allSignatures);
            materias.ShowDialog();

            
        }

        private void testingCard_Click(object sender, EventArgs e)
        {
            List<string> allSignatures = consulta("locacion(testing,B,C)");
            
        }

        private void scrumMasterCard_Click(object sender, EventArgs e)
        {
            List<string> allSignatures = consulta("locacion(scrum,B,C)");
            
        }

        private void reportadorCard_Click(object sender, EventArgs e)
        {
            List<string> allSignatures = consulta("locacion(reporteador,B,C)");
        }

        private void redesDeComputadorasCard_Click(object sender, EventArgs e)
        {
            List<string> allSignatures = consulta("locacion(redes,B,C)");
            materias.materiasRedes();
            materias.ShowDialog();
        }

        private void projectOwnerCard_Click(object sender, EventArgs e)
        {
            List<string> allSignatures = consulta("locacion(owner,B,C)");
            materias.materiasOwner();
            materias.ShowDialog();

        }

        private void frontendCard_Click(object sender, EventArgs e)
        {
            List<string> allSignatures = consulta("locacion(frontend,B,C)");
            materias.materiasFrontend();
            materias.ShowDialog();

        }

        private void projectManagerCard_Click(object sender, EventArgs e)
        {
            List<string> allSignatures = consulta("locacion(manager,B,C)");
            materias.materiasManager();
        }
    }
}

