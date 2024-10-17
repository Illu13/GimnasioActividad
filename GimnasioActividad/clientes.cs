using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Text.Json;
using System.IO;
using System.Runtime.Remoting.Messaging;

namespace GimnasioActividad
{
    public partial class clientes : Form
    {
        Form1 formPadre;
        BindingList<Cliente> clientList = new BindingList<Cliente>
            {};
        public clientes(Form1 form)
        {
            InitializeComponent();
            formPadre = form;
            dgvClient.DataSource = clientList;

        }

        private void clientes_FormClosed(object sender, FormClosedEventArgs e)
        {
            formPadre.Show();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int clientCode;
            try
            {
                clientCode = clientList.Last().id + 1;
            } catch { 
                clientCode = 1;
            }
            try
            {
                string name, surname, city;
                DateTime bornDate;
                int telf;
                getData(out name, out surname, out bornDate, out city, out telf);

                Cliente cliente = new Cliente(clientCode, name, surname, bornDate, city, telf);
                clientList.Add(cliente);
                
            }
            catch {
                MessageBox.Show("Has metido algún dato incorrecto, comprueba que el teléfono sean solo números.", "Error");
            }
        }

       

        private void cbCities_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow filaSeleccionada = dgvClient.Rows[e.RowIndex];
                String id = filaSeleccionada.Cells[0].Value.ToString();
                String nombre = filaSeleccionada.Cells[1].Value.ToString();
                String apellidos = filaSeleccionada.Cells[2].Value.ToString();
                DateTime nac = DateTime.Parse(filaSeleccionada.Cells[3].Value.ToString());
                String ciudad = filaSeleccionada.Cells[4].Value.ToString();
                String telf = filaSeleccionada.Cells[5].Value.ToString();

                tbCode.Text = id;
                tbName.Text = nombre;
                tbSurname.Text = apellidos;
                dtpBorn.Value = nac;
                tbPhone.Text = telf;
                cbCities.SelectedText = ciudad;
            }
            catch { 
            
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int id;
            try { 
                id = Convert.ToInt32(tbCode.Text);
            } catch {
                MessageBox.Show("No estás modificando ningún usuario", "Error");
                return;
            }
            try {
                Cliente chosenClient = new Cliente();
                for (int i = 0; i < clientList.Count; i++)
                {
                    if (clientList[i].id.Equals(id))
                    {
                        clientList.RemoveAt(i);
                        break; // Terminamos el bucle una vez que se encuentra y elimina el cliente
                    }
                }
                string name, surname, city;
                DateTime bornDate;
                int telf;
                getData(out name, out surname, out bornDate, out city, out telf);
                chosenClient.id = id;
                chosenClient.nombre = name;
                chosenClient.apellidos = surname;
                chosenClient.fechaNacimiento = bornDate;
                chosenClient.ciudad = city;
                chosenClient.telefono = telf;
                clientList.Add(chosenClient);

            } catch (Exception exc){
                MessageBox.Show("Ha habido un fallo" + exc.ToString());
            }



        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id;
            try
            {
                id = Convert.ToInt32(tbCode.Text);
            }
            catch
            {
                MessageBox.Show("No estás eliminando ningún usuario", "Error");
                return;
            }
            try
            {
                for (int i = 0; i < clientList.Count; i++)
                {
                    if (clientList[i].id.Equals(id))
                    {
                        clientList.RemoveAt(i);
                        break; // Terminamos el bucle una vez que se encuentra y elimina el cliente
                    }
                }
            }
            catch {
                MessageBox.Show("Ha habido un fallo");
            }
        }

        private void getData(out string name, out string surname, out DateTime bornDate, out string city, out int telf)
        {
            name = tbName.Text;
            surname = tbSurname.Text;
            bornDate = DateTime.Parse(dtpBorn.Text);
            city = cbCities.SelectedItem.ToString();
            telf = Int32.Parse(tbPhone.Text);
            clearTextBoxes();
        }

        private void clearTextBoxes()
        {
            tbCode.Clear();
            tbName.Clear();
            tbSurname.Clear();
            tbPhone.Clear();
            dtpBorn.Value = DateTime.Now;
            cbCities.Text = "";
        }


        public string getJson()
        {
            return JsonSerializer.Serialize(clientList);
        }

        private void btnSaveJson_Click(object sender, EventArgs e)
        {
            try
            {
                String json = getJson();
                File.WriteAllText("C:\\Users\\isaac\\Desktop\\clientes.json", json);
                MessageBox.Show("El JSON se ha creado correctamente.", "Éxito");
            } catch {
                MessageBox.Show("Ha habido un error al crear el JSON.", "Error");
            }
        }

        private void btnUploadJson_Click(object sender, EventArgs e)
        {
            if (uploadJsonDialog.ShowDialog() == DialogResult.OK) {
                String rutaFichero = uploadJsonDialog.FileName;
                FileStream json = File.Open(rutaFichero, FileMode.Open);
                List<Cliente> allClients = JsonSerializer.Deserialize<List<Cliente>>(json);
                foreach (Cliente cliente in allClients)
                {
                    if (cliente != null)
                    {
                        clientList.Add(cliente);
                    }
                }

            }
        }
    }
}
