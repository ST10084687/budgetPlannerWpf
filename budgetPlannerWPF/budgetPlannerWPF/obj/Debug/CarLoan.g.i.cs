// Updated by XamlIntelliSenseFileGenerator 2022/06/15 22:28:43
#pragma checksum "..\..\CarLoan.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "134D87148FE585FFA0660A6F14F0BF971AC668E94B03E4C24AA389FAE7682F3D"
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


namespace budgetPlannerWPF
{


    /// <summary>
    /// CarLoan
    /// </summary>
    public partial class CarLoan : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/budgetPlannerWPF;component/carloan.xaml", System.UriKind.Relative);

#line 1 "..\..\CarLoan.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.BG = ((System.Windows.Controls.Grid)(target));
                    return;
                case 2:
                    this._img_bg = ((System.Windows.Media.ImageBrush)(target));
                    return;
                case 3:
                    this.makeTb = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 4:
                    this.purchaseTB = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 5:
                    this.depositTB = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 6:
                    this.interestTB = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 7:
                    this.insuranceTB = ((System.Windows.Controls.TextBox)(target));
                    return;
            }
            this._contentLoaded = true;
        }
    }
}
