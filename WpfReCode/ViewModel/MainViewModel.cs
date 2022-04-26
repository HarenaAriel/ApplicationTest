using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Windows.Input;
using WpfReCode.View;

namespace WpfReCode.ViewModel
{

  public class MainViewModel : ViewModelBase
  {
    public MainViewModel()
    {
      Name = "Test Modif";
      CurrentView = ViewModelLocator.HomePage;
    }

    /*
     * Ariel
     * 04/01/22
     * Command to View
     */

    public ICommand HomePageView => new RelayCommand(() => 
    {
      try
      {
        ViewModelLocator.Cleanup<ManagePageViewModel>();
        CurrentView = ViewModelLocator.HomePage;
      }
      catch (Exception e)
      {
        Console.WriteLine(e.ToString());
      }
    });

    public ICommand ManagePageView => new RelayCommand(() =>
    {
      try
      {
        ViewModelLocator.Cleanup<HomePageViewModel>();
        CurrentView = ViewModelLocator.ManagePage;
      }
      catch (Exception e)
      {
        Console.WriteLine(e.ToString());
      }
    });

    public ICommand ShowAddWindow => new RelayCommand(() => 
    {
      try
      {
        _addWindow = new AddWindowView();
        _addWindow.ShowDialog();
      }
      catch (Exception e)
      {
        Console.WriteLine(e.ToString());
      }
    });

    /*
     * Ariel
     * 04/01/22
     * Class Fields
     */

    private AddWindowView _addWindow;
    private string _name;
    private ViewModelBase _currentView;

    /*
     * Ariel
     * 04/01/22
     * Getters and Setters Section
     */

    public string Name
    {
      get { return _name; }
      set
      {
        _name = value;
        RaisePropertyChanged(() => Name);
      }
    }

    public ViewModelBase CurrentView
    {
      get { return _currentView; }
      set
      {
        _currentView = value;
        RaisePropertyChanged(() => CurrentView);
      }
    }

  }
}