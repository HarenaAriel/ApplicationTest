using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfReCode.ViewModel
{
  public class HomePageViewModel : ViewModelBase
  {
    public HomePageViewModel()
    {
      LastName = "Logo";
    }

    public string _lastName;

    public string LastName
    {
      get { return _lastName; }
      set
      {
        _lastName = value;
        RaisePropertyChanged(() => LastName);
      }
    }
  }
}
