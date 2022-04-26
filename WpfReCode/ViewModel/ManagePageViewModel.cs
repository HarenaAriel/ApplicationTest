using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfReCode.ViewModel
{
  public class ManagePageViewModel : ViewModelBase
  {
    public ManagePageViewModel()
    {
      Message = "Manage Page";
    }

    private string _message;

    public string Message
    {
      get { return _message; }
      set
      {
        _message = value;
        RaisePropertyChanged(() => Message);
      }
    }

  }

}
