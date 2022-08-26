namespace MySerialPortApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存接收数据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.工具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.重置串口设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.作者ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.贡献者ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDownTimeout = new System.Windows.Forms.NumericUpDown();
            this.comboBoxStopBit = new System.Windows.Forms.ComboBox();
            this.comboBoxCheckBit = new System.Windows.Forms.ComboBox();
            this.comboBoxDataBit = new System.Windows.Forms.ComboBox();
            this.comboBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxPorts = new System.Windows.Forms.ComboBox();
            this.textBoxRecive = new System.Windows.Forms.TextBox();
            this.buttonRefreshPortsList = new System.Windows.Forms.Button();
            this.buttonOpenPorts = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonEmptyRecive = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButtonSendHEX = new System.Windows.Forms.RadioButton();
            this.radioButtonSendASCII = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioButtonReciveHEX = new System.Windows.Forms.RadioButton();
            this.radioButtonReciveASCII = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.textBoxSend = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimeout)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.工具ToolStripMenuItem,
            this.设置ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.保存接收数据ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 保存接收数据ToolStripMenuItem
            // 
            this.保存接收数据ToolStripMenuItem.Name = "保存接收数据ToolStripMenuItem";
            this.保存接收数据ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.保存接收数据ToolStripMenuItem.Text = "保存接收数据";
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            // 
            // 工具ToolStripMenuItem
            // 
            this.工具ToolStripMenuItem.Name = "工具ToolStripMenuItem";
            this.工具ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.工具ToolStripMenuItem.Text = "工具";
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.重置串口设置ToolStripMenuItem});
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.设置ToolStripMenuItem.Text = "设置";
            // 
            // 重置串口设置ToolStripMenuItem
            // 
            this.重置串口设置ToolStripMenuItem.Name = "重置串口设置ToolStripMenuItem";
            this.重置串口设置ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.重置串口设置ToolStripMenuItem.Text = "重置串口设置";
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.作者ToolStripMenuItem,
            this.贡献者ToolStripMenuItem});
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.关于ToolStripMenuItem.Text = "关于";
            // 
            // 作者ToolStripMenuItem
            // 
            this.作者ToolStripMenuItem.Name = "作者ToolStripMenuItem";
            this.作者ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.作者ToolStripMenuItem.Text = "作者";
            // 
            // 贡献者ToolStripMenuItem
            // 
            this.贡献者ToolStripMenuItem.Name = "贡献者ToolStripMenuItem";
            this.贡献者ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.贡献者ToolStripMenuItem.Text = "贡献者";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(96, 22);
            this.toolStripLabel1.Text = "toolStripLabel1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDownTimeout);
            this.groupBox1.Controls.Add(this.comboBoxStopBit);
            this.groupBox1.Controls.Add(this.comboBoxCheckBit);
            this.groupBox1.Controls.Add(this.comboBoxDataBit);
            this.groupBox1.Controls.Add(this.comboBoxBaudRate);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBoxPorts);
            this.groupBox1.Location = new System.Drawing.Point(12, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(188, 233);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "串口设置";
            // 
            // numericUpDownTimeout
            // 
            this.numericUpDownTimeout.Location = new System.Drawing.Point(56, 177);
            this.numericUpDownTimeout.Name = "numericUpDownTimeout";
            this.numericUpDownTimeout.Size = new System.Drawing.Size(91, 23);
            this.numericUpDownTimeout.TabIndex = 3;
            // 
            // comboBoxStopBit
            // 
            this.comboBoxStopBit.FormattingEnabled = true;
            this.comboBoxStopBit.Location = new System.Drawing.Point(55, 146);
            this.comboBoxStopBit.Name = "comboBoxStopBit";
            this.comboBoxStopBit.Size = new System.Drawing.Size(121, 25);
            this.comboBoxStopBit.TabIndex = 2;
            // 
            // comboBoxCheckBit
            // 
            this.comboBoxCheckBit.FormattingEnabled = true;
            this.comboBoxCheckBit.Location = new System.Drawing.Point(55, 115);
            this.comboBoxCheckBit.Name = "comboBoxCheckBit";
            this.comboBoxCheckBit.Size = new System.Drawing.Size(121, 25);
            this.comboBoxCheckBit.TabIndex = 2;
            // 
            // comboBoxDataBit
            // 
            this.comboBoxDataBit.FormattingEnabled = true;
            this.comboBoxDataBit.Location = new System.Drawing.Point(55, 84);
            this.comboBoxDataBit.Name = "comboBoxDataBit";
            this.comboBoxDataBit.Size = new System.Drawing.Size(121, 25);
            this.comboBoxDataBit.TabIndex = 2;
            // 
            // comboBoxBaudRate
            // 
            this.comboBoxBaudRate.FormattingEnabled = true;
            this.comboBoxBaudRate.Location = new System.Drawing.Point(55, 53);
            this.comboBoxBaudRate.Name = "comboBoxBaudRate";
            this.comboBoxBaudRate.Size = new System.Drawing.Size(121, 25);
            this.comboBoxBaudRate.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(149, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "ms";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "超时设置";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "停止位";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "校验位";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "数据位";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "波特率";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "端口";
            // 
            // comboBoxPorts
            // 
            this.comboBoxPorts.FormattingEnabled = true;
            this.comboBoxPorts.Location = new System.Drawing.Point(55, 22);
            this.comboBoxPorts.Name = "comboBoxPorts";
            this.comboBoxPorts.Size = new System.Drawing.Size(121, 25);
            this.comboBoxPorts.TabIndex = 0;
            // 
            // textBoxRecive
            // 
            this.textBoxRecive.Location = new System.Drawing.Point(5, 22);
            this.textBoxRecive.Multiline = true;
            this.textBoxRecive.Name = "textBoxRecive";
            this.textBoxRecive.Size = new System.Drawing.Size(284, 154);
            this.textBoxRecive.TabIndex = 3;
            // 
            // buttonRefreshPortsList
            // 
            this.buttonRefreshPortsList.Location = new System.Drawing.Point(391, 63);
            this.buttonRefreshPortsList.Name = "buttonRefreshPortsList";
            this.buttonRefreshPortsList.Size = new System.Drawing.Size(108, 37);
            this.buttonRefreshPortsList.TabIndex = 4;
            this.buttonRefreshPortsList.Text = "刷新串口列表";
            this.buttonRefreshPortsList.UseVisualStyleBackColor = true;
            this.buttonRefreshPortsList.Click += new System.EventHandler(this.buttonRefreshPortsList_Click);
            // 
            // buttonOpenPorts
            // 
            this.buttonOpenPorts.Location = new System.Drawing.Point(582, 63);
            this.buttonOpenPorts.Name = "buttonOpenPorts";
            this.buttonOpenPorts.Size = new System.Drawing.Size(102, 37);
            this.buttonOpenPorts.TabIndex = 5;
            this.buttonOpenPorts.Text = "打开串口";
            this.buttonOpenPorts.UseVisualStyleBackColor = true;
            this.buttonOpenPorts.Click += new System.EventHandler(this.buttonOpenPorts_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonEmptyRecive);
            this.groupBox2.Controls.Add(this.textBoxRecive);
            this.groupBox2.Location = new System.Drawing.Point(391, 110);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(293, 219);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "接收数据";
            // 
            // buttonEmptyRecive
            // 
            this.buttonEmptyRecive.Location = new System.Drawing.Point(104, 182);
            this.buttonEmptyRecive.Name = "buttonEmptyRecive";
            this.buttonEmptyRecive.Size = new System.Drawing.Size(92, 32);
            this.buttonEmptyRecive.TabIndex = 4;
            this.buttonEmptyRecive.Text = "清空数据";
            this.buttonEmptyRecive.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButtonSendHEX);
            this.groupBox3.Controls.Add(this.radioButtonSendASCII);
            this.groupBox3.Location = new System.Drawing.Point(12, 316);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(188, 75);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "发送设置";
            // 
            // radioButtonSendHEX
            // 
            this.radioButtonSendHEX.AutoSize = true;
            this.radioButtonSendHEX.Location = new System.Drawing.Point(97, 22);
            this.radioButtonSendHEX.Name = "radioButtonSendHEX";
            this.radioButtonSendHEX.Size = new System.Drawing.Size(50, 21);
            this.radioButtonSendHEX.TabIndex = 0;
            this.radioButtonSendHEX.TabStop = true;
            this.radioButtonSendHEX.Text = "HEX";
            this.radioButtonSendHEX.UseVisualStyleBackColor = true;
            // 
            // radioButtonSendASCII
            // 
            this.radioButtonSendASCII.AutoSize = true;
            this.radioButtonSendASCII.Location = new System.Drawing.Point(14, 22);
            this.radioButtonSendASCII.Name = "radioButtonSendASCII";
            this.radioButtonSendASCII.Size = new System.Drawing.Size(57, 21);
            this.radioButtonSendASCII.TabIndex = 0;
            this.radioButtonSendASCII.TabStop = true;
            this.radioButtonSendASCII.Text = "ASCII";
            this.radioButtonSendASCII.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioButtonReciveHEX);
            this.groupBox4.Controls.Add(this.radioButtonReciveASCII);
            this.groupBox4.Location = new System.Drawing.Point(12, 397);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(188, 74);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "接收设置";
            // 
            // radioButtonReciveHEX
            // 
            this.radioButtonReciveHEX.AutoSize = true;
            this.radioButtonReciveHEX.Location = new System.Drawing.Point(97, 29);
            this.radioButtonReciveHEX.Name = "radioButtonReciveHEX";
            this.radioButtonReciveHEX.Size = new System.Drawing.Size(50, 21);
            this.radioButtonReciveHEX.TabIndex = 0;
            this.radioButtonReciveHEX.TabStop = true;
            this.radioButtonReciveHEX.Text = "HEX";
            this.radioButtonReciveHEX.UseVisualStyleBackColor = true;
            // 
            // radioButtonReciveASCII
            // 
            this.radioButtonReciveASCII.AutoSize = true;
            this.radioButtonReciveASCII.Location = new System.Drawing.Point(14, 29);
            this.radioButtonReciveASCII.Name = "radioButtonReciveASCII";
            this.radioButtonReciveASCII.Size = new System.Drawing.Size(57, 21);
            this.radioButtonReciveASCII.TabIndex = 0;
            this.radioButtonReciveASCII.TabStop = true;
            this.radioButtonReciveASCII.Text = "ASCII";
            this.radioButtonReciveASCII.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.buttonSend);
            this.groupBox5.Controls.Add(this.textBoxSend);
            this.groupBox5.Location = new System.Drawing.Point(392, 335);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(292, 146);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "发送数据";
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(103, 104);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(92, 32);
            this.buttonSend.TabIndex = 4;
            this.buttonSend.Text = "发送数据";
            this.buttonSend.UseVisualStyleBackColor = true;
            // 
            // textBoxSend
            // 
            this.textBoxSend.Location = new System.Drawing.Point(6, 21);
            this.textBoxSend.Multiline = true;
            this.textBoxSend.Name = "textBoxSend";
            this.textBoxSend.Size = new System.Drawing.Size(284, 77);
            this.textBoxSend.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 535);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonOpenPorts);
            this.Controls.Add(this.buttonRefreshPortsList);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimeout)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem 文件ToolStripMenuItem;
        private ToolStripMenuItem 保存接收数据ToolStripMenuItem;
        private ToolStripMenuItem 退出ToolStripMenuItem;
        private ToolStripMenuItem 工具ToolStripMenuItem;
        private ToolStripMenuItem 设置ToolStripMenuItem;
        private ToolStripMenuItem 重置串口设置ToolStripMenuItem;
        private ToolStripMenuItem 帮助ToolStripMenuItem;
        private ToolStripMenuItem 关于ToolStripMenuItem;
        private ToolStripMenuItem 作者ToolStripMenuItem;
        private ToolStripMenuItem 贡献者ToolStripMenuItem;
        private ToolStrip toolStrip1;
        private GroupBox groupBox1;
        private ComboBox comboBoxStopBit;
        private ComboBox comboBoxCheckBit;
        private ComboBox comboBoxDataBit;
        private ComboBox comboBoxBaudRate;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox comboBoxPorts;
        private TextBox textBoxRecive;
        private Button buttonRefreshPortsList;
        private Button buttonOpenPorts;
        private GroupBox groupBox2;
        private Button buttonEmptyRecive;
        private GroupBox groupBox3;
        private RadioButton radioButtonSendHEX;
        private RadioButton radioButtonSendASCII;
        private GroupBox groupBox4;
        private RadioButton radioButtonReciveHEX;
        private RadioButton radioButtonReciveASCII;
        private GroupBox groupBox5;
        private Button buttonSend;
        private TextBox textBoxSend;
        private ToolStripButton toolStripButton1;
        private ToolStripLabel toolStripLabel1;
        private NumericUpDown numericUpDownTimeout;
        private Label label7;
        private Label label6;
    }
}