using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Threading;


namespace AiSam
{
    class Program
    {
        static ManualResetEvent _completed = null;
        static void Main(string[] args)
        {
            _completed = new ManualResetEvent(false);
            SpeechRecognitionEngine _recognizer = new SpeechRecognitionEngine();
            _recognizer.LoadGrammar(new Grammar(new GrammarBuilder("Hai")) { Name = "HaiGrammar" });
           // _recognizer.LoadGrammar(new Grammar(new GrammarBuilder("Hai I am sampath")) { Name = "Grammar" });

           // _recognizer.LoadGrammar(new Grammar(new GrammarBuilder("exit")) { Name = "exitGrammar" });
            _recognizer.SpeechRecognized += _recognizer_SpeechRecognized;
            _recognizer.SetInputToDefaultAudioDevice();
            _recognizer.RecognizeAsync(RecognizeMode.Multiple);
            _completed.WaitOne();
            _recognizer.Dispose();
        }

        private static void _recognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            SpeechSynthesizer _synthesizer = new SpeechSynthesizer();
            if (e.Result.Text == "Hai")
            {
                _synthesizer.Speak("Do you Like Jarvis?");
                _completed.Set();
            }
            
        }
    }
}
