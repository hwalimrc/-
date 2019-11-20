using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class _2호선 : Form
    {
        private Form1 form1 = null;
        public int stationCode;

        public _2호선(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void 장산_CheckedChanged(object sender, EventArgs e)
        { textBox1.Text = "장산"; stationCode = 17; }

        private void 해운대_CheckedChanged(object sender, EventArgs e)
        { textBox1.Text = "해운대"; stationCode = 18; }

        private void 시립미술관_CheckedChanged(object sender, EventArgs e)
        { textBox1.Text = "시립미술관"; stationCode = 19; }

        private void 센텀시티_CheckedChanged(object sender, EventArgs e)
        { textBox1.Text = "센텀시티"; stationCode = 20; }

        private void 수영_CheckedChanged(object sender, EventArgs e)
        { textBox1.Text = "수영"; stationCode = 21; }

        private void 광안_CheckedChanged(object sender, EventArgs e)
        { textBox1.Text = "광안"; stationCode = 22; }

        private void 경성대_CheckedChanged(object sender, EventArgs e)
        { textBox1.Text = "경성대"; stationCode = 23; }

        private void 부산은행_CheckedChanged(object sender, EventArgs e)
        { textBox1.Text = "부산은행"; stationCode = 24; }

        private void 서면_CheckedChanged(object sender, EventArgs e)
        { textBox1.Text = "서면"; stationCode = 10; }

        private void 동의대_CheckedChanged(object sender, EventArgs e)
        { textBox1.Text = "동의대"; stationCode = 26; }

        private void 감천_CheckedChanged(object sender, EventArgs e)
        { textBox1.Text = "감천"; stationCode = 27; }

        private void 사상_CheckedChanged(object sender, EventArgs e)
        { textBox1.Text = "사상"; stationCode = 28; }

        private void 덕천_CheckedChanged(object sender, EventArgs e)
        { textBox1.Text = "덕천"; stationCode = 29; }

        private void 부산대양산_CheckedChanged(object sender, EventArgs e)
        { textBox1.Text = "부산대양산"; stationCode = 30; }

        private void 양산_CheckedChanged(object sender, EventArgs e)
        { textBox1.Text = "양산"; stationCode = 31; }

        private void button1_Click(object sender, EventArgs e)
        {
            form1.setPlaceData(textBox1.Text);
            form1.startStation = stationCode;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form1.setPlaceEndData(textBox1.Text);
            form1.endStation = stationCode;
            Close();
        }
    }
}