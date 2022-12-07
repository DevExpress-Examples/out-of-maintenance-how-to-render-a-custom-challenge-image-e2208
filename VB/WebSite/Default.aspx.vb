Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports DevExpress.Web.Captcha
Imports System.Drawing

Partial Public Class _Default
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)

	End Sub
	Protected Sub ASPxCaptcha1_ChallengeImageCustomRender(ByVal sender As Object, ByVal e As ChallengeImageCustomRenderEventArgs)
		Using graphics As Graphics = Graphics.FromImage(e.Image)
			Dim backgroundImage As System.Drawing.Image = System.Drawing.Image.FromFile(Server.MapPath("~/pp.jpg"))
			graphics.DrawImage(backgroundImage, 0, 0, e.Image.Width, e.Image.Height)
			Dim font As New Font("Times New Roman", 40.0f, FontStyle.Bold, GraphicsUnit.Pixel)
			graphics.DrawString(e.Code, font, Brushes.Red, New PointF(0.0f, 0.0f))
			graphics.Flush()
		End Using
	End Sub
End Class
