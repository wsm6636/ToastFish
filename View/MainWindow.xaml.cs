﻿using Microsoft.Toolkit.Uwp.Notifications;
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
using ToastFish.PushControl;
using ToastFish.ViewModel;
using Windows.Foundation.Collections;

namespace ToastFish
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //ToastNotificationManagerCompat.OnActivated += toastArgs =>
            //{
            //    ToastArguments Args = ToastArguments.Parse(toastArgs.Argument);
            //    string Status = Args["action"];
            //    if (Status == "succeed")
            //    {
            //        PushWords.PUSH_CURRENT_STATUS = 1;
            //    }
            //    else
            //    {
            //        PushWords.PUSH_CURRENT_STATUS = 0;
            //    }
            //};
            //Task<bool> ProcessToastNotification()
            //{
            //    var tcs = new TaskCompletionSource<bool>();

            //    ToastNotificationManagerCompat.OnActivated += toastArgs =>
            //    {
            //        ToastArguments Args = ToastArguments.Parse(toastArgs.Argument);
            //        string Status = Args["action"];
            //        if (Status == "succeed")
            //        {
            //            tcs.SetResult(true);
            //        }
            //        else
            //        {
            //            tcs.SetResult(false);
            //        }
            //    };

            //    return tcs.Task;
            //}
        }
    }
}
