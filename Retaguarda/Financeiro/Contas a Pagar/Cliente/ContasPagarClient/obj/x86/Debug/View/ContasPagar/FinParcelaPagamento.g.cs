﻿#pragma checksum "..\..\..\..\..\View\ContasPagar\FinParcelaPagamento.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "429E727C2B5FACFB985BC84C3677A199"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18449
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Windows.Controls;
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


namespace ContasPagarClient.View.ContasPagar {
    
    
    /// <summary>
    /// FinParcelaPagamento
    /// </summary>
    public partial class FinParcelaPagamento : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 5 "..\..\..\..\..\View\ContasPagar\FinParcelaPagamento.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btGravar;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\..\..\..\View\ContasPagar\FinParcelaPagamento.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btSair;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\..\..\View\ContasPagar\FinParcelaPagamento.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btPesquisarFinTipoPagamento;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\..\View\ContasPagar\FinParcelaPagamento.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btPesquisarContaCaixa;
        
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
            System.Uri resourceLocater = new System.Uri("/ContasPagarClient;component/view/contaspagar/finparcelapagamento.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\View\ContasPagar\FinParcelaPagamento.xaml"
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
            this.btGravar = ((System.Windows.Controls.Button)(target));
            return;
            case 2:
            this.btSair = ((System.Windows.Controls.Button)(target));
            return;
            case 3:
            this.btPesquisarFinTipoPagamento = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\..\..\View\ContasPagar\FinParcelaPagamento.xaml"
            this.btPesquisarFinTipoPagamento.Click += new System.Windows.RoutedEventHandler(this.btPesquisarFinTipoPagamento_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btPesquisarContaCaixa = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\..\..\View\ContasPagar\FinParcelaPagamento.xaml"
            this.btPesquisarContaCaixa.Click += new System.Windows.RoutedEventHandler(this.btPesquisarContaCaixa_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
