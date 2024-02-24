using Microsoft.VisualBasic;
using Newtonsoft.Json;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Interlock
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window,INotifyPropertyChanged
    {

       

        public Thread thread { get; set; }


        public string folderlocation = "../../../StaticFile";

        private ObservableCollection<Car> _cars;

        public ObservableCollection<Car> Cars 
        {
            get { return _cars; }
            set { _cars = value; OnPropertyChanged(); }
        }


        public MainWindow()
        {
            Cars = new ObservableCollection<Car>();
            DataContext = this;
            InitializeComponent();
        }

        public void ThreadSingle()
        {
            foreach (var filePath in Directory.GetFiles(folderlocation))
            {
                
                if (File.Exists(filePath))
                {
                    
                   
                        string jsonContent = File.ReadAllText(filePath);
                        var obj = JsonConvert.DeserializeObject<ObservableCollection<Car>>(jsonContent);
                            foreach (var item in obj)
                            {
                                 Application.Current.Dispatcher.Invoke(() => Cars.Add(item));

                            }


                }
            }
        }



        public void MultiThread()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            object _lock = new object();
            Cars.Clear();
            List<Thread> threads = new List<Thread>();
            foreach (var filePath in Directory.GetFiles(folderlocation))
            {
                Thread newthrd1 = new Thread(() =>
                {



                    if (File.Exists(filePath))
                    {


                        string jsonContent = File.ReadAllText(filePath);
                        var obj = JsonConvert.DeserializeObject<ObservableCollection<Car>>(jsonContent);
                           
                           foreach (var item in obj)

                           {
                            lock (_lock)
                            {
                                Application.Current.Dispatcher.Invoke(() => Cars.Add(item));
                            }
                          }
                            


                    }
                });

                threads.Add(newthrd1);
           }
        

            foreach (var item in threads)
            {
                item.Start();
            }
            sw.Stop();
            Application.Current.Dispatcher.Invoke(() =>
            {
                listview.ItemsSource = Cars;
                time.Content=sw.Elapsed.Milliseconds.ToString();
                

            });

        }

        private async void StartClick(object sender, RoutedEventArgs e)
        {
           
            if (multi.IsChecked == true)
            {
               
                MultiThread();
              


               



            }

            if (single.IsChecked == true)
            {
                Cars.Clear();
                thread = new Thread(() =>
                {
                    Stopwatch stopwatch = new Stopwatch();
                    stopwatch.Start();
                    ThreadSingle();
                    stopwatch.Stop();
                    Application.Current.Dispatcher.Invoke(() =>
                    {
                        listview.ItemsSource = Cars;

                        time.Content = stopwatch.Elapsed.Milliseconds.ToString();
                        
                    });
                });
                thread.Start();
                

            }
        }


        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string? propertyName = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

      
    }
}