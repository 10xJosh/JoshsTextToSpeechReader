using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using JoshsTextToSpeechReader.MenuItems;
using JoshsTextToSpeechReader.Speech;
using System.Speech.Synthesis;
using System.Windows.Forms;

namespace JoshsTextToSpeechReader
{
    public partial class MainWindow : Window
    {
        MenuMethods menuMethods = new MenuMethods();
        SpeechMethods speechMethods = new SpeechMethods();
        FrmChangeFont frmFontChange = new FrmChangeFont();
        FrmChangeVoice frmChangeVoice = new FrmChangeVoice();

        public string inputStorage { get; set; }
        public string path { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            InitializeReadingSpeedSettings();

            SpeechMethods.TextToSpeech.SpeakCompleted += CompletedSpeech;
            SpeechMethods.TextToSpeech.SpeakProgress += SpeechHighlight;
            FrmChangeFont.GetChangedFontSettings += GetUpdatedFontSettings;
            
        }

        public void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Text = string.Empty;
            inputStorage = " ";

            speechMethods.CancelSpeach();

            btnPause.Visibility = Visibility.Hidden;
            btnRead.Content = "▷";
            btnRead.Visibility = Visibility.Visible;

            if (speechMethods.IsTextToSpeechPaused == true)
            {
                speechMethods.IsTextToSpeechPaused = false;
            }
        }

        private void btnRead_Click(object sender, RoutedEventArgs e)
        {
            if (speechMethods.IsTextToSpeechPaused == true)
            {
                speechMethods.ContinueReadingText();
                btnRead.Visibility = Visibility.Hidden;
                btnPause.Visibility = Visibility.Visible;
            }
            else
            {
                btnRead.Visibility = Visibility.Hidden;
                btnPause.Visibility = Visibility.Visible;

                inputStorage = txtDisplay.Text;

                speechMethods.ReadDisplayText(inputStorage);
            }

        }

        public void btnPause_Click(object sender, RoutedEventArgs e)
        {
            if (speechMethods.IsTextToSpeechPaused == false)
            {
                speechMethods.PauseReadingText();
                btnRead.Visibility = Visibility.Visible;
                btnRead.Content = "Resume";
                btnPause.Visibility = Visibility.Hidden;
            }
            else
            {
                speechMethods.ContinueReadingText();
            }

        }

        private void MenuExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void MenuImport_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Title = "Select a file";
                openFileDialog.ShowDialog();

                if (openFileDialog.FileName != "")
                {
                    path = openFileDialog.FileName;
                    txtDisplay.Text = menuMethods.GetImportedFile(path);
                }
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show(
                    "Something went wrong when trying to open the File. Please try again.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MenuChangeFont_Click(object sender, RoutedEventArgs e)
        {
            if (frmFontChange == null || frmFontChange.IsDisposed)
            {
                FrmChangeFont frmFontChange = new FrmChangeFont();
                frmFontChange.Show();
            }
            else
            {
                frmFontChange.Show();
            }
        }

        private void MenuChangeVoice_Click(object sender, RoutedEventArgs e)
        {
            if (frmChangeVoice == null || frmChangeVoice.IsDisposed)
            {
                FrmChangeVoice frmChangeVoice = new FrmChangeVoice();
                frmChangeVoice.Show();
            }
            else
            {
                frmChangeVoice.Show();
            }
        }

        private void MenuAbout_Click(object sender, RoutedEventArgs e)
        {
            menuMethods.GetAbout();
        }

        private void sldrVolume_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            speechMethods.SetVolume(sldrVolume.Value);
        }
        private void cmboReadingSpeed_Changed(object sender, SelectionChangedEventArgs e)
        {
            GetReadingSpeed();
        }

        public void GetUpdatedFontSettings()
        {
            txtDisplay.FontFamily = new FontFamily(FrmChangeFont.FontName);
            txtDisplay.FontSize = FrmChangeFont.FontSize;
        }

        private void GetReadingSpeed()
        {
            speechMethods.SetReadingSpeed((string)cmboReadingSpeed.SelectedItem);
        }

        private void InitializeReadingSpeedSettings()
        {
            cmboReadingSpeed.Items.Add("Slower");
            cmboReadingSpeed.Items.Add("Normal");
            cmboReadingSpeed.Items.Add("Faster");
            cmboReadingSpeed.SelectedItem = "Normal";
        }

        private void CompletedSpeech(object sender, SpeakCompletedEventArgs e)
        {
            btnRead.Visibility = Visibility.Visible;
            btnPause.Visibility = Visibility.Hidden;
        }

        private void SpeechHighlight(object sender, SpeakProgressEventArgs e)
        {
            txtDisplay.Focus(); //this is required for the highlight feature to work
            txtDisplay.Select(e.CharacterPosition, e.Text.Length);
        }
    }
}
