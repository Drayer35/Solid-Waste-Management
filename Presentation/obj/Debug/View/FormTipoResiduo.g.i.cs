﻿#pragma checksum "..\..\..\View\FormTipoResiduo.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C6A40F38E382025D86F3D2757ECEC87E5C33B773E8EB42368495B47FE4EA95EC"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using FontAwesome.WPF;
using FontAwesome.WPF.Converters;
using Presentation.View;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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


namespace Presentation.View {
    
    
    /// <summary>
    /// FormTipoResiduo
    /// </summary>
    public partial class FormTipoResiduo : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 34 "..\..\..\View\FormTipoResiduo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtIdEstadoMateria;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\View\FormTipoResiduo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtNameEstadoMateria;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\View\FormTipoResiduo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnAddEstadoMateria;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\View\FormTipoResiduo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TextAddEstablecimiento;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\View\FormTipoResiduo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid TableEstadoMateria;
        
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
            System.Uri resourceLocater = new System.Uri("/Presentation;component/view/formtiporesiduo.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\FormTipoResiduo.xaml"
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
            this.TxtIdEstadoMateria = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.TxtNameEstadoMateria = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.BtnAddEstadoMateria = ((System.Windows.Controls.Button)(target));
            return;
            case 4:
            this.TextAddEstablecimiento = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.TableEstadoMateria = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
