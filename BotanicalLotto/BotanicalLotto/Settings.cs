using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BotanicalLotto
{
    public partial class Settings : Form
    {
        public MyStyle myStyle {get; set; }
        MainMenu WhoShowMe;
        int theme = 0;
        string fontStyle = "";
        int fontSize = 0;
        public Settings()
        {
            InitializeComponent();
        }
        public Settings(MainMenu menu)
        {
            WhoShowMe = menu;
            InitializeComponent();
        }
        private void back(object sender, EventArgs e)
        {   
            Close();

            WhoShowMe.Visible = true;
        }

        private void Save(object sender, EventArgs e)
        {
            fontStyle = comboBox2.Text;
            fontSize = comboBox3.SelectedIndex;
            theme = comboBox1.SelectedIndex;
            myStyle = new MyStyle(fontStyle, fontSize, theme);
            WhoShowMe.Visible = true;
            Close();
            Properties.Settings.Default.FontStyle = fontStyle;
            Properties.Settings.Default.FontSize = fontSize;
            Properties.Settings.Default.theme = theme;
            Properties.Settings.Default.Save();
        }
    
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
