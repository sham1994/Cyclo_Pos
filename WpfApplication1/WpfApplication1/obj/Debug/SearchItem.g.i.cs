﻿#pragma checksum "..\..\SearchItem.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0122CBBDFD8FBF3D5ECA5004299E8FA57725076C"
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
using WpfApplication1;


namespace WpfApplication1 {
    
    
    /// <summary>
    /// SearchItem
    /// </summary>
    public partial class SearchItem : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\SearchItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid grdItems;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\SearchItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_SearchName;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\SearchItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_Searchcode;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApplication1;component/searchitem.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\SearchItem.xaml"
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
            
            #line 8 "..\..\SearchItem.xaml"
            ((WpfApplication1.SearchItem)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.grdItems = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            this.txt_SearchName = ((System.Windows.Controls.TextBox)(target));
            
            #line 43 "..\..\SearchItem.xaml"
            this.txt_SearchName.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txt_SearchName_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txt_Searchcode = ((System.Windows.Controls.TextBox)(target));
            
            #line 61 "..\..\SearchItem.xaml"
            this.txt_Searchcode.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txt_Searchcode_TextChanged);
            
            #line default
            #line hidden
            
            #line 61 "..\..\SearchItem.xaml"
            this.txt_Searchcode.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.txt_Searchcode_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
