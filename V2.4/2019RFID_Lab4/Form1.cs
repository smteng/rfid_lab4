﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//using System.BitConverter;

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        MW_EasyPOD EasyPOD;

        UInt32 dwResult, Index;
        bool SC, BC, KC = false;  //參數預設

        /// <summary>
        /// 讀取
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        unsafe public void BtnReadData_Click(object sender, EventArgs e)
        {
            string SNum = "-1", BNum = "-1", KType = "-1";  //參數預設
            SNum = Sector.Text;
            BNum = Block.Text;
            if (KeyAB.Text == "A")  //選擇 key A,B
            {
                KType = "60";
            }
            else
            {
                KType = "61";
            }

            string ReadCmd = "020A15";  //讀取commend 0x02, 0x0A, 0x15,
            string TX = ReadCmd + KType + LoadKey.Text + SNum + BNum;         //組成 Read Data Request

            UInt32 uiLength, uiRead, uiResult, uiWritten;
            byte[] ReadBuffer = new byte[0x40];
            //byte[] WriteBuffer = new byte[] { 0x02, 0x0A, 0x15, 0x60, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x02, 0x01 };
            byte[] WriteBuffer = StringToByteArray(TX);
            byte[] sResponse = null;
            sResponse = new byte[21];

            EasyPOD.VID = 0xe6a;
            EasyPOD.PID = 0x317;
            Index = 1;
            uiLength = 64;


            fixed (MW_EasyPOD* pPOD = &EasyPOD)
            {

                dwResult = PODfuncs.ConnectPOD(pPOD, Index);

                if ((dwResult != 0))
                {
                    MessageBox.Show("Not connected yet");
                }
                else
                {
                    EasyPOD.ReadTimeOut = 200;
                    EasyPOD.WriteTimeOut = 200;

                    dwResult = PODfuncs.WriteData(pPOD, WriteBuffer, 12, &uiWritten);    //Send a request command to reader  ,buffer 讀取12個 command 碼
                    uiResult = PODfuncs.ReadData(pPOD, ReadBuffer, uiLength, &uiRead);  //Read the response data from reader

                    tebReadData.Text = BitConverter.ToString(ReadBuffer, 4,(Int32)uiRead - 4).Replace("-", "");  //HEX  從 4 之後開始 讀取 data (Response 欄位 0~4 為 02 12 15 00)
                }
                dwResult = PODfuncs.ClearPODBuffer(pPOD);
                dwResult = PODfuncs.DisconnectPOD(pPOD);

            }
        }
        unsafe public string readData(string SNum, string BNum)
        {
            string retVal = "";
            string KType = "60";  //參數預設

            string ReadCmd = "020A15";  //讀取commend 0x02, 0x0A, 0x15,
            string TX = ReadCmd + KType + LoadKey.Text + SNum + BNum;         //組成 Read Data Request

            UInt32 uiLength, uiRead, uiResult, uiWritten;
            byte[] ReadBuffer = new byte[0x40];
            //byte[] WriteBuffer = new byte[] { 0x02, 0x0A, 0x15, 0x60, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x02, 0x01 };
            byte[] WriteBuffer = StringToByteArray(TX);
            byte[] sResponse = null;
            sResponse = new byte[21];

            EasyPOD.VID = 0xe6a;
            EasyPOD.PID = 0x317;
            Index = 1;
            uiLength = 64;


            fixed (MW_EasyPOD* pPOD = &EasyPOD)
            {

                dwResult = PODfuncs.ConnectPOD(pPOD, Index);

                if ((dwResult != 0))
                {
                    MessageBox.Show("Not connected yet");
                }
                else
                {
                    EasyPOD.ReadTimeOut = 200;
                    EasyPOD.WriteTimeOut = 200;

                    dwResult = PODfuncs.WriteData(pPOD, WriteBuffer, 12, &uiWritten);    //Send a request command to reader  ,buffer 讀取12個 command 碼
                    uiResult = PODfuncs.ReadData(pPOD, ReadBuffer, uiLength, &uiRead);  //Read the response data from reader

                    retVal = BitConverter.ToString(ReadBuffer, 4, (Int32)uiRead - 4).Replace("-", "");  //HEX  從 4 之後開始 讀取 data (Response 欄位 0~4 為 02 12 15 00)
                }
                dwResult = PODfuncs.ClearPODBuffer(pPOD);
                dwResult = PODfuncs.DisconnectPOD(pPOD);

            }
            return System.Text.Encoding.ASCII.GetString(StringToByteArray(retVal));
        }
        /// <summary>
        /// 寫入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        unsafe public void BtnWriteData_Click(object sender, EventArgs e)
        {
            string SNum = "-1", BNum = "-1", KType = "-1";  //參數預設
            SNum = Sector.Text;
            BNum = Block.Text;
            if (KeyAB.Text == "A")  //選擇 key A,B
            {
                KType = "60";
            }
            else
            {
                KType = "61";
            }

            string WriteCmd = "021A16";  //寫入commend 0x02, 0x1A, 0x16,
            string TX = WriteCmd + KType + LoadKey.Text + SNum + BNum + tebWriteData.Text;         //組成 Read Data Request

            UInt32 uiLength, uiRead, uiResult, uiWritten;
            byte[] ReadBuffer = new byte[0x40];
            //byte[] WriteBuffer = new byte[] { 0x02, 0x0A, 0x15, 0x60, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x02, 0x01 };
            byte[] WriteBuffer = StringToByteArray(TX);
            byte[] sResponse = null;
            sResponse = new byte[21];

            EasyPOD.VID = 0xe6a;
            EasyPOD.PID = 0x317;
            Index = 1;
            uiLength = 64;


            fixed (MW_EasyPOD* pPOD = &EasyPOD)
            {

                dwResult = PODfuncs.ConnectPOD(pPOD, Index);

                if ((dwResult != 0))
                {
                    MessageBox.Show("Not connected yet");
                }
                else
                {
                    EasyPOD.ReadTimeOut = 200;
                    EasyPOD.WriteTimeOut = 200;

                    dwResult = PODfuncs.WriteData(pPOD, WriteBuffer, 28, &uiWritten);    //Send a request command to reader  ,buffer 讀取12個 command 碼 + 16 byte data，所以讀28個
                    uiResult = PODfuncs.ReadData(pPOD, ReadBuffer, uiLength, &uiRead);  //Read the response data from reader

                    tebReadData.Text = BitConverter.ToString(ReadBuffer, 4, (Int32)uiRead - 4).Replace("-", "");  //HEX  從 4 之後開始 寫入 data (Response 欄位 0~4 為 02 12 16 00 ，這四個之後才是data)
                }
                dwResult = PODfuncs.ClearPODBuffer(pPOD);
                dwResult = PODfuncs.DisconnectPOD(pPOD);

            }
        }
        unsafe public void writeData(string SNum, string BNum, string inputString)
        {
            string KType = "60";  //參數預設

            string WriteCmd = "021A16";  //寫入commend 0x02, 0x1A, 0x16,

            string str2 = inputString;
            byte[] array = System.Text.Encoding.ASCII.GetBytes(str2);
            string ASCIIstr2 = null;
            for (int i = 0; i < array.Length; i++)
            {
                int asciicode = (int)(array[i]);
                ASCIIstr2 += Convert.ToString(asciicode.ToString("X"));
            }
            inputString = ASCIIstr2;

            int initLen = 0;
            try
            {
                initLen = inputString.Length;
            } catch
            {

            }

            System.Diagnostics.Debug.WriteLine("ASCII =" + inputString);
            System.Diagnostics.Debug.WriteLine("1 len=" + inputString.Length);
            if (inputString.Length < 32)
            {
                for (int i = 0; i < (32 - initLen); i++){
                    inputString = inputString + "0";
                }
            }
            System.Diagnostics.Debug.WriteLine("2 len="+ inputString.Length);


            string TX = WriteCmd + KType + LoadKey.Text + SNum + BNum + inputString;         //組成 Read Data Request

            UInt32 uiLength, uiRead, uiResult, uiWritten;
            byte[] ReadBuffer = new byte[0x40];
            //byte[] WriteBuffer = new byte[] { 0x02, 0x0A, 0x15, 0x60, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x02, 0x01 };
            byte[] WriteBuffer = StringToByteArray(TX);
            byte[] sResponse = null;
            sResponse = new byte[21];

            EasyPOD.VID = 0xe6a;
            EasyPOD.PID = 0x317;
            Index = 1;
            uiLength = 64;

            fixed (MW_EasyPOD* pPOD = &EasyPOD)
            {

                dwResult = PODfuncs.ConnectPOD(pPOD, Index);

                if ((dwResult != 0))
                {
                    MessageBox.Show("Not connected yet");
                }
                else
                {
                    EasyPOD.ReadTimeOut = 200;
                    EasyPOD.WriteTimeOut = 200;

                    dwResult = PODfuncs.WriteData(pPOD, WriteBuffer, 28, &uiWritten);    //Send a request command to reader  ,buffer 讀取12個 command 碼 + 16 byte data，所以讀28個
                    uiResult = PODfuncs.ReadData(pPOD, ReadBuffer, uiLength, &uiRead);  //Read the response data from reader

                    tebReadData.Text = BitConverter.ToString(ReadBuffer, 4, (Int32)uiRead - 4).Replace("-", "");  //HEX  從 4 之後開始 寫入 data (Response 欄位 0~4 為 02 12 16 00 ，這四個之後才是data)
                }
                dwResult = PODfuncs.ClearPODBuffer(pPOD);
                dwResult = PODfuncs.DisconnectPOD(pPOD);

            }
        }

        /// <summary>
        /// StringToByteArray 字串轉型
        /// </summary>
        /// <param name="hex"></param>
        /// <returns></returns>
        public static byte[] StringToByteArray(String hex)
         {
            int NumberChars = hex.Length;
            byte[] bytes = new byte[NumberChars / 2];
            for (int i = 0; i < NumberChars; i += 2)
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            return bytes;
        }

        /// <summary>
        /// 頁面初始(下拉選單參數等)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {

            for (int i = 0; i < 16; i++)
            {
                Sector.Items.Add(i.ToString("00"));
            }

            for (int j = 0; j < 4; j++)
            {
                Block.Items.Add(j.ToString("00"));
            }

            KeyAB.Items.Add("A");
            KeyAB.Items.Add("B");

            BtnReadData.Enabled = false;
            BtnWriteData.Enabled = false;
        }


        /// <summary>
        /// Sector 防呆
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Sector_SelectedIndexChanged(object sender, EventArgs e)
        {
            tebReadData.Text = "";
            BtnReadData.Enabled = false;
            SC = true;
            if (SC == true && BC == true && KC == true)
            {
                if (LoadKey.TextLength == 12)
                {
                    BtnReadData.Enabled = true;
                }
            }
        }

        /// <summary>
        /// Block 防呆
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Block_SelectedIndexChanged(object sender, EventArgs e)
        {
            tebReadData.Text = "";
            BtnReadData.Enabled = false;
            BC = true;
            if (SC == true && BC == true && KC == true)
            {
                if (LoadKey.TextLength == 12)
                {
                    BtnReadData.Enabled = true;
                }
            }
        }

        /// <summary>
        /// 寫入防呆
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tebWriteData_TextChanged(object sender, EventArgs e)
        {
            BtnWriteData.Enabled = false;
            if (tebWriteData.TextLength == 32)
            {
                BtnWriteData.Enabled = true;
            }

        }

        private void but_SignCard_Click(object sender, EventArgs e)
        {
            string id ;
            string name ;
            string signdate ;
            string point = "";

            id = textBox_MemID.Text;
            name = textBox_MemName.Text;
            signdate = textBox_SignDay.Text;
            point = textBox_Point.Text;

            System.Diagnostics.Debug.WriteLine(id);
            writeData("01", "00", id);

            System.Diagnostics.Debug.WriteLine(name);
            writeData("01", "01", name);

            System.Diagnostics.Debug.WriteLine(signdate);
            writeData("01", "02", signdate);

            System.Diagnostics.Debug.WriteLine(point);

        }

        private void textBox_MemID_TextChanged(object sender, EventArgs e)
        {

        }

        private void tebReadData_TextChanged(object sender, EventArgs e)
        {

        }

        private void but_ReadCard_Click(object sender, EventArgs e)
        {
            textBox_MemID2.Text = readData("01","00");
            textBox_MemName2.Text = readData("01", "01");
            textBox_SignDay2.Text = readData("01", "02");
            textBox_Point2.Text = readData("01", "03");


        }

        private void textBox_MemID2_TextChanged(object sender, EventArgs e)
        {

        }

        private void but_CleanCard_Click(object sender, EventArgs e)
        {
            string id = "0";
            string name = "0";
            string signdate = "0";
            string point = "0";

            System.Diagnostics.Debug.WriteLine(id);
            writeData("01", "00", id);

            System.Diagnostics.Debug.WriteLine(name);
            writeData("01", "01", name);

            System.Diagnostics.Debug.WriteLine(signdate);
            writeData("01", "02", signdate);

            System.Diagnostics.Debug.WriteLine(point);
        }

        /// <summary>
        /// KeyAB 防呆
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KeyAB_SelectedIndexChanged(object sender, EventArgs e)
        {
            tebReadData.Text = "";
            BtnReadData.Enabled = false;
            KC = true;
            if (SC == true && BC == true && KC == true)
            {
                if (LoadKey.TextLength == 12)
                {
                    BtnReadData.Enabled = true;
                }
            }
        }

        /// <summary>
        /// LoadKey防呆
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadKey_TextChanged(object sender, EventArgs e)
        {
            BtnReadData.Enabled = false;
            if (SC == true && BC == true && KC == true)
            {
                if (LoadKey.TextLength == 12)
                {
                    BtnReadData.Enabled = true;
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

    }

}
