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
    public partial class MainMenu : Form
    {       
        MyStyle myStyle = new MyStyle(
           Properties.Settings.Default.FontStyle,
           Properties.Settings.Default.FontSize,
           Properties.Settings.Default.theme);
        
        public MainMenu()
        {
            InitializeComponent();
            myStyle.SetStyle(this);
        }

        private void Settings(object sender, EventArgs e)
        {
            Settings settings = new Settings(this);
            myStyle.SetStyle(settings);
            Visible = false;
            settings.ShowDialog();
            if (settings.myStyle != null) { 
                myStyle = settings.myStyle;
            };
            if (myStyle != null) myStyle.SetStyle(this);

        }

        private void Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Game(object sender, EventArgs e)
        {
            Game game = new Game(this);
            myStyle.SetStyle(game);
            game.Show();
            Visible = false;
        }
    }
}
