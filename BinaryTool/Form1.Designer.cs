namespace BinaryTool
{
	partial class BinToolForm
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
		/// 设计器支持所需的方法 - 不要
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.openBin = new System.Windows.Forms.Button();
			this.saveBin = new System.Windows.Forms.Button();
			this.newBin = new System.Windows.Forms.Button();
			this.BinRowNumber = new System.Windows.Forms.TextBox();
			this.Bin2HexField = new System.Windows.Forms.TextBox();
			this.Bin2CharField = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.editBin = new System.Windows.Forms.Button();
			this.showBin = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			this.SuspendLayout();
			// 
			// openBin
			// 
			this.openBin.Location = new System.Drawing.Point(84, 3);
			this.openBin.Name = "openBin";
			this.openBin.Size = new System.Drawing.Size(75, 23);
			this.openBin.TabIndex = 0;
			this.openBin.Text = "打开二进制文件";
			this.openBin.UseVisualStyleBackColor = true;
			this.openBin.Click += new System.EventHandler(this.openBin_Click);
			// 
			// saveBin
			// 
			this.saveBin.Location = new System.Drawing.Point(165, 3);
			this.saveBin.Name = "saveBin";
			this.saveBin.Size = new System.Drawing.Size(75, 23);
			this.saveBin.TabIndex = 1;
			this.saveBin.Text = "保存二进制";
			this.saveBin.UseVisualStyleBackColor = true;
			this.saveBin.Click += new System.EventHandler(this.saveBin_Click);
			// 
			// newBin
			// 
			this.newBin.Location = new System.Drawing.Point(3, 3);
			this.newBin.Name = "newBin";
			this.newBin.Size = new System.Drawing.Size(75, 23);
			this.newBin.TabIndex = 2;
			this.newBin.Text = "新建二进制";
			this.newBin.UseVisualStyleBackColor = true;
			this.newBin.Click += new System.EventHandler(this.newBin_Click);
			// 
			// BinRowNumber
			// 
			this.BinRowNumber.Dock = System.Windows.Forms.DockStyle.Fill;
			this.BinRowNumber.Location = new System.Drawing.Point(0, 0);
			this.BinRowNumber.Multiline = true;
			this.BinRowNumber.Name = "BinRowNumber";
			this.BinRowNumber.ReadOnly = true;
			this.BinRowNumber.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.BinRowNumber.Size = new System.Drawing.Size(62, 348);
			this.BinRowNumber.TabIndex = 3;
			// 
			// Bin2HexField
			// 
			this.Bin2HexField.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Bin2HexField.Location = new System.Drawing.Point(0, 0);
			this.Bin2HexField.Multiline = true;
			this.Bin2HexField.Name = "Bin2HexField";
			this.Bin2HexField.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.Bin2HexField.Size = new System.Drawing.Size(359, 348);
			this.Bin2HexField.TabIndex = 4;
			// 
			// Bin2CharField
			// 
			this.Bin2CharField.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Bin2CharField.Location = new System.Drawing.Point(0, 0);
			this.Bin2CharField.Multiline = true;
			this.Bin2CharField.Name = "Bin2CharField";
			this.Bin2CharField.ReadOnly = true;
			this.Bin2CharField.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.Bin2CharField.Size = new System.Drawing.Size(165, 348);
			this.Bin2CharField.TabIndex = 5;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.editBin);
			this.panel1.Controls.Add(this.showBin);
			this.panel1.Controls.Add(this.newBin);
			this.panel1.Controls.Add(this.openBin);
			this.panel1.Controls.Add(this.saveBin);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(594, 31);
			this.panel1.TabIndex = 6;
			// 
			// editBin
			// 
			this.editBin.Location = new System.Drawing.Point(435, 3);
			this.editBin.Name = "editBin";
			this.editBin.Size = new System.Drawing.Size(75, 23);
			this.editBin.TabIndex = 4;
			this.editBin.Text = "加载修改";
			this.editBin.UseVisualStyleBackColor = true;
			this.editBin.Click += new System.EventHandler(this.editBin_Click);
			// 
			// showBin
			// 
			this.showBin.Location = new System.Drawing.Point(516, 2);
			this.showBin.Name = "showBin";
			this.showBin.Size = new System.Drawing.Size(75, 23);
			this.showBin.TabIndex = 3;
			this.showBin.Text = "刷新显示";
			this.showBin.UseVisualStyleBackColor = true;
			this.showBin.Click += new System.EventHandler(this.showBin_Click);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.splitContainer1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 31);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(594, 348);
			this.panel2.TabIndex = 7;
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.BinRowNumber);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
			this.splitContainer1.Size = new System.Drawing.Size(594, 348);
			this.splitContainer1.SplitterDistance = 62;
			this.splitContainer1.TabIndex = 6;
			// 
			// splitContainer2
			// 
			this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer2.Location = new System.Drawing.Point(0, 0);
			this.splitContainer2.Name = "splitContainer2";
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.Controls.Add(this.Bin2HexField);
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.Controls.Add(this.Bin2CharField);
			this.splitContainer2.Size = new System.Drawing.Size(528, 348);
			this.splitContainer2.SplitterDistance = 359;
			this.splitContainer2.TabIndex = 0;
			// 
			// BinToolForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(594, 379);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "BinToolForm";
			this.Text = "Form1";
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel1.PerformLayout();
			this.splitContainer2.Panel2.ResumeLayout(false);
			this.splitContainer2.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
			this.splitContainer2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button openBin;
		private System.Windows.Forms.Button saveBin;
		private System.Windows.Forms.Button newBin;
		private System.Windows.Forms.TextBox BinRowNumber;
		private System.Windows.Forms.TextBox Bin2HexField;
		private System.Windows.Forms.TextBox Bin2CharField;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button editBin;
		private System.Windows.Forms.Button showBin;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.SplitContainer splitContainer2;
	}
}

