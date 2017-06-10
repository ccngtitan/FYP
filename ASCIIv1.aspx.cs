using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class ASCIIv1 : System.Web.UI.Page
    {
        public string strHtml = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 256; i++)
            {
                lbl1.Text += i + " " + Convert.ToChar(i) + "<br/>";
            }
        }
    }
}