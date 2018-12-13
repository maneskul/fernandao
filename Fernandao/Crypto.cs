namespace Fernandao.Lib
{
    using System;
    using System.IO;

    public class Crypto
    {
        public Crypto(bool production, string cryptoFile, string password)
        {
            this.production = production;
            this.cryptoFile = cryptoFile;
            this.password = password;
        }

        private bool production;
        private string cryptoFile;
        private string password;

        public string CryptoAndSaveFile(string remessaFilePath)
        {
            var key = this.GetCryptKey();
            var fileName = Path.GetFileName(remessaFilePath);
            var outputFolder = Path.GetDirectoryName(remessaFilePath);
            var filePrefix = production ? "COBN_" : "COTT_";
            var finalFileName = string.Concat(filePrefix, fileName);

            try
            {
                var wos = new br.com.bradesco.webta.security.crypto.WEBTAOutputStream(finalFileName, outputFolder, key);

                var buffer = new byte[8192];
                var fileBytes = java.nio.file.Files.readAllBytes(java.nio.file.Paths.get(remessaFilePath));
                var input = new java.io.ByteArrayInputStream(fileBytes);
                var len = input.read(buffer);

                while (len != -1)
                {
                    wos.write(buffer, 0, len);
                    len = input.read(buffer);
                }

                wos.close();
            }
            catch
            {
                var path = Path.Combine(outputFolder, finalFileName);
                throw new Exception(string.Format("Erro ao iniciar o Output Stream para salvar o arquivo em {0}", path));
            }

            var fullPath = Path.Combine(fileName, outputFolder, finalFileName);

            return fullPath;
        }

        public string DecodeAndSaveFile(string retornoFilePath)
        {
            var key = this.GetCryptKey();
            var fileName = Path.GetFileName(retornoFilePath);

            try
            {
                var wis = new br.com.bradesco.webta.security.crypto.WEBTAInputStream(
                    fileName,
                    Path.GetDirectoryName(retornoFilePath),
                    key);

                int readBytes = 0;
                byte[] aux = new byte[512];
                var baos = new java.io.ByteArrayOutputStream();
                while ((readBytes = wis.read(aux, 0, aux.Length)) > 0)
                {
                    baos.write(aux, 0, readBytes);
                }

                var outputFile = string.Concat(Path.Combine(Path.GetDirectoryName(retornoFilePath), Path.GetFileNameWithoutExtension(fileName)), ".out.RET");
                File.WriteAllText(outputFile, baos.toString());

                wis.close();

                return outputFile;
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("Falha ao descriptografar o arquivo '{0}'.", fileName), ex);
            }
        }

        private byte[] GetCryptKey()
        {
            return br.com.bradesco.webta.security.crypto.WEBTACryptoUtil.decodeKeyFile(new java.io.File(this.cryptoFile), this.password);
        }
    }
}