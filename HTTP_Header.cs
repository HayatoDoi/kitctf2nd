using System;
using System.Net;
using System.Text;
using System.Web;
using System.Collections.Specialized;

namespace GET
{
	class Program
	{
		static void Main(string[] args)
		{
			Encoding enc = Encoding.UTF8;

			WebClient wc = new WebClient();
			wc.Headers.Add("User-Agent",
				"docomo");

			NameValueCollection nvc = new NameValueCollection();

			wc.QueryString = nvc;

			byte[] result =
					wc.DownloadData("http://ctfsvr.ic.kanazawa-it.ac.jp:20080/q02/index.php");
			string html = enc.GetString(result);

			Console.WriteLine(html);

		}
	}
}
