using System;

namespace ByteBank.SistemaAgencia
{
    public class ExtratorValorDeArgumentosURL
    {
        public string URL { get; }
        private readonly string _argumentos;

        public ExtratorValorDeArgumentosURL(string url)
        {
            if (string.IsNullOrEmpty(url))
            {
                throw new ArgumentException("O argumento url não pode ser uma string vazia.", nameof(url));
            }
            URL = url;
            var indiceInterrogacao = url.IndexOf('?');
            _argumentos = url.Substring(indiceInterrogacao + 1);
        }

        public string GetValor(string parametro)
        {
            parametro.ToUpper();
            var argumento = _argumentos.ToUpper();
            var termo = parametro + "=";
            var indiceTermo = argumento.IndexOf(termo);
            var resultado = _argumentos.Substring(indiceTermo + termo.Length);
            var indiceEComercial = resultado.IndexOf('&');
            if (indiceEComercial == -1)
            {
                return resultado;
            }

            return resultado.Remove(indiceEComercial);
        }
    }
}
