﻿#pragma checksum "..\..\CuadroModal.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D4078921782C2B569235A8A46AD6A4ED24B59BBAA167EBAB6BFD8FFEEFFB0144"
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


namespace Interfaces_GII {
    
    
    /// <summary>
    /// CuadroModal
    /// </summary>
    public partial class CuadroModal : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 37 "..\..\CuadroModal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock xText;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\CuadroModal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox xTextBox;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\CuadroModal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock yText;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\CuadroModal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox yTextBox;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\CuadroModal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAnadir;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\CuadroModal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAceptar;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\CuadroModal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCancelar;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\CuadroModal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnLimpiar;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\CuadroModal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAleatorio;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\CuadroModal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid CustomerGrid;
        
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
            System.Uri resourceLocater = new System.Uri("/Interfaces_GII;component/cuadromodal.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\CuadroModal.xaml"
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
            this.xText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.xTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 38 "..\..\CuadroModal.xaml"
            this.xTextBox.KeyDown += new System.Windows.Input.KeyEventHandler(this.xTextBox_KeyDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.yText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.yTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 41 "..\..\CuadroModal.xaml"
            this.yTextBox.KeyDown += new System.Windows.Input.KeyEventHandler(this.yTextBox_KeyDown);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnAnadir = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\CuadroModal.xaml"
            this.btnAnadir.Click += new System.Windows.RoutedEventHandler(this.btnAnadir_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnAceptar = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\CuadroModal.xaml"
            this.btnAceptar.Click += new System.Windows.RoutedEventHandler(this.btnAceptar_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnCancelar = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\CuadroModal.xaml"
            this.btnCancelar.Click += new System.Windows.RoutedEventHandler(this.btnCancelar_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnLimpiar = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\CuadroModal.xaml"
            this.btnLimpiar.Click += new System.Windows.RoutedEventHandler(this.btnLimpiar_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnAleatorio = ((System.Windows.Controls.Button)(target));
            return;
            case 10:
            this.CustomerGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

