using Aplication.Querys;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


///
///Componente para el formulario de Elenco
///

namespace Peliculas_y_Actores.Component
{
    public partial class ElencoForm : UserControl
    {
        public Image Foto;
        public Bitmap bitmap;
        ElencoServices Services = new ElencoServices();

        public ElencoForm()
        {
            InitializeComponent();

        }


        public void InicializarElenco()
        {
            cbxELEPelicula.Items.Clear();


            cbxELEActor.Items.Clear();

            LimpiarCampos();
            ObtenerDatos();
            cbxELEPelicula.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbxELEPelicula.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbxELEActor.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbxELEActor.AutoCompleteSource = AutoCompleteSource.ListItems;



        }


        private void LimpiarCampos()
        {
            cbxELEActor.SelectedIndex = -1;
            cbxELEPelicula.SelectedIndex = -1;

        }

        private void ObtenerDatos()
        {
            cbxELEActor.Items.Clear();
            cbxELEPelicula.Items.Clear();

            try
            {

                var DataActor = Services.Get(Querys.SELECT_ACTOR_N);
                var DataPelucula = Services.Get(Querys.SELECT_TITULO);

                foreach (DataRow DR in DataActor.Rows)
                {
                    cbxELEActor.Items.Add(DR["Nombre"].ToString());
                }

                foreach (DataRow DR in DataPelucula.Rows)
                {
                    cbxELEPelicula.Items.Add(DR["Título"].ToString());
                }


            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error al recoger la información de la base de datos.\n" + Ex.Message);
            }

        }
        ///
        ///Acciones de los elementos interactivos
        ///
        private void cbxELEPelicula_KeyPress(object sender, KeyPressEventArgs e)
        {
            cbxELEPelicula.DroppedDown = false;
        }

        private void cbxELEActor_KeyPress(object sender, KeyPressEventArgs e)
        {
            cbxELEPelicula.DroppedDown = false;
        }

        private void cbxELEPelicula_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                var Query = String.Format(Querys.SELECT_ELENCO, cbxELEPelicula.Text);
                var Data = Services.Get(Query);
                dgvELE.DataSource = Data;

                dgvELE.Refresh();

                var FilePath = Path.Combine(Directory.GetCurrentDirectory(), "Resources", cbxELEPelicula.Text + ".jpg");

                pbELEFoto.Image = File.Exists(FilePath) ? Image.FromFile(FilePath) : null;


            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error al recoger la información de la base de datos.\n" + Ex.Message);
            }
        }

        private void dgvELE_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow Row = dgvELE.CurrentRow;
            cbxELEActor.Text = Row.Cells[0].Value.ToString();

        }

        private void btnELEEliminar_Click(object sender, EventArgs e)
        {
            string actor = cbxELEActor.Text;
            string pelicula = cbxELEPelicula.Text;

            try
            {
                var Query = String.Format(Querys.DELETE_ELENCO, actor, pelicula);
                Services.Modificar(Query);

                MessageBox.Show("Actor desvinculado de la pelicula.");

                ObtenerDatos();
                LimpiarCampos();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error al eliminar la información de la base de datos.\n" + Ex.Message);
            }


            cbxELEPelicula.Text = "";
            cbxELEPelicula.Text = pelicula;
        }

        private void btnELEAñadir_Click(object sender, EventArgs e)
        {
            string actor = cbxELEActor.Text;
            string pelicula = cbxELEPelicula.Text;

            try
            {
                var Query = String.Format(Querys.INSERT_ELENCO, actor, pelicula);
                Services.Modificar(Query);

                MessageBox.Show("Actor Vinculado a la pelicula.");

                ObtenerDatos();
                LimpiarCampos();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error al añadir la información de la base de datos.\n" + Ex.Message);
            }

            cbxELEPelicula.Text = "";
            cbxELEPelicula.Text = pelicula;
        }
    }
}
