﻿#pragma checksum "C:\Projects\Silverlight2010\SilverlightViewer2.1\ChartingWidget\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "41BD83132C06A029B6308E83FE5F5346"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.225
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


namespace ChartingWidget {
    
    
    public partial class MainPage : ESRI.SilverlightViewer.Widget.WidgetBase {
        
        internal System.Windows.Controls.StackPanel PanelAttributeQuery;
        
        internal System.Windows.Controls.ComboBox lstAttQueryLayer;
        
        internal System.Windows.Controls.ListBox lstAttQueryField;
        
        internal System.Windows.Controls.TextBox txtAttQueryWhere;
        
        internal System.Windows.Controls.Button btnAttWhereClear;
        
        internal System.Windows.Controls.Grid OperatorsGrid;
        
        internal System.Windows.Controls.Button btnOperLike;
        
        internal System.Windows.Controls.Button btnOperAnd;
        
        internal System.Windows.Controls.Button btnOperOr;
        
        internal System.Windows.Controls.Button btnOperNot;
        
        internal System.Windows.Controls.Button btnOperIs;
        
        internal System.Windows.Controls.Button btnOperNULL;
        
        internal System.Windows.Controls.Button btnOperEqual;
        
        internal System.Windows.Controls.Button btnOperNotEqual;
        
        internal System.Windows.Controls.Button btnOperGreater;
        
        internal System.Windows.Controls.Button btnOperLess;
        
        internal System.Windows.Controls.Button btnOperGtEqual;
        
        internal System.Windows.Controls.Button btnOperLtEqual;
        
        internal System.Windows.Controls.Button btnSubmitAttQuery;
        
        internal System.Windows.Controls.Grid PanelChartOutput;
        
        internal System.Windows.Controls.TextBlock ChartResultMessage;
        
        internal ESRI.SilverlightViewer.Controls.SplitGrid ChartResultGrid;
        
        internal System.Windows.Controls.StackPanel LeftResultStack;
        
        internal System.Windows.Controls.StackPanel RightChartStack;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/ChartingWidget;component/MainPage.xaml", System.UriKind.Relative));
            this.PanelAttributeQuery = ((System.Windows.Controls.StackPanel)(this.FindName("PanelAttributeQuery")));
            this.lstAttQueryLayer = ((System.Windows.Controls.ComboBox)(this.FindName("lstAttQueryLayer")));
            this.lstAttQueryField = ((System.Windows.Controls.ListBox)(this.FindName("lstAttQueryField")));
            this.txtAttQueryWhere = ((System.Windows.Controls.TextBox)(this.FindName("txtAttQueryWhere")));
            this.btnAttWhereClear = ((System.Windows.Controls.Button)(this.FindName("btnAttWhereClear")));
            this.OperatorsGrid = ((System.Windows.Controls.Grid)(this.FindName("OperatorsGrid")));
            this.btnOperLike = ((System.Windows.Controls.Button)(this.FindName("btnOperLike")));
            this.btnOperAnd = ((System.Windows.Controls.Button)(this.FindName("btnOperAnd")));
            this.btnOperOr = ((System.Windows.Controls.Button)(this.FindName("btnOperOr")));
            this.btnOperNot = ((System.Windows.Controls.Button)(this.FindName("btnOperNot")));
            this.btnOperIs = ((System.Windows.Controls.Button)(this.FindName("btnOperIs")));
            this.btnOperNULL = ((System.Windows.Controls.Button)(this.FindName("btnOperNULL")));
            this.btnOperEqual = ((System.Windows.Controls.Button)(this.FindName("btnOperEqual")));
            this.btnOperNotEqual = ((System.Windows.Controls.Button)(this.FindName("btnOperNotEqual")));
            this.btnOperGreater = ((System.Windows.Controls.Button)(this.FindName("btnOperGreater")));
            this.btnOperLess = ((System.Windows.Controls.Button)(this.FindName("btnOperLess")));
            this.btnOperGtEqual = ((System.Windows.Controls.Button)(this.FindName("btnOperGtEqual")));
            this.btnOperLtEqual = ((System.Windows.Controls.Button)(this.FindName("btnOperLtEqual")));
            this.btnSubmitAttQuery = ((System.Windows.Controls.Button)(this.FindName("btnSubmitAttQuery")));
            this.PanelChartOutput = ((System.Windows.Controls.Grid)(this.FindName("PanelChartOutput")));
            this.ChartResultMessage = ((System.Windows.Controls.TextBlock)(this.FindName("ChartResultMessage")));
            this.ChartResultGrid = ((ESRI.SilverlightViewer.Controls.SplitGrid)(this.FindName("ChartResultGrid")));
            this.LeftResultStack = ((System.Windows.Controls.StackPanel)(this.FindName("LeftResultStack")));
            this.RightChartStack = ((System.Windows.Controls.StackPanel)(this.FindName("RightChartStack")));
        }
    }
}

