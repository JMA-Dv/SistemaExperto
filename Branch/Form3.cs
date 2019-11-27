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
    public partial class Form3 : Form
    {
        int contador = 0;
        public Form3()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void CerrarVentana_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdminBD_CheckedChanged(object sender, EventArgs e)
        {
            if(contador > 8)
            {
                MessageBox.Show("Materias seleccionadas al limite");
            }
            else
            {
                contador++;
            }
            if(AdminBD.Checked == true)
            {
                AdminBD.BackColor = Color.FromArgb(0,255,127);
            }
            else
            {
                AdminBD.BackColor = Color.Black;
            }
        }

        private void AdminRedes_CheckedChanged(object sender, EventArgs e)
        {
            if (contador > 8)
            {
                MessageBox.Show("Materias seleccionadas al limite");
            }
            else
            {
                contador++;
            }
            if (AdminRedes.Checked == true)
            {
                AdminRedes.BackColor = Color.FromArgb(0, 255, 127);
            }
            else
            {
                AdminRedes.BackColor = Color.Black;
            }
        }

        private void AdminServidores_CheckedChanged(object sender, EventArgs e)
        {
            if (contador > 8)
            {
                MessageBox.Show("Materias seleccionadas al limite");
            }
            else
            {
                contador++;
            }
            if (AdminServidores.Checked == true)
            {
                AdminServidores.BackColor = Color.FromArgb(0, 255, 127);
            }
            else
            {
                AdminServidores.BackColor = Color.Black;
            }
        }

        private void ArquitecturaComputadoras_CheckedChanged(object sender, EventArgs e)
        {
            if (contador > 8)
            {
                MessageBox.Show("Materias seleccionadas al limite");
            }
            else
            {
                contador++;
            }
            if (ArquitecturaComputadoras.Checked == true)
            {
                ArquitecturaComputadoras.BackColor = Color.FromArgb(0, 255, 127);
            }
            else
            {
                ArquitecturaComputadoras.BackColor = Color.Black;
            }
        }

        private void BDmoviles_CheckedChanged(object sender, EventArgs e)
        {
            if (contador > 8)
            {
                MessageBox.Show("Materias seleccionadas al limite");
            }
            else
            {
                contador++;
            }
            if (BDmoviles.Checked == true)
            {
                BDmoviles.BackColor = Color.FromArgb(0, 255, 127);
            }
            else
            {
                BDmoviles.BackColor = Color.Black;
            }
        }

        private void ConmutacionRedes_CheckedChanged(object sender, EventArgs e)
        {
            if (contador > 8)
            {
                MessageBox.Show("Materias seleccionadas al limite");
            }
            else
            {
                contador++;
            }
            if (ConmutacionRedes.Checked == true)
            {
                ConmutacionRedes.BackColor = Color.FromArgb(0, 255, 127);
            }
            else
            {
                ConmutacionRedes.BackColor = Color.Black;
            }
        }

        private void EstructuraDatos_CheckedChanged(object sender, EventArgs e)
        {
            if (contador > 8)
            {
                MessageBox.Show("Materias seleccionadas al limite");
            }
            else
            {
                contador++;
            }
            if (EstructuraDatos.Checked == true)
            {
                EstructuraDatos.BackColor = Color.FromArgb(0, 255, 127);
            }
            else
            {
                EstructuraDatos.BackColor = Color.Black;
            }
        }

        private void FundamentosBD_CheckedChanged(object sender, EventArgs e)
        {
            if (contador > 8)
            {
                MessageBox.Show("Materias seleccionadas al limite");
            }
            else
            {
                contador++;
            }
            if (FundamentosBD.Checked == true)
            {
                FundamentosBD.BackColor = Color.FromArgb(0, 255, 127);
            }
            else
            {
                FundamentosBD.BackColor = Color.Black;
            }
        }

        private void FundamentosIS_CheckedChanged(object sender, EventArgs e)
        {
            if (contador > 8)
            {
                MessageBox.Show("Materias seleccionadas al limite");
            }
            else
            {
                contador++;
            }
            if (FundamentosIS.Checked == true)
            {
                FundamentosIS.BackColor = Color.FromArgb(0, 255, 127);
            }
            else
            {
                FundamentosIS.BackColor = Color.Black;
            }
        }

        private void FundamentosProgram_CheckedChanged(object sender, EventArgs e)
        {
            if (contador > 8)
            {
                MessageBox.Show("Materias seleccionadas al limite");
            }
            else
            {
                contador++;
            }
            if (FundamentosProgram.Checked == true)
            {
                FundamentosProgram.BackColor = Color.FromArgb(0, 255, 127);
            }
            else
            {
                FundamentosProgram.BackColor = Color.Black;
            }
        }

        private void GPS_CheckedChanged(object sender, EventArgs e)
        {
            if (contador > 8)
            {
                MessageBox.Show("Materias seleccionadas al limite");
            }
            else
            {
                contador++;
            }
            if (GPS.Checked == true)
            {
                GPS.BackColor = Color.FromArgb(0, 255, 127);
            }
            else
            {
                GPS.BackColor = Color.Black;
            }
        }

        private void Graficacion_CheckedChanged(object sender, EventArgs e)
        {
            if (contador > 8)
            {
                MessageBox.Show("Materias seleccionadas al limite");
            }
            else
            {
                contador++;
            }
            if (Graficacion.Checked == true)
            {
                Graficacion.BackColor = Color.FromArgb(0, 255, 127);
            }
            else
            {
                Graficacion.BackColor = Color.Black;
            }
        }

        private void IA_CheckedChanged(object sender, EventArgs e)
        {
            if (contador > 8)
            {
                MessageBox.Show("Materias seleccionadas al limite");
            }
            else
            {
                contador++;
            }
            if (IA.Checked == true)
            {
                IA.BackColor = Color.FromArgb(0, 255, 127);
            }
            else
            {
                IA.BackColor = Color.Black;
            }
        }

        private void LenguajesInterfaz_CheckedChanged(object sender, EventArgs e)
        {
            if (contador > 8)
            {
                MessageBox.Show("Materias seleccionadas al limite");
            }
            else
            {
                contador++;
            }
            if (LenguajesInterfaz.Checked == true)
            {
                LenguajesInterfaz.BackColor = Color.FromArgb(0, 255, 127);
            }
            else
            {
                LenguajesInterfaz.BackColor = Color.Black;
            }
        }

        private void LenguajesAutomatas_CheckedChanged(object sender, EventArgs e)
        {
            if (contador > 8)
            {
                MessageBox.Show("Materias seleccionadas al limite");
            }
            else
            {
                contador++;
            }
            if (LenguajesAutomatas.Checked == true)
            {
                LenguajesAutomatas.BackColor = Color.FromArgb(0, 255, 127);
            }
            else
            {
                LenguajesAutomatas.BackColor = Color.Black;
            }
        }

        private void MatesDiscretas_CheckedChanged(object sender, EventArgs e)
        {
            if (contador > 8)
            {
                MessageBox.Show("Materias seleccionadas al limite");
            }
            else
            {
                contador++;
            }
            if (MatesDiscretas.Checked == true)
            {
                MatesDiscretas.BackColor = Color.FromArgb(0, 255, 127);
            }
            else
            {
                MatesDiscretas.BackColor = Color.Black;
            }
        }

        private void Poo_CheckedChanged(object sender, EventArgs e)
        {
            if (contador > 8)
            {
                MessageBox.Show("Materias seleccionadas al limite");
            }
            else
            {
                contador++;
            }
            if (Poo.Checked == true)
            {
                Poo.BackColor = Color.FromArgb(0, 255, 127);
            }
            else
            {
                Poo.BackColor = Color.Black;
            }
        }

        private void ProgramacionDB_CheckedChanged(object sender, EventArgs e)
        {
            if (contador > 8)
            {
                MessageBox.Show("Materias seleccionadas al limite");
            }
            else
            {
                contador++;
            }
            if (ProgramacionDB.Checked == true)
            {
                ProgramacionDB.BackColor = Color.FromArgb(0, 255, 127);
            }
            else
            {
                ProgramacionDB.BackColor = Color.Black;
            }
        }

        private void LenguajesAutomatas2_CheckedChanged(object sender, EventArgs e)
        {
            if (contador > 8)
            {
                MessageBox.Show("Materias seleccionadas al limite");
            }
            else
            {
                contador++;
            }
            if (LenguajesAutomatas2.Checked == true)
            {
                LenguajesAutomatas2.BackColor = Color.FromArgb(0, 255, 127);
            }
            else
            {
                LenguajesAutomatas2.BackColor = Color.Black;
            }
        }

        private void Prolog_CheckedChanged(object sender, EventArgs e)
        {
            if (contador > 8)
            {
                MessageBox.Show("Materias seleccionadas al limite");
            }
            else
            {
                contador++;
            }
            if (Prolog.Checked == true)
            {
                Prolog.BackColor = Color.FromArgb(0, 255, 127);
            }
            else
            {
                Prolog.BackColor = Color.Black;
            }
        }

        private void ProgramacionWeb_CheckedChanged(object sender, EventArgs e)
        {
            if (contador > 8)
            {
                MessageBox.Show("Materias seleccionadas al limite");
            }
            else
            {
                contador++;
            }
            if (ProgramacionWeb.Checked == true)
            {
                ProgramacionWeb.BackColor = Color.FromArgb(0, 255, 127);
            }
            else
            {
                ProgramacionWeb.BackColor = Color.Black;
            }
        }

        private void RedesComputadoras_CheckedChanged(object sender, EventArgs e)
        {
            if (contador > 8)
            {
                MessageBox.Show("Materias seleccionadas al limite");
            }
            else
            {
                contador++;
            }
            if (RedesComputadoras.Checked == true)
            {
                RedesComputadoras.BackColor = Color.FromArgb(0, 255, 127);
            }
            else
            {
                RedesComputadoras.BackColor = Color.Black;
            }
        }

        private void SistemasProgramables_CheckedChanged(object sender, EventArgs e)
        {
            if (contador > 8)
            {
                MessageBox.Show("Materias seleccionadas al limite");
            }
            else
            {
                contador++;
            }
            if (SistemasProgramables.Checked == true)
            {
                SistemasProgramables.BackColor = Color.FromArgb(0, 255, 127);
            }
            else
            {
                SistemasProgramables.BackColor = Color.Black;
            }
        }

        private void SistemasOperativos_CheckedChanged(object sender, EventArgs e)
        {
            if (contador > 8)
            {
                MessageBox.Show("Materias seleccionadas al limite");
            }
            else
            {
                contador++;
            }
            if (SistemasOperativos.Checked == true)
            {
                SistemasOperativos.BackColor = Color.FromArgb(0, 255, 127);
            }
            else
            {
                SistemasOperativos.BackColor = Color.Black;
            }
        }

        private void TallerInvestigacion_CheckedChanged(object sender, EventArgs e)
        {
            if (contador > 8)
            {
                MessageBox.Show("Materias seleccionadas al limite");
            }
            else
            {
                contador++;
            }
            if (TallerInvestigacion.Checked == true)
            {
                TallerInvestigacion.BackColor = Color.FromArgb(0, 255, 127);
            }
            else
            {
                TallerInvestigacion.BackColor = Color.Black;
            }
        }

        private void TallerInvestigacion2_CheckedChanged(object sender, EventArgs e)
        {
            if (contador > 8)
            {
                MessageBox.Show("Materias seleccionadas al limite");
            }
            else
            {
                contador++;
            }
            if (TallerInvestigacion2.Checked == true)
            {
                TallerInvestigacion2.BackColor = Color.FromArgb(0, 255, 127);
            }
            else
            {
                TallerInvestigacion2.BackColor = Color.Black;
            }
        }

        private void TallerSO_CheckedChanged(object sender, EventArgs e)
        {
            if (contador > 8)
            {
                MessageBox.Show("Materias seleccionadas al limite");
            }
            else
            {
                contador++;
            }
            if (TallerSO.Checked == true)
            {
                TallerSO.BackColor = Color.FromArgb(0, 255, 127);
            }
            else
            {
                TallerSO.BackColor = Color.Black;
            }
        }

        private void TAP_CheckedChanged(object sender, EventArgs e)
        {
            if (contador > 8)
            {
                MessageBox.Show("Materias seleccionadas al limite");
            }
            else
            {
                contador++;
            }
            if (TAP.Checked == true)
            {
                TAP.BackColor = Color.FromArgb(0, 255, 127);
            }
            else
            {
                TAP.BackColor = Color.Black;
            }
        }

        private void Telecom_CheckedChanged(object sender, EventArgs e)
        {
            if (contador > 8)
            {
                MessageBox.Show("Materias seleccionadas al limite");
            }
            else
            {
                contador++;
            }
            if (Telecom.Checked == true)
            {
                Telecom.BackColor = Color.FromArgb(0, 255, 127);
            }
            else
            {
                Telecom.BackColor = Color.Black;
            }
        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
