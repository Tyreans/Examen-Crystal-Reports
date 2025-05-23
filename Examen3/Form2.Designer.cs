namespace Examen3
{
    partial class Form2
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.numPrecio = new System.Windows.Forms.NumericUpDown();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.numCanti = new System.Windows.Forms.NumericUpDown();
            this.rtbDescr = new System.Windows.Forms.RichTextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.btnAlta = new System.Windows.Forms.Button();
            this.btnCanc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCanti)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(13, 69);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(65, 20);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(99, 69);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(120, 26);
            this.tbNombre.TabIndex = 1;
            // 
            // numPrecio
            // 
            this.numPrecio.Location = new System.Drawing.Point(99, 118);
            this.numPrecio.Maximum = new decimal(new int[] {
            1874919423,
            2328306,
            0,
            0});
            this.numPrecio.Name = "numPrecio";
            this.numPrecio.Size = new System.Drawing.Size(120, 26);
            this.numPrecio.TabIndex = 2;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(13, 124);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(53, 20);
            this.lblPrecio.TabIndex = 3;
            this.lblPrecio.Text = "Precio";
            this.lblPrecio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(13, 174);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(73, 20);
            this.lblCantidad.TabIndex = 5;
            this.lblCantidad.Text = "Cantidad";
            // 
            // numCanti
            // 
            this.numCanti.Location = new System.Drawing.Point(99, 168);
            this.numCanti.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.numCanti.Name = "numCanti";
            this.numCanti.Size = new System.Drawing.Size(120, 26);
            this.numCanti.TabIndex = 4;
            // 
            // rtbDescr
            // 
            this.rtbDescr.Location = new System.Drawing.Point(346, 27);
            this.rtbDescr.Name = "rtbDescr";
            this.rtbDescr.Size = new System.Drawing.Size(309, 311);
            this.rtbDescr.TabIndex = 6;
            this.rtbDescr.Text = "";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(235, 30);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(92, 20);
            this.lblDescripcion.TabIndex = 7;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(18, 303);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(133, 35);
            this.btnAlta.TabIndex = 8;
            this.btnAlta.Text = "Registrar";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // btnCanc
            // 
            this.btnCanc.Location = new System.Drawing.Point(194, 303);
            this.btnCanc.Name = "btnCanc";
            this.btnCanc.Size = new System.Drawing.Size(133, 35);
            this.btnCanc.TabIndex = 9;
            this.btnCanc.Text = "Cancelar";
            this.btnCanc.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 450);
            this.Controls.Add(this.btnCanc);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.rtbDescr);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.numCanti);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.numPrecio);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.lblNombre);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.numPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCanti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.NumericUpDown numPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.NumericUpDown numCanti;
        private System.Windows.Forms.RichTextBox rtbDescr;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Button btnCanc;
    }
}