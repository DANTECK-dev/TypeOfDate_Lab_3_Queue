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

        private void PushStack(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(stackInput.Text.Split('_')[0], out int value))
            {
                stack.Push(value);
                UpdateStackListBox();
            }
        }

        private void PopStack(object sender, RoutedEventArgs e)
        {
            if (stack.Count > 0)
            {
                stack.Pop();
                UpdateStackListBox();
            }
        }

        private void Enqueue(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(queueInput.Text.Split('_')[0], out int value))
            {
                queue.Enqueue(value);
                UpdateQueueListBox();
            }
        }

        private void Dequeue(object sender, RoutedEventArgs e)
        {
            if (queue.Count > 0)
            {
                queue.Dequeue();
                UpdateQueueListBox();
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
