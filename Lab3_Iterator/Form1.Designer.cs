namespace Lab3_Iterator
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
            this.MiListBox = new System.Windows.Forms.ListBox();
            this.txtTop = new System.Windows.Forms.Button();
            this.txtBottom = new System.Windows.Forms.Button();
            this.txtNext = new System.Windows.Forms.Button();
            this.txtPrevious = new System.Windows.Forms.Button();
            this.txtCentral = new System.Windows.Forms.Button();
            this.txtStep = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblSelected = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // MiListBox
            // 
            this.MiListBox.FormattingEnabled = true;
            this.MiListBox.ItemHeight = 31;
            this.MiListBox.Items.AddRange(new object[] {
            "Alarcon",
            "Caldas",
            "Candela",
            "De la Cruz",
            "Espinoza",
            "Farfan",
            "Gamarra",
            "Lau",
            "Licetti",
            "Miranda",
            "Mora",
            "Mujica",
            "ParedesF",
            "ParedesM",
            "Rivera",
            "Troncos",
            "Villanueva"});
            this.MiListBox.Location = new System.Drawing.Point(137, 83);
            this.MiListBox.Name = "MiListBox";
            this.MiListBox.Size = new System.Drawing.Size(550, 593);
            this.MiListBox.TabIndex = 0;
            // 
            // txtTop
            // 
            this.txtTop.Location = new System.Drawing.Point(800, 83);
            this.txtTop.Name = "txtTop";
            this.txtTop.Size = new System.Drawing.Size(220, 74);
            this.txtTop.TabIndex = 1;
            this.txtTop.Text = "Top";
            this.txtTop.UseVisualStyleBackColor = true;
            this.txtTop.Click += new System.EventHandler(this.txtTop_Click);
            // 
            // txtBottom
            // 
            this.txtBottom.Location = new System.Drawing.Point(800, 201);
            this.txtBottom.Name = "txtBottom";
            this.txtBottom.Size = new System.Drawing.Size(220, 74);
            this.txtBottom.TabIndex = 2;
            this.txtBottom.Text = "Bottom";
            this.txtBottom.UseVisualStyleBackColor = true;
            this.txtBottom.Click += new System.EventHandler(this.txtBottom_Click);
            // 
            // txtNext
            // 
            this.txtNext.Location = new System.Drawing.Point(800, 324);
            this.txtNext.Name = "txtNext";
            this.txtNext.Size = new System.Drawing.Size(220, 74);
            this.txtNext.TabIndex = 4;
            this.txtNext.Text = "Next";
            this.txtNext.UseVisualStyleBackColor = true;
            this.txtNext.Click += new System.EventHandler(this.txtNext_Click);
            // 
            // txtPrevious
            // 
            this.txtPrevious.Location = new System.Drawing.Point(800, 443);
            this.txtPrevious.Name = "txtPrevious";
            this.txtPrevious.Size = new System.Drawing.Size(220, 74);
            this.txtPrevious.TabIndex = 3;
            this.txtPrevious.Text = "Previous";
            this.txtPrevious.UseVisualStyleBackColor = true;
            this.txtPrevious.Click += new System.EventHandler(this.txtPrevious_Click);
            // 
            // txtCentral
            // 
            this.txtCentral.Location = new System.Drawing.Point(800, 573);
            this.txtCentral.Name = "txtCentral";
            this.txtCentral.Size = new System.Drawing.Size(220, 74);
            this.txtCentral.TabIndex = 6;
            this.txtCentral.Text = "Central";
            this.txtCentral.UseVisualStyleBackColor = true;
            this.txtCentral.Click += new System.EventHandler(this.txtCentral_Click);
            // 
            // txtStep
            // 
            this.txtStep.Location = new System.Drawing.Point(925, 783);
            this.txtStep.Name = "txtStep";
            this.txtStep.Size = new System.Drawing.Size(220, 74);
            this.txtStep.TabIndex = 5;
            this.txtStep.Text = "Set Step";
            this.txtStep.UseVisualStyleBackColor = true;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(137, 819);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(550, 38);
            this.txtResult.TabIndex = 7;
            // 
            // lblSelected
            // 
            this.lblSelected.AutoSize = true;
            this.lblSelected.Location = new System.Drawing.Point(137, 747);
            this.lblSelected.Name = "lblSelected";
            this.lblSelected.Size = new System.Drawing.Size(127, 32);
            this.lblSelected.TabIndex = 8;
            this.lblSelected.Text = "Selected";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(800, 819);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(67, 38);
            this.textBox2.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 1095);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblSelected);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtCentral);
            this.Controls.Add(this.txtStep);
            this.Controls.Add(this.txtNext);
            this.Controls.Add(this.txtPrevious);
            this.Controls.Add(this.txtBottom);
            this.Controls.Add(this.txtTop);
            this.Controls.Add(this.MiListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox MiListBox;
        private System.Windows.Forms.Button txtTop;
        private System.Windows.Forms.Button txtBottom;
        private System.Windows.Forms.Button txtNext;
        private System.Windows.Forms.Button txtPrevious;
        private System.Windows.Forms.Button txtCentral;
        private System.Windows.Forms.Button txtStep;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lblSelected;
        private System.Windows.Forms.TextBox textBox2;
    }
}

