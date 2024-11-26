using System.Diagnostics.Metrics;
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
using System.IO;

namespace TestLogischeFouten
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random rn = new Random();


        public MainWindow()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            try
            {
                int number = int.Parse(numberTextBox.Text);
                resultTextBox.Text = string.Empty;
                int counter = 1;
                int product = 0;

                while (product <= 1000 && counter < 51)
                {
                    product = number * counter;
                    resultTextBox.Text += $"{counter} x {number} = {product}\n";
                    counter++;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Geef een getal in!", "Foutief input", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void start2Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int product = 0;
                int counter = 1;
                int number = 0;

                number = Convert.ToInt32(numberTextBox.Text);
                resultTextBox.Text = "";

                while (product < 1000 && counter < 51)
                {
                    product = number * counter;
                    resultTextBox.Text = resultTextBox.Text + counter.ToString() + " x " +
                    number.ToString() + " = " + product.ToString() + "\n";
                    counter++;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Geef een getal in!", "Foutief input", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            resultTextBox.Text = String.Empty;
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void ShowImageButton_Click(object sender, RoutedEventArgs e)
        {
            int choice = rn.Next(0, 10);
            switch (choice)
            {
                case 0:
                    ImageBox.Source = new BitmapImage(new Uri(@"C:\Users\suyen\Desktop\C# Essentials (2024-25 - GRPRO)\Hoofdstuk 10 - Foutopsporing\Oefening 1 - TestLogischeFouten\zee0.jpg"));
                    break;
                case 1:
                    ImageBox.Source = new BitmapImage(new Uri(@"C:\Users\suyen\Desktop\C# Essentials (2024-25 - GRPRO)\Hoofdstuk 10 - Foutopsporing\Oefening 1 - TestLogischeFouten\zee1.jpg"));
                    break;
                case 2:
                    ImageBox.Source = new BitmapImage(new Uri(@"C:\Users\suyen\Desktop\C# Essentials (2024-25 - GRPRO)\Hoofdstuk 10 - Foutopsporing\Oefening 1 - TestLogischeFouten\zee2.jpg"));
                    break;
                case 3:
                    ImageBox.Source = new BitmapImage(new Uri(@"C:\Users\suyen\Desktop\C# Essentials (2024-25 - GRPRO)\Hoofdstuk 10 - Foutopsporing\Oefening 1 - TestLogischeFouten\zee3.jpg"));
                    break;
                case 4:
                    ImageBox.Source = new BitmapImage(new Uri(@"C:\Users\suyen\Desktop\C# Essentials (2024-25 - GRPRO)\Hoofdstuk 10 - Foutopsporing\Oefening 1 - TestLogischeFouten\zee4.jpg"));
                    break;
                case 5:
                    ImageBox.Source = new BitmapImage(new Uri(@"C:\Users\suyen\Desktop\C# Essentials (2024-25 - GRPRO)\Hoofdstuk 10 - Foutopsporing\Oefening 1 - TestLogischeFouten\zee5.jpg"));
                    break;
                case 6:
                    ImageBox.Source = new BitmapImage(new Uri(@"C:\Users\suyen\Desktop\C# Essentials (2024-25 - GRPRO)\Hoofdstuk 10 - Foutopsporing\Oefening 1 - TestLogischeFouten\zee6.jpg"));
                    break;
                case 7:
                    ImageBox.Source = new BitmapImage(new Uri(@"C:\Users\suyen\Desktop\C# Essentials (2024-25 - GRPRO)\Hoofdstuk 10 - Foutopsporing\Oefening 1 - TestLogischeFouten\zee7.jpg"));
                    break;
                case 8:
                    ImageBox.Source = new BitmapImage(new Uri(@"C:\Users\suyen\Desktop\C# Essentials (2024-25 - GRPRO)\Hoofdstuk 10 - Foutopsporing\Oefening 1 - TestLogischeFouten\zee8.jpg"));
                    break;
                case 9:
                    ImageBox.Source = new BitmapImage(new Uri(@"C:\Users\suyen\Desktop\C# Essentials (2024-25 - GRPRO)\Hoofdstuk 10 - Foutopsporing\Oefening 1 - TestLogischeFouten\zee9.jpg"));
                    break;
            }

        }

        private void ShowImageWithCheckButton_Click(object sender, RoutedEventArgs e)
        {
            int choice = rn.Next(0, 10);
            string imagePath = $@"C:\Path\To\Images\zee{choice}.jpg";

            if (File.Exists(imagePath))
            {
                ImageBox.Source = new BitmapImage(new Uri(imagePath));
            }
            else
            {
                MessageBox.Show($"Afbeelding zee{choice}.jpg niet aanwezig.", "Foutmelding", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}