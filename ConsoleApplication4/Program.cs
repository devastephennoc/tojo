using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;
namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();

            // Configure the audio output. 
            synth.SetOutputToDefaultAudioDevice();
            // Speak a string.
            synth.Speak("This example demonstrates a basic use of Speech Synthesizer");
            synth.Speak("Press any key to exit...");
            synth.Speak("Action");

            synth.Speak("None");
            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
