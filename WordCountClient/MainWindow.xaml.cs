using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WordCountClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly HttpClient _httpClient;
        private string uri = "https://localhost:44388/wordcount";

        public MainWindow(HttpClient httpClient)
        {
            InitializeComponent();
            _httpClient = httpClient;
        }

        private void fromFIleBtn_Click(object sender, RoutedEventArgs e)
        {
            string openText;
            var OpenFile = new Microsoft.Win32.OpenFileDialog();
            OpenFile.DefaultExt = ".txt";
            OpenFile.Filter = "Text documents (.txt)|*.txt";
            Nullable<bool> Success = OpenFile.ShowDialog();

            if (Success.HasValue && Success.Value)
            {
                openText = System.IO.File.ReadAllText(OpenFile.FileName);
                CountWords(HttpMethod.Post, openText);
            }
            else
            {
                wordCountLbl.Content = "Error reading file!";
            }
        }

        private void fromDatabaseBtn_Click(object sender, RoutedEventArgs e)
        {
            CountWords(HttpMethod.Get);
        }

        private void fromInputBtn_Click(object sender, RoutedEventArgs e)
        {
            CountWords(HttpMethod.Post, textBoxInput.Text);
        }
        private async void CountWords(HttpMethod method, string textToCount = "")
        {
            HttpResponseMessage response = null;
            if (method == HttpMethod.Post)
            {
                var jsonString = JsonConvert.SerializeObject(textToCount);
                var content = new StringContent(jsonString, Encoding.UTF8, "application/json");
                response = await _httpClient.PostAsync(uri, content);
            }
            else if (method == HttpMethod.Get)
            {
                response = await _httpClient.GetAsync(uri);
            }

            response.EnsureSuccessStatusCode();
            if (response.IsSuccessStatusCode)
            {
                wordCountLbl.Content = "Word Count: " + await response.Content.ReadAsStringAsync();
            }
            else
            {
                wordCountLbl.Content = "Word Count: Error";
            }
        }

    }
}
