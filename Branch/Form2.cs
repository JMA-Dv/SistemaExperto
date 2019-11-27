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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void AreaPorMateria_Click(object sender, EventArgs e)
        {
            Home res = new Home();
            res.Show();
        }

        private void MateriaPorArea_Click(object sender, EventArgs e)
        {
            Form3 des = new Form3();
            des.Show();
        }

        private void Minijuego_Click(object sender, EventArgs e)
        {
            juego les = new juego();
            les.Show();
        }
    }
}
