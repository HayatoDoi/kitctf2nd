using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Threading.Tasks;

namespace POST
{
	class Program
	{
		static void Main(string[] args)
		{
			string url = "http://ctfsvr.ic.kanazawa-it.ac.jp:20080/q03/proxy_tool.php";

			System.Net.WebClient wc = new System.Net.WebClient();
			//NameValueCollectionの作成
			System.Collections.Specialized.NameValueCollection ps =
				new System.Collections.Specialized.NameValueCollection();
			//送信するデータ（フィールド名と値の組み合わせ）を追加
			ps.Add("user","root");
			ps.Add("pass", "admin");
			ps.Add("tmp", "test");

			//データを送信し、また受信する
			byte[] resData = wc.UploadValues(url, ps);
			wc.Dispose();

			//受信したデータを表示する
			string resText = System.Text.Encoding.UTF8.GetString(resData);
			Console.WriteLine(resText);
		}
	}
}
