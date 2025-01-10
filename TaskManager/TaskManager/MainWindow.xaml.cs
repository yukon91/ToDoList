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

namespace TaskManager
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
        public void AddButton_Click(object sender, RoutedEventArgs e)
        {
            string option = TaskTextBox.Text;

            if (!string.IsNullOrWhiteSpace(option))
            {
                TasksListBox.Items.Add(option);
                   
            }
            else
            {
                MessageBox.Show("Please enter a task!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        public void RemoveButton_Click(Object sender, RoutedEventArgs e)
        {
            var selectedTask = TasksListBox.SelectedItem;

            if (selectedTask != null)
            {
                TasksListBox.Items.Remove(selectedTask);
            }
            else
            {
                MessageBox.Show("Please select a task to remove.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}