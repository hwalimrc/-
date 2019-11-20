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
    public partial class _4호선 : Form
    {
        private Form1 form1 = null;
        public int stationCode;

        public _4호선(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void 안평_CheckedChanged(object sender, EventArgs e)
        { textBox1.Text = "안평"; stationCode = 41; }

        private void 고촌_CheckedChanged(object sender, EventArgs e)
        { textBox1.Text = "고촌"; stationCode = 42; }

        private void 동부산대학_CheckedChanged(object sender, EventArgs e)
        { textBox1.Text = "동부산대학"; stationCode = 43; }

        private void 영산대_CheckedChanged(object sender, EventArgs e)
        { textBox1.Text = "영산대"; stationCode = 44; }

        private void 반여_CheckedChanged(object sender, EventArgs e)
        { textBox1.Text = "반여"; stationCode = 45; }

        private void 금사_CheckedChanged(object sender, EventArgs e)
        { textBox1.Text = "금사"; stationCode = 46; }

        private void 충렬사_CheckedChanged(object sender, EventArgs e)
        { textBox1.Text = "충렬사"; stationCode = 47; }

        private void 동래_CheckedChanged(object sender, EventArgs e)
        { textBox1.Text = "동래"; stationCode = 14; }

        private void 미남_CheckedChanged(object sender, EventArgs e)
        { textBox1.Text = "미남"; stationCode = 35; }

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

        private void _4호선_Load(object sender, EventArgs e)
        {

        }
    }
}
