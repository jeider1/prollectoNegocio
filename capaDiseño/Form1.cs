using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaEntidad;
using capaNegocio;

namespace capaDiseño
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) => emple();
        entidad ent = new entidad();
        negocio nes = new negocio();
        
        void emple()
        {
            DataTable dt = nes.nLista();
            dataGridView1.DataSource = dt;
        }
    }
}

