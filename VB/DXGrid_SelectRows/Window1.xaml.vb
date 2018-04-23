Imports Microsoft.VisualBasic
Imports System.Windows

Namespace DXGrid_SelectRows
	Partial Public Class Window1
		Inherits Window
		Public Sub New()
			InitializeComponent()
			grid.ItemsSource = ProductList.GetData()
		End Sub

		Private Sub Button_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			SelectProducts(20)
		End Sub

		Private Sub SelectProducts(ByVal minPrice As Double)
            grid.BeginSelection()
            grid.UnselectAll()
			For i As Integer = 0 To grid.VisibleRowCount - 1
				Dim rowHandle As Integer = grid.GetRowHandleByVisibleIndex(i)
				If (Not grid.IsGroupRowHandle(rowHandle)) Then
					Dim price As Double = CDbl(grid.GetCellValue( _
						rowHandle, grid.Columns("UnitPrice")))
					If price >= minPrice Then
                        grid.SelectItem(rowHandle)
					End If
				End If
			Next i
            grid.EndSelection()
		End Sub
	End Class
End Namespace
