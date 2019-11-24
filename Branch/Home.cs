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
            if (contador < 8)
            {
                if (cbfundamentos.Checked == true)
                {
                    contador++;
                    cbfundamentos.BackColor = Color.FromArgb(255, 140, 0);
                }
                else
                {
                    cbfundamentos.BackColor = Color.FromArgb(13, 21, 57);
                }
            }
            else
            {
                MessageBox.Show("Haz alcanzado el número máximo de Materias Seleccionadas");
            }

        }

        private void CheckBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (contador < 8)
            {
                if (cbConmutacion.Checked == true)
                {
                    contador++;
                    cbConmutacion.BackColor = Color.FromArgb(124, 252, 0);
                }
                else
                {
                    cbConmutacion.BackColor = Color.FromArgb(13, 21, 57);
                }
            }
            else
            {
                MessageBox.Show("Haz alcanzado el número máximo de Materias Seleccionadas");
            }

        }

        private void CbLenjuages_CheckedChanged(object sender, EventArgs e)
        {
            if (contador < 8)
            {
                if (cbLenjuages.Checked == true)
                {
                    contador++;
                    cbLenjuages.BackColor = Color.FromArgb(255, 0, 205);
                }
                else
                {
                    cbLenjuages.BackColor = Color.FromArgb(13, 21, 57);
                }
            }
            else
            {
                MessageBox.Show("Haz alcanzado el número máximo de Materias Seleccionadas");
            }

        }

        private void CbProlog_CheckedChanged(object sender, EventArgs e)
        {
            if (contador < 8)
            {
                if (cbProlog.Checked == true)
                {
                    contador++;
                    cbProlog.BackColor = Color.FromArgb(255, 140, 0);
                }
                else
                {
                    cbProlog.BackColor = Color.FromArgb(13, 21, 57);
                }
            }
            else
            {
                MessageBox.Show("Haz alcanzado el número máximo de Materias Seleccionadas");
            }

        }

        private void CbArquitectura_CheckedChanged(object sender, EventArgs e)
        {
            if (contador < 8)
            {
                if (cbArquitectura.Checked == true)
                {
                    contador++;
                    cbArquitectura.BackColor = Color.FromArgb(123, 104, 238);
                }
                else
                {
                    cbArquitectura.BackColor = Color.FromArgb(13, 21, 57);
                }
            }
            else
            {
                MessageBox.Show("Haz alcanzado el número máximo de Materias Seleccionadas");
            }

        }

        private void CbMatDiscretas_CheckedChanged(object sender, EventArgs e)
        {
            if (contador < 8)
            {
                if (cbMatDiscretas.Checked == true)
                {
                    contador++;
                    cbMatDiscretas.BackColor = Color.FromArgb(147, 112, 219);
                }
                else
                {
                    cbMatDiscretas.BackColor = Color.FromArgb(13, 21, 57);
                }
            }
            else
            {
                MessageBox.Show("Haz alcanzado el número máximo de Materias Seleccionadas");
            }

        }

        private void CbTopicos_CheckedChanged(object sender, EventArgs e)
        {
            if (contador < 8)
            {
                if (cbTopicos.Checked == true)
                {
                    contador++;
                    cbTopicos.BackColor = Color.FromArgb(152, 251, 152);
                }
                else
                {
                    cbTopicos.BackColor = Color.FromArgb(13, 21, 57);
                }
            }
            else
            {
                MessageBox.Show("Haz alcanzado el número máximo de Materias Seleccionadas");
            }

        }

        private void CdEstructuradeDatos_CheckedChanged(object sender, EventArgs e)
        {
            if (contador < 8)
            {
                if (cdEstructuradeDatos.Checked == true)
                {
                    contador++;
                    cdEstructuradeDatos.BackColor = Color.FromArgb(102, 205, 170);
                }
                else
                {
                    cdEstructuradeDatos.BackColor = Color.FromArgb(13, 21, 57);
                }
            }
            else
            {
                MessageBox.Show("Haz alcanzado el número máximo de Materias Seleccionadas");
            }

        }

        private void CbSistemasOperativos_CheckedChanged(object sender, EventArgs e)
        {
            if (contador < 8)
            {
                if (cbSistemasOperativos.Checked == true)
                {
                    contador++;
                    cbSistemasOperativos.BackColor = Color.FromArgb(25, 207, 73);
                }
                else
                {
                    cbSistemasOperativos.BackColor = Color.FromArgb(13, 21, 57);
                }
            }
            else
            {
                MessageBox.Show("Haz alcanzado el número máximo de Materias Seleccionadas");
            }

        }

        private void CbRedes_CheckedChanged(object sender, EventArgs e)
        {
            if (contador < 8)
            {
                if (cbRedes.Checked == true)
                {
                    contador++;
                    cbRedes.BackColor = Color.FromArgb(218, 165, 32);
                }
                else
                {
                    cbRedes.BackColor = Color.FromArgb(13, 21, 57);
                }
            }
            else
            {
                MessageBox.Show("Haz alcanzado el número máximo de Materias Seleccionadas");
            }

        }

        private void CbMetNumericos_CheckedChanged(object sender, EventArgs e)
        {
            if (contador < 8)
            {
                if (cbMetNumericos.Checked == true)
                {
                    contador++;
                    cbMetNumericos.BackColor = Color.FromArgb(255, 127, 80);
                }
                else
                {
                    cbMetNumericos.BackColor = Color.FromArgb(13, 21, 57);
                }
            }
            else
            {
                MessageBox.Show("Haz alcanzado el número máximo de Materias Seleccionadas");
            }

        }

        private void CheckBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (contador < 8)
            {
                if (checkBox5.Checked == true)
                {
                    contador++;
                    checkBox5.BackColor = Color.FromArgb(188, 143, 143);
                }
                else
                {
                    checkBox5.BackColor = Color.FromArgb(13, 21, 57);
                }
            }
            else
            {
                MessageBox.Show("Haz alcanzado el número máximo de Materias Seleccionadas");
            }

        }

        private void CbSimulacion_CheckedChanged(object sender, EventArgs e)
        {
            if (contador < 8)
            {
                if (cbSimulacion.Checked == true)
                {
                    contador++;
                    cbSimulacion.BackColor = Color.FromArgb(244, 164, 96);
                }
                else
                {
                    cbSimulacion.BackColor = Color.FromArgb(13, 21, 57);
                }
            }
            else
            {
                MessageBox.Show("Haz alcanzado el número máximo de Materias Seleccionadas");
            }

        }

        private void CbBD_CheckedChanged(object sender, EventArgs e)
        {
            if (contador < 8)
            {
                if (cbBD.Checked == true)
                {
                    contador++;
                    cbBD.BackColor = Color.FromArgb(30, 155, 255);
                }
                else
                {
                    cbBD.BackColor = Color.FromArgb(13, 21, 57);
                }
            }
            else
            {
                MessageBox.Show("Haz alcanzado el número máximo de Materias Seleccionadas");
            }

        }

        private void CbPrincipiosElectricos_CheckedChanged(object sender, EventArgs e)
        {
            if (contador < 8)
            {
                if (cbPrincipiosElectricos.Checked == true)
                {
                    contador++;
                    cbPrincipiosElectricos.BackColor = Color.FromArgb(60, 179, 113);
                }
                else
                {
                    cbPrincipiosElectricos.BackColor = Color.FromArgb(13, 21, 57);
                }
            }
            else
            {
                MessageBox.Show("Haz alcanzado el número máximo de Materias Seleccionadas");
            }

        }

        private void CbGPS_CheckedChanged(object sender, EventArgs e)
        {
            if (contador < 8)
            {
                if (cbGPS.Checked == true)
                {
                    contador++;
                    cbGPS.BackColor = Color.FromArgb(255, 190, 0);
                }
                else
                {
                    cbGPS.BackColor = Color.FromArgb(13, 21, 57);
                }
            }
            else
            {
                MessageBox.Show("Haz alcanzado el número máximo de Materias Seleccionadas");
            }

        }

        private void CbSoftware_CheckedChanged(object sender, EventArgs e)
        {
            if (contador < 8)
            {
                if (cbSoftware.Checked == true)
                {
                    contador++;
                    cbSoftware.BackColor = Color.FromArgb(238, 130, 238);
                }
                else
                {
                    cbSoftware.BackColor = Color.FromArgb(13, 21, 57);
                }
            }
            else
            {
                MessageBox.Show("Haz alcanzado el número máximo de Materias Seleccionadas");
            }

        }

        private void CbTelecom_CheckedChanged(object sender, EventArgs e)
        {
            if (contador < 8)
            {
                if (cbTelecom.Checked == true)
                {
                    contador++;
                    cbTelecom.BackColor = Color.FromArgb(240, 128, 128);
                }
                else
                {
                    cbTelecom.BackColor = Color.FromArgb(13, 21, 57);
                }
            }
            else
            {
                MessageBox.Show("Haz alcanzado el número máximo de Materias Seleccionadas");
            }

        }

        private void CheckBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (contador < 8)
            {
                if (checkBox6.Checked == true)
                {
                    contador++;
                    checkBox6.BackColor = Color.FromArgb(255, 160, 122);
                }
                else
                {
                    checkBox6.BackColor = Color.FromArgb(13, 21, 57);
                }
            }
            else
            {
                MessageBox.Show("Haz alcanzado el número máximo de Materias Seleccionadas");
            }

        }

        private void CbSistemasProgramables_CheckedChanged(object sender, EventArgs e)
        {
            if (contador < 8)
            {
                if (cbSistemasProgramables.Checked == true)
                {
                    contador++;
                    cbSistemasProgramables.BackColor = Color.FromArgb(216, 11, 216);
                }
                else
                {
                    cbSistemasProgramables.BackColor = Color.FromArgb(13, 21, 57);
                }
            }
            else
            {
                MessageBox.Show("Haz alcanzado el número máximo de Materias Seleccionadas");
            }

        }

        private void CbLenguajesAtomatas_CheckedChanged(object sender, EventArgs e)
        {
            if (contador < 8)
            {
                if (cbLenguajesAtomatas.Checked == true)
                {
                    contador++;
                    cbLenguajesAtomatas.BackColor = Color.FromArgb(10, 255, 47);
                }
                else
                {
                    cbLenguajesAtomatas.BackColor = Color.FromArgb(13, 21, 57);
                }
            }
            else
            {
                MessageBox.Show("Haz alcanzado el número máximo de Materias Seleccionadas");
            }

        }

        private void CbProgramacionBD_CheckedChanged(object sender, EventArgs e)
        {
            if (contador < 8)
            {
                if (cbProgramacionBD.Checked == true)
                {
                    contador++;
                    cbProgramacionBD.BackColor = Color.FromArgb(152, 251, 12);
                }
                else
                {
                    cbProgramacionBD.BackColor = Color.FromArgb(13, 21, 57);
                }
            }
            else
            {
                MessageBox.Show("Haz alcanzado el número máximo de Materias Seleccionadas");
            }

        }

        private void CbAdminRedes_CheckedChanged(object sender, EventArgs e)
        {
            if (contador < 8)
            {
                if (cbAdminRedes.Checked == true)
                {
                    contador++;
                    cbAdminRedes.BackColor = Color.FromArgb(0, 255, 255);
                }
                else
                {
                    cbAdminRedes.BackColor = Color.FromArgb(13, 21, 57);
                }
            }
            else
            {
                MessageBox.Show("Haz alcanzado el número máximo de Materias Seleccionadas");
            }

        }

        private void CbGestores_CheckedChanged(object sender, EventArgs e)
        {
            if (contador < 8)
            {
                if (cbGestores.Checked == true)
                {
                    contador++;
                    cbGestores.BackColor = Color.FromArgb(0, 206, 209);
                }
                else
                {
                    cbGestores.BackColor = Color.FromArgb(13, 21, 57);
                }
            }
            else
            {
                MessageBox.Show("Haz alcanzado el número máximo de Materias Seleccionadas");
            }

        }

        private void CbIA_CheckedChanged(object sender, EventArgs e)
        {
            if (contador < 8)
            {
                if (cbIA.Checked == true)
                {
                    contador++;
                    cbIA.BackColor = Color.FromArgb(244, 164, 96);
                }
                else
                {
                    cbIA.BackColor = Color.FromArgb(13, 21, 57);
                }
            }
            else
            {
                MessageBox.Show("Haz alcanzado el número máximo de Materias Seleccionadas");
            }

        }

        private void CbAdminServidores_CheckedChanged(object sender, EventArgs e)
        {
            if (contador < 8)
            {
                if (cbAdminServidores.Checked == true)
                {
                    contador++;
                    cbAdminServidores.BackColor = Color.FromArgb(0, 255, 127);
                }
                else
                {
                    cbAdminServidores.BackColor = Color.FromArgb(13, 21, 57);
                }
            }
            else
            {
                MessageBox.Show("Haz alcanzado el número máximo de Materias Seleccionadas");
            }

        }

        private void CbWeb_CheckedChanged(object sender, EventArgs e)
        {
            if (contador < 8)
            {
                if (cbWeb.Checked == true)
                {
                    contador++;
                    cbWeb.BackColor = Color.FromArgb(143, 188, 139);
                }
                else
                {
                    cbWeb.BackColor = Color.FromArgb(13, 21, 57);
                }
            }
            else
            {
                MessageBox.Show("Haz alcanzado el número máximo de Materias Seleccionadas");
            }

        }

        private void CbPoo_CheckedChanged(object sender, EventArgs e)
        {
            if (contador < 8)
            {
                if (cbPoo.Checked == true)
                {
                    contador++;
                    cbPoo.BackColor = Color.FromArgb(255, 140, 0);
                }
                else
                {
                    cbPoo.BackColor = Color.FromArgb(13, 21, 57);
                }
            }
            else
            {
                MessageBox.Show("Haz alcanzado el número máximo de Materias Seleccionadas");
            }

        }

        private void CbDispositivos_CheckedChanged(object sender, EventArgs e)
        {
            if (contador < 8)
            {
                if (cbDispositivos.Checked == true)
                {
                    contador++;
                    cbDispositivos.BackColor = Color.FromArgb(0, 191, 255);
                }
                else
                {
                    cbDispositivos.BackColor = Color.FromArgb(13, 21, 57);
                }
            }
            else
            {
                MessageBox.Show("Haz alcanzado el número máximo de Materias Seleccionadas");
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

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}

