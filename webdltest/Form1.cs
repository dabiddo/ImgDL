using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Web;
using System.Threading;

namespace webdltest
{
    public partial class Form1 : Form
    {
        string line = string.Empty;
        public Form1()
        {
            InitializeComponent();

            //on loading it will check if main directory exists
            if (!Directory.Exists(@"C:\Tumblrdownload"))
                Directory.CreateDirectory(@"C:\Tumblrdownload");


        }

        private void btndl_Click(object sender, EventArgs e)
        {
            //Request to get the HTML code and pass it to a streamreader for examine line by line
            HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(txtweb.Text);
            myRequest.Method = "GET";
            WebResponse myResponse = myRequest.GetResponse();
            StreamReader sr = new StreamReader(myResponse.GetResponseStream(), System.Text.Encoding.UTF8);
            
            
            while ((line = sr.ReadLine()) != null)
            {
                //Delimeter to get rid of unwanted characters, the we will split the line in  substrings to examine if there is a link
                char[] delim = new char[] { '\t', '\n', '=', '(', ')', '"', '<', '>', ';' };
                string[] linksss = line.Split(delim, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < linksss.Length; i++)
                {
                    //Here we check for the link keyword HTTP, if it passes, we will examine for any image file format
                    bool imghh = linksss[i].Contains("http");
                    
                    if (imghh == true)
                    {
                        bool ismimgg = linksss[i].Contains(".gif");

                        if (ismimgg == true)
                        {
                            //After making sure the link contains an image, pass it to a method for extracting and downloading
                            pastelink(linksss, i);
                        }


                        bool imgjpg = linksss[i].Contains(".jpg");
                        if (imgjpg == true)
                        {
                           
                            pastelink(linksss, i);
                        }

                        bool imgpng = linksss[i].Contains(".png");
                        if (imgpng == true)
                        {
                           
                            pastelink(linksss, i);
                        }
                    }
                   
                }



            }
           
            sr.Close();
            myResponse.Close();
        }
        /// <summary>
        /// This method splits the link to get the filename and extension, after getting the data, it will proceed to download the image
        /// </summary>
        /// <param name="linksss"></param>
        /// <param name="i"></param>
        private void pastelink(string[] linksss, int i)
        {
            progressBar.Value = 0;
            string getlink = linksss[i].ToString();
            imgdownload.Load(getlink);
            linkstxt.AppendText(linksss[i] + "\n");
            progressBar.Value = 20;
            Thread.Sleep(2000);
            char[] limit = new char[] { '/','.' };
            char[] filelimit = new char[] { '/', '.' };            
            string link = txtweb.Text;
            string[] file = link.Split(limit, StringSplitOptions.RemoveEmptyEntries);
            string folder = "Tumblrdownload"+ @"\" + file[1].ToString();
            if (!Directory.Exists(@"C:\"+folder))
                Directory.CreateDirectory(@"C:\"+folder);
            progressBar.Value = 60;
            Thread.Sleep(2000);
            WebClient filedl = new WebClient();
            string lame = linksss[i].ToString();
            string[] filename = lame.Split(filelimit, StringSplitOptions.RemoveEmptyEntries);
            int count = filename.Length;
            progressBar.Value = 80;
            Thread.Sleep(2000);
            string dlname =@"C:\"+folder+@"\"+ filename[count - 2] + "." + filename[count-1];
            filedl.DownloadFile(linksss[i].ToString(), dlname);
            progressBar.Value = 100;
            Thread.Sleep(1000);
            
        }

      
    }
}
