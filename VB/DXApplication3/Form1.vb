Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Namespace DXApplication3

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
            Dim helper As UnboundRowsHelper = New UnboundRowsHelper(propertyGridControl1)
            helper.AddUnboundRow("UnboundInt", GetType(Integer))
            helper.AddUnboundRow("UnboundString", GetType(String))
            helper.AddUnboundRow("UnboundDateTime", GetType(Date))
            propertyGridControl1.RetrieveFields()
        End Sub
    End Class

    Public Class SourceObject
        Inherits Component

        Public Property TestProperty As String
    End Class
End Namespace
