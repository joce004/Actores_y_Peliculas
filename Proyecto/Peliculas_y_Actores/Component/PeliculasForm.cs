using Aplication.Querys;
using Domain;
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
///Componente para el formulario de Peliculas
///

namespace Peliculas_y_Actores
{
    public partial class PeliculasForm : UserControl
    {
        public Image Foto;
        public Bitmap bitmap;

        public PeliculasForm()
        {
            InitializeComponent();
        }


        public void InicializarPeliculas()
        {

            cbxPLCCriterio.SelectedIndex = 0;

            HabilitarBotones("A");

            LimpiarCampos();
            ObtenerGeneros();
            ObtenerDatos();
        }

        PeliculasServices Services = new PeliculasServices();

        private void HabilitarBotones(string S)
        {
            if (S == "A")
            {
                btnPLCGuardar.Enabled = true;
                btnPLCModificar.Enabled = false;
                btnPLCEliminar.Enabled = false;
            }
            else if (S == "M")
            {
                btnPLCGuardar.Enabled = false;
                btnPLCModificar.Enabled = true;
                btnPLCEliminar.Enabled = true;
            }
        }

        private void LimpiarCampos()
        {
            txtPLCTitulo.Clear();
            cbxPLCGenero.SelectedIndex = -1;
            dtpPLCEstreno.Value = DateTime.Now;
            pbPLCFoto.Image = null;

            HabilitarBotones("A");
        }

        private void ObtenerGeneros()
        {

            cbxPLCGenero.Items.Clear();

            try
            {
                var Data = Services.Get(Querys.SELECT_GENEROS);


                foreach (DataRow DR in Data.Rows)
                {
                    cbxPLCGenero.Items.Add(DR["Nombre"].ToString()); ;
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error al recoger los servicios.\n" + Ex.Message);
            }
        }

        private void ObtenerDatos()
        {
            try
            {

                var Data = Services.Get(Querys.SELECT_PELICULA);
                dtgPeliculas.DataSource = Data;

                dtgPeliculas.Refresh();


            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error al recoger la información de la base de datos.\n" + Ex.Message);
            }

        }

        ///
        ///Acciones de los elementos interactivos
        ///

        private void btnPLCCargar_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                DialogResult DR = dialog.ShowDialog();

                if (DR == DialogResult.OK)
                {
                    Foto = Image.FromFile(dialog.FileName);
                    bitmap = (Bitmap)Foto;
                    pbPLCFoto.Image = bitmap;
                    txtPLCFoto.Text = dialog.FileName;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("No se pudo completar la operación.\n" + Ex.Message);
            }

        }



        private void btnPLCLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnPLCGuardar_Click(object sender, EventArgs e)
        {
            Pelicula pelicula = new Pelicula();
            pelicula.Titulo = txtPLCTitulo.Text;
            pelicula.Genero = cbxPLCGenero.Text;
            pelicula.Fecha_Estreno = dtpPLCEstreno.Value;
            pelicula.Foto = File.Exists(txtPLCFoto.Text) ? Path.GetFileName(txtPLCFoto.Text) : null;

            try
            {

                Services.InsertPelicula(pelicula, Querys.INSERT_PELICULA);

                var saveDirectory = Path.Combine(Directory.GetCurrentDirectory(), "Resources");
                string fileName = pelicula.Foto;

                if (!Directory.Exists(saveDirectory))
                {
                    Directory.CreateDirectory(saveDirectory);
                }

                if (pelicula.Foto != null)
                {

                    saveDirectory = Path.Combine(Directory.GetCurrentDirectory(), "Resources", pelicula.Titulo + ".jpg");
                    File.Copy(txtPLCFoto.Text, saveDirectory, true);

                }
                MessageBox.Show("Pelicula registrada.");

                ObtenerDatos();
                LimpiarCampos();
                HabilitarBotones("A");
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error al insertar la información de la base de datos.\n" + Ex.Message);
            }
        }



        private void btnPLCModificar_Click(object sender, EventArgs e)
        {
            Pelicula pelicula = new Pelicula();
            pelicula.Titulo = txtPLCTitulo.Text;
            pelicula.Genero = cbxPLCGenero.Text;
            pelicula.Fecha_Estreno = dtpPLCEstreno.Value;
            pelicula.Foto = File.Exists(txtPLCFoto.Text) ? Path.GetFileName(txtPLCFoto.Text) : null;

            try
            {

                Services.UpdatePelicula(pelicula, Querys.UPDATE_PELICULA, txtPLCSubject.Text);

                var saveDirectory = Path.Combine(Directory.GetCurrentDirectory(), "Resources");
                string fileName = pelicula.Foto;

                if (!Directory.Exists(saveDirectory))
                {
                    Directory.CreateDirectory(saveDirectory);
                }

                if (pelicula.Foto != null)
                {
                    saveDirectory = Path.Combine(Directory.GetCurrentDirectory(), "Resources", pelicula.Titulo + ".jpg");
                    File.Copy(txtPLCFoto.Text, saveDirectory, true);
                }

                MessageBox.Show("Pelicula modificada.");

                ObtenerDatos();
                LimpiarCampos();
                HabilitarBotones("A");
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error al insertar la información de la base de datos.\n" + Ex.Message);
            }

        }

        private void btnPLCEliminar_Click(object sender, EventArgs e)
        {

            string Titulo = txtPLCTitulo.Text;

            try
            {

                Services.Delete(Titulo, Querys.DELETE_PELICULA);

                var DeleteFile = Path.Combine(Directory.GetCurrentDirectory(), "Resources", Path.GetFileName(txtPLCFoto.Text));


                if (Directory.Exists(DeleteFile))
                {
                    File.Delete(DeleteFile);
                }


                MessageBox.Show("Pelicula eliminada.");

                ObtenerDatos();
                LimpiarCampos();
                HabilitarBotones("A");
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error al eliminar la información de la base de datos.\n" + Ex.Message);
            }
        }

        private void dtgPeliculas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow Row = dtgPeliculas.CurrentRow;
            txtPLCTitulo.Text = Row.Cells[0].Value.ToString();
            txtPLCSubject.Text = Row.Cells[0].Value.ToString();
            cbxPLCGenero.Text = Row.Cells[1].Value.ToString();
            dtpPLCEstreno.Value = DateTime.Parse(Row.Cells[2].Value.ToString());
            txtPLCFoto.Text = Path.Combine(Directory.GetCurrentDirectory(), "Resources", Row.Cells[0].Value.ToString() + ".jpg");

            var FilePath = Path.Combine(Directory.GetCurrentDirectory(), "Resources", Row.Cells[0].Value.ToString() + ".jpg");

            pbPLCFoto.Image = File.Exists(FilePath) ? Image.FromFile(FilePath) : null;

            HabilitarBotones("M");

        }

        private void btnPLCBuscar_Click(object sender, EventArgs e)
        {
            string Criterio = cbxPLCCriterio.Text;
            string Busqueda = txtPLCDato.Text;

            if (Criterio == "Genero")
                Criterio = "Genero].[Nombre";

            try
            {

                var Data = Services.Filter(Querys.SELECT_PELICULA, Criterio, Busqueda);
                dtgPeliculas.DataSource = Data;

                dtgPeliculas.Refresh();


            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error al recoger la información de la base de datos.\n" + Ex.Message);
            }
        }
    }
}
