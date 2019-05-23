namespace Service_Station_Manager
{
    partial class GarageForm
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
            this.radioButtonOpen = new System.Windows.Forms.RadioButton();
            this.radioButtonClose = new System.Windows.Forms.RadioButton();
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
            this.buttonOK.Location = new System.Drawing.Point(12, 100);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(60, 23);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackgroundImage = global::Service_Station_Manager.Properties.Resources.cancel;
            this.buttonCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.FlatAppearance.BorderSize = 0;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Location = new System.Drawing.Point(94, 100);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(59, 23);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // radioButtonOpen
            // 
            this.radioButtonOpen.AutoSize = true;
            this.radioButtonOpen.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.radioButtonOpen.Checked = true;
            this.radioButtonOpen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButtonOpen.Location = new System.Drawing.Point(28, 37);
            this.radioButtonOpen.Name = "radioButtonOpen";
            this.radioButtonOpen.Size = new System.Drawing.Size(109, 17);
            this.radioButtonOpen.TabIndex = 5;
            this.radioButtonOpen.TabStop = true;
            this.radioButtonOpen.Text = "Garage is opened";
            this.radioButtonOpen.UseVisualStyleBackColor = false;
            // 
            // radioButtonClose
            // 
            this.radioButtonClose.AutoSize = true;
            this.radioButtonClose.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.radioButtonClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButtonClose.Location = new System.Drawing.Point(28, 60);
            this.radioButtonClose.Name = "radioButtonClose";
            this.radioButtonClose.Size = new System.Drawing.Size(104, 17);
            this.radioButtonClose.TabIndex = 6;
            this.radioButtonClose.Text = "Garage is closed";
            this.radioButtonClose.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(141, 82);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Condition";
            // 
            // GarageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(165, 131);
            this.ControlBox = false;
            this.Controls.Add(this.radioButtonClose);
            this.Controls.Add(this.radioButtonOpen);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GarageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.GarageForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        protected internal System.Windows.Forms.RadioButton radioButtonOpen;
        protected internal System.Windows.Forms.RadioButton radioButtonClose;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}