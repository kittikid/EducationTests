﻿#pragma checksum "..\..\..\Pages\MainPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9005344114181B2936547AFFEE041FABEF48864E0EA2DD164E71C7625F264968"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using EducationTests.Pages;
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


namespace EducationTests.Pages {
    
    
    /// <summary>
    /// MainPage
    /// </summary>
    public partial class MainPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 20 "..\..\..\Pages\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ColumnDefinition TestColumnChange;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Pages\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button TestAdd;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Pages\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button TestCopy;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\Pages\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button TestEdit;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Pages\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button TestDellete;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\Pages\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button StartTest;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\Pages\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid MainGrid;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\Pages\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TestTextName;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\Pages\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button TestAddCommit;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\..\Pages\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button TestAddRollback;
        
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
            System.Uri resourceLocater = new System.Uri("/EducationTests;component/pages/mainpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\MainPage.xaml"
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
            this.TestColumnChange = ((System.Windows.Controls.ColumnDefinition)(target));
            return;
            case 2:
            this.TestAdd = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\Pages\MainPage.xaml"
            this.TestAdd.Click += new System.Windows.RoutedEventHandler(this.TestAdd_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.TestCopy = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\Pages\MainPage.xaml"
            this.TestCopy.Click += new System.Windows.RoutedEventHandler(this.TestCopy_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.TestEdit = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\Pages\MainPage.xaml"
            this.TestEdit.Click += new System.Windows.RoutedEventHandler(this.TestEdit_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.TestDellete = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\..\Pages\MainPage.xaml"
            this.TestDellete.Click += new System.Windows.RoutedEventHandler(this.TestDelete_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.StartTest = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\..\Pages\MainPage.xaml"
            this.StartTest.Click += new System.Windows.RoutedEventHandler(this.StartTest_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.MainGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 10:
            this.TestTextName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.TestAddCommit = ((System.Windows.Controls.Button)(target));
            
            #line 85 "..\..\..\Pages\MainPage.xaml"
            this.TestAddCommit.Click += new System.Windows.RoutedEventHandler(this.TestAddCommit_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.TestAddRollback = ((System.Windows.Controls.Button)(target));
            
            #line 87 "..\..\..\Pages\MainPage.xaml"
            this.TestAddRollback.Click += new System.Windows.RoutedEventHandler(this.TestAddRollback_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 8:
            
            #line 54 "..\..\..\Pages\MainPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.TestEdit_Click);
            
            #line default
            #line hidden
            break;
            case 9:
            
            #line 56 "..\..\..\Pages\MainPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.TestDelete_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

