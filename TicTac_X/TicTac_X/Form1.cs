using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTac_X
{
    public partial class Form1 : Form
    {
        #region prop & arrays
        
        public int[,] TicTac = new int[3, 3];
        string result;
        bool flag = false;
        public int score_X_Count = 0 , score_O_Count = 0;
        string PathX = @"C:\Users\Osama Al-Rashed\source\repos\TicTac_O\TicTac_O\Images\X.png";
        string PathO = @"C:\Users\Osama Al-Rashed\source\repos\TicTac_O\TicTac_O\Images\O.png";
        string PathW = @"C:\Users\Osama Al-Rashed\source\repos\TicTac_O\TicTac_O\Images\White.png";


        #endregion

        #region Methods

        // 0 ما خلصنا
        // 1 ربح
        // 2 تعادل
        private int Result(int i, int j)
        {
            //قطر رئيسي
            if (TicTac[0, 0] == 1 && TicTac[1, 1] == 1 && TicTac[2, 2] == 1)
            {
                return 1;
            }

            //قطر ثانوي
            else if (TicTac[2, 0] == 1 && TicTac[1, 1] == 1 && TicTac[0, 2] == 1)
            {
                return 1;
            }

            //سطر أو عمود
            else if (TicTac[0, j] == 1 && TicTac[1, j] == 1 && TicTac[2, j] == 1)
            {
                return 1;
            }
            else if (TicTac[i, 0] == 1 && TicTac[i, 1] == 1 && TicTac[i, 2] == 1)
            {
                return 1;
            }

            //تعادل
            for (int ind = 0; ind < 3; ind++)
            {
                for (int indy = 0; indy < 3; indy++)
                {
                    if (TicTac[ind, indy] == 0)
                    {
                        return 0;
                    }
                }
            }
            Label_Result.Text = "Draw";
            Label_Result.ForeColor = Color.Orange;
            return 2;
        }

        private void Send(string move)
        {
            if (serialPort_X.IsOpen)
            {
                serialPort_X.WriteLine(move);
            }
        }

        private async void Reset()
        {
            await UseDelay();
            flag = false;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    TicTac[i, j] = 0;
                }
            }
            TicTac1_1.ImageLocation = PathW;
            TicTac1_2.ImageLocation = PathW;
            TicTac1_3.ImageLocation = PathW;
            TicTac2_1.ImageLocation = PathW;
            TicTac2_2.ImageLocation = PathW;
            TicTac2_3.ImageLocation = PathW;
            TicTac3_1.ImageLocation = PathW;
            TicTac3_2.ImageLocation = PathW;
            TicTac3_3.ImageLocation = PathW;

            TicTac1_1.Enabled = true;
            TicTac1_2.Enabled = true;
            TicTac1_3.Enabled = true;
            TicTac2_1.Enabled = true;
            TicTac2_2.Enabled = true;
            TicTac2_3.Enabled = true;
            TicTac3_1.Enabled = true;
            TicTac3_2.Enabled = true;
            TicTac3_3.Enabled = true;

            Label_Result.Text = "       ";
        }

        private void serialPort_X_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            flag = false; //دور X
            result = serialPort_X.ReadLine();
            switch (result)
            {
                case "0000":
                    TicTac[0, 0] = 2;
                    TicTac1_1.ImageLocation = PathO;
                    TicTac1_1.Enabled = false;
                    break;
                case "0001":
                    TicTac[0, 1] = 2;
                    TicTac1_2.ImageLocation = PathO;
                    TicTac1_2.Enabled = false;
                    break;
                case "0010":
                    TicTac[0, 2] = 2;
                    TicTac1_3.ImageLocation = PathO;
                    TicTac1_3.Enabled = false;
                    break;
                case "0011":
                    TicTac[1, 0] = 2;
                    TicTac2_1.ImageLocation = PathO;
                    TicTac2_1.Enabled = false;
                    break;
                case "0100":
                    TicTac[1, 1] = 2;
                    TicTac2_2.ImageLocation = PathO;
                    TicTac2_2.Enabled = false;
                    break;
                case "0101":
                    TicTac[1, 2] = 2;
                    TicTac2_3.ImageLocation = PathO;
                    TicTac2_3.Enabled = false;
                    break;
                case "0110":
                    TicTac[2, 0] = 2;
                    TicTac3_1.ImageLocation = PathO;
                    TicTac3_1.Enabled = false;
                    break;
                case "0111":
                    TicTac[2, 1] = 2;
                    TicTac3_2.ImageLocation = PathO;
                    TicTac3_2.Enabled = false;
                    break;
                case "1000":
                    TicTac3_3.ImageLocation = PathO;
                    TicTac3_3.Enabled = false;
                    TicTac[2, 2] = 2;
                    break;
                case "1111":
                    score_O_Count++;
                    Score_O.Text = score_O_Count.ToString();
                    Label_Result.Text = "You Lost";
                    Label_Result.ForeColor = Color.Red;
                    Reset();
                    break;
            }
        }

        async Task UseDelay()
        {

            await Task.Delay(2000);
        }

        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        #region Grid
        private void TicTac1_1_Click(object sender, EventArgs e)
        {
            if (!flag)
            {
                TicTac1_1.ImageLocation = PathX;
                TicTac1_1.Enabled = false;
                TicTac[0, 0] = 1;
                flag = true;
                Send("0000");
                if(Result(0, 0) == 1)
                {
                    Reset();
                    score_X_Count++;
                    Score_X.Text = score_X_Count.ToString();
                    Send("1111");
                    Label_Result.Text = "You Win";
                    Label_Result.ForeColor = Color.Green;
                }
                else if (Result(0, 0) == 2)
                {
                    Reset();
                    Send("1110");
                }
            }
        }

        private void TicTac1_2_Click(object sender, EventArgs e)
        {
            if (!flag)
            {
                TicTac[0, 1] = 1;
                TicTac1_2.ImageLocation = PathX;
                flag = true;
                TicTac[0, 1] = 1;
                Send("0001");
                if (Result(0, 1) == 1)
                {
                    Reset();
                    score_X_Count++;
                    Score_X.Text = score_X_Count.ToString();
                    Send("1111");
                    Label_Result.Text = "You Win";
                    Label_Result.ForeColor = Color.Green;
                }
                else if (Result(0, 1) == 2)
                {
                    Reset();
                    Send("1110");
                }
            }
        }

        private void TicTac1_3_Click(object sender, EventArgs e)
        {
            if (!flag)
            {
                TicTac1_3.ImageLocation = PathX;
                TicTac1_3.Enabled = false;
                TicTac[0, 2] = 1;
                flag = true;
                Send("0010");
                if (Result(0, 2) == 1)
                {
                    Reset();
                    score_X_Count++;
                    Score_X.Text = score_X_Count.ToString();
                    Send("1111");
                    Label_Result.Text = "You Win";
                    Label_Result.ForeColor = Color.Green;
                }
                else if (Result(0, 2) == 2)
                {
                    Reset();
                    Send("1110");
                }
            }
        }

        private void TicTac2_1_Click(object sender, EventArgs e)
        {
            if (!flag)
            {
                TicTac2_1.ImageLocation = PathX;
                TicTac2_1.Enabled = false;
                TicTac[1, 0] = 1;
                flag = true;
                Send("0011");
                if (Result(1, 0) == 1)
                {
                    Reset();
                    score_X_Count++;
                    Score_X.Text = score_X_Count.ToString();
                    Send("1111");
                    Label_Result.Text = "You Win";
                    Label_Result.ForeColor = Color.Green;
                }
                else if (Result(1, 0) == 2)
                {
                    Reset();
                    Send("1110");
                }
            }
        }

        private void TicTac2_2_Click(object sender, EventArgs e)
        {
            if (!flag)
            {
                TicTac2_2.ImageLocation = PathX;
                TicTac2_2.Enabled = false;
                TicTac[1, 1] = 1;
                flag = true;
                Send("0100");
                if (Result(1, 1) == 1)
                {
                    Reset();
                    score_X_Count++;
                    Score_X.Text = score_X_Count.ToString();
                    Send("1111");
                    Label_Result.Text = "You Win";
                    Label_Result.ForeColor = Color.Green;
                }
                else if (Result(1, 1) == 2)
                {
                    Reset();
                    Send("1110");
                }
            }
        }

        private void TicTac2_3_Click(object sender, EventArgs e)
        {
            if (!flag)
            {
                TicTac2_3.ImageLocation = PathX;
                TicTac2_3.Enabled = false;
                TicTac[1, 2] = 1;
                flag = true;
                Send("0101");
                if (Result(1, 2) == 1)
                {
                    Reset();
                    score_X_Count++;
                    Score_X.Text = score_X_Count.ToString();
                    Send("1111");
                    Label_Result.Text = "You Win";
                    Label_Result.ForeColor = Color.Green;
                }
                else if (Result(1, 2) == 2)
                {
                    Reset();
                    Send("1110");
                }
            }
        }

        private void TicTac3_1_Click(object sender, EventArgs e)
        {
            if (!flag)
            {
                TicTac3_1.ImageLocation = PathX;
                TicTac3_1.Enabled = false;
                TicTac[2, 0] = 1;
                flag = true;
                Send("0110");
                if (Result(2, 0) == 1)
                {
                    Reset();
                    score_X_Count++;
                    Score_X.Text = score_X_Count.ToString();
                    Send("1111");
                    Label_Result.Text = "You Win";
                    Label_Result.ForeColor = Color.Green;
                }
                else if (Result(2, 0) == 2)
                {
                    Reset();
                    Send("1110");
                }
            }
        }

        private void TicTac3_2_Click(object sender, EventArgs e)
        {
            if (!flag)
            {
                TicTac3_2.ImageLocation = PathX;
                TicTac3_2.Enabled = false;
                TicTac[2, 1] = 1;
                flag = true;
                Send("0111");
                if (Result(2, 1) == 1)
                {
                    Reset();
                    score_X_Count++;
                    Score_X.Text = score_X_Count.ToString();
                    Send("1111");
                    Label_Result.Text = "You Win";
                    Label_Result.ForeColor = Color.Green;
                }
                else if (Result(2, 1) == 2)
                {
                    Reset();
                    Send("1110");
                }

            }
        }

        private void TicTac3_3_Click(object sender, EventArgs e)
        {
            if (!flag)
            {
                TicTac3_3.ImageLocation = PathX;
                TicTac3_3.Enabled = false;
                TicTac[2, 2] = 1;
                flag = true;
                Send("1000");
                if (Result(2, 2) == 1)
                {
                    Reset();
                    score_X_Count++;
                    Score_X.Text = score_X_Count.ToString();
                    Send("1111");
                    Label_Result.Text = "You Win";
                    Label_Result.ForeColor = Color.Green;
                }
                else if (Result(2, 2) == 2)
                {
                    Reset();
                    Send("1110");
                }
            }
        }

        #endregion Grid

        #region Port Setting
        private void Default_Setting_Click(object sender, EventArgs e)
        {
            serialPort_X.PortName = "COM1";
            serialPort_X.DataBits = 5;
            serialPort_X.BaudRate = 9600;
            serialPort_X.StopBits = System.IO.Ports.StopBits.One;
            serialPort_X.Parity = System.IO.Ports.Parity.None;
            comboPortName.Text = "Com1";
            comboDataBit.Text = "8";
            comboBaudRate.Text = "9600";
            comboStopBox.Text = "One";
            comboParity.Text = "None";
        }
        private void Start_Click(object sender, EventArgs e)
        {
            int temp = 0;
            string str;
            if (serialPort_X.IsOpen == false)
            {
                serialPort_X.PortName = (comboPortName.SelectedItem).ToString();
                temp = Convert.ToInt32(comboDataBit.SelectedItem);
                switch (temp)
                {
                    case 5:
                        serialPort_X.DataBits = 5;
                        break;
                    case 6:
                        serialPort_X.DataBits = 6;
                        break;
                    case 7:
                        serialPort_X.DataBits = 7;
                        break;
                    case 8:
                        serialPort_X.DataBits = 8;
                        break;
                    default:
                        break;
                }

                temp = Convert.ToInt32(comboBaudRate.SelectedItem);
                switch (temp)
                {
                    case 9600:
                        serialPort_X.BaudRate = 9600;
                        break;
                    case 1155:
                        serialPort_X.BaudRate = 1155;
                        break;
                    case 4800:
                        serialPort_X.BaudRate = 4800;
                        break;
                    case 19200:
                        serialPort_X.BaudRate = 19200;
                        break;
                    default:
                        break;
                }

                str = "";
                str = comboStopBox.SelectedItem.ToString().ToLower();
                if (str == "one")
                    serialPort_X.StopBits = System.IO.Ports.StopBits.One;
                else
                    if (str == "two")
                    serialPort_X.StopBits = System.IO.Ports.StopBits.Two;
                else
                        if (str == "onefivepoint")
                    serialPort_X.StopBits = System.IO.Ports.StopBits.OnePointFive;


                str = comboParity.SelectedItem.ToString().ToLower();
                if (str == "none")
                    serialPort_X.Parity = System.IO.Ports.Parity.None;
                else
                    if (str == "even")
                    serialPort_X.Parity = System.IO.Ports.Parity.Even;
                else
                        if (str == "odd")
                    serialPort_X.Parity = System.IO.Ports.Parity.Odd;
                else
                            if (str == "mark")
                    serialPort_X.Parity = System.IO.Ports.Parity.Mark;
                else
                                if (str == "space")
                    serialPort_X.Parity = System.IO.Ports.Parity.Space;

                try
                { serialPort_X.Open(); }
                catch
                {

                }

            }
        }
        private void Finish_Click(object sender, EventArgs e)
        {
            if (serialPort_X.IsOpen)
                serialPort_X.Close();
        }

        private void Score_O_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // port name Value
            String[] port;
            port = System.IO.Ports.SerialPort.GetPortNames();
            comboPortName.Items.Clear();
            for (int i = 0; i < port.Length; i++)
                comboPortName.Items.Add(port[i]);
            comboPortName.SelectedIndex = 0;
            // dataBits Value
            comboDataBit.SelectedIndex = 3;
            //Buad rate value
            comboBaudRate.SelectedIndex = 0;
            // stop bit Value
            comboStopBox.SelectedIndex = 0;
            // parity Value
            comboParity.SelectedIndex = 0;
            Score_X.Text = "0";
            Score_O.Text = "0";

        }
        #endregion




    }
}
