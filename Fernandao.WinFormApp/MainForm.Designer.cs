namespace Fernandao.WinFormApp
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.openFileDialogForCrypto = new System.Windows.Forms.OpenFileDialog();
            this.btnOpenCryptoFile = new System.Windows.Forms.Button();
            this.btnDecryptFile = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.openFileDialogForFile = new System.Windows.Forms.OpenFileDialog();
            this.btnEncryptFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.savePassword = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialogForCrypto
            // 
            this.openFileDialogForCrypto.Filter = ".bin Files|*.bin";
            // 
            // btnOpenCryptoFile
            // 
            this.btnOpenCryptoFile.Enabled = false;
            this.btnOpenCryptoFile.Location = new System.Drawing.Point(12, 61);
            this.btnOpenCryptoFile.Name = "btnOpenCryptoFile";
            this.btnOpenCryptoFile.Size = new System.Drawing.Size(335, 43);
            this.btnOpenCryptoFile.TabIndex = 2;
            this.btnOpenCryptoFile.Text = "Arquivo criptografia .bin";
            this.btnOpenCryptoFile.UseVisualStyleBackColor = true;
            this.btnOpenCryptoFile.Click += new System.EventHandler(this.btnOpenCryptoFile_Click);
            // 
            // btnDecryptFile
            // 
            this.btnDecryptFile.Enabled = false;
            this.btnDecryptFile.Location = new System.Drawing.Point(12, 110);
            this.btnDecryptFile.Name = "btnDecryptFile";
            this.btnDecryptFile.Size = new System.Drawing.Size(160, 43);
            this.btnDecryptFile.TabIndex = 3;
            this.btnDecryptFile.Text = "Descriptografar";
            this.btnDecryptFile.UseVisualStyleBackColor = true;
            this.btnDecryptFile.Click += new System.EventHandler(this.btnOpenFileToProcess_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(59, 33);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(197, 20);
            this.textBoxPassword.TabIndex = 4;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(12, 37);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(41, 13);
            this.labelPassword.TabIndex = 5;
            this.labelPassword.Text = "Senha:";
            // 
            // openFileDialogForFile
            // 
            this.openFileDialogForFile.Filter = ".rem or .ret|*.rem;*.ret";
            // 
            // btnEncryptFile
            // 
            this.btnEncryptFile.Enabled = false;
            this.btnEncryptFile.Location = new System.Drawing.Point(178, 110);
            this.btnEncryptFile.Name = "btnEncryptFile";
            this.btnEncryptFile.Size = new System.Drawing.Size(169, 43);
            this.btnEncryptFile.TabIndex = 6;
            this.btnEncryptFile.Text = "Criptografar";
            this.btnEncryptFile.UseVisualStyleBackColor = true;
            this.btnEncryptFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(314, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "v2.2";
            // 
            // savePassword
            // 
            this.savePassword.Location = new System.Drawing.Point(262, 33);
            this.savePassword.Name = "savePassword";
            this.savePassword.Size = new System.Drawing.Size(88, 20);
            this.savePassword.TabIndex = 8;
            this.savePassword.Text = "Salvar Senha";
            this.savePassword.UseVisualStyleBackColor = true;
            this.savePassword.Click += new System.EventHandler(this.btnSavePassword_click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(356, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            this.ajudaToolStripMenuItem.Click += new System.EventHandler(this.ajudaToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 179);
            this.Controls.Add(this.savePassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEncryptFile);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.btnDecryptFile);
            this.Controls.Add(this.btnOpenCryptoFile);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Criptografia Bradesco - v2.2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialogForCrypto;
        private System.Windows.Forms.Button btnOpenCryptoFile;
        private System.Windows.Forms.Button btnDecryptFile;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.OpenFileDialog openFileDialogForFile;
        private System.Windows.Forms.Button btnEncryptFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button savePassword;
        private System.Windows.Forms.MenuStrip menuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
    }
}