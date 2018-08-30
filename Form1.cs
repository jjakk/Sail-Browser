using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sail
{
    public partial class Sail : Form
    {
        public Sail()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (webBrowser1.CanGoBack){

                webBrowser1.GoBack();

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (webBrowser1.CanGoForward) { }

                webBrowser1.GoForward();

            }

        private void button4_Click(object sender, EventArgs e)
        {

            webBrowser1.Refresh();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            String webPageURL = textBox1.Text.Trim();
            webBrowser1.Navigate(webPageURL);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //String url = webBrowser1.Url;
            //textBox1.Text = url;
        }
    }
    
}
