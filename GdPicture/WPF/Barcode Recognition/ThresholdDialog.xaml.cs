using System;
using System.Windows;
using System.Windows.Controls;

namespace Csharp_Barcode_Recognition.WPF
{
    /// <summary>
    /// Interaction logic for ThresholdDialog.xaml
    /// </summary>
    public partial class ThresholdDialog : Window
    {
        //Reference to Main window(MainWindow)
		MainWindow m_Window;
		//Previous Selection of ComboBox
		int _previous;


        public ThresholdDialog(MainWindow windowReference)
		{
            m_Window = windowReference;
			InitializeComponent();
			
			ComboBox1.SelectedIndex = 0;
			//set previous to Linear by default
			_previous = 0;
		}

        private void sldSmooth_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (e.NewValue != e.OldValue)
            {
                txtSmooth.Text = ((int)e.NewValue).ToString();
                m_Window._smoothKernel = (int)e.NewValue;
                m_Window.doThreshold();
            }
        }

        private void sldThreshold_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (e.NewValue != e.OldValue)
            {
                if (ComboBox1.SelectedIndex == 2)
                {
                    txtThreshold.Text = ((int)(Math.Round((double)sldThreshold.Value / 100, 2))).ToString();
                }
                else
                {
                    txtThreshold.Text = e.NewValue.ToString();
                }

                m_Window._thresholdValue = (int)e.NewValue;
                m_Window.doThreshold();
            }
        }

        private void sldCont_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (e.NewValue != e.OldValue)
            {
                txtCont.Text = ((int)e.NewValue).ToString();
                m_Window._contrastMinDif = (int)e.NewValue;
                m_Window.doThreshold();
            }
        }

        private void ComboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (ComboBox1.SelectedIndex)
            {
                case 0: //Linear
                    if (_previous != 0)
                    {
                        //change threshold parameters
                        lbl1.Content = "Threshold";
                        sldThreshold.Minimum = 1;
                        sldThreshold.Maximum = 254;
                        sldThreshold.Value = 128;
                        txtThreshold.Text = sldThreshold.Value.ToString();
                        lbl2.Visibility = Visibility.Hidden;
                        lbl3.Visibility = Visibility.Hidden;
                        sldCont.Visibility = Visibility.Hidden;
                        sldSmooth.Visibility = Visibility.Hidden;
                        txtCont.Visibility = Visibility.Hidden;
                        txtSmooth.Visibility = Visibility.Hidden;
                    }
                    _previous = 0;
                    break;
                case 1: //Adaptive (Otsu)
                    if (_previous != 1)
                    {
                        //change threshold parameters
                        lbl1.Content = "Threshold";
                        sldThreshold.Minimum = 0;
                        sldThreshold.Maximum = 100;
                        sldThreshold.Value = 50;
                        txtThreshold.Text = sldThreshold.Value.ToString();
                        lbl2.Visibility = Visibility.Hidden;
                        lbl3.Visibility = Visibility.Hidden;
                        sldCont.Visibility = Visibility.Hidden;
                        sldSmooth.Visibility = Visibility.Hidden;
                        txtCont.Visibility = Visibility.Hidden;
                        txtSmooth.Visibility = Visibility.Hidden;

                    }
                    _previous = 1;
                    break;
                case 2: //Sauvola
                    if (_previous != 2)
                    {
                        lbl1.Content = "Factor";
                        sldThreshold.Minimum = 0;
                        sldThreshold.Maximum = 100;
                        sldThreshold.Value = 35;
                        txtThreshold.Text = (string)(Math.Round((double)sldThreshold.Value / 100, 2).ToString());
                        lbl2.Visibility =Visibility.Visible;
                        lbl3.Visibility = Visibility.Visible;
                        sldCont.Visibility = Visibility.Visible;
                        sldSmooth.Visibility = Visibility.Visible;
                        txtCont.Visibility = Visibility.Visible;
                        txtSmooth.Visibility = Visibility.Visible;

                    }
                    _previous = 2;
                    break;
            }
            m_Window._thresholdType = _previous;
            m_Window.doThreshold();
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

       
    }
}
