namespace serialPortApp
{
    partial class serialPortApp
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
            this.components = new System.ComponentModel.Container();
            this.txtBOX = new System.Windows.Forms.TextBox();
            this.btnSTART = new System.Windows.Forms.Button();
            this.txtSENDDATA = new System.Windows.Forms.TextBox();
            this.btnSEND = new System.Windows.Forms.Button();
            this.serialPORTS = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btnSTOP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBOX
            // 
            this.txtBOX.Location = new System.Drawing.Point(14, 39);
            this.txtBOX.Multiline = true;
            this.txtBOX.Name = "txtBOX";
            this.txtBOX.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBOX.Size = new System.Drawing.Size(494, 321);
            this.txtBOX.TabIndex = 0;
            // 
            // btnSTART
            // 
            this.btnSTART.Location = new System.Drawing.Point(285, 12);
            this.btnSTART.Name = "btnSTART";
            this.btnSTART.Size = new System.Drawing.Size(149, 21);
            this.btnSTART.TabIndex = 2;
            this.btnSTART.Text = "START";
            this.btnSTART.UseVisualStyleBackColor = true;
            this.btnSTART.Click += new System.EventHandler(this.btnSTART_Click);
            // 
            // txtSENDDATA
            // 
            this.txtSENDDATA.Location = new System.Drawing.Point(14, 366);
            this.txtSENDDATA.Multiline = true;
            this.txtSENDDATA.Name = "txtSENDDATA";
            this.txtSENDDATA.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSENDDATA.Size = new System.Drawing.Size(384, 45);
            this.txtSENDDATA.TabIndex = 3;
            this.txtSENDDATA.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSENDDATA_KeyDown);
            // 
            // btnSEND
            // 
            this.btnSEND.Location = new System.Drawing.Point(415, 366);
            this.btnSEND.Name = "btnSEND";
            this.btnSEND.Size = new System.Drawing.Size(91, 44);
            this.btnSEND.TabIndex = 4;
            this.btnSEND.Text = "SEND";
            this.btnSEND.UseVisualStyleBackColor = true;
            this.btnSEND.Click += new System.EventHandler(this.btnSEND_Click);
            // 
            // serialPORTS
            // 
            this.serialPORTS.FormattingEnabled = true;
            this.serialPORTS.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.serialPORTS.Location = new System.Drawing.Point(14, 12);
            this.serialPORTS.Name = "serialPORTS";
            this.serialPORTS.Size = new System.Drawing.Size(265, 21);
            this.serialPORTS.TabIndex = 5;
            this.serialPORTS.Text = "Select COM port";
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM7";
            // 
            // btnSTOP
            // 
            this.btnSTOP.Location = new System.Drawing.Point(440, 12);
            this.btnSTOP.Name = "btnSTOP";
            this.btnSTOP.Size = new System.Drawing.Size(68, 21);
            this.btnSTOP.TabIndex = 6;
            this.btnSTOP.Text = "STOP";
            this.btnSTOP.UseVisualStyleBackColor = true;
            this.btnSTOP.Click += new System.EventHandler(this.btnSTOP_Click);
            // 
            // serialPortApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 417);
            this.Controls.Add(this.btnSTOP);
            this.Controls.Add(this.serialPORTS);
            this.Controls.Add(this.btnSEND);
            this.Controls.Add(this.txtSENDDATA);
            this.Controls.Add(this.btnSTART);
            this.Controls.Add(this.txtBOX);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimizeBox = false;
            this.Name = "serialPortApp";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "serialPortApp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBOX;
        private System.Windows.Forms.Button btnSTART;
        private System.Windows.Forms.TextBox txtSENDDATA;
        private System.Windows.Forms.Button btnSEND;
        private System.Windows.Forms.ComboBox serialPORTS;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btnSTOP;
    }
}

