using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GimnasioActividad
{
    public partial class actividades : Form
    {
        Form1 formPadre;
        List<Actividad> actividadList = new List<Actividad>() { 
        new Actividad
        {
            id = 1,
            nombre = "Pesas",
            sala = "Sala 1",
            desripcion = "Entrenamiento de mancuernas y pesos ligeros"
        },
        new Actividad { 
            id = 2,
            nombre = "Spining",
            sala = "Sala 2",
            desripcion = "Entrenamiento de bicicletas estáticas"
        },
        new Actividad
        {
            id = 3,
            nombre = "Yoga",
            sala = "Sala 3",
            desripcion = "Relájate y estira los músculos con este ejercicio"
        },
        new Actividad
        {
            id = 4,
            nombre = "Natación",
            sala = "Sala Cubierta",
            desripcion = "Aprende a nadar."
        }
        
        };
        public actividades(Form1 formPadre)
        {
            InitializeComponent();
            this.formPadre = formPadre;
            foreach (Actividad a in actividadList) { 
                ListViewItem lvi = new ListViewItem(a.id.ToString());
                lvi.SubItems.Add(a.nombre);
                lvi.SubItems.Add(a.sala);
                lvi.SubItems.Add(a.desripcion);
                lvActivities.Items.Add(lvi);
            }


        }

        private void actividades_FormClosed(object sender, FormClosedEventArgs e)
        {
            formPadre.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
