using System.Diagnostics.Eventing.Reader;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace pract5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        
        


        private void tb_input_Click(object sender, RoutedEventArgs e)
        {

            
            string str1 = tb_t1.Text;
            string str2 = tb_t2.Text;
            string str3 = tb_t3.Text;
            string[] words1 = str1.Split(' ');
            string[] words2 = str2.Split(' '); 
            string[] words3 = str3.Split(' '); 
           
            
            int[] a = new int[3];
            int[] b = new int[3];
            int[] c = new int[3];
            
            if ((words1.Length == 3) && (words2.Length == 3) && (words3.Length == 3))
            {

                for (int i = 0; i < words1.Length; i++)
                {

                    int q, w, r;
                    bool f1, f2, f3;
                    f1 = int.TryParse(words1[i], out q);
                    f2 = int.TryParse(words2[i], out w);
                    f3 = int.TryParse(words3[i], out r);
                    if (f1 && f2 && f3)
                    {
                        a[i] = q;
                        b[i] = w;
                        c[i] = r;
                    }
                    else MessageBox.Show("Некоректный формат");
                    


                }
                Triad triad1 = new Triad(a[0], a[1], a[2]);
                Triad triad2 = new Triad(b[0], b[1], b[2]);
                Triad triad3 = new Triad(c[0], c[1], c[2]);

                bool f5 = Triad.Equals(triad1, triad2);
                if (f5) tb_1a2t.Text = "1 и 2 равны  ";
                else tb_1a2t.Text = "1 и 2 не равны  ";

                bool f6 = Triad.Equals(triad2, triad3);
                if (f6) tb_2a3t.Text = "2 и 3 равны  ";
                else tb_2a3t.Text = "2 и 3 не равны  ";

                bool f7 = Triad.Equals(triad1, triad3);
                if (f7) tb_1a3t.Text = "1 и 3 равны  ";
                else tb_1a3t.Text = "1 и 3 не равны  ";

                bool f8 = Triad.Equals(triad1, triad2, triad3);
                if (f8) tb_3t.Text = "Они равны";
                else tb_3t.Text = "Они не равны ";
            }
            else
            {
                
                MessageBox.Show("Не везде по 3 числа");
            }
            
                

        }
        



        
        private void bt_esc_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void bt_inf_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Создать класс Triad (тройка нечетных чисел). Создать необходимые методы и \r\nсвойства. Определить метод сравнения двух триад на равенство. Создать \r\nперегруженный метод сравнения трех триад на равенство. Разработчик студент ИСП-31 Карпушин А.Д", "Информация о программе");
        }

        private void bt_clear_Click(object sender, RoutedEventArgs e)
        {
            tb_1a2t.Clear();
            tb_1a3t.Clear();
            tb_2a3t.Clear();
            tb_3t.Clear();
            
        }
    }
}
