namespace Fernao.WinFormApp
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
            this.openFileDialogForCrypto = new System.Windows.Forms.OpenFileDialog();
            this.btnOpenCryptoFile = new System.Windows.Forms.Button();
            this.btnOpenFileToProcess = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.openFileDialogForFile = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // openFileDialogForCrypto
            // 
            this.openFileDialogForCrypto.FileName = "openFileDialogForCrypto";
            // 
            // btnOpenCryptoFile
            // 
            this.btnOpenCryptoFile.Location = new System.Drawing.Point(34, 69);
            this.btnOpenCryptoFile.Name = "btnOpenCryptoFile";
            this.btnOpenCryptoFile.Size = new System.Drawing.Size(193, 43);
            this.btnOpenCryptoFile.TabIndex = 2;
            this.btnOpenCryptoFile.Text = "Arquivo criptografia .bin";
            this.btnOpenCryptoFile.UseVisualStyleBackColor = true;
            this.btnOpenCryptoFile.Click += new System.EventHandler(this.btnOpenCryptoFile_Click);
            // 
            // btnOpenFileToProcess
            // 
            this.btnOpenFileToProcess.Location = new System.Drawing.Point(34, 118);
            this.btnOpenFileToProcess.Name = "btnOpenFileToProcess";
            this.btnOpenFileToProcess.Size = new System.Drawing.Size(193, 43);
            this.btnOpenFileToProcess.TabIndex = 3;
            this.btnOpenFileToProcess.Text = "Arquivo para processar";
            this.btnOpenFileToProcess.UseVisualStyleBackColor = true;
            this.btnOpenFileToProcess.Click += new System.EventHandler(this.btnOpenFileToProcess_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(34, 36);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(193, 20);
            this.textBoxPassword.TabIndex = 4;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(34, 20);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(132, 13);
            this.labelPassword.TabIndex = 5;
            this.labelPassword.Text = "Senha para decodificação";
            // 
            // openFileDialogForFile
            // 
            this.openFileDialogForFile.FileName = "openFileDialogForFile";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 193);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.btnOpenFileToProcess);
            this.Controls.Add(this.btnOpenCryptoFile);
            this.Name = "MainForm";
            this.Text = "MainForm";
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
    }
}