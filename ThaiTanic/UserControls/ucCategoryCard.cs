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
        private string _CategoryName;
        private int _Count;

        public ucCategoryCard(string categoryName, int count)
        {
            InitializeComponent();

            _CategoryName = categoryName;
            _Count = count;

            lblCategoryName.Text = _CategoryName;
            lblCount.Text = $"{_Count} Items";
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
