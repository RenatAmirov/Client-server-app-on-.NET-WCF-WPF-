using System.Windows;
using WpfOrdersApplication.OrdersService;

namespace WpfOrdersApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var client = new OrderServiceClient();
            var orders = client.GetOrders();
            ordersGrid.DataContext = orders;
        }
    }
}
