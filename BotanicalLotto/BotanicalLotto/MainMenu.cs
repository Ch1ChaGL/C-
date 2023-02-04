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
        
        MyStyle myStyle;
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Settings settings = new Settings(this);
            if (myStyle != null)  myStyle.SetStyle(settings);               
            Visible = false;
            settings.ShowDialog();
            if(settings.myStyle != null) myStyle = settings.myStyle;
            if (myStyle != null) myStyle.SetStyle(this);
        }
    }
}
