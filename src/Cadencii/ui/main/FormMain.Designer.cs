﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using cadencii.windows.forms;

namespace cadencii
{
    public partial class FormMain
    {
        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && (components != null) ) {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        /// <summary>
        /// デザイナ サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディタで変更しないでください。
        /// </summary>
        public void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditRedo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.menuEditCut = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem19 = new System.Windows.Forms.ToolStripSeparator();
            this.menuEditAutoNormalizeMode = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem20 = new System.Windows.Forms.ToolStripSeparator();
            this.menuEditSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditSelectAllEvents = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVisual = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVisualControlTrack = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVisualMixer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVisualWaveform = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVisualIconPalette = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVisualProperty = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVisualOverview = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVisualPluginUi = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVisualPluginUiVocaloid1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVisualPluginUiVocaloid2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVisualPluginUiAquesTone = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVisualPluginUiAquesTone2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuVisualGridline = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuVisualStartMarker = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVisualEndMarker = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuVisualLyrics = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVisualNoteProperty = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVisualPitchLine = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuJob = new System.Windows.Forms.ToolStripMenuItem();
            this.menuJobNormalize = new System.Windows.Forms.ToolStripMenuItem();
            this.menuJobInsertBar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuJobDeleteBar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuJobRandomize = new System.Windows.Forms.ToolStripMenuItem();
            this.menuJobConnect = new System.Windows.Forms.ToolStripMenuItem();
            this.menuJobLyric = new System.Windows.Forms.ToolStripMenuItem();
            this.menuJobRewire = new System.Windows.Forms.ToolStripMenuItem();
            this.menuJobReloadVsti = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTrack = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTrackOn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem21 = new System.Windows.Forms.ToolStripSeparator();
            this.menuTrackAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTrackCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTrackChangeName = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTrackDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem22 = new System.Windows.Forms.ToolStripSeparator();
            this.menuTrackRenderCurrent = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTrackRenderAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem23 = new System.Windows.Forms.ToolStripSeparator();
            this.menuTrackOverlay = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTrackRenderer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTrackRendererVOCALOID1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTrackRendererVOCALOID2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTrackRendererUtau = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTrackRendererVCNT = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTrackRendererAquesTone = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTrackRendererAquesTone2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.menuTrackBgm = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLyric = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLyricExpressionProperty = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLyricVibratoProperty = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLyricApplyUtauParameters = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLyricPhonemeTransformation = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLyricDictionary = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLyricCopyVibratoToPreset = new System.Windows.Forms.ToolStripMenuItem();
            this.menuScript = new System.Windows.Forms.ToolStripMenuItem();
            this.menuScriptUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSettingPreference = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSettingSequence = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSettingPositionQuantize = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSettingPositionQuantize04 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSettingPositionQuantize08 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSettingPositionQuantize16 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSettingPositionQuantize32 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSettingPositionQuantize64 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSettingPositionQuantize128 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSettingPositionQuantizeOff = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripSeparator();
            this.menuSettingPositionQuantizeTriplet = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripSeparator();
            this.menuSettingGameControler = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSettingGameControlerSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSettingGameControlerLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSettingGameControlerRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSettingPaletteTool = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSettingShortcut = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSettingVibratoPreset = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.menuSettingDefaultSingerStyle = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTools = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolsCreateVConnectSTANDDb = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelpManual = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelpCheckForUpdates = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelpLog = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelpLogSwitch = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelpLogOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelpDebug = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHidden = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHiddenEditLyric = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHiddenEditFlipToolPointerPencil = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHiddenEditFlipToolPointerEraser = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHiddenVisualForwardParameter = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHiddenVisualBackwardParameter = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHiddenTrackNext = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHiddenTrackBack = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHiddenCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHiddenPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHiddenCut = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHiddenSelectForward = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHiddenSelectBackward = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHiddenMoveUp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHiddenMoveDown = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHiddenMoveLeft = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHiddenMoveRight = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHiddenLengthen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHiddenShorten = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHiddenGoToStartMarker = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHiddenGoToEndMarker = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHiddenPlayFromStartMarker = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHiddenFlipCurveOnPianorollMode = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHiddenPrintPoToCSV = new System.Windows.Forms.ToolStripMenuItem();
            this.cMenuPiano = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cMenuPianoPointer = new System.Windows.Forms.ToolStripMenuItem();
            this.cMenuPianoPencil = new System.Windows.Forms.ToolStripMenuItem();
            this.cMenuPianoEraser = new System.Windows.Forms.ToolStripMenuItem();
            this.cMenuPianoPaletteTool = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator15 = new System.Windows.Forms.ToolStripSeparator();
            this.cMenuPianoCurve = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem13 = new System.Windows.Forms.ToolStripSeparator();
            this.cMenuPianoFixed = new System.Windows.Forms.ToolStripMenuItem();
            this.cMenuPianoFixed01 = new System.Windows.Forms.ToolStripMenuItem();
            this.cMenuPianoFixed02 = new System.Windows.Forms.ToolStripMenuItem();
            this.cMenuPianoFixed04 = new System.Windows.Forms.ToolStripMenuItem();
            this.cMenuPianoFixed08 = new System.Windows.Forms.ToolStripMenuItem();
            this.cMenuPianoFixed16 = new System.Windows.Forms.ToolStripMenuItem();
            this.cMenuPianoFixed32 = new System.Windows.Forms.ToolStripMenuItem();
            this.cMenuPianoFixed64 = new System.Windows.Forms.ToolStripMenuItem();
            this.cMenuPianoFixed128 = new System.Windows.Forms.ToolStripMenuItem();
            this.cMenuPianoFixedOff = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem18 = new System.Windows.Forms.ToolStripSeparator();
            this.cMenuPianoFixedTriplet = new System.Windows.Forms.ToolStripMenuItem();
            this.cMenuPianoFixedDotted = new System.Windows.Forms.ToolStripMenuItem();
            this.cMenuPianoQuantize = new System.Windows.Forms.ToolStripMenuItem();
            this.cMenuPianoQuantize04 = new System.Windows.Forms.ToolStripMenuItem();
            this.cMenuPianoQuantize08 = new System.Windows.Forms.ToolStripMenuItem();
            this.cMenuPianoQuantize16 = new System.Windows.Forms.ToolStripMenuItem();
            this.cMenuPianoQuantize32 = new System.Windows.Forms.ToolStripMenuItem();
            this.cMenuPianoQuantize64 = new System.Windows.Forms.ToolStripMenuItem();
            this.cMenuPianoQuantize128 = new System.Windows.Forms.ToolStripMenuItem();
            this.cMenuPianoQuantizeOff = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem26 = new System.Windows.Forms.ToolStripSeparator();
            this.cMenuPianoQuantizeTriplet = new System.Windows.Forms.ToolStripMenuItem();
            this.cMenuPianoGrid = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem14 = new System.Windows.Forms.ToolStripSeparator();
            this.cMenuPianoUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.cMenuPianoRedo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem15 = new System.Windows.Forms.ToolStripSeparator();
            this.cMenuPianoCut = new System.Windows.Forms.ToolStripMenuItem();
            this.cMenuPianoCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.cMenuPianoPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.cMenuPianoDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem16 = new System.Windows.Forms.ToolStripSeparator();
            this.cMenuPianoSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.cMenuPianoSelectAllEvents = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem17 = new System.Windows.Forms.ToolStripSeparator();
            this.cMenuPianoImportLyric = new System.Windows.Forms.ToolStripMenuItem();
            this.cMenuPianoExpressionProperty = new System.Windows.Forms.ToolStripMenuItem();
            this.cMenuPianoVibratoProperty = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.cMenuTrackTab = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cMenuTrackTabTrackOn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem24 = new System.Windows.Forms.ToolStripSeparator();
            this.cMenuTrackTabAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.cMenuTrackTabCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.cMenuTrackTabChangeName = new System.Windows.Forms.ToolStripMenuItem();
            this.cMenuTrackTabDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem25 = new System.Windows.Forms.ToolStripSeparator();
            this.cMenuTrackTabRenderCurrent = new System.Windows.Forms.ToolStripMenuItem();
            this.cMenuTrackTabRenderAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem27 = new System.Windows.Forms.ToolStripSeparator();
            this.cMenuTrackTabOverlay = new System.Windows.Forms.ToolStripMenuItem();
            this.cMenuTrackTabRenderer = new System.Windows.Forms.ToolStripMenuItem();
            this.cMenuTrackTabRendererVOCALOID1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cMenuTrackTabRendererVOCALOID2 = new System.Windows.Forms.ToolStripMenuItem();
            this.cMenuTrackTabRendererUtau = new System.Windows.Forms.ToolStripMenuItem();
            this.cMenuTrackTabRendererStraight = new System.Windows.Forms.ToolStripMenuItem();
            this.cMenuTrackTabRendererAquesTone = new System.Windows.Forms.ToolStripMenuItem();
            this.cMenuTrackTabRendererAquesTone2 = new System.Windows.Forms.ToolStripMenuItem();
            this.cMenuTrackSelector = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cMenuTrackSelectorPointer = new System.Windows.Forms.ToolStripMenuItem();
            this.cMenuTrackSelectorPencil = new System.Windows.Forms.ToolStripMenuItem();
            this.cMenuTrackSelectorLine = new System.Windows.Forms.ToolStripMenuItem();
            this.cMenuTrackSelectorEraser = new System.Windows.Forms.ToolStripMenuItem();
            this.cMenuTrackSelectorPaletteTool = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.cMenuTrackSelectorCurve = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem28 = new System.Windows.Forms.ToolStripSeparator();
            this.cMenuTrackSelectorUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.cMenuTrackSelectorRedo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem29 = new System.Windows.Forms.ToolStripSeparator();
            this.cMenuTrackSelectorCut = new System.Windows.Forms.ToolStripMenuItem();
            this.cMenuTrackSelectorCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.cMenuTrackSelectorPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.cMenuTrackSelectorDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.cMenuTrackSelectorDeleteBezier = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem31 = new System.Windows.Forms.ToolStripSeparator();
            this.cMenuTrackSelectorSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictKeyLengthSplitter = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.vScroll = new System.Windows.Forms.VScrollBar();
            this.picturePositionIndicator = new System.Windows.Forms.PictureBox();
            this.toolStripBottom = new System.Windows.Forms.ToolStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.stripLblGameCtrlMode = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.stripLblMidiIn = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.stripBtnStepSequencer = new System.Windows.Forms.ToolStripButton();
            this.splitContainerProperty = new cadencii.apputil.BSplitContainer();
            this.splitContainer2 = new cadencii.apputil.BSplitContainer();
            this.splitContainer1 = new cadencii.apputil.BSplitContainer();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.stripDDBtnQuantize = new System.Windows.Forms.ContextMenu();
            this.stripDDBtnQuantize04 = new System.Windows.Forms.MenuItem();
            this.stripDDBtnQuantize08 = new System.Windows.Forms.MenuItem();
            this.stripDDBtnQuantize16 = new System.Windows.Forms.MenuItem();
            this.stripDDBtnQuantize32 = new System.Windows.Forms.MenuItem();
            this.stripDDBtnQuantize64 = new System.Windows.Forms.MenuItem();
            this.stripDDBtnQuantize128 = new System.Windows.Forms.MenuItem();
            this.stripDDBtnQuantizeOff = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.stripDDBtnQuantizeTriplet = new System.Windows.Forms.MenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.imageListFile = new System.Windows.Forms.ImageList(this.components);
            this.imageListPosition = new System.Windows.Forms.ImageList(this.components);
            this.imageListMeasure = new System.Windows.Forms.ImageList(this.components);
            this.imageListTool = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelOverview = new cadencii.PictOverview();
            this.pictPianoRoll = new cadencii.PictPianoRoll();
            this.hScroll = new System.Windows.Forms.HScrollBar();
            this.rebar = new cadencii.windows.forms.Rebar();
            this.imageListMenu = new System.Windows.Forms.ImageList(this.components);
            this.toolBarFile = new System.Windows.Forms.ToolBar();
            this.stripBtnFileNew = new System.Windows.Forms.ToolBarButton();
            this.stripBtnFileOpen = new System.Windows.Forms.ToolBarButton();
            this.stripBtnFileSave = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton1 = new System.Windows.Forms.ToolBarButton();
            this.stripBtnCut = new System.Windows.Forms.ToolBarButton();
            this.stripBtnCopy = new System.Windows.Forms.ToolBarButton();
            this.stripBtnPaste = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton2 = new System.Windows.Forms.ToolBarButton();
            this.stripBtnUndo = new System.Windows.Forms.ToolBarButton();
            this.stripBtnRedo = new System.Windows.Forms.ToolBarButton();
            this.toolBarPosition = new System.Windows.Forms.ToolBar();
            this.stripBtnMoveTop = new System.Windows.Forms.ToolBarButton();
            this.stripBtnRewind = new System.Windows.Forms.ToolBarButton();
            this.stripBtnForward = new System.Windows.Forms.ToolBarButton();
            this.stripBtnMoveEnd = new System.Windows.Forms.ToolBarButton();
            this.stripBtnPlay = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton4 = new System.Windows.Forms.ToolBarButton();
            this.stripBtnScroll = new System.Windows.Forms.ToolBarButton();
            this.stripBtnLoop = new System.Windows.Forms.ToolBarButton();
            this.toolBarMeasure = new System.Windows.Forms.ToolBar();
            this.stripDDBtnQuantizeParent = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton5 = new System.Windows.Forms.ToolBarButton();
            this.stripBtnStartMarker = new System.Windows.Forms.ToolBarButton();
            this.stripBtnEndMarker = new System.Windows.Forms.ToolBarButton();
            this.toolBarTool = new System.Windows.Forms.ToolBar();
            this.stripBtnPointer = new System.Windows.Forms.ToolBarButton();
            this.stripBtnPencil = new System.Windows.Forms.ToolBarButton();
            this.stripBtnLine = new System.Windows.Forms.ToolBarButton();
            this.stripBtnEraser = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton3 = new System.Windows.Forms.ToolBarButton();
            this.stripBtnGrid = new System.Windows.Forms.ToolBarButton();
            this.stripBtnCurve = new System.Windows.Forms.ToolBarButton();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.bigMenu = new System.Windows.Forms.Panel();
            this.exportMenu = new System.Windows.Forms.Panel();
            this.ExportUstMI = new System.Windows.Forms.Label();
            this.ExportVsqMI = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.importMenu = new System.Windows.Forms.Panel();
            this.ImportUstMI = new System.Windows.Forms.Label();
            this.ImportVsqMI = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.projNameLabel = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.cMenuPositionIndicator = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cMenuPositionIndicatorStartMarker = new System.Windows.Forms.ToolStripMenuItem();
            this.cMenuPositionIndicatorEndMarker = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.frqEditBtn = new System.Windows.Forms.PictureBox();
            this.eraseBtn = new System.Windows.Forms.PictureBox();
            this.addBtn = new System.Windows.Forms.PictureBox();
            this.highligher = new System.Windows.Forms.Panel();
            this.BigMenuBtn = new System.Windows.Forms.PictureBox();
            this.SelectBtn = new System.Windows.Forms.PictureBox();
            this.menuFileQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripSeparator();
            this.menuFileRecentClear = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileRecent = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripSeparator();
            this.menuFileExportWave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileExportParaWave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileExportVsq = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileExportVsqx = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileExportMidi = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileExportMusicXml = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileExportUst = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileExportVxt = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileExport = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileImportVsq = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileImportMidi = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileImportUst = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileImport = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileOpenUst = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileOpenVsq = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripSeparator();
            this.menuFileSaveNamed = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem30 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem32 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem33 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem34 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem35 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem36 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem37 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem38 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem39 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem40 = new System.Windows.Forms.ToolStripMenuItem();
            this.renderTimer = new System.Windows.Forms.Timer(this.components);
            this.menuStripMain.SuspendLayout();
            this.cMenuPiano.SuspendLayout();
            this.cMenuTrackTab.SuspendLayout();
            this.cMenuTrackSelector.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictKeyLengthSplitter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePositionIndicator)).BeginInit();
            this.splitContainerProperty.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelOverview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictPianoRoll)).BeginInit();
            this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.bigMenu.SuspendLayout();
            this.exportMenu.SuspendLayout();
            this.importMenu.SuspendLayout();
            this.cMenuPositionIndicator.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frqEditBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eraseBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BigMenuBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuEdit,
            this.menuVisual,
            this.menuJob,
            this.menuTrack,
            this.menuLyric,
            this.menuScript,
            this.menuSetting,
            this.menuTools,
            this.menuHelp,
            this.menuHidden});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStripMain.Size = new System.Drawing.Size(955, 24);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip1";
            this.menuStripMain.Visible = false;
            // 
            // menuFile
            // 
            this.menuFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuFile.ForeColor = System.Drawing.Color.White;
            this.menuFile.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(51, 20);
            this.menuFile.Text = "File(&F)";
            // 
            // menuEdit
            // 
            this.menuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuEditUndo,
            this.menuEditRedo,
            this.toolStripMenuItem5,
            this.menuEditCut,
            this.menuEditCopy,
            this.menuEditPaste,
            this.menuEditDelete,
            this.toolStripMenuItem19,
            this.menuEditAutoNormalizeMode,
            this.toolStripMenuItem20,
            this.menuEditSelectAll,
            this.menuEditSelectAllEvents});
            this.menuEdit.ForeColor = System.Drawing.Color.White;
            this.menuEdit.Name = "menuEdit";
            this.menuEdit.Size = new System.Drawing.Size(53, 20);
            this.menuEdit.Text = "Edit(&E)";
            // 
            // menuEditUndo
            // 
            this.menuEditUndo.Name = "menuEditUndo";
            this.menuEditUndo.Size = new System.Drawing.Size(208, 22);
            this.menuEditUndo.Text = "Undo(&U)";
            // 
            // menuEditRedo
            // 
            this.menuEditRedo.Name = "menuEditRedo";
            this.menuEditRedo.Size = new System.Drawing.Size(208, 22);
            this.menuEditRedo.Text = "Redo(&R)";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(205, 6);
            // 
            // menuEditCut
            // 
            this.menuEditCut.Name = "menuEditCut";
            this.menuEditCut.Size = new System.Drawing.Size(208, 22);
            this.menuEditCut.Text = "Cut(&T)";
            // 
            // menuEditCopy
            // 
            this.menuEditCopy.Name = "menuEditCopy";
            this.menuEditCopy.Size = new System.Drawing.Size(208, 22);
            this.menuEditCopy.Text = "Copy(&C)";
            // 
            // menuEditPaste
            // 
            this.menuEditPaste.Name = "menuEditPaste";
            this.menuEditPaste.ShortcutKeyDisplayString = "";
            this.menuEditPaste.Size = new System.Drawing.Size(208, 22);
            this.menuEditPaste.Text = "Paste(&P)";
            // 
            // menuEditDelete
            // 
            this.menuEditDelete.Name = "menuEditDelete";
            this.menuEditDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.menuEditDelete.Size = new System.Drawing.Size(208, 22);
            this.menuEditDelete.Tag = "";
            this.menuEditDelete.Text = "Delete(&D)";
            // 
            // toolStripMenuItem19
            // 
            this.toolStripMenuItem19.Name = "toolStripMenuItem19";
            this.toolStripMenuItem19.Size = new System.Drawing.Size(205, 6);
            // 
            // menuEditAutoNormalizeMode
            // 
            this.menuEditAutoNormalizeMode.Name = "menuEditAutoNormalizeMode";
            this.menuEditAutoNormalizeMode.Size = new System.Drawing.Size(208, 22);
            this.menuEditAutoNormalizeMode.Text = "Auto Normalize Mode(&N)";
            // 
            // toolStripMenuItem20
            // 
            this.toolStripMenuItem20.Name = "toolStripMenuItem20";
            this.toolStripMenuItem20.Size = new System.Drawing.Size(205, 6);
            // 
            // menuEditSelectAll
            // 
            this.menuEditSelectAll.Name = "menuEditSelectAll";
            this.menuEditSelectAll.Size = new System.Drawing.Size(208, 22);
            this.menuEditSelectAll.Text = "Select All(&A)";
            // 
            // menuEditSelectAllEvents
            // 
            this.menuEditSelectAllEvents.Name = "menuEditSelectAllEvents";
            this.menuEditSelectAllEvents.Size = new System.Drawing.Size(208, 22);
            this.menuEditSelectAllEvents.Text = "Select All Events(&E)";
            // 
            // menuVisual
            // 
            this.menuVisual.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuVisual.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuVisualControlTrack,
            this.menuVisualMixer,
            this.menuVisualWaveform,
            this.menuVisualIconPalette,
            this.menuVisualProperty,
            this.menuVisualOverview,
            this.menuVisualPluginUi,
            this.toolStripMenuItem1,
            this.menuVisualGridline,
            this.toolStripMenuItem2,
            this.menuVisualStartMarker,
            this.menuVisualEndMarker,
            this.toolStripMenuItem3,
            this.menuVisualLyrics,
            this.menuVisualNoteProperty,
            this.menuVisualPitchLine,
            this.toolStripSeparator1,
            this.toolStripMenuItem7});
            this.menuVisual.ForeColor = System.Drawing.Color.White;
            this.menuVisual.Name = "menuVisual";
            this.menuVisual.Size = new System.Drawing.Size(59, 20);
            this.menuVisual.Text = "View(&V)";
            // 
            // menuVisualControlTrack
            // 
            this.menuVisualControlTrack.Checked = true;
            this.menuVisualControlTrack.CheckOnClick = true;
            this.menuVisualControlTrack.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuVisualControlTrack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuVisualControlTrack.Name = "menuVisualControlTrack";
            this.menuVisualControlTrack.Size = new System.Drawing.Size(218, 22);
            this.menuVisualControlTrack.Text = "Control Track(&C)";
            // 
            // menuVisualMixer
            // 
            this.menuVisualMixer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuVisualMixer.Name = "menuVisualMixer";
            this.menuVisualMixer.Size = new System.Drawing.Size(218, 22);
            this.menuVisualMixer.Text = "Mixer(&X)";
            // 
            // menuVisualWaveform
            // 
            this.menuVisualWaveform.CheckOnClick = true;
            this.menuVisualWaveform.Name = "menuVisualWaveform";
            this.menuVisualWaveform.Size = new System.Drawing.Size(218, 22);
            this.menuVisualWaveform.Text = "Waveform(&W)";
            // 
            // menuVisualIconPalette
            // 
            this.menuVisualIconPalette.CheckOnClick = true;
            this.menuVisualIconPalette.Name = "menuVisualIconPalette";
            this.menuVisualIconPalette.Size = new System.Drawing.Size(218, 22);
            this.menuVisualIconPalette.Text = "Icon Palette(&I)";
            // 
            // menuVisualProperty
            // 
            this.menuVisualProperty.CheckOnClick = true;
            this.menuVisualProperty.Name = "menuVisualProperty";
            this.menuVisualProperty.Size = new System.Drawing.Size(218, 22);
            this.menuVisualProperty.Text = "Property Window(&C)";
            // 
            // menuVisualOverview
            // 
            this.menuVisualOverview.CheckOnClick = true;
            this.menuVisualOverview.Name = "menuVisualOverview";
            this.menuVisualOverview.Size = new System.Drawing.Size(218, 22);
            this.menuVisualOverview.Text = "Overview(&O)";
            // 
            // menuVisualPluginUi
            // 
            this.menuVisualPluginUi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuVisualPluginUiVocaloid1,
            this.menuVisualPluginUiVocaloid2,
            this.menuVisualPluginUiAquesTone,
            this.menuVisualPluginUiAquesTone2});
            this.menuVisualPluginUi.Name = "menuVisualPluginUi";
            this.menuVisualPluginUi.Size = new System.Drawing.Size(218, 22);
            this.menuVisualPluginUi.Text = "VSTi Plugin UI(&U)";
            // 
            // menuVisualPluginUiVocaloid1
            // 
            this.menuVisualPluginUiVocaloid1.Name = "menuVisualPluginUiVocaloid1";
            this.menuVisualPluginUiVocaloid1.Size = new System.Drawing.Size(150, 22);
            this.menuVisualPluginUiVocaloid1.Text = "VOCALOID1";
            // 
            // menuVisualPluginUiVocaloid2
            // 
            this.menuVisualPluginUiVocaloid2.Name = "menuVisualPluginUiVocaloid2";
            this.menuVisualPluginUiVocaloid2.Size = new System.Drawing.Size(150, 22);
            this.menuVisualPluginUiVocaloid2.Text = "VOCALOID2";
            // 
            // menuVisualPluginUiAquesTone
            // 
            this.menuVisualPluginUiAquesTone.Name = "menuVisualPluginUiAquesTone";
            this.menuVisualPluginUiAquesTone.Size = new System.Drawing.Size(150, 22);
            this.menuVisualPluginUiAquesTone.Text = "AquesTone(&A)";
            // 
            // menuVisualPluginUiAquesTone2
            // 
            this.menuVisualPluginUiAquesTone2.Name = "menuVisualPluginUiAquesTone2";
            this.menuVisualPluginUiAquesTone2.Size = new System.Drawing.Size(150, 22);
            this.menuVisualPluginUiAquesTone2.Text = "AquesTone2";
            this.menuVisualPluginUiAquesTone2.Click += new System.EventHandler(this.menuVisualPluginUiAquesTone2_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(215, 6);
            // 
            // menuVisualGridline
            // 
            this.menuVisualGridline.CheckOnClick = true;
            this.menuVisualGridline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuVisualGridline.Name = "menuVisualGridline";
            this.menuVisualGridline.Size = new System.Drawing.Size(218, 22);
            this.menuVisualGridline.Text = "Grid Line(&G)";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(215, 6);
            // 
            // menuVisualStartMarker
            // 
            this.menuVisualStartMarker.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuVisualStartMarker.Name = "menuVisualStartMarker";
            this.menuVisualStartMarker.Size = new System.Drawing.Size(218, 22);
            this.menuVisualStartMarker.Text = "Start Marker(&S)";
            // 
            // menuVisualEndMarker
            // 
            this.menuVisualEndMarker.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuVisualEndMarker.Name = "menuVisualEndMarker";
            this.menuVisualEndMarker.Size = new System.Drawing.Size(218, 22);
            this.menuVisualEndMarker.Text = "End Marker(&E)";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(215, 6);
            // 
            // menuVisualLyrics
            // 
            this.menuVisualLyrics.Checked = true;
            this.menuVisualLyrics.CheckOnClick = true;
            this.menuVisualLyrics.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuVisualLyrics.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuVisualLyrics.Name = "menuVisualLyrics";
            this.menuVisualLyrics.Size = new System.Drawing.Size(218, 22);
            this.menuVisualLyrics.Text = "Lyric/Phoneme(&L)";
            // 
            // menuVisualNoteProperty
            // 
            this.menuVisualNoteProperty.Checked = true;
            this.menuVisualNoteProperty.CheckOnClick = true;
            this.menuVisualNoteProperty.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuVisualNoteProperty.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuVisualNoteProperty.Name = "menuVisualNoteProperty";
            this.menuVisualNoteProperty.Size = new System.Drawing.Size(218, 22);
            this.menuVisualNoteProperty.Text = "Note Expression/Vibrato(&N)";
            // 
            // menuVisualPitchLine
            // 
            this.menuVisualPitchLine.CheckOnClick = true;
            this.menuVisualPitchLine.Name = "menuVisualPitchLine";
            this.menuVisualPitchLine.Size = new System.Drawing.Size(218, 22);
            this.menuVisualPitchLine.Text = "Pitch Line(&P)";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(215, 6);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Checked = true;
            this.toolStripMenuItem7.CheckOnClick = true;
            this.toolStripMenuItem7.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(218, 22);
            this.toolStripMenuItem7.Text = "Enable New Toolbar UI";
            // 
            // menuJob
            // 
            this.menuJob.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuJobNormalize,
            this.menuJobInsertBar,
            this.menuJobDeleteBar,
            this.menuJobRandomize,
            this.menuJobConnect,
            this.menuJobLyric,
            this.menuJobRewire,
            this.menuJobReloadVsti});
            this.menuJob.ForeColor = System.Drawing.Color.White;
            this.menuJob.Name = "menuJob";
            this.menuJob.Size = new System.Drawing.Size(49, 20);
            this.menuJob.Text = "Job(&J)";
            // 
            // menuJobNormalize
            // 
            this.menuJobNormalize.Name = "menuJobNormalize";
            this.menuJobNormalize.Size = new System.Drawing.Size(234, 22);
            this.menuJobNormalize.Text = "Normalize Notes(&N)";
            // 
            // menuJobInsertBar
            // 
            this.menuJobInsertBar.Name = "menuJobInsertBar";
            this.menuJobInsertBar.Size = new System.Drawing.Size(234, 22);
            this.menuJobInsertBar.Text = "Insert Bars(&I)";
            // 
            // menuJobDeleteBar
            // 
            this.menuJobDeleteBar.Name = "menuJobDeleteBar";
            this.menuJobDeleteBar.Size = new System.Drawing.Size(234, 22);
            this.menuJobDeleteBar.Text = "Delete Bars(&D)";
            // 
            // menuJobRandomize
            // 
            this.menuJobRandomize.Name = "menuJobRandomize";
            this.menuJobRandomize.Size = new System.Drawing.Size(234, 22);
            this.menuJobRandomize.Text = "Randomize(&R)";
            // 
            // menuJobConnect
            // 
            this.menuJobConnect.Name = "menuJobConnect";
            this.menuJobConnect.Size = new System.Drawing.Size(234, 22);
            this.menuJobConnect.Text = "Connect Notes(&C)";
            // 
            // menuJobLyric
            // 
            this.menuJobLyric.Name = "menuJobLyric";
            this.menuJobLyric.Size = new System.Drawing.Size(234, 22);
            this.menuJobLyric.Text = "Insert Lyrics(&L)";
            // 
            // menuJobRewire
            // 
            this.menuJobRewire.Enabled = false;
            this.menuJobRewire.Name = "menuJobRewire";
            this.menuJobRewire.Size = new System.Drawing.Size(234, 22);
            this.menuJobRewire.Text = "Import ReWire Host Tempo(&T)";
            // 
            // menuJobReloadVsti
            // 
            this.menuJobReloadVsti.Name = "menuJobReloadVsti";
            this.menuJobReloadVsti.Size = new System.Drawing.Size(234, 22);
            this.menuJobReloadVsti.Text = "Reload VSTi(&R)";
            this.menuJobReloadVsti.Visible = false;
            // 
            // menuTrack
            // 
            this.menuTrack.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuTrackOn,
            this.toolStripMenuItem21,
            this.menuTrackAdd,
            this.menuTrackCopy,
            this.menuTrackChangeName,
            this.menuTrackDelete,
            this.toolStripMenuItem22,
            this.menuTrackRenderCurrent,
            this.menuTrackRenderAll,
            this.toolStripMenuItem23,
            this.menuTrackOverlay,
            this.menuTrackRenderer,
            this.toolStripMenuItem4,
            this.menuTrackBgm});
            this.menuTrack.ForeColor = System.Drawing.Color.White;
            this.menuTrack.Name = "menuTrack";
            this.menuTrack.Size = new System.Drawing.Size(63, 20);
            this.menuTrack.Text = "Track(&T)";
            // 
            // menuTrackOn
            // 
            this.menuTrackOn.Name = "menuTrackOn";
            this.menuTrackOn.Size = new System.Drawing.Size(201, 22);
            this.menuTrackOn.Text = "Track On(&K)";
            // 
            // toolStripMenuItem21
            // 
            this.toolStripMenuItem21.Name = "toolStripMenuItem21";
            this.toolStripMenuItem21.Size = new System.Drawing.Size(198, 6);
            // 
            // menuTrackAdd
            // 
            this.menuTrackAdd.Name = "menuTrackAdd";
            this.menuTrackAdd.Size = new System.Drawing.Size(201, 22);
            this.menuTrackAdd.Text = "Add Track(&A)";
            // 
            // menuTrackCopy
            // 
            this.menuTrackCopy.Name = "menuTrackCopy";
            this.menuTrackCopy.Size = new System.Drawing.Size(201, 22);
            this.menuTrackCopy.Text = "Copy Track(&C)";
            // 
            // menuTrackChangeName
            // 
            this.menuTrackChangeName.Name = "menuTrackChangeName";
            this.menuTrackChangeName.Size = new System.Drawing.Size(201, 22);
            this.menuTrackChangeName.Text = "Rename Track";
            // 
            // menuTrackDelete
            // 
            this.menuTrackDelete.Name = "menuTrackDelete";
            this.menuTrackDelete.Size = new System.Drawing.Size(201, 22);
            this.menuTrackDelete.Text = "Delete Track(&D)";
            // 
            // toolStripMenuItem22
            // 
            this.toolStripMenuItem22.Name = "toolStripMenuItem22";
            this.toolStripMenuItem22.Size = new System.Drawing.Size(198, 6);
            // 
            // menuTrackRenderCurrent
            // 
            this.menuTrackRenderCurrent.Name = "menuTrackRenderCurrent";
            this.menuTrackRenderCurrent.Size = new System.Drawing.Size(201, 22);
            this.menuTrackRenderCurrent.Text = "Render Current Track(&T)";
            // 
            // menuTrackRenderAll
            // 
            this.menuTrackRenderAll.Enabled = false;
            this.menuTrackRenderAll.Name = "menuTrackRenderAll";
            this.menuTrackRenderAll.Size = new System.Drawing.Size(201, 22);
            this.menuTrackRenderAll.Text = "Render All Tracks(&S)";
            // 
            // toolStripMenuItem23
            // 
            this.toolStripMenuItem23.Name = "toolStripMenuItem23";
            this.toolStripMenuItem23.Size = new System.Drawing.Size(198, 6);
            // 
            // menuTrackOverlay
            // 
            this.menuTrackOverlay.Name = "menuTrackOverlay";
            this.menuTrackOverlay.Size = new System.Drawing.Size(201, 22);
            this.menuTrackOverlay.Text = "Overlay(&O)";
            // 
            // menuTrackRenderer
            // 
            this.menuTrackRenderer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuTrackRendererVOCALOID1,
            this.menuTrackRendererVOCALOID2,
            this.menuTrackRendererUtau,
            this.menuTrackRendererVCNT,
            this.menuTrackRendererAquesTone,
            this.menuTrackRendererAquesTone2});
            this.menuTrackRenderer.Name = "menuTrackRenderer";
            this.menuTrackRenderer.Size = new System.Drawing.Size(201, 22);
            this.menuTrackRenderer.Text = "Renderer(&R)";
            // 
            // menuTrackRendererVOCALOID1
            // 
            this.menuTrackRendererVOCALOID1.Name = "menuTrackRendererVOCALOID1";
            this.menuTrackRendererVOCALOID1.Size = new System.Drawing.Size(182, 22);
            this.menuTrackRendererVOCALOID1.Text = "VOCALOID1(&1)";
            // 
            // menuTrackRendererVOCALOID2
            // 
            this.menuTrackRendererVOCALOID2.Name = "menuTrackRendererVOCALOID2";
            this.menuTrackRendererVOCALOID2.Size = new System.Drawing.Size(182, 22);
            this.menuTrackRendererVOCALOID2.Text = "VOCALOID2(&2)";
            // 
            // menuTrackRendererUtau
            // 
            this.menuTrackRendererUtau.Name = "menuTrackRendererUtau";
            this.menuTrackRendererUtau.Size = new System.Drawing.Size(182, 22);
            this.menuTrackRendererUtau.Text = "UTAU(&3)";
            // 
            // menuTrackRendererVCNT
            // 
            this.menuTrackRendererVCNT.Name = "menuTrackRendererVCNT";
            this.menuTrackRendererVCNT.Size = new System.Drawing.Size(182, 22);
            this.menuTrackRendererVCNT.Text = "vConnect-STAND(&4)";
            // 
            // menuTrackRendererAquesTone
            // 
            this.menuTrackRendererAquesTone.Name = "menuTrackRendererAquesTone";
            this.menuTrackRendererAquesTone.Size = new System.Drawing.Size(182, 22);
            this.menuTrackRendererAquesTone.Text = "AquesTone(&5)";
            // 
            // menuTrackRendererAquesTone2
            // 
            this.menuTrackRendererAquesTone2.Name = "menuTrackRendererAquesTone2";
            this.menuTrackRendererAquesTone2.Size = new System.Drawing.Size(182, 22);
            this.menuTrackRendererAquesTone2.Text = "AquesTone2(&6)";
            this.menuTrackRendererAquesTone2.Click += new System.EventHandler(this.handleChangeRenderer);
            this.menuTrackRendererAquesTone2.MouseEnter += new System.EventHandler(this.handleMenuMouseEnter);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(198, 6);
            // 
            // menuTrackBgm
            // 
            this.menuTrackBgm.Name = "menuTrackBgm";
            this.menuTrackBgm.Size = new System.Drawing.Size(201, 22);
            this.menuTrackBgm.Text = "BGM(&B)";
            // 
            // menuLyric
            // 
            this.menuLyric.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuLyricExpressionProperty,
            this.menuLyricVibratoProperty,
            this.menuLyricApplyUtauParameters,
            this.menuLyricPhonemeTransformation,
            this.menuLyricDictionary,
            this.menuLyricCopyVibratoToPreset});
            this.menuLyric.ForeColor = System.Drawing.Color.White;
            this.menuLyric.Name = "menuLyric";
            this.menuLyric.Size = new System.Drawing.Size(63, 20);
            this.menuLyric.Text = "Lyrics(&L)";
            // 
            // menuLyricExpressionProperty
            // 
            this.menuLyricExpressionProperty.Name = "menuLyricExpressionProperty";
            this.menuLyricExpressionProperty.Size = new System.Drawing.Size(243, 22);
            this.menuLyricExpressionProperty.Text = "Note Expression Property(&E)";
            // 
            // menuLyricVibratoProperty
            // 
            this.menuLyricVibratoProperty.Name = "menuLyricVibratoProperty";
            this.menuLyricVibratoProperty.Size = new System.Drawing.Size(243, 22);
            this.menuLyricVibratoProperty.Text = "Note Vibrato Property(&V)";
            // 
            // menuLyricApplyUtauParameters
            // 
            this.menuLyricApplyUtauParameters.Name = "menuLyricApplyUtauParameters";
            this.menuLyricApplyUtauParameters.Size = new System.Drawing.Size(243, 22);
            this.menuLyricApplyUtauParameters.Text = "Apply UTAU Parameters(&A)";
            // 
            // menuLyricPhonemeTransformation
            // 
            this.menuLyricPhonemeTransformation.Name = "menuLyricPhonemeTransformation";
            this.menuLyricPhonemeTransformation.Size = new System.Drawing.Size(243, 22);
            this.menuLyricPhonemeTransformation.Text = "Phoneme Transformation(&T)";
            // 
            // menuLyricDictionary
            // 
            this.menuLyricDictionary.Name = "menuLyricDictionary";
            this.menuLyricDictionary.Size = new System.Drawing.Size(243, 22);
            this.menuLyricDictionary.Text = "User Word Dictionary(&C)";
            // 
            // menuLyricCopyVibratoToPreset
            // 
            this.menuLyricCopyVibratoToPreset.Name = "menuLyricCopyVibratoToPreset";
            this.menuLyricCopyVibratoToPreset.Size = new System.Drawing.Size(243, 22);
            this.menuLyricCopyVibratoToPreset.Text = "Copy vibrato config to preset(&P)";
            // 
            // menuScript
            // 
            this.menuScript.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuScriptUpdate});
            this.menuScript.ForeColor = System.Drawing.Color.White;
            this.menuScript.Name = "menuScript";
            this.menuScript.Size = new System.Drawing.Size(65, 20);
            this.menuScript.Text = "Script(&C)";
            // 
            // menuScriptUpdate
            // 
            this.menuScriptUpdate.Name = "menuScriptUpdate";
            this.menuScriptUpdate.Size = new System.Drawing.Size(182, 22);
            this.menuScriptUpdate.Text = "Update Script List(&U)";
            // 
            // menuSetting
            // 
            this.menuSetting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSettingPreference,
            this.menuSettingSequence,
            this.menuSettingPositionQuantize,
            this.toolStripMenuItem8,
            this.menuSettingGameControler,
            this.menuSettingPaletteTool,
            this.menuSettingShortcut,
            this.menuSettingVibratoPreset,
            this.toolStripMenuItem6,
            this.menuSettingDefaultSingerStyle});
            this.menuSetting.ForeColor = System.Drawing.Color.White;
            this.menuSetting.Name = "menuSetting";
            this.menuSetting.Size = new System.Drawing.Size(70, 20);
            this.menuSetting.Text = "Setting(&S)";
            // 
            // menuSettingPreference
            // 
            this.menuSettingPreference.Name = "menuSettingPreference";
            this.menuSettingPreference.Size = new System.Drawing.Size(204, 22);
            this.menuSettingPreference.Text = "Preference(&P)";
            // 
            // menuSettingSequence
            // 
            this.menuSettingSequence.Name = "menuSettingSequence";
            this.menuSettingSequence.Size = new System.Drawing.Size(204, 22);
            this.menuSettingSequence.Text = "Sequence config(&S)";
            // 
            // menuSettingPositionQuantize
            // 
            this.menuSettingPositionQuantize.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSettingPositionQuantize04,
            this.menuSettingPositionQuantize08,
            this.menuSettingPositionQuantize16,
            this.menuSettingPositionQuantize32,
            this.menuSettingPositionQuantize64,
            this.menuSettingPositionQuantize128,
            this.menuSettingPositionQuantizeOff,
            this.toolStripMenuItem9,
            this.menuSettingPositionQuantizeTriplet});
            this.menuSettingPositionQuantize.Name = "menuSettingPositionQuantize";
            this.menuSettingPositionQuantize.Size = new System.Drawing.Size(204, 22);
            this.menuSettingPositionQuantize.Text = "Quantize(&Q)";
            // 
            // menuSettingPositionQuantize04
            // 
            this.menuSettingPositionQuantize04.Name = "menuSettingPositionQuantize04";
            this.menuSettingPositionQuantize04.Size = new System.Drawing.Size(108, 22);
            this.menuSettingPositionQuantize04.Text = "1/4";
            // 
            // menuSettingPositionQuantize08
            // 
            this.menuSettingPositionQuantize08.Name = "menuSettingPositionQuantize08";
            this.menuSettingPositionQuantize08.Size = new System.Drawing.Size(108, 22);
            this.menuSettingPositionQuantize08.Text = "1/8";
            // 
            // menuSettingPositionQuantize16
            // 
            this.menuSettingPositionQuantize16.Name = "menuSettingPositionQuantize16";
            this.menuSettingPositionQuantize16.Size = new System.Drawing.Size(108, 22);
            this.menuSettingPositionQuantize16.Text = "1/16";
            // 
            // menuSettingPositionQuantize32
            // 
            this.menuSettingPositionQuantize32.Name = "menuSettingPositionQuantize32";
            this.menuSettingPositionQuantize32.Size = new System.Drawing.Size(108, 22);
            this.menuSettingPositionQuantize32.Text = "1/32";
            // 
            // menuSettingPositionQuantize64
            // 
            this.menuSettingPositionQuantize64.Name = "menuSettingPositionQuantize64";
            this.menuSettingPositionQuantize64.Size = new System.Drawing.Size(108, 22);
            this.menuSettingPositionQuantize64.Text = "1/64";
            // 
            // menuSettingPositionQuantize128
            // 
            this.menuSettingPositionQuantize128.Name = "menuSettingPositionQuantize128";
            this.menuSettingPositionQuantize128.Size = new System.Drawing.Size(108, 22);
            this.menuSettingPositionQuantize128.Text = "1/128";
            // 
            // menuSettingPositionQuantizeOff
            // 
            this.menuSettingPositionQuantizeOff.Name = "menuSettingPositionQuantizeOff";
            this.menuSettingPositionQuantizeOff.Size = new System.Drawing.Size(108, 22);
            this.menuSettingPositionQuantizeOff.Text = "Off";
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(105, 6);
            // 
            // menuSettingPositionQuantizeTriplet
            // 
            this.menuSettingPositionQuantizeTriplet.Name = "menuSettingPositionQuantizeTriplet";
            this.menuSettingPositionQuantizeTriplet.Size = new System.Drawing.Size(108, 22);
            this.menuSettingPositionQuantizeTriplet.Text = "Triplet";
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(201, 6);
            // 
            // menuSettingGameControler
            // 
            this.menuSettingGameControler.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSettingGameControlerSetting,
            this.menuSettingGameControlerLoad,
            this.menuSettingGameControlerRemove});
            this.menuSettingGameControler.Name = "menuSettingGameControler";
            this.menuSettingGameControler.Size = new System.Drawing.Size(204, 22);
            this.menuSettingGameControler.Text = "Game Controler(&G)";
            // 
            // menuSettingGameControlerSetting
            // 
            this.menuSettingGameControlerSetting.Name = "menuSettingGameControlerSetting";
            this.menuSettingGameControlerSetting.Size = new System.Drawing.Size(132, 22);
            this.menuSettingGameControlerSetting.Text = "Setting(&S)";
            // 
            // menuSettingGameControlerLoad
            // 
            this.menuSettingGameControlerLoad.Name = "menuSettingGameControlerLoad";
            this.menuSettingGameControlerLoad.Size = new System.Drawing.Size(132, 22);
            this.menuSettingGameControlerLoad.Text = "Load(&L)";
            // 
            // menuSettingGameControlerRemove
            // 
            this.menuSettingGameControlerRemove.Name = "menuSettingGameControlerRemove";
            this.menuSettingGameControlerRemove.Size = new System.Drawing.Size(132, 22);
            this.menuSettingGameControlerRemove.Text = "Remove(&R)";
            // 
            // menuSettingPaletteTool
            // 
            this.menuSettingPaletteTool.Name = "menuSettingPaletteTool";
            this.menuSettingPaletteTool.Size = new System.Drawing.Size(204, 22);
            this.menuSettingPaletteTool.Text = "Palette Tool(&T)";
            // 
            // menuSettingShortcut
            // 
            this.menuSettingShortcut.Name = "menuSettingShortcut";
            this.menuSettingShortcut.Size = new System.Drawing.Size(204, 22);
            this.menuSettingShortcut.Text = "Shortcut Key(&K)";
            // 
            // menuSettingVibratoPreset
            // 
            this.menuSettingVibratoPreset.Name = "menuSettingVibratoPreset";
            this.menuSettingVibratoPreset.Size = new System.Drawing.Size(204, 22);
            this.menuSettingVibratoPreset.Text = "Vibrato preset(&V)";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(201, 6);
            // 
            // menuSettingDefaultSingerStyle
            // 
            this.menuSettingDefaultSingerStyle.Name = "menuSettingDefaultSingerStyle";
            this.menuSettingDefaultSingerStyle.Size = new System.Drawing.Size(204, 22);
            this.menuSettingDefaultSingerStyle.Text = "Singing Style Defaults(&D)";
            // 
            // menuTools
            // 
            this.menuTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolsCreateVConnectSTANDDb});
            this.menuTools.ForeColor = System.Drawing.Color.White;
            this.menuTools.Name = "menuTools";
            this.menuTools.Size = new System.Drawing.Size(65, 20);
            this.menuTools.Text = "Tools(&O)";
            // 
            // menuToolsCreateVConnectSTANDDb
            // 
            this.menuToolsCreateVConnectSTANDDb.Name = "menuToolsCreateVConnectSTANDDb";
            this.menuToolsCreateVConnectSTANDDb.Size = new System.Drawing.Size(223, 22);
            this.menuToolsCreateVConnectSTANDDb.Text = "Create vConnect-STAND DB";
            this.menuToolsCreateVConnectSTANDDb.Click += new System.EventHandler(this.menuToolsCreateVConnectSTANDDb_Click);
            // 
            // menuHelp
            // 
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHelpAbout,
            this.menuHelpManual,
            this.menuHelpCheckForUpdates,
            this.menuHelpLog,
            this.menuHelpDebug});
            this.menuHelp.ForeColor = System.Drawing.Color.White;
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(61, 20);
            this.menuHelp.Text = "Help(&H)";
            // 
            // menuHelpAbout
            // 
            this.menuHelpAbout.Name = "menuHelpAbout";
            this.menuHelpAbout.Size = new System.Drawing.Size(173, 22);
            this.menuHelpAbout.Text = "About Cadencii(&A)";
            // 
            // menuHelpManual
            // 
            this.menuHelpManual.Name = "menuHelpManual";
            this.menuHelpManual.Size = new System.Drawing.Size(173, 22);
            this.menuHelpManual.Text = "Manual (PDF)";
            // 
            // menuHelpCheckForUpdates
            // 
            this.menuHelpCheckForUpdates.Name = "menuHelpCheckForUpdates";
            this.menuHelpCheckForUpdates.Size = new System.Drawing.Size(173, 22);
            this.menuHelpCheckForUpdates.Text = "Check For Updates";
            this.menuHelpCheckForUpdates.Click += new System.EventHandler(this.menuHelpCheckForUpdates_Click);
            // 
            // menuHelpLog
            // 
            this.menuHelpLog.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHelpLogSwitch,
            this.menuHelpLogOpen});
            this.menuHelpLog.Name = "menuHelpLog";
            this.menuHelpLog.Size = new System.Drawing.Size(173, 22);
            this.menuHelpLog.Text = "Log(&L)";
            // 
            // menuHelpLogSwitch
            // 
            this.menuHelpLogSwitch.CheckOnClick = true;
            this.menuHelpLogSwitch.Name = "menuHelpLogSwitch";
            this.menuHelpLogSwitch.Size = new System.Drawing.Size(146, 22);
            this.menuHelpLogSwitch.Text = "Enable Log(&L)";
            // 
            // menuHelpLogOpen
            // 
            this.menuHelpLogOpen.Name = "menuHelpLogOpen";
            this.menuHelpLogOpen.Size = new System.Drawing.Size(146, 22);
            this.menuHelpLogOpen.Text = "Open(&O)";
            // 
            // menuHelpDebug
            // 
            this.menuHelpDebug.Name = "menuHelpDebug";
            this.menuHelpDebug.Size = new System.Drawing.Size(173, 22);
            this.menuHelpDebug.Text = "Debug";
            this.menuHelpDebug.Visible = false;
            // 
            // menuHidden
            // 
            this.menuHidden.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHiddenEditLyric,
            this.menuHiddenEditFlipToolPointerPencil,
            this.menuHiddenEditFlipToolPointerEraser,
            this.menuHiddenVisualForwardParameter,
            this.menuHiddenVisualBackwardParameter,
            this.menuHiddenTrackNext,
            this.menuHiddenTrackBack,
            this.menuHiddenCopy,
            this.menuHiddenPaste,
            this.menuHiddenCut,
            this.menuHiddenSelectForward,
            this.menuHiddenSelectBackward,
            this.menuHiddenMoveUp,
            this.menuHiddenMoveDown,
            this.menuHiddenMoveLeft,
            this.menuHiddenMoveRight,
            this.menuHiddenLengthen,
            this.menuHiddenShorten,
            this.menuHiddenGoToStartMarker,
            this.menuHiddenGoToEndMarker,
            this.menuHiddenPlayFromStartMarker,
            this.menuHiddenFlipCurveOnPianorollMode,
            this.menuHiddenPrintPoToCSV});
            this.menuHidden.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.menuHidden.Name = "menuHidden";
            this.menuHidden.Size = new System.Drawing.Size(89, 20);
            this.menuHidden.Text = "MenuHidden";
            this.menuHidden.Visible = false;
            // 
            // menuHiddenEditLyric
            // 
            this.menuHiddenEditLyric.Name = "menuHiddenEditLyric";
            this.menuHiddenEditLyric.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.menuHiddenEditLyric.Size = new System.Drawing.Size(282, 22);
            this.menuHiddenEditLyric.Text = "Start Lyric Input";
            this.menuHiddenEditLyric.Visible = false;
            // 
            // menuHiddenEditFlipToolPointerPencil
            // 
            this.menuHiddenEditFlipToolPointerPencil.Name = "menuHiddenEditFlipToolPointerPencil";
            this.menuHiddenEditFlipToolPointerPencil.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.menuHiddenEditFlipToolPointerPencil.Size = new System.Drawing.Size(282, 22);
            this.menuHiddenEditFlipToolPointerPencil.Text = "Change Tool Pointer / Pencil";
            this.menuHiddenEditFlipToolPointerPencil.Visible = false;
            // 
            // menuHiddenEditFlipToolPointerEraser
            // 
            this.menuHiddenEditFlipToolPointerEraser.Name = "menuHiddenEditFlipToolPointerEraser";
            this.menuHiddenEditFlipToolPointerEraser.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.menuHiddenEditFlipToolPointerEraser.Size = new System.Drawing.Size(282, 22);
            this.menuHiddenEditFlipToolPointerEraser.Text = "Change Tool Pointer/ Eraser";
            this.menuHiddenEditFlipToolPointerEraser.Visible = false;
            // 
            // menuHiddenVisualForwardParameter
            // 
            this.menuHiddenVisualForwardParameter.Name = "menuHiddenVisualForwardParameter";
            this.menuHiddenVisualForwardParameter.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.Next)));
            this.menuHiddenVisualForwardParameter.Size = new System.Drawing.Size(282, 22);
            this.menuHiddenVisualForwardParameter.Text = "Next Control Curve";
            this.menuHiddenVisualForwardParameter.Visible = false;
            // 
            // menuHiddenVisualBackwardParameter
            // 
            this.menuHiddenVisualBackwardParameter.Name = "menuHiddenVisualBackwardParameter";
            this.menuHiddenVisualBackwardParameter.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.PageUp)));
            this.menuHiddenVisualBackwardParameter.Size = new System.Drawing.Size(282, 22);
            this.menuHiddenVisualBackwardParameter.Text = "Previous Control Curve";
            this.menuHiddenVisualBackwardParameter.Visible = false;
            // 
            // menuHiddenTrackNext
            // 
            this.menuHiddenTrackNext.Name = "menuHiddenTrackNext";
            this.menuHiddenTrackNext.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Next)));
            this.menuHiddenTrackNext.Size = new System.Drawing.Size(282, 22);
            this.menuHiddenTrackNext.Text = "Next Track";
            this.menuHiddenTrackNext.Visible = false;
            // 
            // menuHiddenTrackBack
            // 
            this.menuHiddenTrackBack.Name = "menuHiddenTrackBack";
            this.menuHiddenTrackBack.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.PageUp)));
            this.menuHiddenTrackBack.Size = new System.Drawing.Size(282, 22);
            this.menuHiddenTrackBack.Text = "Previous Track";
            this.menuHiddenTrackBack.Visible = false;
            // 
            // menuHiddenCopy
            // 
            this.menuHiddenCopy.Name = "menuHiddenCopy";
            this.menuHiddenCopy.Size = new System.Drawing.Size(282, 22);
            this.menuHiddenCopy.Text = "Copy";
            // 
            // menuHiddenPaste
            // 
            this.menuHiddenPaste.Name = "menuHiddenPaste";
            this.menuHiddenPaste.Size = new System.Drawing.Size(282, 22);
            this.menuHiddenPaste.Text = "Paste";
            // 
            // menuHiddenCut
            // 
            this.menuHiddenCut.Name = "menuHiddenCut";
            this.menuHiddenCut.Size = new System.Drawing.Size(282, 22);
            this.menuHiddenCut.Text = "Cut";
            // 
            // menuHiddenSelectForward
            // 
            this.menuHiddenSelectForward.Name = "menuHiddenSelectForward";
            this.menuHiddenSelectForward.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Right)));
            this.menuHiddenSelectForward.Size = new System.Drawing.Size(282, 22);
            this.menuHiddenSelectForward.Text = "Select Forward";
            // 
            // menuHiddenSelectBackward
            // 
            this.menuHiddenSelectBackward.Name = "menuHiddenSelectBackward";
            this.menuHiddenSelectBackward.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Left)));
            this.menuHiddenSelectBackward.Size = new System.Drawing.Size(282, 22);
            this.menuHiddenSelectBackward.Text = "Select Backward";
            // 
            // menuHiddenMoveUp
            // 
            this.menuHiddenMoveUp.Name = "menuHiddenMoveUp";
            this.menuHiddenMoveUp.Size = new System.Drawing.Size(282, 22);
            this.menuHiddenMoveUp.Text = "Move Up";
            // 
            // menuHiddenMoveDown
            // 
            this.menuHiddenMoveDown.Name = "menuHiddenMoveDown";
            this.menuHiddenMoveDown.Size = new System.Drawing.Size(282, 22);
            this.menuHiddenMoveDown.Text = "Move Down";
            // 
            // menuHiddenMoveLeft
            // 
            this.menuHiddenMoveLeft.Name = "menuHiddenMoveLeft";
            this.menuHiddenMoveLeft.Size = new System.Drawing.Size(282, 22);
            this.menuHiddenMoveLeft.Text = "Move Left";
            // 
            // menuHiddenMoveRight
            // 
            this.menuHiddenMoveRight.Name = "menuHiddenMoveRight";
            this.menuHiddenMoveRight.Size = new System.Drawing.Size(282, 22);
            this.menuHiddenMoveRight.Text = "Move Right";
            // 
            // menuHiddenLengthen
            // 
            this.menuHiddenLengthen.Name = "menuHiddenLengthen";
            this.menuHiddenLengthen.Size = new System.Drawing.Size(282, 22);
            this.menuHiddenLengthen.Text = "Lengthen";
            // 
            // menuHiddenShorten
            // 
            this.menuHiddenShorten.Name = "menuHiddenShorten";
            this.menuHiddenShorten.Size = new System.Drawing.Size(282, 22);
            this.menuHiddenShorten.Text = "Shorten";
            // 
            // menuHiddenGoToStartMarker
            // 
            this.menuHiddenGoToStartMarker.Name = "menuHiddenGoToStartMarker";
            this.menuHiddenGoToStartMarker.Size = new System.Drawing.Size(282, 22);
            this.menuHiddenGoToStartMarker.Text = "GoTo Start Marker";
            // 
            // menuHiddenGoToEndMarker
            // 
            this.menuHiddenGoToEndMarker.Name = "menuHiddenGoToEndMarker";
            this.menuHiddenGoToEndMarker.Size = new System.Drawing.Size(282, 22);
            this.menuHiddenGoToEndMarker.Text = "GoTo End Marker";
            // 
            // menuHiddenPlayFromStartMarker
            // 
            this.menuHiddenPlayFromStartMarker.Name = "menuHiddenPlayFromStartMarker";
            this.menuHiddenPlayFromStartMarker.Size = new System.Drawing.Size(282, 22);
            this.menuHiddenPlayFromStartMarker.Text = "Play From Start Marker";
            // 
            // menuHiddenFlipCurveOnPianorollMode
            // 
            this.menuHiddenFlipCurveOnPianorollMode.Name = "menuHiddenFlipCurveOnPianorollMode";
            this.menuHiddenFlipCurveOnPianorollMode.Size = new System.Drawing.Size(282, 22);
            this.menuHiddenFlipCurveOnPianorollMode.Text = "Change pitch drawing mode";
            // 
            // menuHiddenPrintPoToCSV
            // 
            this.menuHiddenPrintPoToCSV.Name = "menuHiddenPrintPoToCSV";
            this.menuHiddenPrintPoToCSV.Size = new System.Drawing.Size(282, 22);
            this.menuHiddenPrintPoToCSV.Text = "Print language configs to CSV";
            // 
            // cMenuPiano
            // 
            this.cMenuPiano.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cMenuPianoPointer,
            this.cMenuPianoPencil,
            this.cMenuPianoEraser,
            this.cMenuPianoPaletteTool,
            this.toolStripSeparator15,
            this.cMenuPianoCurve,
            this.toolStripMenuItem13,
            this.cMenuPianoFixed,
            this.cMenuPianoQuantize,
            this.cMenuPianoGrid,
            this.toolStripMenuItem14,
            this.cMenuPianoUndo,
            this.cMenuPianoRedo,
            this.toolStripMenuItem15,
            this.cMenuPianoCut,
            this.cMenuPianoCopy,
            this.cMenuPianoPaste,
            this.cMenuPianoDelete,
            this.toolStripMenuItem16,
            this.cMenuPianoSelectAll,
            this.cMenuPianoSelectAllEvents,
            this.toolStripMenuItem17,
            this.cMenuPianoImportLyric,
            this.cMenuPianoExpressionProperty,
            this.cMenuPianoVibratoProperty});
            this.cMenuPiano.Name = "cMenuPiano";
            this.cMenuPiano.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.cMenuPiano.ShowCheckMargin = true;
            this.cMenuPiano.ShowImageMargin = false;
            this.cMenuPiano.Size = new System.Drawing.Size(222, 458);
            // 
            // cMenuPianoPointer
            // 
            this.cMenuPianoPointer.Name = "cMenuPianoPointer";
            this.cMenuPianoPointer.Size = new System.Drawing.Size(221, 22);
            this.cMenuPianoPointer.Text = "Arrow(&A)";
            // 
            // cMenuPianoPencil
            // 
            this.cMenuPianoPencil.Name = "cMenuPianoPencil";
            this.cMenuPianoPencil.Size = new System.Drawing.Size(221, 22);
            this.cMenuPianoPencil.Text = "Pencil(&W)";
            // 
            // cMenuPianoEraser
            // 
            this.cMenuPianoEraser.Name = "cMenuPianoEraser";
            this.cMenuPianoEraser.Size = new System.Drawing.Size(221, 22);
            this.cMenuPianoEraser.Text = "Eraser(&E)";
            // 
            // cMenuPianoPaletteTool
            // 
            this.cMenuPianoPaletteTool.Name = "cMenuPianoPaletteTool";
            this.cMenuPianoPaletteTool.Size = new System.Drawing.Size(221, 22);
            this.cMenuPianoPaletteTool.Text = "Palette Tool";
            // 
            // toolStripSeparator15
            // 
            this.toolStripSeparator15.Name = "toolStripSeparator15";
            this.toolStripSeparator15.Size = new System.Drawing.Size(218, 6);
            // 
            // cMenuPianoCurve
            // 
            this.cMenuPianoCurve.Name = "cMenuPianoCurve";
            this.cMenuPianoCurve.Size = new System.Drawing.Size(221, 22);
            this.cMenuPianoCurve.Text = "Curve(&V)";
            // 
            // toolStripMenuItem13
            // 
            this.toolStripMenuItem13.Name = "toolStripMenuItem13";
            this.toolStripMenuItem13.Size = new System.Drawing.Size(218, 6);
            // 
            // cMenuPianoFixed
            // 
            this.cMenuPianoFixed.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cMenuPianoFixed01,
            this.cMenuPianoFixed02,
            this.cMenuPianoFixed04,
            this.cMenuPianoFixed08,
            this.cMenuPianoFixed16,
            this.cMenuPianoFixed32,
            this.cMenuPianoFixed64,
            this.cMenuPianoFixed128,
            this.cMenuPianoFixedOff,
            this.toolStripMenuItem18,
            this.cMenuPianoFixedTriplet,
            this.cMenuPianoFixedDotted});
            this.cMenuPianoFixed.Name = "cMenuPianoFixed";
            this.cMenuPianoFixed.Size = new System.Drawing.Size(221, 22);
            this.cMenuPianoFixed.Text = "Note Fixed Length(&N)";
            // 
            // cMenuPianoFixed01
            // 
            this.cMenuPianoFixed01.Name = "cMenuPianoFixed01";
            this.cMenuPianoFixed01.Size = new System.Drawing.Size(129, 22);
            this.cMenuPianoFixed01.Text = "1/ 1 [1920]";
            // 
            // cMenuPianoFixed02
            // 
            this.cMenuPianoFixed02.Name = "cMenuPianoFixed02";
            this.cMenuPianoFixed02.Size = new System.Drawing.Size(129, 22);
            this.cMenuPianoFixed02.Text = "1/ 2 [960]";
            // 
            // cMenuPianoFixed04
            // 
            this.cMenuPianoFixed04.Name = "cMenuPianoFixed04";
            this.cMenuPianoFixed04.Size = new System.Drawing.Size(129, 22);
            this.cMenuPianoFixed04.Text = "1/ 4 [480]";
            // 
            // cMenuPianoFixed08
            // 
            this.cMenuPianoFixed08.Name = "cMenuPianoFixed08";
            this.cMenuPianoFixed08.Size = new System.Drawing.Size(129, 22);
            this.cMenuPianoFixed08.Text = "1/ 8 [240]";
            // 
            // cMenuPianoFixed16
            // 
            this.cMenuPianoFixed16.Name = "cMenuPianoFixed16";
            this.cMenuPianoFixed16.Size = new System.Drawing.Size(129, 22);
            this.cMenuPianoFixed16.Text = "1/16 [120]";
            // 
            // cMenuPianoFixed32
            // 
            this.cMenuPianoFixed32.Name = "cMenuPianoFixed32";
            this.cMenuPianoFixed32.Size = new System.Drawing.Size(129, 22);
            this.cMenuPianoFixed32.Text = "1/32 [60]";
            // 
            // cMenuPianoFixed64
            // 
            this.cMenuPianoFixed64.Name = "cMenuPianoFixed64";
            this.cMenuPianoFixed64.Size = new System.Drawing.Size(129, 22);
            this.cMenuPianoFixed64.Text = "1/64 [30]";
            // 
            // cMenuPianoFixed128
            // 
            this.cMenuPianoFixed128.Name = "cMenuPianoFixed128";
            this.cMenuPianoFixed128.Size = new System.Drawing.Size(129, 22);
            this.cMenuPianoFixed128.Text = "1/128[15]";
            // 
            // cMenuPianoFixedOff
            // 
            this.cMenuPianoFixedOff.Name = "cMenuPianoFixedOff";
            this.cMenuPianoFixedOff.Size = new System.Drawing.Size(129, 22);
            this.cMenuPianoFixedOff.Text = "オフ";
            // 
            // toolStripMenuItem18
            // 
            this.toolStripMenuItem18.Name = "toolStripMenuItem18";
            this.toolStripMenuItem18.Size = new System.Drawing.Size(126, 6);
            // 
            // cMenuPianoFixedTriplet
            // 
            this.cMenuPianoFixedTriplet.Name = "cMenuPianoFixedTriplet";
            this.cMenuPianoFixedTriplet.Size = new System.Drawing.Size(129, 22);
            this.cMenuPianoFixedTriplet.Text = "3連符";
            // 
            // cMenuPianoFixedDotted
            // 
            this.cMenuPianoFixedDotted.Name = "cMenuPianoFixedDotted";
            this.cMenuPianoFixedDotted.Size = new System.Drawing.Size(129, 22);
            this.cMenuPianoFixedDotted.Text = "付点";
            // 
            // cMenuPianoQuantize
            // 
            this.cMenuPianoQuantize.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cMenuPianoQuantize04,
            this.cMenuPianoQuantize08,
            this.cMenuPianoQuantize16,
            this.cMenuPianoQuantize32,
            this.cMenuPianoQuantize64,
            this.cMenuPianoQuantize128,
            this.cMenuPianoQuantizeOff,
            this.toolStripMenuItem26,
            this.cMenuPianoQuantizeTriplet});
            this.cMenuPianoQuantize.Name = "cMenuPianoQuantize";
            this.cMenuPianoQuantize.Size = new System.Drawing.Size(221, 22);
            this.cMenuPianoQuantize.Text = "Quantize(&Q)";
            // 
            // cMenuPianoQuantize04
            // 
            this.cMenuPianoQuantize04.Name = "cMenuPianoQuantize04";
            this.cMenuPianoQuantize04.Size = new System.Drawing.Size(104, 22);
            this.cMenuPianoQuantize04.Text = "1/4";
            // 
            // cMenuPianoQuantize08
            // 
            this.cMenuPianoQuantize08.Name = "cMenuPianoQuantize08";
            this.cMenuPianoQuantize08.Size = new System.Drawing.Size(104, 22);
            this.cMenuPianoQuantize08.Text = "1/8";
            // 
            // cMenuPianoQuantize16
            // 
            this.cMenuPianoQuantize16.Name = "cMenuPianoQuantize16";
            this.cMenuPianoQuantize16.Size = new System.Drawing.Size(104, 22);
            this.cMenuPianoQuantize16.Text = "1/16";
            // 
            // cMenuPianoQuantize32
            // 
            this.cMenuPianoQuantize32.Name = "cMenuPianoQuantize32";
            this.cMenuPianoQuantize32.Size = new System.Drawing.Size(104, 22);
            this.cMenuPianoQuantize32.Text = "1/32";
            // 
            // cMenuPianoQuantize64
            // 
            this.cMenuPianoQuantize64.Name = "cMenuPianoQuantize64";
            this.cMenuPianoQuantize64.Size = new System.Drawing.Size(104, 22);
            this.cMenuPianoQuantize64.Text = "1/64";
            // 
            // cMenuPianoQuantize128
            // 
            this.cMenuPianoQuantize128.Name = "cMenuPianoQuantize128";
            this.cMenuPianoQuantize128.Size = new System.Drawing.Size(104, 22);
            this.cMenuPianoQuantize128.Text = "1/128";
            // 
            // cMenuPianoQuantizeOff
            // 
            this.cMenuPianoQuantizeOff.Name = "cMenuPianoQuantizeOff";
            this.cMenuPianoQuantizeOff.Size = new System.Drawing.Size(104, 22);
            this.cMenuPianoQuantizeOff.Text = "オフ";
            // 
            // toolStripMenuItem26
            // 
            this.toolStripMenuItem26.Name = "toolStripMenuItem26";
            this.toolStripMenuItem26.Size = new System.Drawing.Size(101, 6);
            // 
            // cMenuPianoQuantizeTriplet
            // 
            this.cMenuPianoQuantizeTriplet.Name = "cMenuPianoQuantizeTriplet";
            this.cMenuPianoQuantizeTriplet.Size = new System.Drawing.Size(104, 22);
            this.cMenuPianoQuantizeTriplet.Text = "3連符";
            // 
            // cMenuPianoGrid
            // 
            this.cMenuPianoGrid.Name = "cMenuPianoGrid";
            this.cMenuPianoGrid.Size = new System.Drawing.Size(221, 22);
            this.cMenuPianoGrid.Text = "Show/Hide Grid Line(&S)";
            // 
            // toolStripMenuItem14
            // 
            this.toolStripMenuItem14.Name = "toolStripMenuItem14";
            this.toolStripMenuItem14.Size = new System.Drawing.Size(218, 6);
            // 
            // cMenuPianoUndo
            // 
            this.cMenuPianoUndo.Name = "cMenuPianoUndo";
            this.cMenuPianoUndo.Size = new System.Drawing.Size(221, 22);
            this.cMenuPianoUndo.Text = "Undo(&U)";
            // 
            // cMenuPianoRedo
            // 
            this.cMenuPianoRedo.Name = "cMenuPianoRedo";
            this.cMenuPianoRedo.Size = new System.Drawing.Size(221, 22);
            this.cMenuPianoRedo.Text = "Redo(&R)";
            // 
            // toolStripMenuItem15
            // 
            this.toolStripMenuItem15.Name = "toolStripMenuItem15";
            this.toolStripMenuItem15.Size = new System.Drawing.Size(218, 6);
            // 
            // cMenuPianoCut
            // 
            this.cMenuPianoCut.Name = "cMenuPianoCut";
            this.cMenuPianoCut.Size = new System.Drawing.Size(221, 22);
            this.cMenuPianoCut.Text = "Cut(&T)";
            // 
            // cMenuPianoCopy
            // 
            this.cMenuPianoCopy.Name = "cMenuPianoCopy";
            this.cMenuPianoCopy.Size = new System.Drawing.Size(221, 22);
            this.cMenuPianoCopy.Text = "Copy(&C)";
            // 
            // cMenuPianoPaste
            // 
            this.cMenuPianoPaste.Name = "cMenuPianoPaste";
            this.cMenuPianoPaste.Size = new System.Drawing.Size(221, 22);
            this.cMenuPianoPaste.Text = "Paste(&P)";
            // 
            // cMenuPianoDelete
            // 
            this.cMenuPianoDelete.Name = "cMenuPianoDelete";
            this.cMenuPianoDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.cMenuPianoDelete.Size = new System.Drawing.Size(221, 22);
            this.cMenuPianoDelete.Text = "Delete(&D)";
            // 
            // toolStripMenuItem16
            // 
            this.toolStripMenuItem16.Name = "toolStripMenuItem16";
            this.toolStripMenuItem16.Size = new System.Drawing.Size(218, 6);
            // 
            // cMenuPianoSelectAll
            // 
            this.cMenuPianoSelectAll.Name = "cMenuPianoSelectAll";
            this.cMenuPianoSelectAll.Size = new System.Drawing.Size(221, 22);
            this.cMenuPianoSelectAll.Text = "Select All(&A)";
            // 
            // cMenuPianoSelectAllEvents
            // 
            this.cMenuPianoSelectAllEvents.Name = "cMenuPianoSelectAllEvents";
            this.cMenuPianoSelectAllEvents.Size = new System.Drawing.Size(221, 22);
            this.cMenuPianoSelectAllEvents.Text = "Select All Events(&E)";
            // 
            // toolStripMenuItem17
            // 
            this.toolStripMenuItem17.Name = "toolStripMenuItem17";
            this.toolStripMenuItem17.Size = new System.Drawing.Size(218, 6);
            // 
            // cMenuPianoImportLyric
            // 
            this.cMenuPianoImportLyric.Name = "cMenuPianoImportLyric";
            this.cMenuPianoImportLyric.Size = new System.Drawing.Size(221, 22);
            this.cMenuPianoImportLyric.Text = "Insert Lyrics(&L)";
            // 
            // cMenuPianoExpressionProperty
            // 
            this.cMenuPianoExpressionProperty.Name = "cMenuPianoExpressionProperty";
            this.cMenuPianoExpressionProperty.Size = new System.Drawing.Size(221, 22);
            this.cMenuPianoExpressionProperty.Text = "Note Expression Property(&P)";
            // 
            // cMenuPianoVibratoProperty
            // 
            this.cMenuPianoVibratoProperty.Name = "cMenuPianoVibratoProperty";
            this.cMenuPianoVibratoProperty.Size = new System.Drawing.Size(221, 22);
            this.cMenuPianoVibratoProperty.Text = "Note Vibrato Property";
            // 
            // cMenuTrackTab
            // 
            this.cMenuTrackTab.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cMenuTrackTabTrackOn,
            this.toolStripMenuItem24,
            this.cMenuTrackTabAdd,
            this.cMenuTrackTabCopy,
            this.cMenuTrackTabChangeName,
            this.cMenuTrackTabDelete,
            this.toolStripMenuItem25,
            this.cMenuTrackTabRenderCurrent,
            this.cMenuTrackTabRenderAll,
            this.toolStripMenuItem27,
            this.cMenuTrackTabOverlay,
            this.cMenuTrackTabRenderer});
            this.cMenuTrackTab.Name = "cMenuTrackTab";
            this.cMenuTrackTab.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.cMenuTrackTab.ShowCheckMargin = true;
            this.cMenuTrackTab.ShowImageMargin = false;
            this.cMenuTrackTab.Size = new System.Drawing.Size(202, 220);
            // 
            // cMenuTrackTabTrackOn
            // 
            this.cMenuTrackTabTrackOn.Name = "cMenuTrackTabTrackOn";
            this.cMenuTrackTabTrackOn.Size = new System.Drawing.Size(201, 22);
            this.cMenuTrackTabTrackOn.Text = "Track On(&K)";
            // 
            // toolStripMenuItem24
            // 
            this.toolStripMenuItem24.Name = "toolStripMenuItem24";
            this.toolStripMenuItem24.Size = new System.Drawing.Size(198, 6);
            // 
            // cMenuTrackTabAdd
            // 
            this.cMenuTrackTabAdd.Name = "cMenuTrackTabAdd";
            this.cMenuTrackTabAdd.Size = new System.Drawing.Size(201, 22);
            this.cMenuTrackTabAdd.Text = "Add Track(&A)";
            // 
            // cMenuTrackTabCopy
            // 
            this.cMenuTrackTabCopy.Name = "cMenuTrackTabCopy";
            this.cMenuTrackTabCopy.Size = new System.Drawing.Size(201, 22);
            this.cMenuTrackTabCopy.Text = "Copy Track(&C)";
            // 
            // cMenuTrackTabChangeName
            // 
            this.cMenuTrackTabChangeName.Name = "cMenuTrackTabChangeName";
            this.cMenuTrackTabChangeName.Size = new System.Drawing.Size(201, 22);
            this.cMenuTrackTabChangeName.Text = "Rename Track";
            // 
            // cMenuTrackTabDelete
            // 
            this.cMenuTrackTabDelete.Name = "cMenuTrackTabDelete";
            this.cMenuTrackTabDelete.Size = new System.Drawing.Size(201, 22);
            this.cMenuTrackTabDelete.Text = "Delete Track(&D)";
            // 
            // toolStripMenuItem25
            // 
            this.toolStripMenuItem25.Name = "toolStripMenuItem25";
            this.toolStripMenuItem25.Size = new System.Drawing.Size(198, 6);
            // 
            // cMenuTrackTabRenderCurrent
            // 
            this.cMenuTrackTabRenderCurrent.Name = "cMenuTrackTabRenderCurrent";
            this.cMenuTrackTabRenderCurrent.Size = new System.Drawing.Size(201, 22);
            this.cMenuTrackTabRenderCurrent.Text = "Render Current Track(&T)";
            // 
            // cMenuTrackTabRenderAll
            // 
            this.cMenuTrackTabRenderAll.Name = "cMenuTrackTabRenderAll";
            this.cMenuTrackTabRenderAll.Size = new System.Drawing.Size(201, 22);
            this.cMenuTrackTabRenderAll.Text = "Render All Tracks(&S)";
            // 
            // toolStripMenuItem27
            // 
            this.toolStripMenuItem27.Name = "toolStripMenuItem27";
            this.toolStripMenuItem27.Size = new System.Drawing.Size(198, 6);
            // 
            // cMenuTrackTabOverlay
            // 
            this.cMenuTrackTabOverlay.Name = "cMenuTrackTabOverlay";
            this.cMenuTrackTabOverlay.Size = new System.Drawing.Size(201, 22);
            this.cMenuTrackTabOverlay.Text = "Overlay(&O)";
            // 
            // cMenuTrackTabRenderer
            // 
            this.cMenuTrackTabRenderer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cMenuTrackTabRendererVOCALOID1,
            this.cMenuTrackTabRendererVOCALOID2,
            this.cMenuTrackTabRendererUtau,
            this.cMenuTrackTabRendererStraight,
            this.cMenuTrackTabRendererAquesTone,
            this.cMenuTrackTabRendererAquesTone2});
            this.cMenuTrackTabRenderer.Name = "cMenuTrackTabRenderer";
            this.cMenuTrackTabRenderer.Size = new System.Drawing.Size(201, 22);
            this.cMenuTrackTabRenderer.Text = "Renderer(&R)";
            // 
            // cMenuTrackTabRendererVOCALOID1
            // 
            this.cMenuTrackTabRendererVOCALOID1.Name = "cMenuTrackTabRendererVOCALOID1";
            this.cMenuTrackTabRendererVOCALOID1.Size = new System.Drawing.Size(185, 22);
            this.cMenuTrackTabRendererVOCALOID1.Text = "VOCALOID1(&1)";
            // 
            // cMenuTrackTabRendererVOCALOID2
            // 
            this.cMenuTrackTabRendererVOCALOID2.Name = "cMenuTrackTabRendererVOCALOID2";
            this.cMenuTrackTabRendererVOCALOID2.Size = new System.Drawing.Size(185, 22);
            this.cMenuTrackTabRendererVOCALOID2.Text = "VOCALOID2(&2)";
            // 
            // cMenuTrackTabRendererUtau
            // 
            this.cMenuTrackTabRendererUtau.Name = "cMenuTrackTabRendererUtau";
            this.cMenuTrackTabRendererUtau.Size = new System.Drawing.Size(185, 22);
            this.cMenuTrackTabRendererUtau.Text = "UTAU(&3)";
            // 
            // cMenuTrackTabRendererStraight
            // 
            this.cMenuTrackTabRendererStraight.Name = "cMenuTrackTabRendererStraight";
            this.cMenuTrackTabRendererStraight.Size = new System.Drawing.Size(185, 22);
            this.cMenuTrackTabRendererStraight.Text = "vConnect-STAND(&4) ";
            // 
            // cMenuTrackTabRendererAquesTone
            // 
            this.cMenuTrackTabRendererAquesTone.Name = "cMenuTrackTabRendererAquesTone";
            this.cMenuTrackTabRendererAquesTone.Size = new System.Drawing.Size(185, 22);
            this.cMenuTrackTabRendererAquesTone.Text = "AquesTone(&5)";
            // 
            // cMenuTrackTabRendererAquesTone2
            // 
            this.cMenuTrackTabRendererAquesTone2.Name = "cMenuTrackTabRendererAquesTone2";
            this.cMenuTrackTabRendererAquesTone2.Size = new System.Drawing.Size(185, 22);
            this.cMenuTrackTabRendererAquesTone2.Text = "AquesTone2(&6)";
            this.cMenuTrackTabRendererAquesTone2.Click += new System.EventHandler(this.handleChangeRenderer);
            // 
            // cMenuTrackSelector
            // 
            this.cMenuTrackSelector.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cMenuTrackSelectorPointer,
            this.cMenuTrackSelectorPencil,
            this.cMenuTrackSelectorLine,
            this.cMenuTrackSelectorEraser,
            this.cMenuTrackSelectorPaletteTool,
            this.toolStripSeparator14,
            this.cMenuTrackSelectorCurve,
            this.toolStripMenuItem28,
            this.cMenuTrackSelectorUndo,
            this.cMenuTrackSelectorRedo,
            this.toolStripMenuItem29,
            this.cMenuTrackSelectorCut,
            this.cMenuTrackSelectorCopy,
            this.cMenuTrackSelectorPaste,
            this.cMenuTrackSelectorDelete,
            this.cMenuTrackSelectorDeleteBezier,
            this.toolStripMenuItem31,
            this.cMenuTrackSelectorSelectAll});
            this.cMenuTrackSelector.Name = "cMenuTrackSelector";
            this.cMenuTrackSelector.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.cMenuTrackSelector.ShowCheckMargin = true;
            this.cMenuTrackSelector.ShowImageMargin = false;
            this.cMenuTrackSelector.Size = new System.Drawing.Size(188, 336);
            // 
            // cMenuTrackSelectorPointer
            // 
            this.cMenuTrackSelectorPointer.Name = "cMenuTrackSelectorPointer";
            this.cMenuTrackSelectorPointer.Size = new System.Drawing.Size(187, 22);
            this.cMenuTrackSelectorPointer.Text = "Arrow(&A)";
            // 
            // cMenuTrackSelectorPencil
            // 
            this.cMenuTrackSelectorPencil.Name = "cMenuTrackSelectorPencil";
            this.cMenuTrackSelectorPencil.Size = new System.Drawing.Size(187, 22);
            this.cMenuTrackSelectorPencil.Text = "Pencil(&W)";
            // 
            // cMenuTrackSelectorLine
            // 
            this.cMenuTrackSelectorLine.Name = "cMenuTrackSelectorLine";
            this.cMenuTrackSelectorLine.Size = new System.Drawing.Size(187, 22);
            this.cMenuTrackSelectorLine.Text = "Line(&L)";
            // 
            // cMenuTrackSelectorEraser
            // 
            this.cMenuTrackSelectorEraser.Name = "cMenuTrackSelectorEraser";
            this.cMenuTrackSelectorEraser.Size = new System.Drawing.Size(187, 22);
            this.cMenuTrackSelectorEraser.Text = "Eraser(&E)";
            // 
            // cMenuTrackSelectorPaletteTool
            // 
            this.cMenuTrackSelectorPaletteTool.Name = "cMenuTrackSelectorPaletteTool";
            this.cMenuTrackSelectorPaletteTool.Size = new System.Drawing.Size(187, 22);
            this.cMenuTrackSelectorPaletteTool.Text = "Palette Tool";
            // 
            // toolStripSeparator14
            // 
            this.toolStripSeparator14.Name = "toolStripSeparator14";
            this.toolStripSeparator14.Size = new System.Drawing.Size(184, 6);
            // 
            // cMenuTrackSelectorCurve
            // 
            this.cMenuTrackSelectorCurve.Name = "cMenuTrackSelectorCurve";
            this.cMenuTrackSelectorCurve.Size = new System.Drawing.Size(187, 22);
            this.cMenuTrackSelectorCurve.Text = "Curve(&V)";
            // 
            // toolStripMenuItem28
            // 
            this.toolStripMenuItem28.Name = "toolStripMenuItem28";
            this.toolStripMenuItem28.Size = new System.Drawing.Size(184, 6);
            // 
            // cMenuTrackSelectorUndo
            // 
            this.cMenuTrackSelectorUndo.Name = "cMenuTrackSelectorUndo";
            this.cMenuTrackSelectorUndo.Size = new System.Drawing.Size(187, 22);
            this.cMenuTrackSelectorUndo.Text = "Undo(&U)";
            // 
            // cMenuTrackSelectorRedo
            // 
            this.cMenuTrackSelectorRedo.Name = "cMenuTrackSelectorRedo";
            this.cMenuTrackSelectorRedo.Size = new System.Drawing.Size(187, 22);
            this.cMenuTrackSelectorRedo.Text = "Redo(&R)";
            // 
            // toolStripMenuItem29
            // 
            this.toolStripMenuItem29.Name = "toolStripMenuItem29";
            this.toolStripMenuItem29.Size = new System.Drawing.Size(184, 6);
            // 
            // cMenuTrackSelectorCut
            // 
            this.cMenuTrackSelectorCut.Name = "cMenuTrackSelectorCut";
            this.cMenuTrackSelectorCut.Size = new System.Drawing.Size(187, 22);
            this.cMenuTrackSelectorCut.Text = "Cut(&T)";
            // 
            // cMenuTrackSelectorCopy
            // 
            this.cMenuTrackSelectorCopy.Name = "cMenuTrackSelectorCopy";
            this.cMenuTrackSelectorCopy.Size = new System.Drawing.Size(187, 22);
            this.cMenuTrackSelectorCopy.Text = "Copy(&C)";
            // 
            // cMenuTrackSelectorPaste
            // 
            this.cMenuTrackSelectorPaste.Name = "cMenuTrackSelectorPaste";
            this.cMenuTrackSelectorPaste.Size = new System.Drawing.Size(187, 22);
            this.cMenuTrackSelectorPaste.Text = "Paste(&P)";
            // 
            // cMenuTrackSelectorDelete
            // 
            this.cMenuTrackSelectorDelete.Name = "cMenuTrackSelectorDelete";
            this.cMenuTrackSelectorDelete.Size = new System.Drawing.Size(187, 22);
            this.cMenuTrackSelectorDelete.Text = "Delete(&D)";
            // 
            // cMenuTrackSelectorDeleteBezier
            // 
            this.cMenuTrackSelectorDeleteBezier.Name = "cMenuTrackSelectorDeleteBezier";
            this.cMenuTrackSelectorDeleteBezier.Size = new System.Drawing.Size(187, 22);
            this.cMenuTrackSelectorDeleteBezier.Text = "Delete Bezier Point(&B)";
            // 
            // toolStripMenuItem31
            // 
            this.toolStripMenuItem31.Name = "toolStripMenuItem31";
            this.toolStripMenuItem31.Size = new System.Drawing.Size(184, 6);
            // 
            // cMenuTrackSelectorSelectAll
            // 
            this.cMenuTrackSelectorSelectAll.Name = "cMenuTrackSelectorSelectAll";
            this.cMenuTrackSelectorSelectAll.Size = new System.Drawing.Size(187, 22);
            this.cMenuTrackSelectorSelectAll.Text = "Select All Events(&E)";
            // 
            // trackBar
            // 
            this.trackBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar.AutoSize = false;
            this.trackBar.Location = new System.Drawing.Point(322, 285);
            this.trackBar.Margin = new System.Windows.Forms.Padding(0);
            this.trackBar.Maximum = 609;
            this.trackBar.Minimum = 17;
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(83, 17);
            this.trackBar.TabIndex = 15;
            this.trackBar.TabStop = false;
            this.trackBar.TickFrequency = 100;
            this.trackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar.Value = 17;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.pictureBox3.Location = new System.Drawing.Point(0, 285);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(49, 17);
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictKeyLengthSplitter
            // 
            this.pictKeyLengthSplitter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictKeyLengthSplitter.BackColor = System.Drawing.SystemColors.Control;
            this.pictKeyLengthSplitter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictKeyLengthSplitter.Cursor = System.Windows.Forms.Cursors.NoMoveHoriz;
            this.pictKeyLengthSplitter.Location = new System.Drawing.Point(49, 285);
            this.pictKeyLengthSplitter.Margin = new System.Windows.Forms.Padding(0);
            this.pictKeyLengthSplitter.Name = "pictKeyLengthSplitter";
            this.pictKeyLengthSplitter.Size = new System.Drawing.Size(16, 17);
            this.pictKeyLengthSplitter.TabIndex = 20;
            this.pictKeyLengthSplitter.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox2.Location = new System.Drawing.Point(405, 250);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(16, 52);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // vScroll
            // 
            this.vScroll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vScroll.Location = new System.Drawing.Point(405, 102);
            this.vScroll.Name = "vScroll";
            this.vScroll.Size = new System.Drawing.Size(16, 148);
            this.vScroll.TabIndex = 17;
            this.vScroll.ValueChanged += new System.EventHandler(this.vScroll_ValueChanged_1);
            // 
            // picturePositionIndicator
            // 
            this.picturePositionIndicator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picturePositionIndicator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.picturePositionIndicator.Location = new System.Drawing.Point(0, 50);
            this.picturePositionIndicator.Margin = new System.Windows.Forms.Padding(0);
            this.picturePositionIndicator.Name = "picturePositionIndicator";
            this.picturePositionIndicator.Size = new System.Drawing.Size(700, 52);
            this.picturePositionIndicator.TabIndex = 10;
            this.picturePositionIndicator.TabStop = false;
            // 
            // toolStripBottom
            // 
            this.toolStripBottom.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripBottom.Location = new System.Drawing.Point(14, 686);
            this.toolStripBottom.Name = "toolStripBottom";
            this.toolStripBottom.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStripBottom.Size = new System.Drawing.Size(111, 25);
            this.toolStripBottom.TabIndex = 22;
            this.toolStripBottom.Visible = false;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(91, 20);
            this.toolStripStatusLabel1.Text = "Game Controler";
            // 
            // stripLblGameCtrlMode
            // 
            this.stripLblGameCtrlMode.Name = "stripLblGameCtrlMode";
            this.stripLblGameCtrlMode.Size = new System.Drawing.Size(52, 20);
            this.stripLblGameCtrlMode.Text = "Disabled";
            this.stripLblGameCtrlMode.ToolTipText = "Game Controler";
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(45, 20);
            this.toolStripStatusLabel2.Text = "MIDI In";
            // 
            // stripLblMidiIn
            // 
            this.stripLblMidiIn.Name = "stripLblMidiIn";
            this.stripLblMidiIn.Size = new System.Drawing.Size(52, 20);
            this.stripLblMidiIn.Text = "Disabled";
            this.stripLblMidiIn.ToolTipText = "Midi In Device";
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(6, 25);
            // 
            // stripBtnStepSequencer
            // 
            this.stripBtnStepSequencer.CheckOnClick = true;
            this.stripBtnStepSequencer.Image = ((System.Drawing.Image)(resources.GetObject("stripBtnStepSequencer.Image")));
            this.stripBtnStepSequencer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stripBtnStepSequencer.Name = "stripBtnStepSequencer";
            this.stripBtnStepSequencer.Size = new System.Drawing.Size(50, 22);
            this.stripBtnStepSequencer.Text = "Step";
            // 
            // splitContainerProperty
            // 
            this.splitContainerProperty.Controls.Add(this.splitContainer2);
            this.splitContainerProperty.FixedPanel = System.Windows.Forms.FixedPanel.None;
            this.splitContainerProperty.IsSplitterFixed = false;
            this.splitContainerProperty.Location = new System.Drawing.Point(448, 15);
            this.splitContainerProperty.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainerProperty.Name = "splitContainerProperty";
            this.splitContainerProperty.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // 
            // 
            this.splitContainerProperty.Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerProperty.Panel1.BorderColor = System.Drawing.Color.Black;
            this.splitContainerProperty.Panel1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerProperty.Panel1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.splitContainerProperty.Panel1.Name = "m_panel1";
            this.splitContainerProperty.Panel1.Size = new System.Drawing.Size(42, 377);
            this.splitContainerProperty.Panel1.TabIndex = 0;
            this.splitContainerProperty.Panel1MinSize = 25;
            // 
            // 
            // 
            this.splitContainerProperty.Panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerProperty.Panel2.BorderColor = System.Drawing.Color.Black;
            this.splitContainerProperty.Panel2.Location = new System.Drawing.Point(46, 0);
            this.splitContainerProperty.Panel2.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainerProperty.Panel2.Name = "m_panel2";
            this.splitContainerProperty.Panel2.Size = new System.Drawing.Size(66, 377);
            this.splitContainerProperty.Panel2.TabIndex = 1;
            this.splitContainerProperty.Panel2MinSize = 25;
            this.splitContainerProperty.Size = new System.Drawing.Size(112, 377);
            this.splitContainerProperty.SplitterDistance = 42;
            this.splitContainerProperty.SplitterWidth = 4;
            this.splitContainerProperty.TabIndex = 20;
            this.splitContainerProperty.TabStop = false;
            this.splitContainerProperty.Text = "bSplitContainer1";
            // 
            // splitContainer2
            // 
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.IsSplitterFixed = false;
            this.splitContainer2.Location = new System.Drawing.Point(0, 374);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Vertical;
            // 
            // 
            // 
            this.splitContainer2.Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer2.Panel1.BorderColor = System.Drawing.Color.Black;
            this.splitContainer2.Panel1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Panel1.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer2.Panel1.Name = "m_panel1";
            this.splitContainer2.Panel1.Size = new System.Drawing.Size(115, 36);
            this.splitContainer2.Panel1.TabIndex = 0;
            this.splitContainer2.Panel1MinSize = 25;
            // 
            // 
            // 
            this.splitContainer2.Panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer2.Panel2.BorderColor = System.Drawing.Color.Black;
            this.splitContainer2.Panel2.Location = new System.Drawing.Point(0, 40);
            this.splitContainer2.Panel2.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer2.Panel2.Name = "m_panel2";
            this.splitContainer2.Panel2.Size = new System.Drawing.Size(115, 105);
            this.splitContainer2.Panel2.TabIndex = 1;
            this.splitContainer2.Panel2MinSize = 25;
            this.splitContainer2.Size = new System.Drawing.Size(115, 145);
            this.splitContainer2.SplitterDistance = 36;
            this.splitContainer2.SplitterWidth = 4;
            this.splitContainer2.TabIndex = 23;
            this.splitContainer2.TabStop = false;
            this.splitContainer2.Text = "bSplitContainer1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.IsSplitterFixed = false;
            this.splitContainer1.Location = new System.Drawing.Point(2, 2);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer1.MinimumSize = new System.Drawing.Size(0, 59);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Vertical;
            // 
            // 
            // 
            this.splitContainer1.Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Panel1.BorderColor = System.Drawing.Color.Black;
            this.splitContainer1.Panel1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Panel1.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer1.Panel1.Name = "m_panel1";
            this.splitContainer1.Panel1.Size = new System.Drawing.Size(953, 55);
            this.splitContainer1.Panel1.TabIndex = 0;
            this.splitContainer1.Panel1MinSize = 25;
            // 
            // 
            // 
            this.splitContainer1.Panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Panel2.BorderColor = System.Drawing.Color.Black;
            this.splitContainer1.Panel2.Location = new System.Drawing.Point(0, 59);
            this.splitContainer1.Panel2.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer1.Panel2.Name = "m_panel2";
            this.splitContainer1.Panel2.Size = new System.Drawing.Size(953, 25);
            this.splitContainer1.Panel2.TabIndex = 1;
            this.splitContainer1.Panel2MinSize = 25;
            this.splitContainer1.Size = new System.Drawing.Size(953, 59);
            this.splitContainer1.SplitterDistance = 55;
            this.splitContainer1.SplitterWidth = 4;
            this.splitContainer1.TabIndex = 4;
            this.splitContainer1.TabStop = false;
            this.splitContainer1.Text = "splitContainerEx1";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(57, 6);
            // 
            // stripDDBtnQuantize
            // 
            this.stripDDBtnQuantize.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.stripDDBtnQuantize04,
            this.stripDDBtnQuantize08,
            this.stripDDBtnQuantize16,
            this.stripDDBtnQuantize32,
            this.stripDDBtnQuantize64,
            this.stripDDBtnQuantize128,
            this.stripDDBtnQuantizeOff,
            this.menuItem2,
            this.stripDDBtnQuantizeTriplet});
            // 
            // stripDDBtnQuantize04
            // 
            this.stripDDBtnQuantize04.Index = 0;
            this.stripDDBtnQuantize04.Text = "1/4";
            // 
            // stripDDBtnQuantize08
            // 
            this.stripDDBtnQuantize08.Index = 1;
            this.stripDDBtnQuantize08.Text = "1/8";
            // 
            // stripDDBtnQuantize16
            // 
            this.stripDDBtnQuantize16.Index = 2;
            this.stripDDBtnQuantize16.Text = "1/16";
            // 
            // stripDDBtnQuantize32
            // 
            this.stripDDBtnQuantize32.Index = 3;
            this.stripDDBtnQuantize32.Text = "1/32";
            // 
            // stripDDBtnQuantize64
            // 
            this.stripDDBtnQuantize64.Index = 4;
            this.stripDDBtnQuantize64.Text = "1/64";
            // 
            // stripDDBtnQuantize128
            // 
            this.stripDDBtnQuantize128.Index = 5;
            this.stripDDBtnQuantize128.Text = "1/128";
            // 
            // stripDDBtnQuantizeOff
            // 
            this.stripDDBtnQuantizeOff.Index = 6;
            this.stripDDBtnQuantizeOff.Text = "Off";
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 7;
            this.menuItem2.Text = "-";
            // 
            // stripDDBtnQuantizeTriplet
            // 
            this.stripDDBtnQuantizeTriplet.Index = 8;
            this.stripDDBtnQuantizeTriplet.Text = "Triplet";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(57, 6);
            // 
            // imageListFile
            // 
            this.imageListFile.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListFile.ImageStream")));
            this.imageListFile.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListFile.Images.SetKeyName(0, "disk__plus.png");
            this.imageListFile.Images.SetKeyName(1, "folder_horizontal_open.png");
            this.imageListFile.Images.SetKeyName(2, "disk.png");
            this.imageListFile.Images.SetKeyName(3, "scissors.png");
            this.imageListFile.Images.SetKeyName(4, "documents.png");
            this.imageListFile.Images.SetKeyName(5, "clipboard_paste.png");
            this.imageListFile.Images.SetKeyName(6, "arrow_skip_180.png");
            this.imageListFile.Images.SetKeyName(7, "arrow_skip.png");
            // 
            // imageListPosition
            // 
            this.imageListPosition.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListPosition.ImageStream")));
            this.imageListPosition.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListPosition.Images.SetKeyName(0, "control_stop_180.png");
            this.imageListPosition.Images.SetKeyName(1, "control_double_180.png");
            this.imageListPosition.Images.SetKeyName(2, "control_double.png");
            this.imageListPosition.Images.SetKeyName(3, "control_stop.png");
            this.imageListPosition.Images.SetKeyName(4, "control.png");
            this.imageListPosition.Images.SetKeyName(5, "control_pause.png");
            this.imageListPosition.Images.SetKeyName(6, "arrow_circle_double.png");
            this.imageListPosition.Images.SetKeyName(7, "arrow_return.png");
            // 
            // imageListMeasure
            // 
            this.imageListMeasure.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListMeasure.ImageStream")));
            this.imageListMeasure.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListMeasure.Images.SetKeyName(0, "pin__arrow.png");
            this.imageListMeasure.Images.SetKeyName(1, "pin__arrow_inv.png");
            this.imageListMeasure.Images.SetKeyName(2, "note001.png");
            this.imageListMeasure.Images.SetKeyName(3, "note002.png");
            this.imageListMeasure.Images.SetKeyName(4, "note004.png");
            this.imageListMeasure.Images.SetKeyName(5, "note008.png");
            this.imageListMeasure.Images.SetKeyName(6, "note016.png");
            this.imageListMeasure.Images.SetKeyName(7, "note032.png");
            this.imageListMeasure.Images.SetKeyName(8, "note064.png");
            this.imageListMeasure.Images.SetKeyName(9, "note128.png");
            this.imageListMeasure.Images.SetKeyName(10, "notenull.png");
            // 
            // imageListTool
            // 
            this.imageListTool.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListTool.ImageStream")));
            this.imageListTool.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListTool.Images.SetKeyName(0, "arrow_135.png");
            this.imageListTool.Images.SetKeyName(1, "pencil.png");
            this.imageListTool.Images.SetKeyName(2, "layer_shape_line.png");
            this.imageListTool.Images.SetKeyName(3, "eraser.png");
            this.imageListTool.Images.SetKeyName(4, "ruler_crop.png");
            this.imageListTool.Images.SetKeyName(5, "layer_shape_curve.png");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictKeyLengthSplitter);
            this.panel1.Controls.Add(this.panelOverview);
            this.panel1.Controls.Add(this.picturePositionIndicator);
            this.panel1.Controls.Add(this.pictPianoRoll);
            this.panel1.Controls.Add(this.vScroll);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.hScroll);
            this.panel1.Controls.Add(this.trackBar);
            this.panel1.Location = new System.Drawing.Point(15, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 302);
            this.panel1.TabIndex = 24;
            // 
            // panelOverview
            // 
            this.panelOverview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelOverview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.panelOverview.Location = new System.Drawing.Point(0, 1);
            this.panelOverview.Margin = new System.Windows.Forms.Padding(0);
            this.panelOverview.Name = "panelOverview";
            this.panelOverview.Size = new System.Drawing.Size(700, 49);
            this.panelOverview.TabIndex = 19;
            this.panelOverview.TabStop = false;
            // 
            // pictPianoRoll
            // 
            this.pictPianoRoll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictPianoRoll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.pictPianoRoll.Location = new System.Drawing.Point(0, 102);
            this.pictPianoRoll.Margin = new System.Windows.Forms.Padding(0);
            this.pictPianoRoll.Name = "pictPianoRoll";
            this.pictPianoRoll.Size = new System.Drawing.Size(405, 183);
            this.pictPianoRoll.TabIndex = 12;
            this.pictPianoRoll.TabStop = false;
            // 
            // hScroll
            // 
            this.hScroll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hScroll.Location = new System.Drawing.Point(65, 285);
            this.hScroll.Name = "hScroll";
            this.hScroll.Size = new System.Drawing.Size(257, 16);
            this.hScroll.TabIndex = 16;
            this.hScroll.ValueChanged += new System.EventHandler(this.hScroll_ValueChanged_1);
            // 
            // rebar
            // 
            this.rebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.rebar.BackgroundImage = global::cadencii.Properties.Resources.toolbarBKG;
            this.rebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.rebar.EmbossHighlight = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.rebar.ForeColor = System.Drawing.Color.White;
            this.rebar.Location = new System.Drawing.Point(0, 24);
            this.rebar.Name = "rebar";
            this.rebar.Size = new System.Drawing.Size(955, 0);
            this.rebar.TabIndex = 19;
            this.rebar.ToggleDoubleClick = true;
            // 
            // imageListMenu
            // 
            this.imageListMenu.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageListMenu.ImageSize = new System.Drawing.Size(1, 16);
            this.imageListMenu.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // toolBarFile
            // 
            this.toolBarFile.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
            this.toolBarFile.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.stripBtnFileNew,
            this.stripBtnFileOpen,
            this.stripBtnFileSave,
            this.toolBarButton1,
            this.stripBtnCut,
            this.stripBtnCopy,
            this.stripBtnPaste,
            this.toolBarButton2,
            this.stripBtnUndo,
            this.stripBtnRedo});
            this.toolBarFile.ButtonSize = new System.Drawing.Size(23, 22);
            this.toolBarFile.Divider = false;
            this.toolBarFile.Dock = System.Windows.Forms.DockStyle.None;
            this.toolBarFile.DropDownArrows = true;
            this.toolBarFile.ImageList = this.imageListFile;
            this.toolBarFile.Location = new System.Drawing.Point(11, 2);
            this.toolBarFile.Name = "toolBarFile";
            this.toolBarFile.ShowToolTips = true;
            this.toolBarFile.Size = new System.Drawing.Size(944, 26);
            this.toolBarFile.TabIndex = 25;
            this.toolBarFile.Wrappable = false;
            // 
            // stripBtnFileNew
            // 
            this.stripBtnFileNew.ImageIndex = 0;
            this.stripBtnFileNew.Name = "stripBtnFileNew";
            this.stripBtnFileNew.ToolTipText = "New";
            // 
            // stripBtnFileOpen
            // 
            this.stripBtnFileOpen.ImageIndex = 1;
            this.stripBtnFileOpen.Name = "stripBtnFileOpen";
            this.stripBtnFileOpen.ToolTipText = "Open";
            // 
            // stripBtnFileSave
            // 
            this.stripBtnFileSave.ImageIndex = 2;
            this.stripBtnFileSave.Name = "stripBtnFileSave";
            this.stripBtnFileSave.ToolTipText = "Save";
            // 
            // toolBarButton1
            // 
            this.toolBarButton1.Name = "toolBarButton1";
            this.toolBarButton1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // stripBtnCut
            // 
            this.stripBtnCut.ImageIndex = 3;
            this.stripBtnCut.Name = "stripBtnCut";
            this.stripBtnCut.ToolTipText = "Cut";
            // 
            // stripBtnCopy
            // 
            this.stripBtnCopy.ImageIndex = 4;
            this.stripBtnCopy.Name = "stripBtnCopy";
            this.stripBtnCopy.ToolTipText = "Copy";
            // 
            // stripBtnPaste
            // 
            this.stripBtnPaste.ImageIndex = 5;
            this.stripBtnPaste.Name = "stripBtnPaste";
            this.stripBtnPaste.ToolTipText = "Paste";
            // 
            // toolBarButton2
            // 
            this.toolBarButton2.Name = "toolBarButton2";
            this.toolBarButton2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // stripBtnUndo
            // 
            this.stripBtnUndo.ImageIndex = 6;
            this.stripBtnUndo.Name = "stripBtnUndo";
            this.stripBtnUndo.ToolTipText = "Undo";
            // 
            // stripBtnRedo
            // 
            this.stripBtnRedo.ImageIndex = 7;
            this.stripBtnRedo.Name = "stripBtnRedo";
            this.stripBtnRedo.ToolTipText = "Redo";
            // 
            // toolBarPosition
            // 
            this.toolBarPosition.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
            this.toolBarPosition.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.stripBtnMoveTop,
            this.stripBtnRewind,
            this.stripBtnForward,
            this.stripBtnMoveEnd,
            this.stripBtnPlay,
            this.toolBarButton4,
            this.stripBtnScroll,
            this.stripBtnLoop});
            this.toolBarPosition.Divider = false;
            this.toolBarPosition.Dock = System.Windows.Forms.DockStyle.None;
            this.toolBarPosition.DropDownArrows = true;
            this.toolBarPosition.ImageList = this.imageListPosition;
            this.toolBarPosition.Location = new System.Drawing.Point(11, 32);
            this.toolBarPosition.Name = "toolBarPosition";
            this.toolBarPosition.ShowToolTips = true;
            this.toolBarPosition.Size = new System.Drawing.Size(944, 40);
            this.toolBarPosition.TabIndex = 25;
            this.toolBarPosition.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
            this.toolBarPosition.Wrappable = false;
            // 
            // stripBtnMoveTop
            // 
            this.stripBtnMoveTop.ImageIndex = 0;
            this.stripBtnMoveTop.Name = "stripBtnMoveTop";
            this.stripBtnMoveTop.ToolTipText = "MoveTop";
            // 
            // stripBtnRewind
            // 
            this.stripBtnRewind.ImageIndex = 1;
            this.stripBtnRewind.Name = "stripBtnRewind";
            this.stripBtnRewind.ToolTipText = "Rewind";
            // 
            // stripBtnForward
            // 
            this.stripBtnForward.ImageIndex = 2;
            this.stripBtnForward.Name = "stripBtnForward";
            this.stripBtnForward.ToolTipText = "Forward";
            // 
            // stripBtnMoveEnd
            // 
            this.stripBtnMoveEnd.ImageIndex = 3;
            this.stripBtnMoveEnd.Name = "stripBtnMoveEnd";
            this.stripBtnMoveEnd.ToolTipText = "MoveEnd";
            // 
            // stripBtnPlay
            // 
            this.stripBtnPlay.ImageIndex = 4;
            this.stripBtnPlay.Name = "stripBtnPlay";
            this.stripBtnPlay.ToolTipText = "Play";
            // 
            // toolBarButton4
            // 
            this.toolBarButton4.Name = "toolBarButton4";
            this.toolBarButton4.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // stripBtnScroll
            // 
            this.stripBtnScroll.ImageIndex = 6;
            this.stripBtnScroll.Name = "stripBtnScroll";
            // 
            // stripBtnLoop
            // 
            this.stripBtnLoop.ImageIndex = 7;
            this.stripBtnLoop.Name = "stripBtnLoop";
            // 
            // toolBarMeasure
            // 
            this.toolBarMeasure.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
            this.toolBarMeasure.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.stripDDBtnQuantizeParent,
            this.toolBarButton5,
            this.stripBtnStartMarker,
            this.stripBtnEndMarker});
            this.toolBarMeasure.Divider = false;
            this.toolBarMeasure.Dock = System.Windows.Forms.DockStyle.None;
            this.toolBarMeasure.DropDownArrows = true;
            this.toolBarMeasure.ImageList = this.imageListMeasure;
            this.toolBarMeasure.Location = new System.Drawing.Point(11, 62);
            this.toolBarMeasure.Name = "toolBarMeasure";
            this.toolBarMeasure.ShowToolTips = true;
            this.toolBarMeasure.Size = new System.Drawing.Size(944, 40);
            this.toolBarMeasure.TabIndex = 25;
            this.toolBarMeasure.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
            this.toolBarMeasure.Wrappable = false;
            // 
            // stripDDBtnQuantizeParent
            // 
            this.stripDDBtnQuantizeParent.Name = "stripDDBtnQuantizeParent";
            // 
            // toolBarButton5
            // 
            this.toolBarButton5.Name = "toolBarButton5";
            this.toolBarButton5.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // stripBtnStartMarker
            // 
            this.stripBtnStartMarker.ImageIndex = 0;
            this.stripBtnStartMarker.Name = "stripBtnStartMarker";
            this.stripBtnStartMarker.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
            // 
            // stripBtnEndMarker
            // 
            this.stripBtnEndMarker.ImageIndex = 1;
            this.stripBtnEndMarker.Name = "stripBtnEndMarker";
            this.stripBtnEndMarker.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
            // 
            // toolBarTool
            // 
            this.toolBarTool.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
            this.toolBarTool.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.stripBtnPointer,
            this.stripBtnPencil,
            this.stripBtnLine,
            this.stripBtnEraser,
            this.toolBarButton3,
            this.stripBtnGrid,
            this.stripBtnCurve});
            this.toolBarTool.Divider = false;
            this.toolBarTool.Dock = System.Windows.Forms.DockStyle.None;
            this.toolBarTool.DropDownArrows = true;
            this.toolBarTool.ImageList = this.imageListTool;
            this.toolBarTool.Location = new System.Drawing.Point(11, 92);
            this.toolBarTool.Name = "toolBarTool";
            this.toolBarTool.ShowToolTips = true;
            this.toolBarTool.Size = new System.Drawing.Size(944, 40);
            this.toolBarTool.TabIndex = 25;
            this.toolBarTool.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
            this.toolBarTool.Wrappable = false;
            // 
            // stripBtnPointer
            // 
            this.stripBtnPointer.ImageIndex = 0;
            this.stripBtnPointer.Name = "stripBtnPointer";
            this.stripBtnPointer.Pushed = true;
            this.stripBtnPointer.ToolTipText = "Pointer";
            // 
            // stripBtnPencil
            // 
            this.stripBtnPencil.ImageIndex = 1;
            this.stripBtnPencil.Name = "stripBtnPencil";
            this.stripBtnPencil.ToolTipText = "Pencil";
            // 
            // stripBtnLine
            // 
            this.stripBtnLine.ImageIndex = 2;
            this.stripBtnLine.Name = "stripBtnLine";
            this.stripBtnLine.ToolTipText = "Line";
            // 
            // stripBtnEraser
            // 
            this.stripBtnEraser.ImageIndex = 3;
            this.stripBtnEraser.Name = "stripBtnEraser";
            this.stripBtnEraser.ToolTipText = "Eraser";
            // 
            // toolBarButton3
            // 
            this.toolBarButton3.Name = "toolBarButton3";
            this.toolBarButton3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // stripBtnGrid
            // 
            this.stripBtnGrid.ImageIndex = 4;
            this.stripBtnGrid.Name = "stripBtnGrid";
            this.stripBtnGrid.ToolTipText = "Grid";
            // 
            // stripBtnCurve
            // 
            this.stripBtnCurve.ImageIndex = 5;
            this.stripBtnCurve.Name = "stripBtnCurve";
            this.stripBtnCurve.ToolTipText = "Curve";
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.statusStrip);
            this.toolStripContainer1.BottomToolStripPanel.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.toolStripBottom);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.bigMenu);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.panel1);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.splitContainerProperty);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(955, 687);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 24);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(955, 709);
            this.toolStripContainer1.TabIndex = 26;
            this.toolStripContainer1.Text = "toolStripContainer1";
            this.toolStripContainer1.TopToolStripPanelVisible = false;
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.statusStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip.Location = new System.Drawing.Point(0, 0);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(955, 22);
            this.statusStrip.TabIndex = 25;
            this.statusStrip.Text = "statusStrip1";
            // 
            // bigMenu
            // 
            this.bigMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.bigMenu.Controls.Add(this.exportMenu);
            this.bigMenu.Controls.Add(this.importMenu);
            this.bigMenu.Controls.Add(this.checkBox4);
            this.bigMenu.Controls.Add(this.checkBox3);
            this.bigMenu.Controls.Add(this.checkBox2);
            this.bigMenu.Controls.Add(this.label10);
            this.bigMenu.Controls.Add(this.label7);
            this.bigMenu.Controls.Add(this.checkBox1);
            this.bigMenu.Controls.Add(this.label9);
            this.bigMenu.Controls.Add(this.label8);
            this.bigMenu.Controls.Add(this.projNameLabel);
            this.bigMenu.Controls.Add(this.panel4);
            this.bigMenu.Controls.Add(this.label6);
            this.bigMenu.Controls.Add(this.label5);
            this.bigMenu.Controls.Add(this.label4);
            this.bigMenu.Controls.Add(this.label3);
            this.bigMenu.Controls.Add(this.label2);
            this.bigMenu.Controls.Add(this.panel3);
            this.bigMenu.Controls.Add(this.label1);
            this.bigMenu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bigMenu.Location = new System.Drawing.Point(-1, 34);
            this.bigMenu.Name = "bigMenu";
            this.bigMenu.Size = new System.Drawing.Size(315, 403);
            this.bigMenu.TabIndex = 25;
            this.bigMenu.Visible = false;
            this.bigMenu.Click += new System.EventHandler(this.bigMenu_Click_1);
            this.bigMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.bigMenu_Paint);
            // 
            // exportMenu
            // 
            this.exportMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.exportMenu.Controls.Add(this.ExportUstMI);
            this.exportMenu.Controls.Add(this.ExportVsqMI);
            this.exportMenu.Controls.Add(this.label14);
            this.exportMenu.Location = new System.Drawing.Point(29, 161);
            this.exportMenu.Name = "exportMenu";
            this.exportMenu.Size = new System.Drawing.Size(171, 77);
            this.exportMenu.TabIndex = 38;
            this.exportMenu.Visible = false;
            // 
            // ExportUstMI
            // 
            this.ExportUstMI.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.ExportUstMI.ForeColor = System.Drawing.Color.Gainsboro;
            this.ExportUstMI.Location = new System.Drawing.Point(14, 48);
            this.ExportUstMI.Name = "ExportUstMI";
            this.ExportUstMI.Size = new System.Drawing.Size(150, 17);
            this.ExportUstMI.TabIndex = 37;
            this.ExportUstMI.Text = "UTAU Script File (*.ust)";
            this.ExportUstMI.Click += new System.EventHandler(this.ExportUstMI_Click);
            this.ExportUstMI.MouseEnter += new System.EventHandler(this.ExportUstMI_MouseEnter);
            this.ExportUstMI.MouseLeave += new System.EventHandler(this.ExportUstMI_MouseLeave);
            // 
            // ExportVsqMI
            // 
            this.ExportVsqMI.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.ExportVsqMI.ForeColor = System.Drawing.Color.Gainsboro;
            this.ExportVsqMI.Location = new System.Drawing.Point(14, 26);
            this.ExportVsqMI.Name = "ExportVsqMI";
            this.ExportVsqMI.Size = new System.Drawing.Size(150, 17);
            this.ExportVsqMI.TabIndex = 36;
            this.ExportVsqMI.Text = "Vocaloid Sequence (*.vsqx)";
            this.ExportVsqMI.Click += new System.EventHandler(this.ExportVsqMI_Click);
            this.ExportVsqMI.MouseEnter += new System.EventHandler(this.ExportVsqMI_MouseEnter);
            this.ExportVsqMI.MouseLeave += new System.EventHandler(this.ExportVsqMI_MouseLeave);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.label14.ForeColor = System.Drawing.Color.DimGray;
            this.label14.Location = new System.Drawing.Point(5, 4);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 15);
            this.label14.TabIndex = 35;
            this.label14.Text = "Export File";
            // 
            // importMenu
            // 
            this.importMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.importMenu.Controls.Add(this.ImportUstMI);
            this.importMenu.Controls.Add(this.ImportVsqMI);
            this.importMenu.Controls.Add(this.label11);
            this.importMenu.Location = new System.Drawing.Point(29, 85);
            this.importMenu.Name = "importMenu";
            this.importMenu.Size = new System.Drawing.Size(171, 77);
            this.importMenu.TabIndex = 38;
            this.importMenu.Visible = false;
            // 
            // ImportUstMI
            // 
            this.ImportUstMI.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.ImportUstMI.ForeColor = System.Drawing.Color.Gainsboro;
            this.ImportUstMI.Location = new System.Drawing.Point(14, 48);
            this.ImportUstMI.Name = "ImportUstMI";
            this.ImportUstMI.Size = new System.Drawing.Size(150, 17);
            this.ImportUstMI.TabIndex = 37;
            this.ImportUstMI.Text = "UTAU Script File (*.ust)";
            this.ImportUstMI.Click += new System.EventHandler(this.ImportUstMI_Click);
            this.ImportUstMI.MouseEnter += new System.EventHandler(this.ImportUstMI_MouseEnter);
            this.ImportUstMI.MouseLeave += new System.EventHandler(this.ImportUstMI_MouseLeave);
            // 
            // ImportVsqMI
            // 
            this.ImportVsqMI.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.ImportVsqMI.ForeColor = System.Drawing.Color.Gainsboro;
            this.ImportVsqMI.Location = new System.Drawing.Point(14, 26);
            this.ImportVsqMI.Name = "ImportVsqMI";
            this.ImportVsqMI.Size = new System.Drawing.Size(150, 17);
            this.ImportVsqMI.TabIndex = 36;
            this.ImportVsqMI.Text = "Vocaloid Sequence (*.vsqx)";
            this.ImportVsqMI.Click += new System.EventHandler(this.ImportVsqMI_Click);
            this.ImportVsqMI.MouseEnter += new System.EventHandler(this.ImportVsqMI_MouseEnter);
            this.ImportVsqMI.MouseLeave += new System.EventHandler(this.ImportVsqMI_MouseLeave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.label11.ForeColor = System.Drawing.Color.DimGray;
            this.label11.Location = new System.Drawing.Point(5, 4);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 15);
            this.label11.TabIndex = 35;
            this.label11.Text = "Import File";
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Enabled = false;
            this.checkBox4.ForeColor = System.Drawing.Color.White;
            this.checkBox4.Location = new System.Drawing.Point(123, 255);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(75, 19);
            this.checkBox4.TabIndex = 37;
            this.checkBox4.Text = "Overview";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Enabled = false;
            this.checkBox3.ForeColor = System.Drawing.Color.White;
            this.checkBox3.Location = new System.Drawing.Point(21, 255);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(81, 19);
            this.checkBox3.TabIndex = 36;
            this.checkBox3.Text = "Waveform";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Enabled = false;
            this.checkBox2.ForeColor = System.Drawing.Color.White;
            this.checkBox2.Location = new System.Drawing.Point(123, 222);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(55, 19);
            this.checkBox2.TabIndex = 35;
            this.checkBox2.Text = "Mixer";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(10, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 15);
            this.label10.TabIndex = 34;
            this.label10.Text = "File";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(10, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 15);
            this.label7.TabIndex = 33;
            this.label7.Text = "View";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(21, 222);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(71, 19);
            this.checkBox1.TabIndex = 32;
            this.checkBox1.Text = "Controls";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Gainsboro;
            this.label9.Location = new System.Drawing.Point(120, 375);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 15);
            this.label9.TabIndex = 31;
            this.label9.Text = "About...";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Gainsboro;
            this.label8.Location = new System.Drawing.Point(18, 375);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 15);
            this.label8.TabIndex = 30;
            this.label8.Text = "Settings...";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // projNameLabel
            // 
            this.projNameLabel.AutoSize = true;
            this.projNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.projNameLabel.ForeColor = System.Drawing.Color.White;
            this.projNameLabel.Location = new System.Drawing.Point(105, 9);
            this.projNameLabel.Name = "projNameLabel";
            this.projNameLabel.Size = new System.Drawing.Size(129, 21);
            this.projNameLabel.TabIndex = 28;
            this.projNameLabel.Text = "Project \"Untitled\"";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DimGray;
            this.panel4.Location = new System.Drawing.Point(92, 7);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(2, 173);
            this.panel4.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(13, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 16);
            this.label6.TabIndex = 27;
            this.label6.Text = "Export...";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            this.label6.MouseEnter += new System.EventHandler(this.label6_MouseEnter);
            this.label6.MouseLeave += new System.EventHandler(this.label6_MouseLeave);
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(13, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Save As...";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            this.label5.MouseEnter += new System.EventHandler(this.label5_MouseEnter);
            this.label5.MouseLeave += new System.EventHandler(this.label5_MouseLeave);
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(13, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Save";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            this.label4.MouseEnter += new System.EventHandler(this.label4_MouseEnter);
            this.label4.MouseLeave += new System.EventHandler(this.label4_MouseLeave);
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(13, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Import...";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            this.label3.MouseEnter += new System.EventHandler(this.label3_MouseEnter);
            this.label3.MouseLeave += new System.EventHandler(this.label3_MouseLeave);
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(13, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Open";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            this.label2.MouseEnter += new System.EventHandler(this.label2_MouseEnter);
            this.label2.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Location = new System.Drawing.Point(13, 189);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(290, 2);
            this.panel3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(13, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "New";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // cMenuPositionIndicator
            // 
            this.cMenuPositionIndicator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cMenuPositionIndicatorStartMarker,
            this.cMenuPositionIndicatorEndMarker});
            this.cMenuPositionIndicator.Name = "cMenuTrackTab";
            this.cMenuPositionIndicator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.cMenuPositionIndicator.ShowImageMargin = false;
            this.cMenuPositionIndicator.Size = new System.Drawing.Size(132, 48);
            // 
            // cMenuPositionIndicatorStartMarker
            // 
            this.cMenuPositionIndicatorStartMarker.Name = "cMenuPositionIndicatorStartMarker";
            this.cMenuPositionIndicatorStartMarker.Size = new System.Drawing.Size(131, 22);
            this.cMenuPositionIndicatorStartMarker.Text = "Set start marker";
            // 
            // cMenuPositionIndicatorEndMarker
            // 
            this.cMenuPositionIndicatorEndMarker.Name = "cMenuPositionIndicatorEndMarker";
            this.cMenuPositionIndicatorEndMarker.Size = new System.Drawing.Size(131, 22);
            this.cMenuPositionIndicatorEndMarker.Text = "Set end marker";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.panel2.Controls.Add(this.frqEditBtn);
            this.panel2.Controls.Add(this.eraseBtn);
            this.panel2.Controls.Add(this.addBtn);
            this.panel2.Controls.Add(this.highligher);
            this.panel2.Controls.Add(this.BigMenuBtn);
            this.panel2.Controls.Add(this.SelectBtn);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(955, 28);
            this.panel2.TabIndex = 25;
            // 
            // frqEditBtn
            // 
            this.frqEditBtn.Image = global::cadencii.Properties.Resources.SineWave;
            this.frqEditBtn.Location = new System.Drawing.Point(159, 5);
            this.frqEditBtn.Name = "frqEditBtn";
            this.frqEditBtn.Size = new System.Drawing.Size(16, 16);
            this.frqEditBtn.TabIndex = 29;
            this.frqEditBtn.TabStop = false;
            // 
            // eraseBtn
            // 
            this.eraseBtn.Image = global::cadencii.Properties.Resources.Erase;
            this.eraseBtn.Location = new System.Drawing.Point(127, 5);
            this.eraseBtn.Name = "eraseBtn";
            this.eraseBtn.Size = new System.Drawing.Size(16, 16);
            this.eraseBtn.TabIndex = 28;
            this.eraseBtn.TabStop = false;
            this.eraseBtn.Click += new System.EventHandler(this.eraseBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Image = global::cadencii.Properties.Resources.Add;
            this.addBtn.Location = new System.Drawing.Point(96, 5);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(16, 16);
            this.addBtn.TabIndex = 27;
            this.addBtn.TabStop = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // highligher
            // 
            this.highligher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(155)))), ((int)(((byte)(167)))));
            this.highligher.Location = new System.Drawing.Point(94, 23);
            this.highligher.Name = "highligher";
            this.highligher.Size = new System.Drawing.Size(20, 4);
            this.highligher.TabIndex = 26;
            // 
            // BigMenuBtn
            // 
            this.BigMenuBtn.Image = global::cadencii.Properties.Resources.MenuClosed;
            this.BigMenuBtn.Location = new System.Drawing.Point(6, 1);
            this.BigMenuBtn.Name = "BigMenuBtn";
            this.BigMenuBtn.Size = new System.Drawing.Size(25, 28);
            this.BigMenuBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.BigMenuBtn.TabIndex = 25;
            this.BigMenuBtn.TabStop = false;
            this.BigMenuBtn.Click += new System.EventHandler(this.BigMenu_Click);
            // 
            // SelectBtn
            // 
            this.SelectBtn.Image = global::cadencii.Properties.Resources.Select;
            this.SelectBtn.Location = new System.Drawing.Point(65, 5);
            this.SelectBtn.Name = "SelectBtn";
            this.SelectBtn.Size = new System.Drawing.Size(16, 16);
            this.SelectBtn.TabIndex = 24;
            this.SelectBtn.TabStop = false;
            this.SelectBtn.Click += new System.EventHandler(this.SelectBtn_Click);
            // 
            // menuFileQuit
            // 
            this.menuFileQuit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuFileQuit.Name = "menuFileQuit";
            this.menuFileQuit.Size = new System.Drawing.Size(255, 22);
            this.menuFileQuit.Text = "Quit(&Q)";
            this.menuFileQuit.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.Size = new System.Drawing.Size(252, 6);
            // 
            // menuFileRecentClear
            // 
            this.menuFileRecentClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuFileRecentClear.Name = "menuFileRecentClear";
            this.menuFileRecentClear.Size = new System.Drawing.Size(135, 22);
            this.menuFileRecentClear.Text = "Clear Menu";
            this.menuFileRecentClear.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // menuFileRecent
            // 
            this.menuFileRecent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuFileRecent.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFileRecentClear});
            this.menuFileRecent.Name = "menuFileRecent";
            this.menuFileRecent.Size = new System.Drawing.Size(255, 22);
            this.menuFileRecent.Text = "Recent Files(&R)";
            this.menuFileRecent.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(252, 6);
            // 
            // menuFileExportWave
            // 
            this.menuFileExportWave.Name = "menuFileExportWave";
            this.menuFileExportWave.Size = new System.Drawing.Size(244, 22);
            this.menuFileExportWave.Text = "Wave";
            // 
            // menuFileExportParaWave
            // 
            this.menuFileExportParaWave.Name = "menuFileExportParaWave";
            this.menuFileExportParaWave.Size = new System.Drawing.Size(244, 22);
            this.menuFileExportParaWave.Text = "Serial numbered Wave";
            // 
            // menuFileExportVsq
            // 
            this.menuFileExportVsq.Name = "menuFileExportVsq";
            this.menuFileExportVsq.Size = new System.Drawing.Size(244, 22);
            this.menuFileExportVsq.Text = "VSQ File";
            // 
            // menuFileExportVsqx
            // 
            this.menuFileExportVsqx.Name = "menuFileExportVsqx";
            this.menuFileExportVsqx.Size = new System.Drawing.Size(244, 22);
            this.menuFileExportVsqx.Text = "VSQX File";
            // 
            // menuFileExportMidi
            // 
            this.menuFileExportMidi.Name = "menuFileExportMidi";
            this.menuFileExportMidi.Size = new System.Drawing.Size(244, 22);
            this.menuFileExportMidi.Text = "MIDI";
            // 
            // menuFileExportMusicXml
            // 
            this.menuFileExportMusicXml.Name = "menuFileExportMusicXml";
            this.menuFileExportMusicXml.Size = new System.Drawing.Size(244, 22);
            this.menuFileExportMusicXml.Text = "MusicXML";
            // 
            // menuFileExportUst
            // 
            this.menuFileExportUst.Name = "menuFileExportUst";
            this.menuFileExportUst.Size = new System.Drawing.Size(244, 22);
            this.menuFileExportUst.Text = "UTAU Project File (current track)";
            // 
            // menuFileExportVxt
            // 
            this.menuFileExportVxt.Name = "menuFileExportVxt";
            this.menuFileExportVxt.Size = new System.Drawing.Size(244, 22);
            this.menuFileExportVxt.Text = "Metatext for vConnect";
            // 
            // menuFileExport
            // 
            this.menuFileExport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuFileExport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFileExportWave,
            this.menuFileExportParaWave,
            this.menuFileExportVsq,
            this.menuFileExportVsqx,
            this.menuFileExportMidi,
            this.menuFileExportMusicXml,
            this.menuFileExportUst,
            this.menuFileExportVxt});
            this.menuFileExport.Name = "menuFileExport";
            this.menuFileExport.Size = new System.Drawing.Size(255, 22);
            this.menuFileExport.Text = "Export(&E)";
            this.menuFileExport.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // menuFileImportVsq
            // 
            this.menuFileImportVsq.Name = "menuFileImportVsq";
            this.menuFileImportVsq.Size = new System.Drawing.Size(164, 22);
            this.menuFileImportVsq.Text = "VSQ File";
            // 
            // menuFileImportMidi
            // 
            this.menuFileImportMidi.Name = "menuFileImportMidi";
            this.menuFileImportMidi.Size = new System.Drawing.Size(164, 22);
            this.menuFileImportMidi.Text = "Standard MIDI";
            // 
            // menuFileImportUst
            // 
            this.menuFileImportUst.Name = "menuFileImportUst";
            this.menuFileImportUst.Size = new System.Drawing.Size(164, 22);
            this.menuFileImportUst.Text = "UTAU project file";
            // 
            // menuFileImport
            // 
            this.menuFileImport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuFileImport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFileImportVsq,
            this.menuFileImportMidi,
            this.menuFileImportUst});
            this.menuFileImport.Name = "menuFileImport";
            this.menuFileImport.Size = new System.Drawing.Size(255, 22);
            this.menuFileImport.Text = "Import(&I)";
            this.menuFileImport.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // menuFileOpenUst
            // 
            this.menuFileOpenUst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuFileOpenUst.Name = "menuFileOpenUst";
            this.menuFileOpenUst.Size = new System.Drawing.Size(255, 22);
            this.menuFileOpenUst.Text = "Open UTAU Project File(&U)";
            this.menuFileOpenUst.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // menuFileOpenVsq
            // 
            this.menuFileOpenVsq.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuFileOpenVsq.Name = "menuFileOpenVsq";
            this.menuFileOpenVsq.Size = new System.Drawing.Size(255, 22);
            this.menuFileOpenVsq.Text = "Open VSQX/VSQ/Vocaloid Midi(&V)";
            this.menuFileOpenVsq.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(252, 6);
            // 
            // menuFileSaveNamed
            // 
            this.menuFileSaveNamed.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuFileSaveNamed.Name = "menuFileSaveNamed";
            this.menuFileSaveNamed.Size = new System.Drawing.Size(255, 22);
            this.menuFileSaveNamed.Text = "Save As(&A)";
            this.menuFileSaveNamed.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // menuFileSave
            // 
            this.menuFileSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuFileSave.Name = "menuFileSave";
            this.menuFileSave.Size = new System.Drawing.Size(255, 22);
            this.menuFileSave.Text = "Save(&S)";
            this.menuFileSave.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // menuFileOpen
            // 
            this.menuFileOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuFileOpen.Name = "menuFileOpen";
            this.menuFileOpen.Size = new System.Drawing.Size(255, 22);
            this.menuFileOpen.Text = "Open(&O)";
            this.menuFileOpen.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // menuFileNew
            // 
            this.menuFileNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuFileNew.Name = "menuFileNew";
            this.menuFileNew.Size = new System.Drawing.Size(255, 22);
            this.menuFileNew.Text = "New(N)";
            this.menuFileNew.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // toolStripMenuItem30
            // 
            this.toolStripMenuItem30.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripMenuItem30.Name = "toolStripMenuItem30";
            this.toolStripMenuItem30.Size = new System.Drawing.Size(255, 22);
            this.toolStripMenuItem30.Text = "New(N)";
            this.toolStripMenuItem30.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // toolStripMenuItem32
            // 
            this.toolStripMenuItem32.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripMenuItem32.Name = "toolStripMenuItem32";
            this.toolStripMenuItem32.Size = new System.Drawing.Size(255, 22);
            this.toolStripMenuItem32.Text = "Open(&O)";
            this.toolStripMenuItem32.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // toolStripMenuItem33
            // 
            this.toolStripMenuItem33.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripMenuItem33.Name = "toolStripMenuItem33";
            this.toolStripMenuItem33.Size = new System.Drawing.Size(255, 22);
            this.toolStripMenuItem33.Text = "Save(&S)";
            this.toolStripMenuItem33.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // toolStripMenuItem34
            // 
            this.toolStripMenuItem34.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripMenuItem34.Name = "toolStripMenuItem34";
            this.toolStripMenuItem34.Size = new System.Drawing.Size(255, 22);
            this.toolStripMenuItem34.Text = "Save As(&A)";
            this.toolStripMenuItem34.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(252, 6);
            // 
            // toolStripMenuItem35
            // 
            this.toolStripMenuItem35.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripMenuItem35.Name = "toolStripMenuItem35";
            this.toolStripMenuItem35.Size = new System.Drawing.Size(255, 22);
            this.toolStripMenuItem35.Text = "Open VSQX/VSQ/Vocaloid Midi(&V)";
            this.toolStripMenuItem35.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // toolStripMenuItem36
            // 
            this.toolStripMenuItem36.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripMenuItem36.Name = "toolStripMenuItem36";
            this.toolStripMenuItem36.Size = new System.Drawing.Size(255, 22);
            this.toolStripMenuItem36.Text = "Open UTAU Project File(&U)";
            this.toolStripMenuItem36.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // toolStripMenuItem37
            // 
            this.toolStripMenuItem37.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripMenuItem37.Name = "toolStripMenuItem37";
            this.toolStripMenuItem37.Size = new System.Drawing.Size(255, 22);
            this.toolStripMenuItem37.Text = "Import(&I)";
            this.toolStripMenuItem37.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // toolStripMenuItem38
            // 
            this.toolStripMenuItem38.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripMenuItem38.Name = "toolStripMenuItem38";
            this.toolStripMenuItem38.Size = new System.Drawing.Size(255, 22);
            this.toolStripMenuItem38.Text = "Export(&E)";
            this.toolStripMenuItem38.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(252, 6);
            // 
            // toolStripMenuItem39
            // 
            this.toolStripMenuItem39.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripMenuItem39.Name = "toolStripMenuItem39";
            this.toolStripMenuItem39.Size = new System.Drawing.Size(255, 22);
            this.toolStripMenuItem39.Text = "Recent Files(&R)";
            this.toolStripMenuItem39.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(252, 6);
            // 
            // toolStripMenuItem40
            // 
            this.toolStripMenuItem40.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripMenuItem40.Name = "toolStripMenuItem40";
            this.toolStripMenuItem40.Size = new System.Drawing.Size(255, 22);
            this.toolStripMenuItem40.Text = "Quit(&Q)";
            this.toolStripMenuItem40.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // renderTimer
            // 
            this.renderTimer.Enabled = true;
            this.renderTimer.Tick += new System.EventHandler(this.renderTimer_Tick);
            // 
            // FormMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(955, 733);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.rebar);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStripMain);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "FormMain";
            this.Text = "CadenciiStudio in the makin";
            this.Load += new System.EventHandler(this.FormMain_Load_1);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.cMenuPiano.ResumeLayout(false);
            this.cMenuTrackTab.ResumeLayout(false);
            this.cMenuTrackSelector.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictKeyLengthSplitter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePositionIndicator)).EndInit();
            this.splitContainerProperty.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelOverview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictPianoRoll)).EndInit();
            this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.bigMenu.ResumeLayout(false);
            this.bigMenu.PerformLayout();
            this.exportMenu.ResumeLayout(false);
            this.exportMenu.PerformLayout();
            this.importMenu.ResumeLayout(false);
            this.importMenu.PerformLayout();
            this.cMenuPositionIndicator.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.frqEditBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eraseBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BigMenuBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.ComponentModel.IContainer components;

        public MenuStrip menuStripMain;
        public ToolStripMenuItem menuFile;
        public ToolStripMenuItem menuEdit;
        public ToolStripMenuItem menuVisual;
        public ToolStripMenuItem menuJob;
        public ToolStripMenuItem menuTrack;
        public ToolStripMenuItem menuLyric;
        public ToolStripMenuItem menuSetting;
        public ToolStripMenuItem menuHelp;
        public ToolStripMenuItem menuVisualControlTrack;
        public ToolStripMenuItem menuVisualMixer;
        public System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        public ToolStripMenuItem menuVisualGridline;
        public System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        public ToolStripMenuItem menuVisualStartMarker;
        public ToolStripMenuItem menuVisualEndMarker;
        public System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        public ToolStripMenuItem menuVisualLyrics;
        public ToolStripMenuItem menuVisualNoteProperty;
        public ToolStripMenuItem menuSettingPreference;
        public System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        public ToolStripMenuItem menuSettingDefaultSingerStyle;
        public ToolStripMenuItem menuSettingPositionQuantize;
        public ToolStripMenuItem menuSettingPositionQuantize04;
        public ToolStripMenuItem menuSettingPositionQuantize08;
        public ToolStripMenuItem menuSettingPositionQuantize16;
        public ToolStripMenuItem menuSettingPositionQuantize32;
        public ToolStripMenuItem menuSettingPositionQuantize64;
        public ToolStripMenuItem menuSettingPositionQuantizeOff;
        public System.Windows.Forms.ToolStripSeparator toolStripMenuItem9;
        public System.Windows.Forms.ToolStripSeparator toolStripMenuItem8;
        public ToolStripMenuItem menuSettingPositionQuantizeTriplet;
        public ToolStripMenuItem menuEditUndo;
        public ToolStripMenuItem menuEditRedo;
        public System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        public PictureBox pictureBox2;
        public PictureBox pictureBox3;
        public PictureBox picturePositionIndicator;
        public ContextMenuStrip cMenuPiano;
        public ToolStripMenuItem cMenuPianoPointer;
        public ToolStripMenuItem cMenuPianoPencil;
        public ToolStripMenuItem cMenuPianoEraser;
        public System.Windows.Forms.ToolStripSeparator toolStripMenuItem13;
        public ToolStripMenuItem cMenuPianoFixed;
        public ToolStripMenuItem cMenuPianoQuantize;
        public ToolStripMenuItem cMenuPianoGrid;
        public System.Windows.Forms.ToolStripSeparator toolStripMenuItem14;
        public ToolStripMenuItem cMenuPianoUndo;
        public ToolStripMenuItem cMenuPianoRedo;
        public System.Windows.Forms.ToolStripSeparator toolStripMenuItem15;
        public ToolStripMenuItem cMenuPianoCut;
        public ToolStripMenuItem cMenuPianoFixed01;
        public ToolStripMenuItem cMenuPianoFixed02;
        public ToolStripMenuItem cMenuPianoFixed04;
        public ToolStripMenuItem cMenuPianoFixed08;
        public ToolStripMenuItem cMenuPianoFixed16;
        public ToolStripMenuItem cMenuPianoFixed32;
        public ToolStripMenuItem cMenuPianoFixed64;
        public ToolStripMenuItem cMenuPianoFixedOff;
        public System.Windows.Forms.ToolStripSeparator toolStripMenuItem18;
        public ToolStripMenuItem cMenuPianoFixedTriplet;
        public ToolStripMenuItem cMenuPianoFixedDotted;
        public ToolStripMenuItem cMenuPianoCopy;
        public ToolStripMenuItem cMenuPianoPaste;
        public ToolStripMenuItem cMenuPianoDelete;
        public System.Windows.Forms.ToolStripSeparator toolStripMenuItem16;
        public ToolStripMenuItem cMenuPianoSelectAll;
        public ToolStripMenuItem cMenuPianoSelectAllEvents;
        public System.Windows.Forms.ToolStripSeparator toolStripMenuItem17;
        public ToolStripMenuItem cMenuPianoImportLyric;
        public ToolStripMenuItem cMenuPianoExpressionProperty;
        public ToolStripMenuItem cMenuPianoQuantize04;
        public ToolStripMenuItem cMenuPianoQuantize08;
        public ToolStripMenuItem cMenuPianoQuantize16;
        public ToolStripMenuItem cMenuPianoQuantize32;
        public ToolStripMenuItem cMenuPianoQuantize64;
        public ToolStripMenuItem cMenuPianoQuantizeOff;
        public System.Windows.Forms.ToolStripSeparator toolStripMenuItem26;
        public ToolStripMenuItem cMenuPianoQuantizeTriplet;
        public System.Windows.Forms.ToolTip toolTip;
        public ToolStripMenuItem menuEditCut;
        public ToolStripMenuItem menuEditCopy;
        public ToolStripMenuItem menuEditPaste;
        public ToolStripMenuItem menuEditDelete;
        public System.Windows.Forms.ToolStripSeparator toolStripMenuItem19;
        public ToolStripMenuItem menuEditAutoNormalizeMode;
        public System.Windows.Forms.ToolStripSeparator toolStripMenuItem20;
        public ToolStripMenuItem menuEditSelectAll;
        public ToolStripMenuItem menuEditSelectAllEvents;
        public ToolStripMenuItem menuTrackOn;
        public System.Windows.Forms.ToolStripSeparator toolStripMenuItem21;
        public ToolStripMenuItem menuTrackAdd;
        public ToolStripMenuItem menuTrackCopy;
        public ToolStripMenuItem menuTrackChangeName;
        public ToolStripMenuItem menuTrackDelete;
        public System.Windows.Forms.ToolStripSeparator toolStripMenuItem22;
        public ToolStripMenuItem menuTrackRenderCurrent;
        public ToolStripMenuItem menuTrackRenderAll;
        public System.Windows.Forms.ToolStripSeparator toolStripMenuItem23;
        public ToolStripMenuItem menuTrackOverlay;
        public ContextMenuStrip cMenuTrackTab;
        public ToolStripMenuItem cMenuTrackTabTrackOn;
        public System.Windows.Forms.ToolStripSeparator toolStripMenuItem24;
        public ToolStripMenuItem cMenuTrackTabAdd;
        public ToolStripMenuItem cMenuTrackTabCopy;
        public ToolStripMenuItem cMenuTrackTabChangeName;
        public ToolStripMenuItem cMenuTrackTabDelete;
        public System.Windows.Forms.ToolStripSeparator toolStripMenuItem25;
        public ToolStripMenuItem cMenuTrackTabRenderCurrent;
        public ToolStripMenuItem cMenuTrackTabRenderAll;
        public System.Windows.Forms.ToolStripSeparator toolStripMenuItem27;
        public ToolStripMenuItem cMenuTrackTabOverlay;
        public ContextMenuStrip cMenuTrackSelector;
        public ToolStripMenuItem cMenuTrackSelectorPointer;
        public ToolStripMenuItem cMenuTrackSelectorPencil;
        public ToolStripMenuItem cMenuTrackSelectorLine;
        public ToolStripMenuItem cMenuTrackSelectorEraser;
        public System.Windows.Forms.ToolStripSeparator toolStripMenuItem28;
        public ToolStripMenuItem cMenuTrackSelectorUndo;
        public ToolStripMenuItem cMenuTrackSelectorRedo;
        public System.Windows.Forms.ToolStripSeparator toolStripMenuItem29;
        public ToolStripMenuItem cMenuTrackSelectorCut;
        public ToolStripMenuItem cMenuTrackSelectorCopy;
        public ToolStripMenuItem cMenuTrackSelectorPaste;
        public ToolStripMenuItem cMenuTrackSelectorDelete;
        public System.Windows.Forms.ToolStripSeparator toolStripMenuItem31;
        public ToolStripMenuItem cMenuTrackSelectorSelectAll;
        public ToolStripMenuItem menuJobNormalize;
        public ToolStripMenuItem menuJobInsertBar;
        public ToolStripMenuItem menuJobDeleteBar;
        public ToolStripMenuItem menuJobRandomize;
        public ToolStripMenuItem menuJobConnect;
        public ToolStripMenuItem menuJobLyric;
        public ToolStripMenuItem menuJobRewire;
        public ToolStripMenuItem menuLyricExpressionProperty;
        public ToolStripMenuItem menuLyricPhonemeTransformation;
        public ToolStripMenuItem menuLyricDictionary;
        public ToolStripMenuItem menuHelpAbout;
        public ToolStripMenuItem menuHelpDebug;
        public ToolStripMenuItem menuScript;
        public ToolStripMenuItem menuHidden;
        public ToolStripMenuItem menuHiddenEditLyric;
        public ToolStripMenuItem menuHiddenEditFlipToolPointerPencil;
        public ToolStripMenuItem menuHiddenEditFlipToolPointerEraser;
        public ToolStripMenuItem menuHiddenVisualForwardParameter;
        public ToolStripMenuItem menuHiddenVisualBackwardParameter;
        public ToolStripMenuItem menuHiddenTrackNext;
        public ToolStripMenuItem menuHiddenTrackBack;
        public ToolStripMenuItem menuJobReloadVsti;
        public ToolStripMenuItem cMenuPianoCurve;
        public ToolStripMenuItem cMenuTrackSelectorCurve;
        public TrackBar trackBar;
        public System.Windows.Forms.ToolBarButton stripBtnPointer;
        public System.Windows.Forms.ToolBarButton stripBtnLine;
        public System.Windows.Forms.ToolBarButton stripBtnPencil;
        public System.Windows.Forms.ToolBarButton stripBtnEraser;
        public System.Windows.Forms.ToolBarButton stripBtnGrid;
        public System.Windows.Forms.ToolBarButton stripBtnMoveTop;
        public System.Windows.Forms.ToolBarButton stripBtnRewind;
        public System.Windows.Forms.ToolBarButton stripBtnForward;
        public System.Windows.Forms.ToolBarButton stripBtnMoveEnd;
        public System.Windows.Forms.ToolBarButton stripBtnPlay;
        public System.Windows.Forms.ToolBarButton stripBtnScroll;
        public System.Windows.Forms.ToolBarButton stripBtnLoop;
        public System.Windows.Forms.ToolBarButton stripBtnCurve;
        public System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        public System.Windows.Forms.ContextMenu stripDDBtnQuantize;
        public System.Windows.Forms.MenuItem stripDDBtnQuantize04;
        public System.Windows.Forms.MenuItem stripDDBtnQuantize08;
        public System.Windows.Forms.MenuItem stripDDBtnQuantize16;
        public System.Windows.Forms.MenuItem stripDDBtnQuantize32;
        public System.Windows.Forms.MenuItem stripDDBtnQuantize64;
        public System.Windows.Forms.MenuItem stripDDBtnQuantizeOff;
        public System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        public System.Windows.Forms.MenuItem stripDDBtnQuantizeTriplet;
        public System.Windows.Forms.ToolBarButton stripBtnStartMarker;
        public System.Windows.Forms.ToolBarButton stripBtnEndMarker;
        public HScrollBar hScroll;
        public VScrollBar vScroll;
        public ToolStripMenuItem menuLyricVibratoProperty;
        public ToolStripMenuItem cMenuPianoVibratoProperty;
        public ToolStripMenuItem menuScriptUpdate;
        public ToolStripMenuItem menuSettingGameControler;
        public ToolStripStatusLabel stripLblGameCtrlMode;
        public System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        public ToolStripMenuItem menuSettingGameControlerSetting;
        public ToolStripMenuItem menuSettingGameControlerLoad;
        public System.Windows.Forms.MenuItem stripDDBtnQuantize128;
        public ToolStripMenuItem menuSettingPositionQuantize128;
        public ToolStripMenuItem cMenuPianoQuantize128;
        public ToolStripMenuItem cMenuPianoFixed128;
        public ToolStripMenuItem menuVisualWaveform;
        private WaveformZoomUiImpl panelWaveformZoom;
        public ToolStripMenuItem cMenuTrackSelectorDeleteBezier;
        public ToolStripStatusLabel stripLblMidiIn;
        public System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        //public ToolStripMenuItem menuJobRealTime;
        public ToolStripMenuItem cMenuTrackTabRenderer;
        public ToolStripMenuItem cMenuTrackTabRendererVOCALOID1;
        public ToolStripMenuItem cMenuTrackTabRendererVOCALOID2;
        public ToolStripMenuItem cMenuTrackTabRendererUtau;
        private System.Windows.Forms.ToolStripMenuItem cMenuTrackTabRendererAquesTone2;
        public ToolStripMenuItem menuVisualPitchLine;
        public ToolStripStatusLabel toolStripStatusLabel1;
        public ToolStripStatusLabel toolStripStatusLabel2;
        public ToolBarButton stripBtnFileSave;
        public ToolBarButton stripBtnFileOpen;
        public ToolBarButton stripBtnCut;
        public ToolBarButton stripBtnCopy;
        public ToolBarButton stripBtnPaste;
        public ToolBarButton stripBtnFileNew;
        public ToolBarButton stripBtnUndo;
        public ToolBarButton stripBtnRedo;
        public ToolStripMenuItem cMenuTrackSelectorPaletteTool;
        public ToolStripMenuItem cMenuPianoPaletteTool;
        public System.Windows.Forms.ToolStripSeparator toolStripSeparator14;
        public System.Windows.Forms.ToolStripSeparator toolStripSeparator15;
        public ToolStripMenuItem menuSettingPaletteTool;
        public ToolStripMenuItem menuTrackRenderer;
        public ToolStripMenuItem menuTrackRendererVOCALOID1;
        public ToolStripMenuItem menuTrackRendererVOCALOID2;
        public ToolStripMenuItem menuTrackRendererUtau;
        public ToolStripMenuItem menuSettingShortcut;
        public ToolStripMenuItem menuVisualProperty;
        public ToolStripMenuItem menuSettingGameControlerRemove;
        public ToolStripMenuItem menuHiddenCopy;
        public ToolStripMenuItem menuHiddenPaste;
        public ToolStripMenuItem menuHiddenCut;
        public ToolStrip toolStripBottom;
        public cadencii.apputil.BSplitContainer splitContainerProperty;
        public ToolStripMenuItem menuVisualOverview;
        public PictOverview panelOverview;
        public cadencii.apputil.BSplitContainer splitContainer1;
        public System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        public ToolStripMenuItem menuTrackBgm;
        public ToolStripMenuItem menuTrackRendererVCNT;
        //public ToolStripMenuItem menuTrackManager;
        public ToolStripMenuItem cMenuTrackTabRendererStraight;
        public PictPianoRoll pictPianoRoll;
        public TrackSelector trackSelector;
        public PictureBox pictKeyLengthSplitter;
        private ToolStripMenuItem menuTrackRendererAquesTone;
        private ToolStripMenuItem cMenuTrackTabRendererAquesTone;
        private ToolStripMenuItem menuVisualPluginUi;
        private ToolStripMenuItem menuVisualPluginUiAquesTone;
        private ToolStripMenuItem menuVisualPluginUiVocaloid1;
        private ToolStripMenuItem menuVisualPluginUiVocaloid2;
        private System.Windows.Forms.ToolStripMenuItem menuTrackRendererAquesTone2;
        private ToolStripMenuItem menuVisualIconPalette;
        public ToolStripMenuItem menuHiddenSelectForward;
        public ToolStripMenuItem menuHiddenSelectBackward;
        public ToolStripMenuItem menuHiddenMoveUp;
        public ToolStripMenuItem menuHiddenMoveDown;
        public ToolStripMenuItem menuHiddenMoveLeft;
        public ToolStripMenuItem menuHiddenMoveRight;
        public ToolStripMenuItem menuHiddenLengthen;
        public ToolStripMenuItem menuHiddenShorten;
        public ToolStripMenuItem menuHiddenGoToStartMarker;
        public ToolStripMenuItem menuHiddenGoToEndMarker;
        public ToolStripMenuItem menuHiddenPlayFromStartMarker;
        public ToolStripMenuItem menuHiddenFlipCurveOnPianorollMode;
        //public CircuitView pictCircuit;
        private ToolStripMenuItem menuHelpLog;
        private ToolStripMenuItem menuHelpLogSwitch;
        private ToolStripMenuItem menuHelpLogOpen;
        private Rebar rebar;
        private RebarBand bandFile;
        private RebarBand bandPosition;
        private RebarBand bandMeasure;
        private RebarBand bandTool;
        public cadencii.apputil.BSplitContainer splitContainer2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolBar toolBarFile;
        private System.Windows.Forms.ImageList imageListFile;
        private System.Windows.Forms.ToolBarButton toolBarButton1;
        private System.Windows.Forms.ToolBarButton toolBarButton2;
        private System.Windows.Forms.ToolBar toolBarTool;
        private System.Windows.Forms.ToolBarButton toolBarButton3;
        private System.Windows.Forms.ImageList imageListTool;
        private System.Windows.Forms.ToolBar toolBarPosition;
        private System.Windows.Forms.ToolBarButton toolBarButton4;
        private System.Windows.Forms.ImageList imageListPosition;
        private System.Windows.Forms.ToolBar toolBarMeasure;
        private System.Windows.Forms.ToolBarButton stripDDBtnQuantizeParent;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.ToolBarButton toolBarButton5;
        private System.Windows.Forms.ImageList imageListMeasure;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ImageList imageListMenu;
        public ToolStripMenuItem menuLyricCopyVibratoToPreset;
        public ToolStripMenuItem menuSettingVibratoPreset;
        public ToolStripMenuItem menuSettingSequence;
        public ToolStripMenuItem menuHiddenPrintPoToCSV;
        private System.Windows.Forms.ToolStripButton stripBtnStepSequencer;
        public ContextMenuStrip cMenuPositionIndicator;
        public ToolStripMenuItem cMenuPositionIndicatorStartMarker;
        public ToolStripMenuItem cMenuPositionIndicatorEndMarker;
        public ToolStripMenuItem menuHelpManual;
        public WaveView waveView;
        public ToolStripMenuItem menuLyricApplyUtauParameters;
        private System.Windows.Forms.ToolStripMenuItem menuVisualPluginUiAquesTone2;
        private System.Windows.Forms.ToolStripMenuItem menuTools;
        private System.Windows.Forms.ToolStripMenuItem menuToolsCreateVConnectSTANDDb;
        private ToolStripMenuItem menuHelpCheckForUpdates;
        private Panel panel2;
        private PictureBox SelectBtn;
        private PictureBox BigMenuBtn;
        private PictureBox addBtn;
        private Panel highligher;
        private PictureBox eraseBtn;
        private Panel bigMenu;
        private Label label1;
        private Panel panel3;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label6;
        private Panel panel4;
        private Label label8;
        private Label projNameLabel;
        private Label label9;
        private CheckBox checkBox1;
        private Label label10;
        private Label label7;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem toolStripMenuItem7;
        private Panel importMenu;
        private Label ImportUstMI;
        private Label ImportVsqMI;
        private Label label11;
        public ToolStripMenuItem menuFileQuit;
        public ToolStripSeparator toolStripMenuItem12;
        public ToolStripMenuItem menuFileRecentClear;
        public ToolStripMenuItem menuFileRecent;
        public ToolStripSeparator toolStripMenuItem11;
        public ToolStripMenuItem menuFileExportWave;
        public ToolStripMenuItem menuFileExportParaWave;
        public ToolStripMenuItem menuFileExportVsq;
        private ToolStripMenuItem menuFileExportVsqx;
        public ToolStripMenuItem menuFileExportMidi;
        private ToolStripMenuItem menuFileExportMusicXml;
        private ToolStripMenuItem menuFileExportUst;
        private ToolStripMenuItem menuFileExportVxt;
        public ToolStripMenuItem menuFileExport;
        public ToolStripMenuItem menuFileImportVsq;
        public ToolStripMenuItem menuFileImportMidi;
        public ToolStripMenuItem menuFileImportUst;
        public ToolStripMenuItem menuFileImport;
        public ToolStripMenuItem menuFileOpenUst;
        public ToolStripMenuItem menuFileOpenVsq;
        public ToolStripSeparator toolStripMenuItem10;
        public ToolStripMenuItem menuFileSaveNamed;
        public ToolStripMenuItem menuFileSave;
        public ToolStripMenuItem menuFileOpen;
        public ToolStripMenuItem menuFileNew;
        public ToolStripMenuItem toolStripMenuItem30;
        public ToolStripMenuItem toolStripMenuItem32;
        public ToolStripMenuItem toolStripMenuItem33;
        public ToolStripMenuItem toolStripMenuItem34;
        public ToolStripSeparator toolStripSeparator4;
        public ToolStripMenuItem toolStripMenuItem35;
        public ToolStripMenuItem toolStripMenuItem36;
        public ToolStripMenuItem toolStripMenuItem37;
        public ToolStripMenuItem toolStripMenuItem38;
        public ToolStripSeparator toolStripSeparator5;
        public ToolStripMenuItem toolStripMenuItem39;
        public ToolStripSeparator toolStripSeparator6;
        public ToolStripMenuItem toolStripMenuItem40;
        private PictureBox frqEditBtn;
        private Panel exportMenu;
        private Label ExportUstMI;
        private Label ExportVsqMI;
        private Label label14;
        private Timer renderTimer;
    }
}