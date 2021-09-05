using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Men.BeatSaver;
using Men.Utilities;

namespace Men.UI
{
    public partial class MainScreen : Form
    {
        public FilterWindow f;
        Map m;
        public MainScreen()
        {
            InitializeComponent();
            f = new FilterWindow();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button5.Enabled = false;
            RandomBeatSaver trigger = new RandomBeatSaver();
            m = trigger.Next();
            button5.Enabled = true;
            textBox1.Text = m.id;
            label6.Text = m.metadata.songName;
            label9.Text = m.metadata.levelAuthorName;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // Filters
        private void button3_Click(object sender, EventArgs e)
        {
            if (f.Visible)
            {
                f.Hide();
                return;
            }
            f.Show();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        // Credits
        private void button4_Click(object sender, EventArgs e)
        {
            Credits c = new Credits();
            c.Show();
        }
        // Copy Map Link
        private void button5_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("https://beatsaver.com/maps/" + m.id);
        }

        private void ChangeUI_Click(object sender, EventArgs e)
        {
            Hide();
            BetterUI b = new BetterUI();
            b.Closed += (s, args) => Close();
            b.Show();
            
        }
    }
}

