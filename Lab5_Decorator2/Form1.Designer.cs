namespace Lab5_Decorator2
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
            this.txtDaño = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblPoder = new System.Windows.Forms.Label();
            this.btnOtorgar = new System.Windows.Forms.Button();
            this.cbMarfil = new System.Windows.Forms.CheckBox();
            this.cbOro = new System.Windows.Forms.CheckBox();
            this.cbRubi = new System.Windows.Forms.CheckBox();
            this.cbDiamante = new System.Windows.Forms.CheckBox();
            this.cbEsmeralda = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCls = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDaño
            // 
            this.txtDaño.Location = new System.Drawing.Point(366, 95);
            this.txtDaño.Name = "txtDaño";
            this.txtDaño.Size = new System.Drawing.Size(100, 20);
            this.txtDaño.TabIndex = 5;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(378, 195);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblPoder
            // 
            this.lblPoder.AutoSize = true;
            this.lblPoder.Location = new System.Drawing.Point(396, 254);
            this.lblPoder.Name = "lblPoder";
            this.lblPoder.Size = new System.Drawing.Size(35, 13);
            this.lblPoder.TabIndex = 7;
            this.lblPoder.Text = "label1";
            // 
            // btnOtorgar
            // 
            this.btnOtorgar.Location = new System.Drawing.Point(378, 136);
            this.btnOtorgar.Name = "btnOtorgar";
            this.btnOtorgar.Size = new System.Drawing.Size(75, 23);
            this.btnOtorgar.TabIndex = 8;
            this.btnOtorgar.Text = "Guardar";
            this.btnOtorgar.UseVisualStyleBackColor = true;
            this.btnOtorgar.Click += new System.EventHandler(this.btnOtorgar_Click);
            // 
            // cbMarfil
            // 
            this.cbMarfil.AutoSize = true;
            this.cbMarfil.Location = new System.Drawing.Point(123, 59);
            this.cbMarfil.Name = "cbMarfil";
            this.cbMarfil.Size = new System.Drawing.Size(51, 17);
            this.cbMarfil.TabIndex = 9;
            this.cbMarfil.Text = "Marfil";
            this.cbMarfil.UseVisualStyleBackColor = true;
            // 
            // cbOro
            // 
            this.cbOro.AutoSize = true;
            this.cbOro.Location = new System.Drawing.Point(123, 110);
            this.cbOro.Name = "cbOro";
            this.cbOro.Size = new System.Drawing.Size(43, 17);
            this.cbOro.TabIndex = 10;
            this.cbOro.Text = "Oro";
            this.cbOro.UseVisualStyleBackColor = true;
            this.cbOro.CheckedChanged += new System.EventHandler(this.cbOro_CheckedChanged);
            // 
            // cbRubi
            // 
            this.cbRubi.AutoSize = true;
            this.cbRubi.Location = new System.Drawing.Point(123, 163);
            this.cbRubi.Name = "cbRubi";
            this.cbRubi.Size = new System.Drawing.Size(48, 17);
            this.cbRubi.TabIndex = 11;
            this.cbRubi.Text = "Rubi";
            this.cbRubi.UseVisualStyleBackColor = true;
            this.cbRubi.CheckedChanged += new System.EventHandler(this.cbRubi_CheckedChanged);
            // 
            // cbDiamante
            // 
            this.cbDiamante.AutoSize = true;
            this.cbDiamante.Location = new System.Drawing.Point(123, 268);
            this.cbDiamante.Name = "cbDiamante";
            this.cbDiamante.Size = new System.Drawing.Size(71, 17);
            this.cbDiamante.TabIndex = 13;
            this.cbDiamante.Text = "Diamante";
            this.cbDiamante.UseVisualStyleBackColor = true;
            this.cbDiamante.CheckedChanged += new System.EventHandler(this.cbDiamante_CheckedChanged);
            // 
            // cbEsmeralda
            // 
            this.cbEsmeralda.AutoSize = true;
            this.cbEsmeralda.Location = new System.Drawing.Point(123, 217);
            this.cbEsmeralda.Name = "cbEsmeralda";
            this.cbEsmeralda.Size = new System.Drawing.Size(75, 17);
            this.cbEsmeralda.TabIndex = 12;
            this.cbEsmeralda.Text = "Esmeralda";
            this.cbEsmeralda.UseVisualStyleBackColor = true;
            this.cbEsmeralda.CheckedChanged += new System.EventHandler(this.cbEsmeralda_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(363, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Poder de ataque:";
            // 
            // btnCls
            // 
            this.btnCls.Location = new System.Drawing.Point(378, 300);
            this.btnCls.Name = "btnCls";
            this.btnCls.Size = new System.Drawing.Size(75, 23);
            this.btnCls.TabIndex = 15;
            this.btnCls.Text = "Limpiar";
            this.btnCls.UseVisualStyleBackColor = true;
            this.btnCls.Click += new System.EventHandler(this.btnCls_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 357);
            this.Controls.Add(this.btnCls);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbDiamante);
            this.Controls.Add(this.cbEsmeralda);
            this.Controls.Add(this.cbRubi);
            this.Controls.Add(this.cbOro);
            this.Controls.Add(this.cbMarfil);
            this.Controls.Add(this.btnOtorgar);
            this.Controls.Add(this.lblPoder);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtDaño);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtDaño;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblPoder;
        private System.Windows.Forms.Button btnOtorgar;
        private System.Windows.Forms.CheckBox cbMarfil;
        private System.Windows.Forms.CheckBox cbOro;
        private System.Windows.Forms.CheckBox cbRubi;
        private System.Windows.Forms.CheckBox cbDiamante;
        private System.Windows.Forms.CheckBox cbEsmeralda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCls;
    }
}

