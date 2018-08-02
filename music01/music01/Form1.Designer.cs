namespace music01
{
	partial class Form1
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.button1 = new System.Windows.Forms.Button();
			this.btnPlay = new System.Windows.Forms.Button();
			this.btnStop = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.title = new System.Windows.Forms.TextBox();
			this.artist = new System.Windows.Forms.TextBox();
			this.album = new System.Windows.Forms.TextBox();
			this.btnPause = new System.Windows.Forms.Button();
			this.listView1 = new System.Windows.Forms.ListView();
			this.SuspendLayout();
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(320, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(72, 30);
			this.button1.TabIndex = 0;
			this.button1.Text = "参照";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// btnPlay
			// 
			this.btnPlay.Location = new System.Drawing.Point(31, 342);
			this.btnPlay.Name = "btnPlay";
			this.btnPlay.Size = new System.Drawing.Size(120, 46);
			this.btnPlay.TabIndex = 2;
			this.btnPlay.Text = ">>再生";
			this.btnPlay.UseVisualStyleBackColor = true;
			this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
			// 
			// btnStop
			// 
			this.btnStop.Location = new System.Drawing.Point(528, 342);
			this.btnStop.Name = "btnStop";
			this.btnStop.Size = new System.Drawing.Size(120, 46);
			this.btnStop.TabIndex = 3;
			this.btnStop.Text = "■停止";
			this.btnStop.UseVisualStyleBackColor = true;
			this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(109, 281);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(51, 15);
			this.label1.TabIndex = 4;
			this.label1.Text = "タイトル";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(307, 281);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(71, 15);
			this.label2.TabIndex = 5;
			this.label2.Text = "アーティスト";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(549, 281);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(55, 15);
			this.label3.TabIndex = 6;
			this.label3.Text = "アルバム";
			// 
			// title
			// 
			this.title.Location = new System.Drawing.Point(31, 299);
			this.title.Name = "title";
			this.title.Size = new System.Drawing.Size(211, 22);
			this.title.TabIndex = 7;
			// 
			// artist
			// 
			this.artist.Location = new System.Drawing.Point(248, 299);
			this.artist.Name = "artist";
			this.artist.Size = new System.Drawing.Size(210, 22);
			this.artist.TabIndex = 8;
			// 
			// album
			// 
			this.album.Location = new System.Drawing.Point(463, 299);
			this.album.Name = "album";
			this.album.Size = new System.Drawing.Size(210, 22);
			this.album.TabIndex = 9;
			// 
			// btnPause
			// 
			this.btnPause.Location = new System.Drawing.Point(291, 342);
			this.btnPause.Name = "btnPause";
			this.btnPause.Size = new System.Drawing.Size(120, 46);
			this.btnPause.TabIndex = 10;
			this.btnPause.Text = "||一時停止";
			this.btnPause.UseVisualStyleBackColor = true;
			this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
			// 
			// listView1
			// 
			this.listView1.Location = new System.Drawing.Point(31, 48);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(642, 216);
			this.listView1.TabIndex = 11;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(685, 400);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.btnPause);
			this.Controls.Add(this.album);
			this.Controls.Add(this.artist);
			this.Controls.Add(this.title);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnStop);
			this.Controls.Add(this.btnPlay);
			this.Controls.Add(this.button1);
			this.Name = "Form1";
			this.Text = "MP3プレイヤー";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btnPlay;
		private System.Windows.Forms.Button btnStop;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox title;
		private System.Windows.Forms.TextBox artist;
		private System.Windows.Forms.TextBox album;
		private System.Windows.Forms.Button btnPause;
		private System.Windows.Forms.ListView listView1;
	}
}

