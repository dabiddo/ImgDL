namespace webdltest
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
            this.txtweb = new System.Windows.Forms.TextBox();
            this.btndl = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.linkstxt = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.imgdownload = new System.Windows.Forms.PictureBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgdownload)).BeginInit();
            this.SuspendLayout();
            // 
            // txtweb
            // 
            this.txtweb.Location = new System.Drawing.Point(29, 22);
            this.txtweb.Name = "txtweb";
            this.txtweb.Size = new System.Drawing.Size(265, 20);
            this.txtweb.TabIndex = 0;
            // 
            // btndl
            // 
            this.btndl.Location = new System.Drawing.Point(313, 18);
            this.btndl.Name = "btndl";
            this.btndl.Size = new System.Drawing.Size(75, 23);
            this.btndl.TabIndex = 1;
            this.btndl.Text = "Resolve";
            this.btndl.UseVisualStyleBackColor = true;
            this.btndl.Click += new System.EventHandler(this.btndl_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.linkstxt);
            this.groupBox2.Location = new System.Drawing.Point(12, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(388, 513);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Links";
            // 
            // linkstxt
            // 
            this.linkstxt.Location = new System.Drawing.Point(7, 19);
            this.linkstxt.Name = "linkstxt";
            this.linkstxt.Size = new System.Drawing.Size(369, 427);
            this.linkstxt.TabIndex = 0;
            this.linkstxt.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.progressBar);
            this.groupBox1.Controls.Add(this.imgdownload);
            this.groupBox1.Location = new System.Drawing.Point(411, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(417, 491);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Download";
            // 
            // imgdownload
            // 
            this.imgdownload.Location = new System.Drawing.Point(7, 20);
            this.imgdownload.Name = "imgdownload";
            this.imgdownload.Size = new System.Drawing.Size(404, 428);
            this.imgdownload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgdownload.TabIndex = 0;
            this.imgdownload.TabStop = false;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(7, 455);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(404, 23);
            this.progressBar.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 589);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btndl);
            this.Controls.Add(this.txtweb);
            this.Name = "Form1";
            this.Text = "IgmDL";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgdownload)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtweb;
        private System.Windows.Forms.Button btndl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox linkstxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox imgdownload;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}

