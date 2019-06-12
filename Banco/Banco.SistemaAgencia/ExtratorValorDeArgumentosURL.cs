using System;

namespace ByteBank.SistemaAgencia
{
    public class ExtratorValorDeArgumentosURL
    {
        public string URL { get; }
        private readonly string _argumntos;

        public ExtratorValorDeArgumentosURL(string url)
        {
            if (string.IsNullOrEmpty(url))
            {
                throw new ArgumentException("O argumento url não pode ser uma string vazia.", nameof(url));
            }
            URL = url;
            var indiceInterrogacao = url.IndexOf('?');
            _argumntos = url.Substring(indiceInterrogacao + 1);
        }

        public string GetValor(string parametro)
        {
            string palavra = "moedaOrigem=real&moedaDestino=dolar";
            string nomeArgumento = "moedaDestino";

            int indice = palavra.IndexOf(nomeArgumento);

            int indiceValor = indice + nomeArgumento.Length;

            string valorArgumento = palavra.Substring(indiceValor);
        }
    }
}
