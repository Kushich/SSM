namespace Service_Station_Manager
{
    partial class InstallationForm
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
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxClient = new System.Windows.Forms.TextBox();
            this.textBoxCar = new System.Windows.Forms.TextBox();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.textBoxGarage = new System.Windows.Forms.TextBox();
            this.textBoxEmployee = new System.Windows.Forms.TextBox();
            this.textBoxPart = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.BackgroundImage = global::Service_Station_Manager.Properties.Resources.OK;
            this.buttonOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.FlatAppearance.BorderSize = 0;
            this.buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOK.Location = new System.Drawing.Point(13, 203);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 1;
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackgroundImage = global::Service_Station_Manager.Properties.Resources.cancel;
            this.buttonCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.FlatAppearance.BorderSize = 0;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Location = new System.Drawing.Point(138, 203);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // textBoxClient
            // 
            this.textBoxClient.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxClient.Location = new System.Drawing.Point(102, 27);
            this.textBoxClient.Name = "textBoxClient";
            this.textBoxClient.Size = new System.Drawing.Size(100, 20);
            this.textBoxClient.TabIndex = 3;
            // 
            // textBoxCar
            // 
            this.textBoxCar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxCar.Location = new System.Drawing.Point(102, 53);
            this.textBoxCar.Name = "textBoxCar";
            this.textBoxCar.Size = new System.Drawing.Size(100, 20);
            this.textBoxCar.TabIndex = 4;
            // 
            // textBoxType
            // 
            this.textBoxType.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxType.Location = new System.Drawing.Point(102, 79);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new System.Drawing.Size(100, 20);
            this.textBoxType.TabIndex = 5;
            // 
            // textBoxGarage
            // 
            this.textBoxGarage.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxGarage.Location = new System.Drawing.Point(102, 158);
            this.textBoxGarage.Name = "textBoxGarage";
            this.textBoxGarage.Size = new System.Drawing.Size(100, 20);
            this.textBoxGarage.TabIndex = 8;
            // 
            // textBoxEmployee
            // 
            this.textBoxEmployee.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxEmployee.Location = new System.Drawing.Point(102, 132);
            this.textBoxEmployee.Name = "textBoxEmployee";
            this.textBoxEmployee.Size = new System.Drawing.Size(100, 20);
            this.textBoxEmployee.TabIndex = 7;
            // 
            // textBoxPart
            // 
            this.textBoxPart.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxPart.Location = new System.Drawing.Point(102, 106);
            this.textBoxPart.Name = "textBoxPart";
            this.textBoxPart.Size = new System.Drawing.Size(100, 20);
            this.textBoxPart.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(28, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "ID Client";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(28, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "ID Car";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(28, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "ID Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(28, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "ID Part";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(28, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "ID Employee";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(28, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "ID Garage";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.groupBox1.Location = new System.Drawing.Point(13, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 190);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // InstallationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(225, 241);
            this.ControlBox = false;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxGarage);
            this.Controls.Add(this.textBoxEmployee);
            this.Controls.Add(this.textBoxPart);
            this.Controls.Add(this.textBoxType);
            this.Controls.Add(this.textBoxCar);
            this.Controls.Add(this.textBoxClient);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "InstallationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.InstallationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        protected internal System.Windows.Forms.TextBox textBoxClient;
        protected internal System.Windows.Forms.TextBox textBoxCar;
        protected internal System.Windows.Forms.TextBox textBoxType;
        protected internal System.Windows.Forms.TextBox textBoxGarage;
        protected internal System.Windows.Forms.TextBox textBoxEmployee;
        protected internal System.Windows.Forms.TextBox textBoxPart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}