using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parcial1_ap1_20180618.BLL;
using Parcial1_ap1_20180618.Entidades;
using Parcial1_ap1_20180618.DAL;

namespace Parcial1_ap1_20180618
{
    public partial class RegistroCiudades : Form
    {
        public RegistroCiudades()
        {
            InitializeComponent();
        }

        private bool Validar()
        {
            bool paso = true;
            errorProvider1.Clear();

            if(IdCiudadNumericUpDown.Value == 0)
            {
                errorProvider1.SetError(IdCiudadNumericUpDown, "Campo obligatorio");
                paso = false;
            }

            if (NombreTextBox.Text == "")
            {
                errorProvider1.SetError(NombreTextBox, "Campo obligatorio");
                paso = false;
            }

            return paso;
        }

        private void LlenarCampos(Ciudades ciudades)
        {
            IdCiudadNumericUpDown.Value = ciudades.CiudadId;
            NombreTextBox.Text = ciudades.Nombre;
        }

        private Ciudades LlenarClase()
        {
            Ciudades ciudades = new Ciudades();

            ciudades.CiudadId = Convert.ToInt32(IdCiudadNumericUpDown.Value);
            ciudades.Nombre = NombreTextBox.Text;

            return ciudades;
        }

        private void Limpiar()
        {
            IdCiudadNumericUpDown.Value = 0;
            NombreTextBox.Text = string.Empty;
            errorProvider1.Clear();
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            Ciudades ciudades = CiudadesBLL.Buscar((int)IdCiudadNumericUpDown.Value);
            return (ciudades != null);
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id;
            Ciudades ciudades = new Ciudades();
            int.TryParse(IdCiudadNumericUpDown.Text, out id);

            Limpiar();

            ciudades = CiudadesBLL.Buscar(id);

            if(ciudades !=  null)
            {
                MessageBox.Show("Ciudad encontrada");
                LlenarCampos(ciudades);
            }
            else 
            {
                MessageBox.Show("Ciudad no encontrada");
            }
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        { 
            Ciudades ciudades;
            bool paso = false;
            int id = (int)IdCiudadNumericUpDown.Value;
            string nombre = NombreTextBox.Text;

            if (!Validar())
                return;

            ciudades = LlenarClase();

            if (IdCiudadNumericUpDown.Value != 0)
            {
                if(CiudadesBLL.ExisteNombre(id, nombre))
                {
                    MessageBox.Show("Esta ciudad ya existe");
                    return;
                }
                paso = CiudadesBLL.Guardar(ciudades);
            }              
            else 
            { 
                if(!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar una ciudad que no existe");
                    return;
                }
                paso = CiudadesBLL.Modificar(ciudades);
            }

            if (paso)
            {
                Limpiar();
                MessageBox.Show("Se ha guardado correctamente");
            }
            else
                MessageBox.Show("No fue posible guardar");

        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            int id;
            int.TryParse(IdCiudadNumericUpDown.Text, out id);
            errorProvider1.Clear();

            Limpiar();

            if (CiudadesBLL.Eliminar(id))
                MessageBox.Show("Ciudad Eliminada");
            else
                errorProvider1.SetError(IdCiudadNumericUpDown, "Ciudad inexistente");
        }
    }
}
