﻿#pragma checksum "D:\Working\WordBank\Source Code\RelationDiagram\Controls\Block.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "297682D3B3995BA27C0CFE487C6B91AD"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace NCRVisual.RelationDiagram {
    
    
    public partial class Block : System.Windows.Controls.UserControl {
        
        internal System.Windows.Media.Animation.Storyboard MouseEnterStoryBoard;
        
        internal System.Windows.Media.Animation.Storyboard MouseLeftStoryBoard;
        
        internal System.Windows.Media.Animation.Storyboard MouseDownStoryBoard;
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.TextBlock TextField;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/RelationDiagram;component/Controls/Block.xaml", System.UriKind.Relative));
            this.MouseEnterStoryBoard = ((System.Windows.Media.Animation.Storyboard)(this.FindName("MouseEnterStoryBoard")));
            this.MouseLeftStoryBoard = ((System.Windows.Media.Animation.Storyboard)(this.FindName("MouseLeftStoryBoard")));
            this.MouseDownStoryBoard = ((System.Windows.Media.Animation.Storyboard)(this.FindName("MouseDownStoryBoard")));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TextField = ((System.Windows.Controls.TextBlock)(this.FindName("TextField")));
        }
    }
}
