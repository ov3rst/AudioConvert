using AssemblyAI;
using AssemblyAI.Transcripts;

namespace AudioConvert
{
    /// <summary>
    /// Clase estatica que utilizamos para encapsular todo el codigo relacionado con la transcripcion del audio
    /// </summary>
    public static class Transcriptor
    {
        //Llave de acceso a la api.
        private const string API_KEY = "a98a54f35c20440199be172f4302a3df";

        /// <summary>
        /// Metodo estatico que transcribe el audio a texto
        /// </summary>
        /// <param name="path">Ruta del archivo a transcribir</param>
        /// <returns>El texto resultante de la transcripcion</returns>
        public static async Task<string> TranscribeAudio(string path)
        {
            // Inicializamos el cliente con nuetra llave que nos permite utilizar la api
            var client = new AssemblyAIClient(API_KEY);

            // Enviamos nuestro archivo a la api, esta utiliza el metodo HTTP POST
            var transcript = await client.Transcripts.TranscribeAsync(new FileInfo(path));

            //Confirmamos si todo salio bien
            if (transcript.Status == TranscriptStatus.Error)
            {
                //Si hubo un error lo retornamos para mostrarselo al usuario
                return transcript.Error!;
            }

            // Si todo salio bien entonces retornamos el audio transcrito
            return transcript.Text!;
        }
    }
}
