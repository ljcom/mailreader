using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;
using MailKit.Security;

namespace mailReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
		private void button1_Click(object sender, EventArgs e)
		{
			RetrieveMail("samuelsurya@yandex.com", this.pwd.Text, "imap.yandex.com", 993, true);

		}

		public void RetrieveMail(String userid, String pwd, String server, int port, bool ssl)
        {

			using (var client = new MailKit.Net.Imap.ImapClient())
			{
				try
				{
					client.Connect(server, port, ssl);
					client.Authenticate(userid, pwd);
					// The Inbox folder is always available on all IMAP servers...
					var inbox = client.Inbox;
					inbox.Open(FolderAccess.ReadOnly);

					Console.WriteLine("Total messages: {0}", inbox.Count);
					Console.WriteLine("Recent messages: {0}", inbox.Recent);
					setText("Total messages: " + inbox.Count);
					setText("Recent messages: " + inbox.Recent);
					for (int i = 0; i < inbox.Count; i++)
					{
						var message = inbox.GetMessage(i);
						Console.WriteLine("Subject: {0}", message.Subject);
						setText("Subject: " + message.Subject);
					}

					client.Disconnect(true);
				}
				catch (AuthenticationException e)
				{
					Console.WriteLine(e.Message);
					setText(e.Message);
				}
				catch (NotSupportedException e) 
				{
					Console.WriteLine(e.Message);
					setText(e.Message);
				}

			}

			}


        private void Form1_Load(object sender, EventArgs e)
        {

        }

		public void setText(String comments)
		{
			String[] aux;
			//if (comments.Contains('\n')) //Multiple lines comments
			//{
				aux = comments.Split('\n');
				for (int i = 0; i < aux.Length; i++)
					this.textBox1.Text += aux[i] + Environment.NewLine;
			//}
			//else //One line comments
				//this.textBox1.Text = comments;
		}

        private void ssl_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
