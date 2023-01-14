using JoshsTextToSpeechReader.Speech;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoshsTextToSpeechReader.MenuItems
{
    public partial class FrmChangeVoice : Form
    {
        SpeechSynthesizer TextToSpeechOptions = new SpeechSynthesizer();
        SpeechMethods displayMethods = new SpeechMethods();
        

        public FrmChangeVoice()
        {
            InitializeComponent();
            InitializeSpeechSettings();
        }

        private void btnVoiceConfirm_Click(object sender, EventArgs e)
        {
            if (cmboVoiceList.SelectedIndex == -1)
            {
                this.Close();
            }
            else
            {
                displayMethods.UpdateVoiceSettings((string)cmboVoiceList.SelectedItem);
                this.Close();
            }
        }

        private void InitializeSpeechSettings()
        {
            var installedVoices = TextToSpeechOptions.GetInstalledVoices();
            cmboVoiceList.DropDownStyle = ComboBoxStyle.DropDownList;

            foreach (var voice in installedVoices)
            {
                cmboVoiceList.Items.Add(voice.VoiceInfo.Name);
            }
        }
    }
}
