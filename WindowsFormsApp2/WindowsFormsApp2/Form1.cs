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
    public partial class Form1 : Form
    {
        public int[,] graph = new int[54, 54];
        public int count = 0;
        public string result_algo;
        public int stationCode;
        public int startStation, endStation;
        public string station = "";
        public List<string> sta = new List<string>();
        public List<string> list = new List<string>();

        Node 신평 = new Node(0, "신평");
        Node 하단 = new Node(1, "하단");
        Node 당리 = new Node(2, "당리");
        Node 사하 = new Node(3, "사하");
        Node 부산대병원 = new Node(4, "부산대병원");
        Node 자갈치 = new Node(5, "자갈치");
        Node 남포동 = new Node(6, "남포동");
        Node 중앙동 = new Node(7, "중앙동");
        Node 부산역 = new Node(8, "부산역");
        Node 범내골 = new Node(9, "범내골");
        Node 서면 = new Node(10, "서면");
        Node 시청 = new Node(11, "시청");
        Node 연산동 = new Node(12, "연산동");
        Node 교대앞 = new Node(13, "교대앞");
        Node 동래 = new Node(14, "동래");
        Node 부산대 = new Node(15, "부산대");
        Node 노포동 = new Node(16, "노포동");

        Node 장산 = new Node(17, "장산");
        Node 해운대 = new Node(18, "해운대");
        Node 시립미술관 = new Node(19, "시립미술관");
        Node 센텀시티 = new Node(20, "센텀시티");
        Node 수영 = new Node(21, "수영");
        Node 광안 = new Node(22, "광안");
        Node 경성대부경대 = new Node(23, "경성대부경대");
        Node 부산은행 = new Node(24, "부산은행");
        Node 동의대 = new Node(25, "동의대");
        Node 감천 = new Node(26, "감천");
        Node 사상 = new Node(27, "사상");
        Node 덕천 = new Node(28, "덕천");
        Node 부산대양산 = new Node(29, "부산대양산");
        Node 양산 = new Node(30, "양산");

        Node 망미 = new Node(31, "망미");
        Node 거제 = new Node(32, "거제");
        Node 종합운동장 = new Node(33, "종합운동장");
        Node 사직 = new Node(34, "사직");
        Node 미남 = new Node(35, "미남");
        Node 만덕 = new Node(36, "만덕");
        Node 숙동 = new Node(37, "숙동");
        Node 구포 = new Node(38, "구포");
        Node 강서구청 = new Node(39, "강서구청");
        Node 대저 = new Node(40, "대저");

        Node 안평 = new Node(41, "안평");
        Node 고촌 = new Node(42, "고촌");
        Node 동부산대학 = new Node(43, "동부산대학");
        Node 영산대 = new Node(44, "영산대");
        Node 반여 = new Node(45, "반여");
        Node 금사 = new Node(46, "금사");
        Node 충렬사 = new Node(47, "충렬사");

        Node 궤법르네시떼 = new Node(48, "궤법르네시떼");
        Node 공항 = new Node(49, "공항");
        Node 인제대 = new Node(50, "인제대");
        Node 수로왕릉 = new Node(51, "수로왕릉");
        Node 박물관 = new Node(52, "박물관");
        Node 가야대 = new Node(53, "가야대");

        public void createEdge(Node start, Node end, int weight)
        {
            graph[start.code, end.code] = weight;
            graph[end.code, start.code] = weight;
        }

        public void createGraph()
        {
            createEdge(신평, 하단, 2);
            createEdge(하단, 당리, 2);
            createEdge(당리, 사하, 2);
            createEdge(사하, 부산대병원, 10);
            createEdge(부산대병원, 자갈치, 2);
            createEdge(자갈치, 남포동, 2);
            createEdge(남포동, 중앙동, 2);
            createEdge(중앙동, 부산역, 2);
            createEdge(부산역, 범내골, 10);
            createEdge(범내골, 서면, 2);
            createEdge(서면, 시청, 6);
            createEdge(시청, 연산동, 2);
            createEdge(연산동, 교대앞, 2);
            createEdge(교대앞, 동래, 2);
            createEdge(동래, 부산대, 6);
            createEdge(부산대, 노포동, 12);

            createEdge(장산, 해운대, 4);
            createEdge(해운대, 시립미술관, 4);
            createEdge(시립미술관, 센텀시티, 2);
            createEdge(센텀시티, 수영, 4);
            createEdge(수영, 광안, 2);
            createEdge(광안, 경성대부경대, 6);
            createEdge(경성대부경대, 부산은행, 10);
            createEdge(부산은행, 서면, 4);
            createEdge(서면, 동의대, 6);
            createEdge(동의대, 감천, 8);
            createEdge(감천, 사상, 2);
            createEdge(사상, 덕천, 12);
            createEdge(덕천, 부산대양산, 16);
            createEdge(부산대양산, 양산, 4);

            createEdge(수영, 망미, 2);
            createEdge(망미, 연산동, 6);
            createEdge(연산동, 거제, 2);
            createEdge(거제, 종합운동장, 2);
            createEdge(종합운동장, 사직, 2);
            createEdge(사직, 미남, 2);
            createEdge(미남, 만덕, 2);
            createEdge(만덕, 숙동, 4);
            createEdge(숙동, 덕천, 2);
            createEdge(덕천, 구포, 2);
            createEdge(구포, 강서구청, 2);
            createEdge(강서구청, 대저, 4);

            createEdge(안평, 고촌, 2);
            createEdge(고촌, 동부산대학, 2);
            createEdge(동부산대학, 영산대, 2);
            createEdge(영산대, 반여, 4);
            createEdge(반여, 금사, 2);
            createEdge(금사, 충렬사, 6);
            createEdge(충렬사, 동래, 6);
            createEdge(동래, 미남, 2);

            createEdge(사상, 궤법르네시떼, 2);
            createEdge(궤법르네시떼, 공항, 4);
            createEdge(공항, 대저, 6);
            createEdge(대저, 인제대, 12);
            createEdge(인제대, 수로왕릉, 8);
            createEdge(수로왕릉, 박물관, 2);
            createEdge(박물관, 가야대, 6);

            sta.Add("신평"); sta.Add("하단"); sta.Add("당리"); sta.Add("사하"); sta.Add("부산대병원");
            sta.Add("자갈치"); sta.Add("남포동"); sta.Add("중앙동"); sta.Add("부산역"); sta.Add("범내골");
            sta.Add("서면"); sta.Add("시청"); sta.Add("연산동"); sta.Add("교대앞"); sta.Add("동래");
            sta.Add("부산대"); sta.Add("노포동");

            sta.Add("장산"); sta.Add("해운대"); sta.Add("시립미술관"); sta.Add("센텀시티"); sta.Add("수영");
            sta.Add("광안"); sta.Add("경성대부경대"); sta.Add("부산은행"); sta.Add("동의대");
            sta.Add("감천"); sta.Add("사상"); sta.Add("덕천"); sta.Add("부산대양산"); sta.Add("양산");

            sta.Add("망미"); sta.Add("거제"); sta.Add("종합운동장"); sta.Add("사직"); sta.Add("미남");
            sta.Add("만덕"); sta.Add("숙동"); sta.Add("구포"); sta.Add("강서구청"); sta.Add("대저");

            sta.Add("안평"); sta.Add("고촌"); sta.Add("동부산대학"); sta.Add("영산대"); sta.Add("반여");
            sta.Add("금사"); sta.Add("충렬사");

            sta.Add("궤법르네시떼"); sta.Add("공항"); sta.Add("인제대"); sta.Add("수로왕릉"); sta.Add("박물관");
            sta.Add("가야대");
        }

        public int MinimumDistance(int[] distance, bool[] shortestPathTreeSet, int verticesCount)
        {
            int min = int.MaxValue;
            int minIndex = 0;

            for (int v = 0; v < verticesCount; ++v)
            {
                if (shortestPathTreeSet[v] == false && distance[v] <= min)
                {
                    min = distance[v];
                    minIndex = v;
                }
            }
            return minIndex;
        }

        private void Print(int[] distance, int source, int verticesCount)
        {
            for (int i = source; i < verticesCount; i++)
            {
                station += " " + sta[i];
            }

            for (int i = 0; i < verticesCount; ++i)
            {
                count = distance[i];
            }
        }

        public void DijkstraAlgo(int[,] graph, int source, int verticesCount)
        {
            if (source > verticesCount)
            {
                int temp = source;
                source = verticesCount;
                verticesCount = temp;
            }

            int[] distance = new int[verticesCount];
            bool[] shortestPathTreeSet = new bool[verticesCount];

            for (int i = 0; i < verticesCount; ++i)
            {
                distance[i] = int.MaxValue;
                shortestPathTreeSet[i] = false;
            }

            distance[source] = 0;

            for (int count = 0; count < verticesCount - 1; ++count)
            {
                int u = MinimumDistance(distance, shortestPathTreeSet, verticesCount);
                shortestPathTreeSet[u] = true;

                for (int v = 0; v < verticesCount; ++v)
                    if (!shortestPathTreeSet[v] && Convert.ToBoolean(graph[u, v]))
                        if (distance[u] != int.MaxValue)
                            if (distance[v] > distance[u] + graph[u, v])
                                distance[v] = distance[u] + graph[u, v];
            }
            Print(distance, source, verticesCount);
        }

        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                    graph[i, j] = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        { _1호선 place = new _1호선(this); place.Show(); }

        private void button2_Click(object sender, EventArgs e)
        { _2호선 place = new _2호선(this); place.Show(); }

        private void button3_Click(object sender, EventArgs e)
        { _3호선 place = new _3호선(this); place.Show(); }

        private void button4_Click(object sender, EventArgs e)
        { _4호선 place = new _4호선(this); place.Show(); }

        private void button5_Click(object sender, EventArgs e)
        { 부산김해경전철 place = new 부산김해경전철(this); place.Show(); }

        public void setPlaceData(string state)
        { Start.Text = state; }

        public void setPlaceEndData(string state)
        { end.Text = state; }

        private void 초기화_Click(object sender, EventArgs e)

        {
            textBox1.Text = ""; Start.Text = ""; end.Text = "";
            station = "";
            result.Text = "";
        }

        private void 확인_Click(object sender, EventArgs e)
        {
            if (Start.Text.Length == 0 || end.Text.Length == 0)
            {
                MessageBox.Show("출발역과 도착역을 모두 지정해주세요");
                return;
            }

            if (Start.Text == end.Text)
            {
                result.Text = "0"; textBox1.Text = "당역하차";
                return;
            }

            createGraph();
            DijkstraAlgo(graph, startStation, endStation);
            result.Text = (count + 2).ToString();
            textBox1.Text = station;
        }
    }
}