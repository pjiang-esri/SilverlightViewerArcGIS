﻿#pragma checksum "C:\Projects\Silverlight2010\SilverlightViewer2.4\SilverlightViewer2.4\SilverlightViewer.Xap\Widgets\TaskbarWidget.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "5BE510A276084C29911CA515138697A9"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ESRI.SilverlightViewer.Controls;
using ESRI.SilverlightViewer.Widget;
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


namespace ESRI.SilverlightViewer.UIWidget {
    
    
    public partial class TaskbarWidget : ESRI.SilverlightViewer.Widget.TaskbarBase {
        
        internal System.Windows.Controls.StackPanel StackTitleBar;
        
        internal System.Windows.Controls.Image LogoImage;
        
        internal System.Windows.Controls.TextBlock TextTitle;
        
        internal System.Windows.Shapes.Path TitleUnderline;
        
        internal System.Windows.Controls.TextBlock TextSubTitle;
        
        internal System.Windows.Controls.StackPanel StackToolbar;
        
        internal ESRI.SilverlightViewer.Controls.DropMenuButton WidgetMenuButton;
        
        internal ESRI.SilverlightViewer.Controls.PagedStackPanel DockWidgetsStack;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/ESRI.SilverlightViewer;component/Widgets/TaskbarWidget.xaml", System.UriKind.Relative));
            this.StackTitleBar = ((System.Windows.Controls.StackPanel)(this.FindName("StackTitleBar")));
            this.LogoImage = ((System.Windows.Controls.Image)(this.FindName("LogoImage")));
            this.TextTitle = ((System.Windows.Controls.TextBlock)(this.FindName("TextTitle")));
            this.TitleUnderline = ((System.Windows.Shapes.Path)(this.FindName("TitleUnderline")));
            this.TextSubTitle = ((System.Windows.Controls.TextBlock)(this.FindName("TextSubTitle")));
            this.StackToolbar = ((System.Windows.Controls.StackPanel)(this.FindName("StackToolbar")));
            this.WidgetMenuButton = ((ESRI.SilverlightViewer.Controls.DropMenuButton)(this.FindName("WidgetMenuButton")));
            this.DockWidgetsStack = ((ESRI.SilverlightViewer.Controls.PagedStackPanel)(this.FindName("DockWidgetsStack")));
        }
    }
}

