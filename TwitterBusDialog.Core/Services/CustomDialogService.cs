using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using TwitterBusDialog.Core.Interfaces;
using Unity;

namespace TwitterBusDialog.Core.Services
{
    public class CustomDialogService : ICustomDialogService
    {
        [Dependency]
        public IDialogService dialogService_;

        public void Show(string title, string message)
        {
            var param = new DialogParameters()
            {
                { "Title" , title },
                { "Message", message }
            };
            this.dialogService_?.ShowDialog("OKDialog", param, _ => { });
            //throw new NotImplementedException();
        }

        public void Show(string title, string message, MessageBoxIcon icon)
        {
            var param = new DialogParameters()
            {
                { "Title" , title },
                { "Message", message },
                { "Icon", icon }
            };
            this.dialogService_?.ShowDialog("OKDialog", param, _ => { });
            //throw new NotImplementedException();
        }

        public void Show(string title, string message, MessageBoxIcon icon, MessageBoxButtons button)
        {
            var param = new DialogParameters()
            {
                { "Title" , title },
                { "Message", message },
                { "Icon", icon },
                { "Button", button }
            };
            switch (button) {
                case MessageBoxButtons.OK:
                    this.dialogService_?.ShowDialog("OKDialog", param, _ => { });
                    break;
                case MessageBoxButtons.OKCancel:
                    this.dialogService_?.ShowDialog("OKCancelDialog", param, _ => { });
                    break;
                case MessageBoxButtons.AbortRetryIgnore:
                    this.dialogService_?.ShowDialog("AbortRetryIgnoreDialog", param, _ => { });
                    break;
                case MessageBoxButtons.YesNoCancel:
                    this.dialogService_?.ShowDialog("YesNoCancelDialog", param, _ => { });
                    break;
                case MessageBoxButtons.YesNo:
                    this.dialogService_?.ShowDialog("YesNoDialog", param, _ => { });
                    break;
                case MessageBoxButtons.RetryCancel:
                    this.dialogService_?.ShowDialog("RetryCancelDialog", param, _ => { });
                    break;
                default:
                    break;
            }
            
            //throw new NotImplementedException();
        }

        public void ShowAsync(string title, string message)
        {
            throw new NotImplementedException();
        }

        public void ShowAsync(string title, string message, MessageBoxIcon icon)
        {
            throw new NotImplementedException();
        }

        public void ShowAsync(string title, string message, MessageBoxIcon icon, MessageBoxButtons buttons)
        {
            throw new NotImplementedException();
        }

        public CustomDialogService()
        {

        }

    }
}
