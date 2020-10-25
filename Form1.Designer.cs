namespace BMI_Calculator
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblLengte = new System.Windows.Forms.Label();
            this.lblGewicht = new System.Windows.Forms.Label();
            this.lblLeeftijd = new System.Windows.Forms.Label();
            this.txtLengte = new System.Windows.Forms.TextBox();
            this.txtGewicht = new System.Windows.Forms.TextBox();
            this.txtLeeftijd = new System.Windows.Forms.TextBox();
            this.btnBerekenen = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButtonM = new System.Windows.Forms.RadioButton();
            this.radioButtonV = new System.Windows.Forms.RadioButton();
            this.lblBMI = new System.Windows.Forms.Label();
            this.lblAdvies = new System.Windows.Forms.Label();
            this.lblVrouw = new System.Windows.Forms.Label();
            this.lblEror = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(156, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "BM1 Calculator";
            // 
            // lblLengte
            // 
            this.lblLengte.AutoSize = true;
            this.lblLengte.Location = new System.Drawing.Point(80, 148);
            this.lblLengte.Name = "lblLengte";
            this.lblLengte.Size = new System.Drawing.Size(136, 17);
            this.lblLengte.TabIndex = 1;
            this.lblLengte.Text = "lengte in centimeter:";
            this.lblLengte.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblGewicht
            // 
            this.lblGewicht.AutoSize = true;
            this.lblGewicht.Location = new System.Drawing.Point(83, 193);
            this.lblGewicht.Name = "lblGewicht";
            this.lblGewicht.Size = new System.Drawing.Size(101, 17);
            this.lblGewicht.TabIndex = 2;
            this.lblGewicht.Text = "Gewicht in KG:";
            // 
            // lblLeeftijd
            // 
            this.lblLeeftijd.AutoSize = true;
            this.lblLeeftijd.Location = new System.Drawing.Point(83, 235);
            this.lblLeeftijd.Name = "lblLeeftijd";
            this.lblLeeftijd.Size = new System.Drawing.Size(58, 17);
            this.lblLeeftijd.TabIndex = 3;
            this.lblLeeftijd.Text = "Leeftijd:";
            // 
            // txtLengte
            // 
            this.txtLengte.Location = new System.Drawing.Point(273, 148);
            this.txtLengte.Name = "txtLengte";
            this.txtLengte.Size = new System.Drawing.Size(100, 22);
            this.txtLengte.TabIndex = 4;
            // 
            // txtGewicht
            // 
            this.txtGewicht.Location = new System.Drawing.Point(273, 193);
            this.txtGewicht.Name = "txtGewicht";
            this.txtGewicht.Size = new System.Drawing.Size(100, 22);
            this.txtGewicht.TabIndex = 5;
            // 
            // txtLeeftijd
            // 
            this.txtLeeftijd.Location = new System.Drawing.Point(273, 235);
            this.txtLeeftijd.Name = "txtLeeftijd";
            this.txtLeeftijd.Size = new System.Drawing.Size(100, 22);
            this.txtLeeftijd.TabIndex = 6;
            // 
            // btnBerekenen
            // 
            this.btnBerekenen.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnBerekenen.Location = new System.Drawing.Point(142, 328);
            this.btnBerekenen.Name = "btnBerekenen";
            this.btnBerekenen.Size = new System.Drawing.Size(231, 72);
            this.btnBerekenen.TabIndex = 7;
            this.btnBerekenen.Text = "BMI Berekenen";
            this.btnBerekenen.UseVisualStyleBackColor = true;
            this.btnBerekenen.Click += new System.EventHandler(this.btnBerekenen_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 462);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "BMI:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 502);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Advies:";
            // 
            // radioButtonM
            // 
            this.radioButtonM.AutoSize = true;
            this.radioButtonM.Location = new System.Drawing.Point(422, 328);
            this.radioButtonM.Name = "radioButtonM";
            this.radioButtonM.Size = new System.Drawing.Size(56, 21);
            this.radioButtonM.TabIndex = 12;
            this.radioButtonM.TabStop = true;
            this.radioButtonM.Text = "man";
            this.radioButtonM.UseVisualStyleBackColor = true;
            // 
            // radioButtonV
            // 
            this.radioButtonV.AutoSize = true;
            this.radioButtonV.Location = new System.Drawing.Point(422, 378);
            this.radioButtonV.Name = "radioButtonV";
            this.radioButtonV.Size = new System.Drawing.Size(66, 21);
            this.radioButtonV.TabIndex = 13;
            this.radioButtonV.TabStop = true;
            this.radioButtonV.Text = "vrouw";
            this.radioButtonV.UseVisualStyleBackColor = true;
            this.radioButtonV.CheckedChanged += new System.EventHandler(this.radioButtonV_CheckedChanged);
            // 
            // lblBMI
            // 
            this.lblBMI.AutoSize = true;
            this.lblBMI.Location = new System.Drawing.Point(270, 462);
            this.lblBMI.Name = "lblBMI";
            this.lblBMI.Size = new System.Drawing.Size(0, 17);
            this.lblBMI.TabIndex = 10;
            this.lblBMI.Click += new System.EventHandler(this.lblBMI_Click);
            // 
            // lblAdvies
            // 
            this.lblAdvies.AutoSize = true;
            this.lblAdvies.Location = new System.Drawing.Point(207, 502);
            this.lblAdvies.Name = "lblAdvies";
            this.lblAdvies.Size = new System.Drawing.Size(0, 17);
            this.lblAdvies.TabIndex = 11;
            this.lblAdvies.Click += new System.EventHandler(this.lblAdvies_Click);
            // 
            // lblVrouw
            // 
            this.lblVrouw.AutoSize = true;
            this.lblVrouw.Location = new System.Drawing.Point(216, 542);
            this.lblVrouw.Name = "lblVrouw";
            this.lblVrouw.Size = new System.Drawing.Size(0, 17);
            this.lblVrouw.TabIndex = 14;
            // 
            // lblEror
            // 
            this.lblEror.AutoSize = true;
            this.lblEror.Location = new System.Drawing.Point(285, 115);
            this.lblEror.Name = "lblEror";
            this.lblEror.Size = new System.Drawing.Size(0, 17);
            this.lblEror.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 612);
            this.Controls.Add(this.lblEror);
            this.Controls.Add(this.lblVrouw);
            this.Controls.Add(this.radioButtonV);
            this.Controls.Add(this.radioButtonM);
            this.Controls.Add(this.lblAdvies);
            this.Controls.Add(this.lblBMI);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnBerekenen);
            this.Controls.Add(this.txtLeeftijd);
            this.Controls.Add(this.txtGewicht);
            this.Controls.Add(this.txtLengte);
            this.Controls.Add(this.lblLeeftijd);
            this.Controls.Add(this.lblGewicht);
            this.Controls.Add(this.lblLengte);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLengte;
        private System.Windows.Forms.Label lblGewicht;
        private System.Windows.Forms.Label lblLeeftijd;
        private System.Windows.Forms.TextBox txtLengte;
        private System.Windows.Forms.TextBox txtGewicht;
        private System.Windows.Forms.TextBox txtLeeftijd;
        private System.Windows.Forms.Button btnBerekenen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioButtonM;
        private System.Windows.Forms.RadioButton radioButtonV;
        private System.Windows.Forms.Label lblBMI;
        private System.Windows.Forms.Label lblAdvies;
        private System.Windows.Forms.Label lblVrouw;
        private System.Windows.Forms.Label lblEror;
    }
}

