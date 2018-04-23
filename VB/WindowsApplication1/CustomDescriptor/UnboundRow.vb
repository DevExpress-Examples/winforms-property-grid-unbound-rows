Imports System
Imports System.ComponentModel

Namespace WindowsApplication1
    Public Class UnboundRow
        Inherits PropertyDescriptor

        Private _MyValue As Object
        Private ReadOnly _ValueType As Type
        Public Property MyValue() As Object
            Get
                Return _MyValue
            End Get
            Set(ByVal value As Object)
                _MyValue = value
            End Set
        End Property

        Public Sub New(ByVal name As String, ByVal valueType As Type)
            MyBase.New(name, Nothing)
            _ValueType = valueType
        End Sub


        Protected Sub New(ByVal name As String, ByVal attrs() As Attribute)
            MyBase.New(name, attrs)

        End Sub
        Protected Sub New(ByVal descr As MemberDescriptor)
            MyBase.New(descr)

        End Sub
        Protected Sub New(ByVal descr As MemberDescriptor, ByVal attrs() As Attribute)
            MyBase.New(descr, attrs)

        End Sub

        Public Overrides ReadOnly Property Category() As String
            Get
                Return "!Unbound rows"
            End Get
        End Property


        Public Overrides Function CanResetValue(ByVal component As Object) As Boolean
            Return False
        End Function

        Public Overrides ReadOnly Property ComponentType() As Type
            Get
                Return _ValueType
            End Get
        End Property

        Public Overrides Function GetValue(ByVal component As Object) As Object
            Return MyValue
        End Function

        Public Overrides ReadOnly Property IsReadOnly() As Boolean
            Get
                Return False
            End Get
        End Property

        Public Overrides ReadOnly Property PropertyType() As Type
            Get
                Return _ValueType
            End Get
        End Property

        Public Overrides Sub ResetValue(ByVal component As Object)

        End Sub

        Public Overrides Sub SetValue(ByVal component As Object, ByVal value As Object)
            MyValue = value
        End Sub

        Public Overrides Function ShouldSerializeValue(ByVal component As Object) As Boolean
            Return False
        End Function
    End Class
End Namespace
