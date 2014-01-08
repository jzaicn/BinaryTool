using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Variables;
using System.IO;

namespace BinaryTool
{
	public partial class BinToolForm : Form
	{
		public BinToolForm()
		{
			InitializeComponent();
		}

		List<byte> memeryBinaryArray = new List<byte>();

		/// <summary>
		/// 新建二进制文件
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void newBin_Click(object sender, EventArgs e)
		{
			//清空数据
			memeryBinaryArray.Clear();

			//刷新显示
			showBin_Click(null, null);
		}

		/// <summary>
		/// 打开一个二进制文件
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void openBin_Click(object sender, EventArgs e)
		{
			memeryBinaryArray.Clear();
			OpenFileDialog filedialog = new OpenFileDialog();
			filedialog.InitialDirectory = @".";
			filedialog.Filter = @"JPG (*.jpg)|*.jpg|All files (*.*)|*.*";
			filedialog.FilterIndex = 2;
			filedialog.RestoreDirectory = true;
			if (filedialog.ShowDialog() == DialogResult.OK)
			{
				try
				{
					//读取文件
					FileStream stream = new FileStream(filedialog.FileName, FileMode.Open);
					stream.Seek(0, SeekOrigin.Begin);
					for (int i = 0; i < stream.Length; i++)
					{
						memeryBinaryArray.Add((byte)stream.ReadByte());
					}
					stream.Close();


					//刷新显示
					showBin_Click(null, null);
				}
				catch (System.Exception ex)
				{
					MessageBox.Show(ex.Message);	
				}
			}
		}

		/// <summary>
		/// 保存一个二进制文件
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void saveBin_Click(object sender, EventArgs e)
		{
			byte[] dataArray = memeryBinaryArray.ToArray();
			SaveFileDialog filedialog = new SaveFileDialog();
			filedialog.InitialDirectory = @".";
			filedialog.Filter = @"JPG (*.jpg)|*.jpg|All files (*.*)|*.*";
			filedialog.FilterIndex = 2;
			filedialog.RestoreDirectory = true;
			if (filedialog.ShowDialog() == DialogResult.OK)
			{
				try
				{
					//保存文件
					FileStream fileStream = new FileStream(filedialog.FileName, FileMode.OpenOrCreate);
					fileStream.Seek(0, SeekOrigin.Begin);
					for(int i = 0; i < dataArray.Length; i++){
						fileStream.WriteByte(dataArray[i]);
					}
					fileStream.Close();
				}
				catch (System.Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}

		}

		/// <summary>
		/// 编辑当前二进制串口中的数据
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void editBin_Click(object sender, EventArgs e)
		{
			//保存修改内容到内存
			memeryBinaryArray.Clear();
			memeryBinaryArray.AddRange(stringByte.stringToByte(Bin2HexField.Text));

			//刷新显示
			showBin_Click(null, null);
		}

		/// <summary>
		/// 刷新数据到当前二进制窗口
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void showBin_Click(object sender, EventArgs e)
		{
			show_HexFieldFromMemery();
			show_RowNumberFromHexField();
			show_CharFieldFromHexField();
		}

		/// <summary>
		/// 从内存二进制到窗口以十六进制显示
		/// </summary>
		void show_HexFieldFromMemery()
		{
			//二进制填充到二进制窗口
			Bin2HexField.Text = stringByte.byteToString(memeryBinaryArray.ToArray());
		}

		/// <summary>
		/// 从十六进制窗口提取行号显示
		/// </summary>
		void show_RowNumberFromHexField()
		{
			//获得文本行数
			int totalline = Bin2HexField.GetLineFromCharIndex(Bin2HexField.Text.Length) + 1;
			string rowNumber = "";
			for (int i = 0; i < totalline; i++)
			{
				rowNumber += i.ToString() + "\r\n";
			}
			BinRowNumber.Text = rowNumber.Remove(rowNumber.Length - 2);
		}

		/// <summary>
		/// 从十六进制窗口提取每行对应ASCII码显示
		/// </summary>
		void show_CharFieldFromHexField()
		{
			//转ASCII码显示
			string strDisplay = "";
			int totalline = Bin2HexField.GetLineFromCharIndex(Bin2HexField.Text.Length) + 1;
			int remainLen = Bin2HexField.Text.Length;
			for (int i = 0; i < totalline; i++)
			{
				int start = Bin2HexField.GetFirstCharIndexFromLine(i);//第一行第一个字符的索引
				int end = Bin2HexField.GetFirstCharIndexFromLine(i + 1);//第二行第一个字符的索引
				if (end == -1)
				{
					end = remainLen + start;
				}
				strDisplay += stringByte.byte2NormalVisableStr(stringByte.stringToByte(Bin2HexField.Text.Substring(start, end - start)).ToArray()) + "\r\n";//选中一行
				remainLen -= (end - start);
			}
			Bin2CharField.Text = strDisplay.Remove(strDisplay.Length - 2);
		}
	}
}
