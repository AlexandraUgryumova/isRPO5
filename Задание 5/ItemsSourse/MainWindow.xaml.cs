using ItemsSourse.Models;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ItemsSourse.Views;

namespace ItemsSourse
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow :Window
    {
        private List<City> cities = new List<City>
{
    new City
    {
        Country = "Россия",
        Name = "Екатеринбург",
        Description = "Екатеринбург является самым большим городом на Урале; центр Екатеринбургской агломерации. Один из 15 городов-миллионеров России.",
        Population = 1_500_000,
        Price = 25000,
        PhotoUrl = "https://thumb.tildacdn.com/tild6436-6264-4665-b565-346566393834/-/resize/834x/-/format/webp/shutterstock_1661579.jpg"
    },
    new City
    {
        Country = "Россия",
        Name = "Санкт-Петербург",
        Description = "Третий по численности населения город Европы, первый по численности населения город Европы, не являющийся столицей государства, и самый северный город с населением более миллиона человек; центр Санкт-Петербургской городской агломерации",
        Population = 5_600_044,
        Price = 35000,
        PhotoUrl = "https://avatars.mds.yandex.net/get-marketcms/1779479/img-fa8a7f10-039f-4543-b4ac-da59191126bd.jpeg/optimize"
    },
    new City
    {
        Country = "Россия",
        Name = "Москва",
        Description = "Столица России",
        Population = 99_999_999,
        Price = 25_000_000,
        PhotoUrl = "https://i.msmap.ru/original/331.jpg"
    },
    new City
    {
        Country = "Китай",
        Name = "Пекин",
        Description = "Пекин – столица Китая, история которой насчитывает три тысячелетия. Она славится как своими современными зданиями, так и древними архитектурными памятниками, среди которых величественный Запретный город – императорский дворец времен династий Мин и Цин.",
        Population = 21_500_000,
        Price = 110000,
        PhotoUrl = "https://ic.pics.livejournal.com/dergachev_va/58474394/2270770/2270770_original.jpg"
    },
    new City
    {
        Country = "Франция",
        Name = "Париж",
        Description = "Париж – один из главных европейских городов и мировой центр культуры, искусства, моды и гастрономии. В центральной части города, построенной в XIX веке, проходят широкие бульвары и протекает река Сена. Самые известные достопримечательности Парижа – Эйфелева башня и собор Парижской Богоматери в готическом стиле, возведенный в XII веке.",
        Population = 2_161_000,
        Price = 200000,
        PhotoUrl = "https://tripmydream.cc/travelhub/travel/blocks/12/8828/block_128828.jpg?v1"
    }
};
        private Page[] pages;
        public MainWindow ()
        {
            InitializeComponent();
            pages = new Page[]
            {
                new DataGridPage()
            };
            pagesComboBox.ItemsSource = pages;
            pagesComboBox.DisplayMemberPath = "Title";
        }

        private void pagesComboBox_SelectionChanged (object sender, SelectionChangedEventArgs e)
        {

        }
    }
}