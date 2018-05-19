namespace Server
{
    partial class FormServer
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
            this.listBoxserver = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonsendnoise = new System.Windows.Forms.Button();
            this.textBoxmessnoise = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxmessage = new System.Windows.Forms.TextBox();
            this.buttonsend = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labeltimer1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxkey = new System.Windows.Forms.TextBox();
            this.textBoxiv = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxserver
            // 
            this.listBoxserver.FormattingEnabled = true;
            this.listBoxserver.Location = new System.Drawing.Point(3, 12);
            this.listBoxserver.Name = "listBoxserver";
            this.listBoxserver.Size = new System.Drawing.Size(623, 277);
            this.listBoxserver.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonsendnoise);
            this.groupBox3.Controls.Add(this.textBoxmessnoise);
            this.groupBox3.Location = new System.Drawing.Point(3, 499);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(623, 89);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Message Noise";
            // 
            // buttonsendnoise
            // 
            this.buttonsendnoise.Location = new System.Drawing.Point(537, 27);
            this.buttonsendnoise.Name = "buttonsendnoise";
            this.buttonsendnoise.Size = new System.Drawing.Size(75, 46);
            this.buttonsendnoise.TabIndex = 7;
            this.buttonsendnoise.Text = "Send Noise";
            this.buttonsendnoise.UseVisualStyleBackColor = true;
            this.buttonsendnoise.Click += new System.EventHandler(this.buttonsendnoise_Click);
            // 
            // textBoxmessnoise
            // 
            this.textBoxmessnoise.Location = new System.Drawing.Point(4, 27);
            this.textBoxmessnoise.Multiline = true;
            this.textBoxmessnoise.Name = "textBoxmessnoise";
            this.textBoxmessnoise.Size = new System.Drawing.Size(522, 46);
            this.textBoxmessnoise.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxmessage);
            this.groupBox2.Controls.Add(this.buttonsend);
            this.groupBox2.Location = new System.Drawing.Point(3, 393);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(623, 100);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Message";
            // 
            // textBoxmessage
            // 
            this.textBoxmessage.Location = new System.Drawing.Point(9, 39);
            this.textBoxmessage.Multiline = true;
            this.textBoxmessage.Name = "textBoxmessage";
            this.textBoxmessage.Size = new System.Drawing.Size(522, 46);
            this.textBoxmessage.TabIndex = 5;
            // 
            // buttonsend
            // 
            this.buttonsend.Location = new System.Drawing.Point(537, 39);
            this.buttonsend.Name = "buttonsend";
            this.buttonsend.Size = new System.Drawing.Size(75, 46);
            this.buttonsend.TabIndex = 6;
            this.buttonsend.Text = "Send";
            this.buttonsend.UseVisualStyleBackColor = true;
            this.buttonsend.Click += new System.EventHandler(this.buttonsend_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labeltimer1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxkey);
            this.groupBox1.Controls.Add(this.textBoxiv);
            this.groupBox1.Location = new System.Drawing.Point(3, 302);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(623, 85);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "KEY, IV";
            // 
            // labeltimer1
            // 
            this.labeltimer1.AutoSize = true;
            this.labeltimer1.Location = new System.Drawing.Point(352, 69);
            this.labeltimer1.Name = "labeltimer1";
            this.labeltimer1.Size = new System.Drawing.Size(36, 13);
            this.labeltimer1.TabIndex = 7;
            this.labeltimer1.Text = "Timer:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Key Chung:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(393, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "IV:";
            // 
            // textBoxkey
            // 
            this.textBoxkey.Location = new System.Drawing.Point(74, 29);
            this.textBoxkey.Name = "textBoxkey";
            this.textBoxkey.Size = new System.Drawing.Size(313, 20);
            this.textBoxkey.TabIndex = 17;
            // 
            // textBoxiv
            // 
            this.textBoxiv.Location = new System.Drawing.Point(419, 29);
            this.textBoxiv.Name = "textBoxiv";
            this.textBoxiv.Size = new System.Drawing.Size(198, 20);
            this.textBoxiv.TabIndex = 19;
            // 
            // FormServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 579);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBoxserver);
            this.Name = "FormServer";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxserver;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonsendnoise;
        private System.Windows.Forms.TextBox textBoxmessnoise;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxmessage;
        private System.Windows.Forms.Button buttonsend;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxkey;
        private System.Windows.Forms.TextBox textBoxiv;
        private System.Windows.Forms.Label labeltimer1;
    }
}

