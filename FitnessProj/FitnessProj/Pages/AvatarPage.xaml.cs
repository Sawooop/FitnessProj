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

namespace FitnessProj.Pages
{
    /// <summary>
    /// Interaction logic for AvatarPage.xaml
    /// </summary>
    public partial class AvatarPage : Page
    {
        public AvatarPage()
        {
            InitializeComponent();
            /*Image LevelImage = new Image();
            BitmapImage bi1 = new BitmapImage();
            bi1.BeginInit();
            bi1.UriSource = new Uri("https://www.bing.com/images/search?view=detailV2&ccid=wySw%2flok&id=E0DBF07378CC558A6562A46B71057904A0BDECEF&thid=OIP.wySw_lok3s7OoinW-MweagHaJN&mediaurl=https%3a%2f%2foutline-prod.imgix.net%2f20170316-M4uLvNJu3IxkSy60g03P%3fauto%3dformat%26q%3d60%26w%3d1280%26s%3d53ccc9ad4ad3e9d116d4fb6291f1eb43&exph=1591&expw=1280&q=club+penguin&simid=607999843150069926&selectedIndex=6&ajaxhist=0", UriKind.Relative);
            bi1.EndInit();
            LevelImage.Stretch = Stretch.Fill;
            LevelImage.Source = bi1;*/
            if (Globals.level == 1)
            {
                LevelImage.Source = new BitmapImage(new Uri(@"C:\Users\admin\pictures\gaaa.png"));
            }
            else if (Globals.level == 2)
            {
                LevelImage.Source = new BitmapImage(new Uri(@"C:\Users\admin\pictures\lvl2imgreal.bmp"));
            }
            else if (Globals.level == 3)
            {
                LevelImage.Source = new BitmapImage(new Uri(@"C:\Users\admin\pictures\lvl3imgreal.png"));
            }
            else if (Globals.level == 4)
            {
                LevelImage.Source = new BitmapImage(new Uri(@"C:\Users\admin\pictures\lvl4imgreal.png"));
            }
            else if (Globals.level == 5)
            {
                LevelImage.Source = new BitmapImage(new Uri(@"C:\Users\admin\pictures\lvl5imgreal.png"));
            }
            else if (Globals.level == 6)
            {
                LevelImage.Source = new BitmapImage(new Uri(@"C:\Users\admin\pictures\lvl6img.bmp"));
            }
            // ActivityVideo.Source
            ActivityVideo.Stop();
            HeartbeatImage.Source = new BitmapImage(new Uri(@"C:\Users\admin\pictures\Big bois " + Globals.level + ".png"));
        }

        private void PlayVideo_Click(object sender, RoutedEventArgs e)
        {
            ActivityVideo.Play();
        }
    }
}
