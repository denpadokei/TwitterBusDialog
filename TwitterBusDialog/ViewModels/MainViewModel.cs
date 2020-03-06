using NLog;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TwitterBusDialog.Core.Interfaces;
using Unity;

namespace TwitterBusDialog.ViewModels
{
    public class MainViewModel : BindableBase
    {
        //ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*
        #region // プロパティ
        [Dependency]
        public ICustomDialogService dialogService_;

        private Logger Logger => LogManager.GetCurrentClassLogger();
        /// <summary>ダイアログのタイトル を取得、設定</summary>
        private string dialogTitle_;
        /// <summary>ダイアログのタイトル を取得、設定</summary>
        public string DialogTitle
        {
            get { return this.dialogTitle_; }
            set { this.SetProperty(ref this.dialogTitle_, value); }
        }

        /// <summary>ダイアログの本文 を取得、設定</summary>
        private string dialogMessage_;
        /// <summary>ダイアログの本文 を取得、設定</summary>
        public string DialogMessage
        {
            get { return this.dialogMessage_; }
            set { this.SetProperty(ref this.dialogMessage_, value); }
        }

        /// <summary>アイコンリスト を取得、設定</summary>
        private Dictionary<string, MessageBoxIcon> iconList_;
        /// <summary>アイコンリスト を取得、設定</summary>
        public Dictionary<string, MessageBoxIcon> IconList
        {
            get { return this.iconList_; }
            set { this.SetProperty(ref this.iconList_, value); }
        }

        /// <summary>ダイアログのアイコン を取得、設定</summary>
        private object icon_;
        /// <summary>ダイアログのアイコン を取得、設定</summary>
        public object Icon
        {
            get { return this.icon_; }
            set { this.SetProperty(ref this.icon_, value); }
        }

        /// <summary>ボタンリスト を取得、設定</summary>
        private Dictionary<string, MessageBoxButtons> buttonList_;
        /// <summary>ボタンリスト を取得、設定</summary>
        public Dictionary<string, MessageBoxButtons> ButtonList
        {
            get { return this.buttonList_; }
            set { this.SetProperty(ref this.buttonList_, value); }
        }

        /// <summary>ダイアログのボタン を取得、設定</summary>
        private MessageBoxButtons button_;
        /// <summary>ダイアログのボタン を取得、設定</summary>
        public MessageBoxButtons Button
        {
            get { return this.button_; }
            set { this.SetProperty(ref this.button_, value); }
        }

        #endregion
        //ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*
        #region // コマンド
        /// <summary>OKダイアログコマンド を取得、設定</summary>
        private DelegateCommand showDialogCommand_;
        /// <summary>OKダイアログコマンド を取得、設定</summary>
        public DelegateCommand ShowDialogCommand { get { return this.showDialogCommand_ ?? (this.showDialogCommand_ = new DelegateCommand(this.Show)); } }
        #endregion
        //ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*
        #region // コマンド用メソッド
        private void Show()
        {
            if (this.Icon is MessageBoxIcon icon) {
                this.dialogService_.Show(this.DialogTitle, this.DialogMessage, icon, this.Button);
            }
        }
        #endregion
        //ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*
        #region // リクエスト
        #endregion
        //ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*
        #region // オーバーライドメソッド
        #endregion
        //ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*
        #region // プライベートメソッド
        #endregion
        //ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*
        #region // パブリックメソッド
        #endregion
        //ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*
        #region // メンバ変数
        #endregion
        //ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*
        #region // 構築・破棄
        public MainViewModel()
        {
            this.IconList = new Dictionary<string, MessageBoxIcon>()
            {
                { "なし", MessageBoxIcon.None },
                { "質問", MessageBoxIcon.Question },
                { "エラー", MessageBoxIcon.Error },
                { "情報", MessageBoxIcon.Information },
                { "警告", MessageBoxIcon.Warning },
            };

            this.Icon = MessageBoxIcon.Question;

            this.ButtonList = new Dictionary<string, MessageBoxButtons>()
            {
                { "OK", MessageBoxButtons.OK },
                { "中止 再試行 無視", MessageBoxButtons.AbortRetryIgnore },
                { "再試行 キャンセル", MessageBoxButtons.RetryCancel },
                { "OK キャンセル", MessageBoxButtons.OKCancel },
                { "はい いいえ キャンセル", MessageBoxButtons.YesNoCancel },
                { "はい いいえ", MessageBoxButtons.YesNo }
            };

            this.Button = MessageBoxButtons.OK;
        }
        #endregion
    }
}
