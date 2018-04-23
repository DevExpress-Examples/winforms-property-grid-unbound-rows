Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Namespace DXApplication3
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
            Dim helper As New UnboundRowsHelper(propertyGridControl1)
            helper.AddUnboundRow("UnboundInt", GetType(Integer))
            helper.AddUnboundRow("UnboundString", GetType(String))
            helper.AddUnboundRow("UnboundDateTime", GetType(Date))
            propertyGridControl1.RetrieveFields()
        End Sub
    End Class

    Public Class SourceObject
        Inherits Component

        Public Property TestProperty() As String
    End Class
End Namespace
