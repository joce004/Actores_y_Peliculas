
namespace Peliculas_y_Actores.Component
{
    partial class ElencoForm
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
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbxELEActor = new System.Windows.Forms.ComboBox();
            this.btnELEEliminar = new System.Windows.Forms.Button();
            this.btnELEAñadir = new System.Windows.Forms.Button();
            this.dgvELE = new System.Windows.Forms.DataGridView();
            this.cbxELEPelicula = new System.Windows.Forms.ComboBox();
            this.pbELEFoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvELE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbELEFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(72)))), ((int)(((byte)(146)))));
            this.label9.Location = new System.Drawing.Point(174, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(376, 17);
            this.label9.TabIndex = 37;
            this.label9.Text = "______________________________________________";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("DINPro-Bold", 15F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(72)))), ((int)(((byte)(146)))));
            this.label11.Location = new System.Drawing.Point(35, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(138, 31);
            this.label11.TabIndex = 36;
            this.label11.Text = "E L E N C O";
            // 
            // cbxELEActor
            // 
            this.cbxELEActor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxELEActor.FormattingEnabled = true;
            this.cbxELEActor.Location = new System.Drawing.Point(41, 437);
            this.cbxELEActor.Name = "cbxELEActor";
            this.cbxELEActor.Size = new System.Drawing.Size(506, 33);
            this.cbxELEActor.TabIndex = 35;
            this.cbxELEActor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxELEActor_KeyPress);
            // 
            // btnELEEliminar
            // 
            this.btnELEEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnELEEliminar.FlatAppearance.BorderSize = 0;
            this.btnELEEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnELEEliminar.Font = new System.Drawing.Font("DINPro-Bold", 10F, System.Drawing.FontStyle.Bold);
            this.btnELEEliminar.ForeColor = System.Drawing.Color.White;
            this.btnELEEliminar.Location = new System.Drawing.Point(308, 486);
            this.btnELEEliminar.Name = "btnELEEliminar";
            this.btnELEEliminar.Size = new System.Drawing.Size(239, 32);
            this.btnELEEliminar.TabIndex = 34;
            this.btnELEEliminar.Text = "Eliminar";
            this.btnELEEliminar.UseVisualStyleBackColor = false;
            this.btnELEEliminar.Click += new System.EventHandler(this.btnELEEliminar_Click);
            // 
            // btnELEAñadir
            // 
            this.btnELEAñadir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(72)))), ((int)(((byte)(146)))));
            this.btnELEAñadir.FlatAppearance.BorderSize = 0;
            this.btnELEAñadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnELEAñadir.Font = new System.Drawing.Font("DINPro-Bold", 10F, System.Drawing.FontStyle.Bold);
            this.btnELEAñadir.ForeColor = System.Drawing.Color.White;
            this.btnELEAñadir.Location = new System.Drawing.Point(41, 486);
            this.btnELEAñadir.Name = "btnELEAñadir";
            this.btnELEAñadir.Size = new System.Drawing.Size(244, 32);
            this.btnELEAñadir.TabIndex = 33;
            this.btnELEAñadir.Text = "Añadir";
            this.btnELEAñadir.UseVisualStyleBackColor = false;
            this.btnELEAñadir.Click += new System.EventHandler(this.btnELEAñadir_Click);
            // 
            // dgvELE
            // 
            this.dgvELE.AllowUserToAddRows = false;
            this.dgvELE.AllowUserToDeleteRows = false;
            this.dgvELE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvELE.Location = new System.Drawing.Point(41, 146);
            this.dgvELE.Name = "dgvELE";
            this.dgvELE.ReadOnly = true;
            this.dgvELE.RowHeadersWidth = 51;
            this.dgvELE.RowTemplate.Height = 24;
            this.dgvELE.Size = new System.Drawing.Size(506, 258);
            this.dgvELE.TabIndex = 32;
            this.dgvELE.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvELE_CellContentDoubleClick);
            // 
            // cbxELEPelicula
            // 
            this.cbxELEPelicula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxELEPelicula.FormattingEnabled = true;
            this.cbxELEPelicula.Location = new System.Drawing.Point(41, 36);
            this.cbxELEPelicula.Name = "cbxELEPelicula";
            this.cbxELEPelicula.Size = new System.Drawing.Size(509, 33);
            this.cbxELEPelicula.TabIndex = 31;
            this.cbxELEPelicula.SelectedValueChanged += new System.EventHandler(this.cbxELEPelicula_SelectedValueChanged);
            this.cbxELEPelicula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxELEPelicula_KeyPress);
            // 
            // pbELEFoto
            // 
            this.pbELEFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbELEFoto.Location = new System.Drawing.Point(582, 36);
            this.pbELEFoto.Name = "pbELEFoto";
            this.pbELEFoto.Size = new System.Drawing.Size(403, 482);
            this.pbELEFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbELEFoto.TabIndex = 30;
            this.pbELEFoto.TabStop = false;
            // 
            // ElencoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbxELEActor);
            this.Controls.Add(this.btnELEEliminar);
            this.Controls.Add(this.btnELEAñadir);
            this.Controls.Add(this.dgvELE);
            this.Controls.Add(this.cbxELEPelicula);
            this.Controls.Add(this.pbELEFoto);
            this.Name = "ElencoForm";
            this.Size = new System.Drawing.Size(1020, 555);
            ((System.ComponentModel.ISupportInitialize)(this.dgvELE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbELEFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbxELEActor;
        private System.Windows.Forms.Button btnELEEliminar;
        private System.Windows.Forms.Button btnELEAñadir;
        private System.Windows.Forms.DataGridView dgvELE;
        private System.Windows.Forms.ComboBox cbxELEPelicula;
        private System.Windows.Forms.PictureBox pbELEFoto;
    }
}
