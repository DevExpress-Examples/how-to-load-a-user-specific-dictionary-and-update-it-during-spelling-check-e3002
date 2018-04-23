Imports Microsoft.VisualBasic
Imports System
Imports System.IO
Imports System.Text
#Region "#usings"
Imports DevExpress.Web.ASPxSpellChecker
Imports DevExpress.XtraSpellChecker
#End Region ' #usings

Namespace CustomDictionary
	Partial Public Class _Default
		Inherits System.Web.UI.Page
		Private userDictPath As String

		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
			userDictPath = GetUserDictionaryPath()
		End Sub

		Private Function GetUserDictionaryPath() As String
			Dim username As String = Request.ServerVariables("remote_user")
			If username = "" Then
				username = "anonymous"
			Else
				username = username.Replace("\", "_")
			End If
			Dim userDictName As String = "~/CustomDictionaries/" & username & ".dic"
			Return Server.MapPath(userDictName)
		End Function
		#Region "#wordadded"
		Protected Sub ASPxSpellChecker1_WordAdded(ByVal sender As Object, ByVal e As WordAddedEventArgs)
			Dim checker As ASPxSpellChecker = TryCast(sender, ASPxSpellChecker)
			Dim dic As SpellCheckerCustomDictionary = checker.GetCustomDictionary()
			If dic IsNot Nothing Then
				Dim stb As New StringBuilder()
				For i As Integer = 0 To dic.WordCount - 1
					stb.AppendLine(dic(i))
				Next i
				Using writer As New StreamWriter(userDictPath)
					writer.Write(stb.ToString())
				End Using
			End If
		End Sub
		#End Region ' #wordadded
		#Region "#customdictionaryloading"
		Protected Sub ASPxSpellChecker1_CustomDictionaryLoading(ByVal sender As Object, _
 ByVal e As CustomDictionaryLoadingEventArgs)

			Dim alphStream As New FileStream(Server.MapPath(e.CustomDictionary.AlphabetPath), _
 FileMode.Open, FileAccess.Read)
			Dim dicStream As New FileStream(userDictPath, _
 FileMode.OpenOrCreate, FileAccess.Read)
			Try
				alphStream.Seek(0, SeekOrigin.Begin)
				dicStream.Seek(0, SeekOrigin.Begin)
				e.CustomDictionary.LoadFromStream(dicStream, alphStream)
			Finally
				alphStream.Dispose()
				dicStream.Dispose()
			End Try
		End Sub
		#End Region ' #customdictionaryloading
	End Class
End Namespace
