﻿#pragma checksum "C:\Projects\Silverlight2010\SilverlightViewer2.2.1\SilverlightViewer2.2\BusinessAnalystWidget\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "C7D924D4C3B16FA52534FBF8BB46277A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace BusinessAnalystWidget {
    
    
    public partial class MainPage : ESRI.SilverlightViewer.Widget.WidgetBase {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel PanelCreateReport;
        
        internal System.Windows.Controls.RadioButton RadioBufferCenter;
        
        internal System.Windows.Controls.RadioButton RadioBufferGeometry;
        
        internal System.Windows.Controls.ComboBox lstGraphicWidget;
        
        internal System.Windows.Controls.TextBox txtBufferDistance;
        
        internal System.Windows.Controls.ComboBox lstBufferUnits;
        
        internal System.Windows.Controls.ComboBox ReportNameComboBox;
        
        internal System.Windows.Controls.Button btnSubmitReport;
        
        internal System.Windows.Controls.Grid PanelDownloadReport;
        
        internal System.Windows.Controls.TextBlock BAReportMessage;
        
        internal System.Windows.Controls.HyperlinkButton ReportDownloadLink;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/BusinessAnalystWidget;component/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.PanelCreateReport = ((System.Windows.Controls.StackPanel)(this.FindName("PanelCreateReport")));
            this.RadioBufferCenter = ((System.Windows.Controls.RadioButton)(this.FindName("RadioBufferCenter")));
            this.RadioBufferGeometry = ((System.Windows.Controls.RadioButton)(this.FindName("RadioBufferGeometry")));
            this.lstGraphicWidget = ((System.Windows.Controls.ComboBox)(this.FindName("lstGraphicWidget")));
            this.txtBufferDistance = ((System.Windows.Controls.TextBox)(this.FindName("txtBufferDistance")));
            this.lstBufferUnits = ((System.Windows.Controls.ComboBox)(this.FindName("lstBufferUnits")));
            this.ReportNameComboBox = ((System.Windows.Controls.ComboBox)(this.FindName("ReportNameComboBox")));
            this.btnSubmitReport = ((System.Windows.Controls.Button)(this.FindName("btnSubmitReport")));
            this.PanelDownloadReport = ((System.Windows.Controls.Grid)(this.FindName("PanelDownloadReport")));
            this.BAReportMessage = ((System.Windows.Controls.TextBlock)(this.FindName("BAReportMessage")));
            this.ReportDownloadLink = ((System.Windows.Controls.HyperlinkButton)(this.FindName("ReportDownloadLink")));
        }
    }
}

