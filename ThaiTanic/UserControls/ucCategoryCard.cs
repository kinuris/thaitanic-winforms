using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThaiTanic.UserControls
{
    public partial class ucCategoryCard : UserControl
    {
        public ucCategoryCard()
        {
            InitializeComponent();
        }

        private Color _color;

        public Color BgColor
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
                pnlBackground.FillColor = _color;
            }
        }
    }
}
