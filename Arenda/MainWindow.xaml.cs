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

namespace Arenda
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ArendaEntities1 DB = new ArendaEntities1();
        public MainWindow()
        {
            InitializeComponent();
        }

        public void update()
        {

        }

        private void btlog_Click(object sender, RoutedEventArgs e)
        {
            //Agent agent = DB. Agent.Where(x => x.Login == TBlog.Text && x.Password == PBpass.Password).SingleOrDefault();
            //if (agent == null)
            {
                MessageBox.Show("Такого Пользователя нет");
            }
            //else if (agent.Post == "Старший агент")
            {
                var contract = new Windows.Object();
                contract.Show();
                this.Close();
            }


    }
    }
}
