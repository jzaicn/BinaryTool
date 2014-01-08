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

		private void newBin_Click(object sender, EventArgs e)
		{
			memeryBinaryArray.Clear();
		}

		private void openBin_Click(object sender, EventArgs e)
		{
			memeryBinaryArray.Clear();
			FileStream stream = new FileStream(@"E:\workspace3\BinaryTool\BinaryTool\open.bin", FileMode.Open);
			stream.Seek(0, SeekOrigin.Begin);
			for (int i = 0; i < stream.Length;i++ )
			{
				memeryBinaryArray.Add((byte)stream.ReadByte());
			}
			stream.Close();

// 			using (FileStream fileReader = new FileStream(@"E:\workspace3\BinaryTool\BinaryTool\open.jpg",FileMode.Open,FileAccess.Read))
// 			{
// 				BinaryReader binReader = new BinaryReader(fileReader);
// 				fileReader.Seek(0, SeekOrigin.Begin);
// 				try
// 				{
// 					while (true)
// 					{
// 						memeryBinaryArray.Add((byte)binReader.ReadByte());
// 					}
// 				}
// 				catch (System.Exception ex)
// 				{
// 					MessageBox.Show(ex.Message + "结尾");
// 				}
// 				
// 			}
		}

		private void saveBin_Click(object sender, EventArgs e)
		{
			byte[] dataArray = memeryBinaryArray.ToArray();
			using (FileStream fileStream = new FileStream(@"E:\workspace3\BinaryTool\BinaryTool\save.jpg", FileMode.OpenOrCreate))
			{
				fileStream.Seek(0, SeekOrigin.Begin);
				for(int i = 0; i < dataArray.Length; i++){
					fileStream.WriteByte(dataArray[i]);
				}
			}
		}

		private void editBin_Click(object sender, EventArgs e)
		{
			memeryBinaryArray.Clear();
			memeryBinaryArray.AddRange(stringByte.stringToByte(Bin2HexField.Text));
		}

		private void showBin_Click(object sender, EventArgs e)
		{
			Bin2HexField.Text = stringByte.byteToString(memeryBinaryArray.ToArray());
		}
	}
}
