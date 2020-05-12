namespace Lab1_Bridge
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
            this.rbDDMMAA = new System.Windows.Forms.RadioButton();
            this.rbBE = new System.Windows.Forms.RadioButton();
            this.rbMMDDAA = new System.Windows.Forms.RadioButton();
            this.btnAyer = new System.Windows.Forms.Button();
            this.btnManiana = new System.Windows.Forms.Button();
            this.btnHoy = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rbDDMMAA
            // 
            this.rbDDMMAA.AutoSize = true;
            this.rbDDMMAA.Location = new System.Drawing.Point(551, 108);
            this.rbDDMMAA.Name = "rbDDMMAA";
            this.rbDDMMAA.Size = new System.Drawing.Size(148, 33);
            this.rbDDMMAA.TabIndex = 0;
            this.rbDDMMAA.TabStop = true;
            this.rbDDMMAA.Text = "DDMMAA";
            this.rbDDMMAA.UseVisualStyleBackColor = true;
            this.rbDDMMAA.CheckedChanged += new System.EventHandler(this.rbDDMMAA_CheckedChanged);
            // 
            // rbBE
            // 
            this.rbBE.AutoSize = true;
            this.rbBE.Location = new System.Drawing.Point(551, 229);
            this.rbBE.Name = "rbBE";
            this.rbBE.Size = new System.Drawing.Size(155, 33);
            this.rbBE.TabIndex = 1;
            this.rbBE.TabStop = true;
            this.rbBE.Text = "BigEndian";
            this.rbBE.UseVisualStyleBackColor = true;
            this.rbBE.CheckedChanged += new System.EventHandler(this.rbBE_CheckedChanged);
            // 
            // rbMMDDAA
            // 
            this.rbMMDDAA.AutoSize = true;
            this.rbMMDDAA.Location = new System.Drawing.Point(551, 347);
            this.rbMMDDAA.Name = "rbMMDDAA";
            this.rbMMDDAA.Size = new System.Drawing.Size(148, 33);
            this.rbMMDDAA.TabIndex = 2;
            this.rbMMDDAA.TabStop = true;
            this.rbMMDDAA.Text = "MMDDAA";
            this.rbMMDDAA.UseVisualStyleBackColor = true;
            this.rbMMDDAA.CheckedChanged += new System.EventHandler(this.rbMMDDAA_CheckedChanged);
            // 
            // btnAyer
            // 
            this.btnAyer.Location = new System.Drawing.Point(132, 465);
            this.btnAyer.Name = "btnAyer";
            this.btnAyer.Size = new System.Drawing.Size(213, 56);
            this.btnAyer.TabIndex = 3;
            this.btnAyer.Text = "Ayer";
            this.btnAyer.UseVisualStyleBackColor = true;
            this.btnAyer.Click += new System.EventHandler(this.btnAyer_Click);
            // 
            // btnManiana
            // 
            this.btnManiana.Location = new System.Drawing.Point(511, 465);
            this.btnManiana.Name = "btnManiana";
            this.btnManiana.Size = new System.Drawing.Size(213, 56);
            this.btnManiana.TabIndex = 4;
            this.btnManiana.Text = "Mañana";
            this.btnManiana.UseVisualStyleBackColor = true;
            this.btnManiana.Click += new System.EventHandler(this.btnManiana_Click);
            // 
            // btnHoy
            // 
            this.btnHoy.Location = new System.Drawing.Point(890, 465);
            this.btnHoy.Name = "btnHoy";
            this.btnHoy.Size = new System.Drawing.Size(213, 56);
            this.btnHoy.TabIndex = 5;
            this.btnHoy.Text = "Hoy";
            this.btnHoy.UseVisualStyleBackColor = true;
            this.btnHoy.Click += new System.EventHandler(this.btnHoy_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(383, 621);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(458, 35);
            this.txtResult.TabIndex = 6;
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 873);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnHoy);
            this.Controls.Add(this.btnManiana);
            this.Controls.Add(this.btnAyer);
            this.Controls.Add(this.rbMMDDAA);
            this.Controls.Add(this.rbBE);
            this.Controls.Add(this.rbDDMMAA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbDDMMAA;
        private System.Windows.Forms.RadioButton rbBE;
        private System.Windows.Forms.RadioButton rbMMDDAA;
        private System.Windows.Forms.Button btnAyer;
        private System.Windows.Forms.Button btnManiana;
        private System.Windows.Forms.Button btnHoy;
        private System.Windows.Forms.TextBox txtResult;
    }
}

