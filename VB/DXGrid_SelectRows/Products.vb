﻿Imports System
Imports System.Collections.Generic

Public Class Product
	Public Property CompanyName() As String
	Public Property Country() As String
	Public Property City() As String
	Public Property UnitPrice() As Double
	Public Property Quantity() As Integer
End Class

Public Class ProductList
	Public Shared Function GetData() As List(Of Product)
		Dim list As New List(Of Product)()
		list.Add(New Product() With {
			.CompanyName = "Island Trading",
			.Country = "UK",
			.City = "Cowes",
			.UnitPrice = 19,
			.Quantity = 10
		})
		list.Add(New Product() With {
			.CompanyName = "Reggiani Caseifici",
			.Country = "Italy",
			.City = "Reggio Emilia",
			.UnitPrice = 12.5,
			.Quantity = 16
		})
		list.Add(New Product() With {
			.CompanyName = "Ricardo Adocicados",
			.Country = "Brazil",
			.City = "Rio de Janeiro",
			.UnitPrice = 19,
			.Quantity = 12
		})
		list.Add(New Product() With {
			.CompanyName = "QUICK-Stop",
			.Country = "Germany",
			.City = "QUICK-Stop",
			.UnitPrice = 22,
			.Quantity = 50
		})
		list.Add(New Product() With {
			.CompanyName = "Split Rail Beer & Ale",
			.Country = "USA",
			.City = "Reggio Emilia",
			.UnitPrice = 18,
			.Quantity = 20
		})
		list.Add(New Product() With {
			.CompanyName = "Ernst Handel",
			.Country = "Austria",
			.City = "Graz",
			.UnitPrice = 21,
			.Quantity = 52
		})
		list.Add(New Product() With {
			.CompanyName = "Save-a-lot Markets",
			.Country = "USA",
			.City = "Boise",
			.UnitPrice = 7.75,
			.Quantity = 120
		})
		list.Add(New Product() With {
			.CompanyName = "Tortuga Restaurante",
			.Country = "Mexico",
			.City = "México D.F.",
			.UnitPrice = 21,
			.Quantity = 15
		})
		list.Add(New Product() With {
			.CompanyName = "Bottom-Dollar Markets",
			.Country = "Canada",
			.City = "Tsawwassen",
			.UnitPrice = 44,
			.Quantity = 16
		})
		Return list
	End Function
End Class
