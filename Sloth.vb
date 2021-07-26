Imports System.IO
Imports System.Net
Imports Newtonsoft.Json.Linq

Public Class Sloth
	Private Function GetSlothImageURL() As String
		'prepare variables
		Dim request As HttpWebRequest
		Dim response As HttpWebResponse
		Dim reader As StreamReader
		Dim rawResponse As String

		'create a web request and get
		'its response as a string
		ActiveProcess.Text = "Fetching image from API"
		request = DirectCast(WebRequest.Create("https://sloth.pics/api"), HttpWebRequest)
		response = DirectCast(request.GetResponse(), HttpWebResponse)
		reader = New StreamReader(response.GetResponseStream())
		rawResponse = reader.ReadToEnd()

		'convert response string to an object
		Dim slothObject As JObject = JObject.Parse(rawResponse)
		Return slothObject("url")
	End Function

	Private Function GetImageFromURL(url As String) As Bitmap
		'download image data from url
		'and convert it to bitmap
		Dim webClient As WebClient = New WebClient
		Dim memoryImage = New MemoryStream(webClient.DownloadData(url))
		Dim bitImage As Bitmap = Bitmap.FromStream(memoryImage)
		Return bitImage
	End Function

	Private Function SetSlothImage()
		'get image and set it to
		'the picture box
		Dim url = GetSlothImageURL()
		Dim bitmap = GetImageFromURL(url)
		ShowSloth.Image = bitmap
		ActiveProcess.Text = "Done"
		Return Nothing
	End Function

	'click event for the get sloth button
	Private Sub GetSlothButton(sender As Object, e As EventArgs) Handles GetSloth.Click
		SetSlothImage()
	End Sub

	'set the space bar as an alias for
	'clicking the get sloth button
	Private Sub GetSlothSpace(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
		If e.KeyCode = Keys.Space Then
			SetSlothImage()
		End If
	End Sub
End Class
