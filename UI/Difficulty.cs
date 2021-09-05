using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Men.UI
{
    public partial class Difficulty : Form
    {
        public Difficulty(Men.BeatSaver.Difficulty d)
        {
            InitializeComponent();
            chroma.Checked = d.chroma;
            noodle.Checked = d.ne;
            cinema.Checked = d.cinema;
            me.Checked = d.me;

            notes.Text = $"{d.notes} Notes";
            bombs.Text = $"{d.bombs} Bombs";
            nps.Text = $"{d.nps} NPS";
            offset.Text = $"{d.offset} Offset";
            njs.Text = $"NJS {d.njs}";

            events.Text = $"{d.events} Events";
            obstacles.Text = $"{d.obstacles} Obstacles";

            int minutes = (int)Math.Floor(d.seconds / 60);
            int seconds = (int)d.seconds % 60;
            string secondss = seconds < 10 ? "0" : "" + $"{seconds}";
            length.Text = $"{minutes}:{secondss}";

            errors.Text = $"{d.paritySummary.errors} Errors";
            resets.Text = $"{d.paritySummary.resets} Resets";
            warnings.Text = $"{d.paritySummary.warns} Warnings";
        }
    }
}
