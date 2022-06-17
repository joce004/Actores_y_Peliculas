
namespace Peliculas_y_Actores
{
    partial class PeliculasForm
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

        
        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgPeliculas = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPLCTitulo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnPLCLimpiar = new System.Windows.Forms.Button();
            this.btnPLCModificar = new System.Windows.Forms.Button();
            this.btnPLCGuardar = new System.Windows.Forms.Button();
            this.btnPLCEliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpPLCEstreno = new System.Windows.Forms.DateTimePicker();
            this.cbxPLCGenero = new System.Windows.Forms.ComboBox();
            this.btnPLCCargar = new System.Windows.Forms.Button();
            this.txtPLCFoto = new System.Windows.Forms.TextBox();
            this.pbPLCFoto = new System.Windows.Forms.PictureBox();
            this.panel18 = new System.Windows.Forms.Panel();
            this.btnPLCBuscar = new System.Windows.Forms.Button();
            this.txtPLCDato = new System.Windows.Forms.TextBox();
            this.cbxPLCCriterio = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPLCSubject = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPeliculas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPLCFoto)).BeginInit();
            this.panel18.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgPeliculas
            // 
            this.dtgPeliculas.AllowUserToAddRows = false;
            this.dtgPeliculas.AllowUserToDeleteRows = false;
            this.dtgPeliculas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgPeliculas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgPeliculas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("DINPro-Bold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(72)))), ((int)(((byte)(146)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgPeliculas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgPeliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("DINPro-Medium", 10.2F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(72)))), ((int)(((byte)(146)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgPeliculas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgPeliculas.EnableHeadersVisualStyles = false;
            this.dtgPeliculas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(72)))), ((int)(((byte)(146)))));
            this.dtgPeliculas.Location = new System.Drawing.Point(14, 76);
            this.dtgPeliculas.Name = "dtgPeliculas";
            this.dtgPeliculas.ReadOnly = true;
            this.dtgPeliculas.RowHeadersWidth = 51;
            this.dtgPeliculas.RowTemplate.Height = 24;
            this.dtgPeliculas.Size = new System.Drawing.Size(579, 450);
            this.dtgPeliculas.TabIndex = 48;
            this.dtgPeliculas.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPeliculas_CellContentDoubleClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(72)))), ((int)(((byte)(146)))));
            this.label12.Location = new System.Drawing.Point(12, 369);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(376, 17);
            this.label12.TabIndex = 25;
            this.label12.Text = "______________________________________________";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("DINPro-Bold", 15F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(72)))), ((int)(((byte)(146)))));
            this.label11.Location = new System.Drawing.Point(11, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 31);
            this.label11.TabIndex = 1;
            this.label11.Text = "Películas";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("DINPro-Bold", 10F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(16, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 21);
            this.label10.TabIndex = 4;
            this.label10.Text = "Título";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("DINPro-Bold", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(16, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Genero";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("DINPro-Bold", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(16, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Debut";
            // 
            // txtPLCTitulo
            // 
            this.txtPLCTitulo.Font = new System.Drawing.Font("DINPro-Bold", 10F, System.Drawing.FontStyle.Bold);
            this.txtPLCTitulo.Location = new System.Drawing.Point(108, 91);
            this.txtPLCTitulo.Name = "txtPLCTitulo";
            this.txtPLCTitulo.Size = new System.Drawing.Size(275, 29);
            this.txtPLCTitulo.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(72)))), ((int)(((byte)(146)))));
            this.label9.Location = new System.Drawing.Point(12, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(376, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "______________________________________________";
            // 
            // btnPLCLimpiar
            // 
            this.btnPLCLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(72)))), ((int)(((byte)(146)))));
            this.btnPLCLimpiar.FlatAppearance.BorderSize = 0;
            this.btnPLCLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPLCLimpiar.Font = new System.Drawing.Font("DINPro-Bold", 10F, System.Drawing.FontStyle.Bold);
            this.btnPLCLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnPLCLimpiar.Location = new System.Drawing.Point(292, 24);
            this.btnPLCLimpiar.Name = "btnPLCLimpiar";
            this.btnPLCLimpiar.Size = new System.Drawing.Size(90, 32);
            this.btnPLCLimpiar.TabIndex = 3;
            this.btnPLCLimpiar.Text = "Limpiar";
            this.btnPLCLimpiar.UseVisualStyleBackColor = false;
            this.btnPLCLimpiar.Click += new System.EventHandler(this.btnPLCLimpiar_Click);
            // 
            // btnPLCModificar
            // 
            this.btnPLCModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(72)))), ((int)(((byte)(146)))));
            this.btnPLCModificar.FlatAppearance.BorderSize = 0;
            this.btnPLCModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPLCModificar.Font = new System.Drawing.Font("DINPro-Bold", 10F, System.Drawing.FontStyle.Bold);
            this.btnPLCModificar.ForeColor = System.Drawing.Color.White;
            this.btnPLCModificar.Location = new System.Drawing.Point(142, 400);
            this.btnPLCModificar.Name = "btnPLCModificar";
            this.btnPLCModificar.Size = new System.Drawing.Size(115, 32);
            this.btnPLCModificar.TabIndex = 22;
            this.btnPLCModificar.Text = "Modificar";
            this.btnPLCModificar.UseVisualStyleBackColor = false;
            this.btnPLCModificar.Click += new System.EventHandler(this.btnPLCModificar_Click);
            // 
            // btnPLCGuardar
            // 
            this.btnPLCGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(72)))), ((int)(((byte)(146)))));
            this.btnPLCGuardar.FlatAppearance.BorderSize = 0;
            this.btnPLCGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPLCGuardar.Font = new System.Drawing.Font("DINPro-Bold", 10F, System.Drawing.FontStyle.Bold);
            this.btnPLCGuardar.ForeColor = System.Drawing.Color.White;
            this.btnPLCGuardar.Location = new System.Drawing.Point(17, 400);
            this.btnPLCGuardar.Name = "btnPLCGuardar";
            this.btnPLCGuardar.Size = new System.Drawing.Size(115, 32);
            this.btnPLCGuardar.TabIndex = 23;
            this.btnPLCGuardar.Text = "Guardar";
            this.btnPLCGuardar.UseVisualStyleBackColor = false;
            this.btnPLCGuardar.Click += new System.EventHandler(this.btnPLCGuardar_Click);
            // 
            // btnPLCEliminar
            // 
            this.btnPLCEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPLCEliminar.FlatAppearance.BorderSize = 0;
            this.btnPLCEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPLCEliminar.Font = new System.Drawing.Font("DINPro-Bold", 10F, System.Drawing.FontStyle.Bold);
            this.btnPLCEliminar.ForeColor = System.Drawing.Color.White;
            this.btnPLCEliminar.Location = new System.Drawing.Point(267, 400);
            this.btnPLCEliminar.Name = "btnPLCEliminar";
            this.btnPLCEliminar.Size = new System.Drawing.Size(115, 32);
            this.btnPLCEliminar.TabIndex = 24;
            this.btnPLCEliminar.Text = "Eliminar";
            this.btnPLCEliminar.UseVisualStyleBackColor = false;
            this.btnPLCEliminar.Click += new System.EventHandler(this.btnPLCEliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("DINPro-Bold", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(16, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 21);
            this.label1.TabIndex = 28;
            this.label1.Text = "Portada";
            // 
            // dtpPLCEstreno
            // 
            this.dtpPLCEstreno.Font = new System.Drawing.Font("DINPro-Bold", 9F, System.Drawing.FontStyle.Bold);
            this.dtpPLCEstreno.Location = new System.Drawing.Point(108, 169);
            this.dtpPLCEstreno.Name = "dtpPLCEstreno";
            this.dtpPLCEstreno.Size = new System.Drawing.Size(273, 27);
            this.dtpPLCEstreno.TabIndex = 29;
            // 
            // cbxPLCGenero
            // 
            this.cbxPLCGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPLCGenero.Font = new System.Drawing.Font("DINPro-Bold", 10F, System.Drawing.FontStyle.Bold);
            this.cbxPLCGenero.FormattingEnabled = true;
            this.cbxPLCGenero.Location = new System.Drawing.Point(106, 128);
            this.cbxPLCGenero.Name = "cbxPLCGenero";
            this.cbxPLCGenero.Size = new System.Drawing.Size(275, 29);
            this.cbxPLCGenero.TabIndex = 31;
            // 
            // btnPLCCargar
            // 
            this.btnPLCCargar.BackgroundImage = global::Peliculas_y_Actores.Properties.Resources.R;
            this.btnPLCCargar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPLCCargar.Location = new System.Drawing.Point(20, 257);
            this.btnPLCCargar.Name = "btnPLCCargar";
            this.btnPLCCargar.Size = new System.Drawing.Size(68, 68);
            this.btnPLCCargar.TabIndex = 32;
            this.btnPLCCargar.UseVisualStyleBackColor = true;
            this.btnPLCCargar.Click += new System.EventHandler(this.btnPLCCargar_Click);
            // 
            // txtPLCFoto
            // 
            this.txtPLCFoto.Location = new System.Drawing.Point(20, 332);
            this.txtPLCFoto.Name = "txtPLCFoto";
            this.txtPLCFoto.Size = new System.Drawing.Size(68, 22);
            this.txtPLCFoto.TabIndex = 33;
            this.txtPLCFoto.Visible = false;
            // 
            // pbPLCFoto
            // 
            this.pbPLCFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPLCFoto.Location = new System.Drawing.Point(108, 212);
            this.pbPLCFoto.Name = "pbPLCFoto";
            this.pbPLCFoto.Size = new System.Drawing.Size(273, 154);
            this.pbPLCFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPLCFoto.TabIndex = 34;
            this.pbPLCFoto.TabStop = false;
            // 
            // panel18
            // 
            this.panel18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel18.Controls.Add(this.pbPLCFoto);
            this.panel18.Controls.Add(this.txtPLCFoto);
            this.panel18.Controls.Add(this.btnPLCCargar);
            this.panel18.Controls.Add(this.cbxPLCGenero);
            this.panel18.Controls.Add(this.dtpPLCEstreno);
            this.panel18.Controls.Add(this.label1);
            this.panel18.Controls.Add(this.btnPLCEliminar);
            this.panel18.Controls.Add(this.btnPLCGuardar);
            this.panel18.Controls.Add(this.btnPLCModificar);
            this.panel18.Controls.Add(this.btnPLCLimpiar);
            this.panel18.Controls.Add(this.label9);
            this.panel18.Controls.Add(this.txtPLCTitulo);
            this.panel18.Controls.Add(this.label4);
            this.panel18.Controls.Add(this.label6);
            this.panel18.Controls.Add(this.label10);
            this.panel18.Controls.Add(this.label11);
            this.panel18.Controls.Add(this.label12);
            this.panel18.Location = new System.Drawing.Point(608, 76);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(398, 450);
            this.panel18.TabIndex = 42;
            // 
            // btnPLCBuscar
            // 
            this.btnPLCBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(72)))), ((int)(((byte)(146)))));
            this.btnPLCBuscar.FlatAppearance.BorderSize = 0;
            this.btnPLCBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(92)))), ((int)(((byte)(166)))));
            this.btnPLCBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPLCBuscar.Font = new System.Drawing.Font("DINPro-Bold", 10F, System.Drawing.FontStyle.Bold);
            this.btnPLCBuscar.ForeColor = System.Drawing.Color.White;
            this.btnPLCBuscar.Location = new System.Drawing.Point(480, 31);
            this.btnPLCBuscar.Name = "btnPLCBuscar";
            this.btnPLCBuscar.Size = new System.Drawing.Size(115, 32);
            this.btnPLCBuscar.TabIndex = 46;
            this.btnPLCBuscar.Text = "Buscar";
            this.btnPLCBuscar.UseVisualStyleBackColor = false;
            this.btnPLCBuscar.Click += new System.EventHandler(this.btnPLCBuscar_Click);
            // 
            // txtPLCDato
            // 
            this.txtPLCDato.Font = new System.Drawing.Font("DINPro-Bold", 10F, System.Drawing.FontStyle.Bold);
            this.txtPLCDato.Location = new System.Drawing.Point(312, 32);
            this.txtPLCDato.Name = "txtPLCDato";
            this.txtPLCDato.Size = new System.Drawing.Size(150, 29);
            this.txtPLCDato.TabIndex = 45;
            // 
            // cbxPLCCriterio
            // 
            this.cbxPLCCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPLCCriterio.Font = new System.Drawing.Font("DINPro-Bold", 10F, System.Drawing.FontStyle.Bold);
            this.cbxPLCCriterio.FormattingEnabled = true;
            this.cbxPLCCriterio.Items.AddRange(new object[] {
            "Titulo",
            "Genero"});
            this.cbxPLCCriterio.Location = new System.Drawing.Point(95, 31);
            this.cbxPLCCriterio.Name = "cbxPLCCriterio";
            this.cbxPLCCriterio.Size = new System.Drawing.Size(150, 29);
            this.cbxPLCCriterio.TabIndex = 44;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("DINPro-Bold", 10F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(18, 34);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 21);
            this.label13.TabIndex = 43;
            this.label13.Text = "Criterio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("DINPro-Bold", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(262, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 21);
            this.label3.TabIndex = 47;
            this.label3.Text = "Dato";
            // 
            // txtPLCSubject
            // 
            this.txtPLCSubject.Font = new System.Drawing.Font("DINPro-Bold", 10F, System.Drawing.FontStyle.Bold);
            this.txtPLCSubject.Location = new System.Drawing.Point(731, 29);
            this.txtPLCSubject.Name = "txtPLCSubject";
            this.txtPLCSubject.Size = new System.Drawing.Size(275, 29);
            this.txtPLCSubject.TabIndex = 35;
            this.txtPLCSubject.Visible = false;
            // 
            // PeliculasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtPLCSubject);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cbxPLCCriterio);
            this.Controls.Add(this.txtPLCDato);
            this.Controls.Add(this.btnPLCBuscar);
            this.Controls.Add(this.panel18);
            this.Controls.Add(this.dtgPeliculas);
            this.Name = "PeliculasForm";
            this.Size = new System.Drawing.Size(1020, 555);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPeliculas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPLCFoto)).EndInit();
            this.panel18.ResumeLayout(false);
            this.panel18.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgPeliculas;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPLCTitulo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnPLCLimpiar;
        private System.Windows.Forms.Button btnPLCModificar;
        private System.Windows.Forms.Button btnPLCGuardar;
        private System.Windows.Forms.Button btnPLCEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpPLCEstreno;
        private System.Windows.Forms.ComboBox cbxPLCGenero;
        private System.Windows.Forms.Button btnPLCCargar;
        private System.Windows.Forms.TextBox txtPLCFoto;
        private System.Windows.Forms.PictureBox pbPLCFoto;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Button btnPLCBuscar;
        private System.Windows.Forms.TextBox txtPLCDato;
        private System.Windows.Forms.ComboBox cbxPLCCriterio;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPLCSubject;
    }
}
