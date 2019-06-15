using System;
using System.Text.RegularExpressions;

namespace ByteBank.SistemaAgencia
{
    public class Program
    {
        static void Main(string[] args)
        {
            var url = "http://www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar&valor=1500";
            var extrator = new ExtratorValorDeArgumentosURL(url);
            Console.WriteLine(url);
            
            var textoVazio = "";
            string textoNulo = null;
            var textoQualquer = "defergfer";
            Console.WriteLine(string.IsNullOrEmpty(textoVazio));
            Console.WriteLine(string.IsNullOrEmpty(textoNulo));
            Console.WriteLine(string.IsNullOrEmpty(textoQualquer));

            var indiceInterrogacao = url.IndexOf('?');
            Console.WriteLine(indiceInterrogacao);

            var argumentos = url.Substring(indiceInterrogacao + 1);
            Console.WriteLine(argumentos);

            var palavra = url;
            var nomeArgumento = "moedaDestino";
            var indice = palavra.IndexOf(nomeArgumento);
            Console.WriteLine(indice);
            Console.WriteLine(palavra.Substring(indice));
            Console.WriteLine(indice + nomeArgumento.Length);

            Console.WriteLine("Valor de destino: " + extrator.GetValor(nomeArgumento));
            Console.WriteLine("Valor de origem: " + extrator.GetValor("moedaOrigem"));
            Console.WriteLine(extrator.GetValor("VALOR"));

            var padrao = "[0-9]{4,5}[-]{0,1}[0-9]{4}";
            var textoDeTeste = "Meu nome é Kalebe, me ligue em 4784-4546";
            var regex = Regex.IsMatch(textoDeTeste, padrao);//retorna se a string está dentro do padrão
            var regex2 = Regex.Match(textoDeTeste, padrao); // retorna as propriedades que respeitam o padrão
            Console.WriteLine(regex);
            Console.WriteLine(regex2.Value);

            Console.ReadLine();
        }
    }
}