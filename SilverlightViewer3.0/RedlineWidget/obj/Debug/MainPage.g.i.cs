﻿#pragma checksum "C:\Projects\Silverlight2010\SilverlightViewer2.4\SilverlightViewer2.4\RedlineWidget\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "7FF0DCB2492C0F6591E156633DC9DBC4"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
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


namespace RedlineWidget {
    
    
    public partial class MainPage : ESRI.SilverlightViewer.Widget.WidgetBase {
        
        internal System.Windows.Controls.StackPanel spDraw;
        
        internal System.Windows.Controls.ListBox lbDrawMode;
        
        internal System.Windows.Controls.ComboBox cboColor;
        
        internal System.Windows.Controls.ComboBox cboFill;
        
        internal System.Windows.Controls.ComboBox cboWidth;
        
        internal System.Windows.Controls.ComboBox cboSize;
        
        internal System.Windows.Controls.StackPanel spTextString;
        
        internal System.Windows.Controls.TextBox txtString;
        
        internal System.Windows.Controls.Grid gridAnchor;
        
        internal System.Windows.Controls.StackPanel spMeasured;
        
        internal System.Windows.Controls.ComboBox cboColor_M;
        
        internal System.Windows.Controls.ComboBox cboFill_M;
        
        internal System.Windows.Controls.ComboBox cboWidth_M;
        
        internal System.Windows.Controls.Grid gridMeasured;
        
        internal System.Windows.Controls.TextBox txtWidthM;
        
        internal System.Windows.Controls.TextBox txtHeightM;
        
        internal System.Windows.Controls.ComboBox cboWidthUnits;
        
        internal System.Windows.Controls.ComboBox cboHeightUnits;
        
        internal System.Windows.Controls.Grid gridAzimuthed;
        
        internal System.Windows.Controls.TextBox txtLengthA;
        
        internal System.Windows.Controls.TextBox txtAzimuth;
        
        internal System.Windows.Controls.ComboBox cboLengthUnits;
        
        internal System.Windows.Controls.StackPanel spManage;
        
        internal System.Windows.Controls.ListBox lbGraphics;
        
        internal System.Windows.Controls.TextBlock tbMessage;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/RedlineWidget;component/MainPage.xaml", System.UriKind.Relative));
            this.spDraw = ((System.Windows.Controls.StackPanel)(this.FindName("spDraw")));
            this.lbDrawMode = ((System.Windows.Controls.ListBox)(this.FindName("lbDrawMode")));
            this.cboColor = ((System.Windows.Controls.ComboBox)(this.FindName("cboColor")));
            this.cboFill = ((System.Windows.Controls.ComboBox)(this.FindName("cboFill")));
            this.cboWidth = ((System.Windows.Controls.ComboBox)(this.FindName("cboWidth")));
            this.cboSize = ((System.Windows.Controls.ComboBox)(this.FindName("cboSize")));
            this.spTextString = ((System.Windows.Controls.StackPanel)(this.FindName("spTextString")));
            this.txtString = ((System.Windows.Controls.TextBox)(this.FindName("txtString")));
            this.gridAnchor = ((System.Windows.Controls.Grid)(this.FindName("gridAnchor")));
            this.spMeasured = ((System.Windows.Controls.StackPanel)(this.FindName("spMeasured")));
            this.cboColor_M = ((System.Windows.Controls.ComboBox)(this.FindName("cboColor_M")));
            this.cboFill_M = ((System.Windows.Controls.ComboBox)(this.FindName("cboFill_M")));
            this.cboWidth_M = ((System.Windows.Controls.ComboBox)(this.FindName("cboWidth_M")));
            this.gridMeasured = ((System.Windows.Controls.Grid)(this.FindName("gridMeasured")));
            this.txtWidthM = ((System.Windows.Controls.TextBox)(this.FindName("txtWidthM")));
            this.txtHeightM = ((System.Windows.Controls.TextBox)(this.FindName("txtHeightM")));
            this.cboWidthUnits = ((System.Windows.Controls.ComboBox)(this.FindName("cboWidthUnits")));
            this.cboHeightUnits = ((System.Windows.Controls.ComboBox)(this.FindName("cboHeightUnits")));
            this.gridAzimuthed = ((System.Windows.Controls.Grid)(this.FindName("gridAzimuthed")));
            this.txtLengthA = ((System.Windows.Controls.TextBox)(this.FindName("txtLengthA")));
            this.txtAzimuth = ((System.Windows.Controls.TextBox)(this.FindName("txtAzimuth")));
            this.cboLengthUnits = ((System.Windows.Controls.ComboBox)(this.FindName("cboLengthUnits")));
            this.spManage = ((System.Windows.Controls.StackPanel)(this.FindName("spManage")));
            this.lbGraphics = ((System.Windows.Controls.ListBox)(this.FindName("lbGraphics")));
            this.tbMessage = ((System.Windows.Controls.TextBlock)(this.FindName("tbMessage")));
        }
    }
}

