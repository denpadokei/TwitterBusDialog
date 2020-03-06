using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterBusDialog.Core.Interfaces
{
    public interface ICustomDialogService
    {
        void Show(String title, String message);
        void ShowAsync(String title, String message);
    }
}
