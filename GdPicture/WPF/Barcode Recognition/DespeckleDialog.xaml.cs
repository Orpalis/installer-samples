using GdPicture14;
using System;
using System.Windows;

namespace Csharp_Barcode_Recognition.WPF
{
    /// <summary>
    /// Interaction logic for Despeckle.xaml
    /// </summary>
    public partial class DespeckleDialog : Window
    {
        //Reference to Main window(MainWindow)
        MainWindow m_Window;

        public DespeckleDialog(MainWindow windowReference)
        {
            m_Window = windowReference;
            InitializeComponent();
            foreach (var item in Enum.GetValues(typeof(DespeckleType)))
            {
                cmbDespeckleType.Items.Add(item);
            }
            cmbDespeckleType.SelectedIndex = 0;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void nDespeckleStrength_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if ((e.NewValue != e.OldValue) && (e.OldValue != 0))
            {
                txtStrengthVal.Text = ((int)e.NewValue).ToString();
                m_Window._despeckleStrength = (int)e.NewValue;
                m_Window.doDespeckle();
            }
        }

        private void cmbDespeckleType_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            m_Window._despeckleType = (DespeckleType)Enum.Parse(typeof(DespeckleType), cmbDespeckleType.SelectedItem.ToString());
        }
    }
}
