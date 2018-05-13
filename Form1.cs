using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Drawing.Drawing2D;

namespace FileSystem
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem MIExit;
		private System.Windows.Forms.MenuItem MIFile;
		private System.Windows.Forms.ListView LVForFiles;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.MenuItem MICreateImage;
		private System.Windows.Forms.MenuItem MIOpenImage;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.TreeView TVDirs;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.MenuItem MIOperations;
		private System.Windows.Forms.MenuItem MICloseImage;
		private System.Windows.Forms.MenuItem MIDeleteFile;
		private System.Windows.Forms.MenuItem MIAddFileToImage;
		private System.Windows.Forms.MenuItem MIFileOperations;
		private System.Windows.Forms.MenuItem MIDirOperations;
		private System.Windows.Forms.MenuItem MICreateDir;
		private System.Windows.Forms.MenuItem MIMoveFile;
		private System.Windows.Forms.MenuItem MIReadFile;
		private System.Windows.Forms.ListView LVImageInfo;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.MenuItem MIMoveDir;
		private System.Windows.Forms.ListView LVFreeSeries;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader7;
		private System.Windows.Forms.ColumnHeader columnHeader8;
		private System.Windows.Forms.Panel PanelForDiag;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					this.Image.CloseImage();
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.MIFile = new System.Windows.Forms.MenuItem();
			this.MICreateImage = new System.Windows.Forms.MenuItem();
			this.MIOpenImage = new System.Windows.Forms.MenuItem();
			this.MIExit = new System.Windows.Forms.MenuItem();
			this.MIOperations = new System.Windows.Forms.MenuItem();
			this.LVForFiles = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.TVDirs = new System.Windows.Forms.TreeView();
			this.MICloseImage = new System.Windows.Forms.MenuItem();
			this.MIFileOperations = new System.Windows.Forms.MenuItem();
			this.MIDeleteFile = new System.Windows.Forms.MenuItem();
			this.MIAddFileToImage = new System.Windows.Forms.MenuItem();
			this.MIDirOperations = new System.Windows.Forms.MenuItem();
			this.MICreateDir = new System.Windows.Forms.MenuItem();
			this.MIMoveFile = new System.Windows.Forms.MenuItem();
			this.MIReadFile = new System.Windows.Forms.MenuItem();
			this.LVImageInfo = new System.Windows.Forms.ListView();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
			this.MIMoveDir = new System.Windows.Forms.MenuItem();
			this.LVFreeSeries = new System.Windows.Forms.ListView();
			this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
			this.PanelForDiag = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.MIFile,
																					  this.MIOperations});
			// 
			// MIFile
			// 
			this.MIFile.Index = 0;
			this.MIFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																				   this.MICreateImage,
																				   this.MIOpenImage,
																				   this.MICloseImage,
																				   this.MIExit});
			this.MIFile.Text = "Файл";
			// 
			// MICreateImage
			// 
			this.MICreateImage.Index = 0;
			this.MICreateImage.Text = "Создать образ тома...";
			this.MICreateImage.Click += new System.EventHandler(this.MICreateImage_Click);
			// 
			// MIOpenImage
			// 
			this.MIOpenImage.Index = 1;
			this.MIOpenImage.Text = "Открыть образ тома...";
			this.MIOpenImage.Click += new System.EventHandler(this.MIOpenImage_Click);
			// 
			// MIExit
			// 
			this.MIExit.Index = 3;
			this.MIExit.Text = "Выход";
			this.MIExit.Click += new System.EventHandler(this.MIExit_Click);
			// 
			// MIOperations
			// 
			this.MIOperations.Index = 1;
			this.MIOperations.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						 this.MIFileOperations,
																						 this.MIDirOperations});
			this.MIOperations.Text = "Операции";
			// 
			// LVForFiles
			// 
			this.LVForFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																						 this.columnHeader1,
																						 this.columnHeader2,
																						 this.columnHeader3});
			this.LVForFiles.FullRowSelect = true;
			this.LVForFiles.Location = new System.Drawing.Point(264, 16);
			this.LVForFiles.MultiSelect = false;
			this.LVForFiles.Name = "LVForFiles";
			this.LVForFiles.Size = new System.Drawing.Size(280, 480);
			this.LVForFiles.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.LVForFiles.TabIndex = 1;
			this.LVForFiles.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Имя файла";
			this.columnHeader1.Width = 108;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Размер";
			this.columnHeader2.Width = 78;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Дата создания";
			this.columnHeader3.Width = 90;
			// 
			// TVDirs
			// 
			this.TVDirs.ImageIndex = -1;
			this.TVDirs.Location = new System.Drawing.Point(8, 16);
			this.TVDirs.Name = "TVDirs";
			this.TVDirs.PathSeparator = "/";
			this.TVDirs.SelectedImageIndex = -1;
			this.TVDirs.Size = new System.Drawing.Size(248, 480);
			this.TVDirs.Sorted = true;
			this.TVDirs.TabIndex = 3;
			this.TVDirs.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TVDirs_AfterSelect);
			// 
			// MICloseImage
			// 
			this.MICloseImage.Index = 2;
			this.MICloseImage.Text = "Закрыть образ тома";
			this.MICloseImage.Click += new System.EventHandler(this.MICloseImage_Click);
			// 
			// MIFileOperations
			// 
			this.MIFileOperations.Index = 0;
			this.MIFileOperations.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																							 this.MIAddFileToImage,
																							 this.MIReadFile,
																							 this.MIMoveFile,
																							 this.MIDeleteFile});
			this.MIFileOperations.Text = "Файл...";
			// 
			// MIDeleteFile
			// 
			this.MIDeleteFile.Index = 3;
			this.MIDeleteFile.Text = "Удалить";
			this.MIDeleteFile.Click += new System.EventHandler(this.MIDeleteFile_Click);
			// 
			// MIAddFileToImage
			// 
			this.MIAddFileToImage.Index = 0;
			this.MIAddFileToImage.Text = "Добавить в образ тома...";
			this.MIAddFileToImage.Click += new System.EventHandler(this.MIAddFileToImage_Click);
			// 
			// MIDirOperations
			// 
			this.MIDirOperations.Index = 1;
			this.MIDirOperations.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																							this.MICreateDir,
																							this.MIMoveDir});
			this.MIDirOperations.Text = "Каталог...";
			// 
			// MICreateDir
			// 
			this.MICreateDir.Index = 0;
			this.MICreateDir.Text = "Создать...";
			this.MICreateDir.Click += new System.EventHandler(this.MICreateDir_Click);
			// 
			// MIMoveFile
			// 
			this.MIMoveFile.Index = 2;
			this.MIMoveFile.Text = "Переместить...";
			this.MIMoveFile.Click += new System.EventHandler(this.MIMoveFile_Click);
			// 
			// MIReadFile
			// 
			this.MIReadFile.Index = 1;
			this.MIReadFile.Text = "Извлечь из образа тома...";
			this.MIReadFile.Click += new System.EventHandler(this.MIReadFile_Click);
			// 
			// LVImageInfo
			// 
			this.LVImageInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																						  this.columnHeader4,
																						  this.columnHeader5});
			this.LVImageInfo.FullRowSelect = true;
			this.LVImageInfo.Location = new System.Drawing.Point(552, 16);
			this.LVImageInfo.MultiSelect = false;
			this.LVImageInfo.Name = "LVImageInfo";
			this.LVImageInfo.Size = new System.Drawing.Size(224, 112);
			this.LVImageInfo.TabIndex = 4;
			this.LVImageInfo.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Свойство образа тома";
			this.columnHeader4.Width = 127;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Значение";
			this.columnHeader5.Width = 93;
			// 
			// MIMoveDir
			// 
			this.MIMoveDir.Index = 1;
			this.MIMoveDir.Text = "Переместить...";
			this.MIMoveDir.Click += new System.EventHandler(this.MIMoveDir_Click);
			// 
			// LVFreeSeries
			// 
			this.LVFreeSeries.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																						   this.columnHeader6,
																						   this.columnHeader7,
																						   this.columnHeader8});
			this.LVFreeSeries.FullRowSelect = true;
			this.LVFreeSeries.Location = new System.Drawing.Point(552, 320);
			this.LVFreeSeries.MultiSelect = false;
			this.LVFreeSeries.Name = "LVFreeSeries";
			this.LVFreeSeries.Size = new System.Drawing.Size(224, 176);
			this.LVFreeSeries.TabIndex = 5;
			this.LVFreeSeries.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "№ серии";
			this.columnHeader6.Width = 77;
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "Начало";
			this.columnHeader7.Width = 73;
			// 
			// columnHeader8
			// 
			this.columnHeader8.Text = "Конец";
			this.columnHeader8.Width = 70;
			// 
			// PanelForDiag
			// 
			this.PanelForDiag.Location = new System.Drawing.Point(560, 184);
			this.PanelForDiag.Name = "PanelForDiag";
			this.PanelForDiag.Size = new System.Drawing.Size(208, 64);
			this.PanelForDiag.TabIndex = 6;
			this.PanelForDiag.Visible = false;
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.Color.Blue;
			this.label1.Location = new System.Drawing.Point(576, 264);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 16);
			this.label1.TabIndex = 7;
			this.label1.Text = "свободно";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.ForeColor = System.Drawing.Color.Brown;
			this.label2.Location = new System.Drawing.Point(680, 264);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 16);
			this.label2.TabIndex = 8;
			this.label2.Text = "занято";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(584, 152);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(160, 16);
			this.label3.TabIndex = 9;
			this.label3.Text = "Структура образа тома";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(786, 507);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.LVFreeSeries);
			this.Controls.Add(this.LVImageInfo);
			this.Controls.Add(this.TVDirs);
			this.Controls.Add(this.LVForFiles);
			this.Controls.Add(this.PanelForDiag);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Menu = this.mainMenu1;
			this.Name = "Form1";
			this.Text = "Эмулятор файловой системы";
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}
		
		
		///////////////////////////////////////////////////////////
		
		private Image Image = new Image();
		private BlockSeries[] FreeBlocks;
		
		///////////////////////////////////////////////////////////

		private void FillLVFreeSeries()
		{
			try
			{
				BlockSeries[] Series = this.FreeBlocks;
				string[] Str = new string[3];
				this.LVFreeSeries.BeginUpdate();
				this.LVFreeSeries.Items.Clear();
				for(int i = 0; i < Series.Length; i++)
				{
					int tmp1 = i + 1;
					Int64 tmp2 = Series[i].FirstBlock + Series[i].Blocks - 1;
					Str[0] = tmp1.ToString();
					Str[1] = Series[i].FirstBlock.ToString();
					Str[2] = tmp2.ToString();
					ListViewItem lvi = new ListViewItem(Str);
					this.LVFreeSeries.Items.Add(lvi);
				}
				this.LVFreeSeries.EndUpdate();
			}
			catch(Exception e)
			{
				MessageBox.Show("Невозможно прочитать список свободных серий. Ошибка: " + e.Message,
					"Ошибка чтения списка свободных серий");
			}

		}
		private void FillTree()
		{
			try
			{
				System.Text.StringBuilder SB = new System.Text.StringBuilder();
				TreeNode TN, Pop;
				Stack Stack = new Stack();
				char[] Separator = {'/'};
				this.TVDirs.BeginUpdate();
				this.TVDirs.Nodes.Clear();

				SB.Append(this.Image.SuperBlock.Root.Name);
				TN = new TreeNode(SB.ToString());
				SB.Remove(0, SB.Length);
				this.TVDirs.Nodes.Add(TN);
				Stack.Push(TN);
				while(Stack.Count > 0)
				{
					Pop = (TreeNode) Stack.Pop();
					string[] Path = Pop.FullPath.Split(Separator);
					FileRecord[] Dirs = this.Image.GetFilesOrDirs(Path, false);
					if(Dirs == null) continue;
					for(int i = 0; i < Dirs.Length; i++)
					{
						SB.Append(Dirs[i].Name);
						TN = new TreeNode(SB.ToString());
						SB.Remove(0, SB.Length);
						Pop.Nodes.Add(TN);
						Stack.Push(TN);
					}
				}
				this.TVDirs.SelectedNode = TVDirs.TopNode;
				this.TVDirs.ExpandAll();
				this.TVDirs.EndUpdate();
				this.FillImageInfo();
				this.FreeBlocks = this.Image.GetFreeBlockSeries();
				this.FillLVFreeSeries();
				this.Invalidate();
			}
			catch(Exception e)
			{
				MessageBox.Show("Невозможно построить дерево каталогов. Ошибка: " + e.Message,
					"Ошибка построения дерева каталогов");
			}
		}
		private void MIExit_Click(object sender, System.EventArgs e)
		{
			this.Close();		
		}
		private void MICreateImage_Click(object sender, System.EventArgs e)
		{
			try
			{
				saveFileDialog1.Filter = "Файлы образа тома (*.img)|*.img";
				if(saveFileDialog1.ShowDialog() == DialogResult.OK)
				{
					FormCreateImage Form = new FormCreateImage();
					if(Form.ShowDialog() == DialogResult.OK)
					{
						string ID = Form.textBox1.Text;
						if(ID.Length >= 8) ID = ID.Substring(0, 8);
						else ID = ID.PadRight(8, ' ');
						Int64 Blocks = Int64.Parse(Form.textBox2.Text);
						this.Image.CreateImage(saveFileDialog1.FileName, ID, Blocks);
						this.FillTree();
					}
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show("Невозможно создать образ тома. Ошибка: " + ex.Message,
					"Ошибка создания образа тома");
			}
		}
		private void MIOpenImage_Click(object sender, System.EventArgs e)
		{
			try
			{
				openFileDialog1.Filter = "Файлы образа тома (*.img)|*.img";
				if(openFileDialog1.ShowDialog() == DialogResult.OK)
				{
					this.Image.OpenImage(openFileDialog1.FileName);
					this.FillTree();

					//TreeViewEventArgs EvAr = new TreeViewEventArgs(this.TVDirs.TopNode);
					//this.TVDirs_AfterSelect(this, EvAr);
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show("Невозможно открыть образ тома. Ошибка: " + ex.Message,
					"Ошибка открытия образа тома");
			}
		}
		private void TVDirs_AfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e)
		{
			try
			{
				System.Text.StringBuilder SB = new System.Text.StringBuilder();
				char[] Separator = {'/'};

				string[] Path = e.Node.FullPath.Split(Separator);
				FileRecord[] Files = this.Image.GetFilesOrDirs(Path, true);
				if(Files == null)
				{
					this.LVForFiles.Items.Clear();
					return;
				}
				this.LVForFiles.BeginUpdate();
				this.LVForFiles.Items.Clear();
				for(int i = 0; i < Files.Length; i++)
				{
					SB.Append(Files[i].Name);
					if(SB.ToString() == "$free_blocks_list")
					{
						SB.Remove(0, SB.Length);
						continue;
					}
					string[] tmpStrArr = this.Image.GetStringsOfAttributes(Files[i]);
					string[] FileStrArr = new string[3];
					FileStrArr[0] = SB.ToString();
					FileStrArr[1] = tmpStrArr[0];
					FileStrArr[2] = tmpStrArr[1];
					ListViewItem lvi = new ListViewItem(FileStrArr);
					this.LVForFiles.Items.Add(lvi);
					SB.Remove(0, SB.Length);
				}
				this.LVForFiles.EndUpdate();
			}
			catch(Exception ex)
			{
				MessageBox.Show("Невозможно вывести содержимое каталога. Ошибка: " + ex.Message,
					"Ошибка вывода содержимого каталога");
			}
		}
		private void MIAddFileToImage_Click(object sender, System.EventArgs e)
		{
			try
			{
				char[] Separator = {'/'};
				openFileDialog1.Filter = "Все Файлы|*.*";
				if(openFileDialog1.ShowDialog() == DialogResult.OK)
				{
					FormSelectDir Form = new FormSelectDir();
					TreeNode Root = new TreeNode();
					Root = (TreeNode) this.TVDirs.TopNode.Clone();
					Form.treeView1.Nodes.Add(Root);
					if(Form.ShowDialog() == DialogResult.OK)
					{
						// проверка существования файла в образе
						FileInfo FileInfo = new FileInfo(openFileDialog1.FileName);
						TreeNode Parent = Form.treeView1.SelectedNode;
						string[] Path, PathOfFile;
						Path = Parent.FullPath.Split(Separator);
						PathOfFile = new string[Path.Length + 1];
						Path.CopyTo(PathOfFile, 0);
						PathOfFile[Path.Length] = FileInfo.Name;
						if(this.Image.FindPositionOfFileRecord(PathOfFile) != -1)
						{
							if(FileInfo.Name == "$free_blocks_list")
								throw new Exception("Невозможно добавить файл с зарезервированным именем");
							if(MessageBox.Show("Файл с таким именем уже существует. Перезаписать?",
								"Добавление файла в образ тома", MessageBoxButtons.OKCancel) == DialogResult.OK)
								this.Image.Delete(PathOfFile);
							else return;
						}
						this.Image.CreateFile(openFileDialog1.FileName, Path);
						this.FillTree();
					}
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show("Невозможно записать файл в образ тома. Ошибка: " + ex.Message,
					"Ошибка записи файла в образ тома");
			}
		}
		private void Form1_Paint(object sender, PaintEventArgs e)
		{
			try
			{
				if(this.Image.IsLoaded == false || this.FreeBlocks == null) return;
				GraphicsContainer GC = e.Graphics.BeginContainer();
				float x, y, w, w2, h;
				x = this.PanelForDiag.Left;
				y = this.PanelForDiag.Top;
				w = this.PanelForDiag.Width;
				h = this.PanelForDiag.Height;
				e.Graphics.TranslateTransform(x, y);
				SolidBrush sbBlue = new SolidBrush(Color.Blue);
				SolidBrush sbBrown = new SolidBrush(Color.Brown);
				e.Graphics.FillRectangle(sbBrown, 0, 0, w - 1, h);
				for(int i = 0; i < this.FreeBlocks.Length; i++)
				{
					float t = this.Image.SuperBlock.TotalBlocks - 1;
					x = (float) this.FreeBlocks[i].FirstBlock * w / t;
					w2 = (float) this.FreeBlocks[i].Blocks * w / t;
					e.Graphics.FillRectangle(sbBlue, (int) x, 0, (int) w2, (int) h);
				}
				e.Graphics.EndContainer(GC);
			}
			catch(Exception ex)
			{
				MessageBox.Show("Невозможно построить диаграмму. Ошибка: " + ex.Message,
					"Ошибка построения диаграммы");
			}
		}
		private void MICloseImage_Click(object sender, System.EventArgs e)
		{
			try
			{
				this.Image.CloseImage();
				this.TVDirs.Nodes.Clear();
				this.LVForFiles.Items.Clear();
				this.LVImageInfo.Items.Clear();
				this.LVFreeSeries.Items.Clear();
				this.Invalidate();
			}
			catch(Exception ex)
			{
				MessageBox.Show("Невозможно закрыть образ тома. Ошибка: " + ex.Message,
					"Ошибка закрытия образа тома");
			}
		}
		private void MIDeleteFile_Click(object sender, System.EventArgs e)
		{
			try
			{
				char[] Separator = { '/' };
				string FileName = this.LVForFiles.SelectedItems[0].Text;
				if(MessageBox.Show("Удалить файл " + FileName + "?", "Удаление файла",
					MessageBoxButtons.OKCancel) == DialogResult.OK)
				{
					string FullPath = this.TVDirs.SelectedNode.FullPath + "/" + FileName;
					string[] Path = FullPath.Split(Separator);
					this.Image.Delete(Path);
					this.FillTree();
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show("Невозможно удалить файл из образа тома. Ошибка: " + ex.Message,
					"Ошибка удаления файла");
			}
		}
		private void MICreateDir_Click(object sender, System.EventArgs e)
		{
			try
			{
				FormSelectDir FormSD = new FormSelectDir();
				TreeNode Root = new TreeNode();
				Root = (TreeNode) this.TVDirs.TopNode.Clone();
				FormSD.treeView1.Nodes.Add(Root);
				if(FormSD.ShowDialog() == DialogResult.OK)
				{
					FormCreateDir FormCD = new FormCreateDir();
					if(FormCD.ShowDialog() == DialogResult.OK)
					{
						char[] Separator = { '/' };
						string DirName = FormCD.textBox1.Text;
                        string DirParentPathStr = FormSD.treeView1.SelectedNode.FullPath;
                        string DirPathStr = DirParentPathStr + '/' + DirName;
						string[] DirParentPath = DirParentPathStr.Split(Separator);
                        string[] DirPath = DirPathStr.Split(Separator);
						if(this.Image.FindPositionOfFileRecord(DirPath) > 0)
							throw new Exception("Каталог с таким именем уже существует");
						this.Image.CreateDir(DirName, DirParentPath);
						this.FillTree();
					}
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show("Невозможно создать каталог. Ошибка: " + ex.Message,
					"Ошибка создания каталога");
			}				
		}
		private void MIMoveFile_Click(object sender, System.EventArgs e)
		{
			try
			{
				FormSelectDir FormSD = new FormSelectDir();
				TreeNode Root = new TreeNode();
				Root = (TreeNode) this.TVDirs.TopNode.Clone();
				FormSD.treeView1.Nodes.Add(Root);
				if(FormSD.ShowDialog() == DialogResult.OK)
				{
					char[] Separator = { '/' };
					string FileName = this.TVDirs.SelectedNode.Text;
					string FilePath = this.TVDirs.SelectedNode.FullPath + "/" +
						this.LVForFiles.SelectedItems[0].Text;
					string[] From = FilePath.Split(Separator);
					string[] To = FormSD.treeView1.SelectedNode.FullPath.Split(Separator);
					string[] DestPath = new string[To.Length + 1];
					To.CopyTo(DestPath, 0);
					DestPath[To.Length + 1] = FileName;
					if(this.Image.FindPositionOfFileRecord(DestPath) > 0)
					{
						if(MessageBox.Show("Файл с таким именем уже существует. Перезаписать?",
							"Перемещение файла", MessageBoxButtons.OKCancel) == DialogResult.OK)
							this.Image.Delete(DestPath);
						else return;
					}
					this.Image.Move(From, To);
					this.FillTree();
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show("Невозможно переместить файл. Ошибка: " + ex.Message,
					"Ошибка перемещения файла");
			}		
		}
		private void MIReadFile_Click(object sender, System.EventArgs e)
		{
			try
			{
				saveFileDialog1.Filter = "Все файлы *.*| *.*";
				if(saveFileDialog1.ShowDialog() == DialogResult.OK)
				{
					char[] Separator = { '/' };
					string FilePath = this.TVDirs.SelectedNode.FullPath + "/" +
						this.LVForFiles.SelectedItems[0].Text;
					string[] Path = FilePath.Split(Separator);
					this.Image.ReadFile(saveFileDialog1.FileName, Path);
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show("Невозможно извлечь файл. Ошибка: " + ex.Message,
					"Ошибка извлечения файла");
			}	
		}
		private void MIMoveDir_Click(object sender, System.EventArgs e)
		{
			try
			{
				if(this.TVDirs.SelectedNode == this.TVDirs.TopNode)
					throw new Exception("Невозможно переместить корневой каталог");
				FormSelectDir FormSD = new FormSelectDir();
				TreeNode Root = new TreeNode();
				Root = (TreeNode) this.TVDirs.TopNode.Clone();
				FormSD.treeView1.Nodes.Add(Root);
				if(FormSD.ShowDialog() == DialogResult.OK)
				{
					char[] Separator = { '/' };
					string DirName = this.TVDirs.SelectedNode.Text;
					string FromStr = this.TVDirs.SelectedNode.FullPath;
                    string ToStr = FormSD.treeView1.SelectedNode.FullPath;
                    string DestPathStr = ToStr + '/' + DirName;
					string[] From = DestPathStr.Split(Separator);
					string[] To = FormSD.treeView1.SelectedNode.FullPath.Split(Separator);
                    string[] DestPath = DestPathStr.Split(Separator);
					if(this.Image.FindPositionOfFileRecord(DestPath) > 0)
                        throw new Exception("Каталог с таким именем уже существует");
                    this.Image.Move(From, To);
					this.FillTree();
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show("Невозможно переместить каталог. Ошибка: " + ex.Message,
					"Ошибка перемещения каталога");
			}		
		}
		private void FillImageInfo()
		{
			try
			{
				System.Text.StringBuilder SB = new System.Text.StringBuilder();
				ListViewItem lvi = new ListViewItem();
				this.LVImageInfo.BeginUpdate();
				this.LVImageInfo.Items.Clear();
				string[] Str = new string[2];
				SB.Append(this.Image.SuperBlock.ID);
				Str[0] = "ID";
				Str[1] = SB.ToString();
                SB.Remove(0, SB.Length);
				lvi = new ListViewItem(Str);
				this.LVImageInfo.Items.Add(lvi);
				
				Str[0] = "Размер блока";
				Str[1] = this.Image.SuperBlock.BlockSize.ToString();
				lvi = new ListViewItem(Str);
				this.LVImageInfo.Items.Add(lvi);

				Str[0] = "Емкость (в блоках)";
				Str[1] = this.Image.SuperBlock.TotalBlocks.ToString();
				lvi = new ListViewItem(Str);
				this.LVImageInfo.Items.Add(lvi);

				Str[0] = "Емкость (в байтах)";
				Str[1] = this.Image.SuperBlock.SizeInBytes.ToString();
				lvi = new ListViewItem(Str);
				this.LVImageInfo.Items.Add(lvi);

				Str[0] = "Свободно (в блоках)";
				Str[1] = this.Image.SuperBlock.FreeBlocks.ToString();
				lvi = new ListViewItem(Str);
				this.LVImageInfo.Items.Add(lvi);

				Str[0] = "Свободно (в байтах)";
				Str[1] = this.Image.SuperBlock.FreeForUserInBytes.ToString();
				lvi = new ListViewItem(Str);
				this.LVImageInfo.Items.Add(lvi);
				this.LVImageInfo.EndUpdate();
			}
			catch(Exception ex)
			{
				MessageBox.Show("Невозможно прочитать информацию об образе тома. Ошибка: " + ex.Message,
					"Ошибка чтения информации об образе тома");
			}		
		}
	}

	// Интерфейс "Запись и чтение из потока"
	interface IStreamReadWrite
	{
		void ReadFromStream(FileStream Stream, BinaryReader Reader);
		void WriteToStream(FileStream Stream, BinaryWriter Writer);
	}

	// Флаги атрибутов файла
	public struct FileAttributeFlags
	{
		public const Int64 Use = 1;		// Запись используется
		public const Int64 Ext = 2;		// Внешнее значение
		public const Int64 Ser = 4;		// Внешнее значение в серии блоков
	}

	// Флаги файловой записи
	public struct FileRecordFlags
	{
		public const Int32 Use = 1;		// Запись используется
		public const Int32 Ext = 2;		// Есть внешние атрибуты
		public const Int32 Dir = 4;		// Директория
	}
	
	// Имена атрибутов файла
	public class Attributes
	{
		public static char[] CreationTime = "CreatTm_".ToCharArray();
		public static char[] LastAccessTime = "LastAccT".ToCharArray();
		public static char[] LastWriteTime = "LastWrTm".ToCharArray();
		public static char[] Data = "Data____".ToCharArray();
		public static string CreationTimeStr = "CreatTm_";
		public static string LastAccessTimeStr = "LastAccT";
		public static string LastWriteTimeStr = "LastWrTm";
		public static string DataStr = "Data____";
	}

	// Описание серии блоков
	public class BlockSeries : IStreamReadWrite
	{
		public Int64 FirstBlock;
		public Int64 Blocks;
		public void WriteToStream(FileStream Stream, BinaryWriter Writer)
		{
			Writer.Write(this.FirstBlock);
			Writer.Write(this.Blocks);
		}
		public void ReadFromStream(FileStream Stream, BinaryReader Reader)
		{
			this.FirstBlock = Reader.ReadInt64();
			this.Blocks = Reader.ReadInt64();
		}
	}
	
	// Описание блока, содержащего часть списка серий
	public class BlockOfSeriesList : IStreamReadWrite
	{
		public Int64 Next;				
		public Int64 Prev;
		public Int32 Number;
		public byte[] Reserve = new byte[12];
		public BlockSeries[] SeriesArray;
		public void WriteToStream(FileStream Stream, BinaryWriter Writer)
		{
			Writer.Write(this.Next);
			Writer.Write(this.Prev);
			Writer.Write(this.Number);
			Writer.Write(this.Reserve);
			for(int i = 0; i < this.Number; i++)
				this.SeriesArray[i].WriteToStream(Stream, Writer);
			int dif = (254 - this.Number) * 16;
			if(dif > 0)
			{
				byte[] buf = new byte[dif];
				Writer.Write(buf);
			}
		}
		public void ReadFromStream(FileStream Stream, BinaryReader Reader)
		{
			this.Next = Reader.ReadInt64();
			this.Prev = Reader.ReadInt64();
			this.Number = Reader.ReadInt32();
			this.Reserve = Reader.ReadBytes(12);
			this.SeriesArray = new BlockSeries[this.Number];
			for(int i = 0; i < this.Number; i++)
			{
				this.SeriesArray[i] = new BlockSeries();
				this.SeriesArray[i].ReadFromStream(Stream, Reader);
			}
			int dif = (254 - this.Number) * 16;
			if(dif > 0)
				Stream.Seek(dif, SeekOrigin.Current);
		}
	}

	// Атрибут файла
	public class FileAttribute : IStreamReadWrite
	{
		public Int64 Flags;
		public char[] Name;
		public Int64 Size;						// Размер внешнего атрибута (для типа B и C)
		public Int64 Block;						// Номер блока с началом списка серий (для типа B)
		// или номер блока, содержащего значение атрибута (тип C)

		public Int16 StringLength;				// Поля для внутреннего атрибута
		public char[] String;
		public DateTime DateTime;
			
		public void WriteToStream(FileStream Stream, BinaryWriter Writer)
		{
			int dif = 0;
			byte[] buf;
			Writer.Write(this.Flags);
			Writer.Write(this.Name);
			if((this.Flags & FileAttributeFlags.Ext) > 0)
			{
				Writer.Write(this.Size);
				Writer.Write(this.Block);
			}
			else
			{
				System.Text.StringBuilder SB = new System.Text.StringBuilder();
				SB.Append(this.Name);
				string AttrName = SB.ToString();
				if (AttrName == Attributes.CreationTimeStr ||
					AttrName == Attributes.LastAccessTimeStr ||
					AttrName == Attributes.LastWriteTimeStr)
				{
					Writer.Write(this.DateTime.ToFileTime());
					dif = 8;
				}
				if (dif > 0)
				{
					buf = new byte[dif];
					Writer.Write(buf);
				}
			}
		}
		public void ReadFromStream(FileStream Stream, BinaryReader Reader)
		{
			System.Text.StringBuilder SB = new System.Text.StringBuilder();
			int dif = 0;
			this.Flags = Reader.ReadInt64();
			this.Name = Reader.ReadChars(8);
			SB.Append(this.Name);
			string AttrName = SB.ToString();
			if((this.Flags & FileAttributeFlags.Ext) > 0)
			{
				this.Size = Reader.ReadInt64();
				this.Block = Reader.ReadInt64();
			}
			else
			{
				if (AttrName == Attributes.CreationTimeStr ||
					AttrName == Attributes.LastAccessTimeStr ||
					AttrName == Attributes.LastWriteTimeStr)
				{
					this.DateTime = DateTime.FromFileTime(Reader.ReadInt64());
					dif = 8;
				}
				if(dif > 0)
					Stream.Seek(dif, SeekOrigin.Current);
			}
		}
	}

	// Описание блока, содержащего часть списка атрибутов
	public class BlockOfAttributeList : IStreamReadWrite
	{
		public Int64 Next;
		public Int64 Prev;
		public Int32 Number;
		public byte[] Reserve = new byte[12];
		public FileAttribute[] FileAttributes;
		public void WriteToStream(FileStream Stream, BinaryWriter Writer)
		{
			Writer.Write(this.Next);
			Writer.Write(this.Prev);
			Writer.Write(this.Number);
			Writer.Write(this.Reserve);
			for(int i = 0; i < this.Number; i++)
				this.FileAttributes[i].WriteToStream(Stream, Writer);
			int dif = 4064 - this.Number * 40;
			byte[] buf = new byte[dif];
			Writer.Write(buf);
		}
		public void ReadFromStream(FileStream Stream, BinaryReader Reader)
		{
			this.Next = Reader.ReadInt64();
			this.Prev = Reader.ReadInt64();
			this.Number = Reader.ReadInt32();
			this.Reserve = Reader.ReadBytes(12);
			this.FileAttributes = new FileAttribute[this.Number];
			for(int i = 0; i < this.Number; i++)
			{
				this.FileAttributes[i] = new FileAttribute();
				this.FileAttributes[i].ReadFromStream(Stream, Reader);
			}
			int dif = 4064 - this.Number * 40;
			Stream.Seek(dif, SeekOrigin.Current);
		}
	}

	// Файловая запись
	public class FileRecord : IStreamReadWrite
	{
		public Int32 SizeOfInternalData;
		public Int32 Flags;
		public Int16 NameLength;
		public char[] Name;
		public byte[] Info = new byte[24];
		public Int64 Block;					// Номер блока начала списка атрибутов
		public byte[] Data;					// Внутрений поток данных
		public void WriteToStream(FileStream Stream, BinaryWriter Writer)
		{
			int dif;
			byte[] buf;
			Writer.Write(this.SizeOfInternalData);
			Writer.Write(this.Flags);
			Writer.Write(this.NameLength);
			Writer.Write(this.Name);
			dif = (255 - this.NameLength) * 2;
			if(dif > 0)
			{
				buf = new byte[dif];
				Writer.Write(buf);
			}
			Writer.Write(this.Info);
			if((this.Flags & FileRecordFlags.Ext) > 0)
			{
				Writer.Write(this.Block);
				dif = 472 - this.SizeOfInternalData;
			}
			else
				dif = 480 - this.SizeOfInternalData;
			if(this.SizeOfInternalData > 0)
				Writer.Write(this.Data);
			if(dif > 0)
			{
				buf = new byte[dif];
				Writer.Write(buf);
			}
		}
		public void ReadFromStream(FileStream Stream, BinaryReader Reader)
		{
			int dif;
			this.SizeOfInternalData = Reader.ReadInt32();
			this.Flags = Reader.ReadInt32();
			this.NameLength = Reader.ReadInt16();
			this.Name = Reader.ReadChars(this.NameLength);
			dif = (255 - this.NameLength) * 2;
			if(dif > 0)
				Stream.Seek(dif, SeekOrigin.Current);
			this.Info = Reader.ReadBytes(24);
			if((this.Flags & FileRecordFlags.Ext) > 0)
			{
				this.Block = Reader.ReadInt64();
				this.Data = Reader.ReadBytes(this.SizeOfInternalData);
				dif = 472 - this.SizeOfInternalData;
			}
			else
			{
				this.Data = Reader.ReadBytes(this.SizeOfInternalData);
				dif = 480 - this.SizeOfInternalData;
			}
			if(dif > 0)
				Stream.Seek(dif, SeekOrigin.Current);
		}
	}

	// Заголовок тома - суперблок
	public class SuperBlock : IStreamReadWrite
	{
		public char[] ID = new char[8];
		public Int32 BlockSize = 4096;
		public Int32 BlocksForSuperBlock = 1;
		public Int64 TotalBlocks;
		public Int64 FreeBlocks;
		public Int64 SizeInBytes;
		public Int64 FreeForUserInBytes;
		public Int64 NextBlockOfSuperBlock = 0;
		public byte[] Reserve1 = new byte[960];
		public FileRecord Root = new FileRecord();
		public byte[] Reserve2 = new byte[2048];
		public void WriteToStream(FileStream Stream, BinaryWriter Writer)
		{
			Writer.Write(this.ID);
			Writer.Write(this.BlockSize);
			Writer.Write(this.BlocksForSuperBlock);
			Writer.Write(this.TotalBlocks);
			Writer.Write(this.FreeBlocks);
			Writer.Write(this.SizeInBytes);
			Writer.Write(this.FreeForUserInBytes);
			Writer.Write(this.NextBlockOfSuperBlock);
			Writer.Write(this.Reserve1);
			this.Root.WriteToStream(Stream, Writer);
			Writer.Write(this.Reserve2);
		}
		public void ReadFromStream(FileStream Stream, BinaryReader Reader)
		{
			this.ID = Reader.ReadChars(8);
			this.BlockSize = Reader.ReadInt32();
			this.BlocksForSuperBlock = Reader.ReadInt32();
			this.TotalBlocks = Reader.ReadInt64();
			this.FreeBlocks = Reader.ReadInt64();
			this.SizeInBytes = Reader.ReadInt64();
			this.FreeForUserInBytes = Reader.ReadInt64();
			this.NextBlockOfSuperBlock = Reader.ReadInt64();
			this.Reserve1 = Reader.ReadBytes(960);
			this.Root.ReadFromStream(Stream, Reader);
			this.Reserve2 = Reader.ReadBytes(2048);
		}
	}

	public class Image
	{
		public FileInfo FileInfo;
		public FileStream Stream;
		public BinaryWriter Writer;
		public BinaryReader Reader;
		public SuperBlock SuperBlock;
		public bool IsLoaded = false;

		public void CreateImage(string RealFilePath, string ID,	Int64 TotalBlocks)
		{
			if(this.IsLoaded == true) this.CloseImage();
			// Создание файла
			this.FileInfo = new FileInfo(RealFilePath);
			this.Stream = new FileStream(RealFilePath, FileMode.Create, FileAccess.ReadWrite);
			this.Writer = new BinaryWriter(Stream, System.Text.Encoding.Unicode);
			this.Reader = new BinaryReader(Stream, System.Text.Encoding.Unicode);
						
			// Заполнение суперблока
			this.SuperBlock = new SuperBlock();
			this.SuperBlock.ID = ID.ToCharArray();
			this.SuperBlock.BlockSize = 4096;
			this.SuperBlock.BlocksForSuperBlock = 1;
			this.SuperBlock.TotalBlocks = TotalBlocks;
			this.SuperBlock.FreeBlocks = TotalBlocks - 1;
			this.SuperBlock.SizeInBytes = 4096 * TotalBlocks;
			this.SuperBlock.FreeForUserInBytes = 4096 * (TotalBlocks - 1);
			this.SuperBlock.NextBlockOfSuperBlock = 0;
			this.SuperBlock.Reserve1 = new byte[960];
			this.SuperBlock.Root = new FileRecord();
			this.SuperBlock.Reserve2 = new byte[2048];
						
			// Заполнение файловой записи корневого каталога
			this.SuperBlock.Root.SizeOfInternalData = 0;
			this.SuperBlock.Root.Flags = FileRecordFlags.Dir | FileRecordFlags.Ext | FileRecordFlags.Use;
			this.SuperBlock.Root.NameLength = (Int16) "$root".Length;
			this.SuperBlock.Root.Name = "$root".ToCharArray();
			this.SuperBlock.Root.Info = new byte[24];
			this.SuperBlock.Root.Block = 1;
			this.SuperBlock.Root.Data = new byte[472];
			this.SuperBlock.WriteToStream(this.Stream, this.Writer);
			
			// Заполнение блока со списком атрибутов корневого каталога
			this.SuperBlock.FreeBlocks--;
			this.SuperBlock.FreeForUserInBytes -= 4096;
			BlockOfAttributeList bal = new BlockOfAttributeList();
			bal.Next = 0;
			bal.Prev = 0;
			bal.Number = 1;
			bal.Reserve = new byte[12];
			bal.FileAttributes = new FileAttribute[1];
			bal.FileAttributes[0] = new FileAttribute();
			bal.FileAttributes[0].Flags =
				FileAttributeFlags.Ser | FileAttributeFlags.Ext | FileAttributeFlags.Use;
			bal.FileAttributes[0].Name = Attributes.Data;
			bal.FileAttributes[0].Size = 1024;
			bal.FileAttributes[0].Block = 2;
			bal.WriteToStream(this.Stream, this.Writer);
			
			// Заполнение блока со списком серий тех блоков, в которых находятся данные корневого каталога
			this.SuperBlock.FreeBlocks--;
			this.SuperBlock.FreeForUserInBytes -= 4096;
			BlockOfSeriesList bsl = new BlockOfSeriesList();
			bsl.Next = 0;
			bsl.Prev = 0;
			bsl.Number = 1;
			bsl.Reserve = new byte[12];
			bsl.SeriesArray = new BlockSeries[1];
			bsl.SeriesArray[0] = new BlockSeries();
			bsl.SeriesArray[0].FirstBlock = 3;
			bsl.SeriesArray[0].Blocks = 1;
			bsl.WriteToStream(this.Stream, this.Writer);

			// Заполнение блока, в котором находятся данные корневого каталога
			this.SuperBlock.FreeBlocks--;
			this.SuperBlock.FreeForUserInBytes -= 4096;
			FileRecord fr = new FileRecord();
			fr.SizeOfInternalData = 0;
			fr.Flags = FileRecordFlags.Ext | FileRecordFlags.Use;
			fr.NameLength = (Int16) "$free_blocks_list".Length;
			fr.Name = "$free_blocks_list".ToCharArray();
			fr.Info = new byte[24];
			fr.Block = 4;
			fr.Data = new byte[472];
			fr.WriteToStream(this.Stream, this.Writer);
			byte[] buf = new byte[3072];
			this.Writer.Write(buf);
            
			// Заполнение блока, в котором находится список атрибутов файла "$free_blocks_list"
			this.SuperBlock.FreeBlocks--;
			this.SuperBlock.FreeForUserInBytes -= 4096;
			bal = new BlockOfAttributeList();
			bal.Next = 0;
			bal.Prev = 0;
			bal.Number = 1;
			bal.Reserve = new byte[12];
			bal.FileAttributes = new FileAttribute[1];
			bal.FileAttributes[0] = new FileAttribute();
			bal.FileAttributes[0].Flags =
				FileAttributeFlags.Ser | FileAttributeFlags.Ext | FileAttributeFlags.Use;
			bal.FileAttributes[0].Name = Attributes.Data;
			bal.FileAttributes[0].Size = 0;
			bal.FileAttributes[0].Block = 5;
			bal.WriteToStream(this.Stream, this.Writer);

			// Заполнение блока со списком свободных серий
			this.SuperBlock.FreeBlocks--;
			this.SuperBlock.FreeForUserInBytes -= 4096;
			bsl = new BlockOfSeriesList();
			bsl.Next = 0;
			bsl.Prev = 0;
			bsl.Number = 1;
			bsl.Reserve = new byte[12];
			bsl.SeriesArray = new BlockSeries[1];
			bsl.SeriesArray[0] = new BlockSeries();
			bsl.SeriesArray[0].FirstBlock = 6;
			bsl.SeriesArray[0].Blocks = TotalBlocks - 6;
			bsl.WriteToStream(this.Stream, this.Writer);

			// Запись оставшейся части файла образа
			buf = new byte[4096];
			for(int i = 0; i < TotalBlocks - 6; i++)
				this.Writer.Write(buf);

			// Запись изменений о свободной памяти
			this.Stream.Position = 0;
			this.SuperBlock.WriteToStream(this.Stream, this.Writer);
			this.IsLoaded = true;
		}
		public void OpenImage(string RealFilePath)
		{
			if(this.IsLoaded == true) this.CloseImage();
			this.FileInfo = new FileInfo(RealFilePath);
			this.Stream = new FileStream(RealFilePath, FileMode.Open, FileAccess.ReadWrite);
			this.Writer = new BinaryWriter(Stream, System.Text.Encoding.Unicode);
			this.Reader = new BinaryReader(Stream, System.Text.Encoding.Unicode);
			
			this.SuperBlock = new SuperBlock();
			this.SuperBlock.Root = new FileRecord();
			this.SuperBlock.ReadFromStream(this.Stream, this.Reader);
			this.IsLoaded = true;
		}
		private void CreateFileRecord(FileRecord Rec, FileRecord Parent)
		{
			BlockOfAttributeList bal = new BlockOfAttributeList();
			BlockOfSeriesList bsl = new BlockOfSeriesList();
			BlockSeries bs = new BlockSeries();
			FileRecord fr = new FileRecord();
			Int64 OffsetInBlocks, Size, OldPosition = this.Stream.Position;

			OffsetInBlocks = Parent.Block;
			this.Stream.Position = OffsetInBlocks * 4096;
			bal.ReadFromStream(this.Stream, this.Reader);
			Size = bal.FileAttributes[0].Size;
			
			// каталог пустой
			if(Size == 0)
			{
				bal.FileAttributes[0].Block = this.AllocateBlock();
				bal.FileAttributes[0].Size = 1024;
				OffsetInBlocks = Parent.Block;
				this.Stream.Position = OffsetInBlocks * 4096;
				bal.WriteToStream(this.Stream, this.Writer);
				OffsetInBlocks = bal.FileAttributes[0].Block;
				this.Stream.Position = OffsetInBlocks * 4096;
				bsl.Prev = 0;
				bsl.Number = 1;
				bsl.Next = 0;
				bsl.SeriesArray = new BlockSeries[1];
				bsl.SeriesArray[0] = new BlockSeries();
				bsl.SeriesArray[0].FirstBlock = this.AllocateBlock();
				bsl.SeriesArray[0].Blocks = 1;
				bsl.WriteToStream(this.Stream, this.Writer);
				OffsetInBlocks = bsl.SeriesArray[0].FirstBlock;
				this.Stream.Position = OffsetInBlocks * 4096;
				Rec.WriteToStream(this.Stream, this.Writer);
				this.Stream.Position = OldPosition;
				return;
			}
			
			// попытка найти удаленную запись
			OffsetInBlocks = bal.FileAttributes[0].Block;
			this.Stream.Position = OffsetInBlocks * 4096;
			bsl.ReadFromStream(this.Stream, this.Reader);
			
			int LastBlockLength;
			if(Size % 4096 == 0) LastBlockLength = 4;
			else LastBlockLength = (int) (Size % 4096) / 1024;
			while(true)
			{
				for(int i = 0; i < bsl.Number; i++)
				{
					OffsetInBlocks = bsl.SeriesArray[i].FirstBlock;
					this.Stream.Position = OffsetInBlocks * 4096;
					for(int j = 0; j < bsl.SeriesArray[i].Blocks; j++)
					{
						int tmp;
						if(i == bsl.Number - 1 && j == bsl.SeriesArray[i].Blocks - 1 && bsl.Next == 0)
							tmp = LastBlockLength;
						else tmp = 4;
						for(int k = 0; k < tmp; k++)
						{
							fr.ReadFromStream(this.Stream, this.Reader);
							if((fr.Flags & FileRecordFlags.Use) == 0)
							{
								this.Stream.Seek(-1024, SeekOrigin.Current);
								Rec.WriteToStream(this.Stream, this.Writer);
								this.Stream.Position = OldPosition;
								return;
							}
						}
					}
				}
				if(bsl.Next == 0) break;
				OffsetInBlocks = bsl.Next;
				this.Stream.Position = OffsetInBlocks * 4096;
				bsl.ReadFromStream(this.Stream, this.Reader);
			}
			
			// попытка добавить запись в последний блок
			if(Size % 4096 != 0)
			{
				Rec.WriteToStream(this.Stream, this.Writer);
				bal.FileAttributes[0].Size += 1024;
				OffsetInBlocks = Parent.Block;
				this.Stream.Position = OffsetInBlocks * 4096;
				bal.WriteToStream(this.Stream, this.Writer);
				this.Stream.Position = OldPosition;
				return;
			}

			// создание блока
			bs.FirstBlock = this.AllocateBlock();
			bs.Blocks = 1;
			this.AddToSeriesList(bal.FileAttributes[0].Block, bs);
			bal.FileAttributes[0].Size += 1024;
			OffsetInBlocks = Parent.Block;
			this.Stream.Position = OffsetInBlocks * 4096;
			bal.WriteToStream(this.Stream, this.Writer);
			OffsetInBlocks = bs.FirstBlock;
			this.Stream.Position = OffsetInBlocks * 4096;
			Rec.WriteToStream(this.Stream, this.Writer);
			this.Stream.Position = OldPosition;
			return;
		}
		public void CreateFile(string RealFilePath, string[] Path)
		{
			BlockOfAttributeList bal = new BlockOfAttributeList();
			BlockOfSeriesList bsl = new BlockOfSeriesList();
			BlockSeries bs = new BlockSeries();
			FileRecord fr = new FileRecord();
			Int64 OffsetInBlocks;
			FileInfo RealFileInfo;
			FileStream RealFileStream;
			BinaryReader RealFileReader;
			RealFileInfo = new FileInfo(RealFilePath);
			RealFileStream = new FileStream(RealFilePath, FileMode.Open, FileAccess.Read);
			RealFileReader = new BinaryReader(RealFileStream);

			this.Stream.Position = this.FindPositionOfFileRecord(Path);
			FileRecord Parent = new FileRecord();
			Parent.ReadFromStream(this.Stream, this.Reader);

			// Примерная оценка расходов на хранение файла
			if(RealFileInfo.Length + 10 * 4096 > this.SuperBlock.FreeForUserInBytes)
			{
				RealFileStream.Close();
				RealFileReader.Close();
				throw new System.Exception("Недостаточно места в образе тома.");
			}

			// Если файл маленький
			if(RealFileInfo.Length <= 472)
			{
				fr.SizeOfInternalData = (Int32) RealFileInfo.Length;
				fr.Flags = FileRecordFlags.Ext | FileRecordFlags.Use;
				fr.NameLength = (Int16) RealFileInfo.Name.Length;
				fr.Name = RealFileInfo.Name.ToCharArray();
				fr.Info = new byte[24];
				fr.Block = this.AllocateBlock();
				fr.Data = RealFileReader.ReadBytes((Int32) RealFileInfo.Length);
				this.CreateFileRecord(fr, Parent);
				OffsetInBlocks = fr.Block;
				this.Stream.Position = OffsetInBlocks * 4096;
				bal = this.SetUpFileAttributes(RealFileInfo, 0);
				bal.WriteToStream(this.Stream, this.Writer);
			}

			// Если файл помещается в одном блоке
			if(RealFileInfo.Length > 472 && RealFileInfo.Length <= 472 + 4096)
			{
				fr.SizeOfInternalData = 472;
				fr.Flags = FileRecordFlags.Ext | FileRecordFlags.Use;
				fr.NameLength = (Int16) RealFileInfo.Name.Length;
				fr.Name = RealFileInfo.Name.ToCharArray();
				fr.Info = new byte[24];
				fr.Block = this.AllocateBlock();
				fr.Data = RealFileReader.ReadBytes(472);
				this.CreateFileRecord(fr, Parent);
				OffsetInBlocks = fr.Block;
				this.Stream.Position = OffsetInBlocks * 4096;
				bal = this.SetUpFileAttributes(RealFileInfo, this.AllocateBlock());
				bal.WriteToStream(this.Stream, this.Writer);
				OffsetInBlocks = bal.FileAttributes[0].Block;
				this.Stream.Position = OffsetInBlocks * 4096;
				byte[] buf = RealFileReader.ReadBytes((Int32) RealFileInfo.Length - 472);
				this.Writer.Write(buf);
			}

			// Для обычного файла
			if(RealFileInfo.Length > 472 + 4096)
			{
				fr.SizeOfInternalData = 472;
				fr.Flags = FileRecordFlags.Ext | FileRecordFlags.Use;
				fr.NameLength = (Int16) RealFileInfo.Name.Length;
				fr.Name = RealFileInfo.Name.ToCharArray();
				fr.Info = new byte[24];
				fr.Block = this.AllocateBlock();
				fr.Data = RealFileReader.ReadBytes(472);
				this.CreateFileRecord(fr, Parent);
				OffsetInBlocks = fr.Block;
				this.Stream.Position = OffsetInBlocks * 4096;
				bal = this.SetUpFileAttributes(RealFileInfo, this.AllocateBlock());
				bal.WriteToStream(this.Stream, this.Writer);
				OffsetInBlocks = bal.FileAttributes[0].Block;
				this.Stream.Position = OffsetInBlocks * 4096;

				Int64 AllocSize;
				if((RealFileInfo.Length - 472 ) % 4096 == 0)
					AllocSize = (RealFileInfo.Length - 472) / 4096;
				else AllocSize = (RealFileInfo.Length - 472) / 4096 + 1;
				BlockSeries[] bsArray = this.AllocateMemory(AllocSize);
				Int64 Next, Prev = 0, Blocks;
				if(bsArray.Length % 254 == 0) Blocks = bsArray.Length / 254;
				else Blocks = bsArray.Length / 254 + 1;
				for(int i = 0; i < Blocks; i++)
				{
					int Num;
					if(i < Blocks - 1)
					{
						Num = 254;
						Next = this.AllocateBlock();
					}
					else
					{
						Num = bsArray.Length % 254;
						if(Num == 0) Num = 254;
						Next = 0;
					}
					bsl.Prev = Prev;
					Prev = this.Stream.Position / 4096;
					bsl.Number = Num;
					bsl.Next = Next;
					bsl.SeriesArray = new BlockSeries[Num];
					for(int j = 0; j < Num; j++)
						bsl.SeriesArray[j] = bsArray[i * 254 + j];
					bsl.WriteToStream(this.Stream, this.Writer);

					int LastBlockLength;
					if((RealFileInfo.Length - 472) % 4096 == 0)	LastBlockLength = 4096;
					else LastBlockLength = (int) (RealFileInfo.Length - 472) % 4096;
					for(int j = 0; j < Num; j++)
					{
						OffsetInBlocks = bsl.SeriesArray[j].FirstBlock;
						this.Stream.Position = OffsetInBlocks * 4096;
						for(int k = 0; k < bsl.SeriesArray[j].Blocks; k++)
						{
							int Bytes;
							if(i == Blocks - 1 && j == Num - 1 && k == bsl.SeriesArray[j].Blocks - 1)
								Bytes = LastBlockLength;
							else Bytes = 4096;
							byte[] buf = RealFileReader.ReadBytes(Bytes);
							this.Writer.Write(buf);
						}
					}
					OffsetInBlocks = bsl.Next;
					this.Stream.Position = OffsetInBlocks * 4096;
				}
			}
			RealFileStream.Close();
			RealFileReader.Close();
		}
		public void ReadFile(string RealFilePath, string[] Path)
		{
			BlockOfAttributeList bal = new BlockOfAttributeList();
			BlockOfSeriesList bsl = new BlockOfSeriesList();
			BlockSeries bs = new BlockSeries();
			FileRecord fr = new FileRecord();
			Int64 OffsetInBlocks;

			FileInfo RealFileInfo = new FileInfo(RealFilePath);
			FileStream RealFileStream = new FileStream(RealFilePath, FileMode.Create, FileAccess.Write);
			BinaryWriter RealFileWriter = new BinaryWriter(RealFileStream);

			this.Stream.Position = this.FindPositionOfFileRecord(Path);
			FileRecord FileRec = new FileRecord();
			FileRec.ReadFromStream(this.Stream, this.Reader);

			// Чтение внутренних данных
			RealFileWriter.Write(FileRec.Data);
			OffsetInBlocks = FileRec.Block;
			this.Stream.Position = OffsetInBlocks * 4096;
			bal.ReadFromStream(this.Stream, this.Reader);
            
			// Установка атрибутов файла

			// Если файл в одном блоке
			if((bal.FileAttributes[0].Flags & FileAttributeFlags.Ser) == 0 &&
				(bal.FileAttributes[0].Flags & FileAttributeFlags.Ext) > 0)
			{
				OffsetInBlocks = bal.FileAttributes[0].Block;
				this.Stream.Position = OffsetInBlocks * 4096;
				byte[] buf = this.Reader.ReadBytes((Int32) bal.FileAttributes[0].Size);
				RealFileWriter.Write(buf);
				return;
			}
            
			// Если файл в серии блоков
			if((bal.FileAttributes[0].Flags & FileAttributeFlags.Ser) > 0 &&
				(bal.FileAttributes[0].Flags & FileAttributeFlags.Ext) > 0)
			{
				OffsetInBlocks = bal.FileAttributes[0].Block;
				this.Stream.Position = OffsetInBlocks * 4096;
				bsl.ReadFromStream(this.Stream, this.Reader);
				
				int LastBlockLength;
				if(bal.FileAttributes[0].Size % 4096 == 0) LastBlockLength = 4096;
				else LastBlockLength = (int) bal.FileAttributes[0].Size % 4096;
				while(true)
				{
					for(int i = 0; i < bsl.Number; i++)
					{
						OffsetInBlocks = bsl.SeriesArray[i].FirstBlock;
						for(int j = 0; j < bsl.SeriesArray[i].Blocks; j++)
						{
							int Bytes;
							if(i == bsl.Number - 1 && j == bsl.SeriesArray[i].Blocks - 1 && bsl.Next == 0)
								Bytes = LastBlockLength;
							else Bytes = 4096;
							byte[] buf = this.Reader.ReadBytes(Bytes);
							RealFileWriter.Write(buf);
						}
					}
					if(bsl.Next == 0) break;
					OffsetInBlocks = bsl.Next;
					this.Stream.Position = OffsetInBlocks * 4096;
					bsl.ReadFromStream(this.Stream, this.Reader);
				}
			}
			RealFileStream.Close();
			RealFileWriter.Close();
		}
		private BlockSeries[] AllocateMemory(Int64 SizeInBlocks)
		{
			BlockSeries bs;
			ArrayList Result = new ArrayList();
			BlockSeries[] res;
			BlockOfAttributeList bal = new BlockOfAttributeList();
			BlockOfSeriesList bsl = new BlockOfSeriesList();
			FileRecord fr = new FileRecord();
			Int64 OffsetInBlocks, OldPosition = this.Stream.Position;
			
			this.SuperBlock.FreeBlocks -= SizeInBlocks;
			this.SuperBlock.FreeForUserInBytes -= SizeInBlocks * 4096;
			this.Stream.Position = 0;
			this.SuperBlock.WriteToStream(this.Stream, this.Writer);
			
			// Работа с файлом "root" - поиск файла "free_blocks_list"
			OffsetInBlocks = SuperBlock.Root.Block;
			this.Stream.Position = OffsetInBlocks * 4096;
			bal.ReadFromStream(this.Stream, this.Reader);
			OffsetInBlocks = bal.FileAttributes[0].Block;
			this.Stream.Position = OffsetInBlocks * 4096;
			bsl.ReadFromStream(this.Stream, this.Reader);
			OffsetInBlocks = bsl.SeriesArray[0].FirstBlock;
			this.Stream.Position = OffsetInBlocks * 4096;
            
			// Работа с файлом "free_blocks_list"
			fr.ReadFromStream(this.Stream, this.Reader);
			OffsetInBlocks = fr.Block;
			this.Stream.Position = OffsetInBlocks * 4096;
			bal.ReadFromStream(this.Stream, this.Reader);
			OffsetInBlocks = bal.FileAttributes[0].Block;
			this.Stream.Position = OffsetInBlocks * 4096;
			bsl.ReadFromStream(this.Stream, this.Reader);
			while(true)
			{
				for(int i = 0; i < bsl.Number; i++)
				{
					if (bsl.SeriesArray[i].Blocks >= SizeInBlocks)
					{
						bs = new BlockSeries();
						bs.FirstBlock = bsl.SeriesArray[i].FirstBlock;
						bs.Blocks = SizeInBlocks;
						Result.Add(bs);
						if(bsl.SeriesArray[i].Blocks == SizeInBlocks)
						{
							bsl.SeriesArray[i].FirstBlock = 0;
							bsl.SeriesArray[i].Blocks = 0;
						}
						else
						{
							bsl.SeriesArray[i].FirstBlock += SizeInBlocks;
							bsl.SeriesArray[i].Blocks -= SizeInBlocks;
						}
						SizeInBlocks = 0;
						break;
					}
					else
					{
						bs = new BlockSeries();
						bs.FirstBlock = bsl.SeriesArray[i].FirstBlock;
						bs.Blocks = bsl.SeriesArray[i].Blocks;
						Result.Add(bs);
						bsl.SeriesArray[i].FirstBlock = 0;
						bsl.SeriesArray[i].Blocks = 0;
						SizeInBlocks -= bs.Blocks;
					}
				}
				this.Stream.Seek(-4096, SeekOrigin.Current);
				bsl.WriteToStream(this.Stream, this.Writer);
				if(SizeInBlocks == 0) break;
				OffsetInBlocks = bsl.Next;
				this.Stream.Position = OffsetInBlocks * 4096;
				bsl.ReadFromStream(this.Stream, this.Reader);
			}
			
			Result.TrimToSize();
			res = new BlockSeries[Result.Count];
			Result.CopyTo(0, res, 0, Result.Count);
			this.Stream.Position = OldPosition;
			return res;
		}
		private Int64 AllocateBlock()
		{
			bool Allocated = false;
			Int64 Result = 0;
			BlockOfAttributeList bal = new BlockOfAttributeList();
			BlockOfSeriesList bsl = new BlockOfSeriesList();
			FileRecord fr = new FileRecord();
			Int64 OffsetInBlocks, OldPosition = this.Stream.Position;
			
			this.SuperBlock.FreeBlocks --;
			this.SuperBlock.FreeForUserInBytes -= 4096;
			this.Stream.Position = 0;
			this.SuperBlock.WriteToStream(this.Stream, this.Writer);

			// Работа с файлом "root" - поиск файла "free_blocks_list"
			OffsetInBlocks = SuperBlock.Root.Block;
			this.Stream.Position = OffsetInBlocks * 4096;
			bal.ReadFromStream(this.Stream, this.Reader);
			OffsetInBlocks = bal.FileAttributes[0].Block;
			this.Stream.Position = OffsetInBlocks * 4096;
			bsl.ReadFromStream(this.Stream, this.Reader);
			OffsetInBlocks = bsl.SeriesArray[0].FirstBlock;
			this.Stream.Position = OffsetInBlocks * 4096;
            
			// Работа с файлом "free_blocks_list"
			fr.ReadFromStream(this.Stream, this.Reader);
			OffsetInBlocks = fr.Block;
			this.Stream.Position = OffsetInBlocks * 4096;
			bal.ReadFromStream(this.Stream, this.Reader);
			OffsetInBlocks = bal.FileAttributes[0].Block;
			this.Stream.Position = OffsetInBlocks * 4096;
			bsl.ReadFromStream(this.Stream, this.Reader);
			while(true)
			{
				for(int i = 0; i < bsl.Number; i++)
				{
					if(bsl.SeriesArray[i].Blocks == 1)
					{
						Result = bsl.SeriesArray[i].FirstBlock;
						bsl.SeriesArray[i].FirstBlock = 0;
						bsl.SeriesArray[i].Blocks = 0;
						Allocated = true;
						break;
					}
					if(bsl.SeriesArray[i].Blocks > 1)
					{
						Result = bsl.SeriesArray[i].FirstBlock;
						bsl.SeriesArray[i].FirstBlock++;
						bsl.SeriesArray[i].Blocks--;
						Allocated = true;
						break;
					}
				}
				if(Allocated == true) break;
				OffsetInBlocks = bsl.Next;
				this.Stream.Position = OffsetInBlocks * 4096;
				bsl.ReadFromStream(this.Stream, this.Reader);
			}
			this.Stream.Seek(-4096, SeekOrigin.Current);
			bsl.WriteToStream(this.Stream, this.Writer);
			this.Stream.Position = OldPosition;
			return Result;
		}
		private void FreeBlock(Int64 Num)
		{
			BlockOfAttributeList bal = new BlockOfAttributeList();
			BlockOfSeriesList bsl = new BlockOfSeriesList();
			BlockSeries bs = new BlockSeries();
			FileRecord fr = new FileRecord();
			Int64 OffsetInBlocks, OldPosition = this.Stream.Position;
			
			this.SuperBlock.FreeBlocks++;
			this.SuperBlock.FreeForUserInBytes += 4096;
			this.Stream.Position = 0;
			this.SuperBlock.WriteToStream(this.Stream, this.Writer);

			// Работа с файлом "root" - поиск файла "free_blocks_list"
			OffsetInBlocks = SuperBlock.Root.Block;
			this.Stream.Position = OffsetInBlocks * 4096;
			bal.ReadFromStream(this.Stream, this.Reader);
			OffsetInBlocks = bal.FileAttributes[0].Block;
			this.Stream.Position = OffsetInBlocks * 4096;
			bsl.ReadFromStream(this.Stream, this.Reader);
			OffsetInBlocks = bsl.SeriesArray[0].FirstBlock;
			this.Stream.Position = OffsetInBlocks * 4096;
            
			// Работа с файлом "free_blocks_list"
			fr.ReadFromStream(this.Stream, this.Reader);
			OffsetInBlocks = fr.Block;
			this.Stream.Position = OffsetInBlocks * 4096;
			bal.ReadFromStream(this.Stream, this.Reader);
			bs.FirstBlock = Num;
			bs.Blocks = 1;
			this.AddToSeriesList(bal.FileAttributes[0].Block, bs);
			this.Stream.Position = OldPosition;
		}
		private void FreeMemory(BlockSeries[] Series)
		{
			BlockOfAttributeList bal = new BlockOfAttributeList();
			BlockOfSeriesList bsl = new BlockOfSeriesList();
			BlockSeries bs = new BlockSeries();
			FileRecord fr = new FileRecord();
			Int64 OffsetInBlocks, OldPosition = this.Stream.Position;

			// Работа с файлом "root" - поиск файла "free_blocks_list"
			OffsetInBlocks = SuperBlock.Root.Block;
			this.Stream.Position = OffsetInBlocks * 4096;
			bal.ReadFromStream(this.Stream, this.Reader);
			OffsetInBlocks = bal.FileAttributes[0].Block;
			this.Stream.Position = OffsetInBlocks * 4096;
			bsl.ReadFromStream(this.Stream, this.Reader);
			OffsetInBlocks = bsl.SeriesArray[0].FirstBlock;
			this.Stream.Position = OffsetInBlocks * 4096;

			// Работа с файлом "free_blocks_list"
			fr.ReadFromStream(this.Stream, this.Reader);
			OffsetInBlocks = fr.Block;
			this.Stream.Position = OffsetInBlocks * 4096;
			bal.ReadFromStream(this.Stream, this.Reader);
			for(int i = 0; i < Series.Length; i++)
			{
				this.AddToSeriesList(bal.FileAttributes[0].Block, Series[i]);
				this.SuperBlock.FreeBlocks += Series[i].Blocks;
				this.SuperBlock.FreeForUserInBytes += Series[i].Blocks * 4096;
			}
			this.Stream.Position = 0;
			this.SuperBlock.WriteToStream(this.Stream, this.Writer);
			this.Stream.Position = OldPosition;
		}
		private void AddToSeriesList(Int64 StartBlock, BlockSeries Ser)
		{
			bool Add = false;
			BlockOfSeriesList bsl = new BlockOfSeriesList();
			Int64 OffsetInBlocks, OldPosition = this.Stream.Position;
			
			OffsetInBlocks = StartBlock;
			this.Stream.Position = OffsetInBlocks * 4096;
			bsl.ReadFromStream(this.Stream, this.Reader);
			while(true)
			{
				// попытка "увеличения" серии
				for(int i = 0; i < bsl.Number; i++)
				{
					if(Ser.FirstBlock + Ser.Blocks == bsl.SeriesArray[i].FirstBlock)
					{
						bsl.SeriesArray[i].FirstBlock -= Ser.Blocks;
						bsl.SeriesArray[i].Blocks += Ser.Blocks;
						Add = true;
						break;
					}
					if(Ser.FirstBlock == bsl.SeriesArray[i].FirstBlock + bsl.SeriesArray[i].Blocks)
					{
						bsl.SeriesArray[i].Blocks += Ser.Blocks;
						Add = true;
						break;
					}
				}
				if(Add == true) break;
					
				// попытка вставки в пустое место
				for(int i = 0; i < bsl.Number; i++)
				{
					if(bsl.SeriesArray[i].FirstBlock == 0 && bsl.SeriesArray[i].Blocks == 0)
					{
						bsl.SeriesArray[i].FirstBlock = Ser.FirstBlock;
						bsl.SeriesArray[i].Blocks = Ser.Blocks;
						Add = true;
						break;
					}
				}
				if(Add == true) break;

				// увеличение количества записей в блоке
				if(bsl.Number < 254)
				{
					BlockSeries[] tmp = new BlockSeries[bsl.Number + 1];
					tmp[bsl.Number] = new BlockSeries();
					tmp[bsl.Number].FirstBlock = Ser.FirstBlock;
					tmp[bsl.Number].Blocks = Ser.Blocks;
					bsl.SeriesArray.CopyTo(tmp, 0);
					bsl.Number++;
					bsl.SeriesArray = tmp;
					Add = true;
				}
				if(Add == true) break;
				if(bsl.Next == 0) break;
				OffsetInBlocks = bsl.Next;
				this.Stream.Position = OffsetInBlocks * 4096;
				bsl.ReadFromStream(this.Stream, this.Reader);
			}
			if(Add == true)
			{
				this.Stream.Seek(-4096, SeekOrigin.Current);
				bsl.WriteToStream(this.Stream, this.Writer);
			}

				// увеличение количества блоков
			else
			{
				Int64 Prev = this.Stream.Position / 4096;
				bsl.Next = AllocateBlock();
				this.Stream.Seek(-4096, SeekOrigin.Current);
				bsl.WriteToStream(this.Stream, this.Writer);
				OffsetInBlocks = bsl.Next;
				this.Stream.Position = OffsetInBlocks * 4096;
				bsl.Prev = Prev;
				bsl.Next = 0;
				bsl.Number = 1;
				bsl.SeriesArray = new BlockSeries[1];
				bsl.SeriesArray[0] = new BlockSeries();
				bsl.SeriesArray[0].FirstBlock = Ser.FirstBlock;
				bsl.SeriesArray[0].Blocks = Ser.Blocks;
				bsl.WriteToStream(this.Stream, this.Writer);
			}
			this.Stream.Position = OldPosition;
		}
		private BlockOfAttributeList SetUpFileAttributes(FileInfo fi, Int64 Block)
		{
			Int64 Size = 0, Flags = 0;
			BlockOfAttributeList bal = new BlockOfAttributeList();
			if(fi.Length <= 472)
			{
				Size = 0;
				Flags = FileAttributeFlags.Use;
			}
			if(fi.Length > 472 && fi.Length <= 472 + 4096)
			{
				Size = fi.Length - 472;
				Flags = FileAttributeFlags.Ext | FileAttributeFlags.Use;
			}
			if(fi.Length > 472 + 4096)
			{
				Size = fi.Length - 472;
				Flags = FileAttributeFlags.Ser | FileAttributeFlags.Ext | FileAttributeFlags.Use;
			}
			bal.Next = 0;
			bal.Prev = 0;
			bal.Number = 4;
			bal.Reserve = new byte[12];
			bal.FileAttributes = new FileAttribute[4];
			bal.FileAttributes[0] = new FileAttribute();
			bal.FileAttributes[0].Flags = Flags;
			bal.FileAttributes[0].Name = Attributes.Data;
			bal.FileAttributes[0].Size = Size;
			bal.FileAttributes[0].Block = Block;
			bal.FileAttributes[1] = new FileAttribute();
			bal.FileAttributes[1].Flags = FileAttributeFlags.Use;
			bal.FileAttributes[1].Name = Attributes.CreationTime;
			bal.FileAttributes[1].DateTime = fi.CreationTime;
			bal.FileAttributes[2] = new FileAttribute();
			bal.FileAttributes[2].Flags = FileAttributeFlags.Use;
			bal.FileAttributes[2].Name = Attributes.LastAccessTime;
			bal.FileAttributes[2].DateTime = fi.LastAccessTime;
			bal.FileAttributes[3] = new FileAttribute();
			bal.FileAttributes[3].Flags = FileAttributeFlags.Use;
			bal.FileAttributes[3].Name = Attributes.LastWriteTime;
			bal.FileAttributes[3].DateTime = fi.LastWriteTime;
			return bal;
		}
		public Int64 FindPositionOfFileRecord(string[] Path)
		{
			BlockOfAttributeList bal = new BlockOfAttributeList();
			BlockOfSeriesList bsl = new BlockOfSeriesList();
			FileRecord fr = new FileRecord();
			Int64 OffsetInBlocks, OldPosition = this.Stream.Position, Size;
            
			if(Path.Length == 0 || Path[0] != "$root")
			{
				this.Stream.Position = OldPosition;
				return -1;
			}
			if(Path.Length == 1) return 1024;
			for(int i = 1; i < Path.Length; i++)
			{
				bool Found = false;
				char[] PathToChar = Path[i].ToCharArray();
				if(i == 1) OffsetInBlocks = this.SuperBlock.Root.Block;
				else OffsetInBlocks = fr.Block;
				this.Stream.Position = OffsetInBlocks * 4096;
				bal.ReadFromStream(this.Stream, this.Reader);
				Size = bal.FileAttributes[0].Size;
				if(Size == 0)
				{
					this.Stream.Position = OldPosition;
					return -1;
				}
				OffsetInBlocks = bal.FileAttributes[0].Block;
				this.Stream.Position = OffsetInBlocks * 4096;
				bsl.ReadFromStream(this.Stream, this.Reader);
				
				int LastBlockLength;
				if(Size % 4096 == 0) LastBlockLength = 4;
				else LastBlockLength = (int) (Size % 4096) / 1024;
				while(true)
				{
					for(int j = 0; j < bsl.Number; j++)
					{
						OffsetInBlocks = bsl.SeriesArray[j].FirstBlock;
						this.Stream.Position = OffsetInBlocks * 4096;
						for(int k = 0; k < bsl.SeriesArray[j].Blocks; k++)
						{
							int tmp;
							if(j == bsl.Number - 1 && k == bsl.SeriesArray[j].Blocks - 1 && bsl.Next == 0)
								tmp = LastBlockLength;
							else tmp = 4;
							System.Text.StringBuilder SB = new System.Text.StringBuilder();
							for(int l = 0; l < tmp; l++)
							{
								fr.ReadFromStream(this.Stream, this.Reader);
								if((fr.Flags & FileRecordFlags.Use) == 0) continue;
								SB.Append(fr.Name);
								if(Path[i] == SB.ToString())
								{
									Found = true;
									break;
								}
								SB.Remove(0, SB.Length);
							}
							if(Found == true) break;
						}
						if(Found == true) break;
					}
					if(Found == true) break;
					if(bsl.Next == 0) break;
					OffsetInBlocks = bsl.Next;
					this.Stream.Position = OffsetInBlocks * 4096;
					bsl.ReadFromStream(this.Stream, this.Reader);
				}
				if(Found == false)
				{
					this.Stream.Position = OldPosition;
					return -1;
				}
			}
			Int64 Res = this.Stream.Position - 1024;
			this.Stream.Position = OldPosition;
			return Res;
		}
		public BlockSeries[] GetFreeBlockSeries()
		{
			ArrayList Result = new ArrayList();
			BlockSeries[] res;
			BlockOfAttributeList bal = new BlockOfAttributeList();
			BlockOfSeriesList bsl = new BlockOfSeriesList();
			FileRecord fr = new FileRecord();
			Int64 OffsetInBlocks, OldPosition = this.Stream.Position;
			
			// Работа с файлом "root" - поиск файла "free_blocks_list"
			OffsetInBlocks = SuperBlock.Root.Block;
			this.Stream.Position = OffsetInBlocks * 4096;
			bal.ReadFromStream(this.Stream, this.Reader);
			OffsetInBlocks = bal.FileAttributes[0].Block;
			this.Stream.Position = OffsetInBlocks * 4096;
			bsl.ReadFromStream(this.Stream, this.Reader);
			OffsetInBlocks = bsl.SeriesArray[0].FirstBlock;
			this.Stream.Position = OffsetInBlocks * 4096;
            
			// Работа с файлом "free_blocks_list"
			fr.ReadFromStream(this.Stream, this.Reader);
			OffsetInBlocks = fr.Block;
			this.Stream.Position = OffsetInBlocks * 4096;
			bal.ReadFromStream(this.Stream, this.Reader);
			OffsetInBlocks = bal.FileAttributes[0].Block;
			this.Stream.Position = OffsetInBlocks * 4096;
			bsl.ReadFromStream(this.Stream, this.Reader);
			while(true)
			{
				for(int i = 0; i < bsl.Number; i++)
					Result.Add(bsl.SeriesArray[i]);
				if(bsl.Next == 0) break;
				OffsetInBlocks = bsl.Next;
				this.Stream.Position = OffsetInBlocks * 4096;
				bsl.ReadFromStream(this.Stream, this.Reader);
			}
			Result.TrimToSize();
			res = new BlockSeries[Result.Count];
			Result.CopyTo(0, res, 0, Result.Count);
			this.Stream.Position = OldPosition;
			return res;
		}
		public void CreateDir(string DirName, string[] Path)
		{
			BlockOfAttributeList bal = new BlockOfAttributeList();
			BlockOfSeriesList bsl = new BlockOfSeriesList();
			FileRecord fr = new FileRecord();
			Int64 OffsetInBlocks;

			this.Stream.Position = this.FindPositionOfFileRecord(Path);
			FileRecord Parent = new FileRecord();
			Parent.ReadFromStream(this.Stream, this.Reader);
			if(this.SuperBlock.FreeBlocks < 3) return;

			fr.SizeOfInternalData = 0;
			fr.Flags = FileRecordFlags.Dir | FileRecordFlags.Ext | FileRecordFlags.Use;
			fr.NameLength = (Int16) DirName.Length;
			fr.Name = DirName.ToCharArray();
			fr.Info = new byte[24];
			fr.Block = this.AllocateBlock();
			fr.Data = new byte[472];
			this.CreateFileRecord(fr, Parent);
			OffsetInBlocks = fr.Block;
			this.Stream.Position = OffsetInBlocks * 4096;
			bal.Next = 0;
			bal.Prev = 0;
			bal.Number = 1;
			bal.Reserve = new byte[12];
			bal.FileAttributes = new FileAttribute[1];
			bal.FileAttributes[0] = new FileAttribute();
			bal.FileAttributes[0].Flags =
				FileAttributeFlags.Ser | FileAttributeFlags.Ext | FileAttributeFlags.Use;
			bal.FileAttributes[0].Name = Attributes.Data;
			bal.FileAttributes[0].Size = 0;
			bal.FileAttributes[0].Block = 0;
			bal.WriteToStream(this.Stream, this.Writer);
		}
		public void CloseImage()
		{
			this.Reader.Close();
			this.Writer.Close();
			this.Stream.Close();
			this.IsLoaded = false;
		}
		public FileRecord[] GetFilesOrDirs(string[] Path, bool GetFiles)
		{
			BlockOfAttributeList bal = new BlockOfAttributeList();
			BlockOfSeriesList bsl = new BlockOfSeriesList();
			FileRecord fr = new FileRecord();
			Int64 OffsetInBlocks;
			ArrayList Result = new ArrayList();

			this.Stream.Position = this.FindPositionOfFileRecord(Path);
			fr.ReadFromStream(this.Stream, this.Reader);
			OffsetInBlocks = fr.Block;
			this.Stream.Position = OffsetInBlocks * 4096;
			bal.ReadFromStream(this.Stream, this.Reader);
			if(bal.FileAttributes[0].Size == 0) return null;
			OffsetInBlocks = bal.FileAttributes[0].Block;
			this.Stream.Position = OffsetInBlocks * 4096;
			bsl.ReadFromStream(this.Stream, this.Reader);
			
			int LastBlockLength;
			if(bal.FileAttributes[0].Size % 4096 == 0) LastBlockLength = 4;
			else LastBlockLength = (int) (bal.FileAttributes[0].Size % 4096) / 1024;
			while(true)
			{
				for(int i = 0; i < bsl.Number; i++)
				{
					OffsetInBlocks = bsl.SeriesArray[i].FirstBlock;
					this.Stream.Position = OffsetInBlocks * 4096;
					for(int j = 0; j < bsl.SeriesArray[i].Blocks; j++)
					{
						int tmp;
						if(i == bsl.Number - 1 && j == bsl.SeriesArray[i].Blocks - 1 && bsl.Next == 0)
							tmp = LastBlockLength;
						else tmp = 4;
						for(int k = 0; k < tmp; k++)
						{
							fr = new FileRecord();
							fr.ReadFromStream(this.Stream, this.Reader);
							if((fr.Flags & FileRecordFlags.Use) == 0) continue;
							if(GetFiles)
								if((fr.Flags & FileRecordFlags.Dir) > 0) continue;
							if(!GetFiles)
								if((fr.Flags & FileRecordFlags.Dir) == 0) continue;
							Result.Add(fr);
						}
					}
				}
				if(bsl.Next == 0) break;
				OffsetInBlocks = bsl.Next;
				this.Stream.Position = OffsetInBlocks * 4096;
				bsl.ReadFromStream(this.Stream, this.Reader);
			}
			Result.TrimToSize();
			FileRecord[] res = new FileRecord[Result.Count];
			Result.CopyTo(0, res, 0, Result.Count);
			return res;
		}
		public void Delete(string[] Path)
		{
			BlockOfAttributeList bal = new BlockOfAttributeList();
			BlockOfSeriesList bsl = new BlockOfSeriesList();
			FileRecord fr = new FileRecord();
			Int64 OffsetInBlocks;
			
			this.Stream.Position = this.FindPositionOfFileRecord(Path);
			fr.ReadFromStream(this.Stream, this.Reader);
			fr.Flags = 0;
			this.Stream.Seek(-1024, SeekOrigin.Current);
			fr.WriteToStream(this.Stream, this.Writer);
			OffsetInBlocks = fr.Block;
			this.Stream.Position = OffsetInBlocks * 4096;
			bal.ReadFromStream(this.Stream, this.Reader);
			this.FreeBlock(fr.Block);

			// если файл маленький
			if((bal.FileAttributes[0].Flags & FileAttributeFlags.Ext) == 0)
				return;

			// если файл в одном блоке
			if((bal.FileAttributes[0].Flags & FileAttributeFlags.Ext) > 0 &&
				(bal.FileAttributes[0].Flags & FileAttributeFlags.Ser) == 0)
			{
				this.FreeBlock(bal.FileAttributes[0].Block);
				return;
			}

			// если файл в серии блоков
			if((bal.FileAttributes[0].Flags & FileAttributeFlags.Ext) > 0 &&
				(bal.FileAttributes[0].Flags & FileAttributeFlags.Ser) > 0)
			{
				OffsetInBlocks = bal.FileAttributes[0].Block;
				this.Stream.Position = OffsetInBlocks * 4096;
				bsl.ReadFromStream(this.Stream, this.Reader);
                Int64 Num = bal.FileAttributes[0].Block;
                while(true)
				{
                    this.FreeBlock(Num);                    
                    this.FreeMemory(bsl.SeriesArray);
					if(bsl.Next == 0) break;
                    Num = bsl.Next;
					OffsetInBlocks = bsl.Next;
					this.Stream.Position = OffsetInBlocks * 4096;
					bsl.ReadFromStream(this.Stream, this.Reader);
				}
			}
		}
		public void Move(string[] From, string[] To)
		{
			BlockOfAttributeList bal = new BlockOfAttributeList();
			BlockOfSeriesList bsl = new BlockOfSeriesList();
			FileRecord fr = new FileRecord();
			FileRecord Parent = new FileRecord();
			int tmpFlags;
			
			this.Stream.Position = this.FindPositionOfFileRecord(From);
			fr.ReadFromStream(this.Stream, this.Reader);
			tmpFlags = fr.Flags;
			fr.Flags = 0;
			this.Stream.Seek(-1024, SeekOrigin.Current);
			fr.WriteToStream(this.Stream, this.Writer);
			this.Stream.Position = this.FindPositionOfFileRecord(To);
			Parent.ReadFromStream(this.Stream, this.Reader);
			fr.Flags = tmpFlags;
			this.CreateFileRecord(fr, Parent);
		}
		public string[] GetStringsOfAttributes(FileRecord fr)
		{
			BlockOfAttributeList bal = new BlockOfAttributeList();
			Int64 OffsetInBlocks, Size;
			string[] Result = new string[2];

			Size = fr.SizeOfInternalData;
			OffsetInBlocks = fr.Block;
			this.Stream.Position = OffsetInBlocks * 4096;
			bal.ReadFromStream(this.Stream, this.Reader);
			Size += bal.FileAttributes[0].Size;
			Result[0] = Size.ToString();
			Result[1] = bal.FileAttributes[1].DateTime.ToShortDateString();
			return Result;
		}
	}
}