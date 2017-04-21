using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using HtmlAgilityPack;
using System.Web;
namespace Price_Checker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://api.cryptonator.com/api/ticker/btc-usd");
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            System.Net.WebClient wc = new System.Net.WebClient();
            byte[] price = wc.DownloadData("http://www.yoursite.com/resource/file.htm");

            string webData = System.Text.Encoding.UTF8.GetString(price);
            StreamReader sr = new StreamReader(response.GetResponseStream());
            richTextBox1.Text = sr.ReadToEnd();
            sr.Close();
            


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
    
}
