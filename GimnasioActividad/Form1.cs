using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GimnasioActividad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void llbClientes_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            clientes clientes = new clientes(this);
            clientes.Show();
            this.Hide();
        }

        private void llbActividades_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            actividades act = new actividades(this);
            act.Show();
            this.Hide();
        }
    }
}
