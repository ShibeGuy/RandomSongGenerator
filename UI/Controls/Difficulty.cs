using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Men.UI;

namespace Men.UI.Controls
{
    public partial class Difficulty : UserControl
    {
        public Men.BeatSaver.Difficulty DifficultyInfo;
        public Difficulty(Men.BeatSaver.Difficulty d)
        {
            InitializeComponent();
            DifficultyInfo = d;
            diff.Text = $"{d.difficulty} {d.characteristic}";

            using (Graphics g = CreateGraphics())
            {
                SizeF size = g.MeasureString(diff.Text, diff.Font, diff.Width);
                expand.Location = new Point((int)size.Width + 23, expand.Location.Y);
                Width = expand.Location.X + 35;
            }
            expand.Click += new EventHandler(new Action<object, EventArgs>((object sender, EventArgs e) => openDiff(sender, e, DifficultyInfo)));
        }
        private void openDiff(object sender, EventArgs e, Men.BeatSaver.Difficulty d)
        {
            UI.Difficulty dif = new UI.Difficulty(d);
            dif.Show();
        }
    }
}
