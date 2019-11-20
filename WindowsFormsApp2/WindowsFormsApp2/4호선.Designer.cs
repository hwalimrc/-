namespace WindowsFormsApp2
{
    partial class _4호선
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_4호선));
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.미남 = new System.Windows.Forms.RadioButton();
            this.동래 = new System.Windows.Forms.RadioButton();
            this.충렬사 = new System.Windows.Forms.RadioButton();
            this.금사 = new System.Windows.Forms.RadioButton();
            this.반여 = new System.Windows.Forms.RadioButton();
            this.영산대 = new System.Windows.Forms.RadioButton();
            this.동부산대학 = new System.Windows.Forms.RadioButton();
            this.고촌 = new System.Windows.Forms.RadioButton();
            this.안평 = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(520, 399);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(181, 30);
            this.button2.TabIndex = 16;
            this.button2.Text = "도착역으로 지정";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(333, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 30);
            this.button1.TabIndex = 15;
            this.button1.Text = "출발역으로 지정";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(280, 352);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(186, 21);
            this.textBox1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(8, 349);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "역 이름을 선택하세요:";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::WindowsFormsApp2.Properties.Resources._4호선;
            this.panel1.Controls.Add(this.미남);
            this.panel1.Controls.Add(this.동래);
            this.panel1.Controls.Add(this.충렬사);
            this.panel1.Controls.Add(this.금사);
            this.panel1.Controls.Add(this.반여);
            this.panel1.Controls.Add(this.영산대);
            this.panel1.Controls.Add(this.동부산대학);
            this.panel1.Controls.Add(this.고촌);
            this.panel1.Controls.Add(this.안평);
            this.panel1.Location = new System.Drawing.Point(8, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 327);
            this.panel1.TabIndex = 0;
            // 
            // 미남
            // 
            this.미남.AutoSize = true;
            this.미남.BackColor = System.Drawing.SystemColors.Control;
            this.미남.Location = new System.Drawing.Point(574, 172);
            this.미남.Name = "미남";
            this.미남.Size = new System.Drawing.Size(14, 13);
            this.미남.TabIndex = 17;
            this.미남.TabStop = true;
            this.미남.UseVisualStyleBackColor = false;
            this.미남.CheckedChanged += new System.EventHandler(this.미남_CheckedChanged);
            // 
            // 동래
            // 
            this.동래.AutoSize = true;
            this.동래.Location = new System.Drawing.Point(525, 172);
            this.동래.Name = "동래";
            this.동래.Size = new System.Drawing.Size(14, 13);
            this.동래.TabIndex = 12;
            this.동래.TabStop = true;
            this.동래.UseVisualStyleBackColor = true;
            this.동래.CheckedChanged += new System.EventHandler(this.동래_CheckedChanged);
            // 
            // 충렬사
            // 
            this.충렬사.AutoSize = true;
            this.충렬사.Location = new System.Drawing.Point(397, 172);
            this.충렬사.Name = "충렬사";
            this.충렬사.Size = new System.Drawing.Size(14, 13);
            this.충렬사.TabIndex = 9;
            this.충렬사.TabStop = true;
            this.충렬사.UseVisualStyleBackColor = true;
            this.충렬사.CheckedChanged += new System.EventHandler(this.충렬사_CheckedChanged);
            // 
            // 금사
            // 
            this.금사.AutoSize = true;
            this.금사.Location = new System.Drawing.Point(270, 172);
            this.금사.Name = "금사";
            this.금사.Size = new System.Drawing.Size(14, 13);
            this.금사.TabIndex = 6;
            this.금사.TabStop = true;
            this.금사.UseVisualStyleBackColor = true;
            this.금사.CheckedChanged += new System.EventHandler(this.금사_CheckedChanged);
            // 
            // 반여
            // 
            this.반여.AutoSize = true;
            this.반여.Location = new System.Drawing.Point(228, 172);
            this.반여.Name = "반여";
            this.반여.Size = new System.Drawing.Size(14, 13);
            this.반여.TabIndex = 5;
            this.반여.TabStop = true;
            this.반여.UseVisualStyleBackColor = true;
            this.반여.CheckedChanged += new System.EventHandler(this.반여_CheckedChanged);
            // 
            // 영산대
            // 
            this.영산대.AutoSize = true;
            this.영산대.Location = new System.Drawing.Point(143, 172);
            this.영산대.Name = "영산대";
            this.영산대.Size = new System.Drawing.Size(14, 13);
            this.영산대.TabIndex = 3;
            this.영산대.TabStop = true;
            this.영산대.UseVisualStyleBackColor = true;
            this.영산대.CheckedChanged += new System.EventHandler(this.영산대_CheckedChanged);
            // 
            // 동부산대학
            // 
            this.동부산대학.AutoSize = true;
            this.동부산대학.Location = new System.Drawing.Point(101, 172);
            this.동부산대학.Name = "동부산대학";
            this.동부산대학.Size = new System.Drawing.Size(14, 13);
            this.동부산대학.TabIndex = 2;
            this.동부산대학.TabStop = true;
            this.동부산대학.UseVisualStyleBackColor = true;
            this.동부산대학.CheckedChanged += new System.EventHandler(this.동부산대학_CheckedChanged);
            // 
            // 고촌
            // 
            this.고촌.AutoSize = true;
            this.고촌.Location = new System.Drawing.Point(59, 172);
            this.고촌.Name = "고촌";
            this.고촌.Size = new System.Drawing.Size(14, 13);
            this.고촌.TabIndex = 1;
            this.고촌.TabStop = true;
            this.고촌.UseVisualStyleBackColor = true;
            this.고촌.CheckedChanged += new System.EventHandler(this.고촌_CheckedChanged);
            // 
            // 안평
            // 
            this.안평.AutoSize = true;
            this.안평.Location = new System.Drawing.Point(17, 172);
            this.안평.Name = "안평";
            this.안평.Size = new System.Drawing.Size(14, 13);
            this.안평.TabIndex = 0;
            this.안평.TabStop = true;
            this.안평.UseVisualStyleBackColor = true;
            this.안평.CheckedChanged += new System.EventHandler(this.안평_CheckedChanged);
            // 
            // _4호선
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 435);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "_4호선";
            this.Text = "_4호선";
            this.Load += new System.EventHandler(this._4호선_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton 미남;
        private System.Windows.Forms.RadioButton 동래;
        private System.Windows.Forms.RadioButton 충렬사;
        private System.Windows.Forms.RadioButton 반여;
        private System.Windows.Forms.RadioButton 영산대;
        private System.Windows.Forms.RadioButton 동부산대학;
        private System.Windows.Forms.RadioButton 안평;
        private System.Windows.Forms.RadioButton 금사;
        private System.Windows.Forms.RadioButton 고촌;
    }
}