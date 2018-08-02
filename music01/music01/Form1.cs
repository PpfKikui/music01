using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shell32;
using System.IO;
using System.Windows.Forms;


namespace music01
{
	public partial class Form1 : Form
	{
		Music m = new Music();
		public Form1()
		{
			InitializeComponent();
			listview_set();
		}

		//リストビューに関する設定
		private void listview_set()
		{
			listView1.View = View.Details;
			//グリッドラインの表示or非表示
			listView1.GridLines = true;
			//ヘッダー名,ピクセル,左寄せ
			listView1.Columns.Add("ファイル名", 0, HorizontalAlignment.Left);
			listView1.Columns.Add("ファイルパス", 0, HorizontalAlignment.Left);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			//複数ファイルの選択を可能に
			openFileDialog1.Multiselect = true;

			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				foreach(string nFileName in openFileDialog1.FileNames)
				{
					ListViewItem lvitem;
					lvitem = listView1.Items.Add(Path.GetFileName(nFileName));
					lvitem.SubItems.Add(nFileName);
				}

				//リストビュー１の列幅を自動調整
				foreach (ColumnHeader ch in listView1.Columns)
				{
					ch.Width = -1;
				}
				
			}
		}

		private void btnPlay_Click(object sender, EventArgs e)
		{
			m.play();
		}

		private void btnPause_Click(object sender, EventArgs e)
		{
			m.pause();
		}

		private void btnStop_Click(object sender, EventArgs e)
		{
			m.stop();
			title.Text = "";
			artist.Text = "";
			album.Text = "";
		}

		private void listView1_SelectedIndexChanged(object sender, EventArgs e)
		{
			//タイトル名とか出す
			if (listView1.SelectedItems.Count == 0)
			{
				return;
			}

			string dir = Path.GetDirectoryName(listView1.SelectedItems[0].SubItems[1].Text);
			string file = Path.GetFileName(listView1.SelectedItems[0].SubItems[1].Text);

			ShellClass shell = new ShellClass();
			Folder f = shell.NameSpace(dir);
			FolderItem item = f.ParseName(file);

			title.Text = (f.GetDetailsOf(item, 21));
			artist.Text = (f.GetDetailsOf(item, 13));
			album.Text = (f.GetDetailsOf(item, 14));

			m.open(listView1.SelectedItems[0].SubItems[1].Text);
		}
	}
}
