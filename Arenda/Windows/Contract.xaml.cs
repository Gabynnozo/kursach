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
    /// Логика взаимодействия для Object.xaml
    /// </summary>
    public partial class Object : Window
    {
        ArendaEntities1 AE = new ArendaEntities1();
        public Object()
        {
            InitializeComponent();
            Update();
        }

        private void Update()
        {
            AE.SaveChanges();
            DGobject.ItemsSource = AE.House.ToList();
        }

        private void DGobject_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            COAC coac=new COAC();
            coac.Show();
            this.Close();
        }
    } 
}
