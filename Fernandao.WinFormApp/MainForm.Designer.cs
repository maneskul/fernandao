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
            this.btnOpenFileToProcess = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.openFileDialogForFile = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFileDialogForCrypto
            // 
            this.openFileDialogForCrypto.Filter = ".bin Files|*.bin";
            // 
            // btnOpenCryptoFile
            // 
            this.btnOpenCryptoFile.Location = new System.Drawing.Point(12, 60);
            this.btnOpenCryptoFile.Name = "btnOpenCryptoFile";
            this.btnOpenCryptoFile.Size = new System.Drawing.Size(335, 43);
            this.btnOpenCryptoFile.TabIndex = 2;
            this.btnOpenCryptoFile.Text = "Arquivo criptografia .bin";
            this.btnOpenCryptoFile.UseVisualStyleBackColor = true;
            this.btnOpenCryptoFile.Click += new System.EventHandler(this.btnOpenCryptoFile_Click);
            // 
            // btnOpenFileToProcess
            // 
            this.btnOpenFileToProcess.Location = new System.Drawing.Point(12, 109);
            this.btnOpenFileToProcess.Name = "btnOpenFileToProcess";
            this.btnOpenFileToProcess.Size = new System.Drawing.Size(160, 43);
            this.btnOpenFileToProcess.TabIndex = 3;
            this.btnOpenFileToProcess.Text = "Descriptografar";
            this.btnOpenFileToProcess.UseVisualStyleBackColor = true;
            this.btnOpenFileToProcess.Click += new System.EventHandler(this.btnOpenFileToProcess_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(12, 27);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(335, 20);
            this.textBoxPassword.TabIndex = 4;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(12, 11);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(41, 13);
            this.labelPassword.TabIndex = 5;
            this.labelPassword.Text = "Senha:";
            // 
            // openFileDialogForFile
            // 
            this.openFileDialogForFile.Filter = ".rem or .ret|*.rem;*.ret";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(178, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 43);
            this.button1.TabIndex = 6;
            this.button1.Text = "Criptografar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(314, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "v2.1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 179);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.btnOpenFileToProcess);
            this.Controls.Add(this.btnOpenCryptoFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Criptografia Bradesco - v2.1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialogForCrypto;
        private System.Windows.Forms.Button btnOpenCryptoFile;
        private System.Windows.Forms.Button btnOpenFileToProcess;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.OpenFileDialog openFileDialogForFile;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}