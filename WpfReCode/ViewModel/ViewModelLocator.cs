/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocator xmlns:vm="clr-namespace:WpfReCode"
                           x:Key="Locator" />
  </Application.Resources>
  
  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"

  You can also use Blend to do all this with the tool's support.
  See http://www.galasoft.ch/mvvm
*/

using CommonServiceLocator;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using System;

namespace WpfReCode.ViewModel
{

  public class ViewModelLocator
  {
    public ViewModelLocator()
    {
      ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

      /* Register all the viewModel of the view with mapping */

      SimpleIoc.Default.Register<MainViewModel>();
      SimpleIoc.Default.Register<HomePageViewModel>();
      SimpleIoc.Default.Register<ManagePageViewModel>();
      SimpleIoc.Default.Register<AddWindowViewModel>();
    }

    /*
     * Ariel
     * 03/01/22
     * Mapping between the ViewModel and View
     */

    //public static MainViewModel Main => ServiceLocator.Current.GetInstance<MainViewModel>();

    public static MainViewModel Main //static set to be able to access by viewmodelbase
    {
      get
      {
        return ServiceLocator.Current.GetInstance<MainViewModel>();
      }
    }

    public static HomePageViewModel HomePage
    {
      get
      {
        return ServiceLocator.Current.GetInstance<HomePageViewModel>();
      }
    }

    public static ManagePageViewModel ManagePage
    {
      get
      {
        return ServiceLocator.Current.GetInstance<ManagePageViewModel>();
      }
    }

    public static AddWindowViewModel AddWindow
    {
      get
      {
        return ServiceLocator.Current.GetInstance<AddWindowViewModel>();
      }
    }

    /*
     * Ariel 
     * 03/01/22
     * Cleanup - Dispose the class
     */

    public static void Cleanup<T>() where T : class
    {
      try
      {
        SimpleIoc.Default.Unregister<T>();
        SimpleIoc.Default.Register<T>();
      }
      catch (Exception e)
      {
        Console.WriteLine(e.ToString());
      }
    }
  }
}