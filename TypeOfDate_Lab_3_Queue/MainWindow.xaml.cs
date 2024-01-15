using System;
using System.Collections.Generic;
using System.Linq;
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

namespace TypeOfDate_Lab_3_Queue
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Stack<int> stack = new Stack<int>();
        private Queue<int> queue = new Queue<int>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void PushStack(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(stackInput.Text.Split('_')[0], out int value))
            {
                stack.Push(value);
                UpdateStackListBox();
            }
            else
            {
                ShowError("Введено некоректное значение");
            }
        }

        private void PopStack(object sender, RoutedEventArgs e)
        {
            if (stack.Count > 0)
            {
                stack.Pop();
                UpdateStackListBox();
            }
            else
            {
                ShowError("Список пуст");
            }
        }

        private void Enqueue(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(queueInput.Text.Split('_')[0], out int value))
            {
                queue.Enqueue(value);
                UpdateQueueListBox();
            }
            else
            {
                ShowError("Введено некоректное значение");
            }
        }

        private void Dequeue(object sender, RoutedEventArgs e)
        {
            if (queue.Count > 0)
            {
                queue.Dequeue();
                UpdateQueueListBox();
            }
            else
            {
                ShowError("Список пуст");
            }
        }

        private void UpdateStackListBox()
        {
            stackListBox.Items.Clear();
            foreach (var item in stack)
            {
                stackListBox.Items.Add(item);
            }
        }

        private void UpdateQueueListBox()
        {
            queueListBox.Items.Clear();
            foreach (var item in queue)
            {
                queueListBox.Items.Add(item);
            }
        }
    }
}
