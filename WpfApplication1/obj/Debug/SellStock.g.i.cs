﻿#pragma checksum "..\..\SellStock.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "0D589BACA8BB83DB9758D8DBC20829B1"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace WpfApplication1 {
    
    
    /// <summary>
    /// SellStock
    /// </summary>
    public partial class SellStock : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\SellStock.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbShares;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\SellStock.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Stock_Box;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApplication1;component/sellstock.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\SellStock.xaml"
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
            this.tbShares = ((System.Windows.Controls.TextBox)(target));
            
            #line 16 "..\..\SellStock.xaml"
            this.tbShares.GotFocus += new System.Windows.RoutedEventHandler(this.Shares_Box_OnFocus);
            
            #line default
            #line hidden
            
            #line 16 "..\..\SellStock.xaml"
            this.tbShares.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Shares_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Stock_Box = ((System.Windows.Controls.TextBox)(target));
            
            #line 18 "..\..\SellStock.xaml"
            this.Stock_Box.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Stock_Box_TextChanged);
            
            #line default
            #line hidden
            
            #line 18 "..\..\SellStock.xaml"
            this.Stock_Box.GotFocus += new System.Windows.RoutedEventHandler(this.Stock_Box_OnFocus);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 21 "..\..\SellStock.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Sell_Stock_Clicked);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 22 "..\..\SellStock.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Cancel_Clicked);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

