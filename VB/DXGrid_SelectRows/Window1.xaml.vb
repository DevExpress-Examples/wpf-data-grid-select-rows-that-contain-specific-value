Imports System.Windows

Namespace DXGrid_SelectRows

    Public Partial Class Window1
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            Me.grid.ItemsSource = ProductList.GetData()
        End Sub

        Private Sub Button_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            SelectProducts(20)
        End Sub

        Private Sub SelectProducts(ByVal minPrice As Double)
            Me.grid.BeginSelection()
            Me.grid.UnselectAll()
            For i As Integer = 0 To Me.grid.VisibleRowCount - 1
                Dim rowHandle As Integer = Me.grid.GetRowHandleByVisibleIndex(i)
                If Not Me.grid.IsGroupRowHandle(rowHandle) Then
                    Dim price As Double = CDbl(Me.grid.GetCellValue(rowHandle, Me.grid.Columns("UnitPrice")))
                    If price >= minPrice Then Me.grid.SelectItem(rowHandle)
                End If
            Next

            Me.grid.EndSelection()
        End Sub
    End Class
End Namespace
