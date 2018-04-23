Imports System
Imports System.IO
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Windows.Forms
Imports System.Runtime.InteropServices
' ...

Namespace WindowsApplication1
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

        Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) _
        Handles button1.Click
            Dim ms As New MemoryStream()
            Try
                chartControl1.ExportToImage(ms, ImageFormat.Png)
                ms.Seek(0, SeekOrigin.Begin)

                Dim mf As New Bitmap(ms)
                Clipboard.SetImage(mf)
            Finally
                ms.Close()
            End Try
        End Sub

        Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles Button2.Click
            Dim ms As New MemoryStream()
            Try
                chartControl1.ExportToImage(ms, ImageFormat.Emf)
                ms.Seek(0, SeekOrigin.Begin)

                Dim mf As New Metafile(ms)
                ClipboardMetafileHelper.PutEnhMetafileOnClipboard(Me.Handle, mf)
            Finally
                ms.Close()
            End Try
        End Sub
    End Class

#Region "ClipboardMetafileHelper"
    Public Class ClipboardMetafileHelper
        <DllImport("user32.dll", EntryPoint:="OpenClipboard", _
           SetLastError:=True, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
        Public Shared Function OpenClipboard(ByVal hWnd As IntPtr) As Boolean
        End Function
        <DllImport("user32.dll", EntryPoint:="EmptyClipboard", _
           SetLastError:=True, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
        Public Shared Function EmptyClipboard() As Boolean
        End Function
        <DllImport("user32.dll", EntryPoint:="SetClipboardData", _
           SetLastError:=True, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
        Public Shared Function SetClipboardData(ByVal uFormat As Integer, ByVal hWnd As IntPtr) As IntPtr
        End Function
        <DllImport("user32.dll", EntryPoint:="CloseClipboard", _
           SetLastError:=True, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
        Public Shared Function CloseClipboard() As Boolean
        End Function
        <DllImport("gdi32.dll", EntryPoint:="CopyEnhMetaFileA", _
           SetLastError:=True, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
        Public Shared Function CopyEnhMetaFile(ByVal hemfSrc As IntPtr, ByVal hNULL As IntPtr) As IntPtr
        End Function
        <DllImport("gdi32.dll", EntryPoint:="DeleteEnhMetaFile", _
           SetLastError:=True, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
        Public Shared Function DeleteEnhMetaFile(ByVal hemfSrc As IntPtr) As Boolean
        End Function

        ' Metafile mf is set to a state that is not valid inside this function.
        Public Shared Function PutEnhMetafileOnClipboard(ByVal hWnd As IntPtr, ByVal mf As Metafile) As Boolean
            Dim bResult As New Boolean()
            bResult = False
            Dim hEMF, hEMF2 As IntPtr
            hEMF = mf.GetHenhmetafile() ' invalidates mf
            If Not hEMF.Equals(New IntPtr(0)) Then
                hEMF2 = CopyEnhMetaFile(hEMF, New IntPtr(0))
                If Not hEMF2.Equals(New IntPtr(0)) Then
                    If OpenClipboard(hWnd) Then
                        If EmptyClipboard() Then
                            Dim hRes As IntPtr
                            hRes = SetClipboardData(14, hEMF2)    ' 14 == CF_ENHMETAFILE
                            bResult = hRes.Equals(hEMF2)
                            CloseClipboard()
                        End If
                    End If
                End If
                DeleteEnhMetaFile(hEMF)
            End If
            Return bResult
        End Function

    End Class
#End Region

End Namespace