﻿#pragma checksum "..\..\..\..\Inspector\Transport\TransportList.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9C1033A1EBF4458755B1815DDEC2B580BEB5EEA57438417AC7B3244747B87364"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using StateTrafficInspectorate.Inspector.Transport;
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


namespace StateTrafficInspectorate.Inspector.Transport {
    
    
    /// <summary>
    /// TransportList
    /// </summary>
    public partial class TransportList : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\..\..\Inspector\Transport\TransportList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Back;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\Inspector\Transport\TransportList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button NewDriver;
        
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
            System.Uri resourceLocater = new System.Uri("/StateTrafficInspectorate;component/inspector/transport/transportlist.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Inspector\Transport\TransportList.xaml"
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
            this.Back = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\..\Inspector\Transport\TransportList.xaml"
            this.Back.Click += new System.Windows.RoutedEventHandler(this.Back_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.NewDriver = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\..\Inspector\Transport\TransportList.xaml"
            this.NewDriver.Click += new System.Windows.RoutedEventHandler(this.NewDriver_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 21 "..\..\..\..\Inspector\Transport\TransportList.xaml"
            ((System.Windows.Controls.TextBlock)(target)).MouseMove += new System.Windows.Input.MouseEventHandler(this.TextBlock_MouseMove);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

