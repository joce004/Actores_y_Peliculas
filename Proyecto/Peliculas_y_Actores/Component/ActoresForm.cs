using Aplication.Querys;
using Domain;
using Services;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

///
///Componente para el formulario de actores
///

namespace Peliculas_y_Actores
{
    public partial class ActoresForm : UserControl
    {
        public Image Foto;
        public Bitmap bitmap;
        ActoresServices Services = new ActoresServices();

        public ActoresForm()
        {
            InitializeComponent();
        }


        public void InicializarActor()
        {

            cbxACTCriterio.SelectedIndex = 0;

            HabilitarBotones("A");

            LimpiarCampos();
            ObtenerDatos();
        }

        

        private void HabilitarBotones(string S)
        {
            if (S == "A")
            {
                btnACTGuardar.Enabled = true;
                btnACTModificar.Enabled = false;
                btnACTEliminar.Enabled = false;
            }
            else if (S == "M")
            {
                btnACTGuardar.Enabled = false;
                btnACTModificar.Enabled = true;
                btnACTEliminar.Enabled = true;
            }
        }

        private void LimpiarCampos()
        {
            txtACTNombre.Clear();
            dtpACTNacimiento.Value = DateTime.Now;
            pbACTFoto.Image = null;

            rbACTM.Checked = false;
            rbACTF.Checked = false;

            HabilitarBotones("A");
        }


        private string ObtenerSexo()
        {
            if (rbACTM.Checked == true) { rbACTF.Checked = false; return "M"; }
            else if (rbACTF.Checked == true) { rbACTM.Checked = false; return "F"; }
            else return "M";
        }



        private void ObtenerDatos()
        {
            try
            {

                var Data = Services.Get(Querys.SELECT_ACTOR);
                dtgActores.DataSource = Data;

                dtgActores.Refresh();


            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error al recoger la información de la base de datos.\n" + Ex.Message);
            }

        }

        ///
        ///Acciones de los elementos interactivos
        ///

        private void btnACTCargar_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                DialogResult DR = dialog.ShowDialog();

                if (DR == DialogResult.OK)
                {
                    Foto = Image.FromFile(dialog.FileName);
                    bitmap = (Bitmap)Foto;
                    pbACTFoto.Image = bitmap;
                    txtACTFoto.Text = dialog.FileName;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("No se pudo completar la operación.\n" + Ex.Message);
            }

        }



        private void btnACTLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnACTGuardar_Click(object sender, EventArgs e)
        {
            Actor actor = new Actor();
            actor.Nombre = txtACTNombre.Text;
            actor.Sexo = ObtenerSexo();
            actor.Fecha_Nacimiento = dtpACTNacimiento.Value;
            actor.Foto = File.Exists(txtACTFoto.Text) ? Path.GetFileName(txtACTFoto.Text) : null;

            try
            {

                Services.InsertActor(actor, Querys.INSERT_ACTOR);

                var saveDirectory = Path.Combine(Directory.GetCurrentDirectory(), "Resources");
                string fileName = actor.Foto;

                if (!Directory.Exists(saveDirectory))
                {
                    Directory.CreateDirectory(saveDirectory);
                }

                if (actor.Foto != null)
                {

                    saveDirectory = Path.Combine(Directory.GetCurrentDirectory(), "Resources", actor.Nombre + ".jpg");
                    File.Copy(txtACTFoto.Text, saveDirectory, true);

                }
                MessageBox.Show("Actor registrado.");

                ObtenerDatos();
                LimpiarCampos();
                HabilitarBotones("A");
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error al insertar la información de la base de datos.\n" + Ex.Message);
            }
        }



        private void btnACTModificar_Click(object sender, EventArgs e)
        {
            Actor actor = new Actor();
            actor.Nombre = txtACTNombre.Text;
            actor.Sexo = ObtenerSexo();
            actor.Fecha_Nacimiento = dtpACTNacimiento.Value;
            actor.Foto = File.Exists(txtACTFoto.Text) ? Path.GetFileName(txtACTFoto.Text) : null;

            try
            {

                Services.UpdateActor(actor, Querys.UPDATE_ACTOR, txtACTSubject.Text);

                var saveDirectory = Path.Combine(Directory.GetCurrentDirectory(), "Resources");
                string fileName = actor.Foto;

                if (!Directory.Exists(saveDirectory))
                {
                    Directory.CreateDirectory(saveDirectory);
                }

                if (actor.Foto != null)
                {
                    saveDirectory = Path.Combine(Directory.GetCurrentDirectory(), "Resources", actor.Nombre + ".jpg");
                    File.Copy(txtACTFoto.Text, saveDirectory, true);
                }

                MessageBox.Show("Actor modificado.");

                ObtenerDatos();
                LimpiarCampos();
                HabilitarBotones("A");
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error al insertar la información de la base de datos.\n" + Ex.Message);
            }

        }

        private void btnACTEliminar_Click(object sender, EventArgs e)
        {

            string Nombre = txtACTNombre.Text;

            try
            {

                Services.Delete(Nombre, Querys.DELETE_ACTOR);

                var DeleteFile = Path.Combine(Directory.GetCurrentDirectory(), "Resources", Path.GetFileName(txtACTFoto.Text));


                if (Directory.Exists(DeleteFile))
                {
                    File.Delete(DeleteFile);
                }


                MessageBox.Show("Actor eliminado.");

                ObtenerDatos();
                LimpiarCampos();
                HabilitarBotones("A");
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error al eliminar la información de la base de datos.\n" + Ex.Message);
            }
        }

        private void dtgActores_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow Row = dtgActores.CurrentRow;
            txtACTNombre.Text = Row.Cells[0].Value.ToString();
            txtACTSubject.Text = Row.Cells[0].Value.ToString();

            if (Row.Cells[1].Value.ToString() == "M") { rbACTM.Checked = true; rbACTF.Checked = false; }
            else if (Row.Cells[1].Value.ToString() == "F") { rbACTM.Checked = false; rbACTF.Checked = true; }


            dtpACTNacimiento.Value = DateTime.Parse(Row.Cells[2].Value.ToString());
            txtACTFoto.Text = Path.Combine(Directory.GetCurrentDirectory(), "Resources", Row.Cells[0].Value.ToString() + ".jpg");

            var FilePath = Path.Combine(Directory.GetCurrentDirectory(), "Resources", Row.Cells[0].Value.ToString() + ".jpg");

            pbACTFoto.Image = File.Exists(FilePath) ? Image.FromFile(FilePath) : null;

            HabilitarBotones("M");

        }

        private void btnACTBuscar_Click(object sender, EventArgs e)
        {
            string Criterio = cbxACTCriterio.Text;
            string Busqueda = txtACTDato.Text;

            try
            {

                var Data = Services.Filter(Querys.SELECT_PELICULA, Criterio, Busqueda);
                dtgActores.DataSource = Data;

                dtgActores.Refresh();


            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error al recoger la información de la base de datos.\n" + Ex.Message);
            }
        }
    }
}
