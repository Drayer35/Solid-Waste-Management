﻿#pragma checksum "..\..\..\View\LoginUser.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "65C89619B55F346DEA3C39BFB338533FC30278802B9F29A9B4B78C1A09C6C1A4"
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
    /// LoginUser
    /// </summary>
    public partial class LoginUser : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 42 "..\..\..\View\LoginUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnMin;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\View\LoginUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnClose;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\View\LoginUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtUser;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\..\View\LoginUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox txtPass;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\..\View\LoginUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.ImageBrush imgPass;
        
        #line default
        #line hidden
        
        
        #line 107 "..\..\..\View\LoginUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock lblAlert;
        
        #line default
        #line hidden
        
        
        #line 110 "..\..\..\View\LoginUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock lblAlertText;
        
        #line default
        #line hidden
        
        
        #line 127 "..\..\..\View\LoginUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnLogin;
        
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
            System.Uri resourceLocater = new System.Uri("/Presentation;component/view/loginuser.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\LoginUser.xaml"
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
            
            #line 8 "..\..\..\View\LoginUser.xaml"
            ((Presentation.View.LoginUser)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnMin = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\..\View\LoginUser.xaml"
            this.btnMin.Click += new System.Windows.RoutedEventHandler(this.btn_MinWindow);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnClose = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\..\View\LoginUser.xaml"
            this.btnClose.Click += new System.Windows.RoutedEventHandler(this.btn_CloseWindow);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txtUser = ((System.Windows.Controls.TextBox)(target));
            
            #line 76 "..\..\..\View\LoginUser.xaml"
            this.txtUser.GotFocus += new System.Windows.RoutedEventHandler(this.txtUserName_Enter);
            
            #line default
            #line hidden
            
            #line 77 "..\..\..\View\LoginUser.xaml"
            this.txtUser.LostFocus += new System.Windows.RoutedEventHandler(this.txtUserName_Leave);
            
            #line default
            #line hidden
            return;
            case 5:
            this.txtPass = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 93 "..\..\..\View\LoginUser.xaml"
            this.txtPass.GotFocus += new System.Windows.RoutedEventHandler(this.txtPass_Enter);
            
            #line default
            #line hidden
            
            #line 94 "..\..\..\View\LoginUser.xaml"
            this.txtPass.LostFocus += new System.Windows.RoutedEventHandler(this.txtPass_Leave);
            
            #line default
            #line hidden
            return;
            case 6:
            this.imgPass = ((System.Windows.Media.ImageBrush)(target));
            return;
            case 7:
            this.lblAlert = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.lblAlertText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            
            #line 120 "..\..\..\View\LoginUser.xaml"
            ((System.Windows.Documents.Hyperlink)(target)).Click += new System.Windows.RoutedEventHandler(this.Hyperlink_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btnLogin = ((System.Windows.Controls.Button)(target));
            
            #line 129 "..\..\..\View\LoginUser.xaml"
            this.btnLogin.Click += new System.Windows.RoutedEventHandler(this.sendLoginClick);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 138 "..\..\..\View\LoginUser.xaml"
            ((System.Windows.Documents.Hyperlink)(target)).Click += new System.Windows.RoutedEventHandler(this.Hyperlink_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 142 "..\..\..\View\LoginUser.xaml"
            ((System.Windows.Documents.Hyperlink)(target)).Click += new System.Windows.RoutedEventHandler(this.Hyperlink_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

