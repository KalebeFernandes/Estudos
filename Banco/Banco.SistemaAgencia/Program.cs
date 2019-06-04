using System;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            // pagina?argumentos
            // 012345678



            string textoVazio = "";
            string textoNulo = null;
            string textoQualquer = "defergfer";



            ExtratorValorDeArgumentosURL extrator = new ExtratorValorDeArgumentosURL("");

            string url = "pagina?moedaOrigem=real&moedaDestino=dolar";

            int indiceInterrogacao = url.IndexOf('?');

            Console.WriteLine(indiceInterrogacao);

            Console.WriteLine(url);
            string argumentos = url.Substring(indiceInterrogacao + 1);
            Console.WriteLine(argumentos);


            Console.ReadLine();
        }
    }


}
