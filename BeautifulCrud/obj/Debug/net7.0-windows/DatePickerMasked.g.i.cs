﻿#pragma checksum "..\..\..\DatePickerMasked.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "EFD80C6BB4EAD956AAC73F68C2A4F42D3256AD4B"
//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

using BeautifulCrud;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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
using Xceed.Wpf.Toolkit;
using Xceed.Wpf.Toolkit.Chromes;
using Xceed.Wpf.Toolkit.Core.Converters;
using Xceed.Wpf.Toolkit.Core.Input;
using Xceed.Wpf.Toolkit.Core.Media;
using Xceed.Wpf.Toolkit.Core.Utilities;
using Xceed.Wpf.Toolkit.Panels;
using Xceed.Wpf.Toolkit.Primitives;
using Xceed.Wpf.Toolkit.PropertyGrid;
using Xceed.Wpf.Toolkit.PropertyGrid.Attributes;
using Xceed.Wpf.Toolkit.PropertyGrid.Commands;
using Xceed.Wpf.Toolkit.PropertyGrid.Converters;
using Xceed.Wpf.Toolkit.PropertyGrid.Editors;
using Xceed.Wpf.Toolkit.Zoombox;


namespace BeautifulCrud {
    
    
    /// <summary>
    /// DatePickerMasked
    /// </summary>
    public partial class DatePickerMasked : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\DatePickerMasked.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Xceed.Wpf.Toolkit.MaskedTextBox DateTextBox;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\DatePickerMasked.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton btn;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\DatePickerMasked.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.Popup CalendarPane;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\DatePickerMasked.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Calendar CalendarControl;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.11.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/BeautifulCrud;V1.0.0.0;component/datepickermasked.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\DatePickerMasked.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.11.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.DateTextBox = ((Xceed.Wpf.Toolkit.MaskedTextBox)(target));
            
            #line 12 "..\..\..\DatePickerMasked.xaml"
            this.DateTextBox.KeyDown += new System.Windows.Input.KeyEventHandler(this.DateTextBox_KeyDown);
            
            #line default
            #line hidden
            
            #line 12 "..\..\..\DatePickerMasked.xaml"
            this.DateTextBox.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.DateTextBox_PreviewTextInput);
            
            #line default
            #line hidden
            
            #line 12 "..\..\..\DatePickerMasked.xaml"
            this.DateTextBox.GotFocus += new System.Windows.RoutedEventHandler(this.DateTextBox_GotFocus);
            
            #line default
            #line hidden
            
            #line 12 "..\..\..\DatePickerMasked.xaml"
            this.DateTextBox.LostFocus += new System.Windows.RoutedEventHandler(this.DateTextBox_LostFocus);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btn = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            return;
            case 3:
            this.CalendarPane = ((System.Windows.Controls.Primitives.Popup)(target));
            return;
            case 4:
            this.CalendarControl = ((System.Windows.Controls.Calendar)(target));
            
            #line 19 "..\..\..\DatePickerMasked.xaml"
            this.CalendarControl.SelectedDatesChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.CalendarControl_SelectedDatesChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
