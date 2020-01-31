using System;
using System.Net;
using System.IO;

namespace RequisicaoSimplesWeb
{
    class Program
    {
        static void Main(string[] args)
        {
            var requisicaoWeb = WebRequest.CreateHttp("https://api.codenation.dev/v1/challenge/dev-ps/generate-data?token=143f8e4b323931be4ab6d40856903ea546e4a9e8");
            requisicaoWeb.Method = "GET";
            requisicaoWeb.UserAgent = "RequisicaoWebDemo";
            using (var resposta = requisicaoWeb.GetResponse())
            {
                var streamDados = resposta.GetResponseStream();
                StreamReader reader = new StreamReader(streamDados);
                object objResponse = reader.ReadToEnd();
                Console.WriteLine(objResponse.ToString());
                Console.ReadLine();
                streamDados.Close();
                resposta.Close();
            }

        }
    }
}
