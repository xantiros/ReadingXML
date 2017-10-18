using System.Windows;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace ReadingXML
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public class Person
        {
            [XmlElement("Name")]
            public string Name { get; set; }
            [XmlElement("Surname")]
            public string Surname { get; set; }
            [XmlElement("PhoneNo")]
            public string PhoneNo { get; set; }
            [XmlElement("Country")]
            public string Country { get; set; }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            var peopleList = XElement.Load(@"C:\Users\bklima\source\repos\ReadingXML\ReadingXML\authors.xml");
            this.dataGrid.DataContext = peopleList;
        }
    }
}
