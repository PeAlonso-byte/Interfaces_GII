﻿#pragma checksum "..\..\..\Views\CuadroCoordenadas.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5AEF5FDFE0ECBA264E7EA72D4688241BA6EC91337A91F62DBE72DDF1F244D1C1"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using Interfaces_GII;
using Microsoft.Xaml.Behaviors;
using Microsoft.Xaml.Behaviors.Core;
using Microsoft.Xaml.Behaviors.Input;
using Microsoft.Xaml.Behaviors.Layout;
using Microsoft.Xaml.Behaviors.Media;
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


namespace Interfaces_GII.Views {
    
    
    /// <summary>
    /// CuadroCoordenadas
    /// </summary>
    public partial class CuadroCoordenadas : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 8 "..\..\..\Views\CuadroCoordenadas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gridVentana;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\Views\CuadroCoordenadas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabControl TestTabs;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Views\CuadroCoordenadas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gridManual;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\Views\CuadroCoordenadas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock xText;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\Views\CuadroCoordenadas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox xTextBox;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\Views\CuadroCoordenadas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock yText;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\Views\CuadroCoordenadas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox yTextBox;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\Views\CuadroCoordenadas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAnadir;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\Views\CuadroCoordenadas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid gridCoord;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\Views\CuadroCoordenadas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gridPolinomio;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\..\Views\CuadroCoordenadas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAleatorio;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\..\Views\CuadroCoordenadas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid gridCoordPolinomio;
        
        #line default
        #line hidden
        
        
        #line 130 "..\..\..\Views\CuadroCoordenadas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCerrar;
        
        #line default
        #line hidden
        
        
        #line 131 "..\..\..\Views\CuadroCoordenadas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnVaciar;
        
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
            System.Uri resourceLocater = new System.Uri("/Interfaces_GII;component/views/cuadrocoordenadas.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\CuadroCoordenadas.xaml"
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
            this.gridVentana = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.TestTabs = ((System.Windows.Controls.TabControl)(target));
            return;
            case 3:
            this.gridManual = ((System.Windows.Controls.Grid)(target));
            return;
            case 4:
            this.xText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.xTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.yText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.yTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.btnAnadir = ((System.Windows.Controls.Button)(target));
            return;
            case 9:
            this.gridCoord = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 10:
            this.gridPolinomio = ((System.Windows.Controls.Grid)(target));
            return;
            case 11:
            this.btnAleatorio = ((System.Windows.Controls.Button)(target));
            return;
            case 12:
            this.gridCoordPolinomio = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 13:
            this.btnCerrar = ((System.Windows.Controls.Button)(target));
            return;
            case 14:
            this.btnVaciar = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

