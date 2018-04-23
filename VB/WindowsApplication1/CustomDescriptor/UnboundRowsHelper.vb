Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Collections
Imports DevExpress.XtraVerticalGrid
Imports DevExpress.XtraVerticalGrid.Events

Namespace WindowsApplication1
    Public Class UnboundRowsHelper


        Private ReadOnly _PropertyGrid As PropertyGridControl

        Private _UnboundRows As New List(Of UnboundRow)()

        Public Sub New(ByVal pg As PropertyGridControl)
            _PropertyGrid = pg
            AddHandler _PropertyGrid.CustomPropertyDescriptors, AddressOf _PropertyGrid_CustomPropertyDescriptors
        End Sub

        Private Sub _PropertyGrid_CustomPropertyDescriptors(ByVal sender As Object, ByVal e As CustomPropertyDescriptorsEventArgs)
            If (TryCast(sender, PropertyGridControl)).SelectedObject = e.Source Then
                Dim properties As PropertyDescriptorCollection = e.Properties
                Dim list As New ArrayList(properties)
                list.AddRange(_UnboundRows)
                Dim result(list.Count - 1) As PropertyDescriptor
                list.ToArray().CopyTo(result, 0)
                e.Properties = New PropertyDescriptorCollection(result)
            End If
        End Sub

        Public Sub AddUnboundRow(ByVal fieldName As String, ByVal valueType As Type)
            Dim row As New UnboundRow(fieldName, valueType)
            _UnboundRows.Add(row)
        End Sub
    End Class
End Namespace
