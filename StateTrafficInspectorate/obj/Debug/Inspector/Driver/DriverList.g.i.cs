﻿#pragma checksum "..\..\..\..\Inspector\Driver\DriverList.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F85A677174D5B037508548278C6849B1F1D2ECBCAE69A7CCEBB0219871D83221"
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
    /// DriverList
    /// </summary>
    public partial class DriverList : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\..\Inspector\Driver\DriverList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid ListDriver;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\..\Inspector\Driver\DriverList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Back;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\..\Inspector\Driver\DriverList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button NewDriver;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\..\Inspector\Driver\DriverList.xaml"
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
            System.Uri resourceLocater = new System.Uri("/StateTrafficInspectorate;component/inspector/driver/driverlist.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Inspector\Driver\DriverList.xaml"
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
            this.ListDriver = ((System.Windows.Controls.DataGrid)(target));
            
            #line 10 "..\..\..\..\Inspector\Driver\DriverList.xaml"
            this.ListDriver.Loaded += new System.Windows.RoutedEventHandler(this.DataGrid_Loaded);
            
            #line default
            #line hidden
            
            #line 10 "..\..\..\..\Inspector\Driver\DriverList.xaml"
            this.ListDriver.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.ListDriver_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Back = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\..\..\Inspector\Driver\DriverList.xaml"
            this.Back.Click += new System.Windows.RoutedEventHandler(this.Back_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.NewDriver = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\..\..\Inspector\Driver\DriverList.xaml"
            this.NewDriver.Click += new System.Windows.RoutedEventHandler(this.NewDriver_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.NameDriver = ((System.Windows.Controls.TextBox)(target));
            
            #line 14 "..\..\..\..\Inspector\Driver\DriverList.xaml"
            this.NameDriver.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.NameDriver_TextChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

