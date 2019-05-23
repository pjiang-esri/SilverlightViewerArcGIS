﻿#pragma checksum "C:\Projects\Silverlight2010\SilverlightViewer3.0\SilverlightViewer3.0\SilverlightViewer.Xap\Widgets\PrintWidget.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "56B1A9FBF5FF250978380A8B8B6C67F2"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ESRI.SilverlightViewer.Generic;
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
    
    
    public partial class PrintWidget : ESRI.SilverlightViewer.Widget.WidgetBase {
        
        internal System.Windows.Controls.Grid PanelExportMap;
        
        internal System.Windows.Controls.TextBox txtExportMapTitle;
        
        internal System.Windows.Controls.ComboBox boxExportFormats;
        
        internal System.Windows.Controls.ComboBox boxLayoutTemplates;
        
        internal System.Windows.Controls.ComboBox boxMetricUnits;
        
        internal System.Windows.Controls.TextBox txtMetricLabel;
        
        internal System.Windows.Controls.ComboBox boxNonmetricUnits;
        
        internal System.Windows.Controls.TextBox txtNonmetricLabel;
        
        internal System.Windows.Controls.TextBox txtCopyright;
        
        internal System.Windows.Controls.HyperlinkButton linkExportResult;
        
        internal System.Windows.Controls.Button ExportMapButton;
        
        internal System.Windows.Controls.StackPanel PanelPrintMap;
        
        internal System.Windows.Controls.TextBox txtPrintMapTitle;
        
        internal ESRI.SilverlightViewer.Generic.PrintMapPage printMapPage;
        
        internal System.Windows.Controls.CheckBox checkFitToPage;
        
        internal System.Windows.Controls.CheckBox checkKeepScale;
        
        internal System.Windows.Controls.CheckBox checkRotateMap;
        
        internal System.Windows.Controls.CheckBox checkPrintLegend;
        
        internal System.Windows.Controls.CheckBox checkPrintOverview;
        
        internal System.Windows.Controls.Button UpdateMapButton;
        
        internal System.Windows.Controls.Button PrintMapButton;
        
        internal System.Windows.Controls.StackPanel PrintingProgressPanel;
        
        internal System.Windows.Controls.TextBlock PrintingPageText;
        
        internal System.Windows.Controls.ProgressBar PrintingProgress;
        
        internal System.Windows.Controls.StackPanel PanelPrintData;
        
        internal System.Windows.Controls.StackPanel StackWidgetCheck;
        
        internal System.Windows.Controls.Button CreatePrintButton;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/ESRI.SilverlightViewer;component/Widgets/PrintWidget.xaml", System.UriKind.Relative));
            this.PanelExportMap = ((System.Windows.Controls.Grid)(this.FindName("PanelExportMap")));
            this.txtExportMapTitle = ((System.Windows.Controls.TextBox)(this.FindName("txtExportMapTitle")));
            this.boxExportFormats = ((System.Windows.Controls.ComboBox)(this.FindName("boxExportFormats")));
            this.boxLayoutTemplates = ((System.Windows.Controls.ComboBox)(this.FindName("boxLayoutTemplates")));
            this.boxMetricUnits = ((System.Windows.Controls.ComboBox)(this.FindName("boxMetricUnits")));
            this.txtMetricLabel = ((System.Windows.Controls.TextBox)(this.FindName("txtMetricLabel")));
            this.boxNonmetricUnits = ((System.Windows.Controls.ComboBox)(this.FindName("boxNonmetricUnits")));
            this.txtNonmetricLabel = ((System.Windows.Controls.TextBox)(this.FindName("txtNonmetricLabel")));
            this.txtCopyright = ((System.Windows.Controls.TextBox)(this.FindName("txtCopyright")));
            this.linkExportResult = ((System.Windows.Controls.HyperlinkButton)(this.FindName("linkExportResult")));
            this.ExportMapButton = ((System.Windows.Controls.Button)(this.FindName("ExportMapButton")));
            this.PanelPrintMap = ((System.Windows.Controls.StackPanel)(this.FindName("PanelPrintMap")));
            this.txtPrintMapTitle = ((System.Windows.Controls.TextBox)(this.FindName("txtPrintMapTitle")));
            this.printMapPage = ((ESRI.SilverlightViewer.Generic.PrintMapPage)(this.FindName("printMapPage")));
            this.checkFitToPage = ((System.Windows.Controls.CheckBox)(this.FindName("checkFitToPage")));
            this.checkKeepScale = ((System.Windows.Controls.CheckBox)(this.FindName("checkKeepScale")));
            this.checkRotateMap = ((System.Windows.Controls.CheckBox)(this.FindName("checkRotateMap")));
            this.checkPrintLegend = ((System.Windows.Controls.CheckBox)(this.FindName("checkPrintLegend")));
            this.checkPrintOverview = ((System.Windows.Controls.CheckBox)(this.FindName("checkPrintOverview")));
            this.UpdateMapButton = ((System.Windows.Controls.Button)(this.FindName("UpdateMapButton")));
            this.PrintMapButton = ((System.Windows.Controls.Button)(this.FindName("PrintMapButton")));
            this.PrintingProgressPanel = ((System.Windows.Controls.StackPanel)(this.FindName("PrintingProgressPanel")));
            this.PrintingPageText = ((System.Windows.Controls.TextBlock)(this.FindName("PrintingPageText")));
            this.PrintingProgress = ((System.Windows.Controls.ProgressBar)(this.FindName("PrintingProgress")));
            this.PanelPrintData = ((System.Windows.Controls.StackPanel)(this.FindName("PanelPrintData")));
            this.StackWidgetCheck = ((System.Windows.Controls.StackPanel)(this.FindName("StackWidgetCheck")));
            this.CreatePrintButton = ((System.Windows.Controls.Button)(this.FindName("CreatePrintButton")));
        }
    }
}
