﻿#pragma checksum "..\..\..\..\Inspector\Driver\Fine.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "12CEB84DC49D67341D95D29B293ACDE607885B1C154753344F9377DD2BF29B8F"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using StateTrafficInspectorate.Inspector.Driver;
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


namespace StateTrafficInspectorate.Inspector.Driver {
    
    
    /// <summary>
    /// Fine
    /// </summary>
    public partial class Fine : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\..\Inspector\Driver\Fine.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid FineList;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\..\Inspector\Driver\Fine.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Back;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\..\Inspector\Driver\Fine.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button NewDriver;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\..\Inspector\Driver\Fine.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NameDriver;
        
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
            System.Uri resourceLocater = new System.Uri("/StateTrafficInspectorate;component/inspector/driver/fine.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Inspector\Driver\Fine.xaml"
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
            this.FineList = ((System.Windows.Controls.DataGrid)(target));
            
            #line 10 "..\..\..\..\Inspector\Driver\Fine.xaml"
            this.FineList.Loaded += new System.Windows.RoutedEventHandler(this.FineList_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Back = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\..\..\Inspector\Driver\Fine.xaml"
            this.Back.Click += new System.Windows.RoutedEventHandler(this.Back_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.NewDriver = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\..\..\Inspector\Driver\Fine.xaml"
            this.NewDriver.Click += new System.Windows.RoutedEventHandler(this.NewFine_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.NameDriver = ((System.Windows.Controls.TextBox)(target));
            
            #line 14 "..\..\..\..\Inspector\Driver\Fine.xaml"
            this.NameDriver.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.NameDriver_TextChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

