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

namespace webdltest
{
    public partial class Form1 : Form
    {
        string line = string.Empty;
        public Form1()
        {
            InitializeComponent();
        }

        private void btndl_Click(object sender, EventArgs e)
        {
            //string link = string.Empty;
            HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(txtweb.Text);
            myRequest.Method = "GET";
            WebResponse myResponse = myRequest.GetResponse();
            StreamReader sr = new StreamReader(myResponse.GetResponseStream(), System.Text.Encoding.UTF8);
            
            
            while ((line = sr.ReadLine()) != null)
            {

                char[] delim = new char[] { '\t', '\n', '=', '(', ')', '"', '<', '>', ';' };
                string[] linksss = line.Split(delim, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < linksss.Length; i++)
                {
                    bool imghh = linksss[i].Contains("http");
                    
                    if (imghh == true)
                    {
                        bool ismimgg = linksss[i].Contains(".gif");
                        if (ismimgg == true)
                        {
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

        private void pastelink(string[] linksss, int i)
        {
            linkstxt.AppendText(linksss[i] + "\n");
            imgdownload.Load(linksss[i].ToString());
        }
    }
}
