#pragma checksum "..\..\..\Pages\UserProfilePage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "223159B505D6FA697AEB1D672227B2EF948B44A7DA1BFAC303564ADF070EC014"
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
    /// UserProfilePage
    /// </summary>
    public partial class UserProfilePage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\..\Pages\UserProfilePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid UserProfileGrid;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Pages\UserProfilePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ReturnMainButton;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\Pages\UserProfilePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ShowResultButton;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\Pages\UserProfilePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteRecordButton;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Pages\UserProfilePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ExitAccountButton;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\Pages\UserProfilePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock NameTextBlock;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\Pages\UserProfilePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock UserNameTextBlock;
        
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
            System.Uri resourceLocater = new System.Uri("/EducationTests;component/pages/userprofilepage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\UserProfilePage.xaml"
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
            this.UserProfileGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.ReturnMainButton = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\Pages\UserProfilePage.xaml"
            this.ReturnMainButton.Click += new System.Windows.RoutedEventHandler(this.ReturnMainButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ShowResultButton = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\..\Pages\UserProfilePage.xaml"
            this.ShowResultButton.Click += new System.Windows.RoutedEventHandler(this.ShowResultButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.DeleteRecordButton = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\..\Pages\UserProfilePage.xaml"
            this.DeleteRecordButton.Click += new System.Windows.RoutedEventHandler(this.DeleteRecordButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ExitAccountButton = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\Pages\UserProfilePage.xaml"
            this.ExitAccountButton.Click += new System.Windows.RoutedEventHandler(this.ExitAccountButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.NameTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.UserNameTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

