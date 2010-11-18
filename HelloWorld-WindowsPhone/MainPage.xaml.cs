using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace HelloWorld_WindowsPhone
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnSaveTheWorld_Click(object sender, RoutedEventArgs e)
        {
            string ninjaPhrase = tbNinjaPhrase.Text;
            if (!string.IsNullOrEmpty(ninjaPhrase))
            {
                if (string.Compare("startrek", ninjaPhrase, StringComparison.OrdinalIgnoreCase) == 0)
                {
                    messageBlock.Text = "Vola! Way to go Ninja, You saved the world!";
                }
                else
                {
                    messageBlock.Text = "That is not a Ninja Phrase! You cannot save the world!";
                }
            }
            else
            {
                messageBlock.Text = "Are you kidding? That is not a Ninja Phrase! You cannot save the world!";
            }
        }
    }
}