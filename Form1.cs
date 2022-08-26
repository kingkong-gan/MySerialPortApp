using System.IO.Ports;

namespace MySerialPortApp
{
    public partial class Form1 : Form
    {
        SerialPort serialPort = new SerialPort();


        public Form1()
        {
            InitializeComponent();
        }

        //初始化窗体控件
        public void Init_Ports_Config_Controller()
        {
            //搜索串口，设置端口下拉列表
            Refresh_Ports_List();
            //设置波特率下拉列表
            comboBoxBaudRate.Items.AddRange(new string[] { "9600", "19200", "38400", "57600", "115200" });
            comboBoxBaudRate.SelectedIndex = 0;
            //设置数据位下拉列表
            comboBoxDataBit.Items.AddRange(new string[] { "5", "6", "7", "8" });
            comboBoxDataBit.SelectedIndex = 3;
            //设置校验位下拉列表
            comboBoxCheckBit.Items.AddRange(new string[] { "None", "Odd", "Even", "Mark", "Space" });
            comboBoxCheckBit.SelectedIndex = 0;
            //设置停止位下拉列表
            comboBoxStopBit.Items.AddRange(new string[] { "1.0", "1.5", "2.0" });
            comboBoxStopBit.SelectedIndex = 0;
            //发送设置，数据格式
            radioButtonSendASCII.Checked = true;
            //接收设置，数据格式
            radioButtonReciveASCII.Checked = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Init_Ports_Config_Controller();
            serialPort.DataReceived += SerialPort_DataReceived;
            serialPort.DtrEnable = true;
            serialPort.RtsEnable = true;
            serialPort.Close();
            buttonSend.Enabled = false;
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string revTxt = serialPort.ReadLine();
            if (radioButtonReciveASCII.Checked == true)
            {
                textBoxRecive.Text += (textBoxRecive.Text == "" ? "" : "\r\n") + revTxt;
            }
            if (radioButtonReciveHEX.Checked == true)
            {
                textBoxRecive.Text += textBoxRecive.Text == "" ? "" : "\r\n";
                char[] revTxtCharArray = revTxt.ToCharArray();
                foreach(var letter in revTxtCharArray)
                {
                    textBoxRecive.Text += Convert.ToInt32(letter) + " ";
                }
            }
        }

        private void buttonRefreshPortsList_Click(object sender, EventArgs e)
        {
            Refresh_Ports_List();
        }

        private void Refresh_Ports_List()
        {
            string[] portNames = SerialPort.GetPortNames();
            if (portNames == null || portNames.Length == 0)
            {
                MessageBox.Show("未发现有串口！");
                return;
            }
            comboBoxPorts.Items.AddRange(portNames);
            comboBoxPorts.SelectedIndex = 0;
        }

        private void buttonOpenPorts_Click(object sender, EventArgs e)
        {
            if (!serialPort.IsOpen)
            {
                if(comboBoxPorts.SelectedIndex == -1)
                {
                    MessageBox.Show("所选端口无效！");
                    return;
                }
                //设置串口名，数据位，波特率
                serialPort.PortName = comboBoxPorts.SelectedItem.ToString();
                serialPort.DataBits = (int)comboBoxDataBit.SelectedItem;
                serialPort.BaudRate = (int)comboBoxBaudRate.SelectedItem;

                //设置停止位
                switch (comboBoxStopBit.SelectedItem.ToString())
                {
                    case "1":serialPort.StopBits=StopBits.One; break;
                    case "1.5":serialPort.StopBits = StopBits.OnePointFive;break;
                    case "2":serialPort.StopBits = StopBits.Two;break;
                        default:MessageBox.Show("");break;
                }


            }
        }
    }
}