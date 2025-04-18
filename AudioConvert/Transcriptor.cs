using AssemblyAI;
using AssemblyAI.Transcripts;

namespace AudioConvert
{
    public static class Transcriptor
    {
        public static async Task<string> TranscribeAudio(string path)
        {
            var client = new AssemblyAIClient("a98a54f35c20440199be172f4302a3df");

            var transcript = await client.Transcripts.TranscribeAsync(new FileInfo(path));

            if (transcript.Status == TranscriptStatus.Error)
            {
                return transcript.Error!;
            }

            return transcript.Text!;
        }
    }
}
