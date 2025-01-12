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
    public partial class MainWindow : Window
    {
        private ToDoList _todoList;
        public MainWindow()
        {
            InitializeComponent();
            _todoList = new ToDoList();
        }
        public void AddButton_Click(object sender, RoutedEventArgs e)
        {
            string option = TaskTextBox.Text;

            if (!string.IsNullOrWhiteSpace(option))
            {
                _todoList.AddTask(option);
                UpdateTaskList();
                TaskTextBox.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a task!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void UpdateTaskList()
        {
            TasksListBox.Items.Clear();
            foreach (var task in _todoList.GetTasks())
            {
                TasksListBox.Items.Add(task);
            }
        }

        public void RemoveButton_Click(Object sender, RoutedEventArgs e)
        {
            var selectedIndex = TasksListBox.SelectedIndex;

            if (selectedIndex >= 0)
            {
                _todoList.RemoveTask(selectedIndex);
                UpdateTaskList();
            }
            else if (_todoList.GetTasks().Count == 0)
            {
                MessageBox.Show("No tasks exist in the list", "Error", MessageBoxButton.OK,MessageBoxImage.Error);
            }
            else
            {
                MessageBox.Show("Please select a task to remove.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}