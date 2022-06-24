Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.DataAnnotations
Imports System.Collections.ObjectModel
Imports System.Linq

Namespace DXGrid_SelectRows

    Public Class ViewModel
        Inherits ViewModelBase

        Public Sub New()
            Products = ProductList.GetData()
            Selection = New ObservableCollection(Of Product)() From {Products.ElementAt(0)}
        End Sub

        Public Property Products As ObservableCollection(Of Product)
            Get
                Return GetValue(Of ObservableCollection(Of Product))()
            End Get

            Set(ByVal value As ObservableCollection(Of Product))
                SetValue(value)
            End Set
        End Property

        Public Property Selection As ObservableCollection(Of Product)
            Get
                Return GetValue(Of ObservableCollection(Of Product))()
            End Get

            Set(ByVal value As ObservableCollection(Of Product))
                SetValue(value)
            End Set
        End Property

        <Command>
        Public Sub SelectRows(ByVal textValue As String)
            Dim value = Double.Parse(textValue)
            Selection = New ObservableCollection(Of Product)(From item In Products Where item.UnitPrice >= value Select item)
        End Sub

        Public Function CanSelectRows(ByVal textValue As String) As Boolean
            Return Double.TryParse(textValue, Nothing)
        End Function
    End Class
End Namespace
