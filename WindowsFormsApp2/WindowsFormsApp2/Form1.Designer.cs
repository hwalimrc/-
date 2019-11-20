namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.minute = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.확인 = new System.Windows.Forms.Button();
            this.end = new System.Windows.Forms.TextBox();
            this.도착역 = new System.Windows.Forms.Label();
            this.출발역 = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.초기화 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // minute
            // 
            this.minute.AutoSize = true;
            this.minute.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.minute.Location = new System.Drawing.Point(247, 52);
            this.minute.Name = "minute";
            this.minute.Size = new System.Drawing.Size(32, 21);
            this.minute.TabIndex = 19;
            this.minute.Text = "분";
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(165, 53);
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.Size = new System.Drawing.Size(82, 21);
            this.result.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(6, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "총 소요시간:";
            // 
            // 확인
            // 
            this.확인.Location = new System.Drawing.Point(458, 17);
            this.확인.Name = "확인";
            this.확인.Size = new System.Drawing.Size(81, 22);
            this.확인.TabIndex = 16;
            this.확인.Text = "확인";
            this.확인.UseVisualStyleBackColor = true;
            this.확인.Click += new System.EventHandler(this.확인_Click);
            // 
            // end
            // 
            this.end.Location = new System.Drawing.Point(320, 18);
            this.end.Name = "end";
            this.end.ReadOnly = true;
            this.end.Size = new System.Drawing.Size(114, 21);
            this.end.TabIndex = 15;
            // 
            // 도착역
            // 
            this.도착역.AutoSize = true;
            this.도착역.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.도착역.Location = new System.Drawing.Point(238, 18);
            this.도착역.Name = "도착역";
            this.도착역.Size = new System.Drawing.Size(76, 21);
            this.도착역.TabIndex = 14;
            this.도착역.Text = "도착역";
            // 
            // 출발역
            // 
            this.출발역.AutoSize = true;
            this.출발역.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.출발역.Location = new System.Drawing.Point(6, 17);
            this.출발역.Name = "출발역";
            this.출발역.Size = new System.Drawing.Size(76, 21);
            this.출발역.TabIndex = 13;
            this.출발역.Text = "출발역";
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(88, 18);
            this.Start.Name = "Start";
            this.Start.ReadOnly = true;
            this.Start.Size = new System.Drawing.Size(118, 21);
            this.Start.TabIndex = 12;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 119);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(118, 27);
            this.button4.TabIndex = 23;
            this.button4.Text = "4호선(반송선)";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 86);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 27);
            this.button3.TabIndex = 22;
            this.button3.Text = "3호선";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 53);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 27);
            this.button2.TabIndex = 21;
            this.button2.Text = "2호선";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 27);
            this.button1.TabIndex = 20;
            this.button1.Text = "1호선";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Location = new System.Drawing.Point(779, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(132, 185);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "노선도 크게보기";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(6, 152);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(118, 27);
            this.button5.TabIndex = 24;
            this.button5.Text = "부산김해경전철";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.초기화);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.출발역);
            this.groupBox2.Controls.Add(this.Start);
            this.groupBox2.Controls.Add(this.minute);
            this.groupBox2.Controls.Add(this.도착역);
            this.groupBox2.Controls.Add(this.result);
            this.groupBox2.Controls.Add(this.end);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.확인);
            this.groupBox2.Location = new System.Drawing.Point(12, 279);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(891, 127);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Menu";
            // 
            // 초기화
            // 
            this.초기화.Location = new System.Drawing.Point(545, 17);
            this.초기화.Name = "초기화";
            this.초기화.Size = new System.Drawing.Size(106, 22);
            this.초기화.TabIndex = 22;
            this.초기화.Text = "초기화";
            this.초기화.UseVisualStyleBackColor = true;
            this.초기화.Click += new System.EventHandler(this.초기화_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(418, 52);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(445, 50);
            this.textBox1.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(343, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 24);
            this.label2.TabIndex = 20;
            this.label2.Text = "경로:";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::WindowsFormsApp2.Properties.Resources._신_노선도3;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(761, 261);
            this.panel1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 418);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "부산지하철노선도";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label minute;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button 확인;
        public System.Windows.Forms.TextBox end;
        private System.Windows.Forms.Label 도착역;
        private System.Windows.Forms.Label 출발역;
        public System.Windows.Forms.TextBox Start;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button 초기화;
    }
}