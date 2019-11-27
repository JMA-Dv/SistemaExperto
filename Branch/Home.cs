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
            catch (Exception)
            {

            }

        }
        public List<String> consult(string context)
        {
            List<String> allElements = new List<String>();
            PlQuery generalConsult = new PlQuery(context);
            foreach (PlQueryVariables elements in generalConsult.SolutionVariables)
            {
                allElements.Add(elements["B"].ToString());
                allElements.Add(elements["C"].ToString());

            }

            return allElements;
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

        private void calidadCard_Click(object sender, EventArgs e)
        {
            List<String> li = consult("locacion(analista,B,C)");
            foreach (string el in li)
                Console.WriteLine(el);

            Form1 res = new Form1();
            res.ShowDialog();
        }

        private void documentadorCard_Click(object sender, EventArgs e)
        {
            List<String> documentadorList = consult("locacion(documentador,B,C)");

        }

        private void backendCard_Click(object sender, EventArgs e)
        {
            List<String> backendList = consult("locacion(backend,B,C)");

        }

        private void analistaCard_Click(object sender, EventArgs e)
        {
            List<String> backendList = consult("locacion(analista,B,C)");

        }

        private void abdCard_Click(object sender, EventArgs e)
        {
            List<String> backendList = consult("locacion(abd,B,C)");
        }

        private void testingCard_Click(object sender, EventArgs e)
        {
            List<String> backendList = consult("locacion(testing,B,C)");
        }

        private void scumMCard_Click(object sender, EventArgs e)
        {
            List<String> backendList = consult("locacion(scrum,B,C)");
        }

        private void reporteadorCards_Click(object sender, EventArgs e)
        {
            List<String> backendList = consult("locacion(reporteador,B,C)");
        }

        private void redesCard_Click(object sender, EventArgs e)
        {
            List<String> backendList = consult("locacion(redes,B,C)");
        }

        private void projectOwnerCard_Click(object sender, EventArgs e)
        {
            List<String> backendList = consult("locacion(owner,B,C)");
        }

        private void frontCard_Click(object sender, EventArgs e)
        {
            List<String> backendList = consult("locacion(frontend,B,C)");
        }

        private void projectManagerCard_Click(object sender, EventArgs e)
        {
            List<String> backendList = consult("locacion(manager,B,C)");
        }
    }
}

