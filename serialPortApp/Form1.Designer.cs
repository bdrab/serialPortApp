namespace serialPortApp
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
            this.components = new System.ComponentModel.Container();
            this.txtBOX = new System.Windows.Forms.TextBox();
            this.btnSTART = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.serialPORTS = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btnSTOP = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // txtBOX
            // 
            this.txtBOX.Location = new System.Drawing.Point(14, 60);
            this.txtBOX.Multiline = true;
            this.txtBOX.Name = "txtBOX";
            this.txtBOX.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBOX.Size = new System.Drawing.Size(494, 300);
            this.txtBOX.TabIndex = 0;
            // 
            // btnSTART
            // 
            this.btnSTART.Location = new System.Drawing.Point(318, 12);
            this.btnSTART.Name = "btnSTART";
            this.btnSTART.Size = new System.Drawing.Size(80, 19);
            this.btnSTART.TabIndex = 2;
            this.btnSTART.Text = "START";
            this.btnSTART.UseVisualStyleBackColor = true;
            this.btnSTART.Click += new System.EventHandler(this.btnSTART_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(14, 366);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox3.Size = new System.Drawing.Size(384, 45);
            this.textBox3.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(415, 366);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 44);
            this.button2.TabIndex = 4;
            this.button2.Text = "SEND";
            this.button2.UseVisualStyleBackColor = true;
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
            this.serialPORTS.Location = new System.Drawing.Point(32, 9);
            this.serialPORTS.Name = "serialPORTS";
            this.serialPORTS.Size = new System.Drawing.Size(248, 21);
            this.serialPORTS.TabIndex = 5;
            this.serialPORTS.Text = "Select COM port";
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM7";
            // 
            // btnSTOP
            // 
            this.btnSTOP.Location = new System.Drawing.Point(428, 12);
            this.btnSTOP.Name = "btnSTOP";
            this.btnSTOP.Size = new System.Drawing.Size(80, 19);
            this.btnSTOP.TabIndex = 6;
            this.btnSTOP.Text = "STOP";
            this.btnSTOP.UseVisualStyleBackColor = true;
            this.btnSTOP.Click += new System.EventHandler(this.btnSTOP_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(14, 40);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(491, 20);
            this.progressBar1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 417);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnSTOP);
            this.Controls.Add(this.serialPORTS);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.btnSTART);
            this.Controls.Add(this.txtBOX);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBOX;
        private System.Windows.Forms.Button btnSTART;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox serialPORTS;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btnSTOP;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

