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
using NMST = nmssavetool;
using System.IO;

namespace WpfApp1
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void get_Click(object sender, RoutedEventArgs e)
        {
            NMST.Program nmstool = new NMST.Program();
            NMST.DecryptOptions opt = new NMST.DecryptOptions();
            opt.GameMode = NMST.GameModes.normal;
            opt.OutputPath = System.IO.Path.GetTempFileName();
            opt.SaveDir = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "HelloGames\\NMS\\DefaultUser");
            opt.Verbose = false;

            nmstool.RunDecrypt(opt);
        }

    }
}
