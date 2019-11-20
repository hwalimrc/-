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
    public partial class 부산김해경전철 : Form
    {
        private Form1 form1 = null;
        public int stationCode;

        public 부산김해경전철(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

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

        private void 사상_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "사상"; stationCode = 28;
        }

        private void 궤법르네시떼_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "궤법르네시떼"; stationCode = 48;
        }

        private void 김해공항_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "공항"; stationCode = 49;
        }

        private void 대저_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "대저"; stationCode = 40;
        }

        private void 인제대_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "인제대"; stationCode = 50;
        }

        private void 수로왕릉_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "수로왕릉"; stationCode = 51;
        }

        private void 박물관_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "박물관"; stationCode = 52;
        }

        private void 가야대_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "가야대"; stationCode = 53;
        }
    }
}
