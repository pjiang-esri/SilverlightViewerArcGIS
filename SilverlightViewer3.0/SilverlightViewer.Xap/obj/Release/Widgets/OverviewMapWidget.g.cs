﻿#pragma checksum "C:\Projects\Silverlight2010\SilverlightViewer2.4\SilverlightViewer2.4\SilverlightViewer.Xap\Widgets\OverviewMapWidget.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "31B54842051B5DC603017B1A126FB9AE"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ESRI.ArcGIS.Client.Toolkit;
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
    
    
    public partial class OverviewMapWidget : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Border OverviewMapPanel;
        
        internal System.Windows.Media.TranslateTransform OverviewPanelTransform;
        
        internal ESRI.ArcGIS.Client.Toolkit.OverviewMap myOverviewMap;
        
        internal System.Windows.Controls.HyperlinkButton OverviewToggler;
        
        internal System.Windows.Media.RotateTransform OverviewTogglerTransform;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/ESRI.SilverlightViewer;component/Widgets/OverviewMapWidget.xaml", System.UriKind.Relative));
            this.OverviewMapPanel = ((System.Windows.Controls.Border)(this.FindName("OverviewMapPanel")));
            this.OverviewPanelTransform = ((System.Windows.Media.TranslateTransform)(this.FindName("OverviewPanelTransform")));
            this.myOverviewMap = ((ESRI.ArcGIS.Client.Toolkit.OverviewMap)(this.FindName("myOverviewMap")));
            this.OverviewToggler = ((System.Windows.Controls.HyperlinkButton)(this.FindName("OverviewToggler")));
            this.OverviewTogglerTransform = ((System.Windows.Media.RotateTransform)(this.FindName("OverviewTogglerTransform")));
        }
    }
}
