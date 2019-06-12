using System;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "pagina?moedaOrigem=real&moedaDestino=dolar";
            // pagina?argumentos
            // 012345678
            string textoVazio = "";
            string textoNulo = null;
            string textoQualquer = "defergfer";

            var extrator = new ExtratorValorDeArgumentosURL(url);
            
            Console.WriteLine(url);

            int indiceInterrogacao = url.IndexOf('?');
            Console.WriteLine(indiceInterrogacao);
           
            string argumentos = url.Substring(indiceInterrogacao + 1);
            Console.WriteLine(argumentos);
            Console.WriteLine(string.IsNullOrEmpty(textoVazio));
            Console.WriteLine(string.IsNullOrEmpty(textoNulo));
            Console.WriteLine(string.IsNullOrEmpty(textoQualquer));

            var palavra = url;
            var nomeArgumento = "moedaDestino";
            var indice = palavra.IndexOf(nomeArgumento);
            Console.WriteLine(indice);
            Console.WriteLine(palavra.Substring(indice));
            Console.WriteLine(indice + nomeArgumento.Length);

            Console.ReadLine();
        }
    }


}
