using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace MPC_HC_GET_TRACK_NAME
{
    public partial class Form1 : Form
    {
        string localhost = @"http://localhost:";
        string page = @"/variables.html";
        string port = "13579";
        string cur_track = "";
        bool space = false;
        bool replace = false;
        WebClient web;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            port = comboBoxPort.Text;
            web = new WebClient();
        }

        private void comboBox2_TextChanged(object sender, EventArgs e)
        {
            port = comboBoxPort.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Interval = int.Parse(comboBoxInterval.Text) * 1000;
            port = comboBoxPort.Text;
            space = checkBoxSpace.Checked;
            replace = checkBoxReplace.Checked;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(timer1.Enabled)
            {
                timer1.Enabled = false;
                buttonState.Text = "Disabled";
            } else
            {
                timer1.Enabled = true;
                buttonState.Text = "Enabled";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string tmp_track = "";
            try
            {
                tmp_track = GetTrack(web.DownloadString(localhost + port + page));
            } catch
            {
                tmp_track = "No music!";
            }
            if (tmp_track != cur_track)
            {
                cur_track = tmp_track;
                StreamWriter sw = new StreamWriter(".\\current_track.txt", false, Encoding.UTF8);
                sw.Write(tmp_track);
                sw.Close();
                //MessageBox.Show(tmp_track);
            }
        }

        private string GetTrack(string htmlPage)
        {
            int tmp_i1 = htmlPage.IndexOf("id=\"file\"");
            int tmp_i2 = htmlPage.IndexOf(">", tmp_i1) + 1;
            int tmp_i3 = htmlPage.IndexOf("</p", tmp_i2);
            string tmp_s = htmlPage.Substring(tmp_i2, tmp_i3 - tmp_i2) + "";
            tmp_s = tmp_s.Substring(0, tmp_s.IndexOf(".mp3"));
            try
            {
                if (replace)
                {
                    tmp_s = tmp_s.Replace(textBoxReplace1.Text, textBoxReplace2.Text);
                }
            } catch { }
            try
            {
                if (space)
                {
                    tmp_s += " ";
                }
            } catch { }
                return tmp_s;
        }
    }
}
