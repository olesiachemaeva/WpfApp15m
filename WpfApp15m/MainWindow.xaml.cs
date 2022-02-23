using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp15m
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            using (FileStream fs = File.Open("1.xaml", FileMode.Create))
            {
                if (docFDR.Document != null)
                {
                    XamlWriter.Save(docFDR.Document, fs);
                    MessageBox.Show("Файл сохранен");
                }
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            using (FileStream fs = File.Open("1.xaml", FileMode.Open))
            {
                FlowDocument document = XamlReader.Load(fs) as FlowDocument;
                if (document != null)
                    docFDR.Document = document;
                //docViewer.Document = XamlReader.Load(fs) as FlowDocument;
            }
        }
    }
}
