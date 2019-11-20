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
    public partial class _1호선 : Form
    {
        private Form1 form1 = null;
        public int stationCode;

        public _1호선(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void 신봉_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "신평";
            stationCode = 0;
        }

        private void 하단_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "하단";
            stationCode = 1;
        }

        private void 당리_CheckedChanged(object sender, EventArgs e)
        { textBox1.Text = "당리"; stationCode = 2; }

        private void 사하_CheckedChanged(object sender, EventArgs e)
        { textBox1.Text = "사하"; stationCode = 3; }

        private void 부산대병원_CheckedChanged(object sender, EventArgs e)
        { textBox1.Text = "부산대병원"; stationCode = 4; }

        private void 자갈치_CheckedChanged(object sender, EventArgs e)
        { textBox1.Text = "자갈치"; stationCode = 5; }

        private void 남포동_CheckedChanged(object sender, EventArgs e)
        { textBox1.Text = "남포동"; stationCode = 6; }

        private void 중앙동_CheckedChanged(object sender, EventArgs e)
        { textBox1.Text = "중앙동"; stationCode = 7; }

        private void 부산역_CheckedChanged(object sender, EventArgs e)
        { textBox1.Text = "부산역"; stationCode = 8; }

        private void 범내골_CheckedChanged(object sender, EventArgs e)
        { textBox1.Text = "범내골"; stationCode = 9; }

        private void 서면_CheckedChanged(object sender, EventArgs e)
        { textBox1.Text = "서면"; stationCode = 10; }

        private void 시청_CheckedChanged(object sender, EventArgs e)
        { textBox1.Text = "시청"; stationCode = 11; }

        private void 연산동_CheckedChanged(object sender, EventArgs e)
        { textBox1.Text = "연산동"; stationCode = 12; }

        private void 교대앞_CheckedChanged(object sender, EventArgs e)
        { textBox1.Text = "교대앞"; stationCode = 13; }

        private void 동래_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "동래"; stationCode = 14;
        }

        private void 부산대_CheckedChanged(object sender, EventArgs e)
        { textBox1.Text = "부산대"; stationCode = 15; }

        private void 노포동_CheckedChanged(object sender, EventArgs e)
        { textBox1.Text = "노포동"; stationCode = 16; }

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