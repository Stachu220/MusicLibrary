﻿#pragma checksum "..\..\..\CavernCategory.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "86B14DD6689D1C1EBC1C21D5996F4C99DB6BF553"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

using MusicLibrary2;
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


namespace MusicLibrary2 {
    
    
    /// <summary>
    /// CavernCategory
    /// </summary>
    public partial class CavernCategory : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 123 "..\..\..\CavernCategory.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid MainView;
        
        #line default
        #line hidden
        
        
        #line 178 "..\..\..\CavernCategory.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas myCanva;
        
        #line default
        #line hidden
        
        
        #line 181 "..\..\..\CavernCategory.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PPButton;
        
        #line default
        #line hidden
        
        
        #line 186 "..\..\..\CavernCategory.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image playPauseButton;
        
        #line default
        #line hidden
        
        
        #line 202 "..\..\..\CavernCategory.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Title;
        
        #line default
        #line hidden
        
        
        #line 203 "..\..\..\CavernCategory.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Description;
        
        #line default
        #line hidden
        
        
        #line 205 "..\..\..\CavernCategory.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Tags;
        
        #line default
        #line hidden
        
        
        #line 208 "..\..\..\CavernCategory.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel VolumeSlider;
        
        #line default
        #line hidden
        
        
        #line 209 "..\..\..\CavernCategory.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock vol;
        
        #line default
        #line hidden
        
        
        #line 210 "..\..\..\CavernCategory.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider volSlider;
        
        #line default
        #line hidden
        
        
        #line 214 "..\..\..\CavernCategory.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton LoopToggle;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.8.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/MusicLibrary2;component/caverncategory.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\CavernCategory.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.8.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.MainView = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            
            #line 134 "..\..\..\CavernCategory.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.prevPage);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 135 "..\..\..\CavernCategory.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.nextPage);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 139 "..\..\..\CavernCategory.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.goToFolk);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 144 "..\..\..\CavernCategory.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.goToBattle);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 149 "..\..\..\CavernCategory.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.goToTavern);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 154 "..\..\..\CavernCategory.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.goToForest);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 164 "..\..\..\CavernCategory.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.goToNight);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 169 "..\..\..\CavernCategory.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.goToEpic);
            
            #line default
            #line hidden
            return;
            case 10:
            this.myCanva = ((System.Windows.Controls.Canvas)(target));
            return;
            case 11:
            this.PPButton = ((System.Windows.Controls.Button)(target));
            
            #line 181 "..\..\..\CavernCategory.xaml"
            this.PPButton.Click += new System.Windows.RoutedEventHandler(this.onPlayPauseClicked);
            
            #line default
            #line hidden
            return;
            case 12:
            this.playPauseButton = ((System.Windows.Controls.Image)(target));
            return;
            case 13:
            
            #line 191 "..\..\..\CavernCategory.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.goToAdd);
            
            #line default
            #line hidden
            return;
            case 14:
            this.Title = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 15:
            this.Description = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 16:
            this.Tags = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 17:
            this.VolumeSlider = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 18:
            this.vol = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 19:
            this.volSlider = ((System.Windows.Controls.Slider)(target));
            
            #line 210 "..\..\..\CavernCategory.xaml"
            this.volSlider.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.onVolumeChanged);
            
            #line default
            #line hidden
            return;
            case 20:
            this.LoopToggle = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            
            #line 214 "..\..\..\CavernCategory.xaml"
            this.LoopToggle.Checked += new System.Windows.RoutedEventHandler(this.onLoop);
            
            #line default
            #line hidden
            
            #line 214 "..\..\..\CavernCategory.xaml"
            this.LoopToggle.Unchecked += new System.Windows.RoutedEventHandler(this.onLoop);
            
            #line default
            #line hidden
            return;
            case 21:
            
            #line 216 "..\..\..\CavernCategory.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.onRemoveClicked);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

