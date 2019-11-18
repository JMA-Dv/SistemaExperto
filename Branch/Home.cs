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
                string[] data = { "-q", "-f", @"base_de_conocimiento.pl" };
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

        private void GroupMaterias_Enter(object sender, EventArgs e)
        {

        }

        private void BarraContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbfundamentos.Checked == true)
            {
                cbfundamentos.BackColor = Color.FromArgb(255, 140, 0);
            }
            else
            {
                cbfundamentos.BackColor = Color.FromArgb(13, 21, 57);
            }
        }

        private void CheckBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (cbConmutacion.Checked == true)
            {
                cbConmutacion.BackColor = Color.FromArgb(124, 252, 0);
            }
            else
            {
                cbConmutacion.BackColor = Color.FromArgb(13, 21, 57);
            }
        }

        private void CbLenjuages_CheckedChanged(object sender, EventArgs e)
        {
            if (cbLenjuages.Checked == true)
            {
                cbLenjuages.BackColor = Color.FromArgb(255, 0, 205);
            }
            else
            {
                cbLenjuages.BackColor = Color.FromArgb(13, 21, 57);
            }
        }

        private void CbProlog_CheckedChanged(object sender, EventArgs e)
        {
            if (cbProlog.Checked == true)
            {
                cbProlog.BackColor = Color.FromArgb(255, 140, 0);
            }
            else
            {
                cbProlog.BackColor = Color.FromArgb(13, 21, 57);
            }
        }

        private void CbArquitectura_CheckedChanged(object sender, EventArgs e)
        {
            if (cbArquitectura.Checked == true)
            {
                cbArquitectura.BackColor = Color.FromArgb(123, 104, 238);
            }
            else
            {
                cbArquitectura.BackColor = Color.FromArgb(13, 21, 57);
            }
        }

        private void CbMatDiscretas_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMatDiscretas.Checked == true)
            {
                cbMatDiscretas.BackColor = Color.FromArgb(147, 112, 219);
            }
            else
            {
                cbMatDiscretas.BackColor = Color.FromArgb(13, 21, 57);
            }
        }

        private void CbTopicos_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTopicos.Checked == true)
            {
                cbTopicos.BackColor = Color.FromArgb(152, 251, 152);
            }
            else
            {
                cbTopicos.BackColor = Color.FromArgb(13, 21, 57);
            }
        }

        private void CdEstructuradeDatos_CheckedChanged(object sender, EventArgs e)
        {
            if (cdEstructuradeDatos.Checked == true)
            {
                cdEstructuradeDatos.BackColor = Color.FromArgb(102, 205, 170);
            }
            else
            {
                cdEstructuradeDatos.BackColor = Color.FromArgb(13, 21, 57);
            }
        }

        private void CbSistemasOperativos_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSistemasOperativos.Checked == true)
            {
                cbSistemasOperativos.BackColor = Color.FromArgb(25, 207, 73);
            }
            else
            {
                cbSistemasOperativos.BackColor = Color.FromArgb(13, 21, 57);
            }
        }

        private void CbRedes_CheckedChanged(object sender, EventArgs e)
        {
            if (cbRedes.Checked == true)
            {
                cbRedes.BackColor = Color.FromArgb(218, 165, 32);
            }
            else
            {
                cbRedes.BackColor = Color.FromArgb(13, 21, 57);
            }
        }

        private void CbMetNumericos_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMetNumericos.Checked == true)
            {
                cbMetNumericos.BackColor = Color.FromArgb(255, 127, 80);
            }
            else
            {
                cbMetNumericos.BackColor = Color.FromArgb(13, 21, 57);
            }
        }

        private void CheckBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                checkBox5.BackColor = Color.FromArgb(188, 143, 143);
            }
            else
            {
                checkBox5.BackColor = Color.FromArgb(13, 21, 57);
            }
        }

        private void CbSimulacion_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSimulacion.Checked == true)
            {
                cbSimulacion.BackColor = Color.FromArgb(244, 164, 96);
            }
            else
            {
                cbSimulacion.BackColor = Color.FromArgb(13, 21, 57);
            }
        }

        private void CbBD_CheckedChanged(object sender, EventArgs e)
        {
            if (cbBD.Checked == true)
            {
                cbBD.BackColor = Color.FromArgb(30, 155, 255);
            }
            else
            {
                cbBD.BackColor = Color.FromArgb(13, 21, 57);
            }
        }

        private void CbPrincipiosElectricos_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPrincipiosElectricos.Checked == true)
            {
                cbPrincipiosElectricos.BackColor = Color.FromArgb(60, 179, 113);
            }
            else
            {
                cbPrincipiosElectricos.BackColor = Color.FromArgb(13, 21, 57);
            }
        }

        private void CbGPS_CheckedChanged(object sender, EventArgs e)
        {
            if (cbGPS.Checked == true)
            {
                cbGPS.BackColor = Color.FromArgb(255, 190, 0);
            }
            else
            {
                cbGPS.BackColor = Color.FromArgb(13, 21, 57);
            }
        }

        private void CbSoftware_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSoftware.Checked == true)
            {
                cbSoftware.BackColor = Color.FromArgb(238, 130, 238);
            }
            else
            {
                cbSoftware.BackColor = Color.FromArgb(13, 21, 57);
            }
        }

        private void CbTelecom_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTelecom.Checked == true)
            {
                cbTelecom.BackColor = Color.FromArgb(240, 128, 128);
            }
            else
            {
                cbTelecom.BackColor = Color.FromArgb(13, 21, 57);
            }
        }

        private void CheckBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                checkBox6.BackColor = Color.FromArgb(255, 160, 122);
            }
            else
            {
                checkBox6.BackColor = Color.FromArgb(13, 21, 57);
            }
        }

        private void CbSistemasProgramables_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSistemasProgramables.Checked == true)
            {
                cbSistemasProgramables.BackColor = Color.FromArgb(216, 11, 216);
            }
            else
            {
                cbSistemasProgramables.BackColor = Color.FromArgb(13, 21, 57);
            }
        }

        private void CbLenguajesAtomatas_CheckedChanged(object sender, EventArgs e)
        {
            if (cbLenguajesAtomatas.Checked == true)
            {
                cbLenguajesAtomatas.BackColor = Color.FromArgb(10, 255, 47);
            }
            else
            {
                cbLenguajesAtomatas.BackColor = Color.FromArgb(13, 21, 57);
            }
        }

        private void CbProgramacionBD_CheckedChanged(object sender, EventArgs e)
        {
            if (cbProgramacionBD.Checked == true)
            {
                cbProgramacionBD.BackColor = Color.FromArgb(152, 251, 12);
            }
            else
            {
                cbProgramacionBD.BackColor = Color.FromArgb(13, 21, 57);
            }
        }

        private void CbAdminRedes_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAdminRedes.Checked == true)
            {
                cbAdminRedes.BackColor = Color.FromArgb(0, 255, 255);
            }
            else
            {
                cbAdminRedes.BackColor = Color.FromArgb(13, 21, 57);
            }
        }

        private void CbGestores_CheckedChanged(object sender, EventArgs e)
        {
            if (cbGestores.Checked == true)
            {
                cbGestores.BackColor = Color.FromArgb(0, 206, 209);
            }
            else
            {
                cbGestores.BackColor = Color.FromArgb(13, 21, 57);
            }
        }

        private void CbIA_CheckedChanged(object sender, EventArgs e)
        {
            if (cbIA.Checked == true)
            {
                cbIA.BackColor = Color.FromArgb(244, 164, 96);
            }
            else
            {
                cbIA.BackColor = Color.FromArgb(13, 21, 57);
            }
        }

        private void CbAdminServidores_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAdminServidores.Checked == true)
            {
                cbAdminServidores.BackColor = Color.FromArgb(0, 255, 127);
            }
            else
            {
                cbAdminServidores.BackColor = Color.FromArgb(13, 21, 57);
            }
        }

        private void CbWeb_CheckedChanged(object sender, EventArgs e)
        {
            if (cbWeb.Checked == true)
            {
                cbWeb.BackColor = Color.FromArgb(143, 188, 139);
            }
            else
            {
                cbWeb.BackColor = Color.FromArgb(13, 21, 57);
            }
        }

        private void CbPoo_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPoo.Checked == true)
            {
                cbPoo.BackColor = Color.FromArgb(255, 140, 0);
            }
            else
            {
                cbPoo.BackColor = Color.FromArgb(13, 21, 57);
            }
        }

        private void CbDispositivos_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDispositivos.Checked == true)
            {
                cbDispositivos.BackColor = Color.FromArgb(0, 191, 255);
            }
            else
            {
                cbDispositivos.BackColor = Color.FromArgb(13, 21, 57);
            }
        }

        private void Bresultados_Click(object sender, EventArgs e)
        {
            
            Form1 res = new Form1();
            res.Show();

        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
    }

