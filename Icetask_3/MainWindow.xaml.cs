using System.Net.NetworkInformation;
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

namespace Icetask_3
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

        private void DevicesListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void DeviceIdTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void StatusComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void AddDevice_Click(object sender, RoutedEventArgs e)
        {

        }
        string deviceId = DeviceIdTextBox.Text;
        string status = (StatusComboBox.SelectedItem as ComboBoxItem)?.Content.ToString();

            if (string.IsNullOrEmpty(deviceId) || string.IsNullOrEmpty(status))
            {
                MessageBox.Show("Please enter a device ID and select a status.");
                return;
            }

            try
            {
                devices.Add(deviceId, status);
                UpdateDeviceList();
    ClearInputs();
}
            catch (ArgumentException)
            {
    MessageBox.Show("A device with this ID already exists.");
}
        
        private void UpdateStatus_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RemoveDevice_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}