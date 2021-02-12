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
using System.Windows.Shapes;

namespace Arenda.Windows
{
    /// <summary>
    /// Логика взаимодействия для COAC.xaml
    /// </summary>
    public partial class COAC : Window
    {
        RentEntities Entities =new RentEntities();
        public COAC()
        {
            InitializeComponent();
            Update();
        }

        public void Update()
        {
            DGCoac.ItemsSource = Entities.Contragent.ToList();
        }

        private void BTback_Click(object sender, RoutedEventArgs e)
        { Windows.Object contract= new Windows.Object();
            contract.Show();
            this.Close(); 
        }
    }

}
