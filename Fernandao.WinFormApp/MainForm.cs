namespace Fernandao.WinFormApp
{
    using System;
    using System.IO;
    using System.Windows.Forms;

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private Crypto crypto;

        private void btnOpenCryptoFile_Click(object sender, EventArgs e)
        {
            if (this.openFileDialogForCrypto.ShowDialog() == DialogResult.OK)
            {
                var validFile = this.openFileDialogForCrypto.FileName;

                var fileExists = File.Exists(validFile);

                if (fileExists) this.crypto = new Crypto(true, validFile, this.textBoxPassword.Text);
                else MessageBox.Show("Arquivo selecionado não existe ou é protegido contra leitura");
            }
        }

        private void btnOpenFileToProcess_Click(object sender, EventArgs e)
        {
            if (!this.ValidatePassword()) return;

            if (this.openFileDialogForFile.ShowDialog() == DialogResult.OK)
            {
                var crytpoFile = this.openFileDialogForFile.FileName;

                var validFile = File.Exists(crytpoFile);

                if (validFile)
                {
                    var retorno = ".ret".Equals(Path.GetExtension(crytpoFile), StringComparison.OrdinalIgnoreCase) ? crytpoFile : null;

                    if (File.Exists(retorno))
                    {
                        try
                        {
                            MessageBox.Show($"O arquivo de retorno foi decodificado com sucesso e salvo em {crypto.DecodeAndSaveFile(retorno)}");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Erro durante a tentativa de descriptografar arquivo de remessa {ex}");
                        }
                    }
                    else MessageBox.Show("O arquivo selecionado deve possuir a extensão .rem (arquvio de registro de remessa) ou .ret (arquivo de retorno)");
                }
                else MessageBox.Show("Arquivo selecionado não existe ou é protegido contra leitura");
            }
        }

        private bool ValidatePassword()
        {
            var success = !string.IsNullOrWhiteSpace(textBoxPassword.Text);

            if (!success) MessageBox.Show("Insira a senha para realizar a decodificação");

            return success;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!this.ValidatePassword()) return;

            if (this.openFileDialogForFile.ShowDialog() == DialogResult.OK)
            {
                var crytpoFile = this.openFileDialogForFile.FileName;

                var validFile = File.Exists(crytpoFile);

                if (validFile)
                {
                    var remessa = ".rem".Equals(Path.GetExtension(crytpoFile), StringComparison.OrdinalIgnoreCase) ? crytpoFile : null;

                    if (File.Exists(remessa))
                    {
                        try
                        {
                            MessageBox.Show($"O arquivo de retorno foi codificado com sucesso e salvo em {crypto.CryptoAndSaveFile(remessa)}");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Erro durante a tentativa de criptografar arquivo de remessa {ex}");
                        }
                    }
                    else MessageBox.Show("O arquivo selecionado deve possuir a extensão .rem (arquvio de registro de remessa) ou .ret (arquivo de retorno)");
                }
                else MessageBox.Show("Arquivo selecionado não existe ou é protegido contra leitura.");
            }
        }
    }
}