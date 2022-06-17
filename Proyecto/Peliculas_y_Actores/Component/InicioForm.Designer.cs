
namespace Peliculas_y_Actores
{
    partial class InicioForm
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
            this.pbInicio = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbInicio)).BeginInit();
            this.SuspendLayout();
            // 
            // pbInicio
            // 
            this.pbInicio.BackgroundImage = global::Peliculas_y_Actores.Properties.Resources.download;
            this.pbInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbInicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbInicio.Location = new System.Drawing.Point(0, 0);
            this.pbInicio.Name = "pbInicio";
            this.pbInicio.Size = new System.Drawing.Size(1020, 555);
            this.pbInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbInicio.TabIndex = 0;
            this.pbInicio.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("DINPro-Bold", 25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(49, 455);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bienvenido";
            // 
            // InicioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbInicio);
            this.Name = "InicioForm";
            this.Size = new System.Drawing.Size(1020, 555);
            ((System.ComponentModel.ISupportInitialize)(this.pbInicio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbInicio;
        private System.Windows.Forms.Label label1;
    }
}
