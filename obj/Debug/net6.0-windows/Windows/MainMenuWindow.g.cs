﻿#pragma checksum "..\..\..\..\Windows\MainMenuWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "616FAF5E169C98750C96DCA23E305340DEA03513"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Bankomat.Windows;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace Bankomat.Windows {
    
    
    /// <summary>
    /// MainMenuWindow
    /// </summary>
    public partial class MainMenuWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\..\Windows\MainMenuWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock User_Id_Block;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\..\Windows\MainMenuWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Score_Text_Block;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\..\Windows\MainMenuWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock User_Score_Text_Block;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\..\Windows\MainMenuWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Add_Money_Button;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\..\Windows\MainMenuWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Get_Money_Button;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\Windows\MainMenuWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Send_Money_Button;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\..\Windows\MainMenuWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Get_Cheque_Button;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\..\Windows\MainMenuWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Exit_Button;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.13.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Bankomat;component/windows/mainmenuwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Windows\MainMenuWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.13.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.User_Id_Block = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.Score_Text_Block = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.User_Score_Text_Block = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.Add_Money_Button = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\..\Windows\MainMenuWindow.xaml"
            this.Add_Money_Button.Click += new System.Windows.RoutedEventHandler(this.Add_Money_Button_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Get_Money_Button = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\..\..\Windows\MainMenuWindow.xaml"
            this.Get_Money_Button.Click += new System.Windows.RoutedEventHandler(this.Get_Money_Button_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Send_Money_Button = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\..\..\Windows\MainMenuWindow.xaml"
            this.Send_Money_Button.Click += new System.Windows.RoutedEventHandler(this.Send_Money_Button_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Get_Cheque_Button = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\..\Windows\MainMenuWindow.xaml"
            this.Get_Cheque_Button.Click += new System.Windows.RoutedEventHandler(this.Get_Cheque_Button_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Exit_Button = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\..\Windows\MainMenuWindow.xaml"
            this.Exit_Button.Click += new System.Windows.RoutedEventHandler(this.Exit_Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

