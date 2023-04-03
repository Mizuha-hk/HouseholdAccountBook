// Copyright (c) Microsoft Corporation and Contributors.
// Licensed under the MIT License.

using HouseholdAccountBook.Pages;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace HouseholdAccountBook
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();

            ExtendsContentIntoTitleBar = true;
            SetTitleBar(TitleBar);

            MainContent.Navigate(typeof(Home));
        }


        //サイドバーによるページ遷移処理------------------
        public void HomeButtonClicked(object sender, RoutedEventArgs e)
        {
            MainContent.Navigate(typeof(Home));
        }

        public void RecordButtonClicked(object sender, RoutedEventArgs e)
        {
            MainContent.Navigate(typeof (Record));
        }

        public void HistoryButtonClicked(object sender, RoutedEventArgs e)
        {
            MainContent.Navigate(typeof (History));
        }

        public void SettingButtonClicked(object sender, RoutedEventArgs e)
        {
            MainContent.Navigate(typeof(Settings));
        }
        //-------------------------------------------
    }
}
