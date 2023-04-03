// Copyright (c) Microsoft Corporation and Contributors.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Microsoft.UI.Xaml.Media.Animation;
using Windows.Security.Cryptography.Core;
using CommunityToolkit.WinUI.UI.Animations;
using Microsoft.UI.Xaml.Shapes;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace HouseholdAccountBook.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Home: Page
    {
        public Home()
        {
            this.InitializeComponent();
            //Loaded += HomePage_Loaded;
        }

        /*
        private async void HomePage_Loaded(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            // Ellipseオブジェクトを取得する
            Ellipse myEllipse = FindName("LimitPointCharts") as Ellipse;
            if (myEllipse != null)
            {
                // アニメーションを作成する
                DoubleAnimation myAnimation = new DoubleAnimation();
                myAnimation.Duration = TimeSpan.FromSeconds(2);
                myAnimation.To = 6;
                myAnimation.EasingFunction = new CubicEase() { EasingMode = EasingMode.EaseOut };

                // EllipseオブジェクトのStrokeDashArrayプロパティの２番目の値を変更するアニメーションを再生する
                await myEllipse.StrokeDashArray[1].StartAnimationAsync(myAnimation);
            }
        }*/
    }
}
