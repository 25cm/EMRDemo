using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using DevExpress.Internal;
using DevExpress.Utils;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraRichEdit;
using DevExpress.XtraRichEdit.API.Native;
using DevExpress.XtraRichEdit.API.Native.Implementation;
using DevExpress.XtraRichEdit.Fields;
using ERMControl.Meta;
using ERMControl.Properties;
using ERMUserControl;
using GhostscriptSharp;
using IHIS.Framework;

namespace ERMControl
{
    public partial class Editor : UserControl
    {
        #region

        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editor));
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem2 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem2 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip3 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem3 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem3 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip4 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem4 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem4 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip5 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem5 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem5 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip6 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem6 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem6 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip7 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem7 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem7 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip8 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem8 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem8 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip9 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem9 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem9 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip10 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem10 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem10 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip11 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem11 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem11 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip12 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem12 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem12 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip13 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem13 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem13 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip14 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem14 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem14 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip15 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem15 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem15 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip19 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem19 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem19 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip16 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem16 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem16 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip17 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem17 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem17 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip18 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem18 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem18 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip20 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem20 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem20 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip21 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem21 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem21 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip22 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem22 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem22 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip23 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem23 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem23 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip24 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem24 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem24 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip25 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem25 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem25 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip26 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem26 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem26 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip27 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem27 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem27 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip36 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem36 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem36 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip28 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem28 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem28 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip29 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem29 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem29 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip30 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem30 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem30 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip31 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem31 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem31 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip32 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem32 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem32 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip33 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem33 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem33 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip34 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem34 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem34 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip35 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem35 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem35 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip37 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem37 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem37 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip38 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem38 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem38 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip39 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem39 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem39 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip40 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem40 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem40 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip41 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem41 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem41 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip42 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem42 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem42 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip43 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem43 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem43 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip44 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem44 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem44 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip45 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem45 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem45 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip57 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem57 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem57 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip46 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem46 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem46 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip47 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem47 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem47 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip48 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem48 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem48 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip49 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem49 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem49 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip50 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem50 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem50 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip51 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem51 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem51 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip52 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem52 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem52 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip53 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem53 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem53 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip54 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem54 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem54 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip55 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem55 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem55 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip56 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem56 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem56 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip58 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem58 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem58 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip59 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem59 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem59 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip60 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem60 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem60 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip65 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem65 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem65 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip61 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem61 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem61 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip62 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem62 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem62 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip63 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem63 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem63 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip64 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem64 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem64 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip66 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem66 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem66 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip71 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem71 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem71 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip67 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem67 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem67 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip68 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem68 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem68 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip69 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem69 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem69 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip70 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem70 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem70 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip72 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem72 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem72 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip73 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem73 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem73 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip74 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem74 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem74 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip75 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem75 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem75 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip76 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem76 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem76 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip77 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem77 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem77 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip78 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem78 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem78 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip79 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem79 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem79 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip83 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem83 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem83 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip80 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem80 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem80 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip81 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem81 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem81 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip82 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem82 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem82 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip84 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem84 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem84 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip85 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem85 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem85 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip86 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem86 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem86 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip87 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem87 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem87 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip88 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem88 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem88 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip89 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem89 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem89 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip90 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem90 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem90 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip91 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem91 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem91 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip92 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem92 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem92 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip93 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem93 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem93 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip94 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem94 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem94 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip95 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem95 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem95 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip96 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem96 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem96 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip97 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem97 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem97 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip98 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem98 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem98 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip99 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem99 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem99 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip100 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem100 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem100 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip101 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem101 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem101 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip102 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem102 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem102 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip103 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem103 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem103 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip104 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem104 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem104 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip105 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem105 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem105 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip106 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem106 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem106 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip107 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem107 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem107 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip108 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem108 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem108 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip109 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem109 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem109 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip110 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem110 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem110 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip115 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem115 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem115 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip111 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem111 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem111 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip112 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem112 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem112 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip113 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem113 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem113 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip114 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem114 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem114 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip118 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem118 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem118 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip116 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem116 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem116 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip117 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem117 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem117 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip119 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem119 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem119 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip124 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem124 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem124 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip120 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem120 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem120 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip121 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem121 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem121 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip122 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem122 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem122 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip123 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem123 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem123 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip130 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem130 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem130 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip125 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem125 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem125 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip126 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem126 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem126 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip127 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem127 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem127 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip128 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem128 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem128 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip129 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem129 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem129 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip137 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem137 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem137 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip131 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem131 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem131 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip132 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem132 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem132 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip133 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem133 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem133 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip134 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem134 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem134 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip135 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem135 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem135 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip136 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem136 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem136 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip138 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem138 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem138 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip139 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem139 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem139 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip140 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem140 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem140 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip141 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem141 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem141 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip142 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem142 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem142 = new DevExpress.Utils.ToolTipItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.commonBar1 = new DevExpress.XtraRichEdit.UI.CommonBar();
            this.insertPdfItem = new DevExpress.XtraBars.BarButtonItem();
            this.insertImage1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.cutItem1 = new DevExpress.XtraRichEdit.UI.CutItem();
            this.copyItem1 = new DevExpress.XtraRichEdit.UI.CopyItem();
            this.pasteItem1 = new DevExpress.XtraRichEdit.UI.PasteItem();
            this.pasteSpecialItem1 = new DevExpress.XtraRichEdit.UI.PasteSpecialItem();
            this.changeFontNameItem1 = new DevExpress.XtraRichEdit.UI.ChangeFontNameItem();
            this.repositoryItemFontEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemFontEdit();
            this.changeFontSizeItem1 = new DevExpress.XtraRichEdit.UI.ChangeFontSizeItem();
            this.repositoryItemRichEditFontSizeEdit1 = new DevExpress.XtraRichEdit.Design.RepositoryItemRichEditFontSizeEdit();
            this.changeFontColorItem1 = new DevExpress.XtraRichEdit.UI.ChangeFontColorItem();
            this.changeFontBackColorItem1 = new DevExpress.XtraRichEdit.UI.ChangeFontBackColorItem();
            this.toggleFontBoldItem1 = new DevExpress.XtraRichEdit.UI.ToggleFontBoldItem();
            this.toggleFontItalicItem1 = new DevExpress.XtraRichEdit.UI.ToggleFontItalicItem();
            this.toggleFontUnderlineItem1 = new DevExpress.XtraRichEdit.UI.ToggleFontUnderlineItem();
            this.toggleFontDoubleUnderlineItem1 = new DevExpress.XtraRichEdit.UI.ToggleFontDoubleUnderlineItem();
            this.toggleFontStrikeoutItem1 = new DevExpress.XtraRichEdit.UI.ToggleFontStrikeoutItem();
            this.toggleFontDoubleStrikeoutItem1 = new DevExpress.XtraRichEdit.UI.ToggleFontDoubleStrikeoutItem();
            this.toggleFontSubscriptItem1 = new DevExpress.XtraRichEdit.UI.ToggleFontSubscriptItem();
            this.changeTextCaseItem1 = new DevExpress.XtraRichEdit.UI.ChangeTextCaseItem();
            this.makeTextUpperCaseItem1 = new DevExpress.XtraRichEdit.UI.MakeTextUpperCaseItem();
            this.makeTextLowerCaseItem1 = new DevExpress.XtraRichEdit.UI.MakeTextLowerCaseItem();
            this.toggleTextCaseItem1 = new DevExpress.XtraRichEdit.UI.ToggleTextCaseItem();
            this.fontSizeIncreaseItem1 = new DevExpress.XtraRichEdit.UI.FontSizeIncreaseItem();
            this.fontSizeDecreaseItem1 = new DevExpress.XtraRichEdit.UI.FontSizeDecreaseItem();
            this.clearFormattingItem1 = new DevExpress.XtraRichEdit.UI.ClearFormattingItem();
            this.showFontFormItem1 = new DevExpress.XtraRichEdit.UI.ShowFontFormItem();
            this.toggleParagraphAlignmentLeftItem1 = new DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentLeftItem();
            this.toggleParagraphAlignmentCenterItem1 = new DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentCenterItem();
            this.toggleParagraphAlignmentRightItem1 = new DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentRightItem();
            this.toggleParagraphAlignmentJustifyItem1 = new DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentJustifyItem();
            this.changeParagraphLineSpacingItem1 = new DevExpress.XtraRichEdit.UI.ChangeParagraphLineSpacingItem();
            this.setSingleParagraphSpacingItem1 = new DevExpress.XtraRichEdit.UI.SetSingleParagraphSpacingItem();
            this.setSesquialteralParagraphSpacingItem1 = new DevExpress.XtraRichEdit.UI.SetSesquialteralParagraphSpacingItem();
            this.setDoubleParagraphSpacingItem1 = new DevExpress.XtraRichEdit.UI.SetDoubleParagraphSpacingItem();
            this.showLineSpacingFormItem1 = new DevExpress.XtraRichEdit.UI.ShowLineSpacingFormItem();
            this.addSpacingBeforeParagraphItem1 = new DevExpress.XtraRichEdit.UI.AddSpacingBeforeParagraphItem();
            this.removeSpacingBeforeParagraphItem1 = new DevExpress.XtraRichEdit.UI.RemoveSpacingBeforeParagraphItem();
            this.addSpacingAfterParagraphItem1 = new DevExpress.XtraRichEdit.UI.AddSpacingAfterParagraphItem();
            this.removeSpacingAfterParagraphItem1 = new DevExpress.XtraRichEdit.UI.RemoveSpacingAfterParagraphItem();
            this.toggleNumberingListItem1 = new DevExpress.XtraRichEdit.UI.ToggleNumberingListItem();
            this.toggleMultiLevelListItem1 = new DevExpress.XtraRichEdit.UI.ToggleMultiLevelListItem();
            this.decreaseIndentItem1 = new DevExpress.XtraRichEdit.UI.DecreaseIndentItem();
            this.increaseIndentItem1 = new DevExpress.XtraRichEdit.UI.IncreaseIndentItem();
            this.toggleShowWhitespaceItem1 = new DevExpress.XtraRichEdit.UI.ToggleShowWhitespaceItem();
            this.showParagraphFormItem1 = new DevExpress.XtraRichEdit.UI.ShowParagraphFormItem();
            this.findItem1 = new DevExpress.XtraRichEdit.UI.FindItem();
            this.replaceItem1 = new DevExpress.XtraRichEdit.UI.ReplaceItem();
            this.changeTableCellsShadingItem1 = new DevExpress.XtraRichEdit.UI.ChangeTableCellsShadingItem();
            this.changeTableBordersItem1 = new DevExpress.XtraRichEdit.UI.ChangeTableBordersItem();
            this.toggleTableCellsBottomBorderItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomBorderItem();
            this.toggleTableCellsTopBorderItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableCellsTopBorderItem();
            this.toggleTableCellsLeftBorderItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableCellsLeftBorderItem();
            this.toggleTableCellsRightBorderItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableCellsRightBorderItem();
            this.resetTableCellsAllBordersItem1 = new DevExpress.XtraRichEdit.UI.ResetTableCellsAllBordersItem();
            this.toggleTableCellsAllBordersItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableCellsAllBordersItem();
            this.toggleTableCellsOutsideBorderItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableCellsOutsideBorderItem();
            this.toggleTableCellsInsideBorderItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableCellsInsideBorderItem();
            this.toggleTableCellsInsideHorizontalBorderItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableCellsInsideHorizontalBorderItem();
            this.toggleTableCellsInsideVerticalBorderItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableCellsInsideVerticalBorderItem();
            this.toggleShowTableGridLinesItem1 = new DevExpress.XtraRichEdit.UI.ToggleShowTableGridLinesItem();
            this.changeTableBorderLineStyleItem1 = new DevExpress.XtraRichEdit.UI.ChangeTableBorderLineStyleItem();
            this.repositoryItemBorderLineStyle1 = new DevExpress.XtraRichEdit.Forms.Design.RepositoryItemBorderLineStyle();
            this.changeTableBorderLineWeightItem1 = new DevExpress.XtraRichEdit.UI.ChangeTableBorderLineWeightItem();
            this.repositoryItemBorderLineWeight1 = new DevExpress.XtraRichEdit.Forms.Design.RepositoryItemBorderLineWeight();
            this.changeTableBorderColorItem1 = new DevExpress.XtraRichEdit.UI.ChangeTableBorderColorItem();
            this.selectTableElementsItem1 = new DevExpress.XtraRichEdit.UI.SelectTableElementsItem();
            this.selectTableCellItem1 = new DevExpress.XtraRichEdit.UI.SelectTableCellItem();
            this.selectTableColumnItem1 = new DevExpress.XtraRichEdit.UI.SelectTableColumnItem();
            this.selectTableRowItem1 = new DevExpress.XtraRichEdit.UI.SelectTableRowItem();
            this.selectTableItem1 = new DevExpress.XtraRichEdit.UI.SelectTableItem();
            this.showTablePropertiesFormItem1 = new DevExpress.XtraRichEdit.UI.ShowTablePropertiesFormItem();
            this.deleteTableElementsItem1 = new DevExpress.XtraRichEdit.UI.DeleteTableElementsItem();
            this.showDeleteTableCellsFormItem1 = new DevExpress.XtraRichEdit.UI.ShowDeleteTableCellsFormItem();
            this.deleteTableColumnsItem1 = new DevExpress.XtraRichEdit.UI.DeleteTableColumnsItem();
            this.deleteTableRowsItem1 = new DevExpress.XtraRichEdit.UI.DeleteTableRowsItem();
            this.deleteTableItem1 = new DevExpress.XtraRichEdit.UI.DeleteTableItem();
            this.insertTableRowAboveItem1 = new DevExpress.XtraRichEdit.UI.InsertTableRowAboveItem();
            this.insertTableRowBelowItem1 = new DevExpress.XtraRichEdit.UI.InsertTableRowBelowItem();
            this.insertTableColumnToLeftItem1 = new DevExpress.XtraRichEdit.UI.InsertTableColumnToLeftItem();
            this.insertTableColumnToRightItem1 = new DevExpress.XtraRichEdit.UI.InsertTableColumnToRightItem();
            this.showInsertTableCellsFormItem1 = new DevExpress.XtraRichEdit.UI.ShowInsertTableCellsFormItem();
            this.mergeTableCellsItem1 = new DevExpress.XtraRichEdit.UI.MergeTableCellsItem();
            this.showSplitTableCellsForm1 = new DevExpress.XtraRichEdit.UI.ShowSplitTableCellsForm();
            this.splitTableItem1 = new DevExpress.XtraRichEdit.UI.SplitTableItem();
            this.toggleTableAutoFitItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableAutoFitItem();
            this.toggleTableAutoFitContentsItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableAutoFitContentsItem();
            this.toggleTableAutoFitWindowItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableAutoFitWindowItem();
            this.toggleTableFixedColumnWidthItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableFixedColumnWidthItem();
            this.toggleTableCellsTopLeftAlignmentItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableCellsTopLeftAlignmentItem();
            this.toggleTableCellsTopCenterAlignmentItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableCellsTopCenterAlignmentItem();
            this.toggleTableCellsTopRightAlignmentItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableCellsTopRightAlignmentItem();
            this.toggleTableCellsMiddleLeftAlignmentItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableCellsMiddleLeftAlignmentItem();
            this.toggleTableCellsMiddleCenterAlignmentItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableCellsMiddleCenterAlignmentItem();
            this.toggleTableCellsMiddleRightAlignmentItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableCellsMiddleRightAlignmentItem();
            this.toggleTableCellsBottomLeftAlignmentItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomLeftAlignmentItem();
            this.toggleTableCellsBottomCenterAlignmentItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomCenterAlignmentItem();
            this.toggleTableCellsBottomRightAlignmentItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomRightAlignmentItem();
            this.switchToSimpleViewItem1 = new DevExpress.XtraRichEdit.UI.SwitchToSimpleViewItem();
            this.switchToDraftViewItem1 = new DevExpress.XtraRichEdit.UI.SwitchToDraftViewItem();
            this.switchToPrintLayoutViewItem1 = new DevExpress.XtraRichEdit.UI.SwitchToPrintLayoutViewItem();
            this.toggleShowHorizontalRulerItem1 = new DevExpress.XtraRichEdit.UI.ToggleShowHorizontalRulerItem();
            this.toggleShowVerticalRulerItem1 = new DevExpress.XtraRichEdit.UI.ToggleShowVerticalRulerItem();
            this.zoomOutItem1 = new DevExpress.XtraRichEdit.UI.ZoomOutItem();
            this.zoomInItem1 = new DevExpress.XtraRichEdit.UI.ZoomInItem();
            this.toggleBulletedListItem1 = new DevExpress.XtraRichEdit.UI.ToggleBulletedListItem();
            this.insertPageBreakItem1 = new DevExpress.XtraRichEdit.UI.InsertPageBreakItem();
            this.insertTableItem1 = new DevExpress.XtraRichEdit.UI.InsertTableItem();
            this.insertPictureItem1 = new DevExpress.XtraRichEdit.UI.InsertPictureItem();
            this.insertBookmarkItem1 = new DevExpress.XtraRichEdit.UI.InsertBookmarkItem();
            this.insertHyperlinkItem1 = new DevExpress.XtraRichEdit.UI.InsertHyperlinkItem();
            this.editPageHeaderItem1 = new DevExpress.XtraRichEdit.UI.EditPageHeaderItem();
            this.editPageFooterItem1 = new DevExpress.XtraRichEdit.UI.EditPageFooterItem();
            this.insertPageNumberItem1 = new DevExpress.XtraRichEdit.UI.InsertPageNumberItem();
            this.insertPageCountItem1 = new DevExpress.XtraRichEdit.UI.InsertPageCountItem();
            this.insertSymbolItem1 = new DevExpress.XtraRichEdit.UI.InsertSymbolItem();
            this.changeSectionPageMarginsItem1 = new DevExpress.XtraRichEdit.UI.ChangeSectionPageMarginsItem();
            this.setNormalSectionPageMarginsItem1 = new DevExpress.XtraRichEdit.UI.SetNormalSectionPageMarginsItem();
            this.setNarrowSectionPageMarginsItem1 = new DevExpress.XtraRichEdit.UI.SetNarrowSectionPageMarginsItem();
            this.setModerateSectionPageMarginsItem1 = new DevExpress.XtraRichEdit.UI.SetModerateSectionPageMarginsItem();
            this.setWideSectionPageMarginsItem1 = new DevExpress.XtraRichEdit.UI.SetWideSectionPageMarginsItem();
            this.changeSectionPageOrientationItem1 = new DevExpress.XtraRichEdit.UI.ChangeSectionPageOrientationItem();
            this.setPortraitPageOrientationItem1 = new DevExpress.XtraRichEdit.UI.SetPortraitPageOrientationItem();
            this.setLandscapePageOrientationItem1 = new DevExpress.XtraRichEdit.UI.SetLandscapePageOrientationItem();
            this.changeSectionPaperKindItem1 = new DevExpress.XtraRichEdit.UI.ChangeSectionPaperKindItem();
            this.changeSectionColumnsItem1 = new DevExpress.XtraRichEdit.UI.ChangeSectionColumnsItem();
            this.setSectionOneColumnItem1 = new DevExpress.XtraRichEdit.UI.SetSectionOneColumnItem();
            this.setSectionTwoColumnsItem1 = new DevExpress.XtraRichEdit.UI.SetSectionTwoColumnsItem();
            this.setSectionThreeColumnsItem1 = new DevExpress.XtraRichEdit.UI.SetSectionThreeColumnsItem();
            this.showColumnsSetupFormItem1 = new DevExpress.XtraRichEdit.UI.ShowColumnsSetupFormItem();
            this.insertBreakItem1 = new DevExpress.XtraRichEdit.UI.InsertBreakItem();
            this.insertPageBreakItem2 = new DevExpress.XtraRichEdit.UI.InsertPageBreakItem();
            this.insertColumnBreakItem1 = new DevExpress.XtraRichEdit.UI.InsertColumnBreakItem();
            this.insertSectionBreakNextPageItem1 = new DevExpress.XtraRichEdit.UI.InsertSectionBreakNextPageItem();
            this.insertSectionBreakEvenPageItem1 = new DevExpress.XtraRichEdit.UI.InsertSectionBreakEvenPageItem();
            this.insertSectionBreakOddPageItem1 = new DevExpress.XtraRichEdit.UI.InsertSectionBreakOddPageItem();
            this.changeSectionLineNumberingItem1 = new DevExpress.XtraRichEdit.UI.ChangeSectionLineNumberingItem();
            this.setSectionLineNumberingNoneItem1 = new DevExpress.XtraRichEdit.UI.SetSectionLineNumberingNoneItem();
            this.setSectionLineNumberingContinuousItem1 = new DevExpress.XtraRichEdit.UI.SetSectionLineNumberingContinuousItem();
            this.setSectionLineNumberingRestartNewPageItem1 = new DevExpress.XtraRichEdit.UI.SetSectionLineNumberingRestartNewPageItem();
            this.setSectionLineNumberingRestartNewSectionItem1 = new DevExpress.XtraRichEdit.UI.SetSectionLineNumberingRestartNewSectionItem();
            this.toggleParagraphSuppressLineNumbersItem1 = new DevExpress.XtraRichEdit.UI.ToggleParagraphSuppressLineNumbersItem();
            this.showLineNumberingFormItem1 = new DevExpress.XtraRichEdit.UI.ShowLineNumberingFormItem();
            this.checkSpellingItem1 = new DevExpress.XtraRichEdit.UI.CheckSpellingItem();
            this.protectDocumentItem1 = new DevExpress.XtraRichEdit.UI.ProtectDocumentItem();
            this.changeRangeEditingPermissionsItem1 = new DevExpress.XtraRichEdit.UI.ChangeRangeEditingPermissionsItem();
            this.unprotectDocumentItem1 = new DevExpress.XtraRichEdit.UI.UnprotectDocumentItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.cboTemplate = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.barStaticItem2 = new DevExpress.XtraBars.BarStaticItem();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemPictureEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.repositoryItemRichEditStyleEdit1 = new DevExpress.XtraRichEdit.Design.RepositoryItemRichEditStyleEdit();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemRichEditStyleEdit2 = new DevExpress.XtraRichEdit.Design.RepositoryItemRichEditStyleEdit();
            this.repositoryItemComboBox2 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.repositoryItemComboBox4 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.repositoryItemRichEditStyleEdit3 = new DevExpress.XtraRichEdit.Design.RepositoryItemRichEditStyleEdit();
            this.richEditBarController1 = new DevExpress.XtraRichEdit.UI.RichEditBarController();
            this.stylesBar2 = new DevExpress.XtraRichEdit.UI.StylesBar();
            this.grdContent = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTagCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colTagName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNotes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.repositoryItemPictureEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.CreateDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.repositoryItemRichTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit();
            this.repositoryItemComboBox3 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.repositoryItemGridLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemRichTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit();
            this.repositoryItemRichTextEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit();
            this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTextEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.cboTempl1 = new System.Windows.Forms.ComboBox();
            this.cboDisplay = new System.Windows.Forms.ComboBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.insertBookmark = new DevExpress.XtraEditors.LabelControl();
            this.fileSaveItem2 = new DevExpress.XtraRichEdit.UI.FileSaveItem();
            this.commonBar2 = new DevExpress.XtraRichEdit.UI.CommonBar();
            this.commonBar3 = new DevExpress.XtraRichEdit.UI.CommonBar();
            this.commonBar4 = new DevExpress.XtraRichEdit.UI.CommonBar();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.dateEdit = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemFontEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRichEditFontSizeEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemBorderLineStyle1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemBorderLineWeight1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRichEditStyleEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRichEditStyleEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRichEditStyleEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.richEditBarController1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdContent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRichTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRichTextEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRichTextEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3,
            this.commonBar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.cutItem1,
            this.copyItem1,
            this.pasteItem1,
            this.pasteSpecialItem1,
            this.changeFontNameItem1,
            this.changeFontSizeItem1,
            this.changeFontColorItem1,
            this.changeFontBackColorItem1,
            this.toggleFontBoldItem1,
            this.toggleFontItalicItem1,
            this.toggleFontUnderlineItem1,
            this.toggleFontDoubleUnderlineItem1,
            this.toggleFontStrikeoutItem1,
            this.toggleFontDoubleStrikeoutItem1,
            this.toggleFontSubscriptItem1,
            this.changeTextCaseItem1,
            this.makeTextUpperCaseItem1,
            this.makeTextLowerCaseItem1,
            this.toggleTextCaseItem1,
            this.fontSizeIncreaseItem1,
            this.fontSizeDecreaseItem1,
            this.clearFormattingItem1,
            this.showFontFormItem1,
            this.toggleParagraphAlignmentLeftItem1,
            this.toggleParagraphAlignmentCenterItem1,
            this.toggleParagraphAlignmentRightItem1,
            this.toggleParagraphAlignmentJustifyItem1,
            this.changeParagraphLineSpacingItem1,
            this.setSingleParagraphSpacingItem1,
            this.setSesquialteralParagraphSpacingItem1,
            this.setDoubleParagraphSpacingItem1,
            this.showLineSpacingFormItem1,
            this.addSpacingBeforeParagraphItem1,
            this.removeSpacingBeforeParagraphItem1,
            this.addSpacingAfterParagraphItem1,
            this.removeSpacingAfterParagraphItem1,
            this.toggleNumberingListItem1,
            this.toggleMultiLevelListItem1,
            this.decreaseIndentItem1,
            this.increaseIndentItem1,
            this.toggleShowWhitespaceItem1,
            this.showParagraphFormItem1,
            this.findItem1,
            this.replaceItem1,
            this.changeTableCellsShadingItem1,
            this.changeTableBordersItem1,
            this.toggleTableCellsBottomBorderItem1,
            this.toggleTableCellsTopBorderItem1,
            this.toggleTableCellsLeftBorderItem1,
            this.toggleTableCellsRightBorderItem1,
            this.resetTableCellsAllBordersItem1,
            this.toggleTableCellsAllBordersItem1,
            this.toggleTableCellsOutsideBorderItem1,
            this.toggleTableCellsInsideBorderItem1,
            this.toggleTableCellsInsideHorizontalBorderItem1,
            this.toggleTableCellsInsideVerticalBorderItem1,
            this.toggleShowTableGridLinesItem1,
            this.changeTableBorderLineStyleItem1,
            this.changeTableBorderLineWeightItem1,
            this.changeTableBorderColorItem1,
            this.selectTableElementsItem1,
            this.selectTableCellItem1,
            this.selectTableColumnItem1,
            this.selectTableRowItem1,
            this.selectTableItem1,
            this.showTablePropertiesFormItem1,
            this.deleteTableElementsItem1,
            this.showDeleteTableCellsFormItem1,
            this.deleteTableColumnsItem1,
            this.deleteTableRowsItem1,
            this.deleteTableItem1,
            this.insertTableRowAboveItem1,
            this.insertTableRowBelowItem1,
            this.insertTableColumnToLeftItem1,
            this.insertTableColumnToRightItem1,
            this.showInsertTableCellsFormItem1,
            this.mergeTableCellsItem1,
            this.showSplitTableCellsForm1,
            this.splitTableItem1,
            this.toggleTableAutoFitItem1,
            this.toggleTableAutoFitContentsItem1,
            this.toggleTableAutoFitWindowItem1,
            this.toggleTableFixedColumnWidthItem1,
            this.toggleTableCellsTopLeftAlignmentItem1,
            this.toggleTableCellsTopCenterAlignmentItem1,
            this.toggleTableCellsTopRightAlignmentItem1,
            this.toggleTableCellsMiddleLeftAlignmentItem1,
            this.toggleTableCellsMiddleCenterAlignmentItem1,
            this.toggleTableCellsMiddleRightAlignmentItem1,
            this.toggleTableCellsBottomLeftAlignmentItem1,
            this.toggleTableCellsBottomCenterAlignmentItem1,
            this.toggleTableCellsBottomRightAlignmentItem1,
            this.switchToSimpleViewItem1,
            this.switchToDraftViewItem1,
            this.switchToPrintLayoutViewItem1,
            this.toggleShowHorizontalRulerItem1,
            this.toggleShowVerticalRulerItem1,
            this.zoomOutItem1,
            this.zoomInItem1,
            this.toggleBulletedListItem1,
            this.insertPageBreakItem1,
            this.insertTableItem1,
            this.insertPictureItem1,
            this.insertBookmarkItem1,
            this.insertHyperlinkItem1,
            this.editPageHeaderItem1,
            this.editPageFooterItem1,
            this.insertPageNumberItem1,
            this.insertPageCountItem1,
            this.insertSymbolItem1,
            this.changeSectionPageMarginsItem1,
            this.setNormalSectionPageMarginsItem1,
            this.setNarrowSectionPageMarginsItem1,
            this.setModerateSectionPageMarginsItem1,
            this.setWideSectionPageMarginsItem1,
            this.changeSectionPageOrientationItem1,
            this.setPortraitPageOrientationItem1,
            this.setLandscapePageOrientationItem1,
            this.changeSectionPaperKindItem1,
            this.changeSectionColumnsItem1,
            this.setSectionOneColumnItem1,
            this.setSectionTwoColumnsItem1,
            this.setSectionThreeColumnsItem1,
            this.showColumnsSetupFormItem1,
            this.insertBreakItem1,
            this.insertPageBreakItem2,
            this.insertColumnBreakItem1,
            this.insertSectionBreakNextPageItem1,
            this.insertSectionBreakEvenPageItem1,
            this.insertSectionBreakOddPageItem1,
            this.changeSectionLineNumberingItem1,
            this.setSectionLineNumberingNoneItem1,
            this.setSectionLineNumberingContinuousItem1,
            this.setSectionLineNumberingRestartNewPageItem1,
            this.setSectionLineNumberingRestartNewSectionItem1,
            this.toggleParagraphSuppressLineNumbersItem1,
            this.showLineNumberingFormItem1,
            this.checkSpellingItem1,
            this.protectDocumentItem1,
            this.changeRangeEditingPermissionsItem1,
            this.unprotectDocumentItem1,
            this.barStaticItem1,
            this.cboTemplate,
            this.barStaticItem2,
            this.barEditItem1,
            this.insertPdfItem,
            this.barButtonItem1,
            this.insertImage1,
            this.barButtonItem2});
            this.barManager1.MaxItemId = 192;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemFontEdit1,
            this.repositoryItemRichEditFontSizeEdit1,
            this.repositoryItemRichEditStyleEdit1,
            this.repositoryItemBorderLineStyle1,
            this.repositoryItemBorderLineWeight1,
            this.repositoryItemPictureEdit1,
            this.repositoryItemComboBox1,
            this.repositoryItemTextEdit1,
            this.repositoryItemRichEditStyleEdit2,
            this.repositoryItemComboBox2,
            this.repositoryItemComboBox4,
            this.repositoryItemPictureEdit2,
            this.repositoryItemRichEditStyleEdit3});
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // commonBar1
            // 
            this.commonBar1.BarName = "";
            this.commonBar1.DockCol = 0;
            this.commonBar1.DockRow = 0;
            this.commonBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.commonBar1.FloatLocation = new System.Drawing.Point(481, 151);
            this.commonBar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.insertPdfItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.insertImage1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2)});
            this.commonBar1.Offset = 381;
            this.commonBar1.Text = "";
            // 
            // insertPdfItem
            // 
            this.insertPdfItem.Caption = "Pdf";
            this.insertPdfItem.Id = 188;
            this.insertPdfItem.Name = "insertPdfItem";
            this.insertPdfItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.insertPdfItem_ItemClick);
            // 
            // insertImage1
            // 
            this.insertImage1.Caption = "Img";
            this.insertImage1.Id = 190;
            this.insertImage1.Name = "insertImage1";
            this.insertImage1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.insertImage1_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Bookmark";
            this.barButtonItem2.Id = 191;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(728, 29);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 491);
            this.barDockControlBottom.Size = new System.Drawing.Size(728, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 29);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 462);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(728, 29);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 462);
            // 
            // cutItem1
            // 
            this.cutItem1.Caption = "Cut";
            this.cutItem1.Enabled = false;
            this.cutItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("cutItem1.Glyph")));
            this.cutItem1.Id = 2;
            this.cutItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("cutItem1.LargeGlyph")));
            this.cutItem1.Name = "cutItem1";
            toolTipTitleItem1.Text = "Cut (Ctrl+X)";
            toolTipItem1.Text = "Cut the selection from the document and put it on the Clipboard.";
            superToolTip1.Items.Add(toolTipTitleItem1);
            superToolTip1.Items.Add(toolTipItem1);
            this.cutItem1.SuperTip = superToolTip1;
            // 
            // copyItem1
            // 
            this.copyItem1.Caption = "Copy";
            this.copyItem1.Enabled = false;
            this.copyItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("copyItem1.Glyph")));
            this.copyItem1.Id = 3;
            this.copyItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("copyItem1.LargeGlyph")));
            this.copyItem1.Name = "copyItem1";
            toolTipTitleItem2.Text = "Copy (Ctrl+C)";
            toolTipItem2.Text = "Copy the selection and put it on the Clipboard.";
            superToolTip2.Items.Add(toolTipTitleItem2);
            superToolTip2.Items.Add(toolTipItem2);
            this.copyItem1.SuperTip = superToolTip2;
            // 
            // pasteItem1
            // 
            this.pasteItem1.Caption = "Paste";
            this.pasteItem1.Enabled = false;
            this.pasteItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("pasteItem1.Glyph")));
            this.pasteItem1.Id = 4;
            this.pasteItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("pasteItem1.LargeGlyph")));
            this.pasteItem1.Name = "pasteItem1";
            toolTipTitleItem3.Text = "Paste (Ctrl+V)";
            toolTipItem3.Text = "Paste the contents of the Clipboard.";
            superToolTip3.Items.Add(toolTipTitleItem3);
            superToolTip3.Items.Add(toolTipItem3);
            this.pasteItem1.SuperTip = superToolTip3;
            // 
            // pasteSpecialItem1
            // 
            this.pasteSpecialItem1.Caption = "Paste Special";
            this.pasteSpecialItem1.Enabled = false;
            this.pasteSpecialItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("pasteSpecialItem1.Glyph")));
            this.pasteSpecialItem1.Id = 5;
            this.pasteSpecialItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("pasteSpecialItem1.LargeGlyph")));
            this.pasteSpecialItem1.Name = "pasteSpecialItem1";
            toolTipTitleItem4.Text = "Paste Special (Ctrl+Alt+V)";
            toolTipItem4.Text = "Paste Special";
            superToolTip4.Items.Add(toolTipTitleItem4);
            superToolTip4.Items.Add(toolTipItem4);
            this.pasteSpecialItem1.SuperTip = superToolTip4;
            // 
            // changeFontNameItem1
            // 
            this.changeFontNameItem1.Caption = "Font";
            this.changeFontNameItem1.Edit = this.repositoryItemFontEdit1;
            this.changeFontNameItem1.Enabled = false;
            this.changeFontNameItem1.Id = 6;
            this.changeFontNameItem1.Name = "changeFontNameItem1";
            toolTipTitleItem5.Text = "Font";
            toolTipItem5.Text = "Change the font face.";
            superToolTip5.Items.Add(toolTipTitleItem5);
            superToolTip5.Items.Add(toolTipItem5);
            this.changeFontNameItem1.SuperTip = superToolTip5;
            // 
            // repositoryItemFontEdit1
            // 
            this.repositoryItemFontEdit1.AutoHeight = false;
            this.repositoryItemFontEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemFontEdit1.Name = "repositoryItemFontEdit1";
            // 
            // changeFontSizeItem1
            // 
            this.changeFontSizeItem1.Caption = "Font Size";
            this.changeFontSizeItem1.Edit = this.repositoryItemRichEditFontSizeEdit1;
            this.changeFontSizeItem1.Enabled = false;
            this.changeFontSizeItem1.Id = 7;
            this.changeFontSizeItem1.Name = "changeFontSizeItem1";
            toolTipTitleItem6.Text = "Font Size";
            toolTipItem6.Text = "Change the font size.";
            superToolTip6.Items.Add(toolTipTitleItem6);
            superToolTip6.Items.Add(toolTipItem6);
            this.changeFontSizeItem1.SuperTip = superToolTip6;
            // 
            // repositoryItemRichEditFontSizeEdit1
            // 
            this.repositoryItemRichEditFontSizeEdit1.AutoHeight = false;
            this.repositoryItemRichEditFontSizeEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemRichEditFontSizeEdit1.Control = null;
            this.repositoryItemRichEditFontSizeEdit1.Name = "repositoryItemRichEditFontSizeEdit1";
            // 
            // changeFontColorItem1
            // 
            this.changeFontColorItem1.Caption = "Font Color";
            this.changeFontColorItem1.Enabled = false;
            this.changeFontColorItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("changeFontColorItem1.Glyph")));
            this.changeFontColorItem1.Id = 8;
            this.changeFontColorItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("changeFontColorItem1.LargeGlyph")));
            this.changeFontColorItem1.Name = "changeFontColorItem1";
            toolTipTitleItem7.Text = "Font Color";
            toolTipItem7.Text = "Change the font color.";
            superToolTip7.Items.Add(toolTipTitleItem7);
            superToolTip7.Items.Add(toolTipItem7);
            this.changeFontColorItem1.SuperTip = superToolTip7;
            // 
            // changeFontBackColorItem1
            // 
            this.changeFontBackColorItem1.Caption = "Text Highlight Color";
            this.changeFontBackColorItem1.Enabled = false;
            this.changeFontBackColorItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("changeFontBackColorItem1.Glyph")));
            this.changeFontBackColorItem1.Id = 9;
            this.changeFontBackColorItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("changeFontBackColorItem1.LargeGlyph")));
            this.changeFontBackColorItem1.Name = "changeFontBackColorItem1";
            toolTipTitleItem8.Text = "Text Highlight Color";
            toolTipItem8.Text = "Make text look like it was marked with a highlighter pen.";
            superToolTip8.Items.Add(toolTipTitleItem8);
            superToolTip8.Items.Add(toolTipItem8);
            this.changeFontBackColorItem1.SuperTip = superToolTip8;
            // 
            // toggleFontBoldItem1
            // 
            this.toggleFontBoldItem1.Caption = "Bold";
            this.toggleFontBoldItem1.Enabled = false;
            this.toggleFontBoldItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("toggleFontBoldItem1.Glyph")));
            this.toggleFontBoldItem1.Id = 10;
            this.toggleFontBoldItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("toggleFontBoldItem1.LargeGlyph")));
            this.toggleFontBoldItem1.Name = "toggleFontBoldItem1";
            toolTipTitleItem9.Text = "Bold (Ctrl+B)";
            toolTipItem9.Text = "Make the selected text bold.";
            superToolTip9.Items.Add(toolTipTitleItem9);
            superToolTip9.Items.Add(toolTipItem9);
            this.toggleFontBoldItem1.SuperTip = superToolTip9;
            // 
            // toggleFontItalicItem1
            // 
            this.toggleFontItalicItem1.Caption = "Italic";
            this.toggleFontItalicItem1.Enabled = false;
            this.toggleFontItalicItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("toggleFontItalicItem1.Glyph")));
            this.toggleFontItalicItem1.Id = 11;
            this.toggleFontItalicItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("toggleFontItalicItem1.LargeGlyph")));
            this.toggleFontItalicItem1.Name = "toggleFontItalicItem1";
            toolTipTitleItem10.Text = "Italic (Ctrl+I)";
            toolTipItem10.Text = "Italicize the selected text.";
            superToolTip10.Items.Add(toolTipTitleItem10);
            superToolTip10.Items.Add(toolTipItem10);
            this.toggleFontItalicItem1.SuperTip = superToolTip10;
            // 
            // toggleFontUnderlineItem1
            // 
            this.toggleFontUnderlineItem1.Caption = "Underline";
            this.toggleFontUnderlineItem1.Enabled = false;
            this.toggleFontUnderlineItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("toggleFontUnderlineItem1.Glyph")));
            this.toggleFontUnderlineItem1.Id = 12;
            this.toggleFontUnderlineItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("toggleFontUnderlineItem1.LargeGlyph")));
            this.toggleFontUnderlineItem1.Name = "toggleFontUnderlineItem1";
            toolTipTitleItem11.Text = "Underline (Ctrl+U)";
            toolTipItem11.Text = "Underline the selected text.";
            superToolTip11.Items.Add(toolTipTitleItem11);
            superToolTip11.Items.Add(toolTipItem11);
            this.toggleFontUnderlineItem1.SuperTip = superToolTip11;
            // 
            // toggleFontDoubleUnderlineItem1
            // 
            this.toggleFontDoubleUnderlineItem1.Caption = "Double Underline";
            this.toggleFontDoubleUnderlineItem1.Enabled = false;
            this.toggleFontDoubleUnderlineItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("toggleFontDoubleUnderlineItem1.Glyph")));
            this.toggleFontDoubleUnderlineItem1.Id = 13;
            this.toggleFontDoubleUnderlineItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("toggleFontDoubleUnderlineItem1.LargeGlyph")));
            this.toggleFontDoubleUnderlineItem1.Name = "toggleFontDoubleUnderlineItem1";
            toolTipTitleItem12.Text = "Double Underline (Ctrl+Shift+D)";
            toolTipItem12.Text = "Double underline";
            superToolTip12.Items.Add(toolTipTitleItem12);
            superToolTip12.Items.Add(toolTipItem12);
            this.toggleFontDoubleUnderlineItem1.SuperTip = superToolTip12;
            // 
            // toggleFontStrikeoutItem1
            // 
            this.toggleFontStrikeoutItem1.Caption = "Strikethrough";
            this.toggleFontStrikeoutItem1.Enabled = false;
            this.toggleFontStrikeoutItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("toggleFontStrikeoutItem1.Glyph")));
            this.toggleFontStrikeoutItem1.Id = 14;
            this.toggleFontStrikeoutItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("toggleFontStrikeoutItem1.LargeGlyph")));
            this.toggleFontStrikeoutItem1.Name = "toggleFontStrikeoutItem1";
            toolTipTitleItem13.Text = "Strikethrough";
            toolTipItem13.Text = "Draw a line through the middle of the selected text.";
            superToolTip13.Items.Add(toolTipTitleItem13);
            superToolTip13.Items.Add(toolTipItem13);
            this.toggleFontStrikeoutItem1.SuperTip = superToolTip13;
            // 
            // toggleFontDoubleStrikeoutItem1
            // 
            this.toggleFontDoubleStrikeoutItem1.Caption = "Double Strikethrough";
            this.toggleFontDoubleStrikeoutItem1.Enabled = false;
            this.toggleFontDoubleStrikeoutItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("toggleFontDoubleStrikeoutItem1.Glyph")));
            this.toggleFontDoubleStrikeoutItem1.Id = 15;
            this.toggleFontDoubleStrikeoutItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("toggleFontDoubleStrikeoutItem1.LargeGlyph")));
            this.toggleFontDoubleStrikeoutItem1.Name = "toggleFontDoubleStrikeoutItem1";
            toolTipTitleItem14.Text = "Double Strikethrough";
            toolTipItem14.Text = "Double strikethrough";
            superToolTip14.Items.Add(toolTipTitleItem14);
            superToolTip14.Items.Add(toolTipItem14);
            this.toggleFontDoubleStrikeoutItem1.SuperTip = superToolTip14;
            // 
            // toggleFontSubscriptItem1
            // 
            this.toggleFontSubscriptItem1.Caption = "Subscript";
            this.toggleFontSubscriptItem1.Enabled = false;
            this.toggleFontSubscriptItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("toggleFontSubscriptItem1.Glyph")));
            this.toggleFontSubscriptItem1.Id = 17;
            this.toggleFontSubscriptItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("toggleFontSubscriptItem1.LargeGlyph")));
            this.toggleFontSubscriptItem1.Name = "toggleFontSubscriptItem1";
            toolTipTitleItem15.Text = "Subscript (Ctrl++)";
            toolTipItem15.Text = "Create small letters below the text baseline.";
            superToolTip15.Items.Add(toolTipTitleItem15);
            superToolTip15.Items.Add(toolTipItem15);
            this.toggleFontSubscriptItem1.SuperTip = superToolTip15;
            // 
            // changeTextCaseItem1
            // 
            this.changeTextCaseItem1.Caption = "Change Case";
            this.changeTextCaseItem1.Enabled = false;
            this.changeTextCaseItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("changeTextCaseItem1.Glyph")));
            this.changeTextCaseItem1.Id = 18;
            this.changeTextCaseItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("changeTextCaseItem1.LargeGlyph")));
            this.changeTextCaseItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.makeTextUpperCaseItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.makeTextLowerCaseItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.toggleTextCaseItem1)});
            this.changeTextCaseItem1.Name = "changeTextCaseItem1";
            toolTipTitleItem19.Text = "Change Case";
            toolTipItem19.Text = "Change all the selected text to UPPERCASE, lowercase, or other common capitalizat" +
                "ions.";
            superToolTip19.Items.Add(toolTipTitleItem19);
            superToolTip19.Items.Add(toolTipItem19);
            this.changeTextCaseItem1.SuperTip = superToolTip19;
            // 
            // makeTextUpperCaseItem1
            // 
            this.makeTextUpperCaseItem1.Caption = "UPPERCASE";
            this.makeTextUpperCaseItem1.Enabled = false;
            this.makeTextUpperCaseItem1.Id = 19;
            this.makeTextUpperCaseItem1.Name = "makeTextUpperCaseItem1";
            toolTipTitleItem16.Text = "UPPERCASE";
            toolTipItem16.Text = "Change all the selected text to UPPERCASE.";
            superToolTip16.Items.Add(toolTipTitleItem16);
            superToolTip16.Items.Add(toolTipItem16);
            this.makeTextUpperCaseItem1.SuperTip = superToolTip16;
            // 
            // makeTextLowerCaseItem1
            // 
            this.makeTextLowerCaseItem1.Caption = "lowercase";
            this.makeTextLowerCaseItem1.Enabled = false;
            this.makeTextLowerCaseItem1.Id = 20;
            this.makeTextLowerCaseItem1.Name = "makeTextLowerCaseItem1";
            toolTipTitleItem17.Text = "lowercase";
            toolTipItem17.Text = "Change all the selected text to lowercase.";
            superToolTip17.Items.Add(toolTipTitleItem17);
            superToolTip17.Items.Add(toolTipItem17);
            this.makeTextLowerCaseItem1.SuperTip = superToolTip17;
            // 
            // toggleTextCaseItem1
            // 
            this.toggleTextCaseItem1.Caption = "tOGGLE cASE";
            this.toggleTextCaseItem1.Enabled = false;
            this.toggleTextCaseItem1.Id = 21;
            this.toggleTextCaseItem1.Name = "toggleTextCaseItem1";
            toolTipTitleItem18.Text = "tOGGLE cASE";
            toolTipItem18.Text = "tOGGLE cASE.";
            superToolTip18.Items.Add(toolTipTitleItem18);
            superToolTip18.Items.Add(toolTipItem18);
            this.toggleTextCaseItem1.SuperTip = superToolTip18;
            // 
            // fontSizeIncreaseItem1
            // 
            this.fontSizeIncreaseItem1.Caption = "Grow Font";
            this.fontSizeIncreaseItem1.Enabled = false;
            this.fontSizeIncreaseItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("fontSizeIncreaseItem1.Glyph")));
            this.fontSizeIncreaseItem1.Id = 22;
            this.fontSizeIncreaseItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("fontSizeIncreaseItem1.LargeGlyph")));
            this.fontSizeIncreaseItem1.Name = "fontSizeIncreaseItem1";
            toolTipTitleItem20.Text = "Grow Font (Ctrl+Shift+.)";
            toolTipItem20.Text = "Increase the font size.";
            superToolTip20.Items.Add(toolTipTitleItem20);
            superToolTip20.Items.Add(toolTipItem20);
            this.fontSizeIncreaseItem1.SuperTip = superToolTip20;
            // 
            // fontSizeDecreaseItem1
            // 
            this.fontSizeDecreaseItem1.Caption = "Shrink Font";
            this.fontSizeDecreaseItem1.Enabled = false;
            this.fontSizeDecreaseItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("fontSizeDecreaseItem1.Glyph")));
            this.fontSizeDecreaseItem1.Id = 23;
            this.fontSizeDecreaseItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("fontSizeDecreaseItem1.LargeGlyph")));
            this.fontSizeDecreaseItem1.Name = "fontSizeDecreaseItem1";
            toolTipTitleItem21.Text = "Shrink Font (Ctrl+Shift+,)";
            toolTipItem21.Text = "Decrease the font size.";
            superToolTip21.Items.Add(toolTipTitleItem21);
            superToolTip21.Items.Add(toolTipItem21);
            this.fontSizeDecreaseItem1.SuperTip = superToolTip21;
            // 
            // clearFormattingItem1
            // 
            this.clearFormattingItem1.Caption = "Clear Formatting";
            this.clearFormattingItem1.Enabled = false;
            this.clearFormattingItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("clearFormattingItem1.Glyph")));
            this.clearFormattingItem1.Id = 24;
            this.clearFormattingItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("clearFormattingItem1.LargeGlyph")));
            this.clearFormattingItem1.Name = "clearFormattingItem1";
            toolTipTitleItem22.Text = "Clear Formatting (Ctrl+Space)";
            toolTipItem22.Text = "Clear all the formatting from the selection, leaving only plain text.";
            superToolTip22.Items.Add(toolTipTitleItem22);
            superToolTip22.Items.Add(toolTipItem22);
            this.clearFormattingItem1.SuperTip = superToolTip22;
            // 
            // showFontFormItem1
            // 
            this.showFontFormItem1.Caption = "Font";
            this.showFontFormItem1.Enabled = false;
            this.showFontFormItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("showFontFormItem1.Glyph")));
            this.showFontFormItem1.Id = 25;
            this.showFontFormItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("showFontFormItem1.LargeGlyph")));
            this.showFontFormItem1.Name = "showFontFormItem1";
            toolTipTitleItem23.Text = "Font (Ctrl+D)";
            toolTipItem23.Text = "Show the Font dialog box.";
            superToolTip23.Items.Add(toolTipTitleItem23);
            superToolTip23.Items.Add(toolTipItem23);
            this.showFontFormItem1.SuperTip = superToolTip23;
            // 
            // toggleParagraphAlignmentLeftItem1
            // 
            this.toggleParagraphAlignmentLeftItem1.Caption = "Align Text Left";
            this.toggleParagraphAlignmentLeftItem1.Enabled = false;
            this.toggleParagraphAlignmentLeftItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("toggleParagraphAlignmentLeftItem1.Glyph")));
            this.toggleParagraphAlignmentLeftItem1.Id = 26;
            this.toggleParagraphAlignmentLeftItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("toggleParagraphAlignmentLeftItem1.LargeGlyph")));
            this.toggleParagraphAlignmentLeftItem1.Name = "toggleParagraphAlignmentLeftItem1";
            toolTipTitleItem24.Text = "Align Text Left (Ctrl+L)";
            toolTipItem24.Text = "Align text to the left.";
            superToolTip24.Items.Add(toolTipTitleItem24);
            superToolTip24.Items.Add(toolTipItem24);
            this.toggleParagraphAlignmentLeftItem1.SuperTip = superToolTip24;
            // 
            // toggleParagraphAlignmentCenterItem1
            // 
            this.toggleParagraphAlignmentCenterItem1.Caption = "Center";
            this.toggleParagraphAlignmentCenterItem1.Enabled = false;
            this.toggleParagraphAlignmentCenterItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("toggleParagraphAlignmentCenterItem1.Glyph")));
            this.toggleParagraphAlignmentCenterItem1.Id = 27;
            this.toggleParagraphAlignmentCenterItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("toggleParagraphAlignmentCenterItem1.LargeGlyph")));
            this.toggleParagraphAlignmentCenterItem1.Name = "toggleParagraphAlignmentCenterItem1";
            toolTipTitleItem25.Text = "Center (Ctrl+E)";
            toolTipItem25.Text = "Center text.";
            superToolTip25.Items.Add(toolTipTitleItem25);
            superToolTip25.Items.Add(toolTipItem25);
            this.toggleParagraphAlignmentCenterItem1.SuperTip = superToolTip25;
            // 
            // toggleParagraphAlignmentRightItem1
            // 
            this.toggleParagraphAlignmentRightItem1.Caption = "Align Text Right";
            this.toggleParagraphAlignmentRightItem1.Enabled = false;
            this.toggleParagraphAlignmentRightItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("toggleParagraphAlignmentRightItem1.Glyph")));
            this.toggleParagraphAlignmentRightItem1.Id = 28;
            this.toggleParagraphAlignmentRightItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("toggleParagraphAlignmentRightItem1.LargeGlyph")));
            this.toggleParagraphAlignmentRightItem1.Name = "toggleParagraphAlignmentRightItem1";
            toolTipTitleItem26.Text = "Align Text Right (Ctrl+R)";
            toolTipItem26.Text = "Align text to the right.";
            superToolTip26.Items.Add(toolTipTitleItem26);
            superToolTip26.Items.Add(toolTipItem26);
            this.toggleParagraphAlignmentRightItem1.SuperTip = superToolTip26;
            // 
            // toggleParagraphAlignmentJustifyItem1
            // 
            this.toggleParagraphAlignmentJustifyItem1.Caption = "Justify";
            this.toggleParagraphAlignmentJustifyItem1.Enabled = false;
            this.toggleParagraphAlignmentJustifyItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("toggleParagraphAlignmentJustifyItem1.Glyph")));
            this.toggleParagraphAlignmentJustifyItem1.Id = 29;
            this.toggleParagraphAlignmentJustifyItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("toggleParagraphAlignmentJustifyItem1.LargeGlyph")));
            this.toggleParagraphAlignmentJustifyItem1.Name = "toggleParagraphAlignmentJustifyItem1";
            toolTipTitleItem27.Text = "Justify (Ctrl+J)";
            toolTipItem27.Text = "Align text to both left and right margins, adding extra space between words as ne" +
                "cessary.\r\n\r\nThis creates a clean look along the left and right side of the page." +
                "";
            superToolTip27.Items.Add(toolTipTitleItem27);
            superToolTip27.Items.Add(toolTipItem27);
            this.toggleParagraphAlignmentJustifyItem1.SuperTip = superToolTip27;
            // 
            // changeParagraphLineSpacingItem1
            // 
            this.changeParagraphLineSpacingItem1.Caption = "Line Spacing";
            this.changeParagraphLineSpacingItem1.Enabled = false;
            this.changeParagraphLineSpacingItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("changeParagraphLineSpacingItem1.Glyph")));
            this.changeParagraphLineSpacingItem1.Id = 30;
            this.changeParagraphLineSpacingItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("changeParagraphLineSpacingItem1.LargeGlyph")));
            this.changeParagraphLineSpacingItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.setSingleParagraphSpacingItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.setSesquialteralParagraphSpacingItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.setDoubleParagraphSpacingItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.showLineSpacingFormItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.addSpacingBeforeParagraphItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.removeSpacingBeforeParagraphItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.addSpacingAfterParagraphItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.removeSpacingAfterParagraphItem1)});
            this.changeParagraphLineSpacingItem1.Name = "changeParagraphLineSpacingItem1";
            toolTipTitleItem36.Text = "Line Spacing";
            toolTipItem36.Text = "Change the spacing between lines of text.\r\n\r\nYou can also customize the amount of" +
                " space added before and after paragraphs.";
            superToolTip36.Items.Add(toolTipTitleItem36);
            superToolTip36.Items.Add(toolTipItem36);
            this.changeParagraphLineSpacingItem1.SuperTip = superToolTip36;
            // 
            // setSingleParagraphSpacingItem1
            // 
            this.setSingleParagraphSpacingItem1.Caption = "1.0";
            this.setSingleParagraphSpacingItem1.Enabled = false;
            this.setSingleParagraphSpacingItem1.Id = 31;
            this.setSingleParagraphSpacingItem1.Name = "setSingleParagraphSpacingItem1";
            toolTipTitleItem28.Text = "1.0 (Ctrl+1)";
            toolTipItem28.Text = " ";
            superToolTip28.Items.Add(toolTipTitleItem28);
            superToolTip28.Items.Add(toolTipItem28);
            this.setSingleParagraphSpacingItem1.SuperTip = superToolTip28;
            // 
            // setSesquialteralParagraphSpacingItem1
            // 
            this.setSesquialteralParagraphSpacingItem1.Caption = "1.5";
            this.setSesquialteralParagraphSpacingItem1.Enabled = false;
            this.setSesquialteralParagraphSpacingItem1.Id = 32;
            this.setSesquialteralParagraphSpacingItem1.Name = "setSesquialteralParagraphSpacingItem1";
            toolTipTitleItem29.Text = "1.5 (Ctrl+5)";
            toolTipItem29.Text = " ";
            superToolTip29.Items.Add(toolTipTitleItem29);
            superToolTip29.Items.Add(toolTipItem29);
            this.setSesquialteralParagraphSpacingItem1.SuperTip = superToolTip29;
            // 
            // setDoubleParagraphSpacingItem1
            // 
            this.setDoubleParagraphSpacingItem1.Caption = "2.0";
            this.setDoubleParagraphSpacingItem1.Enabled = false;
            this.setDoubleParagraphSpacingItem1.Id = 33;
            this.setDoubleParagraphSpacingItem1.Name = "setDoubleParagraphSpacingItem1";
            toolTipTitleItem30.Text = "2.0 (Ctrl+2)";
            toolTipItem30.Text = " ";
            superToolTip30.Items.Add(toolTipTitleItem30);
            superToolTip30.Items.Add(toolTipItem30);
            this.setDoubleParagraphSpacingItem1.SuperTip = superToolTip30;
            // 
            // showLineSpacingFormItem1
            // 
            this.showLineSpacingFormItem1.Caption = "Line Spacing Options...";
            this.showLineSpacingFormItem1.Enabled = false;
            this.showLineSpacingFormItem1.Id = 34;
            this.showLineSpacingFormItem1.Name = "showLineSpacingFormItem1";
            toolTipTitleItem31.Text = "Line Spacing Options...";
            toolTipItem31.Text = " ";
            superToolTip31.Items.Add(toolTipTitleItem31);
            superToolTip31.Items.Add(toolTipItem31);
            this.showLineSpacingFormItem1.SuperTip = superToolTip31;
            // 
            // addSpacingBeforeParagraphItem1
            // 
            this.addSpacingBeforeParagraphItem1.Caption = "Add Space &Before Paragraph";
            this.addSpacingBeforeParagraphItem1.Enabled = false;
            this.addSpacingBeforeParagraphItem1.Id = 35;
            this.addSpacingBeforeParagraphItem1.Name = "addSpacingBeforeParagraphItem1";
            toolTipTitleItem32.Text = "Add Space &Before Paragraph";
            toolTipItem32.Text = " ";
            superToolTip32.Items.Add(toolTipTitleItem32);
            superToolTip32.Items.Add(toolTipItem32);
            this.addSpacingBeforeParagraphItem1.SuperTip = superToolTip32;
            // 
            // removeSpacingBeforeParagraphItem1
            // 
            this.removeSpacingBeforeParagraphItem1.Caption = "Remove Space &Before Paragraph";
            this.removeSpacingBeforeParagraphItem1.Enabled = false;
            this.removeSpacingBeforeParagraphItem1.Id = 36;
            this.removeSpacingBeforeParagraphItem1.Name = "removeSpacingBeforeParagraphItem1";
            toolTipTitleItem33.Text = "Remove Space &Before Paragraph";
            toolTipItem33.Text = " ";
            superToolTip33.Items.Add(toolTipTitleItem33);
            superToolTip33.Items.Add(toolTipItem33);
            this.removeSpacingBeforeParagraphItem1.SuperTip = superToolTip33;
            // 
            // addSpacingAfterParagraphItem1
            // 
            this.addSpacingAfterParagraphItem1.Caption = "Add Space &After Paragraph";
            this.addSpacingAfterParagraphItem1.Enabled = false;
            this.addSpacingAfterParagraphItem1.Id = 37;
            this.addSpacingAfterParagraphItem1.Name = "addSpacingAfterParagraphItem1";
            toolTipTitleItem34.Text = "Add Space &After Paragraph";
            toolTipItem34.Text = " ";
            superToolTip34.Items.Add(toolTipTitleItem34);
            superToolTip34.Items.Add(toolTipItem34);
            this.addSpacingAfterParagraphItem1.SuperTip = superToolTip34;
            // 
            // removeSpacingAfterParagraphItem1
            // 
            this.removeSpacingAfterParagraphItem1.Caption = "Remove Space &After Paragraph";
            this.removeSpacingAfterParagraphItem1.Enabled = false;
            this.removeSpacingAfterParagraphItem1.Id = 38;
            this.removeSpacingAfterParagraphItem1.Name = "removeSpacingAfterParagraphItem1";
            toolTipTitleItem35.Text = "Remove Space &After Paragraph";
            toolTipItem35.Text = " ";
            superToolTip35.Items.Add(toolTipTitleItem35);
            superToolTip35.Items.Add(toolTipItem35);
            this.removeSpacingAfterParagraphItem1.SuperTip = superToolTip35;
            // 
            // toggleNumberingListItem1
            // 
            this.toggleNumberingListItem1.Caption = "Numbering";
            this.toggleNumberingListItem1.Enabled = false;
            this.toggleNumberingListItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("toggleNumberingListItem1.Glyph")));
            this.toggleNumberingListItem1.Id = 39;
            this.toggleNumberingListItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("toggleNumberingListItem1.LargeGlyph")));
            this.toggleNumberingListItem1.Name = "toggleNumberingListItem1";
            toolTipTitleItem37.Text = "Numbering";
            toolTipItem37.Text = "Start a numbered list.";
            superToolTip37.Items.Add(toolTipTitleItem37);
            superToolTip37.Items.Add(toolTipItem37);
            this.toggleNumberingListItem1.SuperTip = superToolTip37;
            // 
            // toggleMultiLevelListItem1
            // 
            this.toggleMultiLevelListItem1.Caption = "Multilevel list";
            this.toggleMultiLevelListItem1.Enabled = false;
            this.toggleMultiLevelListItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("toggleMultiLevelListItem1.Glyph")));
            this.toggleMultiLevelListItem1.Id = 40;
            this.toggleMultiLevelListItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("toggleMultiLevelListItem1.LargeGlyph")));
            this.toggleMultiLevelListItem1.Name = "toggleMultiLevelListItem1";
            toolTipTitleItem38.Text = "Multilevel list";
            toolTipItem38.Text = "Start a multilevel list.";
            superToolTip38.Items.Add(toolTipTitleItem38);
            superToolTip38.Items.Add(toolTipItem38);
            this.toggleMultiLevelListItem1.SuperTip = superToolTip38;
            // 
            // decreaseIndentItem1
            // 
            this.decreaseIndentItem1.Caption = "Decrease Indent";
            this.decreaseIndentItem1.Enabled = false;
            this.decreaseIndentItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("decreaseIndentItem1.Glyph")));
            this.decreaseIndentItem1.Id = 41;
            this.decreaseIndentItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("decreaseIndentItem1.LargeGlyph")));
            this.decreaseIndentItem1.Name = "decreaseIndentItem1";
            toolTipTitleItem39.Text = "Decrease Indent";
            toolTipItem39.Text = "Decrease the indent level of the paragraph.";
            superToolTip39.Items.Add(toolTipTitleItem39);
            superToolTip39.Items.Add(toolTipItem39);
            this.decreaseIndentItem1.SuperTip = superToolTip39;
            // 
            // increaseIndentItem1
            // 
            this.increaseIndentItem1.Caption = "Increase Indent";
            this.increaseIndentItem1.Enabled = false;
            this.increaseIndentItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("increaseIndentItem1.Glyph")));
            this.increaseIndentItem1.Id = 42;
            this.increaseIndentItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("increaseIndentItem1.LargeGlyph")));
            this.increaseIndentItem1.Name = "increaseIndentItem1";
            toolTipTitleItem40.Text = "Increase Indent";
            toolTipItem40.Text = "Increase the indent level of the paragraph.";
            superToolTip40.Items.Add(toolTipTitleItem40);
            superToolTip40.Items.Add(toolTipItem40);
            this.increaseIndentItem1.SuperTip = superToolTip40;
            // 
            // toggleShowWhitespaceItem1
            // 
            this.toggleShowWhitespaceItem1.Caption = "Show/Hide ¶";
            this.toggleShowWhitespaceItem1.Enabled = false;
            this.toggleShowWhitespaceItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("toggleShowWhitespaceItem1.Glyph")));
            this.toggleShowWhitespaceItem1.Id = 43;
            this.toggleShowWhitespaceItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("toggleShowWhitespaceItem1.LargeGlyph")));
            this.toggleShowWhitespaceItem1.Name = "toggleShowWhitespaceItem1";
            toolTipTitleItem41.Text = "Show/Hide ¶ (Ctrl+Shift+8)";
            toolTipItem41.Text = "Show paragraph marks and other hidden formatting symbols.";
            superToolTip41.Items.Add(toolTipTitleItem41);
            superToolTip41.Items.Add(toolTipItem41);
            this.toggleShowWhitespaceItem1.SuperTip = superToolTip41;
            // 
            // showParagraphFormItem1
            // 
            this.showParagraphFormItem1.Caption = "Paragraph";
            this.showParagraphFormItem1.Enabled = false;
            this.showParagraphFormItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("showParagraphFormItem1.Glyph")));
            this.showParagraphFormItem1.Id = 44;
            this.showParagraphFormItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("showParagraphFormItem1.LargeGlyph")));
            this.showParagraphFormItem1.Name = "showParagraphFormItem1";
            toolTipTitleItem42.Text = "Paragraph";
            toolTipItem42.Text = "Show the Paragraph dialog box.";
            superToolTip42.Items.Add(toolTipTitleItem42);
            superToolTip42.Items.Add(toolTipItem42);
            this.showParagraphFormItem1.SuperTip = superToolTip42;
            // 
            // findItem1
            // 
            this.findItem1.Caption = "Find";
            this.findItem1.Enabled = false;
            this.findItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("findItem1.Glyph")));
            this.findItem1.Id = 46;
            this.findItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("findItem1.LargeGlyph")));
            this.findItem1.Name = "findItem1";
            toolTipTitleItem43.Text = "Find (Ctrl+F)";
            toolTipItem43.Text = "Find text in the document.";
            superToolTip43.Items.Add(toolTipTitleItem43);
            superToolTip43.Items.Add(toolTipItem43);
            this.findItem1.SuperTip = superToolTip43;
            // 
            // replaceItem1
            // 
            this.replaceItem1.Caption = "Replace";
            this.replaceItem1.Enabled = false;
            this.replaceItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("replaceItem1.Glyph")));
            this.replaceItem1.Id = 47;
            this.replaceItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("replaceItem1.LargeGlyph")));
            this.replaceItem1.Name = "replaceItem1";
            toolTipTitleItem44.Text = "Replace (Ctrl+H)";
            toolTipItem44.Text = "Replace text in the document.";
            superToolTip44.Items.Add(toolTipTitleItem44);
            superToolTip44.Items.Add(toolTipItem44);
            this.replaceItem1.SuperTip = superToolTip44;
            // 
            // changeTableCellsShadingItem1
            // 
            this.changeTableCellsShadingItem1.Caption = "Shading";
            this.changeTableCellsShadingItem1.Enabled = false;
            this.changeTableCellsShadingItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("changeTableCellsShadingItem1.Glyph")));
            this.changeTableCellsShadingItem1.Id = 48;
            this.changeTableCellsShadingItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("changeTableCellsShadingItem1.LargeGlyph")));
            this.changeTableCellsShadingItem1.Name = "changeTableCellsShadingItem1";
            toolTipTitleItem45.Text = "Shading";
            toolTipItem45.Text = "Color the background behind the selected cells.";
            superToolTip45.Items.Add(toolTipTitleItem45);
            superToolTip45.Items.Add(toolTipItem45);
            this.changeTableCellsShadingItem1.SuperTip = superToolTip45;
            // 
            // changeTableBordersItem1
            // 
            this.changeTableBordersItem1.Caption = "Borders";
            this.changeTableBordersItem1.Enabled = false;
            this.changeTableBordersItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("changeTableBordersItem1.Glyph")));
            this.changeTableBordersItem1.Id = 49;
            this.changeTableBordersItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("changeTableBordersItem1.LargeGlyph")));
            this.changeTableBordersItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.toggleTableCellsBottomBorderItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.toggleTableCellsTopBorderItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.toggleTableCellsLeftBorderItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.toggleTableCellsRightBorderItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.resetTableCellsAllBordersItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.toggleTableCellsAllBordersItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.toggleTableCellsOutsideBorderItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.toggleTableCellsInsideBorderItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.toggleTableCellsInsideHorizontalBorderItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.toggleTableCellsInsideVerticalBorderItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.toggleShowTableGridLinesItem1)});
            this.changeTableBordersItem1.Name = "changeTableBordersItem1";
            toolTipTitleItem57.Text = "Borders";
            toolTipItem57.Text = "Customize the borders of the selected cells.";
            superToolTip57.Items.Add(toolTipTitleItem57);
            superToolTip57.Items.Add(toolTipItem57);
            this.changeTableBordersItem1.SuperTip = superToolTip57;
            // 
            // toggleTableCellsBottomBorderItem1
            // 
            this.toggleTableCellsBottomBorderItem1.Caption = "Bottom Border";
            this.toggleTableCellsBottomBorderItem1.Enabled = false;
            this.toggleTableCellsBottomBorderItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("toggleTableCellsBottomBorderItem1.Glyph")));
            this.toggleTableCellsBottomBorderItem1.Id = 50;
            this.toggleTableCellsBottomBorderItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("toggleTableCellsBottomBorderItem1.LargeGlyph")));
            this.toggleTableCellsBottomBorderItem1.Name = "toggleTableCellsBottomBorderItem1";
            toolTipTitleItem46.Text = "Bottom Border";
            toolTipItem46.Text = "Customize the borders of the selected cells.";
            superToolTip46.Items.Add(toolTipTitleItem46);
            superToolTip46.Items.Add(toolTipItem46);
            this.toggleTableCellsBottomBorderItem1.SuperTip = superToolTip46;
            // 
            // toggleTableCellsTopBorderItem1
            // 
            this.toggleTableCellsTopBorderItem1.Caption = "Top Border";
            this.toggleTableCellsTopBorderItem1.Enabled = false;
            this.toggleTableCellsTopBorderItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("toggleTableCellsTopBorderItem1.Glyph")));
            this.toggleTableCellsTopBorderItem1.Id = 51;
            this.toggleTableCellsTopBorderItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("toggleTableCellsTopBorderItem1.LargeGlyph")));
            this.toggleTableCellsTopBorderItem1.Name = "toggleTableCellsTopBorderItem1";
            toolTipTitleItem47.Text = "Top Border";
            toolTipItem47.Text = "Customize the borders of the selected cells.";
            superToolTip47.Items.Add(toolTipTitleItem47);
            superToolTip47.Items.Add(toolTipItem47);
            this.toggleTableCellsTopBorderItem1.SuperTip = superToolTip47;
            // 
            // toggleTableCellsLeftBorderItem1
            // 
            this.toggleTableCellsLeftBorderItem1.Caption = "Left Border";
            this.toggleTableCellsLeftBorderItem1.Enabled = false;
            this.toggleTableCellsLeftBorderItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("toggleTableCellsLeftBorderItem1.Glyph")));
            this.toggleTableCellsLeftBorderItem1.Id = 52;
            this.toggleTableCellsLeftBorderItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("toggleTableCellsLeftBorderItem1.LargeGlyph")));
            this.toggleTableCellsLeftBorderItem1.Name = "toggleTableCellsLeftBorderItem1";
            toolTipTitleItem48.Text = "Left Border";
            toolTipItem48.Text = "Customize the borders of the selected cells.";
            superToolTip48.Items.Add(toolTipTitleItem48);
            superToolTip48.Items.Add(toolTipItem48);
            this.toggleTableCellsLeftBorderItem1.SuperTip = superToolTip48;
            // 
            // toggleTableCellsRightBorderItem1
            // 
            this.toggleTableCellsRightBorderItem1.Caption = "Right Border";
            this.toggleTableCellsRightBorderItem1.Enabled = false;
            this.toggleTableCellsRightBorderItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("toggleTableCellsRightBorderItem1.Glyph")));
            this.toggleTableCellsRightBorderItem1.Id = 53;
            this.toggleTableCellsRightBorderItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("toggleTableCellsRightBorderItem1.LargeGlyph")));
            this.toggleTableCellsRightBorderItem1.Name = "toggleTableCellsRightBorderItem1";
            toolTipTitleItem49.Text = "Right Border";
            toolTipItem49.Text = "Customize the borders of the selected cells.";
            superToolTip49.Items.Add(toolTipTitleItem49);
            superToolTip49.Items.Add(toolTipItem49);
            this.toggleTableCellsRightBorderItem1.SuperTip = superToolTip49;
            // 
            // resetTableCellsAllBordersItem1
            // 
            this.resetTableCellsAllBordersItem1.Caption = "No Border";
            this.resetTableCellsAllBordersItem1.Enabled = false;
            this.resetTableCellsAllBordersItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("resetTableCellsAllBordersItem1.Glyph")));
            this.resetTableCellsAllBordersItem1.Id = 54;
            this.resetTableCellsAllBordersItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("resetTableCellsAllBordersItem1.LargeGlyph")));
            this.resetTableCellsAllBordersItem1.Name = "resetTableCellsAllBordersItem1";
            toolTipTitleItem50.Text = "No Border";
            toolTipItem50.Text = "Customize the borders of the selected cells.";
            superToolTip50.Items.Add(toolTipTitleItem50);
            superToolTip50.Items.Add(toolTipItem50);
            this.resetTableCellsAllBordersItem1.SuperTip = superToolTip50;
            // 
            // toggleTableCellsAllBordersItem1
            // 
            this.toggleTableCellsAllBordersItem1.Caption = "All Borders";
            this.toggleTableCellsAllBordersItem1.Enabled = false;
            this.toggleTableCellsAllBordersItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("toggleTableCellsAllBordersItem1.Glyph")));
            this.toggleTableCellsAllBordersItem1.Id = 55;
            this.toggleTableCellsAllBordersItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("toggleTableCellsAllBordersItem1.LargeGlyph")));
            this.toggleTableCellsAllBordersItem1.Name = "toggleTableCellsAllBordersItem1";
            toolTipTitleItem51.Text = "All Borders";
            toolTipItem51.Text = "Customize the borders of the selected cells.";
            superToolTip51.Items.Add(toolTipTitleItem51);
            superToolTip51.Items.Add(toolTipItem51);
            this.toggleTableCellsAllBordersItem1.SuperTip = superToolTip51;
            // 
            // toggleTableCellsOutsideBorderItem1
            // 
            this.toggleTableCellsOutsideBorderItem1.Caption = "Outside Border";
            this.toggleTableCellsOutsideBorderItem1.Enabled = false;
            this.toggleTableCellsOutsideBorderItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("toggleTableCellsOutsideBorderItem1.Glyph")));
            this.toggleTableCellsOutsideBorderItem1.Id = 56;
            this.toggleTableCellsOutsideBorderItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("toggleTableCellsOutsideBorderItem1.LargeGlyph")));
            this.toggleTableCellsOutsideBorderItem1.Name = "toggleTableCellsOutsideBorderItem1";
            toolTipTitleItem52.Text = "Outside Border";
            toolTipItem52.Text = "Customize the borders of the selected cells.";
            superToolTip52.Items.Add(toolTipTitleItem52);
            superToolTip52.Items.Add(toolTipItem52);
            this.toggleTableCellsOutsideBorderItem1.SuperTip = superToolTip52;
            // 
            // toggleTableCellsInsideBorderItem1
            // 
            this.toggleTableCellsInsideBorderItem1.Caption = "Inside Border";
            this.toggleTableCellsInsideBorderItem1.Enabled = false;
            this.toggleTableCellsInsideBorderItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("toggleTableCellsInsideBorderItem1.Glyph")));
            this.toggleTableCellsInsideBorderItem1.Id = 57;
            this.toggleTableCellsInsideBorderItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("toggleTableCellsInsideBorderItem1.LargeGlyph")));
            this.toggleTableCellsInsideBorderItem1.Name = "toggleTableCellsInsideBorderItem1";
            toolTipTitleItem53.Text = "Inside Border";
            toolTipItem53.Text = "Customize the borders of the selected cells.";
            superToolTip53.Items.Add(toolTipTitleItem53);
            superToolTip53.Items.Add(toolTipItem53);
            this.toggleTableCellsInsideBorderItem1.SuperTip = superToolTip53;
            // 
            // toggleTableCellsInsideHorizontalBorderItem1
            // 
            this.toggleTableCellsInsideHorizontalBorderItem1.Caption = "Inside Horizontal Border";
            this.toggleTableCellsInsideHorizontalBorderItem1.Enabled = false;
            this.toggleTableCellsInsideHorizontalBorderItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("toggleTableCellsInsideHorizontalBorderItem1.Glyph")));
            this.toggleTableCellsInsideHorizontalBorderItem1.Id = 58;
            this.toggleTableCellsInsideHorizontalBorderItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("toggleTableCellsInsideHorizontalBorderItem1.LargeGlyph")));
            this.toggleTableCellsInsideHorizontalBorderItem1.Name = "toggleTableCellsInsideHorizontalBorderItem1";
            toolTipTitleItem54.Text = "Inside Horizontal Border";
            toolTipItem54.Text = "Customize the borders of the selected cells.";
            superToolTip54.Items.Add(toolTipTitleItem54);
            superToolTip54.Items.Add(toolTipItem54);
            this.toggleTableCellsInsideHorizontalBorderItem1.SuperTip = superToolTip54;
            // 
            // toggleTableCellsInsideVerticalBorderItem1
            // 
            this.toggleTableCellsInsideVerticalBorderItem1.Caption = "Inside Vertical Border";
            this.toggleTableCellsInsideVerticalBorderItem1.Enabled = false;
            this.toggleTableCellsInsideVerticalBorderItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("toggleTableCellsInsideVerticalBorderItem1.Glyph")));
            this.toggleTableCellsInsideVerticalBorderItem1.Id = 59;
            this.toggleTableCellsInsideVerticalBorderItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("toggleTableCellsInsideVerticalBorderItem1.LargeGlyph")));
            this.toggleTableCellsInsideVerticalBorderItem1.Name = "toggleTableCellsInsideVerticalBorderItem1";
            toolTipTitleItem55.Text = "Inside Vertical Border";
            toolTipItem55.Text = "Customize the borders of the selected cells.";
            superToolTip55.Items.Add(toolTipTitleItem55);
            superToolTip55.Items.Add(toolTipItem55);
            this.toggleTableCellsInsideVerticalBorderItem1.SuperTip = superToolTip55;
            // 
            // toggleShowTableGridLinesItem1
            // 
            this.toggleShowTableGridLinesItem1.Caption = "View Gridlines";
            this.toggleShowTableGridLinesItem1.Enabled = false;
            this.toggleShowTableGridLinesItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("toggleShowTableGridLinesItem1.Glyph")));
            this.toggleShowTableGridLinesItem1.Id = 60;
            this.toggleShowTableGridLinesItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("toggleShowTableGridLinesItem1.LargeGlyph")));
            this.toggleShowTableGridLinesItem1.Name = "toggleShowTableGridLinesItem1";
            toolTipTitleItem56.Text = "View Gridlines";
            toolTipItem56.Text = "Show or hide the gridlines within the table.";
            superToolTip56.Items.Add(toolTipTitleItem56);
            superToolTip56.Items.Add(toolTipItem56);
            this.toggleShowTableGridLinesItem1.SuperTip = superToolTip56;
            // 
            // changeTableBorderLineStyleItem1
            // 
            this.changeTableBorderLineStyleItem1.Caption = "Line Style";
            this.changeTableBorderLineStyleItem1.Edit = this.repositoryItemBorderLineStyle1;
            this.changeTableBorderLineStyleItem1.Enabled = false;
            this.changeTableBorderLineStyleItem1.Id = 61;
            this.changeTableBorderLineStyleItem1.Name = "changeTableBorderLineStyleItem1";
            toolTipTitleItem58.Text = "Line Style";
            toolTipItem58.Text = "Change the style of the line used to draw borders.";
            superToolTip58.Items.Add(toolTipTitleItem58);
            superToolTip58.Items.Add(toolTipItem58);
            this.changeTableBorderLineStyleItem1.SuperTip = superToolTip58;
            // 
            // repositoryItemBorderLineStyle1
            // 
            this.repositoryItemBorderLineStyle1.AutoHeight = false;
            this.repositoryItemBorderLineStyle1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemBorderLineStyle1.Control = null;
            this.repositoryItemBorderLineStyle1.Name = "repositoryItemBorderLineStyle1";
            // 
            // changeTableBorderLineWeightItem1
            // 
            this.changeTableBorderLineWeightItem1.Caption = "Line Weight";
            this.changeTableBorderLineWeightItem1.Edit = this.repositoryItemBorderLineWeight1;
            this.changeTableBorderLineWeightItem1.Enabled = false;
            this.changeTableBorderLineWeightItem1.Id = 62;
            this.changeTableBorderLineWeightItem1.Name = "changeTableBorderLineWeightItem1";
            toolTipTitleItem59.Text = "Line Weight";
            toolTipItem59.Text = "Change the width of the line used to draw borders.";
            superToolTip59.Items.Add(toolTipTitleItem59);
            superToolTip59.Items.Add(toolTipItem59);
            this.changeTableBorderLineWeightItem1.SuperTip = superToolTip59;
            // 
            // repositoryItemBorderLineWeight1
            // 
            this.repositoryItemBorderLineWeight1.AutoHeight = false;
            this.repositoryItemBorderLineWeight1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemBorderLineWeight1.Control = null;
            this.repositoryItemBorderLineWeight1.Name = "repositoryItemBorderLineWeight1";
            // 
            // changeTableBorderColorItem1
            // 
            this.changeTableBorderColorItem1.Caption = "Pen Color";
            this.changeTableBorderColorItem1.Enabled = false;
            this.changeTableBorderColorItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("changeTableBorderColorItem1.Glyph")));
            this.changeTableBorderColorItem1.Id = 63;
            this.changeTableBorderColorItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("changeTableBorderColorItem1.LargeGlyph")));
            this.changeTableBorderColorItem1.Name = "changeTableBorderColorItem1";
            toolTipTitleItem60.Text = "Pen Color";
            toolTipItem60.Text = "Change the pen color.";
            superToolTip60.Items.Add(toolTipTitleItem60);
            superToolTip60.Items.Add(toolTipItem60);
            this.changeTableBorderColorItem1.SuperTip = superToolTip60;
            // 
            // selectTableElementsItem1
            // 
            this.selectTableElementsItem1.Caption = "Select";
            this.selectTableElementsItem1.Enabled = false;
            this.selectTableElementsItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("selectTableElementsItem1.Glyph")));
            this.selectTableElementsItem1.Id = 64;
            this.selectTableElementsItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("selectTableElementsItem1.LargeGlyph")));
            this.selectTableElementsItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.selectTableCellItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.selectTableColumnItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.selectTableRowItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.selectTableItem1)});
            this.selectTableElementsItem1.Name = "selectTableElementsItem1";
            toolTipTitleItem65.Text = "Select";
            toolTipItem65.Text = "Select the current cell, row, column, or entire table";
            superToolTip65.Items.Add(toolTipTitleItem65);
            superToolTip65.Items.Add(toolTipItem65);
            this.selectTableElementsItem1.SuperTip = superToolTip65;
            // 
            // selectTableCellItem1
            // 
            this.selectTableCellItem1.Caption = "Select Cell";
            this.selectTableCellItem1.Enabled = false;
            this.selectTableCellItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("selectTableCellItem1.Glyph")));
            this.selectTableCellItem1.Id = 65;
            this.selectTableCellItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("selectTableCellItem1.LargeGlyph")));
            this.selectTableCellItem1.Name = "selectTableCellItem1";
            toolTipTitleItem61.Text = "Select Cell";
            toolTipItem61.Text = "Select Cell";
            superToolTip61.Items.Add(toolTipTitleItem61);
            superToolTip61.Items.Add(toolTipItem61);
            this.selectTableCellItem1.SuperTip = superToolTip61;
            // 
            // selectTableColumnItem1
            // 
            this.selectTableColumnItem1.Caption = "Select Column";
            this.selectTableColumnItem1.Enabled = false;
            this.selectTableColumnItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("selectTableColumnItem1.Glyph")));
            this.selectTableColumnItem1.Id = 66;
            this.selectTableColumnItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("selectTableColumnItem1.LargeGlyph")));
            this.selectTableColumnItem1.Name = "selectTableColumnItem1";
            toolTipTitleItem62.Text = "Select Column";
            toolTipItem62.Text = "Select Column";
            superToolTip62.Items.Add(toolTipTitleItem62);
            superToolTip62.Items.Add(toolTipItem62);
            this.selectTableColumnItem1.SuperTip = superToolTip62;
            // 
            // selectTableRowItem1
            // 
            this.selectTableRowItem1.Caption = "Select Row";
            this.selectTableRowItem1.Enabled = false;
            this.selectTableRowItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("selectTableRowItem1.Glyph")));
            this.selectTableRowItem1.Id = 67;
            this.selectTableRowItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("selectTableRowItem1.LargeGlyph")));
            this.selectTableRowItem1.Name = "selectTableRowItem1";
            toolTipTitleItem63.Text = "Select Row";
            toolTipItem63.Text = "Select Row";
            superToolTip63.Items.Add(toolTipTitleItem63);
            superToolTip63.Items.Add(toolTipItem63);
            this.selectTableRowItem1.SuperTip = superToolTip63;
            // 
            // selectTableItem1
            // 
            this.selectTableItem1.Caption = "Select Table";
            this.selectTableItem1.Enabled = false;
            this.selectTableItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("selectTableItem1.Glyph")));
            this.selectTableItem1.Id = 68;
            this.selectTableItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("selectTableItem1.LargeGlyph")));
            this.selectTableItem1.Name = "selectTableItem1";
            toolTipTitleItem64.Text = "Select Table";
            toolTipItem64.Text = "Select Table";
            superToolTip64.Items.Add(toolTipTitleItem64);
            superToolTip64.Items.Add(toolTipItem64);
            this.selectTableItem1.SuperTip = superToolTip64;
            // 
            // showTablePropertiesFormItem1
            // 
            this.showTablePropertiesFormItem1.Caption = "Properties";
            this.showTablePropertiesFormItem1.Enabled = false;
            this.showTablePropertiesFormItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("showTablePropertiesFormItem1.Glyph")));
            this.showTablePropertiesFormItem1.Id = 69;
            this.showTablePropertiesFormItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("showTablePropertiesFormItem1.LargeGlyph")));
            this.showTablePropertiesFormItem1.Name = "showTablePropertiesFormItem1";
            toolTipTitleItem66.Text = "Properties";
            toolTipItem66.Text = "Show the Table Properties dialog box to change advanced table properties, such as" +
                " indentation and text wrapping options.";
            superToolTip66.Items.Add(toolTipTitleItem66);
            superToolTip66.Items.Add(toolTipItem66);
            this.showTablePropertiesFormItem1.SuperTip = superToolTip66;
            // 
            // deleteTableElementsItem1
            // 
            this.deleteTableElementsItem1.Caption = "Delete";
            this.deleteTableElementsItem1.Enabled = false;
            this.deleteTableElementsItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("deleteTableElementsItem1.Glyph")));
            this.deleteTableElementsItem1.Id = 70;
            this.deleteTableElementsItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("deleteTableElementsItem1.LargeGlyph")));
            this.deleteTableElementsItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.showDeleteTableCellsFormItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.deleteTableColumnsItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.deleteTableRowsItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.deleteTableItem1)});
            this.deleteTableElementsItem1.Name = "deleteTableElementsItem1";
            toolTipTitleItem71.Text = "Delete";
            toolTipItem71.Text = "Delete rows, columns, cells, or the entire Table";
            superToolTip71.Items.Add(toolTipTitleItem71);
            superToolTip71.Items.Add(toolTipItem71);
            this.deleteTableElementsItem1.SuperTip = superToolTip71;
            // 
            // showDeleteTableCellsFormItem1
            // 
            this.showDeleteTableCellsFormItem1.Caption = "Delete Cells";
            this.showDeleteTableCellsFormItem1.Enabled = false;
            this.showDeleteTableCellsFormItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("showDeleteTableCellsFormItem1.Glyph")));
            this.showDeleteTableCellsFormItem1.Id = 71;
            this.showDeleteTableCellsFormItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("showDeleteTableCellsFormItem1.LargeGlyph")));
            this.showDeleteTableCellsFormItem1.Name = "showDeleteTableCellsFormItem1";
            toolTipTitleItem67.Text = "Delete Cells";
            toolTipItem67.Text = "Delete rows, columns, or cells";
            superToolTip67.Items.Add(toolTipTitleItem67);
            superToolTip67.Items.Add(toolTipItem67);
            this.showDeleteTableCellsFormItem1.SuperTip = superToolTip67;
            // 
            // deleteTableColumnsItem1
            // 
            this.deleteTableColumnsItem1.Caption = "Delete Columns";
            this.deleteTableColumnsItem1.Enabled = false;
            this.deleteTableColumnsItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("deleteTableColumnsItem1.Glyph")));
            this.deleteTableColumnsItem1.Id = 72;
            this.deleteTableColumnsItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("deleteTableColumnsItem1.LargeGlyph")));
            this.deleteTableColumnsItem1.Name = "deleteTableColumnsItem1";
            toolTipTitleItem68.Text = "Delete Columns";
            toolTipItem68.Text = "Delete Columns";
            superToolTip68.Items.Add(toolTipTitleItem68);
            superToolTip68.Items.Add(toolTipItem68);
            this.deleteTableColumnsItem1.SuperTip = superToolTip68;
            // 
            // deleteTableRowsItem1
            // 
            this.deleteTableRowsItem1.Caption = "Delete Rows";
            this.deleteTableRowsItem1.Enabled = false;
            this.deleteTableRowsItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("deleteTableRowsItem1.Glyph")));
            this.deleteTableRowsItem1.Id = 73;
            this.deleteTableRowsItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("deleteTableRowsItem1.LargeGlyph")));
            this.deleteTableRowsItem1.Name = "deleteTableRowsItem1";
            toolTipTitleItem69.Text = "Delete Rows";
            toolTipItem69.Text = "Delete Rows";
            superToolTip69.Items.Add(toolTipTitleItem69);
            superToolTip69.Items.Add(toolTipItem69);
            this.deleteTableRowsItem1.SuperTip = superToolTip69;
            // 
            // deleteTableItem1
            // 
            this.deleteTableItem1.Caption = "Delete Table";
            this.deleteTableItem1.Enabled = false;
            this.deleteTableItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("deleteTableItem1.Glyph")));
            this.deleteTableItem1.Id = 74;
            this.deleteTableItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("deleteTableItem1.LargeGlyph")));
            this.deleteTableItem1.Name = "deleteTableItem1";
            toolTipTitleItem70.Text = "Delete Table";
            toolTipItem70.Text = "Delete Entire Table";
            superToolTip70.Items.Add(toolTipTitleItem70);
            superToolTip70.Items.Add(toolTipItem70);
            this.deleteTableItem1.SuperTip = superToolTip70;
            // 
            // insertTableRowAboveItem1
            // 
            this.insertTableRowAboveItem1.Caption = "Insert Rows Above";
            this.insertTableRowAboveItem1.Enabled = false;
            this.insertTableRowAboveItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("insertTableRowAboveItem1.Glyph")));
            this.insertTableRowAboveItem1.Id = 75;
            this.insertTableRowAboveItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("insertTableRowAboveItem1.LargeGlyph")));
            this.insertTableRowAboveItem1.Name = "insertTableRowAboveItem1";
            toolTipTitleItem72.Text = "Insert Rows Above";
            toolTipItem72.Text = "Add a new row directly above the selected row.";
            superToolTip72.Items.Add(toolTipTitleItem72);
            superToolTip72.Items.Add(toolTipItem72);
            this.insertTableRowAboveItem1.SuperTip = superToolTip72;
            // 
            // insertTableRowBelowItem1
            // 
            this.insertTableRowBelowItem1.Caption = "Insert Rows Below";
            this.insertTableRowBelowItem1.Enabled = false;
            this.insertTableRowBelowItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("insertTableRowBelowItem1.Glyph")));
            this.insertTableRowBelowItem1.Id = 76;
            this.insertTableRowBelowItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("insertTableRowBelowItem1.LargeGlyph")));
            this.insertTableRowBelowItem1.Name = "insertTableRowBelowItem1";
            toolTipTitleItem73.Text = "Insert Rows Below";
            toolTipItem73.Text = "Add a new row directly below the selected row.";
            superToolTip73.Items.Add(toolTipTitleItem73);
            superToolTip73.Items.Add(toolTipItem73);
            this.insertTableRowBelowItem1.SuperTip = superToolTip73;
            // 
            // insertTableColumnToLeftItem1
            // 
            this.insertTableColumnToLeftItem1.Caption = "Insert Columns to the Left";
            this.insertTableColumnToLeftItem1.Enabled = false;
            this.insertTableColumnToLeftItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("insertTableColumnToLeftItem1.Glyph")));
            this.insertTableColumnToLeftItem1.Id = 77;
            this.insertTableColumnToLeftItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("insertTableColumnToLeftItem1.LargeGlyph")));
            this.insertTableColumnToLeftItem1.Name = "insertTableColumnToLeftItem1";
            toolTipTitleItem74.Text = "Insert Columns to the Left";
            toolTipItem74.Text = "Add a new column directly to the left of the selected column";
            superToolTip74.Items.Add(toolTipTitleItem74);
            superToolTip74.Items.Add(toolTipItem74);
            this.insertTableColumnToLeftItem1.SuperTip = superToolTip74;
            // 
            // insertTableColumnToRightItem1
            // 
            this.insertTableColumnToRightItem1.Caption = "Insert Columns to the Right";
            this.insertTableColumnToRightItem1.Enabled = false;
            this.insertTableColumnToRightItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("insertTableColumnToRightItem1.Glyph")));
            this.insertTableColumnToRightItem1.Id = 78;
            this.insertTableColumnToRightItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("insertTableColumnToRightItem1.LargeGlyph")));
            this.insertTableColumnToRightItem1.Name = "insertTableColumnToRightItem1";
            toolTipTitleItem75.Text = "Insert Columns to the Right";
            toolTipItem75.Text = "Add a new column directly to the right of the selected column";
            superToolTip75.Items.Add(toolTipTitleItem75);
            superToolTip75.Items.Add(toolTipItem75);
            this.insertTableColumnToRightItem1.SuperTip = superToolTip75;
            // 
            // showInsertTableCellsFormItem1
            // 
            this.showInsertTableCellsFormItem1.Caption = "Insert Cells";
            this.showInsertTableCellsFormItem1.Enabled = false;
            this.showInsertTableCellsFormItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("showInsertTableCellsFormItem1.Glyph")));
            this.showInsertTableCellsFormItem1.Id = 79;
            this.showInsertTableCellsFormItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("showInsertTableCellsFormItem1.LargeGlyph")));
            this.showInsertTableCellsFormItem1.Name = "showInsertTableCellsFormItem1";
            toolTipTitleItem76.Text = "Insert Cells";
            toolTipItem76.Text = "Insert Cells";
            superToolTip76.Items.Add(toolTipTitleItem76);
            superToolTip76.Items.Add(toolTipItem76);
            this.showInsertTableCellsFormItem1.SuperTip = superToolTip76;
            // 
            // mergeTableCellsItem1
            // 
            this.mergeTableCellsItem1.Caption = "Merge Cells";
            this.mergeTableCellsItem1.Enabled = false;
            this.mergeTableCellsItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("mergeTableCellsItem1.Glyph")));
            this.mergeTableCellsItem1.Id = 80;
            this.mergeTableCellsItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("mergeTableCellsItem1.LargeGlyph")));
            this.mergeTableCellsItem1.Name = "mergeTableCellsItem1";
            toolTipTitleItem77.Text = "Merge Cells";
            toolTipItem77.Text = "Merge the selected cells into one cell.";
            superToolTip77.Items.Add(toolTipTitleItem77);
            superToolTip77.Items.Add(toolTipItem77);
            this.mergeTableCellsItem1.SuperTip = superToolTip77;
            // 
            // showSplitTableCellsForm1
            // 
            this.showSplitTableCellsForm1.Caption = "Split Cells";
            this.showSplitTableCellsForm1.Enabled = false;
            this.showSplitTableCellsForm1.Glyph = ((System.Drawing.Image)(resources.GetObject("showSplitTableCellsForm1.Glyph")));
            this.showSplitTableCellsForm1.Id = 81;
            this.showSplitTableCellsForm1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("showSplitTableCellsForm1.LargeGlyph")));
            this.showSplitTableCellsForm1.Name = "showSplitTableCellsForm1";
            toolTipTitleItem78.Text = "Split Cells";
            toolTipItem78.Text = "Split the selected cells into multiple new cells";
            superToolTip78.Items.Add(toolTipTitleItem78);
            superToolTip78.Items.Add(toolTipItem78);
            this.showSplitTableCellsForm1.SuperTip = superToolTip78;
            // 
            // splitTableItem1
            // 
            this.splitTableItem1.Caption = "Split Table";
            this.splitTableItem1.Enabled = false;
            this.splitTableItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("splitTableItem1.Glyph")));
            this.splitTableItem1.Id = 82;
            this.splitTableItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("splitTableItem1.LargeGlyph")));
            this.splitTableItem1.Name = "splitTableItem1";
            toolTipTitleItem79.Text = "Split Table";
            toolTipItem79.Text = "Split the table into two tables.\r\nThe selected row will become the first row of t" +
                "he new table.";
            superToolTip79.Items.Add(toolTipTitleItem79);
            superToolTip79.Items.Add(toolTipItem79);
            this.splitTableItem1.SuperTip = superToolTip79;
            // 
            // toggleTableAutoFitItem1
            // 
            this.toggleTableAutoFitItem1.Caption = "AutoFit";
            this.toggleTableAutoFitItem1.Enabled = false;
            this.toggleTableAutoFitItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("toggleTableAutoFitItem1.Glyph")));
            this.toggleTableAutoFitItem1.Id = 83;
            this.toggleTableAutoFitItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("toggleTableAutoFitItem1.LargeGlyph")));
            this.toggleTableAutoFitItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.toggleTableAutoFitContentsItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.toggleTableAutoFitWindowItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.toggleTableFixedColumnWidthItem1)});
            this.toggleTableAutoFitItem1.Name = "toggleTableAutoFitItem1";
            toolTipTitleItem83.Text = "AutoFit";
            toolTipItem83.Text = "Automatically resize the column widths based on the text in them.\r\n\r\nYou can set " +
                "the table width based on the window size or convert it back to use fixed column " +
                "widths.";
            superToolTip83.Items.Add(toolTipTitleItem83);
            superToolTip83.Items.Add(toolTipItem83);
            this.toggleTableAutoFitItem1.SuperTip = superToolTip83;
            // 
            // toggleTableAutoFitContentsItem1
            // 
            this.toggleTableAutoFitContentsItem1.Caption = "AutoFit Contents";
            this.toggleTableAutoFitContentsItem1.Enabled = false;
            this.toggleTableAutoFitContentsItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("toggleTableAutoFitContentsItem1.Glyph")));
            this.toggleTableAutoFitContentsItem1.Id = 84;
            this.toggleTableAutoFitContentsItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("toggleTableAutoFitContentsItem1.LargeGlyph")));
            this.toggleTableAutoFitContentsItem1.Name = "toggleTableAutoFitContentsItem1";
            toolTipTitleItem80.Text = "AutoFit Contents";
            toolTipItem80.Text = "Auto-Fit Table to the contents.";
            superToolTip80.Items.Add(toolTipTitleItem80);
            superToolTip80.Items.Add(toolTipItem80);
            this.toggleTableAutoFitContentsItem1.SuperTip = superToolTip80;
            // 
            // toggleTableAutoFitWindowItem1
            // 
            this.toggleTableAutoFitWindowItem1.Caption = "AutoFit Window";
            this.toggleTableAutoFitWindowItem1.Enabled = false;
            this.toggleTableAutoFitWindowItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("toggleTableAutoFitWindowItem1.Glyph")));
            this.toggleTableAutoFitWindowItem1.Id = 85;
            this.toggleTableAutoFitWindowItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("toggleTableAutoFitWindowItem1.LargeGlyph")));
            this.toggleTableAutoFitWindowItem1.Name = "toggleTableAutoFitWindowItem1";
            toolTipTitleItem81.Text = "AutoFit Window";
            toolTipItem81.Text = "Auto-Fit Table to the window.";
            superToolTip81.Items.Add(toolTipTitleItem81);
            superToolTip81.Items.Add(toolTipItem81);
            this.toggleTableAutoFitWindowItem1.SuperTip = superToolTip81;
            // 
            // toggleTableFixedColumnWidthItem1
            // 
            this.toggleTableFixedColumnWidthItem1.Caption = "Fixed Column Width";
            this.toggleTableFixedColumnWidthItem1.Enabled = false;
            this.toggleTableFixedColumnWidthItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("toggleTableFixedColumnWidthItem1.Glyph")));
            this.toggleTableFixedColumnWidthItem1.Id = 86;
            this.toggleTableFixedColumnWidthItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("toggleTableFixedColumnWidthItem1.LargeGlyph")));
            this.toggleTableFixedColumnWidthItem1.Name = "toggleTableFixedColumnWidthItem1";
            toolTipTitleItem82.Text = "Fixed Column Width";
            toolTipItem82.Text = "Set table size to a fixed width.";
            superToolTip82.Items.Add(toolTipTitleItem82);
            superToolTip82.Items.Add(toolTipItem82);
            this.toggleTableFixedColumnWidthItem1.SuperTip = superToolTip82;
            // 
            // toggleTableCellsTopLeftAlignmentItem1
            // 
            this.toggleTableCellsTopLeftAlignmentItem1.Caption = "Align Top Left";
            this.toggleTableCellsTopLeftAlignmentItem1.Enabled = false;
            this.toggleTableCellsTopLeftAlignmentItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("toggleTableCellsTopLeftAlignmentItem1.Glyph")));
            this.toggleTableCellsTopLeftAlignmentItem1.Id = 87;
            this.toggleTableCellsTopLeftAlignmentItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("toggleTableCellsTopLeftAlignmentItem1.LargeGlyph")));
            this.toggleTableCellsTopLeftAlignmentItem1.Name = "toggleTableCellsTopLeftAlignmentItem1";
            toolTipTitleItem84.Text = "Align Top Left";
            toolTipItem84.Text = "Align text to the top left corner of the cell.";
            superToolTip84.Items.Add(toolTipTitleItem84);
            superToolTip84.Items.Add(toolTipItem84);
            this.toggleTableCellsTopLeftAlignmentItem1.SuperTip = superToolTip84;
            // 
            // toggleTableCellsTopCenterAlignmentItem1
            // 
            this.toggleTableCellsTopCenterAlignmentItem1.Caption = "Align Top Center";
            this.toggleTableCellsTopCenterAlignmentItem1.Enabled = false;
            this.toggleTableCellsTopCenterAlignmentItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("toggleTableCellsTopCenterAlignmentItem1.Glyph")));
            this.toggleTableCellsTopCenterAlignmentItem1.Id = 88;
            this.toggleTableCellsTopCenterAlignmentItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("toggleTableCellsTopCenterAlignmentItem1.LargeGlyph")));
            this.toggleTableCellsTopCenterAlignmentItem1.Name = "toggleTableCellsTopCenterAlignmentItem1";
            toolTipTitleItem85.Text = "Align Top Center";
            toolTipItem85.Text = "Center text and align it to the top of the cell.";
            superToolTip85.Items.Add(toolTipTitleItem85);
            superToolTip85.Items.Add(toolTipItem85);
            this.toggleTableCellsTopCenterAlignmentItem1.SuperTip = superToolTip85;
            // 
            // toggleTableCellsTopRightAlignmentItem1
            // 
            this.toggleTableCellsTopRightAlignmentItem1.Caption = "Align Top Right";
            this.toggleTableCellsTopRightAlignmentItem1.Enabled = false;
            this.toggleTableCellsTopRightAlignmentItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("toggleTableCellsTopRightAlignmentItem1.Glyph")));
            this.toggleTableCellsTopRightAlignmentItem1.Id = 89;
            this.toggleTableCellsTopRightAlignmentItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("toggleTableCellsTopRightAlignmentItem1.LargeGlyph")));
            this.toggleTableCellsTopRightAlignmentItem1.Name = "toggleTableCellsTopRightAlignmentItem1";
            toolTipTitleItem86.Text = "Align Top Right";
            toolTipItem86.Text = "Align text to the top right corner of the cell.";
            superToolTip86.Items.Add(toolTipTitleItem86);
            superToolTip86.Items.Add(toolTipItem86);
            this.toggleTableCellsTopRightAlignmentItem1.SuperTip = superToolTip86;
            // 
            // toggleTableCellsMiddleLeftAlignmentItem1
            // 
            this.toggleTableCellsMiddleLeftAlignmentItem1.Caption = "Align Center Left";
            this.toggleTableCellsMiddleLeftAlignmentItem1.Enabled = false;
            this.toggleTableCellsMiddleLeftAlignmentItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("toggleTableCellsMiddleLeftAlignmentItem1.Glyph")));
            this.toggleTableCellsMiddleLeftAlignmentItem1.Id = 90;
            this.toggleTableCellsMiddleLeftAlignmentItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("toggleTableCellsMiddleLeftAlignmentItem1.LargeGlyph")));
            this.toggleTableCellsMiddleLeftAlignmentItem1.Name = "toggleTableCellsMiddleLeftAlignmentItem1";
            toolTipTitleItem87.Text = "Align Center Left";
            toolTipItem87.Text = "Center text vertically and align it to the left side of the cell.";
            superToolTip87.Items.Add(toolTipTitleItem87);
            superToolTip87.Items.Add(toolTipItem87);
            this.toggleTableCellsMiddleLeftAlignmentItem1.SuperTip = superToolTip87;
            // 
            // toggleTableCellsMiddleCenterAlignmentItem1
            // 
            this.toggleTableCellsMiddleCenterAlignmentItem1.Caption = "Align Center";
            this.toggleTableCellsMiddleCenterAlignmentItem1.Enabled = false;
            this.toggleTableCellsMiddleCenterAlignmentItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("toggleTableCellsMiddleCenterAlignmentItem1.Glyph")));
            this.toggleTableCellsMiddleCenterAlignmentItem1.Id = 91;
            this.toggleTableCellsMiddleCenterAlignmentItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("toggleTableCellsMiddleCenterAlignmentItem1.LargeGlyph")));
            this.toggleTableCellsMiddleCenterAlignmentItem1.Name = "toggleTableCellsMiddleCenterAlignmentItem1";
            toolTipTitleItem88.Text = "Align Center";
            toolTipItem88.Text = "Center text horizontally and vertically within the cell.";
            superToolTip88.Items.Add(toolTipTitleItem88);
            superToolTip88.Items.Add(toolTipItem88);
            this.toggleTableCellsMiddleCenterAlignmentItem1.SuperTip = superToolTip88;
            // 
            // toggleTableCellsMiddleRightAlignmentItem1
            // 
            this.toggleTableCellsMiddleRightAlignmentItem1.Caption = "Align Center Right";
            this.toggleTableCellsMiddleRightAlignmentItem1.Enabled = false;
            this.toggleTableCellsMiddleRightAlignmentItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("toggleTableCellsMiddleRightAlignmentItem1.Glyph")));
            this.toggleTableCellsMiddleRightAlignmentItem1.Id = 92;
            this.toggleTableCellsMiddleRightAlignmentItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("toggleTableCellsMiddleRightAlignmentItem1.LargeGlyph")));
            this.toggleTableCellsMiddleRightAlignmentItem1.Name = "toggleTableCellsMiddleRightAlignmentItem1";
            toolTipTitleItem89.Text = "Align Center Right";
            toolTipItem89.Text = "Center text vertically and align it to the right side of the cell.";
            superToolTip89.Items.Add(toolTipTitleItem89);
            superToolTip89.Items.Add(toolTipItem89);
            this.toggleTableCellsMiddleRightAlignmentItem1.SuperTip = superToolTip89;
            // 
            // toggleTableCellsBottomLeftAlignmentItem1
            // 
            this.toggleTableCellsBottomLeftAlignmentItem1.Caption = "Align Bottom Left";
            this.toggleTableCellsBottomLeftAlignmentItem1.Enabled = false;
            this.toggleTableCellsBottomLeftAlignmentItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("toggleTableCellsBottomLeftAlignmentItem1.Glyph")));
            this.toggleTableCellsBottomLeftAlignmentItem1.Id = 93;
            this.toggleTableCellsBottomLeftAlignmentItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("toggleTableCellsBottomLeftAlignmentItem1.LargeGlyph")));
            this.toggleTableCellsBottomLeftAlignmentItem1.Name = "toggleTableCellsBottomLeftAlignmentItem1";
            toolTipTitleItem90.Text = "Align Bottom Left";
            toolTipItem90.Text = "Align text to the bottom left corner of the cell.";
            superToolTip90.Items.Add(toolTipTitleItem90);
            superToolTip90.Items.Add(toolTipItem90);
            this.toggleTableCellsBottomLeftAlignmentItem1.SuperTip = superToolTip90;
            // 
            // toggleTableCellsBottomCenterAlignmentItem1
            // 
            this.toggleTableCellsBottomCenterAlignmentItem1.Caption = "Align Bottom Center";
            this.toggleTableCellsBottomCenterAlignmentItem1.Enabled = false;
            this.toggleTableCellsBottomCenterAlignmentItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("toggleTableCellsBottomCenterAlignmentItem1.Glyph")));
            this.toggleTableCellsBottomCenterAlignmentItem1.Id = 94;
            this.toggleTableCellsBottomCenterAlignmentItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("toggleTableCellsBottomCenterAlignmentItem1.LargeGlyph")));
            this.toggleTableCellsBottomCenterAlignmentItem1.Name = "toggleTableCellsBottomCenterAlignmentItem1";
            toolTipTitleItem91.Text = "Align Bottom Center";
            toolTipItem91.Text = "Center text and align it to the bottom of the cell.";
            superToolTip91.Items.Add(toolTipTitleItem91);
            superToolTip91.Items.Add(toolTipItem91);
            this.toggleTableCellsBottomCenterAlignmentItem1.SuperTip = superToolTip91;
            // 
            // toggleTableCellsBottomRightAlignmentItem1
            // 
            this.toggleTableCellsBottomRightAlignmentItem1.Caption = "Align Bottom Right";
            this.toggleTableCellsBottomRightAlignmentItem1.Enabled = false;
            this.toggleTableCellsBottomRightAlignmentItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("toggleTableCellsBottomRightAlignmentItem1.Glyph")));
            this.toggleTableCellsBottomRightAlignmentItem1.Id = 95;
            this.toggleTableCellsBottomRightAlignmentItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("toggleTableCellsBottomRightAlignmentItem1.LargeGlyph")));
            this.toggleTableCellsBottomRightAlignmentItem1.Name = "toggleTableCellsBottomRightAlignmentItem1";
            toolTipTitleItem92.Text = "Align Bottom Right";
            toolTipItem92.Text = "Align text to the bottom right corner of the cell.";
            superToolTip92.Items.Add(toolTipTitleItem92);
            superToolTip92.Items.Add(toolTipItem92);
            this.toggleTableCellsBottomRightAlignmentItem1.SuperTip = superToolTip92;
            // 
            // switchToSimpleViewItem1
            // 
            this.switchToSimpleViewItem1.Caption = "Simple View";
            this.switchToSimpleViewItem1.Enabled = false;
            this.switchToSimpleViewItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("switchToSimpleViewItem1.Glyph")));
            this.switchToSimpleViewItem1.Id = 96;
            this.switchToSimpleViewItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("switchToSimpleViewItem1.LargeGlyph")));
            this.switchToSimpleViewItem1.Name = "switchToSimpleViewItem1";
            toolTipTitleItem93.Text = "Simple View";
            toolTipItem93.Text = "View the document as a simple memo.\r\n\r\nThis view ignores the page layout to draw " +
                "attention to text editing.";
            superToolTip93.Items.Add(toolTipTitleItem93);
            superToolTip93.Items.Add(toolTipItem93);
            this.switchToSimpleViewItem1.SuperTip = superToolTip93;
            // 
            // switchToDraftViewItem1
            // 
            this.switchToDraftViewItem1.Caption = "Draft View";
            this.switchToDraftViewItem1.Enabled = false;
            this.switchToDraftViewItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("switchToDraftViewItem1.Glyph")));
            this.switchToDraftViewItem1.Id = 97;
            this.switchToDraftViewItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("switchToDraftViewItem1.LargeGlyph")));
            this.switchToDraftViewItem1.Name = "switchToDraftViewItem1";
            toolTipTitleItem94.Text = "Draft View";
            toolTipItem94.Text = "View the document as a draft to quickly edit the text.\r\n\r\nCertain elements of the" +
                " document such as headers and footers will not be visible in this view.";
            superToolTip94.Items.Add(toolTipTitleItem94);
            superToolTip94.Items.Add(toolTipItem94);
            this.switchToDraftViewItem1.SuperTip = superToolTip94;
            // 
            // switchToPrintLayoutViewItem1
            // 
            this.switchToPrintLayoutViewItem1.Caption = "Print Layout";
            this.switchToPrintLayoutViewItem1.Enabled = false;
            this.switchToPrintLayoutViewItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("switchToPrintLayoutViewItem1.Glyph")));
            this.switchToPrintLayoutViewItem1.Id = 98;
            this.switchToPrintLayoutViewItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("switchToPrintLayoutViewItem1.LargeGlyph")));
            this.switchToPrintLayoutViewItem1.Name = "switchToPrintLayoutViewItem1";
            toolTipTitleItem95.Text = "Print Layout";
            toolTipItem95.Text = "View the document as it will appear on the printed page.";
            superToolTip95.Items.Add(toolTipTitleItem95);
            superToolTip95.Items.Add(toolTipItem95);
            this.switchToPrintLayoutViewItem1.SuperTip = superToolTip95;
            // 
            // toggleShowHorizontalRulerItem1
            // 
            this.toggleShowHorizontalRulerItem1.Caption = "Horizontal Ruler";
            this.toggleShowHorizontalRulerItem1.Enabled = false;
            this.toggleShowHorizontalRulerItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("toggleShowHorizontalRulerItem1.Glyph")));
            this.toggleShowHorizontalRulerItem1.Id = 99;
            this.toggleShowHorizontalRulerItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("toggleShowHorizontalRulerItem1.LargeGlyph")));
            this.toggleShowHorizontalRulerItem1.Name = "toggleShowHorizontalRulerItem1";
            toolTipTitleItem96.Text = "Horizontal Ruler";
            toolTipItem96.Text = "View the horizontal ruler, used to measure and line up objects in the document";
            superToolTip96.Items.Add(toolTipTitleItem96);
            superToolTip96.Items.Add(toolTipItem96);
            this.toggleShowHorizontalRulerItem1.SuperTip = superToolTip96;
            // 
            // toggleShowVerticalRulerItem1
            // 
            this.toggleShowVerticalRulerItem1.Caption = "Vertical Ruler";
            this.toggleShowVerticalRulerItem1.Enabled = false;
            this.toggleShowVerticalRulerItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("toggleShowVerticalRulerItem1.Glyph")));
            this.toggleShowVerticalRulerItem1.Id = 100;
            this.toggleShowVerticalRulerItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("toggleShowVerticalRulerItem1.LargeGlyph")));
            this.toggleShowVerticalRulerItem1.Name = "toggleShowVerticalRulerItem1";
            toolTipTitleItem97.Text = "Vertical Ruler";
            toolTipItem97.Text = "View the vertical ruler, used to measure and line up objects in the document";
            superToolTip97.Items.Add(toolTipTitleItem97);
            superToolTip97.Items.Add(toolTipItem97);
            this.toggleShowVerticalRulerItem1.SuperTip = superToolTip97;
            // 
            // zoomOutItem1
            // 
            this.zoomOutItem1.Caption = "Zoom Out";
            this.zoomOutItem1.Enabled = false;
            this.zoomOutItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("zoomOutItem1.Glyph")));
            this.zoomOutItem1.Id = 101;
            this.zoomOutItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("zoomOutItem1.LargeGlyph")));
            this.zoomOutItem1.Name = "zoomOutItem1";
            toolTipTitleItem98.Text = "Zoom Out (Ctrl+Subtract)";
            toolTipItem98.Text = "Zoom Out";
            superToolTip98.Items.Add(toolTipTitleItem98);
            superToolTip98.Items.Add(toolTipItem98);
            this.zoomOutItem1.SuperTip = superToolTip98;
            // 
            // zoomInItem1
            // 
            this.zoomInItem1.Caption = "Zoom In";
            this.zoomInItem1.Enabled = false;
            this.zoomInItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("zoomInItem1.Glyph")));
            this.zoomInItem1.Id = 102;
            this.zoomInItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("zoomInItem1.LargeGlyph")));
            this.zoomInItem1.Name = "zoomInItem1";
            toolTipTitleItem99.Text = "Zoom In (Ctrl+Add)";
            toolTipItem99.Text = "Zoom In";
            superToolTip99.Items.Add(toolTipTitleItem99);
            superToolTip99.Items.Add(toolTipItem99);
            this.zoomInItem1.SuperTip = superToolTip99;
            // 
            // toggleBulletedListItem1
            // 
            this.toggleBulletedListItem1.Caption = "Bullets";
            this.toggleBulletedListItem1.Enabled = false;
            this.toggleBulletedListItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("toggleBulletedListItem1.Glyph")));
            this.toggleBulletedListItem1.Id = 112;
            this.toggleBulletedListItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("toggleBulletedListItem1.LargeGlyph")));
            this.toggleBulletedListItem1.Name = "toggleBulletedListItem1";
            toolTipTitleItem100.Text = "Bullets";
            toolTipItem100.Text = "Start a bulleted list.";
            superToolTip100.Items.Add(toolTipTitleItem100);
            superToolTip100.Items.Add(toolTipItem100);
            this.toggleBulletedListItem1.SuperTip = superToolTip100;
            // 
            // insertPageBreakItem1
            // 
            this.insertPageBreakItem1.Caption = "Page";
            this.insertPageBreakItem1.Enabled = false;
            this.insertPageBreakItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("insertPageBreakItem1.Glyph")));
            this.insertPageBreakItem1.Id = 113;
            this.insertPageBreakItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("insertPageBreakItem1.LargeGlyph")));
            this.insertPageBreakItem1.Name = "insertPageBreakItem1";
            toolTipTitleItem101.Text = "Page (Ctrl+Return)";
            toolTipItem101.Text = "Start the next page at the current position.";
            superToolTip101.Items.Add(toolTipTitleItem101);
            superToolTip101.Items.Add(toolTipItem101);
            this.insertPageBreakItem1.SuperTip = superToolTip101;
            // 
            // insertTableItem1
            // 
            this.insertTableItem1.Caption = "Table";
            this.insertTableItem1.Enabled = false;
            this.insertTableItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("insertTableItem1.Glyph")));
            this.insertTableItem1.Id = 114;
            this.insertTableItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("insertTableItem1.LargeGlyph")));
            this.insertTableItem1.Name = "insertTableItem1";
            toolTipTitleItem102.Text = "Table";
            toolTipItem102.Text = "Insert a table into the document.";
            superToolTip102.Items.Add(toolTipTitleItem102);
            superToolTip102.Items.Add(toolTipItem102);
            this.insertTableItem1.SuperTip = superToolTip102;
            // 
            // insertPictureItem1
            // 
            this.insertPictureItem1.Caption = "Picture";
            this.insertPictureItem1.Enabled = false;
            this.insertPictureItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("insertPictureItem1.Glyph")));
            this.insertPictureItem1.Id = 115;
            this.insertPictureItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("insertPictureItem1.LargeGlyph")));
            this.insertPictureItem1.Name = "insertPictureItem1";
            toolTipTitleItem103.Text = "Picture";
            toolTipItem103.Text = "Insert a picture from a file.";
            superToolTip103.Items.Add(toolTipTitleItem103);
            superToolTip103.Items.Add(toolTipItem103);
            this.insertPictureItem1.SuperTip = superToolTip103;
            // 
            // insertBookmarkItem1
            // 
            this.insertBookmarkItem1.Caption = "Bookmark";
            this.insertBookmarkItem1.Enabled = false;
            this.insertBookmarkItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("insertBookmarkItem1.Glyph")));
            this.insertBookmarkItem1.Id = 116;
            this.insertBookmarkItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("insertBookmarkItem1.LargeGlyph")));
            this.insertBookmarkItem1.Name = "insertBookmarkItem1";
            toolTipTitleItem104.Text = "Bookmark";
            toolTipItem104.Text = "Create a bookmark to assign a name to a specific point in a document\r\n\r\nYou can m" +
                "ake hyperlinks that jump directly to a bookmarked location.";
            superToolTip104.Items.Add(toolTipTitleItem104);
            superToolTip104.Items.Add(toolTipItem104);
            this.insertBookmarkItem1.SuperTip = superToolTip104;
            // 
            // insertHyperlinkItem1
            // 
            this.insertHyperlinkItem1.Caption = "Hyperlink";
            this.insertHyperlinkItem1.Enabled = false;
            this.insertHyperlinkItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("insertHyperlinkItem1.Glyph")));
            this.insertHyperlinkItem1.Id = 117;
            this.insertHyperlinkItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("insertHyperlinkItem1.LargeGlyph")));
            this.insertHyperlinkItem1.Name = "insertHyperlinkItem1";
            toolTipTitleItem105.Text = "Hyperlink (Ctrl+K)";
            toolTipItem105.Text = "Create a link to a Web page, a picture, an e-mail address, or a program.";
            superToolTip105.Items.Add(toolTipTitleItem105);
            superToolTip105.Items.Add(toolTipItem105);
            this.insertHyperlinkItem1.SuperTip = superToolTip105;
            // 
            // editPageHeaderItem1
            // 
            this.editPageHeaderItem1.Caption = "Header";
            this.editPageHeaderItem1.Enabled = false;
            this.editPageHeaderItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("editPageHeaderItem1.Glyph")));
            this.editPageHeaderItem1.Id = 118;
            this.editPageHeaderItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("editPageHeaderItem1.LargeGlyph")));
            this.editPageHeaderItem1.Name = "editPageHeaderItem1";
            toolTipTitleItem106.Text = "Header";
            toolTipItem106.Text = "Edit the header of the document.\r\n\r\nThe content in the header will appear at the " +
                "top of each printed page.";
            superToolTip106.Items.Add(toolTipTitleItem106);
            superToolTip106.Items.Add(toolTipItem106);
            this.editPageHeaderItem1.SuperTip = superToolTip106;
            // 
            // editPageFooterItem1
            // 
            this.editPageFooterItem1.Caption = "Footer";
            this.editPageFooterItem1.Enabled = false;
            this.editPageFooterItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("editPageFooterItem1.Glyph")));
            this.editPageFooterItem1.Id = 119;
            this.editPageFooterItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("editPageFooterItem1.LargeGlyph")));
            this.editPageFooterItem1.Name = "editPageFooterItem1";
            toolTipTitleItem107.Text = "Footer";
            toolTipItem107.Text = "Edit the footer of the document.\r\n\r\nThe content in the footer will appear at the " +
                "bottom of each printed page.";
            superToolTip107.Items.Add(toolTipTitleItem107);
            superToolTip107.Items.Add(toolTipItem107);
            this.editPageFooterItem1.SuperTip = superToolTip107;
            // 
            // insertPageNumberItem1
            // 
            this.insertPageNumberItem1.Caption = "Page Number";
            this.insertPageNumberItem1.Enabled = false;
            this.insertPageNumberItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("insertPageNumberItem1.Glyph")));
            this.insertPageNumberItem1.Id = 120;
            this.insertPageNumberItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("insertPageNumberItem1.LargeGlyph")));
            this.insertPageNumberItem1.Name = "insertPageNumberItem1";
            toolTipTitleItem108.Text = "Page Number";
            toolTipItem108.Text = "Insert page numbers into the document.";
            superToolTip108.Items.Add(toolTipTitleItem108);
            superToolTip108.Items.Add(toolTipItem108);
            this.insertPageNumberItem1.SuperTip = superToolTip108;
            // 
            // insertPageCountItem1
            // 
            this.insertPageCountItem1.Caption = "Page Count";
            this.insertPageCountItem1.Enabled = false;
            this.insertPageCountItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("insertPageCountItem1.Glyph")));
            this.insertPageCountItem1.Id = 121;
            this.insertPageCountItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("insertPageCountItem1.LargeGlyph")));
            this.insertPageCountItem1.Name = "insertPageCountItem1";
            toolTipTitleItem109.Text = "Page Count";
            toolTipItem109.Text = "Insert total page count into the document.";
            superToolTip109.Items.Add(toolTipTitleItem109);
            superToolTip109.Items.Add(toolTipItem109);
            this.insertPageCountItem1.SuperTip = superToolTip109;
            // 
            // insertSymbolItem1
            // 
            this.insertSymbolItem1.Caption = "Symbol";
            this.insertSymbolItem1.Enabled = false;
            this.insertSymbolItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("insertSymbolItem1.Glyph")));
            this.insertSymbolItem1.Id = 122;
            this.insertSymbolItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("insertSymbolItem1.LargeGlyph")));
            this.insertSymbolItem1.Name = "insertSymbolItem1";
            toolTipTitleItem110.Text = "Symbol";
            toolTipItem110.Text = "Insert symbols that are not on your keyboard, such as copyright symbols, trademar" +
                "k symbols, paragraph marks and Unicode characters.";
            superToolTip110.Items.Add(toolTipTitleItem110);
            superToolTip110.Items.Add(toolTipItem110);
            this.insertSymbolItem1.SuperTip = superToolTip110;
            // 
            // changeSectionPageMarginsItem1
            // 
            this.changeSectionPageMarginsItem1.Caption = "Margins";
            this.changeSectionPageMarginsItem1.Enabled = false;
            this.changeSectionPageMarginsItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("changeSectionPageMarginsItem1.Glyph")));
            this.changeSectionPageMarginsItem1.Id = 129;
            this.changeSectionPageMarginsItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("changeSectionPageMarginsItem1.LargeGlyph")));
            this.changeSectionPageMarginsItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.setNormalSectionPageMarginsItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.setNarrowSectionPageMarginsItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.setModerateSectionPageMarginsItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.setWideSectionPageMarginsItem1)});
            this.changeSectionPageMarginsItem1.Name = "changeSectionPageMarginsItem1";
            toolTipTitleItem115.Text = "Margins";
            toolTipItem115.Text = "Select the margin sizes for the entire document or the current section.";
            superToolTip115.Items.Add(toolTipTitleItem115);
            superToolTip115.Items.Add(toolTipItem115);
            this.changeSectionPageMarginsItem1.SuperTip = superToolTip115;
            // 
            // setNormalSectionPageMarginsItem1
            // 
            this.setNormalSectionPageMarginsItem1.Caption = "Normal\r\nTop:\t     0.79\"\tBottom:\t     0.79\"\r\nLeft:\t     1.18\"\tRight:\t\t     0.59\"";
            this.setNormalSectionPageMarginsItem1.Enabled = false;
            this.setNormalSectionPageMarginsItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("setNormalSectionPageMarginsItem1.Glyph")));
            this.setNormalSectionPageMarginsItem1.Id = 130;
            this.setNormalSectionPageMarginsItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("setNormalSectionPageMarginsItem1.LargeGlyph")));
            this.setNormalSectionPageMarginsItem1.Name = "setNormalSectionPageMarginsItem1";
            toolTipTitleItem111.Text = "Normal\r\nTop:\t     0.79\"\tBottom:\t     0.79\"\r\nLeft:\t     1.18\"\tRight:\t\t     0.59\"";
            toolTipItem111.Text = " ";
            superToolTip111.Items.Add(toolTipTitleItem111);
            superToolTip111.Items.Add(toolTipItem111);
            this.setNormalSectionPageMarginsItem1.SuperTip = superToolTip111;
            // 
            // setNarrowSectionPageMarginsItem1
            // 
            this.setNarrowSectionPageMarginsItem1.Caption = "Narrow\r\nTop:\t      0.5\"\tBottom:\t      0.5\"\r\nLeft:\t      0.5\"\tRight:\t\t      0.5\"";
            this.setNarrowSectionPageMarginsItem1.Enabled = false;
            this.setNarrowSectionPageMarginsItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("setNarrowSectionPageMarginsItem1.Glyph")));
            this.setNarrowSectionPageMarginsItem1.Id = 131;
            this.setNarrowSectionPageMarginsItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("setNarrowSectionPageMarginsItem1.LargeGlyph")));
            this.setNarrowSectionPageMarginsItem1.Name = "setNarrowSectionPageMarginsItem1";
            toolTipTitleItem112.Text = "Narrow\r\nTop:\t      0.5\"\tBottom:\t      0.5\"\r\nLeft:\t      0.5\"\tRight:\t\t      0.5\"";
            toolTipItem112.Text = " ";
            superToolTip112.Items.Add(toolTipTitleItem112);
            superToolTip112.Items.Add(toolTipItem112);
            this.setNarrowSectionPageMarginsItem1.SuperTip = superToolTip112;
            // 
            // setModerateSectionPageMarginsItem1
            // 
            this.setModerateSectionPageMarginsItem1.Caption = "Moderate\r\nTop:\t        1\"\tBottom:\t        1\"\r\nLeft:\t     0.75\"\tRight:\t\t     0.75\"" +
                "";
            this.setModerateSectionPageMarginsItem1.Enabled = false;
            this.setModerateSectionPageMarginsItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("setModerateSectionPageMarginsItem1.Glyph")));
            this.setModerateSectionPageMarginsItem1.Id = 132;
            this.setModerateSectionPageMarginsItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("setModerateSectionPageMarginsItem1.LargeGlyph")));
            this.setModerateSectionPageMarginsItem1.Name = "setModerateSectionPageMarginsItem1";
            toolTipTitleItem113.Text = "Moderate\r\nTop:\t        1\"\tBottom:\t        1\"\r\nLeft:\t     0.75\"\tRight:\t\t     0.75\"" +
                "";
            toolTipItem113.Text = " ";
            superToolTip113.Items.Add(toolTipTitleItem113);
            superToolTip113.Items.Add(toolTipItem113);
            this.setModerateSectionPageMarginsItem1.SuperTip = superToolTip113;
            // 
            // setWideSectionPageMarginsItem1
            // 
            this.setWideSectionPageMarginsItem1.Caption = "Wide\r\nTop:\t        1\"\tBottom:\t        1\"\r\nLeft:\t        2\"\tRight:\t\t        2\"";
            this.setWideSectionPageMarginsItem1.Enabled = false;
            this.setWideSectionPageMarginsItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("setWideSectionPageMarginsItem1.Glyph")));
            this.setWideSectionPageMarginsItem1.Id = 133;
            this.setWideSectionPageMarginsItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("setWideSectionPageMarginsItem1.LargeGlyph")));
            this.setWideSectionPageMarginsItem1.Name = "setWideSectionPageMarginsItem1";
            toolTipTitleItem114.Text = "Wide\r\nTop:\t        1\"\tBottom:\t        1\"\r\nLeft:\t        2\"\tRight:\t\t        2\"";
            toolTipItem114.Text = " ";
            superToolTip114.Items.Add(toolTipTitleItem114);
            superToolTip114.Items.Add(toolTipItem114);
            this.setWideSectionPageMarginsItem1.SuperTip = superToolTip114;
            // 
            // changeSectionPageOrientationItem1
            // 
            this.changeSectionPageOrientationItem1.Caption = "Orientation";
            this.changeSectionPageOrientationItem1.Enabled = false;
            this.changeSectionPageOrientationItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("changeSectionPageOrientationItem1.Glyph")));
            this.changeSectionPageOrientationItem1.Id = 134;
            this.changeSectionPageOrientationItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("changeSectionPageOrientationItem1.LargeGlyph")));
            this.changeSectionPageOrientationItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.setPortraitPageOrientationItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.setLandscapePageOrientationItem1)});
            this.changeSectionPageOrientationItem1.Name = "changeSectionPageOrientationItem1";
            toolTipTitleItem118.Text = "Orientation";
            toolTipItem118.Text = "Switch the pages between portrait and landscape layouts.";
            superToolTip118.Items.Add(toolTipTitleItem118);
            superToolTip118.Items.Add(toolTipItem118);
            this.changeSectionPageOrientationItem1.SuperTip = superToolTip118;
            // 
            // setPortraitPageOrientationItem1
            // 
            this.setPortraitPageOrientationItem1.Caption = "Portrait";
            this.setPortraitPageOrientationItem1.Enabled = false;
            this.setPortraitPageOrientationItem1.Id = 135;
            this.setPortraitPageOrientationItem1.Name = "setPortraitPageOrientationItem1";
            toolTipTitleItem116.Text = "Portrait";
            toolTipItem116.Text = " ";
            superToolTip116.Items.Add(toolTipTitleItem116);
            superToolTip116.Items.Add(toolTipItem116);
            this.setPortraitPageOrientationItem1.SuperTip = superToolTip116;
            // 
            // setLandscapePageOrientationItem1
            // 
            this.setLandscapePageOrientationItem1.Caption = "Landscape";
            this.setLandscapePageOrientationItem1.Enabled = false;
            this.setLandscapePageOrientationItem1.Id = 136;
            this.setLandscapePageOrientationItem1.Name = "setLandscapePageOrientationItem1";
            toolTipTitleItem117.Text = "Landscape";
            toolTipItem117.Text = " ";
            superToolTip117.Items.Add(toolTipTitleItem117);
            superToolTip117.Items.Add(toolTipItem117);
            this.setLandscapePageOrientationItem1.SuperTip = superToolTip117;
            // 
            // changeSectionPaperKindItem1
            // 
            this.changeSectionPaperKindItem1.Caption = "Size";
            this.changeSectionPaperKindItem1.Enabled = false;
            this.changeSectionPaperKindItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("changeSectionPaperKindItem1.Glyph")));
            this.changeSectionPaperKindItem1.Id = 137;
            this.changeSectionPaperKindItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("changeSectionPaperKindItem1.LargeGlyph")));
            this.changeSectionPaperKindItem1.Name = "changeSectionPaperKindItem1";
            toolTipTitleItem119.Text = "Size";
            toolTipItem119.Text = "Choose a paper size for the current section.";
            superToolTip119.Items.Add(toolTipTitleItem119);
            superToolTip119.Items.Add(toolTipItem119);
            this.changeSectionPaperKindItem1.SuperTip = superToolTip119;
            // 
            // changeSectionColumnsItem1
            // 
            this.changeSectionColumnsItem1.Caption = "Columns";
            this.changeSectionColumnsItem1.Enabled = false;
            this.changeSectionColumnsItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("changeSectionColumnsItem1.Glyph")));
            this.changeSectionColumnsItem1.Id = 138;
            this.changeSectionColumnsItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("changeSectionColumnsItem1.LargeGlyph")));
            this.changeSectionColumnsItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.setSectionOneColumnItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.setSectionTwoColumnsItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.setSectionThreeColumnsItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.showColumnsSetupFormItem1)});
            this.changeSectionColumnsItem1.Name = "changeSectionColumnsItem1";
            toolTipTitleItem124.Text = "Columns";
            toolTipItem124.Text = "Split text into two or more columns.";
            superToolTip124.Items.Add(toolTipTitleItem124);
            superToolTip124.Items.Add(toolTipItem124);
            this.changeSectionColumnsItem1.SuperTip = superToolTip124;
            // 
            // setSectionOneColumnItem1
            // 
            this.setSectionOneColumnItem1.Caption = "One";
            this.setSectionOneColumnItem1.Enabled = false;
            this.setSectionOneColumnItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("setSectionOneColumnItem1.Glyph")));
            this.setSectionOneColumnItem1.Id = 139;
            this.setSectionOneColumnItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("setSectionOneColumnItem1.LargeGlyph")));
            this.setSectionOneColumnItem1.Name = "setSectionOneColumnItem1";
            toolTipTitleItem120.Text = "One";
            toolTipItem120.Text = "One column.";
            superToolTip120.Items.Add(toolTipTitleItem120);
            superToolTip120.Items.Add(toolTipItem120);
            this.setSectionOneColumnItem1.SuperTip = superToolTip120;
            // 
            // setSectionTwoColumnsItem1
            // 
            this.setSectionTwoColumnsItem1.Caption = "Two";
            this.setSectionTwoColumnsItem1.Enabled = false;
            this.setSectionTwoColumnsItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("setSectionTwoColumnsItem1.Glyph")));
            this.setSectionTwoColumnsItem1.Id = 140;
            this.setSectionTwoColumnsItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("setSectionTwoColumnsItem1.LargeGlyph")));
            this.setSectionTwoColumnsItem1.Name = "setSectionTwoColumnsItem1";
            toolTipTitleItem121.Text = "Two";
            toolTipItem121.Text = "Two columns.";
            superToolTip121.Items.Add(toolTipTitleItem121);
            superToolTip121.Items.Add(toolTipItem121);
            this.setSectionTwoColumnsItem1.SuperTip = superToolTip121;
            // 
            // setSectionThreeColumnsItem1
            // 
            this.setSectionThreeColumnsItem1.Caption = "Three";
            this.setSectionThreeColumnsItem1.Enabled = false;
            this.setSectionThreeColumnsItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("setSectionThreeColumnsItem1.Glyph")));
            this.setSectionThreeColumnsItem1.Id = 141;
            this.setSectionThreeColumnsItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("setSectionThreeColumnsItem1.LargeGlyph")));
            this.setSectionThreeColumnsItem1.Name = "setSectionThreeColumnsItem1";
            toolTipTitleItem122.Text = "Three";
            toolTipItem122.Text = "Three columns.";
            superToolTip122.Items.Add(toolTipTitleItem122);
            superToolTip122.Items.Add(toolTipItem122);
            this.setSectionThreeColumnsItem1.SuperTip = superToolTip122;
            // 
            // showColumnsSetupFormItem1
            // 
            this.showColumnsSetupFormItem1.Caption = "More Columns";
            this.showColumnsSetupFormItem1.Enabled = false;
            this.showColumnsSetupFormItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("showColumnsSetupFormItem1.Glyph")));
            this.showColumnsSetupFormItem1.Id = 142;
            this.showColumnsSetupFormItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("showColumnsSetupFormItem1.LargeGlyph")));
            this.showColumnsSetupFormItem1.Name = "showColumnsSetupFormItem1";
            toolTipTitleItem123.Text = "More Columns";
            toolTipItem123.Text = "Show the Column dialog box to customize column widths.";
            superToolTip123.Items.Add(toolTipTitleItem123);
            superToolTip123.Items.Add(toolTipItem123);
            this.showColumnsSetupFormItem1.SuperTip = superToolTip123;
            // 
            // insertBreakItem1
            // 
            this.insertBreakItem1.Caption = "Breaks";
            this.insertBreakItem1.Enabled = false;
            this.insertBreakItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("insertBreakItem1.Glyph")));
            this.insertBreakItem1.Id = 143;
            this.insertBreakItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("insertBreakItem1.LargeGlyph")));
            this.insertBreakItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.insertPageBreakItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.insertColumnBreakItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.insertSectionBreakNextPageItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.insertSectionBreakEvenPageItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.insertSectionBreakOddPageItem1)});
            this.insertBreakItem1.Name = "insertBreakItem1";
            toolTipTitleItem130.Text = "Breaks";
            toolTipItem130.Text = "Add page, section, or column breaks to the document.";
            superToolTip130.Items.Add(toolTipTitleItem130);
            superToolTip130.Items.Add(toolTipItem130);
            this.insertBreakItem1.SuperTip = superToolTip130;
            // 
            // insertPageBreakItem2
            // 
            this.insertPageBreakItem2.Caption = "Page";
            this.insertPageBreakItem2.Enabled = false;
            this.insertPageBreakItem2.Glyph = ((System.Drawing.Image)(resources.GetObject("insertPageBreakItem2.Glyph")));
            this.insertPageBreakItem2.Id = 144;
            this.insertPageBreakItem2.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("insertPageBreakItem2.LargeGlyph")));
            this.insertPageBreakItem2.Name = "insertPageBreakItem2";
            toolTipTitleItem125.Text = "Page (Ctrl+Return)";
            toolTipItem125.Text = "Start the next page at the current position.";
            superToolTip125.Items.Add(toolTipTitleItem125);
            superToolTip125.Items.Add(toolTipItem125);
            this.insertPageBreakItem2.SuperTip = superToolTip125;
            // 
            // insertColumnBreakItem1
            // 
            this.insertColumnBreakItem1.Caption = "Column";
            this.insertColumnBreakItem1.Enabled = false;
            this.insertColumnBreakItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("insertColumnBreakItem1.Glyph")));
            this.insertColumnBreakItem1.Id = 145;
            this.insertColumnBreakItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("insertColumnBreakItem1.LargeGlyph")));
            this.insertColumnBreakItem1.Name = "insertColumnBreakItem1";
            toolTipTitleItem126.Text = "Column (Ctrl+Shift+Return)";
            toolTipItem126.Text = "Indicate that the text following the column break will begin in the next column.";
            superToolTip126.Items.Add(toolTipTitleItem126);
            superToolTip126.Items.Add(toolTipItem126);
            this.insertColumnBreakItem1.SuperTip = superToolTip126;
            // 
            // insertSectionBreakNextPageItem1
            // 
            this.insertSectionBreakNextPageItem1.Caption = "Section (Next Page)";
            this.insertSectionBreakNextPageItem1.Enabled = false;
            this.insertSectionBreakNextPageItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("insertSectionBreakNextPageItem1.Glyph")));
            this.insertSectionBreakNextPageItem1.Id = 146;
            this.insertSectionBreakNextPageItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("insertSectionBreakNextPageItem1.LargeGlyph")));
            this.insertSectionBreakNextPageItem1.Name = "insertSectionBreakNextPageItem1";
            toolTipTitleItem127.Text = "Section (Next Page)";
            toolTipItem127.Text = "Insert a section break and start the new section on the next page.";
            superToolTip127.Items.Add(toolTipTitleItem127);
            superToolTip127.Items.Add(toolTipItem127);
            this.insertSectionBreakNextPageItem1.SuperTip = superToolTip127;
            // 
            // insertSectionBreakEvenPageItem1
            // 
            this.insertSectionBreakEvenPageItem1.Caption = "Section (Even Page)";
            this.insertSectionBreakEvenPageItem1.Enabled = false;
            this.insertSectionBreakEvenPageItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("insertSectionBreakEvenPageItem1.Glyph")));
            this.insertSectionBreakEvenPageItem1.Id = 147;
            this.insertSectionBreakEvenPageItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("insertSectionBreakEvenPageItem1.LargeGlyph")));
            this.insertSectionBreakEvenPageItem1.Name = "insertSectionBreakEvenPageItem1";
            toolTipTitleItem128.Text = "Section (Even Page)";
            toolTipItem128.Text = "Insert a section break and start the new section on the next even-numbered page.";
            superToolTip128.Items.Add(toolTipTitleItem128);
            superToolTip128.Items.Add(toolTipItem128);
            this.insertSectionBreakEvenPageItem1.SuperTip = superToolTip128;
            // 
            // insertSectionBreakOddPageItem1
            // 
            this.insertSectionBreakOddPageItem1.Caption = "Section (Odd Page)";
            this.insertSectionBreakOddPageItem1.Enabled = false;
            this.insertSectionBreakOddPageItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("insertSectionBreakOddPageItem1.Glyph")));
            this.insertSectionBreakOddPageItem1.Id = 148;
            this.insertSectionBreakOddPageItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("insertSectionBreakOddPageItem1.LargeGlyph")));
            this.insertSectionBreakOddPageItem1.Name = "insertSectionBreakOddPageItem1";
            toolTipTitleItem129.Text = "Section (Odd Page)";
            toolTipItem129.Text = "Insert a section break and start the new section on the next odd-numbered page.";
            superToolTip129.Items.Add(toolTipTitleItem129);
            superToolTip129.Items.Add(toolTipItem129);
            this.insertSectionBreakOddPageItem1.SuperTip = superToolTip129;
            // 
            // changeSectionLineNumberingItem1
            // 
            this.changeSectionLineNumberingItem1.Caption = "Line Numbers";
            this.changeSectionLineNumberingItem1.Enabled = false;
            this.changeSectionLineNumberingItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("changeSectionLineNumberingItem1.Glyph")));
            this.changeSectionLineNumberingItem1.Id = 149;
            this.changeSectionLineNumberingItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("changeSectionLineNumberingItem1.LargeGlyph")));
            this.changeSectionLineNumberingItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.setSectionLineNumberingNoneItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.setSectionLineNumberingContinuousItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.setSectionLineNumberingRestartNewPageItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.setSectionLineNumberingRestartNewSectionItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.toggleParagraphSuppressLineNumbersItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.showLineNumberingFormItem1)});
            this.changeSectionLineNumberingItem1.Name = "changeSectionLineNumberingItem1";
            toolTipTitleItem137.Text = "Line Numbers";
            toolTipItem137.Text = "Add line numbers in the margin alongside of each line of the document.";
            superToolTip137.Items.Add(toolTipTitleItem137);
            superToolTip137.Items.Add(toolTipItem137);
            this.changeSectionLineNumberingItem1.SuperTip = superToolTip137;
            // 
            // setSectionLineNumberingNoneItem1
            // 
            this.setSectionLineNumberingNoneItem1.Caption = "None";
            this.setSectionLineNumberingNoneItem1.Enabled = false;
            this.setSectionLineNumberingNoneItem1.Id = 150;
            this.setSectionLineNumberingNoneItem1.Name = "setSectionLineNumberingNoneItem1";
            toolTipTitleItem131.Text = "None";
            toolTipItem131.Text = "No line numbers.";
            superToolTip131.Items.Add(toolTipTitleItem131);
            superToolTip131.Items.Add(toolTipItem131);
            this.setSectionLineNumberingNoneItem1.SuperTip = superToolTip131;
            // 
            // setSectionLineNumberingContinuousItem1
            // 
            this.setSectionLineNumberingContinuousItem1.Caption = "Continuous";
            this.setSectionLineNumberingContinuousItem1.Enabled = false;
            this.setSectionLineNumberingContinuousItem1.Id = 151;
            this.setSectionLineNumberingContinuousItem1.Name = "setSectionLineNumberingContinuousItem1";
            toolTipTitleItem132.Text = "Continuous";
            toolTipItem132.Text = "Continuous";
            superToolTip132.Items.Add(toolTipTitleItem132);
            superToolTip132.Items.Add(toolTipItem132);
            this.setSectionLineNumberingContinuousItem1.SuperTip = superToolTip132;
            // 
            // setSectionLineNumberingRestartNewPageItem1
            // 
            this.setSectionLineNumberingRestartNewPageItem1.Caption = "Restart Each Page";
            this.setSectionLineNumberingRestartNewPageItem1.Enabled = false;
            this.setSectionLineNumberingRestartNewPageItem1.Id = 152;
            this.setSectionLineNumberingRestartNewPageItem1.Name = "setSectionLineNumberingRestartNewPageItem1";
            toolTipTitleItem133.Text = "Restart Each Page";
            toolTipItem133.Text = "Restart Each Page";
            superToolTip133.Items.Add(toolTipTitleItem133);
            superToolTip133.Items.Add(toolTipItem133);
            this.setSectionLineNumberingRestartNewPageItem1.SuperTip = superToolTip133;
            // 
            // setSectionLineNumberingRestartNewSectionItem1
            // 
            this.setSectionLineNumberingRestartNewSectionItem1.Caption = "Restart Each Section";
            this.setSectionLineNumberingRestartNewSectionItem1.Enabled = false;
            this.setSectionLineNumberingRestartNewSectionItem1.Id = 153;
            this.setSectionLineNumberingRestartNewSectionItem1.Name = "setSectionLineNumberingRestartNewSectionItem1";
            toolTipTitleItem134.Text = "Restart Each Section";
            toolTipItem134.Text = "Restart Each Section";
            superToolTip134.Items.Add(toolTipTitleItem134);
            superToolTip134.Items.Add(toolTipItem134);
            this.setSectionLineNumberingRestartNewSectionItem1.SuperTip = superToolTip134;
            // 
            // toggleParagraphSuppressLineNumbersItem1
            // 
            this.toggleParagraphSuppressLineNumbersItem1.Caption = "Suppress Line Numbers for Current Paragraph";
            this.toggleParagraphSuppressLineNumbersItem1.Enabled = false;
            this.toggleParagraphSuppressLineNumbersItem1.Id = 154;
            this.toggleParagraphSuppressLineNumbersItem1.Name = "toggleParagraphSuppressLineNumbersItem1";
            toolTipTitleItem135.Text = "Suppress Line Numbers for Current Paragraph";
            toolTipItem135.Text = "Suppress Line Numbers for Current Paragraph";
            superToolTip135.Items.Add(toolTipTitleItem135);
            superToolTip135.Items.Add(toolTipItem135);
            this.toggleParagraphSuppressLineNumbersItem1.SuperTip = superToolTip135;
            // 
            // showLineNumberingFormItem1
            // 
            this.showLineNumberingFormItem1.Caption = "Line Numbering Options";
            this.showLineNumberingFormItem1.Enabled = false;
            this.showLineNumberingFormItem1.Id = 155;
            this.showLineNumberingFormItem1.Name = "showLineNumberingFormItem1";
            toolTipTitleItem136.Text = "Line Numbering Options";
            toolTipItem136.Text = "Line Numbering Options";
            superToolTip136.Items.Add(toolTipTitleItem136);
            superToolTip136.Items.Add(toolTipItem136);
            this.showLineNumberingFormItem1.SuperTip = superToolTip136;
            // 
            // checkSpellingItem1
            // 
            this.checkSpellingItem1.Caption = "Spelling";
            this.checkSpellingItem1.Enabled = false;
            this.checkSpellingItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("checkSpellingItem1.Glyph")));
            this.checkSpellingItem1.Id = 156;
            this.checkSpellingItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("checkSpellingItem1.LargeGlyph")));
            this.checkSpellingItem1.Name = "checkSpellingItem1";
            toolTipTitleItem138.Text = "Spelling";
            toolTipItem138.Text = "Check the spelling of text in the document.";
            superToolTip138.Items.Add(toolTipTitleItem138);
            superToolTip138.Items.Add(toolTipItem138);
            this.checkSpellingItem1.SuperTip = superToolTip138;
            // 
            // protectDocumentItem1
            // 
            this.protectDocumentItem1.Caption = "Protect Document";
            this.protectDocumentItem1.Enabled = false;
            this.protectDocumentItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("protectDocumentItem1.Glyph")));
            this.protectDocumentItem1.Id = 157;
            this.protectDocumentItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("protectDocumentItem1.LargeGlyph")));
            this.protectDocumentItem1.Name = "protectDocumentItem1";
            toolTipTitleItem139.Text = "Protect Document";
            toolTipItem139.Text = "Help restrict people from editing the document by specifying a password.";
            superToolTip139.Items.Add(toolTipTitleItem139);
            superToolTip139.Items.Add(toolTipItem139);
            this.protectDocumentItem1.SuperTip = superToolTip139;
            // 
            // changeRangeEditingPermissionsItem1
            // 
            this.changeRangeEditingPermissionsItem1.Caption = "Range Editing Permissions";
            this.changeRangeEditingPermissionsItem1.Enabled = false;
            this.changeRangeEditingPermissionsItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("changeRangeEditingPermissionsItem1.Glyph")));
            this.changeRangeEditingPermissionsItem1.Id = 158;
            this.changeRangeEditingPermissionsItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("changeRangeEditingPermissionsItem1.LargeGlyph")));
            this.changeRangeEditingPermissionsItem1.Name = "changeRangeEditingPermissionsItem1";
            toolTipTitleItem140.Text = "Range Editing Permissions";
            toolTipItem140.Text = "Range Editing Permissions";
            superToolTip140.Items.Add(toolTipTitleItem140);
            superToolTip140.Items.Add(toolTipItem140);
            this.changeRangeEditingPermissionsItem1.SuperTip = superToolTip140;
            // 
            // unprotectDocumentItem1
            // 
            this.unprotectDocumentItem1.Caption = "Unprotect Document";
            this.unprotectDocumentItem1.Enabled = false;
            this.unprotectDocumentItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("unprotectDocumentItem1.Glyph")));
            this.unprotectDocumentItem1.Id = 159;
            this.unprotectDocumentItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("unprotectDocumentItem1.LargeGlyph")));
            this.unprotectDocumentItem1.Name = "unprotectDocumentItem1";
            toolTipTitleItem141.Text = "Unprotect Document";
            toolTipItem141.Text = "Unprotect Document";
            superToolTip141.Items.Add(toolTipTitleItem141);
            superToolTip141.Items.Add(toolTipItem141);
            this.unprotectDocumentItem1.SuperTip = superToolTip141;
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "テンプレート";
            this.barStaticItem1.Id = 123;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // cboTemplate
            // 
            this.cboTemplate.Caption = "cbo1";
            this.cboTemplate.Edit = this.repositoryItemComboBox1;
            this.cboTemplate.Id = 124;
            this.cboTemplate.Name = "cboTemplate";
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // barStaticItem2
            // 
            this.barStaticItem2.Caption = "表示";
            this.barStaticItem2.Id = 126;
            this.barStaticItem2.Name = "barStaticItem2";
            this.barStaticItem2.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barEditItem1
            // 
            this.barEditItem1.Caption = "hs";
            this.barEditItem1.Edit = this.repositoryItemPictureEdit2;
            this.barEditItem1.Id = 161;
            this.barEditItem1.Name = "barEditItem1";
            // 
            // repositoryItemPictureEdit2
            // 
            this.repositoryItemPictureEdit2.Name = "repositoryItemPictureEdit2";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Img";
            this.barButtonItem1.Id = 189;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // repositoryItemRichEditStyleEdit1
            // 
            this.repositoryItemRichEditStyleEdit1.AutoHeight = false;
            this.repositoryItemRichEditStyleEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemRichEditStyleEdit1.Control = null;
            this.repositoryItemRichEditStyleEdit1.Name = "repositoryItemRichEditStyleEdit1";
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // repositoryItemRichEditStyleEdit2
            // 
            this.repositoryItemRichEditStyleEdit2.AutoHeight = false;
            this.repositoryItemRichEditStyleEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemRichEditStyleEdit2.Control = null;
            this.repositoryItemRichEditStyleEdit2.Name = "repositoryItemRichEditStyleEdit2";
            // 
            // repositoryItemComboBox2
            // 
            this.repositoryItemComboBox2.AutoHeight = false;
            this.repositoryItemComboBox2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox2.Name = "repositoryItemComboBox2";
            // 
            // repositoryItemComboBox4
            // 
            this.repositoryItemComboBox4.AutoHeight = false;
            this.repositoryItemComboBox4.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox4.Name = "repositoryItemComboBox4";
            // 
            // repositoryItemRichEditStyleEdit3
            // 
            this.repositoryItemRichEditStyleEdit3.AutoHeight = false;
            this.repositoryItemRichEditStyleEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemRichEditStyleEdit3.Control = null;
            this.repositoryItemRichEditStyleEdit3.Name = "repositoryItemRichEditStyleEdit3";
            // 
            // richEditBarController1
            // 
            this.richEditBarController1.BarItems.Add(this.cutItem1);
            this.richEditBarController1.BarItems.Add(this.copyItem1);
            this.richEditBarController1.BarItems.Add(this.pasteItem1);
            this.richEditBarController1.BarItems.Add(this.pasteSpecialItem1);
            this.richEditBarController1.BarItems.Add(this.changeFontNameItem1);
            this.richEditBarController1.BarItems.Add(this.changeFontSizeItem1);
            this.richEditBarController1.BarItems.Add(this.changeFontColorItem1);
            this.richEditBarController1.BarItems.Add(this.changeFontBackColorItem1);
            this.richEditBarController1.BarItems.Add(this.toggleFontBoldItem1);
            this.richEditBarController1.BarItems.Add(this.toggleFontItalicItem1);
            this.richEditBarController1.BarItems.Add(this.toggleFontUnderlineItem1);
            this.richEditBarController1.BarItems.Add(this.toggleFontDoubleUnderlineItem1);
            this.richEditBarController1.BarItems.Add(this.toggleFontStrikeoutItem1);
            this.richEditBarController1.BarItems.Add(this.toggleFontDoubleStrikeoutItem1);
            this.richEditBarController1.BarItems.Add(this.toggleFontSubscriptItem1);
            this.richEditBarController1.BarItems.Add(this.changeTextCaseItem1);
            this.richEditBarController1.BarItems.Add(this.makeTextUpperCaseItem1);
            this.richEditBarController1.BarItems.Add(this.makeTextLowerCaseItem1);
            this.richEditBarController1.BarItems.Add(this.toggleTextCaseItem1);
            this.richEditBarController1.BarItems.Add(this.fontSizeIncreaseItem1);
            this.richEditBarController1.BarItems.Add(this.fontSizeDecreaseItem1);
            this.richEditBarController1.BarItems.Add(this.clearFormattingItem1);
            this.richEditBarController1.BarItems.Add(this.showFontFormItem1);
            this.richEditBarController1.BarItems.Add(this.toggleParagraphAlignmentLeftItem1);
            this.richEditBarController1.BarItems.Add(this.toggleParagraphAlignmentCenterItem1);
            this.richEditBarController1.BarItems.Add(this.toggleParagraphAlignmentRightItem1);
            this.richEditBarController1.BarItems.Add(this.toggleParagraphAlignmentJustifyItem1);
            this.richEditBarController1.BarItems.Add(this.changeParagraphLineSpacingItem1);
            this.richEditBarController1.BarItems.Add(this.setSingleParagraphSpacingItem1);
            this.richEditBarController1.BarItems.Add(this.setSesquialteralParagraphSpacingItem1);
            this.richEditBarController1.BarItems.Add(this.setDoubleParagraphSpacingItem1);
            this.richEditBarController1.BarItems.Add(this.showLineSpacingFormItem1);
            this.richEditBarController1.BarItems.Add(this.addSpacingBeforeParagraphItem1);
            this.richEditBarController1.BarItems.Add(this.removeSpacingBeforeParagraphItem1);
            this.richEditBarController1.BarItems.Add(this.addSpacingAfterParagraphItem1);
            this.richEditBarController1.BarItems.Add(this.removeSpacingAfterParagraphItem1);
            this.richEditBarController1.BarItems.Add(this.toggleNumberingListItem1);
            this.richEditBarController1.BarItems.Add(this.toggleMultiLevelListItem1);
            this.richEditBarController1.BarItems.Add(this.decreaseIndentItem1);
            this.richEditBarController1.BarItems.Add(this.increaseIndentItem1);
            this.richEditBarController1.BarItems.Add(this.toggleShowWhitespaceItem1);
            this.richEditBarController1.BarItems.Add(this.showParagraphFormItem1);
            this.richEditBarController1.BarItems.Add(this.findItem1);
            this.richEditBarController1.BarItems.Add(this.replaceItem1);
            this.richEditBarController1.BarItems.Add(this.changeTableCellsShadingItem1);
            this.richEditBarController1.BarItems.Add(this.changeTableBordersItem1);
            this.richEditBarController1.BarItems.Add(this.toggleTableCellsBottomBorderItem1);
            this.richEditBarController1.BarItems.Add(this.toggleTableCellsTopBorderItem1);
            this.richEditBarController1.BarItems.Add(this.toggleTableCellsLeftBorderItem1);
            this.richEditBarController1.BarItems.Add(this.toggleTableCellsRightBorderItem1);
            this.richEditBarController1.BarItems.Add(this.resetTableCellsAllBordersItem1);
            this.richEditBarController1.BarItems.Add(this.toggleTableCellsAllBordersItem1);
            this.richEditBarController1.BarItems.Add(this.toggleTableCellsOutsideBorderItem1);
            this.richEditBarController1.BarItems.Add(this.toggleTableCellsInsideBorderItem1);
            this.richEditBarController1.BarItems.Add(this.toggleTableCellsInsideHorizontalBorderItem1);
            this.richEditBarController1.BarItems.Add(this.toggleTableCellsInsideVerticalBorderItem1);
            this.richEditBarController1.BarItems.Add(this.toggleShowTableGridLinesItem1);
            this.richEditBarController1.BarItems.Add(this.changeTableBorderLineStyleItem1);
            this.richEditBarController1.BarItems.Add(this.changeTableBorderLineWeightItem1);
            this.richEditBarController1.BarItems.Add(this.changeTableBorderColorItem1);
            this.richEditBarController1.BarItems.Add(this.selectTableElementsItem1);
            this.richEditBarController1.BarItems.Add(this.selectTableCellItem1);
            this.richEditBarController1.BarItems.Add(this.selectTableColumnItem1);
            this.richEditBarController1.BarItems.Add(this.selectTableRowItem1);
            this.richEditBarController1.BarItems.Add(this.selectTableItem1);
            this.richEditBarController1.BarItems.Add(this.showTablePropertiesFormItem1);
            this.richEditBarController1.BarItems.Add(this.deleteTableElementsItem1);
            this.richEditBarController1.BarItems.Add(this.showDeleteTableCellsFormItem1);
            this.richEditBarController1.BarItems.Add(this.deleteTableColumnsItem1);
            this.richEditBarController1.BarItems.Add(this.deleteTableRowsItem1);
            this.richEditBarController1.BarItems.Add(this.deleteTableItem1);
            this.richEditBarController1.BarItems.Add(this.insertTableRowAboveItem1);
            this.richEditBarController1.BarItems.Add(this.insertTableRowBelowItem1);
            this.richEditBarController1.BarItems.Add(this.insertTableColumnToLeftItem1);
            this.richEditBarController1.BarItems.Add(this.insertTableColumnToRightItem1);
            this.richEditBarController1.BarItems.Add(this.showInsertTableCellsFormItem1);
            this.richEditBarController1.BarItems.Add(this.mergeTableCellsItem1);
            this.richEditBarController1.BarItems.Add(this.showSplitTableCellsForm1);
            this.richEditBarController1.BarItems.Add(this.splitTableItem1);
            this.richEditBarController1.BarItems.Add(this.toggleTableAutoFitItem1);
            this.richEditBarController1.BarItems.Add(this.toggleTableAutoFitContentsItem1);
            this.richEditBarController1.BarItems.Add(this.toggleTableAutoFitWindowItem1);
            this.richEditBarController1.BarItems.Add(this.toggleTableFixedColumnWidthItem1);
            this.richEditBarController1.BarItems.Add(this.toggleTableCellsTopLeftAlignmentItem1);
            this.richEditBarController1.BarItems.Add(this.toggleTableCellsTopCenterAlignmentItem1);
            this.richEditBarController1.BarItems.Add(this.toggleTableCellsTopRightAlignmentItem1);
            this.richEditBarController1.BarItems.Add(this.toggleTableCellsMiddleLeftAlignmentItem1);
            this.richEditBarController1.BarItems.Add(this.toggleTableCellsMiddleCenterAlignmentItem1);
            this.richEditBarController1.BarItems.Add(this.toggleTableCellsMiddleRightAlignmentItem1);
            this.richEditBarController1.BarItems.Add(this.toggleTableCellsBottomLeftAlignmentItem1);
            this.richEditBarController1.BarItems.Add(this.toggleTableCellsBottomCenterAlignmentItem1);
            this.richEditBarController1.BarItems.Add(this.toggleTableCellsBottomRightAlignmentItem1);
            this.richEditBarController1.BarItems.Add(this.switchToSimpleViewItem1);
            this.richEditBarController1.BarItems.Add(this.switchToDraftViewItem1);
            this.richEditBarController1.BarItems.Add(this.switchToPrintLayoutViewItem1);
            this.richEditBarController1.BarItems.Add(this.toggleShowHorizontalRulerItem1);
            this.richEditBarController1.BarItems.Add(this.toggleShowVerticalRulerItem1);
            this.richEditBarController1.BarItems.Add(this.zoomOutItem1);
            this.richEditBarController1.BarItems.Add(this.zoomInItem1);
            this.richEditBarController1.BarItems.Add(this.toggleBulletedListItem1);
            this.richEditBarController1.BarItems.Add(this.insertPageBreakItem1);
            this.richEditBarController1.BarItems.Add(this.insertTableItem1);
            this.richEditBarController1.BarItems.Add(this.insertPictureItem1);
            this.richEditBarController1.BarItems.Add(this.insertBookmarkItem1);
            this.richEditBarController1.BarItems.Add(this.insertHyperlinkItem1);
            this.richEditBarController1.BarItems.Add(this.editPageHeaderItem1);
            this.richEditBarController1.BarItems.Add(this.editPageFooterItem1);
            this.richEditBarController1.BarItems.Add(this.insertPageNumberItem1);
            this.richEditBarController1.BarItems.Add(this.insertPageCountItem1);
            this.richEditBarController1.BarItems.Add(this.insertSymbolItem1);
            this.richEditBarController1.BarItems.Add(this.changeSectionPageMarginsItem1);
            this.richEditBarController1.BarItems.Add(this.setNormalSectionPageMarginsItem1);
            this.richEditBarController1.BarItems.Add(this.setNarrowSectionPageMarginsItem1);
            this.richEditBarController1.BarItems.Add(this.setModerateSectionPageMarginsItem1);
            this.richEditBarController1.BarItems.Add(this.setWideSectionPageMarginsItem1);
            this.richEditBarController1.BarItems.Add(this.changeSectionPageOrientationItem1);
            this.richEditBarController1.BarItems.Add(this.setPortraitPageOrientationItem1);
            this.richEditBarController1.BarItems.Add(this.setLandscapePageOrientationItem1);
            this.richEditBarController1.BarItems.Add(this.changeSectionPaperKindItem1);
            this.richEditBarController1.BarItems.Add(this.changeSectionColumnsItem1);
            this.richEditBarController1.BarItems.Add(this.setSectionOneColumnItem1);
            this.richEditBarController1.BarItems.Add(this.setSectionTwoColumnsItem1);
            this.richEditBarController1.BarItems.Add(this.setSectionThreeColumnsItem1);
            this.richEditBarController1.BarItems.Add(this.showColumnsSetupFormItem1);
            this.richEditBarController1.BarItems.Add(this.insertBreakItem1);
            this.richEditBarController1.BarItems.Add(this.insertPageBreakItem2);
            this.richEditBarController1.BarItems.Add(this.insertColumnBreakItem1);
            this.richEditBarController1.BarItems.Add(this.insertSectionBreakNextPageItem1);
            this.richEditBarController1.BarItems.Add(this.insertSectionBreakEvenPageItem1);
            this.richEditBarController1.BarItems.Add(this.insertSectionBreakOddPageItem1);
            this.richEditBarController1.BarItems.Add(this.changeSectionLineNumberingItem1);
            this.richEditBarController1.BarItems.Add(this.setSectionLineNumberingNoneItem1);
            this.richEditBarController1.BarItems.Add(this.setSectionLineNumberingContinuousItem1);
            this.richEditBarController1.BarItems.Add(this.setSectionLineNumberingRestartNewPageItem1);
            this.richEditBarController1.BarItems.Add(this.setSectionLineNumberingRestartNewSectionItem1);
            this.richEditBarController1.BarItems.Add(this.toggleParagraphSuppressLineNumbersItem1);
            this.richEditBarController1.BarItems.Add(this.showLineNumberingFormItem1);
            this.richEditBarController1.BarItems.Add(this.checkSpellingItem1);
            this.richEditBarController1.BarItems.Add(this.protectDocumentItem1);
            this.richEditBarController1.BarItems.Add(this.changeRangeEditingPermissionsItem1);
            this.richEditBarController1.BarItems.Add(this.unprotectDocumentItem1);
            // 
            // stylesBar2
            // 
            this.stylesBar2.BarName = "";
            this.stylesBar2.DockCol = 0;
            this.stylesBar2.DockRow = 5;
            this.stylesBar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.stylesBar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.cboTemplate)});
            this.stylesBar2.Text = "";
            // 
            // grdContent
            // 
            this.grdContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdContent.EmbeddedNavigator.Appearance.Options.UseBorderColor = true;
            this.grdContent.Location = new System.Drawing.Point(0, 29);
            this.grdContent.MainView = this.gridView1;
            this.grdContent.Name = "grdContent";
            this.grdContent.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemRichTextEdit1,
            this.repositoryItemMemoEdit1,
            this.repositoryItemComboBox3,
            this.repositoryItemGridLookUpEdit1,
            this.repositoryItemRichTextEdit2,
            this.repositoryItemRichTextEdit3,
            this.repositoryItemTextEdit2,
            this.repositoryItemTextEdit3,
            this.repositoryItemPictureEdit3,
            this.repositoryItemLookUpEdit1,
            this.repositoryItemMemoEdit2});
            this.grdContent.ShowOnlyPredefinedDetails = true;
            this.grdContent.Size = new System.Drawing.Size(728, 462);
            this.grdContent.TabIndex = 5;
            this.grdContent.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.grdContent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdContent_KeyDown);
            // 
            // gridView1
            // 
            this.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTagCode,
            this.colTagName,
            this.colNotes,
            this.CreateDate,
            this.colType});
            this.gridView1.GridControl = this.grdContent;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.RowAutoHeight = true;
            this.gridView1.OptionsView.ShowColumnHeaders = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowIndicator = false;
            this.gridView1.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gridView1_SelectionChanged);
            this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged);
            this.gridView1.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanging);
            this.gridView1.CustomRowCellEdit += new DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventHandler(this.gridView1_CustomRowCellEdit);
            this.gridView1.ColumnChanged += new System.EventHandler(this.gridView1_ColumnChanged);
            // 
            // colTagCode
            // 
            this.colTagCode.Caption = "Tag code";
            this.colTagCode.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.colTagCode.FieldName = "TagCode";
            this.colTagCode.Name = "colTagCode";
            this.colTagCode.OptionsColumn.AllowSize = false;
            this.colTagCode.OptionsColumn.FixedWidth = true;
            this.colTagCode.Visible = true;
            this.colTagCode.VisibleIndex = 0;
            this.colTagCode.Width = 74;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            // 
            // colTagName
            // 
            this.colTagName.Caption = "Tag Name";
            this.colTagName.FieldName = "TagName";
            this.colTagName.Name = "colTagName";
            this.colTagName.OptionsColumn.AllowEdit = false;
            this.colTagName.OptionsColumn.AllowSize = false;
            this.colTagName.OptionsColumn.FixedWidth = true;
            this.colTagName.OptionsColumn.ReadOnly = true;
            this.colTagName.Visible = true;
            this.colTagName.VisibleIndex = 1;
            this.colTagName.Width = 74;
            // 
            // colNotes
            // 
            this.colNotes.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colNotes.AppearanceHeader.Options.UseFont = true;
            this.colNotes.Caption = "Content";
            this.colNotes.ColumnEdit = this.repositoryItemMemoEdit2;
            this.colNotes.FieldName = "Content";
            this.colNotes.Name = "colNotes";
            this.colNotes.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colNotes.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colNotes.OptionsFilter.AllowFilter = false;
            this.colNotes.Visible = true;
            this.colNotes.VisibleIndex = 2;
            this.colNotes.Width = 290;
            // 
            // repositoryItemMemoEdit2
            // 
            this.repositoryItemMemoEdit2.Name = "repositoryItemMemoEdit2";
            // 
            // repositoryItemPictureEdit3
            // 
            this.repositoryItemPictureEdit3.Name = "repositoryItemPictureEdit3";
            // 
            // CreateDate
            // 
            this.CreateDate.Caption = "CreateDate";
            this.CreateDate.FieldName = "CreateDate";
            this.CreateDate.Name = "CreateDate";
            // 
            // colType
            // 
            this.colType.Caption = "Product Type";
            this.colType.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colType.FieldName = "Type";
            this.colType.Name = "colType";
            this.colType.Width = 97;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // repositoryItemRichTextEdit1
            // 
            this.repositoryItemRichTextEdit1.Name = "repositoryItemRichTextEdit1";
            this.repositoryItemRichTextEdit1.ShowCaretInReadOnly = false;
            // 
            // repositoryItemComboBox3
            // 
            this.repositoryItemComboBox3.AutoHeight = false;
            this.repositoryItemComboBox3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox3.Name = "repositoryItemComboBox3";
            // 
            // repositoryItemGridLookUpEdit1
            // 
            this.repositoryItemGridLookUpEdit1.AutoHeight = false;
            this.repositoryItemGridLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit1.Name = "repositoryItemGridLookUpEdit1";
            this.repositoryItemGridLookUpEdit1.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // repositoryItemRichTextEdit2
            // 
            this.repositoryItemRichTextEdit2.Name = "repositoryItemRichTextEdit2";
            this.repositoryItemRichTextEdit2.ShowCaretInReadOnly = false;
            // 
            // repositoryItemRichTextEdit3
            // 
            this.repositoryItemRichTextEdit3.Name = "repositoryItemRichTextEdit3";
            this.repositoryItemRichTextEdit3.ShowCaretInReadOnly = false;
            // 
            // repositoryItemTextEdit2
            // 
            this.repositoryItemTextEdit2.AutoHeight = false;
            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
            // 
            // repositoryItemTextEdit3
            // 
            this.repositoryItemTextEdit3.AutoHeight = false;
            this.repositoryItemTextEdit3.Name = "repositoryItemTextEdit3";
            // 
            // cboTempl1
            // 
            this.cboTempl1.FormattingEnabled = true;
            this.cboTempl1.Location = new System.Drawing.Point(65, 4);
            this.cboTempl1.Name = "cboTempl1";
            this.cboTempl1.Size = new System.Drawing.Size(90, 21);
            this.cboTempl1.TabIndex = 10;
            this.cboTempl1.SelectedIndexChanged += new System.EventHandler(this.cboTempl1_SelectedIndexChanged);
            // 
            // cboDisplay
            // 
            this.cboDisplay.FormattingEnabled = true;
            this.cboDisplay.Location = new System.Drawing.Point(240, 4);
            this.cboDisplay.Name = "cboDisplay";
            this.cboDisplay.Size = new System.Drawing.Size(90, 21);
            this.cboDisplay.TabIndex = 11;
            this.cboDisplay.SelectedIndexChanged += new System.EventHandler(this.cboDisplay_SelectedIndexChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(5, 9);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(54, 13);
            this.labelControl1.TabIndex = 16;
            this.labelControl1.Text = "テンプレート";
            // 
            // insertBookmark
            // 
            this.insertBookmark.Location = new System.Drawing.Point(210, 9);
            this.insertBookmark.Name = "insertBookmark";
            this.insertBookmark.Size = new System.Drawing.Size(24, 13);
            this.insertBookmark.TabIndex = 17;
            this.insertBookmark.Text = "表示";
            // 
            // fileSaveItem2
            // 
            this.fileSaveItem2.Caption = "Save";
            this.fileSaveItem2.Enabled = false;
            this.fileSaveItem2.Glyph = ((System.Drawing.Image)(resources.GetObject("fileSaveItem2.Glyph")));
            this.fileSaveItem2.Id = 105;
            this.fileSaveItem2.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("fileSaveItem2.LargeGlyph")));
            this.fileSaveItem2.Name = "fileSaveItem2";
            toolTipTitleItem142.Text = "Save (Ctrl+S)";
            toolTipItem142.Text = "Save";
            superToolTip142.Items.Add(toolTipTitleItem142);
            superToolTip142.Items.Add(toolTipItem142);
            this.fileSaveItem2.SuperTip = superToolTip142;
            // 
            // commonBar2
            // 
            this.commonBar2.BarName = "";
            this.commonBar2.DockCol = 0;
            this.commonBar2.DockRow = 0;
            this.commonBar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.commonBar2.FloatLocation = new System.Drawing.Point(323, 168);
            this.commonBar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.cboTemplate)});
            this.commonBar2.OptionsBar.AllowQuickCustomization = false;
            this.commonBar2.Text = "";
            // 
            // commonBar3
            // 
            this.commonBar3.BarName = "";
            this.commonBar3.DockCol = 0;
            this.commonBar3.DockRow = 0;
            this.commonBar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.commonBar3.FloatLocation = new System.Drawing.Point(323, 168);
            this.commonBar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.cboTemplate)});
            this.commonBar3.OptionsBar.AllowQuickCustomization = false;
            this.commonBar3.Text = "";
            // 
            // commonBar4
            // 
            this.commonBar4.BarName = "";
            this.commonBar4.DockCol = 0;
            this.commonBar4.DockRow = 0;
            this.commonBar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.commonBar4.FloatLocation = new System.Drawing.Point(323, 168);
            this.commonBar4.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.cboTemplate)});
            this.commonBar4.OptionsBar.AllowQuickCustomization = false;
            this.commonBar4.Text = "";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "edit_16x16.png");
            this.imageList1.Images.SetKeyName(1, "edit_box_24x24.png");
            this.imageList1.Images.SetKeyName(2, "insert-bookmark_16x16.png");
            this.imageList1.Images.SetKeyName(3, "insert-bookmark_box_24x24.png");
            this.imageList1.Images.SetKeyName(4, "insert-image_16x16.png");
            this.imageList1.Images.SetKeyName(5, "insert-image_box_24x24.png");
            this.imageList1.Images.SetKeyName(6, "insert-pdf_16x16.png");
            this.imageList1.Images.SetKeyName(7, "insert-pdf_box_24x24.png");
            this.imageList1.Images.SetKeyName(8, "log_box_24x24.png");
            this.imageList1.Images.SetKeyName(9, "log-history_16x16.png");
            this.imageList1.Images.SetKeyName(10, "print_box_24x24.png");
            this.imageList1.Images.SetKeyName(11, "printer_16x16.png");
            this.imageList1.Images.SetKeyName(12, "refesh_16x16.png");
            this.imageList1.Images.SetKeyName(13, "refesh_box_24x24.png");
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.Images.SetKeyName(0, "file_unlock.png");
            this.imageCollection1.Images.SetKeyName(1, "bar_chart_add.png");
            this.imageCollection1.Images.SetKeyName(2, "chart_remove.png");
            // 
            // dateEdit
            // 
            this.dateEdit.EditValue = null;
            this.dateEdit.Location = new System.Drawing.Point(580, 3);
            this.dateEdit.MenuManager = this.barManager1;
            this.dateEdit.Name = "dateEdit";
            this.dateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEdit.Size = new System.Drawing.Size(94, 20);
            this.dateEdit.TabIndex = 22;
            this.dateEdit.EditValueChanged += new System.EventHandler(this.dateEdit_EditValueChanged);
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dateEdit);
            this.Controls.Add(this.insertBookmark);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cboDisplay);
            this.Controls.Add(this.cboTempl1);
            this.Controls.Add(this.grdContent);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "Editor";
            this.Size = new System.Drawing.Size(728, 514);
            this.Load += new System.EventHandler(this.Editor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemFontEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRichEditFontSizeEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemBorderLineStyle1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemBorderLineWeight1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRichEditStyleEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRichEditStyleEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRichEditStyleEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.richEditBarController1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdContent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRichTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRichTextEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRichTextEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraRichEdit.UI.CutItem cutItem1;
        private DevExpress.XtraRichEdit.UI.CopyItem copyItem1;
        private DevExpress.XtraRichEdit.UI.PasteItem pasteItem1;
        private DevExpress.XtraRichEdit.UI.PasteSpecialItem pasteSpecialItem1;
        private DevExpress.XtraRichEdit.UI.ChangeFontNameItem changeFontNameItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemFontEdit repositoryItemFontEdit1;
        private DevExpress.XtraRichEdit.UI.ChangeFontSizeItem changeFontSizeItem1;
        private DevExpress.XtraRichEdit.Design.RepositoryItemRichEditFontSizeEdit repositoryItemRichEditFontSizeEdit1;
        private DevExpress.XtraRichEdit.UI.ChangeFontColorItem changeFontColorItem1;
        private DevExpress.XtraRichEdit.UI.ChangeFontBackColorItem changeFontBackColorItem1;
        private DevExpress.XtraRichEdit.UI.ToggleFontBoldItem toggleFontBoldItem1;
        private DevExpress.XtraRichEdit.UI.ToggleFontItalicItem toggleFontItalicItem1;
        private DevExpress.XtraRichEdit.UI.ToggleFontUnderlineItem toggleFontUnderlineItem1;
        private DevExpress.XtraRichEdit.UI.ToggleFontDoubleUnderlineItem toggleFontDoubleUnderlineItem1;
        private DevExpress.XtraRichEdit.UI.ToggleFontStrikeoutItem toggleFontStrikeoutItem1;
        private DevExpress.XtraRichEdit.UI.ToggleFontDoubleStrikeoutItem toggleFontDoubleStrikeoutItem1;
        private DevExpress.XtraRichEdit.UI.ToggleFontSubscriptItem toggleFontSubscriptItem1;
        private DevExpress.XtraRichEdit.UI.ChangeTextCaseItem changeTextCaseItem1;
        private DevExpress.XtraRichEdit.UI.MakeTextUpperCaseItem makeTextUpperCaseItem1;
        private DevExpress.XtraRichEdit.UI.MakeTextLowerCaseItem makeTextLowerCaseItem1;
        private DevExpress.XtraRichEdit.UI.ToggleTextCaseItem toggleTextCaseItem1;
        private DevExpress.XtraRichEdit.UI.FontSizeIncreaseItem fontSizeIncreaseItem1;
        private DevExpress.XtraRichEdit.UI.FontSizeDecreaseItem fontSizeDecreaseItem1;
        private DevExpress.XtraRichEdit.UI.ClearFormattingItem clearFormattingItem1;
        private DevExpress.XtraRichEdit.UI.ShowFontFormItem showFontFormItem1;
        private DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentLeftItem toggleParagraphAlignmentLeftItem1;
        private DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentCenterItem toggleParagraphAlignmentCenterItem1;
        private DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentRightItem toggleParagraphAlignmentRightItem1;
        private DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentJustifyItem toggleParagraphAlignmentJustifyItem1;
        private DevExpress.XtraRichEdit.UI.ChangeParagraphLineSpacingItem changeParagraphLineSpacingItem1;
        private DevExpress.XtraRichEdit.UI.SetSingleParagraphSpacingItem setSingleParagraphSpacingItem1;
        private DevExpress.XtraRichEdit.UI.SetSesquialteralParagraphSpacingItem setSesquialteralParagraphSpacingItem1;
        private DevExpress.XtraRichEdit.UI.SetDoubleParagraphSpacingItem setDoubleParagraphSpacingItem1;
        private DevExpress.XtraRichEdit.UI.ShowLineSpacingFormItem showLineSpacingFormItem1;
        private DevExpress.XtraRichEdit.UI.AddSpacingBeforeParagraphItem addSpacingBeforeParagraphItem1;
        private DevExpress.XtraRichEdit.UI.RemoveSpacingBeforeParagraphItem removeSpacingBeforeParagraphItem1;
        private DevExpress.XtraRichEdit.UI.AddSpacingAfterParagraphItem addSpacingAfterParagraphItem1;
        private DevExpress.XtraRichEdit.UI.RemoveSpacingAfterParagraphItem removeSpacingAfterParagraphItem1;
        private DevExpress.XtraRichEdit.UI.ToggleNumberingListItem toggleNumberingListItem1;
        private DevExpress.XtraRichEdit.UI.ToggleMultiLevelListItem toggleMultiLevelListItem1;
        private DevExpress.XtraRichEdit.UI.DecreaseIndentItem decreaseIndentItem1;
        private DevExpress.XtraRichEdit.UI.IncreaseIndentItem increaseIndentItem1;
        private DevExpress.XtraRichEdit.UI.ToggleShowWhitespaceItem toggleShowWhitespaceItem1;
        private DevExpress.XtraRichEdit.UI.ShowParagraphFormItem showParagraphFormItem1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraRichEdit.Design.RepositoryItemRichEditStyleEdit repositoryItemRichEditStyleEdit1;
        private DevExpress.XtraRichEdit.UI.FindItem findItem1;
        private DevExpress.XtraRichEdit.UI.ReplaceItem replaceItem1;
        private DevExpress.XtraRichEdit.UI.ChangeTableCellsShadingItem changeTableCellsShadingItem1;
        private DevExpress.XtraRichEdit.UI.ChangeTableBordersItem changeTableBordersItem1;
        private DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomBorderItem toggleTableCellsBottomBorderItem1;
        private DevExpress.XtraRichEdit.UI.ToggleTableCellsTopBorderItem toggleTableCellsTopBorderItem1;
        private DevExpress.XtraRichEdit.UI.ToggleTableCellsLeftBorderItem toggleTableCellsLeftBorderItem1;
        private DevExpress.XtraRichEdit.UI.ToggleTableCellsRightBorderItem toggleTableCellsRightBorderItem1;
        private DevExpress.XtraRichEdit.UI.ResetTableCellsAllBordersItem resetTableCellsAllBordersItem1;
        private DevExpress.XtraRichEdit.UI.ToggleTableCellsAllBordersItem toggleTableCellsAllBordersItem1;
        private DevExpress.XtraRichEdit.UI.ToggleTableCellsOutsideBorderItem toggleTableCellsOutsideBorderItem1;
        private DevExpress.XtraRichEdit.UI.ToggleTableCellsInsideBorderItem toggleTableCellsInsideBorderItem1;
        private DevExpress.XtraRichEdit.UI.ToggleTableCellsInsideHorizontalBorderItem toggleTableCellsInsideHorizontalBorderItem1;
        private DevExpress.XtraRichEdit.UI.ToggleTableCellsInsideVerticalBorderItem toggleTableCellsInsideVerticalBorderItem1;
        private DevExpress.XtraRichEdit.UI.ToggleShowTableGridLinesItem toggleShowTableGridLinesItem1;
        private DevExpress.XtraRichEdit.UI.ChangeTableBorderLineStyleItem changeTableBorderLineStyleItem1;
        private DevExpress.XtraRichEdit.Forms.Design.RepositoryItemBorderLineStyle repositoryItemBorderLineStyle1;
        private DevExpress.XtraRichEdit.UI.ChangeTableBorderLineWeightItem changeTableBorderLineWeightItem1;
        private DevExpress.XtraRichEdit.Forms.Design.RepositoryItemBorderLineWeight repositoryItemBorderLineWeight1;
        private DevExpress.XtraRichEdit.UI.ChangeTableBorderColorItem changeTableBorderColorItem1;
        private DevExpress.XtraRichEdit.UI.SelectTableElementsItem selectTableElementsItem1;
        private DevExpress.XtraRichEdit.UI.SelectTableCellItem selectTableCellItem1;
        private DevExpress.XtraRichEdit.UI.SelectTableColumnItem selectTableColumnItem1;
        private DevExpress.XtraRichEdit.UI.SelectTableRowItem selectTableRowItem1;
        private DevExpress.XtraRichEdit.UI.SelectTableItem selectTableItem1;
        private DevExpress.XtraRichEdit.UI.ShowTablePropertiesFormItem showTablePropertiesFormItem1;
        private DevExpress.XtraRichEdit.UI.DeleteTableElementsItem deleteTableElementsItem1;
        private DevExpress.XtraRichEdit.UI.ShowDeleteTableCellsFormItem showDeleteTableCellsFormItem1;
        private DevExpress.XtraRichEdit.UI.DeleteTableColumnsItem deleteTableColumnsItem1;
        private DevExpress.XtraRichEdit.UI.DeleteTableRowsItem deleteTableRowsItem1;
        private DevExpress.XtraRichEdit.UI.DeleteTableItem deleteTableItem1;
        private DevExpress.XtraRichEdit.UI.InsertTableRowAboveItem insertTableRowAboveItem1;
        private DevExpress.XtraRichEdit.UI.InsertTableRowBelowItem insertTableRowBelowItem1;
        private DevExpress.XtraRichEdit.UI.InsertTableColumnToLeftItem insertTableColumnToLeftItem1;
        private DevExpress.XtraRichEdit.UI.InsertTableColumnToRightItem insertTableColumnToRightItem1;
        private DevExpress.XtraRichEdit.UI.ShowInsertTableCellsFormItem showInsertTableCellsFormItem1;
        private DevExpress.XtraRichEdit.UI.MergeTableCellsItem mergeTableCellsItem1;
        private DevExpress.XtraRichEdit.UI.ShowSplitTableCellsForm showSplitTableCellsForm1;
        private DevExpress.XtraRichEdit.UI.SplitTableItem splitTableItem1;
        private DevExpress.XtraRichEdit.UI.ToggleTableAutoFitItem toggleTableAutoFitItem1;
        private DevExpress.XtraRichEdit.UI.ToggleTableAutoFitContentsItem toggleTableAutoFitContentsItem1;
        private DevExpress.XtraRichEdit.UI.ToggleTableAutoFitWindowItem toggleTableAutoFitWindowItem1;
        private DevExpress.XtraRichEdit.UI.ToggleTableFixedColumnWidthItem toggleTableFixedColumnWidthItem1;
        private DevExpress.XtraRichEdit.UI.ToggleTableCellsTopLeftAlignmentItem toggleTableCellsTopLeftAlignmentItem1;
        private DevExpress.XtraRichEdit.UI.ToggleTableCellsTopCenterAlignmentItem toggleTableCellsTopCenterAlignmentItem1;
        private DevExpress.XtraRichEdit.UI.ToggleTableCellsTopRightAlignmentItem toggleTableCellsTopRightAlignmentItem1;
        private DevExpress.XtraRichEdit.UI.ToggleTableCellsMiddleLeftAlignmentItem toggleTableCellsMiddleLeftAlignmentItem1;
        private DevExpress.XtraRichEdit.UI.ToggleTableCellsMiddleCenterAlignmentItem toggleTableCellsMiddleCenterAlignmentItem1;
        private DevExpress.XtraRichEdit.UI.ToggleTableCellsMiddleRightAlignmentItem toggleTableCellsMiddleRightAlignmentItem1;
        private DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomLeftAlignmentItem toggleTableCellsBottomLeftAlignmentItem1;
        private DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomCenterAlignmentItem toggleTableCellsBottomCenterAlignmentItem1;
        private DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomRightAlignmentItem toggleTableCellsBottomRightAlignmentItem1;
        private DevExpress.XtraRichEdit.UI.SwitchToSimpleViewItem switchToSimpleViewItem1;
        private DevExpress.XtraRichEdit.UI.SwitchToDraftViewItem switchToDraftViewItem1;
        private DevExpress.XtraRichEdit.UI.SwitchToPrintLayoutViewItem switchToPrintLayoutViewItem1;
        private DevExpress.XtraRichEdit.UI.ToggleShowHorizontalRulerItem toggleShowHorizontalRulerItem1;
        private DevExpress.XtraRichEdit.UI.ToggleShowVerticalRulerItem toggleShowVerticalRulerItem1;
        private DevExpress.XtraRichEdit.UI.ZoomOutItem zoomOutItem1;
        private DevExpress.XtraRichEdit.UI.ZoomInItem zoomInItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraRichEdit.UI.RichEditBarController richEditBarController1;
        private DevExpress.XtraRichEdit.UI.ToggleBulletedListItem toggleBulletedListItem1;
        private DevExpress.XtraRichEdit.UI.InsertPageBreakItem insertPageBreakItem1;
        private DevExpress.XtraRichEdit.UI.InsertTableItem insertTableItem1;
        private DevExpress.XtraRichEdit.UI.InsertPictureItem insertPictureItem1;
        private DevExpress.XtraRichEdit.UI.InsertBookmarkItem insertBookmarkItem1;
        private DevExpress.XtraRichEdit.UI.InsertHyperlinkItem insertHyperlinkItem1;
        private DevExpress.XtraRichEdit.UI.EditPageHeaderItem editPageHeaderItem1;
        private DevExpress.XtraRichEdit.UI.EditPageFooterItem editPageFooterItem1;
        private DevExpress.XtraRichEdit.UI.InsertPageNumberItem insertPageNumberItem1;
        private DevExpress.XtraRichEdit.UI.InsertPageCountItem insertPageCountItem1;
        private DevExpress.XtraRichEdit.UI.InsertSymbolItem insertSymbolItem1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarEditItem cboTemplate;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem2;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox2;
        private DevExpress.XtraRichEdit.UI.ChangeSectionPageMarginsItem changeSectionPageMarginsItem1;
        private DevExpress.XtraRichEdit.UI.SetNormalSectionPageMarginsItem setNormalSectionPageMarginsItem1;
        private DevExpress.XtraRichEdit.UI.SetNarrowSectionPageMarginsItem setNarrowSectionPageMarginsItem1;
        private DevExpress.XtraRichEdit.UI.SetModerateSectionPageMarginsItem setModerateSectionPageMarginsItem1;
        private DevExpress.XtraRichEdit.UI.SetWideSectionPageMarginsItem setWideSectionPageMarginsItem1;
        private DevExpress.XtraRichEdit.UI.ChangeSectionPageOrientationItem changeSectionPageOrientationItem1;
        private DevExpress.XtraRichEdit.UI.SetPortraitPageOrientationItem setPortraitPageOrientationItem1;
        private DevExpress.XtraRichEdit.UI.SetLandscapePageOrientationItem setLandscapePageOrientationItem1;
        private DevExpress.XtraRichEdit.UI.ChangeSectionPaperKindItem changeSectionPaperKindItem1;
        private DevExpress.XtraRichEdit.UI.ChangeSectionColumnsItem changeSectionColumnsItem1;
        private DevExpress.XtraRichEdit.UI.SetSectionOneColumnItem setSectionOneColumnItem1;
        private DevExpress.XtraRichEdit.UI.SetSectionTwoColumnsItem setSectionTwoColumnsItem1;
        private DevExpress.XtraRichEdit.UI.SetSectionThreeColumnsItem setSectionThreeColumnsItem1;
        private DevExpress.XtraRichEdit.UI.ShowColumnsSetupFormItem showColumnsSetupFormItem1;
        private DevExpress.XtraRichEdit.UI.InsertBreakItem insertBreakItem1;
        private DevExpress.XtraRichEdit.UI.InsertPageBreakItem insertPageBreakItem2;
        private DevExpress.XtraRichEdit.UI.InsertColumnBreakItem insertColumnBreakItem1;
        private DevExpress.XtraRichEdit.UI.InsertSectionBreakNextPageItem insertSectionBreakNextPageItem1;
        private DevExpress.XtraRichEdit.UI.InsertSectionBreakEvenPageItem insertSectionBreakEvenPageItem1;
        private DevExpress.XtraRichEdit.UI.InsertSectionBreakOddPageItem insertSectionBreakOddPageItem1;
        private DevExpress.XtraRichEdit.UI.ChangeSectionLineNumberingItem changeSectionLineNumberingItem1;
        private DevExpress.XtraRichEdit.UI.SetSectionLineNumberingNoneItem setSectionLineNumberingNoneItem1;
        private DevExpress.XtraRichEdit.UI.SetSectionLineNumberingContinuousItem setSectionLineNumberingContinuousItem1;
        private DevExpress.XtraRichEdit.UI.SetSectionLineNumberingRestartNewPageItem setSectionLineNumberingRestartNewPageItem1;
        private DevExpress.XtraRichEdit.UI.SetSectionLineNumberingRestartNewSectionItem setSectionLineNumberingRestartNewSectionItem1;
        private DevExpress.XtraRichEdit.UI.ToggleParagraphSuppressLineNumbersItem toggleParagraphSuppressLineNumbersItem1;
        private DevExpress.XtraRichEdit.UI.ShowLineNumberingFormItem showLineNumberingFormItem1;
        private DevExpress.XtraRichEdit.UI.CheckSpellingItem checkSpellingItem1;
        private DevExpress.XtraRichEdit.UI.ProtectDocumentItem protectDocumentItem1;
        private DevExpress.XtraRichEdit.UI.ChangeRangeEditingPermissionsItem changeRangeEditingPermissionsItem1;
        private DevExpress.XtraRichEdit.UI.UnprotectDocumentItem unprotectDocumentItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraRichEdit.Design.RepositoryItemRichEditStyleEdit repositoryItemRichEditStyleEdit2;
        private DevExpress.XtraRichEdit.UI.StylesBar stylesBar2;
        private DevExpress.XtraGrid.GridControl grdContent;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colType;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colNotes;
        private DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit repositoryItemRichTextEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colTagCode;
        private DevExpress.XtraGrid.Columns.GridColumn colTagName;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox3;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox4;
        private System.Windows.Forms.ComboBox cboDisplay;
        private System.Windows.Forms.ComboBox cboTempl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl insertBookmark;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraRichEdit.UI.FileSaveItem fileSaveItem2;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit2;
        private DevExpress.XtraRichEdit.UI.CommonBar commonBar2;
        private DevExpress.XtraRichEdit.UI.CommonBar commonBar3;
        private DevExpress.XtraRichEdit.UI.CommonBar commonBar4;
        private DevExpress.XtraRichEdit.Design.RepositoryItemRichEditStyleEdit repositoryItemRichEditStyleEdit3;
        private System.Windows.Forms.ImageList imageList1;
        private RepositoryItemRichTextEdit repositoryItemRichTextEdit2;
        private RepositoryItemRichTextEdit repositoryItemRichTextEdit3;
        private RepositoryItemTextEdit repositoryItemTextEdit2;
        private RepositoryItemTextEdit repositoryItemTextEdit3;
        private DevExpress.XtraBars.BarButtonItem insertPdfItem;
        private DevExpress.XtraBars.BarButtonItem insertImage1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private RepositoryItemPictureEdit repositoryItemPictureEdit3;
        private DevExpress.Utils.ImageCollection imageCollection1;
        private RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn CreateDate;
        private DevExpress.XtraEditors.DateEdit dateEdit;
        private RepositoryItemMemoEdit repositoryItemMemoEdit2;
        //private DevExpress.CodeRush.Controls.Utils.ToolTipController toolTipController1;
        public DevExpress.XtraRichEdit.UI.CommonBar commonBar1;

        #endregion

        #region Constructor
        public Editor()
        {
            InitializeComponent();
            this.insertPdfItem.Enabled = true;
            this.insertImage1.Enabled = true;
            this.insertBookmark.Enabled = true;
            gridView1.BorderStyle = BorderStyles.NoBorder;
            gridView1.CustomRowCellEdit -= new CustomRowCellEditEventHandler(gridView1_CustomRowCellEdit);
            cboTempl1.SelectedIndexChanged -= new System.EventHandler(cboTempl1_SelectedIndexChanged);
            LoadCombobox();

            LoadGrid();
            //grdContent.DataSource = DataCreator.CreateDataGrid(20);
            gridView1.CustomRowCellEdit += new CustomRowCellEditEventHandler(gridView1_CustomRowCellEdit);
            cboTempl1.SelectedIndexChanged += new System.EventHandler(cboTempl1_SelectedIndexChanged);
        }

        #endregion End Constructor

        #region Model & Fields & Properties
        private string Bunho = "000000128";

        //public IMainScreen _mainScreen;
        //private string _bunho = "";
        //public string Bunho
        //{
        //    get { return _mainScreen == null ? _bunho : _mainScreen.MSelectedPatientInfo.Parameter.Bunho; }
        //    set { _bunho = value; }
        //}

        private Dictionary<string, string> hashFileNameDict = new Dictionary<string, string>();

        public Dictionary<string, string> HashFileNameDict
        {
            get { return hashFileNameDict; }
            set { hashFileNameDict = value; }
        }

        List<string> _newlyAddedImages = new List<string>();
        private Dictionary<string, Meta.UserData> metaDictionary = new Dictionary<string, Meta.UserData>();
        #endregion End Fields & Properties

        #region Event

        //private void grdContent_Load(object sender, EventArgs e)
        //{
        //    LoadGrid();
        //    grdContent.DataSource = DataCreator.CreateDataGrid(20);
        //    gridView1.CustomRowCellEdit += new CustomRowCellEditEventHandler(gridView1_CustomRowCellEdit);
        //}

        private void cboDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {
            int objSelected;
            Int32.TryParse(Convert.ToString(cboDisplay.SelectedValue), out objSelected);

            //int objSelected = (int)cboDisplay.SelectedValue;
            if (objSelected == 0)
            {
                gridView1.Columns["TagCode"].Visible = true;
                gridView1.Columns["TagName"].Visible = true;
            }
            else if (objSelected == 1)
            {
                gridView1.Columns["TagCode"].Visible = false;
                gridView1.Columns["TagName"].Visible = true;
            }
            else if (objSelected == 2)
            {
                gridView1.Columns["TagCode"].Visible = true;
                gridView1.Columns["TagName"].Visible = false;
            }
        }

        private void Editor_Load(object sender, EventArgs e)
        {
            RepositoryItemLookUpEdit popEdit = new RepositoryItemLookUpEdit();
            popEdit.DataSource = DataCreator.CboTagData();
            popEdit.DisplayMember = "DisplayId";
            //popEdit.ValueMember = "Value";            
            popEdit.ValueMember = "DisplayId";
            //popEdit.SearchMode = SearchMode.AutoComplete;
            popEdit.AutoSearchColumnIndex = 2;
            gridView1.Columns["TagCode"].ColumnEdit = popEdit;
        }

        private void grdContent_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Control | e.KeyCode == Keys.N)
            {
                int selectedRowIndex = gridView1.FocusedRowHandle;
                DataTable dt = grdContent.DataSource as DataTable;
                DataRow newRow = dt != null ? dt.NewRow() : null;
                if (newRow == null) return;
                newRow["TagCode"] = "";
                newRow["TagName"] = "";
                newRow["Content"] = "";
                newRow["CreateDate"] = DateTime.Now.ToString("yyyy/MM/dd");

                dt.Rows.InsertAt(newRow, selectedRowIndex + 1);
                //gridView1.AddNewRow();
                gridView1.FocusedRowHandle = gridView1.GetRowHandle(selectedRowIndex + 1);
            }
            if (e.KeyCode == Keys.Delete)
            {
                gridView1.DeleteSelectedRows();
            }
        }

        private void gridView1_CustomRowCellEdit(object sender, CustomRowCellEditEventArgs e)
        {
            gridView1.CustomRowCellEdit -= new CustomRowCellEditEventHandler(gridView1_CustomRowCellEdit);

            if (e.Column.FieldName == "Content")
            {
                int img = !string.IsNullOrEmpty(gridView1.GetRowCellValue(e.RowHandle, "Type").ToString()) ? Int32.Parse(gridView1.GetRowCellValue(e.RowHandle, "Type").ToString()) : -1;
                if (img == -1)
                {
                    gridView1.CustomRowCellEdit += new CustomRowCellEditEventHandler(gridView1_CustomRowCellEdit);
                    return;
                }
                if (img == 0)
                    e.RepositoryItem = repositoryItemMemoEdit1;
                else
                {
                    e.RepositoryItem = repositoryItemPictureEdit3;
                }
            }

            #region forCbo
            //RepositoryItemComboBox cboColumnGrd;
            //cboColumnGrd = new RepositoryItemComboBox();
            //cboColumnGrd.Items.Add("One");
            //gridView1.Columns["TagCode"].ColumnEdit = cboColumnGrd;

            //cboColumnGrd.Items.Clear();
            //cboColumnGrd.Items.Add("S");
            //cboColumnGrd.Items.Add("AN");
            //cboColumnGrd.Items.Add("FH");
            //cboColumnGrd.Items.Add("LH");
            //cboColumnGrd.Items.Add("O");
            //cboColumnGrd.Items.Add("A");
            //cboColumnGrd.Items.Add("MI");
            //cboColumnGrd.Items.Add("MA");
            //cboColumnGrd.Items.Add("P");
            //cboColumnGrd.Items.Add("Tx");
            //cboColumnGrd.Items.Add("Dx");
            //cboColumnGrd.Items.Add("Ex");
            #endregion

            #region for LookUpEditCtrl
            //RepositoryItemLookUpEdit popEdit = new RepositoryItemLookUpEdit();
            //popEdit.DataSource = DataCreator.CboTagData();
            //popEdit.DisplayMember = "DisplayId";
            ////popEdit.ValueMember = "Value";            
            //popEdit.ValueMember = "DisplayId";
            ////popEdit.SearchMode = SearchMode.AutoComplete;
            //popEdit.AutoSearchColumnIndex = 2;
            //gridView1.Columns["TagCode"].ColumnEdit = popEdit;

            //Dictionary<string, string> dicConvert = DataCreator.DicConvertTag();
            //if (e.Column.Name == colTagCode.Name)
            //{
            //    if (dicConvert.ContainsKey(e.ToString()))
            //    {
            //        string value = dicConvert[e.ToString()];
            //        gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "TagName", value);
            //    }
            //}
            #endregion

            gridView1.CustomRowCellEdit += new CustomRowCellEditEventHandler(gridView1_CustomRowCellEdit);
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            //gridView1.CellValueChanged -= gridView1_CellValueChanged;

            //try
            //{
            //    LoadTagName(e);
            //}
            //catch
            //{
            //    throw;
            //}
            //finally
            //{
            //    gridView1.CellValueChanged += gridView1_CellValueChanged;
            //}
        }

        private void gridView1_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                LoadTagName(e);
            }
            catch
            {
                throw;
            }
            finally
            {
            }
        }

        private void gridView1_ColumnChanged(object sender, EventArgs e)
        {

        }

        #region insertPdfItem_ItemClick
        private void insertPdfItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //DocumentPosition pos = richEditControl.Document.Selection == null ? richEditControl.Document.CreatePosition(0) : richEditControl.Document.Selection.Start;
            int selectedRowIndex = gridView1.FocusedRowHandle;

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Pdf Files|*.pdf";
            dialog.FilterIndex = 1;
            dialog.RestoreDirectory = true;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string ext = Path.GetExtension(dialog.FileName);
                if (ext.ToLower() == ".pdf")
                {
                    //InsertPdfFile(dialog.FileName, pos, true);
                    InsertPdfFile(dialog.FileName, selectedRowIndex, true);
                }
            }
        }
        #endregion

        #region insertImage1_ItemClick
        private void insertImage1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //AddNewRow("", "", "Test");

            //DocumentPosition pos = richEditControl.Document.Selection == null ? richEditControl.Document.CreatePosition(0) : richEditControl.Document.Selection.Start;
            int selectedRowIndex = gridView1.FocusedRowHandle;
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            dialog.FilterIndex = 1;
            dialog.RestoreDirectory = true;
            dialog.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory + "\\CLIP";

            if (dialog.ShowDialog() == DialogResult.OK && File.Exists(dialog.FileName))
            {
                //richEditControl.Document.BeginUpdate();
                //DocumentImage docImage = richEditControl.Document.InsertImage(pos, new FileDocumentImageSource(dialog.FileName));

                //docImage.Size = GetImageSizeF(docImage, richEditControl);

                //docImage.Uri = dialog.FileName;
                //richEditControl.Document.EndUpdate();

                //string imageHash = CalculateImageChecksum(docImage.Image);

                //if (!hashFileNameDict.ContainsKey(imageHash))
                //{
                //    hashFileNameDict.Add(imageHash, dialog.FileName);
                //}
                //EditImage(docImage);
                AddNewRow("", "", "Image", dialog.FileName);
            }
        }

        #endregion

        private void gridView1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            //int a = 0;
        }

        private void dateEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(dateEdit.Text))
            {
                grdContent.DataSource = null;
                grdContent.DataSource = DataCreator.CreateDataGrid(20, "", false);
                grdContent.Refresh();
            }
            else
            {
                DateTime dt = Convert.ToDateTime(dateEdit.Text);
                string dtConvert = dt.ToString("yyyy/MM/dd");
                //for (int i = 0; i < gridView1.DataRowCount; i++)
                //{
                //    DataRow row = gridView1.GetDataRow(i);
                //    if (row["CreateDate"].ToString() == dtConvert)
                //    {

                //    }
                //}

                DataTable dt1 = DataCreator.CreateDataGrid(20, "", false);

                DataTable dataSortBy = dt1.Clone();

                foreach (DataRow itemData in dt1.Rows)
                {
                    if (itemData["CreateDate"].ToString() == dtConvert)
                    {
                        dataSortBy.ImportRow(itemData);
                    }
                }

                grdContent.DataSource = dataSortBy;
                grdContent.Refresh();
            }
        }


        private void cboTempl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboTempl1.SelectedIndexChanged -= new System.EventHandler(cboTempl1_SelectedIndexChanged);
            DialogResult result = MessageBox.Show("Change Template, your content will be removed. Do you want change Template?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (!result.Equals(DialogResult.OK))
            {
                cboTempl1.SelectedIndexChanged += new System.EventHandler(cboTempl1_SelectedIndexChanged);
                return;
            }

            int objSelected;
            Int32.TryParse(Convert.ToString(cboTempl1.SelectedValue), out objSelected);
            if (objSelected == -1)
            {
                grdContent.DataSource = DataCreator.CreateDataGrid(20, "", true);
            }
            else
            {
                DataTable dt1 = DataCreator.CreateDataGrid(20, "", true);
                DataTable dataSortBy = dt1.Clone();
                int check = 0;
                foreach (DataRow itemData in dt1.Rows)
                {
                    if (check == objSelected) break;
                    dataSortBy.ImportRow(itemData);
                    check++;
                }
                grdContent.DataSource = dataSortBy;
            }
            cboTempl1.SelectedIndexChanged += new System.EventHandler(cboTempl1_SelectedIndexChanged);
        }

        #endregion endEvent

        #region Method
        #region Load combobox
        //Load combobox
        private void LoadCombobox()
        {
            cboDisplay.SelectedIndexChanged -= new EventHandler(cboDisplay_SelectedIndexChanged);

            cboTempl1.DataSource = DataCreator.CreateTemplateData();
            cboTempl1.DisplayMember = "DisplayId";
            cboTempl1.ValueMember = "Value";

            cboDisplay.DataSource = DataCreator.CreateDisplayTagData();
            cboDisplay.DisplayMember = "DisplayId";
            cboDisplay.ValueMember = "Value";

            cboDisplay.SelectedIndexChanged += new EventHandler(cboDisplay_SelectedIndexChanged);

        }
        #endregion

        #region LoadGrid
        //Load Grid
        private void LoadGrid()
        {
            gridView1.CustomRowCellEdit -= new CustomRowCellEditEventHandler(gridView1_CustomRowCellEdit);
            gridView1.BorderStyle = BorderStyles.NoBorder;
            grdContent.DataSource = DataCreator.CreateDataGrid(20, "", false);
            gridView1.CustomRowCellEdit += new CustomRowCellEditEventHandler(gridView1_CustomRowCellEdit);
            gridView1.OptionsView.ShowGroupPanel = false;
            gridView1.OptionsView.ShowIndicator = false;
            gridView1.OptionsView.ShowHorzLines = false;
            gridView1.OptionsView.ShowVertLines = false;
        }
        #endregion

        #region GetImageSizeF
        private static SizeF GetImageSizeF(DocumentImage img, RichEditControl richEditContrl)
        {
            float pageWidth = richEditContrl.Document.Sections[0].Page.Width - richEditContrl.Document.Sections[0].Margins.Left - richEditContrl.Document.Sections[0].Margins.Right;
            float pageHeight = richEditContrl.Document.Sections[0].Page.Height - richEditContrl.Document.Sections[0].Margins.Top - richEditContrl.Document.Sections[0].Margins.Bottom;

            float imgHeight = img.Size.Height;
            float imgWidth = img.Size.Width;
            if (imgWidth > pageWidth || imgHeight > pageHeight)
            {
                float ratio = Math.Min(imgWidth / pageWidth, imgHeight / pageHeight);
                ratio = ratio > 1 ? 1 / (Math.Max(imgWidth / pageWidth, imgHeight / pageHeight)) : ratio;
                return new SizeF(imgWidth * ratio, imgHeight * ratio);
            }
            return img.Size;
        }
        #endregion

        private static readonly MD5 md5 = MD5.Create();

        #region CalculateImageChecksum
        private static string CalculateImageChecksum(Stream image)
        {
            byte[] checksum = md5.ComputeHash(image);
            return BitConverter.ToString(checksum);
        }
        #endregion

        #region GetPdfThumbnail
        private FileDocumentImageSource GetPdfThumbnail(string pdfFilePath, out string thumbnailFilePath)
        {
            thumbnailFilePath = Utilities.GetAbsoluteDataPath(Utilities.NextSequence(Bunho, Path.GetFileNameWithoutExtension(pdfFilePath), "jpeg"), Bunho);
            try
            {
                GhostscriptWrapper.GeneratePageThumb(pdfFilePath, thumbnailFilePath, 1, 24, 24);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
            return new FileDocumentImageSource(thumbnailFilePath);
        }

        #endregion

        #region CheckPdfUploadFile
        private static bool CheckPdfUploadFile(string fileName)
        {
            try
            {
                //if (string.IsNullOrEmpty(fileName) || !File.Exists(fileName) || string.IsNullOrEmpty(DataProvider.Instance.Pdf_max_size)) return false;                
                if (string.IsNullOrEmpty(fileName) || !File.Exists(fileName)) return false;
                //Double confSize = Double.Parse(DataProvider.Instance.Pdf_max_size);
                FileInfo fileInfo = new FileInfo(fileName);
                //return (double)fileInfo.Length / (1024 * 1024) > confSize ? false : true;                
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
                return false;
            }
        }
        #endregion

        #region InsertPdfFile
        //private void InsertPdfFile(string originalFilePath, DocumentPosition pos, bool beginEndBlock)        
        private void InsertPdfFile(string originalFilePath, int pos, bool beginEndBlock)
        {
            if (!CheckPdfUploadFile(originalFilePath))
            {
                //MessageBox.Show(string.Format(Resources.EMR_PDF_MAX_SIZE, 5), Resources.WARN);
                return;
            }
            string pdfLink =
                Utilities.GetAbsoluteDataPath(Utilities.NextSequence(Bunho, Path.GetFileName(originalFilePath), "pdf"), Bunho);
            File.Copy(originalFilePath, pdfLink);
            _newlyAddedImages.Add(pdfLink);

            string pdfHash = Utilities.CalculateFileChecksum(pdfLink);
            string thumbnailFilePath;

            thumbnailFilePath = Utilities.GetAbsoluteDataPath(Utilities.NextSequence(Bunho, Path.GetFileNameWithoutExtension(pdfLink), "jpeg"), Bunho);
            try
            {
                GhostscriptWrapper.GeneratePageThumb(pdfLink, thumbnailFilePath, 1, 24, 24);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
            FileDocumentImageSource image = new FileDocumentImageSource(thumbnailFilePath);

            //FileDocumentImageSource image = GetPdfThumbnail(pdfLink, out thumbnailFilePath);
            //FileDocumentImageSource image = GetPdfThumbnail(originalFilePath, out thumbnailFilePath);



            _newlyAddedImages.Add(pdfLink);
            _newlyAddedImages.Add(thumbnailFilePath);
            string thumbnailHash = Utilities.CalculateImageChecksum(image.Stream);
            if (!metaDictionary.ContainsKey(thumbnailHash))
            {
                metaDictionary.Add(
                    thumbnailHash,
                    new PdfMeta(pdfHash, pdfLink, new ImageMeta(thumbnailHash, thumbnailFilePath, 0.25f, 0.25f)));
            }




            //if (beginEndBlock) richEditControl.Document.BeginUpdate();
            //DocumentImage docImage = richEditControl.Document.InsertImage(pos, new FileDocumentImageSource(thumbnailFilePath));
            //docImage.ScaleX = 0.25f;
            //docImage.ScaleY = 0.25f;
            //docImage.Uri = thumbnailFilePath;
            //if (beginEndBlock) richEditControl.Document.EndUpdate();
            AddNewRow("", "", thumbnailHash, thumbnailFilePath);

        }
        #endregion

        #region AddNewRow
        private void AddNewRow(string tagCode, string tagName, string content, string imagePath)
        {
            int selectedRowIndex = gridView1.FocusedRowHandle;
            DataTable dt = grdContent.DataSource as DataTable;

            DataRow newRow = dt != null ? dt.NewRow() : null;
            if (newRow == null) return;
            newRow["TagCode"] = tagCode;
            newRow["TagName"] = tagName;
            newRow["Type"] = 1;
            newRow["Content"] = Image.FromFile(imagePath);
            newRow["CreateDate"] = DateTime.Now.ToString("yyyy/MM/dd");
            dt.Rows.InsertAt(newRow, selectedRowIndex + 1);
            gridView1.SelectRow(selectedRowIndex + 1);
        }
        #endregion

        #region EditImage
        //private void EditImage(DocumentImage image)
        //{
        //    // Get original image which is being edited
        //    string editingImageHash = "";
        //    if (hashFileNameDict.ContainsKey(Utilities.CalculateImageChecksum(image.Image)))
        //    {
        //        editingImageHash = Utilities.CalculateImageChecksum(image.Image);
        //    }
        //    string editedImageHash = "";

        //    //string filePath = Utilities.GetAbsoluteDataPath(Path.GetFileName(image.Uri) + "temp" + "." + image.Image.RawFormat, Bunho);
        //    string filePath = Utilities.GetAbsoluteDataPath(Path.GetFileName(hashFileNameDict.ContainsKey(editingImageHash) ? hashFileNameDict[editingImageHash] : string.IsNullOrEmpty(this.initialImgPath) ? image.Uri : this.initialImgPath) + "temp" + "." + image.Image.RawFormat, Bunho);
        //    FileInfo fileInfo = new FileInfo(filePath);
        //    if (!fileInfo.Exists)
        //        Directory.CreateDirectory(fileInfo.Directory.FullName);
        //    SaveStreamToFile(filePath, image.Image.GetImageBytesSafe(image.Image.RawFormat));
        //    editingImage = true;
        //    DataProvider.ImageEditorInstance.Edit(
        //        filePath, image.ScaleX, image.ScaleY,
        //        delegate(byte[] data, float scaleX, float scaleY)
        //        {
        //            richEditControl.Document.BeginUpdate();
        //            richEditControl.Document.Delete(image.Range);
        //            DocumentImage docImage = richEditControl.Document.InsertImage(
        //                richEditControl.Document.CreatePosition(clickPosition == -1 ? 0 : clickPosition),
        //                new StreamDocumentImageSource(new MemoryStream(data)));
        //            docImage.ScaleX = scaleX;
        //            docImage.ScaleY = scaleY;
        //            richEditControl.Document.EndUpdate();
        //            editingImage = false;
        //            editedImageHash = Utilities.CalculateImageChecksum(docImage.Image); // get edited image hash
        //        }, this);

        //    // Update new file hash after editing
        //    string orgFilePath = "";
        //    if (hashFileNameDict.ContainsKey(editingImageHash))
        //    {
        //        orgFilePath = hashFileNameDict[editingImageHash];
        //        hashFileNameDict.Remove(editingImageHash);
        //    }
        //    if (!hashFileNameDict.ContainsKey(editedImageHash))
        //    {
        //        hashFileNameDict.Add(editedImageHash, orgFilePath);
        //    }
        //}
        #endregion

        private void LoadTagName(DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            Dictionary<string, string> dicConvert = DataCreator.DicConvertTag();
            Dictionary<string, string> nonDicConvert = DataCreator.NonDicConvertTag();
            if (e.Column.Name == colTagCode.Name)
            {
                RepositoryItemComboBox riCmb = new RepositoryItemComboBox();
                //if (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TagCode").ToString() == "S")

                #region for cbo
                //if (dicConvert.ContainsKey(e.Value.ToString()))
                //{
                //    string value = dicConvert[e.Value.ToString()];
                //    gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "TagName", value);
                //}
                #endregion

                #region forLookupEdit
                string value = dicConvert[e.Value.ToString()];
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "TagCode", e.Value);
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "TagName", value);
                #endregion
            }
        }

        public class ByteArrayFormatter : IFormatProvider, ICustomFormatter
        {
            // implementing the GetFormat method of the IFormatProvider interface 
            public object GetFormat(System.Type type)
            {
                return this;
            }
            // implementing the Format method of the ICustomFormatter interface 
            public string Format(string format, object arg, IFormatProvider formatProvider)
            {
                return arg.ToString() + "LongString";
            }
        }
        #endregion End Method

    }
}
