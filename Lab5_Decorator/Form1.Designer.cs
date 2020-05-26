namespace Lab5_Decorator
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbAnchoas = new System.Windows.Forms.CheckBox();
            this.cbQueso = new System.Windows.Forms.CheckBox();
            this.cbJalapeño = new System.Windows.Forms.CheckBox();
            this.cbPiña = new System.Windows.Forms.CheckBox();
            this.cbChorizo = new System.Windows.Forms.CheckBox();
            this.btnPrecio = new System.Windows.Forms.Button();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.btnPizza = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbAnchoas
            // 
            this.cbAnchoas.AutoSize = true;
            this.cbAnchoas.Location = new System.Drawing.Point(239, 109);
            this.cbAnchoas.Name = "cbAnchoas";
            this.cbAnchoas.Size = new System.Drawing.Size(113, 17);
            this.cbAnchoas.TabIndex = 0;
            this.cbAnchoas.Text = "Anchoas : S/ 6.00";
            this.cbAnchoas.UseVisualStyleBackColor = true;
            this.cbAnchoas.CheckedChanged += new System.EventHandler(this.cbAnchoas_CheckedChanged);
            // 
            // cbQueso
            // 
            this.cbQueso.AutoSize = true;
            this.cbQueso.Location = new System.Drawing.Point(239, 179);
            this.cbQueso.Name = "cbQueso";
            this.cbQueso.Size = new System.Drawing.Size(102, 17);
            this.cbQueso.TabIndex = 1;
            this.cbQueso.Text = "Queso : S/ 5.00";
            this.cbQueso.UseVisualStyleBackColor = true;
            this.cbQueso.CheckedChanged += new System.EventHandler(this.cbQueso_CheckedChanged);
            // 
            // cbJalapeño
            // 
            this.cbJalapeño.AutoSize = true;
            this.cbJalapeño.Location = new System.Drawing.Point(239, 244);
            this.cbJalapeño.Name = "cbJalapeño";
            this.cbJalapeño.Size = new System.Drawing.Size(114, 17);
            this.cbJalapeño.TabIndex = 3;
            this.cbJalapeño.Text = "Jalapeño : S/ 4.00";
            this.cbJalapeño.UseVisualStyleBackColor = true;
            this.cbJalapeño.CheckedChanged += new System.EventHandler(this.cbJalapeño_CheckedChanged);
            // 
            // cbPiña
            // 
            this.cbPiña.AutoSize = true;
            this.cbPiña.Location = new System.Drawing.Point(72, 109);
            this.cbPiña.Name = "cbPiña";
            this.cbPiña.Size = new System.Drawing.Size(92, 17);
            this.cbPiña.TabIndex = 2;
            this.cbPiña.Text = "Piña : S/ 2.00";
            this.cbPiña.UseVisualStyleBackColor = true;
            this.cbPiña.CheckedChanged += new System.EventHandler(this.cbPiña_CheckedChanged);
            // 
            // cbChorizo
            // 
            this.cbChorizo.AutoSize = true;
            this.cbChorizo.Location = new System.Drawing.Point(72, 179);
            this.cbChorizo.Name = "cbChorizo";
            this.cbChorizo.Size = new System.Drawing.Size(106, 17);
            this.cbChorizo.TabIndex = 4;
            this.cbChorizo.Text = "Chorizo : S/ 3.50";
            this.cbChorizo.UseVisualStyleBackColor = true;
            this.cbChorizo.CheckedChanged += new System.EventHandler(this.cbChorizo_CheckedChanged);
            // 
            // btnPrecio
            // 
            this.btnPrecio.Location = new System.Drawing.Point(72, 310);
            this.btnPrecio.Name = "btnPrecio";
            this.btnPrecio.Size = new System.Drawing.Size(119, 28);
            this.btnPrecio.TabIndex = 5;
            this.btnPrecio.Text = "Consultar precio";
            this.btnPrecio.UseVisualStyleBackColor = true;
            this.btnPrecio.Click += new System.EventHandler(this.btnPrecio_Click);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(236, 310);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(0, 13);
            this.lblPrecio.TabIndex = 6;
            // 
            // btnPizza
            // 
            this.btnPizza.Location = new System.Drawing.Point(143, 39);
            this.btnPizza.Name = "btnPizza";
            this.btnPizza.Size = new System.Drawing.Size(116, 23);
            this.btnPizza.TabIndex = 0;
            this.btnPizza.Text = "Crear pizza";
            this.btnPizza.Click += new System.EventHandler(this.btnPizza_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 403);
            this.Controls.Add(this.btnPizza);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.btnPrecio);
            this.Controls.Add(this.cbChorizo);
            this.Controls.Add(this.cbJalapeño);
            this.Controls.Add(this.cbPiña);
            this.Controls.Add(this.cbQueso);
            this.Controls.Add(this.cbAnchoas);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbAnchoas;
        private System.Windows.Forms.CheckBox cbQueso;
        private System.Windows.Forms.CheckBox cbJalapeño;
        private System.Windows.Forms.CheckBox cbPiña;
        private System.Windows.Forms.CheckBox cbChorizo;
        private System.Windows.Forms.Button btnPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Button btnPizza;
    }
}

