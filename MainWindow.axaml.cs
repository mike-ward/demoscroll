using System;
using System.IO;
using System.Linq;
using Avalonia;
using Avalonia.Collections;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Threading;

namespace DemoScroll
{
    public class MainWindow : Window
    {
        private const string sample = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";

        public static readonly StyledProperty<AvaloniaList<string>> ItemsProperty = AvaloniaProperty.Register<Window, AvaloniaList<string>>(nameof(Items));

        public AvaloniaList<string> Items
        {
            get => GetValue(ItemsProperty);
            set => SetValue(ItemsProperty, value);
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);

            Items = new AvaloniaList<string>(Enumerable
                .Range(0, 200)
                .Select(_ => Path.GetRandomFileName() + sample));

            var timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromSeconds(2)
            };
            timer.Tick += delegate { Items.Insert(0, Path.GetRandomFileName() + sample); };
            timer.Start();
        }
    }
}