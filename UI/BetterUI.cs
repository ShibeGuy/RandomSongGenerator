using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Men.Utilities;
using Men.BeatSaver;


namespace Men.UI
{
    public partial class BetterUI : Form
    {
        private Map mp;
        public BetterUI()
        {
            InitializeComponent();
            for (int i = 1; i < 5; i++)
            {
                Filters.SetItemChecked(i, true);
            }
            Filters.ItemCheck += new ItemCheckEventHandler(ItemCheck);
        }
        private void ItemCheck(object sender, ItemCheckEventArgs e)
        {
            /*for (int i = 4; i < 10; i++)
            {
                if (Filters.GetItemChecked(i))
                {
                    if (i == e.Index)
                        continue;
                    
                    return;
                }
            }*/
            Men.Utilities.Filters.filter ^= (short)Math.Pow(2, e.Index);
        }

        private void BetterUI_Load(object sender, EventArgs e)
        {
            if(!Random_Song_Generator.Properties.Settings.Default.accepted)
            {
                DialogResult r = MessageBox.Show("This program utilizes the BeatSaver API for validating map keys. If more than one exclusive filter is enabled, this will send the program into a loop, sending the BeatSaver API many requests, which may cause your IP to be blacklisted. Do you understand?", "API Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if(r == DialogResult.Yes)
                {

                    Random_Song_Generator.Properties.Settings.Default.accepted = true;
                    Random_Song_Generator.Properties.Settings.Default.Save();

                }
            }
        }

        private void gen_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(Generate);
            t.IsBackground = true;
            t.Start();
            

        }
        private void Generate()
        {
            RandomBeatSaver rand = new RandomBeatSaver(status);
            Map map = rand.Next();
            mp = map;
            songName.Invoke(new Action(() =>  songName.Text = $"{map.metadata.songName} - {map.metadata.songAuthorName}" ));
            subname.Invoke(new Action(() => subname.Text = map.metadata.songSubName));
            coverArt.Invoke(new Action(() => coverArt.ImageLocation = map.versions[0].coverURl));
            
            mapper.Invoke(new Action(() => mapper.Text = map.metadata.levelAuthorName));

            copy.Invoke(new Action(() => copy.Enabled = true));
            oneclick.Invoke(new Action(() => oneclick.Enabled = true));
            key.Invoke(new Action(() => key.Enabled = true));
            int i = 0;
            diffPanel.Invoke(new Action(() => diffPanel.Controls.Clear()));
            foreach(BeatSaver.Difficulty d in map.versions[0].diffs)
            {

                diffPanel.Invoke(new Action(() => {
                    Controls.Difficulty dif = new Controls.Difficulty(d);

                    dif.Left = dif.Width * i;
                    diffPanel.Controls.Add(dif);
                }));
                i++;
            }
            // diffPanel

        }

        private void copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText($"https://beatsaver.com/maps/{mp.id}");
        }

        private void oneclick_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start($"beatsaver://{mp.id}");
        }

        private void key_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(mp.id);
        }
    }
}
