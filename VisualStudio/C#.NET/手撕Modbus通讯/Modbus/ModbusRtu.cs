﻿using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Modbus
{
    public class ModbusRtu
    {
        #region Filed
        //创建串口对象
        private SerialPort MyCom;
        #endregion

        #region Property
        public int RcvTimeOut { get; set; } = 2000;
        #endregion

        #region Methods
        /// <summary>
        /// 连接串口方法
        /// </summary>
        /// <param name="iPortName"></param>端口名称
        /// <param name="iBaudRate"></param>波特率
        /// <param name="iParity"></param>检验位，枚举类型
        /// <param name="IDataBits"></param>数据位
        /// <param name="istopBits"></param>枚举类型
        public void Connect(string iPortName, int iBaudRate, Parity iParity, int IDataBits, StopBits istopBits)
        {
            //实例化串口对象
            MyCom = new SerialPort(iPortName, iBaudRate, iParity, IDataBits, istopBits);

            //MyCom.DataReceived += MyCom_DataReceived;

            if (MyCom.IsOpen)
            {
                MyCom.Close();
            }
            MyCom.Open();
        }

        //private void MyCom_DataReceived(object sender, SerialDataReceivedEventArgs e)
        //{
            
        //}

        public void DisConnect()
        {
            if (MyCom.IsOpen)
            {
                MyCom.Close();
            }
        }
        /// <summary>
        /// 数据通讯
        /// </summary>
        /// <param name="iDevAdd"></param>
        /// <param name="iAddress"></param>从站地址
        /// <param name="iLength"></param>数据长度
        /// <returns></returns>
        public byte[] ReadOutputState(byte iDevAdd, ushort iAddress, ushort iLength)
        {
            //拼接报文
            
            List<byte> SendCommand = new List<byte>();
            
            SendCommand.Add(iDevAdd); //从站地址
            
            SendCommand.Add(0x01); //功能码
            
            //起始地址
            SendCommand.Add((byte)(iAddress / 256)); //高位
            SendCommand.Add((byte)(iAddress % 256)); //低位
            
            //长度
            SendCommand.Add((byte)(iLength / 256)); //高位
            SendCommand.Add((byte)(iLength % 256)); //低位   
            
            //校验CRC
            byte[] crc = Crc16(SendCommand.ToArray(), SendCommand.Count);
            SendCommand.AddRange(crc);
            byte[] response = null;

            //int bytelength = 0;

            //if (iLength%8==0)
            //{
            //    bytelength = iLength / 8;
            //}
            //else
            //{
            //    bytelength = iLength / 8+1;
            //}

            int bytelength = iLength % 8 == 0 ? iLength / 8 : iLength / 8 + 1;

            if (SendAndReceive(SendCommand.ToArray(),ref response))
            {
                //验证
                if (response.Length==5+ bytelength)
                {
                    if (response[0]==iDevAdd&&response[1]==0x01&&response[3]==bytelength&& CheckCRC(response))
                    {
                        //RCR检验
                        return GetByteArray(response, 3, response.Length - 5);
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
            
        }
        #endregion


        private byte[] GetByteArray(byte[] source ,int start,int count)
        {
            if (source== null || source?.Length <= 0) return null;

            if (start < 0 || count < 0) return null;

            if (source.Length < start + count) return null;
            byte[] result = new byte[count];
            Array.Copy(source, start, result, 0, count);
            return result;
        }

        private bool CheckCRC(byte[] response)
        {
            byte[] crc = Crc16(response, response.Length - 2);
            if (crc[0]==response[response.Length-2]&& crc[1]==response[response.Length-1])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool SendAndReceive(byte[] send,ref byte[] response)
        {
            try
            {
                MyCom.Write(send, 0, send.Length);

                //串口接收
                MemoryStream ms = new MemoryStream();
                DateTime start = DateTime.Now;
                byte[] buffer = new byte[1024];
                while (true)
                {
                    Thread.Sleep(20);
                    if (MyCom.BytesToRead > 0)
                    {
                        int count = MyCom.Read(buffer, 0, buffer.Length);
                        ms.Write(buffer, 0, count);
                    }
                    else
                    {
                        if ((DateTime.Now - start).TotalMilliseconds > this.RcvTimeOut)
                        {
                            ms.Dispose();
                            return false;
                        }
                        else if (ms.Length > 0)
                        {
                            break;
                        }
                    }
                }
                response = ms.ToArray();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        #region CRC
        private static readonly byte[] aucCRCHi = {
                    0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41, 0x01, 0xC0, 0x80, 0x41,
                    0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41, 0x00, 0xC1, 0x81, 0x40,
                    0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41, 0x01, 0xC0, 0x80, 0x41,
                    0x00, 0xC1, 0x81, 0x40, 0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41,
                    0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41, 0x01, 0xC0, 0x80, 0x41,
                    0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41, 0x00, 0xC1, 0x81, 0x40,
                    0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41, 0x00, 0xC1, 0x81, 0x40,
                    0x01, 0xC0, 0x80, 0x41, 0x01, 0xC0, 0x80, 0x41, 0x00, 0xC1, 0x81, 0x40,
                    0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41, 0x01, 0xC0, 0x80, 0x41,
                    0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41, 0x00, 0xC1, 0x81, 0x40,
                    0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41, 0x01, 0xC0, 0x80, 0x41,
                    0x00, 0xC1, 0x81, 0x40, 0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41,
                    0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41, 0x01, 0xC0, 0x80, 0x41,
                    0x00, 0xC1, 0x81, 0x40, 0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41,
                    0x01, 0xC0, 0x80, 0x41, 0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41,
                    0x00, 0xC1, 0x81, 0x40, 0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41,
                    0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41, 0x01, 0xC0, 0x80, 0x41,
                    0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41, 0x00, 0xC1, 0x81, 0x40,
                    0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41, 0x01, 0xC0, 0x80, 0x41,
                    0x00, 0xC1, 0x81, 0x40, 0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41,
                    0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41, 0x01, 0xC0, 0x80, 0x41,
                    0x00, 0xC1, 0x81, 0x40
                };
        private static readonly byte[] aucCRCLo = {
                0x00, 0xC0, 0xC1, 0x01, 0xC3, 0x03, 0x02, 0xC2, 0xC6, 0x06, 0x07, 0xC7,
                0x05, 0xC5, 0xC4, 0x04, 0xCC, 0x0C, 0x0D, 0xCD, 0x0F, 0xCF, 0xCE, 0x0E,
                0x0A, 0xCA, 0xCB, 0x0B, 0xC9, 0x09, 0x08, 0xC8, 0xD8, 0x18, 0x19, 0xD9,
                0x1B, 0xDB, 0xDA, 0x1A, 0x1E, 0xDE, 0xDF, 0x1F, 0xDD, 0x1D, 0x1C, 0xDC,
                0x14, 0xD4, 0xD5, 0x15, 0xD7, 0x17, 0x16, 0xD6, 0xD2, 0x12, 0x13, 0xD3,
                0x11, 0xD1, 0xD0, 0x10, 0xF0, 0x30, 0x31, 0xF1, 0x33, 0xF3, 0xF2, 0x32,
                0x36, 0xF6, 0xF7, 0x37, 0xF5, 0x35, 0x34, 0xF4, 0x3C, 0xFC, 0xFD, 0x3D,
                0xFF, 0x3F, 0x3E, 0xFE, 0xFA, 0x3A, 0x3B, 0xFB, 0x39, 0xF9, 0xF8, 0x38,
                0x28, 0xE8, 0xE9, 0x29, 0xEB, 0x2B, 0x2A, 0xEA, 0xEE, 0x2E, 0x2F, 0xEF,
                0x2D, 0xED, 0xEC, 0x2C, 0xE4, 0x24, 0x25, 0xE5, 0x27, 0xE7, 0xE6, 0x26,
                0x22, 0xE2, 0xE3, 0x23, 0xE1, 0x21, 0x20, 0xE0, 0xA0, 0x60, 0x61, 0xA1,
                0x63, 0xA3, 0xA2, 0x62, 0x66, 0xA6, 0xA7, 0x67, 0xA5, 0x65, 0x64, 0xA4,
                0x6C, 0xAC, 0xAD, 0x6D, 0xAF, 0x6F, 0x6E, 0xAE, 0xAA, 0x6A, 0x6B, 0xAB,
                0x69, 0xA9, 0xA8, 0x68, 0x78, 0xB8, 0xB9, 0x79, 0xBB, 0x7B, 0x7A, 0xBA,
                0xBE, 0x7E, 0x7F, 0xBF, 0x7D, 0xBD, 0xBC, 0x7C, 0xB4, 0x74, 0x75, 0xB5,
                0x77, 0xB7, 0xB6, 0x76, 0x72, 0xB2, 0xB3, 0x73, 0xB1, 0x71, 0x70, 0xB0,
                0x50, 0x90, 0x91, 0x51, 0x93, 0x53, 0x52, 0x92, 0x96, 0x56, 0x57, 0x97,
                0x55, 0x95, 0x94, 0x54, 0x9C, 0x5C, 0x5D, 0x9D, 0x5F, 0x9F, 0x9E, 0x5E,
                0x5A, 0x9A, 0x9B, 0x5B, 0x99, 0x59, 0x58, 0x98, 0x88, 0x48, 0x49, 0x89,
                0x4B, 0x8B, 0x8A, 0x4A, 0x4E, 0x8E, 0x8F, 0x4F, 0x8D, 0x4D, 0x4C, 0x8C,
                0x44, 0x84, 0x85, 0x45, 0x87, 0x47, 0x46, 0x86, 0x82, 0x42, 0x43, 0x83,
                0x41, 0x81, 0x80, 0x40
             };

        /// <summary>
        /// CRC校验
        /// </summary>
        /// <param name="pucFrame">字节数组</param>
        /// <param name="usLen">验证长度</param>
        /// <returns>2个字节</returns>
       private byte[] Crc16(byte[] pucFrame, int usLen)
        {
            int i = 0;
            byte[] res = new byte[2] { 0xFF, 0xFF };
            UInt16 iIndex = 0x0000;
            while (usLen-- > 0)
            {
                iIndex = (UInt16)(res[0] ^ pucFrame[i++]);
                res[0] = (byte)(res[1] ^ aucCRCHi[iIndex]);
                res[1] = aucCRCLo[iIndex];
            }
            return res;
        }
        #endregion
    }
}