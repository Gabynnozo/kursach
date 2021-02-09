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
        ArendaEntities AE = new ArendaEntities();
        public Object()
        {
            InitializeComponent();
            Update();
        }

        private void Update()
        {
            DGobject.ItemsSource = AE.Object.ToList();
        }
    } 
}
