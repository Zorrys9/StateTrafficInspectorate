﻿#pragma checksum "..\..\..\Setting\AdminMainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7BF9DEDE82018F442B6F25728EA34970B4BC6292621676F073157470174C59C2"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using StateTrafficInspectorate.Setting;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace StateTrafficInspectorate.Setting {
    
    
    /// <summary>
    /// AdminMainWindow
    /// </summary>
    public partial class AdminMainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\Setting\AdminMainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ChangeLogin;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Setting\AdminMainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ChangePassword;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Setting\AdminMainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NewLogin;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Setting\AdminMainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CurrentLogin;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Setting\AdminMainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox NewPassword;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Setting\AdminMainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox CurrentPassword;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Setting\AdminMainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Back;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Setting\AdminMainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DataBaseChange;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Setting\AdminMainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock DataBaseInfo;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/StateTrafficInspectorate;component/setting/adminmainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Setting\AdminMainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 9 "..\..\..\Setting\AdminMainWindow.xaml"
            ((System.Windows.Controls.Grid)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Grid_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ChangeLogin = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\Setting\AdminMainWindow.xaml"
            this.ChangeLogin.Click += new System.Windows.RoutedEventHandler(this.ChangeLogin_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ChangePassword = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\Setting\AdminMainWindow.xaml"
            this.ChangePassword.Click += new System.Windows.RoutedEventHandler(this.ChangePassword_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.NewLogin = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.CurrentLogin = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.NewPassword = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 7:
            this.CurrentPassword = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 8:
            this.Back = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\Setting\AdminMainWindow.xaml"
            this.Back.Click += new System.Windows.RoutedEventHandler(this.Back_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.DataBaseChange = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\Setting\AdminMainWindow.xaml"
            this.DataBaseChange.Click += new System.Windows.RoutedEventHandler(this.DataBaseChange_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.DataBaseInfo = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
