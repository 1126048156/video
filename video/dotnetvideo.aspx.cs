using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

namespace video.mp3
{
    public partial class dotnetvideo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String path = "video\\test.mp4";
            Label1.Text = Play(path,380,280);
            String path2 = "mp3\\test.mp3";
            Label2.Text = Play(path2,100,100);
        }
        public static string Play(string url, int width, int height)
        {
            string strTmp = url.ToLower();
             if (strTmp.EndsWith(".mp3"))
            {
                return mp3(url, width, height);
            }
            else if (strTmp.EndsWith(".mp4"))
            {
                return mp4(url, width, height);
            }        
            else
            {
                return "视频文件数据错误";
            }
        }
       
       /* private static string mp3(string url, int width, int height)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<object   id=\"WMPlay\"  classid=\"CLSID:22d6f312-b0f6-11d0-94ab-0080c74c7e95\" codebase=\"http://activex.microsoft.com/activex/controls/mplayer/en/nsmp2inf.cab#Version=5,1,52,701\"   type=\"application/x-oleobject\"   width=\""   +   width   +   "\"   height=\""   +   height   +   "\"   hspace=\"0\"   standby=\"Loading   Microsoft   Windows   Media   Player   components...\"   id=\"NSPlay\">");
            sb.Append("<param   name=\"AutoRewind\"   value=\"0\">");
            sb.Append("<param   name=\"FileName\"   value=\""   +   url   +   "\">");//这里是MP3网址
            sb.Append("<param   name=\"ShowControls\"   value=\"1\">");
            sb.Append("<param   name=\"ShowPositionControls\"   value=\"0\">");
            sb.Append("<param   name=\"ShowAudioControls\"   value=\"1\">");
            sb.Append("<param   name=\"ShowTracker\"   value=\"0\">");
            sb.Append("<param   name=\"ShowDisplay\"   value=\"0\">");
            sb.Append("<param   name=\"ShowStatusBar\"   value=\"1\">");
            sb.Append("<param   name=\"ShowGotoBar\"   value=\"0\">");
            sb.Append("<param   name=\"ShowCaptioning\"   value=\"0\">");
            sb.Append("<param   name=\"AutoStart\"   value=\"1\">");
            sb.Append("<param   name=\"Volume\"   value=\"-2500\">");
            sb.Append("<param   name=\"AnimationAtStart\"   value=\"0\">");
            sb.Append("<param   name=\"TransparentAtStart\"   value=\"0\">");
            sb.Append("<param   name=\"AllowChangeDisplaySize\"   value=\"0\">");
            sb.Append("<param   name=\"AllowScan\"   value=\"0\">");
            sb.Append("<param   name=\"EnableContextMenu\"   value=\"0\">");
            sb.Append("<param   name=\"ClickToPlay\"   value=\"0\">");
            sb.Append("<embed src=\""+url+"\" quality=\"high\" bgcolor=\"#ffffff\" width=\"550\"  height=\"400\" name=\"mymp3\" align=\"center\" allowScriptAccess=\"sameDomain\" type=\"application/x-shockwave-flash\" pluginspage=\"http://www.macromedia.com/go/getflashplayer\" />");        
            sb.Append("</object>");
            return sb.ToString();
        }*/
        private static string mp4(string url, int width, int height)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<video style=\"width:602px;height:365px\" controls=\"controls\">");
            sb.Append("<source src=\""+url+"\" type=\"video/mp4\"/></video>");   
            return sb.ToString();
        }
        private static string mp3(string url, int width, int height)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<audio controls=\"controls\">");
            sb.Append("<source src=\"" + url + "\" type=\"audio/mp3\"/></video>");
            return sb.ToString();
        }
      
    }
}