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
    public partial class _3호선 : Form
    {
        private Form1 form1 = null;
        public int stationCode;

        public _3호선(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void 수영_CheckedChanged(object sender, EventArgs e)
        { textBox1.Text = "수영"; stationCode = 21; }

        private void 망미_CheckedChanged(object sender, EventArgs e)
        { textBox1.Text = "망미"; stationCode = 31; }

        private void 연산_CheckedChanged(object sender, EventArgs e)
        { textBox1.Text = "연산동"; stationCode = 12; }

        private void 거제_CheckedChanged(object sender, EventArgs e)
        { textBox1.Text = "거제"; stationCode = 32; }

        private void 종합운동장_CheckedChanged(object sender, EventArgs e)
        { textBox1.Text = "종합운동장"; stationCode = 33; }

        private void 사직_CheckedChanged(object sender, EventArgs e)
        { textBox1.Text = "사직"; stationCode = 34; }

        private void 미남_CheckedChanged(object sender, EventArgs e)
        { textBox1.Text = "미남"; stationCode = 35; }

        private void 만덕_CheckedChanged(object sender, EventArgs e)
        { textBox1.Text = "만덕"; stationCode = 36; }

        private void 숙동_CheckedChanged(object sender, EventArgs e)
        { textBox1.Text = "숙동"; stationCode = 37; }

        private void 덕천_CheckedChanged(object sender, EventArgs e)
        { textBox1.Text = "덕천"; stationCode = 29; }

        private void 구포_CheckedChanged(object sender, EventArgs e)
        { textBox1.Text = "구포"; stationCode = 38; }

        private void 강서구청_CheckedChanged(object sender, EventArgs e)
        { textBox1.Text = "강서구청"; stationCode = 39; }

        private void 대저_CheckedChanged(object sender, EventArgs e)
        { textBox1.Text = "대저"; stationCode = 40; }

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