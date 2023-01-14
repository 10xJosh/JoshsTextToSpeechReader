using System;
using System.Speech.Synthesis;
using System.Windows;
using System.Windows.Controls;

namespace JoshsTextToSpeechReader.Speech
{
    internal class SpeechMethods
    {
        public bool IsTextToSpeechPaused { get; set; }

        public static SpeechSynthesizer TextToSpeech = new SpeechSynthesizer();


        public void UpdateVoiceSettings(string VoiceSetting)
        {
             TextToSpeech.SelectVoice(VoiceSetting);
        }

        public void ReadDisplayText(string displayText)
        {
            TextToSpeech.SpeakAsync(displayText);
        }

        public void ContinueReadingText()
        {
            TextToSpeech.Resume();
            IsTextToSpeechPaused= false;
        }

        public void CancelSpeach()
        {
            TextToSpeech.SpeakAsyncCancelAll();
            //Speech queue will still be paused after cancelling so resume() needs to be called
            TextToSpeech.Resume(); 
        }

        public void PauseReadingText()
        {
            TextToSpeech.Pause();
            IsTextToSpeechPaused = true;
        }

        public void SetVolume(double volume)
        {
            TextToSpeech.Volume = Convert.ToInt32(volume);
        }

        public void SetReadingSpeed(string speedSetting)
        {
            switch(speedSetting)
            {
                case "Slower":
                        TextToSpeech.Rate = -5;
                    break;
                case "Normal":
                        TextToSpeech.Rate = 1;
                    break;
                case "Faster":
                        TextToSpeech.Rate = 4;
                    break;
            }
        }
    }
}
