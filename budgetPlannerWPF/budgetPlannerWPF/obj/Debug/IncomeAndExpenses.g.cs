﻿#pragma checksum "..\..\IncomeAndExpenses.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8A96517C04D774F065D3B68A366796573FD022F1D8BE6D51F66AEE7D72BB5267"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
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
using budgetPlannerWPF;


namespace budgetPlannerWPF {
    
    
    /// <summary>
    /// IncomeAndExpenses
    /// </summary>
    public partial class IncomeAndExpenses : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\IncomeAndExpenses.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid BG;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\IncomeAndExpenses.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.ImageBrush _img_bg;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\IncomeAndExpenses.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox taxTB;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\IncomeAndExpenses.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox groceriesTB;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\IncomeAndExpenses.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox travelTB;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\IncomeAndExpenses.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox waterTB;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\IncomeAndExpenses.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox cellTB;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\IncomeAndExpenses.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox otherTB;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\IncomeAndExpenses.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox grossIncomeTb;
        
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
            System.Uri resourceLocater = new System.Uri("/budgetPlannerWPF;component/incomeandexpenses.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\IncomeAndExpenses.xaml"
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
            this.BG = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this._img_bg = ((System.Windows.Media.ImageBrush)(target));
            return;
            case 3:
            this.taxTB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.groceriesTB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.travelTB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.waterTB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.cellTB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.otherTB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.grossIncomeTb = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            
            #line 70 "..\..\IncomeAndExpenses.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_2);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 72 "..\..\IncomeAndExpenses.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 74 "..\..\IncomeAndExpenses.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
