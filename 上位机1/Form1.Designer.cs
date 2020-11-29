namespace 上位机1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.duankou1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.byterate = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.shujuwei = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.jiaoyanwei = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tingzhiwei = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.output_test = new System.Windows.Forms.RichTextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.com = new System.IO.Ports.SerialPort(this.components);
            this.auto_change_line = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.send_area = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.show_time = new System.Windows.Forms.CheckBox();
            this.s = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(291, 630);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(36, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "端口";
            // 
            // duankou1
            // 
            this.duankou1.FormattingEnabled = true;
            this.duankou1.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9",
            "COM10"});
            this.duankou1.Location = new System.Drawing.Point(93, 35);
            this.duankou1.Name = "duankou1";
            this.duankou1.Size = new System.Drawing.Size(102, 23);
            this.duankou1.TabIndex = 5;
            this.duankou1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(15, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "波特率";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // byterate
            // 
            this.byterate.FormattingEnabled = true;
            this.byterate.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "56000",
            "57600",
            "115200",
            "128000",
            "256000"});
            this.byterate.Location = new System.Drawing.Point(93, 73);
            this.byterate.Name = "byterate";
            this.byterate.Size = new System.Drawing.Size(102, 23);
            this.byterate.TabIndex = 7;
            this.byterate.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(15, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "数据位";
            // 
            // shujuwei
            // 
            this.shujuwei.FormattingEnabled = true;
            this.shujuwei.Items.AddRange(new object[] {
            "8",
            "7",
            "6",
            "5"});
            this.shujuwei.Location = new System.Drawing.Point(93, 109);
            this.shujuwei.Name = "shujuwei";
            this.shujuwei.Size = new System.Drawing.Size(102, 23);
            this.shujuwei.TabIndex = 9;
            this.shujuwei.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(15, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "校验位";
            // 
            // jiaoyanwei
            // 
            this.jiaoyanwei.FormattingEnabled = true;
            this.jiaoyanwei.Items.AddRange(new object[] {
            "无校验",
            "奇校验",
            "偶校验"});
            this.jiaoyanwei.Location = new System.Drawing.Point(93, 143);
            this.jiaoyanwei.Name = "jiaoyanwei";
            this.jiaoyanwei.Size = new System.Drawing.Size(102, 23);
            this.jiaoyanwei.TabIndex = 11;
            this.jiaoyanwei.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(15, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "停止位";
            // 
            // tingzhiwei
            // 
            this.tingzhiwei.FormattingEnabled = true;
            this.tingzhiwei.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.tingzhiwei.Location = new System.Drawing.Point(93, 179);
            this.tingzhiwei.Name = "tingzhiwei";
            this.tingzhiwei.Size = new System.Drawing.Size(102, 23);
            this.tingzhiwei.TabIndex = 13;
            this.tingzhiwei.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(19, 218);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 38);
            this.button2.TabIndex = 15;
            this.button2.Text = "打开串口";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // output_test
            // 
            this.output_test.AutoWordSelection = true;
            this.output_test.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.output_test.Location = new System.Drawing.Point(228, 49);
            this.output_test.Name = "output_test";
            this.output_test.ReadOnly = true;
            this.output_test.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.output_test.Size = new System.Drawing.Size(827, 315);
            this.output_test.TabIndex = 17;
            this.output_test.Text = "";
            this.output_test.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(5, 33);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(52, 19);
            this.radioButton1.TabIndex = 20;
            this.radioButton1.Text = "HEX";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(122, 33);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(68, 19);
            this.radioButton2.TabIndex = 21;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "ASCII";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // com
            // 
            this.com.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialDataReceivedEventHandler);
            // 
            // auto_change_line
            // 
            this.auto_change_line.AutoSize = true;
            this.auto_change_line.Location = new System.Drawing.Point(2, 58);
            this.auto_change_line.Margin = new System.Windows.Forms.Padding(0);
            this.auto_change_line.Name = "auto_change_line";
            this.auto_change_line.Size = new System.Drawing.Size(89, 19);
            this.auto_change_line.TabIndex = 22;
            this.auto_change_line.Text = "自动换行";
            this.auto_change_line.UseVisualStyleBackColor = true;
            this.auto_change_line.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label6.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(224, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 19);
            this.label6.TabIndex = 23;
            this.label6.Text = "接收区";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label7.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(224, 376);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 19);
            this.label7.TabIndex = 24;
            this.label7.Text = "发送区";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // send_area
            // 
            this.send_area.Location = new System.Drawing.Point(228, 415);
            this.send_area.Name = "send_area";
            this.send_area.Size = new System.Drawing.Size(827, 191);
            this.send_area.TabIndex = 25;
            this.send_area.Text = "";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(980, 646);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 26;
            this.button1.Text = "发送";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.Location = new System.Drawing.Point(825, 646);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(137, 29);
            this.button3.TabIndex = 27;
            this.button3.Text = "清发送区";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button4.Location = new System.Drawing.Point(12, 577);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(106, 29);
            this.button4.TabIndex = 28;
            this.button4.Text = "清接收区";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.69613F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.30387F));
            this.tableLayoutPanel1.Controls.Add(this.show_time, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.radioButton2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.radioButton1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.auto_change_line, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.s, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 274);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(2, 0, 0, 3);
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.87719F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.12281F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(216, 108);
            this.tableLayoutPanel1.TabIndex = 29;
            // 
            // show_time
            // 
            this.show_time.AutoSize = true;
            this.show_time.Location = new System.Drawing.Point(2, 84);
            this.show_time.Margin = new System.Windows.Forms.Padding(0);
            this.show_time.Name = "show_time";
            this.show_time.Size = new System.Drawing.Size(89, 19);
            this.show_time.TabIndex = 30;
            this.show_time.Text = "显示时间";
            this.show_time.UseVisualStyleBackColor = true;
            this.show_time.CheckedChanged += new System.EventHandler(this.show_time_CheckedChanged);
            // 
            // s
            // 
            this.s.AutoSize = true;
            this.s.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.s.Location = new System.Drawing.Point(2, 0);
            this.s.Margin = new System.Windows.Forms.Padding(0);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(80, 15);
            this.s.TabIndex = 30;
            this.s.Text = "接收设置:";
            this.s.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.s.Click += new System.EventHandler(this.label8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1095, 759);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.send_area);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.output_test);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tingzhiwei);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.jiaoyanwei);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.shujuwei);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.byterate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.duankou1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "华东理工大学上位机";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox duankou1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox byterate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox shujuwei;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox jiaoyanwei;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox tingzhiwei;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox output_test;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.IO.Ports.SerialPort com;
        private System.Windows.Forms.CheckBox auto_change_line;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox send_area;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label s;
        private System.Windows.Forms.CheckBox show_time;
        private System.Windows.Forms.Timer timer1;
    }
}

