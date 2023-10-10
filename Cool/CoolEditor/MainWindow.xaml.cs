using System.Windows;
using CoolEditor.Pages;

namespace CoolEditor
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();
      Loaded += OnMainWindow_Loaded;
    }

    private void OnMainWindow_Loaded(object sender, RoutedEventArgs e)
    {
      Loaded -= OnMainWindow_Loaded;
      OpenProjectsBrowser();
    }

    private void OpenProjectsBrowser()
    {
      var projectsBrowser = new ProjectsBrowser();

      if (projectsBrowser.ShowDialog() == false)
      {
        Application.Current.Shutdown();
      }
      else
      {
        projectsBrowser.Show();
      }
    }
  }
}
