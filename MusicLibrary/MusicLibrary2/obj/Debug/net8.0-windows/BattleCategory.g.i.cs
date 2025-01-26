// Updated by XamlIntelliSenseFileGenerator 26.01.2025 23:50:51
#pragma checksum "..\..\..\BattleCategory.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "B21B3F3304C8B9BA0BE3E55890D3AB7508B3BB67"
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


namespace MusicLibrary2
{


    /// <summary>
    /// BattleCategory
    /// </summary>
    public partial class BattleCategory : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector
    {


#line 83 "..\..\..\BattleCategory.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid MainView;

#line default
#line hidden


#line 138 "..\..\..\BattleCategory.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas myCanva;

#line default
#line hidden


#line 163 "..\..\..\BattleCategory.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Title;

#line default
#line hidden


#line 164 "..\..\..\BattleCategory.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Description;

#line default
#line hidden


#line 166 "..\..\..\BattleCategory.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Tags;

#line default
#line hidden


#line 169 "..\..\..\BattleCategory.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel VolumeSlider;

#line default
#line hidden


#line 175 "..\..\..\BattleCategory.xaml"
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
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/MusicLibrary2;component/battlecategory.xaml", System.UriKind.Relative);

#line 1 "..\..\..\BattleCategory.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.MainView = ((System.Windows.Controls.Grid)(target));
                    return;
                case 2:

#line 99 "..\..\..\BattleCategory.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.goToFolk);

#line default
#line hidden
                    return;
                case 3:

#line 109 "..\..\..\BattleCategory.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.goToTavern);

#line default
#line hidden
                    return;
                case 4:

#line 114 "..\..\..\BattleCategory.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.goToForest);

#line default
#line hidden
                    return;
                case 5:

#line 119 "..\..\..\BattleCategory.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.goToCavern);

#line default
#line hidden
                    return;
                case 6:

#line 124 "..\..\..\BattleCategory.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.goToNight);

#line default
#line hidden
                    return;
                case 7:

#line 129 "..\..\..\BattleCategory.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.goToEpic);

#line default
#line hidden
                    return;
                case 8:
                    this.myCanva = ((System.Windows.Controls.Canvas)(target));
                    return;
                case 9:
                    this.playPauseButton = ((System.Windows.Controls.Button)(target));

#line 141 "..\..\..\BattleCategory.xaml"
                    this.playPauseButton.Click += new System.Windows.RoutedEventHandler(this.onPlayPauseClicked);

#line default
#line hidden
                    return;
                case 10:

#line 152 "..\..\..\BattleCategory.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.goToAdd);

#line default
#line hidden
                    return;
                case 11:
                    this.Title = ((System.Windows.Controls.TextBlock)(target));
                    return;
                case 12:
                    this.Description = ((System.Windows.Controls.TextBlock)(target));
                    return;
                case 13:
                    this.Tags = ((System.Windows.Controls.TextBlock)(target));
                    return;
                case 14:
                    this.VolumeSlider = ((System.Windows.Controls.StackPanel)(target));
                    return;
                case 15:
                    this.LoopToggle = ((System.Windows.Controls.Primitives.ToggleButton)(target));
                    return;
                case 16:

#line 177 "..\..\..\BattleCategory.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.onRemoveClicked);

#line default
#line hidden
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.TextBlock vol;
        internal System.Windows.Controls.Slider volSlider;
        internal System.Windows.Controls.Image playPauseButton;
    }
}

