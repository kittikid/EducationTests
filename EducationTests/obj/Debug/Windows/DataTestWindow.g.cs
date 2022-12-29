﻿#pragma checksum "..\..\..\Windows\DataTestWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "344A1E35B90EB53FA54691A69859581FE78B32F323227AEC5E6CB008738F9416"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using EducationTests.Windows;
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


namespace EducationTests.Windows {
    
    
    /// <summary>
    /// DataTestWindow
    /// </summary>
    public partial class DataTestWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\..\Windows\DataTestWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TestNameTextBlock;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\Windows\DataTestWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextQuestion;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Windows\DataTestWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddQuestionButton;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\Windows\DataTestWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock QuestionNameTextBlock;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\Windows\DataTestWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextAnswer;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\Windows\DataTestWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddAnswerButton;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\Windows\DataTestWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddCommitButton;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\Windows\DataTestWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CancelButton;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\Windows\DataTestWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button NextQuestionButton;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\Windows\DataTestWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox AnswerList;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\Windows\DataTestWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox CorrectCheck;
        
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
            System.Uri resourceLocater = new System.Uri("/EducationTests;component/windows/datatestwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\DataTestWindow.xaml"
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
            this.TestNameTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.TextQuestion = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.AddQuestionButton = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\Windows\DataTestWindow.xaml"
            this.AddQuestionButton.Click += new System.Windows.RoutedEventHandler(this.AddQuestionButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.QuestionNameTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.TextAnswer = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.AddAnswerButton = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\..\Windows\DataTestWindow.xaml"
            this.AddAnswerButton.Click += new System.Windows.RoutedEventHandler(this.AddAnswerButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.AddCommitButton = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\..\Windows\DataTestWindow.xaml"
            this.AddCommitButton.Click += new System.Windows.RoutedEventHandler(this.AddCommitButton_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.CancelButton = ((System.Windows.Controls.Button)(target));
            return;
            case 9:
            this.NextQuestionButton = ((System.Windows.Controls.Button)(target));
            
            #line 56 "..\..\..\Windows\DataTestWindow.xaml"
            this.NextQuestionButton.Click += new System.Windows.RoutedEventHandler(this.NextQuestionButton_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.AnswerList = ((System.Windows.Controls.ListBox)(target));
            return;
            case 11:
            this.CorrectCheck = ((System.Windows.Controls.CheckBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

