using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using DevExpress.Web.ASPxEditors.Captcha;
using System.Drawing;

public partial class _Default : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {

    }
    protected void ASPxCaptcha1_ChallengeImageCustomRender(object sender, ChallengeImageCustomRenderEventArgs e) {
        using (Graphics graphics = Graphics.FromImage(e.Image)) {
            System.Drawing.Image backgroundImage = System.Drawing.Image.FromFile(Server.MapPath("~/pp.jpg"));
            graphics.DrawImage(backgroundImage, 0, 0, e.Image.Width, e.Image.Height);
            Font font = new Font("Times New Roman", 40.0f, FontStyle.Bold, GraphicsUnit.Pixel);
            graphics.DrawString(e.Code, font, Brushes.Red, new PointF(0.0f, 0.0f));
            graphics.Flush();
        }
    }
}
