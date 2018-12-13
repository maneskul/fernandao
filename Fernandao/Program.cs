namespace Fernandao
{
    using System;
    using System.IO;
    using System.Linq;

    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(Environment.NewLine, args));
            var crytpoFile = args.FirstOrDefault(d => ".bin".Equals(Path.GetExtension(d), StringComparison.OrdinalIgnoreCase));
            var remessa = args.FirstOrDefault(d => ".rem".Equals(Path.GetExtension(d), StringComparison.OrdinalIgnoreCase));
            var retorno = args.FirstOrDefault(d => ".ret".Equals(Path.GetExtension(d), StringComparison.OrdinalIgnoreCase));
            var production = args.Contains("--production");

            var validCriptoFile = File.Exists(crytpoFile);
            var validRemessafile = File.Exists(remessa);
            var validRetorno = File.Exists(retorno);

            if (validCriptoFile)
            {
                var pass = GetPass();
                var crypto = new Crypto(production, crytpoFile, pass);

                if (validRemessafile) crypto.CryptoAndSaveFile(remessa);
                if (validRetorno) crypto.DecodeAndSaveFile(retorno);
            }
            else Console.WriteLine("Arquivo de criptografia é obrigatório para realizar as operações");

            Console.ReadKey();
        }

        private static string GetPass()
        {
            Console.WriteLine("SENHA PARA DESCRIPTOGRAFAR ou CRIPTOGRAFAR: ");
            return Console.ReadLine();
        }
    }
}