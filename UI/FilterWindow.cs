using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Random_Song_Generator;

namespace Men.UI
{
    public partial class FilterWindow : Form
    {
        public FilterWindow()
        {
            InitializeComponent();
            for (int i = 0; i < 5; i++)
            {
                Filters.SetItemChecked(i, true);
            }
            

        }
        private void ItemCheck(object sender, ItemCheckEventArgs e)
        {
            Men.Utilities.Filters.filter ^= (short) Math.Pow(2, e.Index);
        }
        private void Apply_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
