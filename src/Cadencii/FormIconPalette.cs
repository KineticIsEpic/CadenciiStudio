/*
 * FormIconPalette.cs
 * Copyright © 2010-2011 kbinani
 *
 * This file is part of cadencii.
 *
 * cadencii is free software; you can redistribute it and/or
 * modify it under the terms of the GPLv3 License.
 *
 * cadencii is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
 */
#if JAVA
package cadencii;

//INCLUDE-SECTION IMPORT ./ui/java/FormIconPalette.java

import java.util.*;
import java.awt.*;
import java.awt.datatransfer.*;
import java.awt.dnd.*;
import java.io.*;
import javax.swing.*;
import javax.imageio.*;
import cadencii.*;
import cadencii.apputil.*;
import cadencii.vsq.*;
import cadencii.windows.forms.*;
#else
using System;
using System.Windows.Forms;
using System.Linq;
using cadencii.apputil;
using cadencii.java.awt;
using cadencii.java.util;
using cadencii.javax.swing;
using cadencii.vsq;
using cadencii.windows.forms;

namespace cadencii
{
    using boolean = System.Boolean;
#endif

    class DraggableBButton : Button
    {
        private IconDynamicsHandle mHandle = null;
#if JAVA
        public DraggableBButton()
        {
            super();
            int drag_action = DnDConstants.ACTION_COPY;
            new DragSource().createDefaultDragGestureRecognizer(
                this, 
                drag_action, 
                new DragGestureListener(){
                    //@Override
                    public void dragGestureRecognized( DragGestureEvent e ) {
                        // 1) cursor
                        Cursor dragCursor = DragSource.DefaultCopyDrop;
    
                        // 2) transfer data
                        // タグにはIconDynamicsHandleが格納されている
                        if( mHandle == null ){
                            return;
                        }
                        String icon_id = mHandle.IconID;
                        StringSelection transferable = new StringSelection( ClipboardModel.CLIP_PREFIX + ":" + icon_id );
    
                        // 3) start drag
                        e.startDrag( dragCursor, transferable );
                    }
                } );
        }
#endif

        public IconDynamicsHandle getHandle()
        {
            return mHandle;
        }
        
        public void setHandle( IconDynamicsHandle value )
        {
            mHandle = value;
        }
    }

#if JAVA
    public class FormIconPalette extends BForm
#else
    public class FormIconPalette : Form
#endif
    {
        private Vector<Button> dynaffButtons = new Vector<Button>();
        private Vector<Button> crescendButtons = new Vector<Button>();
        private Vector<Button> decrescendButtons = new Vector<Button>();
        private int buttonWidth = 40;
        private FormMain mMainWindow = null;
        private boolean mPreviousAlwaysOnTop;

        public FormIconPalette( FormMain main_window )
        {
#if JAVA
            super();
            initialize();
#else
            InitializeComponent();
#endif
            mMainWindow = main_window;
            applyLanguage();
            Util.applyFontRecurse( this, AppManager.editorConfig.getBaseFont() );
            init();
            registerEventHandlers();
            TreeMap<String, Keys[]> dict = AppManager.editorConfig.getShortcutKeysDictionary( mMainWindow.getDefaultShortcutKeys() );
            if ( dict.containsKey( "menuVisualIconPalette" ) ) {
                Keys[] keys = dict.get( "menuVisualIconPalette" );
                Keys shortcut = Keys.None;
                keys.Aggregate(shortcut, (seed, key) => seed | key);
                menuWindowHide.ShortcutKeys = shortcut;
            }
        }
    
        #region public methods
        /// <summary>
        /// AlwaysOnTopが強制的にfalseにされる直前の，AlwaysOnTop値を取得します．
        /// </summary>
        public boolean getPreviousAlwaysOnTop()
        {
            return mPreviousAlwaysOnTop;
        }
        
        /// <summary>
        /// AlwaysOnTopが強制的にfalseにされる直前の，AlwaysOnTop値を設定しておきます．
        /// </summary>
        public void setPreviousAlwaysOnTop( boolean value )
        {
            mPreviousAlwaysOnTop = value;
        }

        public void applyLanguage()
        {
            this.Text = _( "Icon Palette" );
        }

        public void applyShortcut( Keys shortcut )
        {
            menuWindowHide.ShortcutKeys = shortcut;
        }
        #endregion

        #region helper methods
        private static String _( String id )
        {
            return Messaging.getMessage( id );
        }

        private void registerEventHandlers()
        {
            this.Load += new EventHandler( FormIconPalette_Load );
            this.FormClosing += new FormClosingEventHandler( FormIconPalette_FormClosing );
            menuWindowHide.Click += new EventHandler( menuWindowHide_Click );
        }

        private void init()
        {
            for ( Iterator<IconDynamicsHandle> itr = VocaloSysUtil.dynamicsConfigIterator( SynthesizerType.VOCALOID1 ); itr.hasNext(); ) {
                IconDynamicsHandle handle = itr.next();
                String icon_id = handle.IconID;
#if JAVA
                DraggableBButton btn = new DraggableBButton();
#else
                DraggableBButton btn = new DraggableBButton();
#endif
                btn.Name = icon_id;
                btn.setHandle( handle );
                String buttonIconPath = handle.getButtonImageFullPath();

                boolean setimg = System.IO.File.Exists(buttonIconPath);
                if ( setimg ) {
                    btn.Image = System.Drawing.Image.FromStream( new System.IO.FileStream( buttonIconPath, System.IO.FileMode.Open, System.IO.FileAccess.Read ) );
                } else {
                    System.Drawing.Image img = null;
                    String str = "";
                    String caption = handle.IDS;
                    if ( caption.Equals( "cresc_1" ) ) {
                        img = Properties.Resources.cresc1;
                    } else if ( caption.Equals( "cresc_2" ) ) {
                        img = Properties.Resources.cresc2;
                    } else if ( caption.Equals( "cresc_3" ) ) {
                        img = Properties.Resources.cresc3;
                    } else if ( caption.Equals( "cresc_4" ) ) {
                        img = Properties.Resources.cresc4;
                    } else if ( caption.Equals( "cresc_5" ) ) {
                        img = Properties.Resources.cresc5;
                    } else if ( caption.Equals( "dim_1" ) ) {
                        img = Properties.Resources.dim1;
                    } else if ( caption.Equals( "dim_2" ) ) {
                        img = Properties.Resources.dim2;
                    } else if ( caption.Equals( "dim_3" ) ) {
                        img = Properties.Resources.dim3;
                    } else if ( caption.Equals( "dim_4" ) ) {
                        img = Properties.Resources.dim4;
                    } else if ( caption.Equals( "dim_5" ) ) {
                        img = Properties.Resources.dim5;
                    } else if ( caption.Equals( "Dynaff11" ) ) {
                        str = "fff";
                    } else if ( caption.Equals( "Dynaff12" ) ) {
                        str = "ff";
                    } else if ( caption.Equals( "Dynaff13" ) ) {
                        str = "f";
                    } else if ( caption.Equals( "Dynaff21" ) ) {
                        str = "mf";
                    } else if ( caption.Equals( "Dynaff22" ) ) {
                        str = "mp";
                    } else if ( caption.Equals( "Dynaff31" ) ) {
                        str = "p";
                    } else if ( caption.Equals( "Dynaff32" ) ) {
                        str = "pp";
                    } else if ( caption.Equals( "Dynaff33" ) ) {
                        str = "ppp";
                    }
                    if ( img != null ) {
                        btn.Image = img;
                    } else {
                        btn.Text = str;
                    }
                }
                btn.MouseDown += new MouseEventHandler( handleCommonMouseDown );
                btn.Size = new System.Drawing.Size( buttonWidth, buttonWidth );
                int iw = 0;
                int ih = 0;
                if ( icon_id.StartsWith( IconDynamicsHandle.ICONID_HEAD_DYNAFF ) ) {
                    // dynaff
                    dynaffButtons.add( btn );
                    ih = 0;
                    iw = dynaffButtons.size() - 1;
                } else if ( icon_id.StartsWith( IconDynamicsHandle.ICONID_HEAD_CRESCEND ) ) {
                    // crescend
                    crescendButtons.add( btn );
                    ih = 1;
                    iw = crescendButtons.size() - 1;
                } else if ( icon_id.StartsWith( IconDynamicsHandle.ICONID_HEAD_DECRESCEND ) ) {
                    // decrescend
                    decrescendButtons.add( btn );
                    ih = 2;
                    iw = decrescendButtons.size() - 1;
                } else {
                    continue;
                }
#if JAVA
                LayoutManager lm = jPanel.getLayout();
                GridBagLayout gbl = null;
                if( lm != null && lm instanceof GridBagLayout ){
                    gbl = (GridBagLayout)lm;
                }else{
                    gbl = new GridBagLayout();
                    jPanel.setLayout( gbl );
                }
                GridBagConstraints g = new GridBagConstraints();
                g.gridx = iw;
                g.gridy = ih;
                gbl.setConstraints( btn, g );
                jPanel.add( btn );
#else
                btn.Location = new System.Drawing.Point( iw * buttonWidth, ih * buttonWidth );
                this.Controls.Add( btn );
                btn.BringToFront();
#endif
            }

            // ウィンドウのサイズを固定化する
            int height = 0;
            int width = 0;
            if ( dynaffButtons.size() > 0 ) {
                height += buttonWidth;
            }
            width = Math.Max( width, buttonWidth * dynaffButtons.size() );
            if ( crescendButtons.size() > 0 ) {
                height += buttonWidth;
            }
            width = Math.Max( width, buttonWidth * crescendButtons.size() );
            if ( decrescendButtons.size() > 0 ) {
                height += buttonWidth;
            }
            width = Math.Max( width, buttonWidth * decrescendButtons.size() );
#if JAVA
            pack();
            Insets i = getInsets();
            Dimension size = new Dimension( width + i.left + i.right, height + i.top + i.bottom );
            setPreferredSize( size );
            setSize( size );
            setResizable( false );
#else
            this.ClientSize = new System.Drawing.Size( width, height );
            var size = this.Size;
#endif
            this.MaximumSize = new System.Drawing.Size(size.Width, size.Height);
            this.MinimumSize = new System.Drawing.Size(size.Width, size.Height);
        }
        #endregion

        #region event handlers
        public void FormIconPalette_Load( Object sender, EventArgs e )
        {
            // コンストラクタから呼ぶと、スレッドが違うので（たぶん）うまく行かない
            this.TopMost = true;
        }

        public void FormIconPalette_FormClosing( Object sender, FormClosingEventArgs e )
        {
            this.Visible = false;
            e.Cancel = true;
        }

        public void menuWindowHide_Click( Object sender, EventArgs e )
        {
            this.Visible = false;
        }

        public void handleCommonMouseDown( Object sender, MouseEventArgs e )
        {
            if ( AppManager.getEditMode() != EditMode.NONE ) {
                return;
            }
            DraggableBButton btn = (DraggableBButton)sender;
            if ( mMainWindow != null ) {
                mMainWindow.BringToFront();
            }

            IconDynamicsHandle handle = btn.getHandle();
            VsqEvent item = new VsqEvent();
            item.Clock = 0;
            item.ID.Note = 60;
            item.ID.type = VsqIDType.Aicon;
            item.ID.IconDynamicsHandle = (IconDynamicsHandle)handle.clone();
            int length = handle.getLength();
            if ( length <= 0 ) {
                length = 1;
            }
            item.ID.setLength( length );
            AppManager.mAddingEvent = item;

#if JAVA
            //TODO: fixme FormIconPalette#handleCommonMouseDown
#else
            btn.DoDragDrop( handle, System.Windows.Forms.DragDropEffects.All );
#endif
        }
        #endregion

        #region UI implementation
#if JAVA
        //INCLUDE-SECTION FIELD ./ui/java/FormIconPalette.java
        //INCLUDE-SECTION METHOD ./ui/java/FormIconPalette.java
#else
        private void InitializeComponent()
        {
            this.menuBar = new MenuStrip();
            this.menuWindow = new ToolStripMenuItem();
            this.menuWindowHide = new ToolStripMenuItem();
            this.menuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuBar
            // 
            this.menuBar.Items.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.menuWindow} );
            this.menuBar.Location = new System.Drawing.Point( 0, 0 );
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size( 458, 24 );
            this.menuBar.TabIndex = 0;
            this.menuBar.Text = "bMenuBar1";
            // 
            // menuWindow
            // 
            this.menuWindow.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.menuWindowHide} );
            this.menuWindow.Name = "menuWindow";
            this.menuWindow.Size = new System.Drawing.Size( 55, 20 );
            this.menuWindow.Text = "Window";
            // 
            // menuWindowHide
            // 
            this.menuWindowHide.Name = "menuWindowHide";
            this.menuWindowHide.Size = new System.Drawing.Size( 93, 22 );
            this.menuWindowHide.Text = "Hide";
            // 
            // FormIconPalette
            // 
            this.ClientSize = new System.Drawing.Size( 458, 342 );
            this.Controls.Add( this.menuBar );
            this.MainMenuStrip = this.menuBar;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormIconPalette";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Icon Palette";
            this.menuBar.ResumeLayout( false );
            this.menuBar.PerformLayout();
            this.ResumeLayout( false );
            this.PerformLayout();

        }

        private MenuStrip menuBar;
        private ToolStripMenuItem menuWindow;
        private ToolStripMenuItem menuWindowHide;

#endif
        #endregion

    }

#if !JAVA
}
#endif
