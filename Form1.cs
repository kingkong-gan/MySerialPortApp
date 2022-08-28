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

        //��ʼ������ؼ�
        public void Init_Ports_Config_Controller()
        {
            //�������ڣ����ö˿������б�
            Refresh_Ports_List();
            //���ò����������б�
            comboBoxBaudRate.Items.AddRange(new string[] { "9600", "19200", "38400", "57600", "115200" });
            comboBoxBaudRate.SelectedIndex = 0;
            //��������λ�����б�
            comboBoxDataBit.Items.AddRange(new string[] { "5", "6", "7", "8" });
            comboBoxDataBit.SelectedIndex = 3;
            //����У��λ�����б�
            comboBoxCheckBit.Items.AddRange(new string[] { "None", "Odd", "Even", "Mark", "Space" });
            comboBoxCheckBit.SelectedIndex = 0;
            //����ֹͣλ�����б�
            comboBoxStopBit.Items.AddRange(new string[] { "1.0", "1.5", "2.0" });
            comboBoxStopBit.SelectedIndex = 0;
            //�������ã����ݸ�ʽ
            radioButtonSendASCII.Checked = true;
            //�������ã����ݸ�ʽ
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
                foreach (var letter in revTxtCharArray)
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
                MessageBox.Show("δ�����д��ڣ�");
                return;
            }
            comboBoxPorts.Items.AddRange(portNames);
            comboBoxPorts.SelectedIndex = 0;
        }

        private void buttonOpenPorts_Click(object sender, EventArgs e)
        {
            if (!serialPort.IsOpen)
            {
                try
                {
                    if (comboBoxPorts.SelectedIndex == -1)
                    {
                        MessageBox.Show("��ѡ�˿���Ч��");
                        return;
                    }
                    //���ô�����������λ��������
                    serialPort.PortName = comboBoxPorts.SelectedItem.ToString();
                    serialPort.DataBits = (int)comboBoxDataBit.SelectedItem;
                    serialPort.BaudRate = (int)comboBoxBaudRate.SelectedItem;

                    //����ֹͣλ"1","1.5","2"
                    switch (comboBoxStopBit.SelectedItem.ToString())
                    {
                        case "1": serialPort.StopBits = StopBits.One; break;
                        case "1.5": serialPort.StopBits = StopBits.OnePointFive; break;
                        case "2": serialPort.StopBits = StopBits.Two; break;
                        default: MessageBox.Show(String.Format("ֹͣλ������{0}  ������Ч������"), comboBoxStopBit.SelectedItem.ToString()); break;
                    }
                    //����У��λ"None", "Odd", "Even", "Mark", "Space" 
                    switch (comboBoxCheckBit.SelectedIndex.ToString())
                    {
                        case "None": serialPort.Parity = Parity.None; break;
                        case "Odd": serialPort.Parity = Parity.Odd; break;
                        case "Even": serialPort.Parity = Parity.Even; break;
                        case "Mark": serialPort.Parity = Parity.Mark; break;
                        case "Space": serialPort.Parity = Parity.Space; break;
                        default: MessageBox.Show(String.Format("У��λ������{0} ������Ч������"), comboBoxCheckBit.SelectedIndex.ToString()); break;
                    }

                    //�������ں��޷����޸Ĳ���
                    serialPort.Open();
                    comboBoxBaudRate.Enabled = false;
                    comboBoxCheckBit.Enabled = false;
                    comboBoxDataBit.Enabled = false;
                    comboBoxPorts.Enabled = false;
                    comboBoxStopBit.Enabled = false;
                    radioButtonReciveASCII.Enabled = false;
                    radioButtonReciveHEX.Enabled = false;
                    buttonSend.Enabled = true;

                    //����֮���޸İ�ť�ı�
                    buttonOpenPorts.Text = "�رմ���";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("�򿪴��ڳ���" + ex.Message, "Error");
                }

            }

            else
            {
                //�رմ���
                serialPort.Close();
                comboBoxBaudRate.Enabled = true;
                comboBoxCheckBit.Enabled = true;
                comboBoxDataBit.Enabled = true;
                comboBoxPorts.Enabled = true;
                comboBoxStopBit.Enabled = true;

                //�޸İ�ť�ı�
                buttonOpenPorts.Text = "�򿪴���";

                radioButtonReciveASCII.Enabled = true;
                radioButtonReciveHEX.Enabled = true;
                buttonSend.Enabled = false;
            }
        }
    }
}