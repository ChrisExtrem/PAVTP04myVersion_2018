using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAVTP04myVersion_2018.Vistas
{
    public partial class Principal : Form
    {
        //Atributos Bandera
        bool ProductosIsActive = false;

        public Principal()
        {
            InitializeComponent();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!ProductosIsActive)
            {
                ProductosIsActive = true;
                var Productos = new ProductosPrincipal();
                Productos.MdiParent = this;
                Productos.Show();
                Productos.WindowState = FormWindowState.Maximized;
            }
        }
    }
}
