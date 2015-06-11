namespace ParseFileForDataProcessing
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
            this.button2 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.footer_TB = new System.Windows.Forms.TextBox();
            this.header_TB = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.cr_sr_RB = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.data_fields_NUD = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_fields_NUD)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(205, 242);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 55);
            this.button2.TabIndex = 1;
            this.button2.Text = "Parse Data";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(239, 303);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(52, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Done";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.data_fields_NUD);
            this.groupBox1.Controls.Add(this.footer_TB);
            this.groupBox1.Controls.Add(this.header_TB);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.cr_sr_RB);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 232);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // footer_TB
            // 
            this.footer_TB.Location = new System.Drawing.Point(193, 59);
            this.footer_TB.Name = "footer_TB";
            this.footer_TB.Size = new System.Drawing.Size(100, 20);
            this.footer_TB.TabIndex = 20;
            this.footer_TB.Text = ";";
            // 
            // header_TB
            // 
            this.header_TB.Location = new System.Drawing.Point(9, 59);
            this.header_TB.Name = "header_TB";
            this.header_TB.Size = new System.Drawing.Size(100, 20);
            this.header_TB.TabIndex = 19;
            this.header_TB.Text = "x:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(9, 114);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(54, 20);
            this.textBox2.TabIndex = 18;
            this.textBox2.Text = ",";
            // 
            // cr_sr_RB
            // 
            this.cr_sr_RB.AutoSize = true;
            this.cr_sr_RB.Location = new System.Drawing.Point(6, 19);
            this.cr_sr_RB.Name = "cr_sr_RB";
            this.cr_sr_RB.Size = new System.Drawing.Size(103, 17);
            this.cr_sr_RB.TabIndex = 17;
            this.cr_sr_RB.TabStop = true;
            this.cr_sr_RB.Text = "Comma Replace";
            this.cr_sr_RB.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(190, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Footer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Header";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Input Data Delimiter (default is a comma)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Output Data Delimiter (default is one whitespace char)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 159);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(54, 18);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = " ";
            // 
            // data_fields_NUD
            // 
            this.data_fields_NUD.Location = new System.Drawing.Point(9, 206);
            this.data_fields_NUD.Name = "data_fields_NUD";
            this.data_fields_NUD.Size = new System.Drawing.Size(54, 20);
            this.data_fields_NUD.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Number of Data Fields";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 341);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button2);
            this.Name = "Form1";
            this.Text = "IMU-10 Data Processor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_fields_NUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox footer_TB;
        private System.Windows.Forms.TextBox header_TB;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton cr_sr_RB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown data_fields_NUD;
        private System.Windows.Forms.Label label5;
    }
}

