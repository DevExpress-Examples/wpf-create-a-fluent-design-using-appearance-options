using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace FluentDesignTemplate
{
    public class MainViewModel
    {
        public ObservableCollection<AnalysisItem> AnalysisItems {
            get;
            set;
        }
        public ObservableCollection<ReportItem> Reports {
            get;
            set;
        }
        public ObservableCollection<EventItem> Events {
            get;
            set;
        }
        public MainViewModel() {
            AnalysisItems = new ObservableCollection<AnalysisItem>() { new AnalysisItem() { Header = "Stock", Text = "Market trends", Image = GetImage("Stock.png") },
            new AnalysisItem() { Header = "Metrics", Text = "Key indicators", Image = GetImage("Metrics.png") },
            new AnalysisItem() { Header = "Competitors", Text = "Growth rate, products, prices", Image = GetImage("Competitors.png") },
            new AnalysisItem() { Header = "Distribution", Text = "Warehouse load, logistics", Image = GetImage("Distribution.png") },
            new AnalysisItem() { Header = "Feedback", Text = "Requests, reviews, complaints", Image = GetImage("Feedback.png") }};

            Reports = new ObservableCollection<ReportItem>() { new ReportItem() { Header = "Balance", Image = GetImage("Balance.png") },
            new ReportItem() { Header = "Performance Review", Image = GetImage("Performance Review.png") },
            new ReportItem() { Header = "New Products", Image = GetImage("Produced Products.png") },
            new ReportItem() { Header = "Revenue", Image = GetImage("Revenue.png") },
            new ReportItem() { Header = "Sales", Image = GetImage("Sales.png") },
            new ReportItem() { Header = "Inspection Report", Image = GetImage("Vehicle Inspection.png") }};


            Events = new ObservableCollection<EventItem>() { new EventItem() { Header = "Meeting", Text = "Strategy Review", Type = EventType.Meeting },
            new EventItem() { Header = "Office Party", Text = "New Year’s Celebration", Type = EventType.Celebration },
            new EventItem() { Header = "Off-site event", Text = "Management Training", Type = EventType.OffSite },
            new EventItem() { Header = "Meeting", Text = "COVID-19 Impact", Type = EventType.Meeting },
            new EventItem() { Header = "Off-site event", Text = "Conference", Type = EventType.OffSite }};
        }

        ImageSource GetImage(string name) {
            BitmapImage logo = new BitmapImage();
            logo.BeginInit();
            logo.UriSource = new Uri($"pack://application:,,,/FluentDesignTemplate;component/Images/{name}");
            logo.EndInit();
            return logo;
        }
    }

    public class BaseItem
    {
        public string Header {
            get;
            set;
        }
        public string Text {
            get;
            set;
        }
        public ImageSource Image {
            get;
            set;
        }
    }
    public class AnalysisItem : BaseItem
    {
    }
    public class ReportItem : BaseItem
    {
    }
    public class EventItem : BaseItem
    {
        public EventType Type {
            get;
            set;
        }
    }

    public enum EventType
    {
        Meeting, Celebration, OffSite
    }

}
