namespace Buoi2_client
{
    partial class FormClient
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
            this.buttonsend = new System.Windows.Forms.Button();
            this.textBoxmess = new System.Windows.Forms.TextBox();
            this.listBoxclient = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labeltimer = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxiv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxkey = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labeltimer1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonsendnoise = new System.Windows.Forms.Button();
            this.textBoxmessnoise = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonsend
            // 
            this.buttonsend.Location = new System.Drawing.Point(537, 39);
            this.buttonsend.Name = "buttonsend";
            this.buttonsend.Size = new System.Drawing.Size(75, 46);
            this.buttonsend.TabIndex = 6;
            this.buttonsend.Text = "Send";
            this.buttonsend.UseVisualStyleBackColor = true;
            this.buttonsend.Click += new System.EventHandler(this.buttonsend_Click);
            this.buttonsend.Enter += new System.EventHandler(this.buttonsend_Click);
            // 
            // textBoxmess
            // 
            this.textBoxmess.Location = new System.Drawing.Point(10, 39);
            this.textBoxmess.Multiline = true;
            this.textBoxmess.Name = "textBoxmess";
            this.textBoxmess.Size = new System.Drawing.Size(522, 46);
            this.textBoxmess.TabIndex = 5;
            // 
            // listBoxclient
            // 
            this.listBoxclient.FormattingEnabled = true;
            this.listBoxclient.Location = new System.Drawing.Point(2, 0);
            this.listBoxclient.Name = "listBoxclient";
            this.listBoxclient.Size = new System.Drawing.Size(633, 277);
            this.listBoxclient.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labeltimer
            // 
            this.labeltimer.AutoSize = true;
            this.labeltimer.Location = new System.Drawing.Point(452, 28);
            this.labeltimer.Name = "labeltimer";
            this.labeltimer.Size = new System.Drawing.Size(0, 13);
            this.labeltimer.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(385, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "IV:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxiv
            // 
            this.textBoxiv.Location = new System.Drawing.Point(411, 29);
            this.textBoxiv.Name = "textBoxiv";
            this.textBoxiv.Size = new System.Drawing.Size(208, 20);
            this.textBoxiv.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Key Chung:";
            // 
            // textBoxkey
            // 
            this.textBoxkey.Location = new System.Drawing.Point(74, 29);
            this.textBoxkey.Name = "textBoxkey";
            this.textBoxkey.Size = new System.Drawing.Size(305, 20);
            this.textBoxkey.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labeltimer1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxkey);
            this.groupBox1.Controls.Add(this.textBoxiv);
            this.groupBox1.Location = new System.Drawing.Point(12, 295);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(623, 85);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "KEY, IV";
            // 
            // labeltimer1
            // 
            this.labeltimer1.AutoSize = true;
            this.labeltimer1.Location = new System.Drawing.Point(343, 69);
            this.labeltimer1.Name = "labeltimer1";
            this.labeltimer1.Size = new System.Drawing.Size(36, 13);
            this.labeltimer1.TabIndex = 21;
            this.labeltimer1.Text = "Timer:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxmess);
            this.groupBox2.Controls.Add(this.buttonsend);
            this.groupBox2.Location = new System.Drawing.Point(12, 386);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(623, 100);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Message";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonsendnoise);
            this.groupBox3.Controls.Add(this.textBoxmessnoise);
            this.groupBox3.Location = new System.Drawing.Point(12, 492);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(623, 89);
            this.groupBox3.TabIndex = 23;
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
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 593);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labeltimer);
            this.Controls.Add(this.listBoxclient);
            this.Name = "FormClient";
            this.Text = "CLient";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonsend;
        private System.Windows.Forms.TextBox textBoxmess;
        private System.Windows.Forms.ListBox listBoxclient;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labeltimer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxiv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxkey;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonsendnoise;
        private System.Windows.Forms.TextBox textBoxmessnoise;
        private System.Windows.Forms.Label labeltimer1;
    }
}

