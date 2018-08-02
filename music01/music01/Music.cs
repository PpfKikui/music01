using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shell32;
using System.IO;
using System.Windows.Forms;



namespace music01
{
	class Music
	{
		//mp3ファイルを再生できるdll winmn.dllをインポート
		[DllImport("winmm.dll")]
		private static extern long mciSendString(string IpstrCommand, String IpcstrReturnString, int uReturnLength, int hwndCallback);

		//アプリケーションファイルを開く
		public void open(string file)
		{
			string command = "open \"" + file + "\" type MPEGVideo alias Mymusic";
			mciSendString(command, null,0,0);
		}

		//ファイルを再生
		public void play()
		{
			string command = "play MyMusic";
			mciSendString(command, null, 0, 0);
		}

		//ファイルを一時停止
		public void pause()
		{
			string command = "stop MyMusic";
			mciSendString(command, null, 0, 0);
		}

		//ファイルを停止
		public void stop()
		{
			string command = "close MyMusic";
			mciSendString(command, null, 0, 0);
		}
	}
}
