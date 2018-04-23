Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraVerticalGrid.Rows
Imports DevExpress.XtraEditors.Repository
Imports System.Collections
Imports DevExpress.XtraVerticalGrid
Imports DevExpress.XtraVerticalGrid.Events

Namespace WindowsApplication1
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
            Dim helper As New UnboundRowsHelper(propertyGridControl1)
            helper.AddUnboundRow("UnboundInt", GetType(Integer))
            helper.AddUnboundRow("UnboundString", GetType(String))
            helper.AddUnboundRow("UnboundDateTime", GetType(Date))
            propertyGridControl1.AutoGenerateRows = True
        End Sub
    End Class

End Namespace