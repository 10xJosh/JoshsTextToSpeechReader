using JoshsTextToSpeechReader.Speech;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Media;
using System.Configuration;

namespace JoshsTextToSpeechReader.MenuItems
{

    public partial class FrmChangeFont : Form
    {
        public delegate void OnChangeFontSettings();
        public static event OnChangeFontSettings GetChangedFontSettings;

        public static string FontName { get; set; }
        public static int FontSize { get; set; }

        public FrmChangeFont()
        {
            InitializeComponent();
            InitalizeFontSettings();

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

            FontName = cmboFonts.SelectedItem.ToString();
            var fontSizeString = cmboFontSize.SelectedItem.ToString().Replace(" pt", "");
            FontSize = Convert.ToInt32(fontSizeString);

            GetChangedFontSettings();
        }

        private void InitalizeFontSettings()
        {
            FontName = Font.Name;
            FontSize = (int)Font.Size;

            cmboFonts.DropDownStyle = ComboBoxStyle.DropDownList;
            cmboFontSize.DropDownStyle = ComboBoxStyle.DropDownList;


            var fontList = Fonts.SystemFontFamilies;
            int[] fontSizes = { 10, 12, 14, 16, 18, 24, 30, 32, 36, 38, 48, 60, 72 };

            foreach (var font in fontList)
            {
                cmboFonts.Items.Add(font);
            }
            
            foreach(var size in fontSizes)
            {
                cmboFontSize.Items.Add(size.ToString() + " pt");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmChangeFont_Load(object sender, EventArgs e)
        {
            cmboFonts.Text = FontName;
            cmboFontSize.SelectedIndex = FontSize;
        }
    }
}
