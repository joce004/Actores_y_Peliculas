
namespace Peliculas_y_Actores
{
    partial class AdministradorDePeliculas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.btnInicio = new System.Windows.Forms.Button();
            this.pnlInicio = new System.Windows.Forms.Panel();
            this.btnPeliculas = new System.Windows.Forms.Button();
            this.pnlPelicula = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlElenco = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlActores = new System.Windows.Forms.Panel();
            this.btnActores = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.inicioForm = new Peliculas_y_Actores.InicioForm();
            this.peliculasForm = new Peliculas_y_Actores.PeliculasForm();
            this.elencoForm = new Peliculas_y_Actores.Component.ElencoForm();
            this.actoresForm = new Peliculas_y_Actores.ActoresForm();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // btnInicio
            // 
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("DINPro-Bold", 15F, System.Drawing.FontStyle.Bold);
            this.btnInicio.ForeColor = System.Drawing.Color.White;
            this.btnInicio.Location = new System.Drawing.Point(12, 279);
            this.btnInicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(195, 39);
            this.btnInicio.TabIndex = 1;
            this.btnInicio.Text = "  INICIO";
            this.btnInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // pnlInicio
            // 
            this.pnlInicio.BackColor = System.Drawing.Color.White;
            this.pnlInicio.Location = new System.Drawing.Point(0, 279);
            this.pnlInicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlInicio.Name = "pnlInicio";
            this.pnlInicio.Size = new System.Drawing.Size(13, 39);
            this.pnlInicio.TabIndex = 2;
            // 
            // btnPeliculas
            // 
            this.btnPeliculas.FlatAppearance.BorderSize = 0;
            this.btnPeliculas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPeliculas.Font = new System.Drawing.Font("DINPro-Bold", 15F, System.Drawing.FontStyle.Bold);
            this.btnPeliculas.ForeColor = System.Drawing.Color.White;
            this.btnPeliculas.Location = new System.Drawing.Point(12, 338);
            this.btnPeliculas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPeliculas.Name = "btnPeliculas";
            this.btnPeliculas.Size = new System.Drawing.Size(195, 39);
            this.btnPeliculas.TabIndex = 4;
            this.btnPeliculas.Text = "  PELÍCULAS";
            this.btnPeliculas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPeliculas.UseVisualStyleBackColor = true;
            this.btnPeliculas.Click += new System.EventHandler(this.btnPeliculas_Click);
            // 
            // pnlPelicula
            // 
            this.pnlPelicula.BackColor = System.Drawing.Color.White;
            this.pnlPelicula.Location = new System.Drawing.Point(0, 338);
            this.pnlPelicula.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlPelicula.Name = "pnlPelicula";
            this.pnlPelicula.Size = new System.Drawing.Size(13, 39);
            this.pnlPelicula.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("DINPro-Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(-4, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(263, 23);
            this.label4.TabIndex = 26;
            this.label4.Text = "_______________________";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(72)))), ((int)(((byte)(146)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.pnlElenco);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pnlActores);
            this.panel1.Controls.Add(this.btnActores);
            this.panel1.Controls.Add(this.pnlPelicula);
            this.panel1.Controls.Add(this.btnPeliculas);
            this.panel1.Controls.Add(this.pnlInicio);
            this.panel1.Controls.Add(this.btnInicio);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 675);
            this.panel1.TabIndex = 4;
            // 
            // pnlElenco
            // 
            this.pnlElenco.BackColor = System.Drawing.Color.White;
            this.pnlElenco.Location = new System.Drawing.Point(0, 455);
            this.pnlElenco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlElenco.Name = "pnlElenco";
            this.pnlElenco.Size = new System.Drawing.Size(13, 39);
            this.pnlElenco.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("DINPro-Bold", 15F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 455);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 39);
            this.button1.TabIndex = 10;
            this.button1.Text = "  ELENCO";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnlActores
            // 
            this.pnlActores.BackColor = System.Drawing.Color.White;
            this.pnlActores.Location = new System.Drawing.Point(0, 398);
            this.pnlActores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlActores.Name = "pnlActores";
            this.pnlActores.Size = new System.Drawing.Size(13, 39);
            this.pnlActores.TabIndex = 8;
            // 
            // btnActores
            // 
            this.btnActores.FlatAppearance.BorderSize = 0;
            this.btnActores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActores.Font = new System.Drawing.Font("DINPro-Bold", 15F, System.Drawing.FontStyle.Bold);
            this.btnActores.ForeColor = System.Drawing.Color.White;
            this.btnActores.Location = new System.Drawing.Point(12, 398);
            this.btnActores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnActores.Name = "btnActores";
            this.btnActores.Size = new System.Drawing.Size(195, 39);
            this.btnActores.TabIndex = 7;
            this.btnActores.Text = "  ACTORES";
            this.btnActores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActores.UseVisualStyleBackColor = true;
            this.btnActores.Click += new System.EventHandler(this.btnActores_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("DINPro-Bold", 25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(657, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADMINISTRACIÓN DE PELÍCULAS";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(47)))), ((int)(((byte)(99)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(207, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1030, 100);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(207, 100);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1030, 10);
            this.panel3.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::Peliculas_y_Actores.Properties.Resources.R__1_;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(207, 213);
            this.panel4.TabIndex = 27;
            // 
            // inicioForm
            // 
            this.inicioForm.Location = new System.Drawing.Point(207, 105);
            this.inicioForm.Name = "inicioForm";
            this.inicioForm.Size = new System.Drawing.Size(1030, 570);
            this.inicioForm.TabIndex = 10;
            // 
            // peliculasForm
            // 
            this.peliculasForm.Location = new System.Drawing.Point(213, 115);
            this.peliculasForm.Name = "peliculasForm";
            this.peliculasForm.Size = new System.Drawing.Size(1020, 555);
            this.peliculasForm.TabIndex = 8;
            this.peliculasForm.Visible = false;
            // 
            // elencoForm
            // 
            this.elencoForm.Location = new System.Drawing.Point(213, 115);
            this.elencoForm.Name = "elencoForm";
            this.elencoForm.Size = new System.Drawing.Size(1020, 555);
            this.elencoForm.TabIndex = 9;
            this.elencoForm.Visible = false;
            // 
            // actoresForm
            // 
            this.actoresForm.Location = new System.Drawing.Point(213, 115);
            this.actoresForm.Name = "actoresForm";
            this.actoresForm.Size = new System.Drawing.Size(1020, 555);
            this.actoresForm.TabIndex = 7;
            this.actoresForm.Visible = false;
            // 
            // AdministradorDePeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 675);
            this.Controls.Add(this.inicioForm);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.peliculasForm);
            this.Controls.Add(this.elencoForm);
            this.Controls.Add(this.actoresForm);
            this.Name = "AdministradorDePeliculas";
            this.Text = "Administración de películas";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlPelicula;
        private System.Windows.Forms.Button btnPeliculas;
        private System.Windows.Forms.Panel pnlInicio;
        private System.Windows.Forms.Button btnInicio;
        private PeliculasForm peliculasForm;
        private ActoresForm actoresForm;
        private System.Windows.Forms.Panel pnlActores;
        private System.Windows.Forms.Button btnActores;
        private System.Windows.Forms.Panel pnlElenco;
        private System.Windows.Forms.Button button1;
        private Component.ElencoForm elencoForm;
        private InicioForm inicioForm;
    }
}

