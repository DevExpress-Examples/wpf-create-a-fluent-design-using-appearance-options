Imports DevExpress.Mvvm
Imports System
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Media
Imports System.Windows.Media.Imaging

Namespace FluentDesignTemplate
	Public Class MainViewModel
		Public Property AnalysisItems() As ObservableCollection(Of AnalysisItem)
		Public Property Reports() As ObservableCollection(Of ReportItem)
		Public Property Events() As ObservableCollection(Of EventItem)
		Public Sub New()
			AnalysisItems = New ObservableCollection(Of AnalysisItem)() From {
				New AnalysisItem() With {
					.Header = "Stock",
					.Text = "Market trends",
					.Image = GetImage("Stock.png")
				},
				New AnalysisItem() With {
					.Header = "Metrics",
					.Text = "Key indicators",
					.Image = GetImage("Metrics.png")
				},
				New AnalysisItem() With {
					.Header = "Competitors",
					.Text = "Growth rate, products, prices",
					.Image = GetImage("Competitors.png")
				},
				New AnalysisItem() With {
					.Header = "Distribution",
					.Text = "Warehouse load, logistics",
					.Image = GetImage("Distribution.png")
				},
				New AnalysisItem() With {
					.Header = "Feedback",
					.Text = "Requests, reviews, complaints",
					.Image = GetImage("Feedback.png")
				}
			}

			Reports = New ObservableCollection(Of ReportItem)() From {
				New ReportItem() With {
					.Header = "Balance",
					.Image = GetImage("Balance.png")
				},
				New ReportItem() With {
					.Header = "Performance Review",
					.Image = GetImage("Performance Review.png")
				},
				New ReportItem() With {
					.Header = "Produced Products",
					.Image = GetImage("Produced Products.png")
				},
				New ReportItem() With {
					.Header = "Revenue",
					.Image = GetImage("Revenue.png")
				},
				New ReportItem() With {
					.Header = "Sales",
					.Image = GetImage("Sales.png")
				},
				New ReportItem() With {
					.Header = "Vehicle Inspection",
					.Image = GetImage("Vehicle Inspection.png")
				}
			}


			Events = New ObservableCollection(Of EventItem)() From {
				New EventItem() With {
					.Header = "Meeting",
					.Text = "Strategy discussion",
					.Type = EventType.Meeting
				},
				New EventItem() With {
					.Header = "Celebration",
					.Text = "New Year Party",
					.Type = EventType.Celebration
				},
				New EventItem() With {
					.Header = "Off-site event",
					.Text = "Management seminar",
					.Type = EventType.OffSite
				},
				New EventItem() With {
					.Header = "Meeting",
					.Text = "COVID-19 impact",
					.Type = EventType.Meeting
				},
				New EventItem() With {
					.Header = "Off-site event",
					.Text = "Conference",
					.Type = EventType.OffSite
				}
			}
		End Sub

		Private Function GetImage(ByVal name As String) As ImageSource
			Dim logo As New BitmapImage()
			logo.BeginInit()
			logo.UriSource = New Uri($"pack://application:,,,/FluentDesignTemplate;component/Images/{name}")
			logo.EndInit()
			Return logo
		End Function
	End Class

	Public Class BaseItem
		Public Property Header() As String
		Public Property Text() As String
		Public Property Image() As ImageSource
	End Class
	Public Class AnalysisItem
		Inherits BaseItem

	End Class
	Public Class ReportItem
		Inherits BaseItem

	End Class
	Public Class EventItem
		Inherits BaseItem

		Public Property Type() As EventType
	End Class

	Public Enum EventType
		Meeting
		Celebration
		OffSite
	End Enum

End Namespace
