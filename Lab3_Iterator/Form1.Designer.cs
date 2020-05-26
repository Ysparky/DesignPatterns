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
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblSelected = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // MiListBox
            // 
            this.MiListBox.FormattingEnabled = true;
            this.MiListBox.ItemHeight = 29;
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
            this.MiListBox.Location = new System.Drawing.Point(119, 78);
            this.MiListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MiListBox.Name = "MiListBox";
            this.MiListBox.Size = new System.Drawing.Size(482, 555);
            this.MiListBox.TabIndex = 0;
            // 
            // txtTop
            // 
            this.txtTop.Location = new System.Drawing.Point(700, 78);
            this.txtTop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTop.Name = "txtTop";
            this.txtTop.Size = new System.Drawing.Size(191, 69);
            this.txtTop.TabIndex = 1;
            this.txtTop.Text = "Top";
            this.txtTop.UseVisualStyleBackColor = true;
            this.txtTop.Click += new System.EventHandler(this.txtTop_Click);
            // 
            // txtBottom
            // 
            this.txtBottom.Location = new System.Drawing.Point(700, 187);
            this.txtBottom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBottom.Name = "txtBottom";
            this.txtBottom.Size = new System.Drawing.Size(191, 69);
            this.txtBottom.TabIndex = 2;
            this.txtBottom.Text = "Bottom";
            this.txtBottom.UseVisualStyleBackColor = true;
            this.txtBottom.Click += new System.EventHandler(this.txtBottom_Click);
            // 
            // txtNext
            // 
            this.txtNext.Location = new System.Drawing.Point(700, 303);
            this.txtNext.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNext.Name = "txtNext";
            this.txtNext.Size = new System.Drawing.Size(191, 69);
            this.txtNext.TabIndex = 4;
            this.txtNext.Text = "Next";
            this.txtNext.UseVisualStyleBackColor = true;
            this.txtNext.Click += new System.EventHandler(this.txtNext_Click);
            // 
            // txtPrevious
            // 
            this.txtPrevious.Location = new System.Drawing.Point(700, 415);
            this.txtPrevious.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPrevious.Name = "txtPrevious";
            this.txtPrevious.Size = new System.Drawing.Size(191, 69);
            this.txtPrevious.TabIndex = 3;
            this.txtPrevious.Text = "Previous";
            this.txtPrevious.UseVisualStyleBackColor = true;
            this.txtPrevious.Click += new System.EventHandler(this.txtPrevious_Click);
            // 
            // txtCentral
            // 
            this.txtCentral.Location = new System.Drawing.Point(700, 535);
            this.txtCentral.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCentral.Name = "txtCentral";
            this.txtCentral.Size = new System.Drawing.Size(191, 69);
            this.txtCentral.TabIndex = 6;
            this.txtCentral.Text = "Central";
            this.txtCentral.UseVisualStyleBackColor = true;
            this.txtCentral.Click += new System.EventHandler(this.txtCentral_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(119, 765);
            this.txtResult.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(482, 35);
            this.txtResult.TabIndex = 7;
            // 
            // lblSelected
            // 
            this.lblSelected.AutoSize = true;
            this.lblSelected.Location = new System.Drawing.Point(119, 698);
            this.lblSelected.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSelected.Name = "lblSelected";
            this.lblSelected.Size = new System.Drawing.Size(109, 29);
            this.lblSelected.TabIndex = 8;
            this.lblSelected.Text = "Selected";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(1130, 321);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(180, 33);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(1130, 474);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(180, 33);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(1130, 600);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(180, 33);
            this.radioButton3.TabIndex = 11;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1523, 881);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.lblSelected);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtCentral);
            this.Controls.Add(this.txtNext);
            this.Controls.Add(this.txtPrevious);
            this.Controls.Add(this.txtBottom);
            this.Controls.Add(this.txtTop);
            this.Controls.Add(this.MiListBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lblSelected;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
    }
}

