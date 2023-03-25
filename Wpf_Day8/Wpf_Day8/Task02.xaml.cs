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
using System.Windows.Shapes;

namespace Wpf_Day8
{
    /// <summary>
    /// Interaction logic for Task02.xaml
    /// </summary>
    public partial class Task02 : Window
    {
        public Task02()
        {
            InitializeComponent();
        }

        private void RBtnAllignRight(object sender, RoutedEventArgs e)
        {
            outputTextBox.TextAlignment = TextAlignment.Right;
        }

        private void RBtnAllignCener(object sender, RoutedEventArgs e)
        {
            outputTextBox.TextAlignment = TextAlignment.Center;
        }

        private void RBtnAllignLeft(object sender, RoutedEventArgs e)
        {
            outputTextBox.TextAlignment = TextAlignment.Left;
        }

        private void RBtnReadOnly(object sender, RoutedEventArgs e)
        {
            outputTextBox.IsEnabled = false;
        }

        private void RBtnEnable(object sender, RoutedEventArgs e)
        {
            outputTextBox.IsEnabled = true;
        }

        private void BtnSetText(object sender, RoutedEventArgs e)
        {
            outputTextBox.Text = "Replace default text with initial text value";
        }

        private void BtnSelectAll(object sender, RoutedEventArgs e)
        {
            outputTextBox.Focus();
            outputTextBox.SelectAll();
        }

        private void BtnClear1(object sender, RoutedEventArgs e)
        {
            outputTextBox.Clear();
        }

        private void BtnPrepend1(object sender, RoutedEventArgs e)
        {
            
            outputTextBox.Text = $"*** Prepended text ***{outputTextBox.Text} ";
        }
        private void BtnInsert1(object sender, RoutedEventArgs e)
        {
            outputTextBox.Text = $" *** inserted text *** {outputTextBox.Text}";
        }

        private void BtnAppend1(object sender, RoutedEventArgs e)
        {
            outputTextBox.AppendText(" *** appended text ***");
        }

        private void BtnCut1(object sender, RoutedEventArgs e)
        {
            MessageBoxResult boxResult;
            if (outputTextBox.SelectedText != "")
            {
                boxResult = MessageBox.Show($"cut '{outputTextBox.Text}'", "Saving", MessageBoxButton.OK, MessageBoxImage.Information, MessageBoxResult.OK);
                outputTextBox.Cut();
            }
            else
                boxResult = MessageBox.Show($"select text to cut", "Saving", MessageBoxButton.OK, MessageBoxImage.Information, MessageBoxResult.OK);

        }

        private void BtnPaste1(object sender, RoutedEventArgs e)
        {
            outputTextBox.Paste();
        }

        private void BtnUndo1(object sender, RoutedEventArgs e)
        {
            MessageBoxResult boxResult;
            if (outputTextBox.CanUndo)
                outputTextBox.Undo();
            else
                 boxResult = MessageBox.Show($"can't undo", "undo message", MessageBoxButton.OK, MessageBoxImage.Information, MessageBoxResult.OK);

        }
    }
}

