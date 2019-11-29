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
    public partial class Form3 : Form
    {
        int contador = 0;
        private string[] areas = { "redes" ,"tester","documentador"};
        public Form3()
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

        public void materiasABD(List<string> materias)
        {
            unableButtons();
            invisiblecomponents();
            MatesDiscretas.Visible = true;
            Poo.Visible = true;
            SistemasOperativos.Visible = true;
            FundamentosBD.Visible = true;
            AdminBD.Visible = true;
            ProgramacionDB.Visible = true;
            BDmoviles.Visible = true;
        }

        public void materiasDocumentador(List<string> materias)
        {
            unableButtons();
            invisiblecomponents();
            MatesDiscretas.Visible = true;
            Poo.Visible = true;
            SistemasOperativos.Visible = true;
            FundamentosBD.Visible = true;
            FundamentosIS.Visible = true;
            GPS.Visible = true;
            AdminBD.Visible = true;
            ProgramacionDB.Visible = true;
            BDmoviles.Visible = true;
            TallerInvestigacion.Visible = true;
            TallerInvestigacion2.Visible = true;

        }
        public void materiasOwner()
        {
            unableButtons();
            invisiblecomponents();
            FundamentosProgram.Visible = true;
            GPS.Visible = true;
            TallerInvestigacion.Visible = true;
            TallerInvestigacion2.Visible = true;
            MatesDiscretas.Visible = true;
            FundamentosProgram.Visible = true;
            FundamentosBD.Visible = true;
            FundamentosIS.Visible = true;

        }

        public void materiasManager()
        {
            unableButtons();
            invisiblecomponents();
            FundamentosProgram.Visible = true;
            GPS.Visible = true;
            TallerInvestigacion.Visible = true;
            TallerInvestigacion2.Visible = true;
            MatesDiscretas.Visible = true;
            FundamentosProgram.Visible = true;
            FundamentosBD.Visible = true;
            FundamentosIS.Visible = true;
        }

        public void materiasCalidad(List<string> materias)
        {
            invisiblecomponents();

            FundamentosProgram.Visible = true;
            SistemasOperativos.Visible = true;
            TallerSO.Visible = true;
            TAP.Visible = true;
            FundamentosIS.Visible = true;
            GPS.Visible = true;
            TallerInvestigacion.Visible = true;
            TallerInvestigacion2.Visible = true;
        }

        public void materiasFrontend()
        {
            invisiblecomponents();
            MatesDiscretas.Visible = true;
            Graficacion.Visible = true;
            SistemasOperativos.Visible = true;
            TallerSO.Visible = true;
            FundamentosIS.Visible = true;
            GPS.Visible = true;
            TallerInvestigacion.Visible = true;
            TallerInvestigacion2.Visible = true;

        }

        public void materiasBackend()
        {
            invisiblecomponents();
            Poo.Visible = true;
            LenguajesAutomatas.Visible = true;
            LenguajesAutomatas2.Visible = true;
            FundamentosBD.Visible = true;
            BDmoviles.Visible = true;
            TallerInvestigacion.Visible = true;
            TallerInvestigacion2.Visible = true;
            EstructuraDatos.Visible = true;
        }
        public void materiasAnalista()
        {
            invisiblecomponents();
            FundamentosIS.Visible = true;
            GPS.Visible = true;
            MatesDiscretas.Visible = true;
            FundamentosProgram.Visible = true;
            TallerInvestigacion.Visible = true;
            TallerInvestigacion2.Visible = true;
            FundamentosBD.Visible = true;
        }
        public void materiasRedes()
        {
            invisiblecomponents();
            SistemasOperativos.Visible = true;
            TallerSO.Visible = true;
            Telecom.Visible = true;
            ArquitecturaComputadoras.Visible = true;
            RedesComputadoras.Visible = true;
            ConmutacionRedes.Visible = true;
            AdminRedes.Visible = true;
            AdminServidores.Visible = true;

        }
        public void invisiblecomponents()
        {
            AdminBD.Visible = false;
            MatesDiscretas.Visible = false;
            AdminRedes.Visible = false;
            ArquitecturaComputadoras.Visible = false;
            AdminServidores.Visible = false;
            BDmoviles.Visible = false;
            ConmutacionRedes.Visible = false;
            EstructuraDatos.Visible = false;
            FundamentosProgram.Visible = false;
            Poo.Visible = false;
            SistemasOperativos.Visible = false;
            FundamentosBD.Visible = false;
            TallerSO.Visible = false;
            Telecom.Visible = false;
            BDmoviles.Visible = false;
            TallerInvestigacion.Visible = false;
            TallerInvestigacion2.Visible = false;
            Prolog.Visible = false;
            ProgramacionDB.Visible = false;
            ProgramacionWeb.Visible = false;
            GPS.Visible = false;
            FundamentosIS.Visible = false;
            Graficacion.Visible = false;
            RedesComputadoras.Visible = false;
            SistemasProgramables.Visible = false;
            LenguajesAutomatas.Visible = false;
            LenguajesAutomatas2.Visible = false;
            IA.Visible = false;

        }
        public void unableButtons()
        {
            AdminBD.Enabled = false;
            MatesDiscretas.Enabled = false;
            AdminRedes.Enabled = false;
            ArquitecturaComputadoras.Enabled = false;
            AdminServidores.Enabled = false;
            BDmoviles.Enabled = false;
            ConmutacionRedes.Enabled = false;
            EstructuraDatos.Enabled = false;
            FundamentosProgram.Enabled = false;
            Poo.Enabled = false;
            SistemasOperativos.Enabled = false;
            FundamentosBD.Enabled = false;
            TallerSO.Enabled = false;
            Telecom.Enabled = false;
            BDmoviles.Enabled = false;
            TallerInvestigacion.Enabled = false;
            TallerInvestigacion2.Enabled = false;
            Prolog.Enabled = false;
            ProgramacionDB.Enabled = false;
            ProgramacionWeb.Enabled = false;
            GPS.Enabled = false;
            FundamentosIS.Enabled = false;
            Graficacion.Enabled = false;
            RedesComputadoras.Enabled = false;
            SistemasProgramables.Enabled = false;
            LenguajesAutomatas.Enabled = false;
            LenguajesAutomatas2.Enabled = false;
            IA.Enabled = false;
        }

        private void AdminBD_CheckedChanged(object sender, EventArgs e)
        {
            if(contador > 8)
            {
                MessageBox.Show("Materias seleccionadas al limite");
                AdminBD.Checked = false;
            }
            else
            {
                if (AdminBD.Checked == true)
                {
                    contador++;
                    AdminBD.BackColor = Color.FromArgb(0, 255, 127);
                }
                else
                {
                    contador--;
                    AdminBD.BackColor = Color.Black;

                }

            }
            
        }

        private void AdminRedes_CheckedChanged(object sender, EventArgs e)
        {
            if (contador > 8)
            {
                MessageBox.Show("Materias seleccionadas al limite");
                AdminRedes.Checked = false;
            }
            else
            {
                
                if (AdminRedes.Checked == true)
                {
                    AdminRedes.BackColor = Color.FromArgb(0, 255, 127);
                    contador++;
                }
                else
                {
                    AdminRedes.BackColor = Color.Black;
                    contador--;
                }
            }
            
        }

        private void AdminServidores_CheckedChanged(object sender, EventArgs e)
        {
            if (contador > 8)
            {
                MessageBox.Show("Materias seleccionadas al limite");
                AdminServidores.Checked = false;
            }
            else
            {
                if (AdminServidores.Checked == true)
                {
                    AdminServidores.BackColor = Color.FromArgb(0, 255, 127);
                    contador++;
                }
                else
                {
                    AdminServidores.BackColor = Color.Black;
                    contador--;
                }

            }
            
        }

        private void ArquitecturaComputadoras_CheckedChanged(object sender, EventArgs e)
        {
            if (contador > 8)
            {
                MessageBox.Show("Materias seleccionadas al limite");
                ArquitecturaComputadoras.Checked = false;
            }
            else
            {
                if (ArquitecturaComputadoras.Checked == true)
                {
                    ArquitecturaComputadoras.BackColor = Color.FromArgb(0, 255, 127);
                    contador++;
                }
                else
                {
                    ArquitecturaComputadoras.BackColor = Color.Black;
                    contador--;
                }
            }
            
        }

        private void BDmoviles_CheckedChanged(object sender, EventArgs e)
        {
            if (contador > 8)
            {
                MessageBox.Show("Materias seleccionadas al limite");
                BDmoviles.Checked = false;
            }
            else
            {
                if (BDmoviles.Checked == true)
                {
                    BDmoviles.BackColor = Color.FromArgb(0, 255, 127);
                    contador++;
                }
                else
                {
                    BDmoviles.BackColor = Color.Black;
                    contador--;
                }

            }
            
        }

        private void ConmutacionRedes_CheckedChanged(object sender, EventArgs e)
        {
            if (contador > 8)
            {
                MessageBox.Show("Materias seleccionadas al limite");
                ConmutacionRedes.Checked = false;
            }
            else
            {
                
                if (ConmutacionRedes.Checked == true)
                {
                    ConmutacionRedes.BackColor = Color.FromArgb(0, 255, 127);
                    contador++;
                }
                else
                {
                    ConmutacionRedes.BackColor = Color.Black;
                    contador--;
                }
            }
            
        }

        private void EstructuraDatos_CheckedChanged(object sender, EventArgs e)
        {
            if (contador > 8)
            {
                MessageBox.Show("Materias seleccionadas al limite");
                EstructuraDatos.Checked = false;
            }
            else
            {
                
                if (EstructuraDatos.Checked == true)
                {
                    EstructuraDatos.BackColor = Color.FromArgb(0, 255, 127);
                    contador++;
                }
                else
                {
                    EstructuraDatos.BackColor = Color.Black;
                    contador--;
                }
            }
            
        }

        private void FundamentosBD_CheckedChanged(object sender, EventArgs e)
        {
            if (contador > 8)
            {
                MessageBox.Show("Materias seleccionadas al limite");
                FundamentosBD.Checked = false;
            }
            else
            {
                
                if (FundamentosBD.Checked == true)
                {
                    FundamentosBD.BackColor = Color.FromArgb(0, 255, 127);
                    contador++;
                }
                else
                {
                    FundamentosBD.BackColor = Color.Black;
                    contador--;
                }
            }
            
        }

        private void FundamentosIS_CheckedChanged(object sender, EventArgs e)
        {
            if (contador > 8)
            {
                MessageBox.Show("Materias seleccionadas al limite");
                FundamentosIS.Checked = false;
            }
            else
            {
                
                if (FundamentosIS.Checked == true)
                {
                    FundamentosIS.BackColor = Color.FromArgb(0, 255, 127);
                    contador++;
                }
                else
                {
                    FundamentosIS.BackColor = Color.Black;
                    contador--;
                }
            }
            
        }

        private void FundamentosProgram_CheckedChanged(object sender, EventArgs e)
        {
            if (contador > 8)
            {
                MessageBox.Show("Materias seleccionadas al limite");
                FundamentosProgram.Checked = false;
            }
            else
            {
                
                if (FundamentosProgram.Checked == true)
                {
                    FundamentosProgram.BackColor = Color.FromArgb(0, 255, 127);
                    contador++;
                }
                else
                {
                    FundamentosProgram.BackColor = Color.Black;
                    contador--;
                }
            }
            
        }

        private void GPS_CheckedChanged(object sender, EventArgs e)
        {
            if (contador > 8)
            {
                MessageBox.Show("Materias seleccionadas al limite");
                GPS.Checked = false;
            }
            else
            {
                
                if (GPS.Checked == true)
                {
                    GPS.BackColor = Color.FromArgb(0, 255, 127);
                    contador++;
                }
                else
                {
                    GPS.BackColor = Color.Black;
                    contador--;
                }
            }
            
        }

        private void Graficacion_CheckedChanged(object sender, EventArgs e)
        {
            if (contador > 8)
            {
                MessageBox.Show("Materias seleccionadas al limite");
                Graficacion.Checked = false;
            }
            else
            {
                
                if (Graficacion.Checked == true)
                {
                    Graficacion.BackColor = Color.FromArgb(0, 255, 127);
                    contador++;
                }
                else
                {
                    Graficacion.BackColor = Color.Black;
                    contador--;
                }
            }
            
        }

        private void IA_CheckedChanged(object sender, EventArgs e)
        {
            if (contador > 8)
            {
                MessageBox.Show("Materias seleccionadas al limite");
                IA.Checked = false;
            }
            else
            {
                
                if (IA.Checked == true)
                {
                    IA.BackColor = Color.FromArgb(0, 255, 127);
                    contador++;
                }
                else
                {
                    IA.BackColor = Color.Black;
                    contador--;
                }
            }
            
        }

        private void LenguajesInterfaz_CheckedChanged(object sender, EventArgs e)
        {
            if (contador > 8)
            {
                MessageBox.Show("Materias seleccionadas al limite");
                LenguajesInterfaz.Checked = false;
            }
            else
            {
                
                if (LenguajesInterfaz.Checked == true)
                {
                    LenguajesInterfaz.BackColor = Color.FromArgb(0, 255, 127);
                    contador++;
                }
                else
                {
                    LenguajesInterfaz.BackColor = Color.Black;
                    contador--;
                }
            }
            
        }

        private void LenguajesAutomatas_CheckedChanged(object sender, EventArgs e)
        {
            if (contador > 8)
            {
                MessageBox.Show("Materias seleccionadas al limite");
                LenguajesAutomatas.Checked = false;
            }
            else
            {
                
                if (LenguajesAutomatas.Checked == true)
                {
                    LenguajesAutomatas.BackColor = Color.FromArgb(0, 255, 127);
                    contador++;
                }
                else
                {
                    LenguajesAutomatas.BackColor = Color.Black;
                    contador--;
                }
            }
            
        }

        private void MatesDiscretas_CheckedChanged(object sender, EventArgs e)
        {
            if (contador > 8)
            {
                MessageBox.Show("Materias seleccionadas al limite");

                MatesDiscretas.Checked = false;
            }
            else
            {
                
                if (MatesDiscretas.Checked == true)
                {
                    MatesDiscretas.BackColor = Color.FromArgb(0, 255, 127);
                    contador++;
                }
                else
                {
                    MatesDiscretas.BackColor = Color.Black;
                    contador--;
                }
            }
            
        }

        private void Poo_CheckedChanged(object sender, EventArgs e)
        {
            if (contador > 8)
            {
                MessageBox.Show("Materias seleccionadas al limite");
                Poo.Checked = false;
            }
            else
            {
                
                if (Poo.Checked == true)
                {
                    Poo.BackColor = Color.FromArgb(0, 255, 127);
                    contador++;
                }
                else
                {
                    Poo.BackColor = Color.Black;
                    contador--;
                }
            }
            
        }

        private void ProgramacionDB_CheckedChanged(object sender, EventArgs e)
        {
            if (contador > 8)
            {
                MessageBox.Show("Materias seleccionadas al limite");
                ProgramacionDB.Checked = false;
            }
            else
            {
                
                if (ProgramacionDB.Checked == true)
                {
                    ProgramacionDB.BackColor = Color.FromArgb(0, 255, 127);
                    contador++;
                }
                else
                {
                    ProgramacionDB.BackColor = Color.Black;
                    contador--;
                }
            }
            
        }

        private void LenguajesAutomatas2_CheckedChanged(object sender, EventArgs e)
        {
            if (contador > 8)
            {
                MessageBox.Show("Materias seleccionadas al limite");
                LenguajesAutomatas2.Checked = false;
            }
            else
            {
                
                if (LenguajesAutomatas2.Checked == true)
                {
                    LenguajesAutomatas2.BackColor = Color.FromArgb(0, 255, 127);
                    contador++;
                }
                else
                {
                    LenguajesAutomatas2.BackColor = Color.Black;
                    contador--;
                }
            }
            
        }

        private void Prolog_CheckedChanged(object sender, EventArgs e)
        {
            if (contador > 8)
            {
                MessageBox.Show("Materias seleccionadas al limite");
                Prolog.Checked = false;
            }
            else
            {
                
                if (Prolog.Checked == true)
                {
                    Prolog.BackColor = Color.FromArgb(0, 255, 127);
                    contador++;
                }
                else
                {
                    Prolog.BackColor = Color.Black;
                    contador--;
                }
            }
            
        }

        private void ProgramacionWeb_CheckedChanged(object sender, EventArgs e)
        {
            if (contador > 8)
            {
                MessageBox.Show("Materias seleccionadas al limite");
                ProgramacionWeb.Checked = false;
            }
            else
            {
                
                if (ProgramacionWeb.Checked == true)
                {
                    ProgramacionWeb.BackColor = Color.FromArgb(0, 255, 127);
                    contador++;
                }
                else
                {
                    ProgramacionWeb.BackColor = Color.Black;
                    contador--;
                }
            }
            
        }

        private void RedesComputadoras_CheckedChanged(object sender, EventArgs e)
        {
            if (contador > 8)
            {
                MessageBox.Show("Materias seleccionadas al limite");
                RedesComputadoras.Checked = false;
            }
            else
            {
                
                if (RedesComputadoras.Checked == true)
                {
                    RedesComputadoras.BackColor = Color.FromArgb(0, 255, 127);
                    contador++;
                }
                else
                {
                    RedesComputadoras.BackColor = Color.Black;
                    contador--;
                }
            }
            
        }

        private void SistemasProgramables_CheckedChanged(object sender, EventArgs e)
        {
            if (contador > 8)
            {
                MessageBox.Show("Materias seleccionadas al limite");
                SistemasProgramables.Checked = false; 
            }
            else
            {
                
                if (SistemasProgramables.Checked == true)
                {
                    SistemasProgramables.BackColor = Color.FromArgb(0, 255, 127);
                    contador++;
                }
                else
                {
                    SistemasProgramables.BackColor = Color.Black;
                    contador++;
                }
            }
            
        }

        private void SistemasOperativos_CheckedChanged(object sender, EventArgs e)
        {
            if (contador > 8)
            {
                MessageBox.Show("Materias seleccionadas al limite");
                SistemasOperativos.Checked = false;
            }
            else
            {
                
                if (SistemasOperativos.Checked == true)
                {
                    SistemasOperativos.BackColor = Color.FromArgb(0, 255, 127);
                    contador++;
                }
                else
                {
                    SistemasOperativos.BackColor = Color.Black;
                    contador--;
                }
            }
            
        }

        private void TallerInvestigacion_CheckedChanged(object sender, EventArgs e)
        {
            if (contador > 8)
            {
                MessageBox.Show("Materias seleccionadas al limite");
                TallerInvestigacion.Checked = false;
            }
            else
            {
                
                if (TallerInvestigacion.Checked == true)
                {
                    TallerInvestigacion.BackColor = Color.FromArgb(0, 255, 127);
                    contador++;
                }
                else
                {
                    TallerInvestigacion.BackColor = Color.Black;
                    contador--;
                }
            }
            
        }

        private void TallerInvestigacion2_CheckedChanged(object sender, EventArgs e)
        {
            if (contador > 8)
            {
                MessageBox.Show("Materias seleccionadas al limite");
                TallerInvestigacion2.Checked = false;
            }
            else
            {
                
                if (TallerInvestigacion2.Checked == true)
                {
                    TallerInvestigacion2.BackColor = Color.FromArgb(0, 255, 127);
                    contador++;
                }
                else
                {
                    TallerInvestigacion2.BackColor = Color.Black;
                    contador--;
                }
            }
            
        }

        private void TallerSO_CheckedChanged(object sender, EventArgs e)
        {
            if (contador > 8)
            {
                MessageBox.Show("Materias seleccionadas al limite");
                TallerSO.Checked = false;
            }
            else
            {
                
                if (TallerSO.Checked == true)
                {
                    TallerSO.BackColor = Color.FromArgb(0, 255, 127);
                    contador++;
                }
                else
                {
                    TallerSO.BackColor = Color.Black;
                    contador--;
                }
            }
            
        }

        private void TAP_CheckedChanged(object sender, EventArgs e)
        {
            if (contador > 8)
            {
                MessageBox.Show("Materias seleccionadas al limite");
                TAP.Checked = false;
            }
            else
            {
                
                if (TAP.Checked == true)
                {
                    TAP.BackColor = Color.FromArgb(0, 255, 127);
                    contador++;
                }
                else
                {
                    TAP.BackColor = Color.Black;
                    contador--;
                }
            }
            
        }

        private void Telecom_CheckedChanged(object sender, EventArgs e)
        {
            if (contador > 8)
            {
                MessageBox.Show("Materias seleccionadas al limite");
                Telecom.Checked = false;
            }
            else
            {
                
                if (Telecom.Checked == true)
                {
                    Telecom.BackColor = Color.FromArgb(0, 255, 127);
                    contador++;
                }
                else
                {
                    Telecom.BackColor = Color.Black;
                    contador--;
                }
            }
            
        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
