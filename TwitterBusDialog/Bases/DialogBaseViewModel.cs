using Prism.Mvvm;
using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Media;
using System.Windows.Interop;
using System.Windows;
using System.Windows.Media.Imaging;
using Prism.Commands;

namespace TwitterBusDialog.Bases
{
    public class DialogBaseViewModel : BindableBase, IDialogAware
    {
        /// <summary>タイトル を取得、設定</summary>
        private string title_;
        /// <summary>タイトル を取得、設定</summary>
        public string Title
        {
            get { return this.title_; }
            set { this.SetProperty(ref this.title_, value); }
        }

        /// <summary>メッセージ を取得、設定</summary>
        private string message_;
        /// <summary>メッセージ を取得、設定</summary>
        public string Message
        {
            get { return this.message_; }
            set { this.SetProperty(ref this.message_, value); }
        }

        /// <summary>アイコン を取得、設定</summary>
        private MessageBoxIcon icon_;
        /// <summary>アイコン を取得、設定</summary>
        public MessageBoxIcon Icon
        {
            get { return this.icon_; }
            set { this.SetProperty(ref this.icon_, value); }
        }


        /// <summary>アイコンソース を取得、設定</summary>
        private ImageSource imageSourse_;
        /// <summary>アイコンソース を取得、設定</summary>
        public ImageSource ImageSource
        {
            get { return this.imageSourse_; }
            set { this.SetProperty(ref this.imageSourse_, value); }
        }

        public event Action<IDialogResult> RequestClose;

        /// <summary>クローズコマンド を取得、設定</summary>
        private DelegateCommand closeCommand_;
        /// <summary>クローズコマンド を取得、設定</summary>
        public DelegateCommand CloseCommand { get { return this.closeCommand_ ?? (this.closeCommand_ = new DelegateCommand(this.Close)); } }

        protected virtual void Close()
        {
            this.RequestClose?.Invoke(new Prism.Services.Dialogs.DialogResult());
        }

        public virtual bool CanCloseDialog()
        {
            return true;
            //throw new NotImplementedException();
        }

        public virtual void OnDialogClosed()
        {
            //throw new NotImplementedException();
        }

        public virtual void OnDialogOpened(IDialogParameters parameters)
        {
            this.Title = parameters.GetValue<string>("Title");
            this.Message = parameters.GetValue<string>("Message");
            this.Icon = parameters.GetValue<MessageBoxIcon>("Icon");

            var bitmap = new Bitmap(50,50);
            var g = Graphics.FromImage(bitmap);
            switch (this.Icon) {
                case MessageBoxIcon.Question:
                    g.DrawIcon(SystemIcons.Question, 0, 0);
                    break;
                case MessageBoxIcon.Error:
                    g.DrawIcon(SystemIcons.Error, 0, 0);
                    break;
                case MessageBoxIcon.Warning:
                    g.DrawIcon(SystemIcons.Warning, 0, 0);
                    break;
                case MessageBoxIcon.Information:
                    g.DrawIcon(SystemIcons.Information, 0, 0);
                    break;
                default:
                    break;
            }
            var hbitmap = bitmap.GetHbitmap();
            this.ImageSource = Imaging.CreateBitmapSourceFromHBitmap(hbitmap, IntPtr.Zero, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());

            //throw new NotImplementedException();
        }

        public DialogBaseViewModel()
        {

        }
    }
}
