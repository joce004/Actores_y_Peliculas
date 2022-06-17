using System;
using System.Drawing;


///
/// Fomulario principal
/// Aquí se encuentra la lógica para la navegación sobre los componentes del aplicativo
///

namespace Peliculas_y_Actores
{
    public partial class AdministradorDePeliculas : System.Windows.Forms.Form
    {
        public AdministradorDePeliculas()
        {
            InitializeComponent();
            inicioForm.Visible = true;
            pnlInicio.BackColor = Color.FromArgb(192, 0, 0);
        }

        public void Visualizador()
        {
            inicioForm.Visible = false;
            peliculasForm.Visible = false;
            actoresForm.Visible = false;
            elencoForm.Visible = false;

            pnlInicio.BackColor = Color.FromArgb(255, 255, 255);
            pnlPelicula.BackColor = Color.FromArgb(255, 255, 255);
            pnlActores.BackColor = Color.FromArgb(255, 255, 255);
            pnlElenco.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            Visualizador();
            pnlInicio.BackColor = Color.FromArgb(192, 0, 0);
            inicioForm.Visible = true;
        }

        private void btnPeliculas_Click(object sender, EventArgs e)
        {
            Visualizador();
            pnlPelicula.BackColor = Color.FromArgb(192, 0, 0);
            peliculasForm.Visible = true;
            peliculasForm.InicializarPeliculas();
        }

        private void btnActores_Click(object sender, EventArgs e)
        {
            Visualizador();
            pnlActores.BackColor = Color.FromArgb(192, 0, 0);
            actoresForm.Visible = true;
            actoresForm.InicializarActor();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Visualizador();
            pnlElenco.BackColor = Color.FromArgb(192, 0, 0);
            elencoForm.Visible = true;
            elencoForm.InicializarElenco();
        }
    }
}
