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

namespace _4laba_norml
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

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            Studdent calc = new Studdent();
            try
            {
                calc.Name = txtName.Text;
                calc.Group = txtGroup.Text;

                double tech = double.Parse(txtTech.Text);
                double os = double.Parse(txtOS.Text);
                double internet = double.Parse(txtInternet.Text);
                double ml = double.Parse(txtML.Text);

                calc.Bal["Tech"] = tech;
                calc.Bal["OS"] = os;
                calc.Bal["Internet"] = internet;
                calc.Bal["ML"] = ml;

                double sesia_valid = calc.SessionCalculate(tech, os, internet, ml);
                string studdent = calc.SetStudett(sesia_valid);

                MessageBox.Show($"Студент: {calc.Name}\nГруппа: {calc.Group}\nСредний балл: {sesia_valid:F2}\nСтатус: {studdent}");
            }
            catch
            {
                MessageBox.Show("Ошибка при заполнении данных");
            }
        }
    }
}