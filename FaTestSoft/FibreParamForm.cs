﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FaTestSoft.CommonData;
using FaTestSoft.FUNCTIONCLASS;

namespace FaTestSoft
{
    public partial class FibreParamForm : Form
    {
        public FibreParamForm()
        {
            InitializeComponent();
        }
        string mac1 = @"", mac2 = @"", mac3 = @"", mac4 = @"", mac5 = @"", mac6 = @"";
        /********************************************************************************************
        *  函数名：    FibreParamForm_Load                                                          *
        *  功能  ：    初始化函数处理                                                               *
        *  参数  ：    无                                                                           *
        *  返回值：    无                                                                           *
        *  修改日期：  2010-11-09                                                                   *
        *  作者    ：  cuibj                                                                        *
        * ******************************************************************************************/
        private void FibreParamForm_Load(object sender, EventArgs e)
        {
            
            comboNetIndex.SelectedIndex = 0;

            SetInitParam();
            

        }
        private void SetInitParam()
        {
            string text = @"";
            userControl11.SetIpAddress(PublicDataClass._NetParam.IP);
            userControl12.SetIpAddress(PublicDataClass._NetParam.GwIP);
            userControl13.SetIpAddress(PublicDataClass._NetParam.SubMask);
            textBoxPort.Text = PublicDataClass._NetParam.Port;
            text = PublicDataClass._NetParam.SrcHA;



            for (byte i = 0; i < 6; i++)
            {
                if (i == 0)
                {
                    textBoxMac1.Text = text.Substring(0, 2);
                    text = text.Remove(0, 3);
                }
                else if (i == 1)
                {
                    textBoxMac2.Text = text.Substring(0, 2);
                    text = text.Remove(0, 3);
                }
                else if (i == 2)
                {
                    textBoxMac3.Text = text.Substring(0, 2);
                    text = text.Remove(0, 3);
                }
                else if (i == 3)
                {
                    textBoxMac4.Text = text.Substring(0, 2);
                    text = text.Remove(0, 3);
                }
                else if (i == 4)
                {
                    textBoxMac5.Text = text.Substring(0, 2);
                    text = text.Remove(0, 3);
                }
                else
                    textBoxMac6.Text = text.Substring(0, 2);


            }
            mac1 = textBoxMac1.Text;
            mac2 = textBoxMac2.Text;
            mac3 = textBoxMac3.Text;
            mac4 = textBoxMac4.Text;
            mac5 = textBoxMac5.Text;
            mac6 = textBoxMac6.Text;


        }
        private void userControl11_TextChanged(object sender, EventArgs e)
        {
            PublicDataClass._NetParam.IP = userControl11.GetIpAddress();
        }

        private void userControl12_TextChanged(object sender, EventArgs e)
        {
            PublicDataClass._NetParam.GwIP = userControl12.GetIpAddress();
        }

        private void userControl13_TextChanged(object sender, EventArgs e)
        {
            PublicDataClass._NetParam.SubMask = userControl13.GetIpAddress();
        }

        private void textBoxPort_TextChanged(object sender, EventArgs e)
        {
            PublicDataClass._NetParam.Port = textBoxPort.Text;
        }

        private void textBoxMac1_TextChanged(object sender, EventArgs e)
        {
            mac1 = textBoxMac1.Text;
            PublicDataClass._NetParam.SrcHA = mac1 + "-" + mac2 + "-" + mac3 + "-" + mac4 + "-" + mac5 + "-" + mac6;
        }

        private void textBoxMac2_TextChanged(object sender, EventArgs e)
        {
            mac2 = textBoxMac2.Text;
            PublicDataClass._NetParam.SrcHA = mac1 + "-" + mac2 + "-" + mac3 + "-" + mac4 + "-" + mac5 + "-" + mac6;
        }

        private void textBoxMac3_TextChanged(object sender, EventArgs e)
        {
            mac3 = textBoxMac3.Text;
            PublicDataClass._NetParam.SrcHA = mac1 + "-" + mac2 + "-" + mac3 + "-" + mac4 + "-" + mac5 + "-" + mac6;
        }

        private void textBoxMac4_TextChanged(object sender, EventArgs e)
        {
            mac4 = textBoxMac4.Text;
            PublicDataClass._NetParam.SrcHA = mac1 + "-" + mac2 + "-" + mac3 + "-" + mac4 + "-" + mac5 + "-" + mac6;
        }

        private void textBoxMac5_TextChanged(object sender, EventArgs e)
        {
            mac5 = textBoxMac5.Text;
            PublicDataClass._NetParam.SrcHA = mac1 + "-" + mac2 + "-" + mac3 + "-" + mac4 + "-" + mac5 + "-" + mac6;
        }

        private void textBoxMac6_TextChanged(object sender, EventArgs e)
        {
            mac6 = textBoxMac6.Text;
            PublicDataClass._NetParam.SrcHA = mac1 + "-" + mac2 + "-" + mac3 + "-" + mac4 + "-" + mac5 + "-" + mac6;
        }

        private void comboNetIndex_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboNetIndex.SelectedIndex == 0) //汉南以外
            {
                PublicDataClass.NetIndex = 0;

            }
            if (comboNetIndex.SelectedIndex == 1)
            {
                PublicDataClass.NetIndex = 1;

            }
            //if (comboNetIndex.SelectedIndex == 0)   //汉南
            //{
            //    PublicDataClass.NetIndex = 1;

            //}
            //if (comboNetIndex.SelectedIndex == 1)
            //{
            //    PublicDataClass.NetIndex = 0;

            //}
        }

        private void FibreParamForm_VisibleChanged(object sender, EventArgs e)
        {
            string FileName = "";
            //string path  =Application.ExecutablePath;
            string path = System.AppDomain.CurrentDomain.BaseDirectory;

            //string path = System.IO.Directory.GetCurrentDirectory();
            //string path = System.Environment.CurrentDirectory;
            path += "ini";
            FileName = path + "\\netparam.ini";
            //WriteReadAllFile.WriteReadSysIniFile(FileName, 0, 0);
            SetInitParam();
        }
    }
}
