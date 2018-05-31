using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Line
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            isRock.LineBot.Bot bot = new isRock.LineBot.Bot("P2yyfwel1iQ0EOuDZgSyZF+oSqR2UTngYay4NDRhUtLs4gdwU0FmrlWm48qqUCtj+kfwLx62xT3BEAgLAtXKtieajXKCXLKQGNQbB8QCPj/sCud4S2Ctp+t4JCyBu8BxQyfltSr4L2D7iMQh+NeM2wdB04t89/1O/w1cDnyilFU=");

            bot.PushMessage("Ueef347870c0018224a63cddfee3180ab", "你好啊！");
            bot.PushMessage("Ueef347870c0018224a63cddfee3180ab", 3,182);
            bot.PushMessage("Ueef347870c0018224a63cddfee3180ab", new Uri("https://www.goody25.com/image.php?file=cache/catalog/3188/20170514141212-1170x585.jpg"));
        }
    }
}