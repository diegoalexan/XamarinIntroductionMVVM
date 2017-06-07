using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;

namespace XamarinIntroductionMVVM.ViewModel
{
    public class MainViewModel
    {
        public decimal Pesos { get; set; }

        public ICommand ConvertCommand { get { return new RelayCommand(ConvertMoney); } }

        private void ConvertMoney()
        {
            throw new NotImplementedException();
        }
    }
}
