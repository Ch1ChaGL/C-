using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace BotanicalLotto
{
    public class MyStyle
    {
        private int[] _fontSize = {8,15,18};
        private int _theme = 0;
        private Font _fontStyle;
        private Color[] _themeColor = { Color.Blue, Color.Tomato, Color.LightYellow };
        private Color[] _ButtonBackColor = { Color.Red, Color.Blue, Color.Green};
        private Color[] _ButtonForeColor = { Color.Brown, Color.Green, Color.Red };

        public MyStyle(string fontStyle, int fontSize, int theme)
        {   
            _theme = theme;
            _fontStyle = new Font(fontStyle, _fontSize[fontSize]);

        }
        public void SetStyle(Form form)
        {
            form.BackColor = _themeColor[_theme];
            form.Font = _fontStyle;
            foreach(Control control in form.Controls)
            {   
                control.Font = _fontStyle;
                if (control is Button) {
                    control.ForeColor = _ButtonBackColor[_theme];
                    control.BackColor = _ButtonForeColor[_theme];
                }
            }
        }




    }

}
