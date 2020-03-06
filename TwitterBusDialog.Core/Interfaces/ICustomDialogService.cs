using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace TwitterBusDialog.Core.Interfaces
{
    public interface ICustomDialogService
    {
        void Show(String title, String message);
        void Show(String title, String message, MessageBoxIcon icon);
        void Show(String title, String message, MessageBoxIcon icon, MessageBoxButtons button);
        void ShowAsync(String title, String message);
        void ShowAsync(String title, String message, MessageBoxIcon icon);
        void ShowAsync(String title, String message, MessageBoxIcon icon, MessageBoxButtons buttons);
    }
}
