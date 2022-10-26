using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class Exec2_Message : Form
	{
		public Exec2_Message()
		{
			InitializeComponent();
			timeLabel.Text = "";
		}

		private void timeButton1_Click(object sender, EventArgs e)
		{
			DateTime time = DateTime.Now;
			string greet = GetGreet(time);
			timeLabel.Text = $"現在時間 {time}, {greet}";
			MessageBox.Show($"目前時間 {time:yyyy/MM/dd HH:mm:ss}");
		}

		private string GetGreet(DateTime time)
		{
			int hour = time.Hour;
			if (hour < 12)
			{
				return "早上好";
			}else if(hour < 18)
			{
				return "下午好";
			}
			else
			{
				return "晚上好";
			}
		}

		private void timeButton2_Click(object sender, EventArgs e)
		{
			DateTime time = DateTime.Now;
			string greet = GetGreet(time);
			timeLabel.Text = $"現在時間 {time},\r\n{greet}";
		}
	}
}
