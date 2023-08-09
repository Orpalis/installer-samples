using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DocumentViewer
{
    /// <summary>
    /// Interaction logic for ColorPicker.xaml
    /// </summary>
    public partial class ColorPicker : Window
    {
        public ColorPicker()
        {
            InitializeComponent();
        }

        private Color _color;

        public Color BackColor
        {
            //set the person name
            set { this._color = value; }
            //get the person name 
            get { return this._color; }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            BackColor = (Color)ColorConverter.ConvertFromString(color.Text);
            this.DialogResult = true;
            this.Close();
        }
    }
}
