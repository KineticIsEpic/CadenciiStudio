using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using cadencii.java.awt;
using cadencii.java.util;
using System.Windows.Forms;
using cadencii.apputil;
using cadencii.vsq;
using System.IO;

namespace cadencii {
    class PrefManager {
        Preference mDialogPreference;


        public void showPrefs(Form Parent, System.Drawing.Point location, bool showVBCfg) {
            try {
                if (mDialogPreference == null) {
                    mDialogPreference = new Preference();
                }
                mDialogPreference.setBaseFont(new Font(AppManager.editorConfig.BaseFontName, java.awt.Font.PLAIN, AppManager.FONT_SIZE9));
                mDialogPreference.setScreenFont(new Font(AppManager.editorConfig.ScreenFontName, java.awt.Font.PLAIN, AppManager.FONT_SIZE9));
                mDialogPreference.setWheelOrder(AppManager.editorConfig.WheelOrder);
                mDialogPreference.setCursorFixed(AppManager.editorConfig.CursorFixed);
                mDialogPreference.setDefaultVibratoLength(AppManager.editorConfig.DefaultVibratoLength);
                mDialogPreference.setAutoVibratoThresholdLength(AppManager.editorConfig.AutoVibratoThresholdLength);
                mDialogPreference.setAutoVibratoType1(AppManager.editorConfig.AutoVibratoType1);
                mDialogPreference.setAutoVibratoType2(AppManager.editorConfig.AutoVibratoType2);
                mDialogPreference.setAutoVibratoTypeCustom(AppManager.editorConfig.AutoVibratoTypeCustom);
                mDialogPreference.setEnableAutoVibrato(AppManager.editorConfig.EnableAutoVibrato);
                mDialogPreference.setPreSendTime(AppManager.editorConfig.PreSendTime);
                mDialogPreference.setControlCurveResolution(AppManager.editorConfig.ControlCurveResolution);
                mDialogPreference.setDefaultSingerName(AppManager.editorConfig.DefaultSingerName);
                mDialogPreference.setScrollHorizontalOnWheel(AppManager.editorConfig.ScrollHorizontalOnWheel);
                mDialogPreference.setMaximumFrameRate(AppManager.editorConfig.MaximumFrameRate);
                mDialogPreference.setKeepLyricInputMode(AppManager.editorConfig.KeepLyricInputMode);
                mDialogPreference.setPxTrackHeight(AppManager.editorConfig.PxTrackHeight);
                mDialogPreference.setMouseHoverTime(AppManager.editorConfig.getMouseHoverTime());
                mDialogPreference.setPlayPreviewWhenRightClick(AppManager.editorConfig.PlayPreviewWhenRightClick);
                mDialogPreference.setCurveSelectingQuantized(AppManager.editorConfig.CurveSelectingQuantized);
                mDialogPreference.setCurveVisibleAccent(AppManager.editorConfig.CurveVisibleAccent);
                mDialogPreference.setCurveVisibleBre(AppManager.editorConfig.CurveVisibleBreathiness);
                mDialogPreference.setCurveVisibleBri(AppManager.editorConfig.CurveVisibleBrightness);
                mDialogPreference.setCurveVisibleCle(AppManager.editorConfig.CurveVisibleClearness);
                mDialogPreference.setCurveVisibleDecay(AppManager.editorConfig.CurveVisibleDecay);
                mDialogPreference.setCurveVisibleDyn(AppManager.editorConfig.CurveVisibleDynamics);
                mDialogPreference.setCurveVisibleGen(AppManager.editorConfig.CurveVisibleGendorfactor);
                mDialogPreference.setCurveVisibleOpe(AppManager.editorConfig.CurveVisibleOpening);
                mDialogPreference.setCurveVisiblePit(AppManager.editorConfig.CurveVisiblePit);
                mDialogPreference.setCurveVisiblePbs(AppManager.editorConfig.CurveVisiblePbs);
                mDialogPreference.setCurveVisiblePor(AppManager.editorConfig.CurveVisiblePortamento);
                mDialogPreference.setCurveVisibleVel(AppManager.editorConfig.CurveVisibleVelocity);
                mDialogPreference.setCurveVisibleVibratoDepth(AppManager.editorConfig.CurveVisibleVibratoDepth);
                mDialogPreference.setCurveVisibleVibratoRate(AppManager.editorConfig.CurveVisibleVibratoRate);
                mDialogPreference.setCurveVisibleFx2Depth(AppManager.editorConfig.CurveVisibleFx2Depth);
                mDialogPreference.setCurveVisibleHarmonics(AppManager.editorConfig.CurveVisibleHarmonics);
                mDialogPreference.setCurveVisibleReso1(AppManager.editorConfig.CurveVisibleReso1);
                mDialogPreference.setCurveVisibleReso2(AppManager.editorConfig.CurveVisibleReso2);
                mDialogPreference.setCurveVisibleReso3(AppManager.editorConfig.CurveVisibleReso3);
                mDialogPreference.setCurveVisibleReso4(AppManager.editorConfig.CurveVisibleReso4);
                mDialogPreference.setCurveVisibleEnvelope(AppManager.editorConfig.CurveVisibleEnvelope);
#if ENABLE_MIDI
                mDialogPreference.setMidiInPort(AppManager.editorConfig.MidiInPort.PortNumber);
#endif
#if ENABLE_MTC
            	m_preference_dlg.setMtcMidiInPort( AppManager.editorConfig.MidiInPortMtc.PortNumber );

#endif
                Vector<String> resamplers = new Vector<String>();
                Vector<Boolean> with_wine = new Vector<Boolean>();
                int size = AppManager.editorConfig.getResamplerCount();
                for (int i = 0; i < size; i++) {
                    resamplers.add(AppManager.editorConfig.getResamplerAt(i));
                    with_wine.add(AppManager.editorConfig.isResamplerWithWineAt(i));
                }
                mDialogPreference.setResamplersConfig(resamplers, with_wine);
                mDialogPreference.setPathWavtool(AppManager.editorConfig.PathWavtool);
                mDialogPreference.setWavtoolWithWine(AppManager.editorConfig.WavtoolWithWine);
                mDialogPreference.setUtausingers(AppManager.editorConfig.UtauSingers);
                mDialogPreference.setSelfDeRomantization(AppManager.editorConfig.SelfDeRomanization);
                mDialogPreference.setAutoBackupIntervalMinutes(AppManager.editorConfig.AutoBackupIntervalMinutes);
                mDialogPreference.setUseSpaceKeyAsMiddleButtonModifier(AppManager.editorConfig.UseSpaceKeyAsMiddleButtonModifier);
                mDialogPreference.setPathAquesTone(AppManager.editorConfig.PathAquesTone);
                mDialogPreference.setPathAquesTone2(AppManager.editorConfig.PathAquesTone2);
                mDialogPreference.setUseProjectCache(AppManager.editorConfig.UseProjectCache);
                mDialogPreference.setAquesToneRequired(!AppManager.editorConfig.DoNotUseAquesTone);
                mDialogPreference.setAquesTone2Requried(!AppManager.editorConfig.DoNotUseAquesTone2);
                mDialogPreference.setVocaloid1Required(!AppManager.editorConfig.DoNotUseVocaloid1);
                mDialogPreference.setVocaloid2Required(!AppManager.editorConfig.DoNotUseVocaloid2);
                mDialogPreference.setBufferSize(AppManager.editorConfig.BufferSizeMilliSeconds);
                mDialogPreference.setDefaultSynthesizer(AppManager.editorConfig.DefaultSynthesizer);
                mDialogPreference.setUseUserDefinedAutoVibratoType(AppManager.editorConfig.UseUserDefinedAutoVibratoType);
                mDialogPreference.setWinePrefix(AppManager.editorConfig.WinePrefix);
                mDialogPreference.setWineTop(AppManager.editorConfig.WineTop);
                mDialogPreference.setWineBuiltin(AppManager.editorConfig.WineTopBuiltin);
                mDialogPreference.setEnableWideCharacterWorkaround(AppManager.editorConfig.UseWideCharacterWorkaround);

                String old_wine_prefix = AppManager.editorConfig.WinePrefix;
                String old_wine_top = AppManager.editorConfig.getWineTop();

                mDialogPreference.Location = location;

                //Show the special voicebank config menu if it's requested
                if (showVBCfg) {
                    mDialogPreference.showEasySetupUtauVB();
                }

                DialogResult dr = AppManager.showModalDialog(mDialogPreference, Parent);
                if (dr == DialogResult.OK) {
                    String old_base_font_name = AppManager.editorConfig.BaseFontName;
                    float old_base_font_size = AppManager.editorConfig.BaseFontSize;
                    Font new_base_font = mDialogPreference.getBaseFont();
                    if (!old_base_font_name.Equals(new_base_font.getName()) ||
                         old_base_font_size != new_base_font.getSize2D()) {
                        AppManager.editorConfig.BaseFontName = mDialogPreference.getBaseFont().getName();
                        AppManager.editorConfig.BaseFontSize = mDialogPreference.getBaseFont().getSize2D();
                        //updateMenuFonts();
                    }

                    AppManager.editorConfig.ScreenFontName = mDialogPreference.getScreenFont().getName();
                    AppManager.editorConfig.WheelOrder = mDialogPreference.getWheelOrder();
                    AppManager.editorConfig.CursorFixed = mDialogPreference.isCursorFixed();

                    AppManager.editorConfig.DefaultVibratoLength = mDialogPreference.getDefaultVibratoLength();
                    AppManager.editorConfig.AutoVibratoThresholdLength = mDialogPreference.getAutoVibratoThresholdLength();
                    AppManager.editorConfig.AutoVibratoType1 = mDialogPreference.getAutoVibratoType1();
                    AppManager.editorConfig.AutoVibratoType2 = mDialogPreference.getAutoVibratoType2();
                    AppManager.editorConfig.AutoVibratoTypeCustom = mDialogPreference.getAutoVibratoTypeCustom();

                    AppManager.editorConfig.EnableAutoVibrato = mDialogPreference.isEnableAutoVibrato();
                    AppManager.editorConfig.PreSendTime = mDialogPreference.getPreSendTime();
                    AppManager.editorConfig.Language = mDialogPreference.getLanguage();
                    if (!Messaging.getLanguage().Equals(AppManager.editorConfig.Language)) {
                        Messaging.setLanguage(AppManager.editorConfig.Language);
                        //applyLanguage();
                        mDialogPreference.applyLanguage();
                        //AppManager.mMixerWindow.applyLanguage();
                        //if (mVersionInfo != null && !mVersionInfo.IsDisposed) {
                        //    mVersionInfo.applyLanguage();
                        //}
#if ENABLE_PROPERTY
                        AppManager.propertyWindow.applyLanguage();
                        AppManager.propertyPanel.updateValue(AppManager.getSelected());
#endif
                        //if (mDialogMidiImportAndExport != null) {
                        //    mDialogMidiImportAndExport.applyLanguage();
                        //}
                    }

                    AppManager.editorConfig.ControlCurveResolution = mDialogPreference.getControlCurveResolution();
                    AppManager.editorConfig.DefaultSingerName = mDialogPreference.getDefaultSingerName();
                    AppManager.editorConfig.ScrollHorizontalOnWheel = mDialogPreference.isScrollHorizontalOnWheel();
                    AppManager.editorConfig.MaximumFrameRate = mDialogPreference.getMaximumFrameRate();
                    int fps = 1000 / AppManager.editorConfig.MaximumFrameRate;
                    //timer.Interval = (fps <= 0) ? 1 : fps;
                    //applyShortcut();
                    AppManager.editorConfig.KeepLyricInputMode = mDialogPreference.isKeepLyricInputMode();
                    if (AppManager.editorConfig.PxTrackHeight != mDialogPreference.getPxTrackHeight()) {
                        AppManager.editorConfig.PxTrackHeight = mDialogPreference.getPxTrackHeight();
                        //updateDrawObjectList();
                    }
                    AppManager.editorConfig.setMouseHoverTime(mDialogPreference.getMouseHoverTime());
                    AppManager.editorConfig.PlayPreviewWhenRightClick = mDialogPreference.isPlayPreviewWhenRightClick();
                    AppManager.editorConfig.CurveSelectingQuantized = mDialogPreference.isCurveSelectingQuantized();

                    AppManager.editorConfig.CurveVisibleAccent = mDialogPreference.isCurveVisibleAccent();
                    AppManager.editorConfig.CurveVisibleBreathiness = mDialogPreference.isCurveVisibleBre();
                    AppManager.editorConfig.CurveVisibleBrightness = mDialogPreference.isCurveVisibleBri();
                    AppManager.editorConfig.CurveVisibleClearness = mDialogPreference.isCurveVisibleCle();
                    AppManager.editorConfig.CurveVisibleDecay = mDialogPreference.isCurveVisibleDecay();
                    AppManager.editorConfig.CurveVisibleDynamics = mDialogPreference.isCurveVisibleDyn();
                    AppManager.editorConfig.CurveVisibleGendorfactor = mDialogPreference.isCurveVisibleGen();
                    AppManager.editorConfig.CurveVisibleOpening = mDialogPreference.isCurveVisibleOpe();
                    AppManager.editorConfig.CurveVisiblePit = mDialogPreference.isCurveVisiblePit();
                    AppManager.editorConfig.CurveVisiblePbs = mDialogPreference.isCurveVisiblePbs();
                    AppManager.editorConfig.CurveVisiblePortamento = mDialogPreference.isCurveVisiblePor();
                    AppManager.editorConfig.CurveVisibleVelocity = mDialogPreference.isCurveVisibleVel();
                    AppManager.editorConfig.CurveVisibleVibratoDepth = mDialogPreference.isCurveVisibleVibratoDepth();
                    AppManager.editorConfig.CurveVisibleVibratoRate = mDialogPreference.isCurveVisibleVibratoRate();
                    AppManager.editorConfig.CurveVisibleFx2Depth = mDialogPreference.isCurveVisibleFx2Depth();
                    AppManager.editorConfig.CurveVisibleHarmonics = mDialogPreference.isCurveVisibleHarmonics();
                    AppManager.editorConfig.CurveVisibleReso1 = mDialogPreference.isCurveVisibleReso1();
                    AppManager.editorConfig.CurveVisibleReso2 = mDialogPreference.isCurveVisibleReso2();
                    AppManager.editorConfig.CurveVisibleReso3 = mDialogPreference.isCurveVisibleReso3();
                    AppManager.editorConfig.CurveVisibleReso4 = mDialogPreference.isCurveVisibleReso4();
                    AppManager.editorConfig.CurveVisibleEnvelope = mDialogPreference.isCurveVisibleEnvelope();

#if ENABLE_MIDI
                    AppManager.editorConfig.MidiInPort.PortNumber = mDialogPreference.getMidiInPort();
#endif
#if ENABLE_MTC
                    AppManager.editorConfig.MidiInPortMtc.PortNumber = m_preference_dlg.getMtcMidiInPort();
#endif
#if ENABLE_MIDI || ENABLE_MTC
                    //updateMidiInStatus();
                    //reloadMidiIn();
#endif

                    Vector<String> new_resamplers = new Vector<String>();
                    Vector<Boolean> new_with_wine = new Vector<Boolean>();
                    mDialogPreference.copyResamplersConfig(new_resamplers, new_with_wine);
                    AppManager.editorConfig.clearResampler();
                    for (int i = 0; i < new_resamplers.size(); i++) {
                        AppManager.editorConfig.addResampler(new_resamplers.get(i), new_with_wine.get(i));
                    }
                    AppManager.editorConfig.PathWavtool = mDialogPreference.getPathWavtool();
                    AppManager.editorConfig.WavtoolWithWine = mDialogPreference.isWavtoolWithWine();

                    AppManager.editorConfig.UtauSingers.clear();
                    for (Iterator<SingerConfig> itr = mDialogPreference.getUtausingers().iterator(); itr.hasNext(); ) {
                        SingerConfig sc = itr.next();
                        AppManager.editorConfig.UtauSingers.add((SingerConfig)sc.clone());
                    }
                    AppManager.reloadUtauVoiceDB();

                    AppManager.editorConfig.SelfDeRomanization = mDialogPreference.isSelfDeRomantization();
                    AppManager.editorConfig.AutoBackupIntervalMinutes = mDialogPreference.getAutoBackupIntervalMinutes();
                    AppManager.editorConfig.UseSpaceKeyAsMiddleButtonModifier = mDialogPreference.isUseSpaceKeyAsMiddleButtonModifier();

#if ENABLE_AQUESTONE
                    var old_aquestone_config = Tuple.Create(AppManager.editorConfig.PathAquesTone, AppManager.editorConfig.DoNotUseAquesTone);
                    AppManager.editorConfig.PathAquesTone = mDialogPreference.getPathAquesTone();
                    AppManager.editorConfig.DoNotUseAquesTone = !mDialogPreference.isAquesToneRequired();
                    if (old_aquestone_config.Item1 != AppManager.editorConfig.PathAquesTone
                        || old_aquestone_config.Item2 != AppManager.editorConfig.DoNotUseAquesTone) {
                        VSTiDllManager.reloadAquesTone();
                    }

                    var old_aquestone2_config = Tuple.Create(AppManager.editorConfig.PathAquesTone2, AppManager.editorConfig.DoNotUseAquesTone2);
                    AppManager.editorConfig.PathAquesTone2 = mDialogPreference.getPathAquesTone2();
                    AppManager.editorConfig.DoNotUseAquesTone2 = !mDialogPreference.isAquesTone2Required();
                    if (old_aquestone2_config.Item1 != AppManager.editorConfig.PathAquesTone2
                        || old_aquestone2_config.Item2 != AppManager.editorConfig.DoNotUseAquesTone2) {
                        VSTiDllManager.reloadAquesTone2();
                    }
#endif
                    //updateRendererMenu();

                    //AppManager.editorConfig.__revoked__WaveFileOutputFromMasterTrack = mDialogPreference.isWaveFileOutputFromMasterTrack();
                    //AppManager.editorConfig.__revoked__WaveFileOutputChannel = mDialogPreference.getWaveFileOutputChannel();
                    if (AppManager.editorConfig.UseProjectCache && !mDialogPreference.isUseProjectCache()) {
                        // プロジェクト用キャッシュを使用していたが，使用しないように変更された場合.
                        // プロジェクト用キャッシュが存在するなら，共用のキャッシュに移動する．
                        String file = AppManager.getFileName();
                        if (file != null && !file.Equals("")) {
                            String dir = PortUtil.getDirectoryName(file);
                            String name = PortUtil.getFileNameWithoutExtension(file);
                            String projectCacheDir = Path.Combine(dir, name + ".cadencii");
                            String commonCacheDir = Path.Combine(AppManager.getCadenciiTempDir(), AppManager.getID());
                            if (Directory.Exists(projectCacheDir)) {
                                VsqFileEx vsq = AppManager.getVsqFile();
                                for (int i = 1; i < vsq.Track.size(); i++) {
                                    // wavを移動
                                    String wavFrom = Path.Combine(projectCacheDir, i + ".wav");
                                    String wavTo = Path.Combine(commonCacheDir, i + ".wav");
                                    if (!System.IO.File.Exists(wavFrom)) {
                                        continue;
                                    }
                                    if (System.IO.File.Exists(wavTo)) {
                                        try {
                                            PortUtil.deleteFile(wavTo);
                                        }
                                        catch (Exception ex) {
                                            Logger.write(typeof(FormMain) + ".menuSettingPreference_Click; ex=" + ex + "\n");
                                            serr.println("FormMain#menuSettingPreference_Click; ex=" + ex);
                                            continue;
                                        }
                                    }
                                    try {
                                        PortUtil.moveFile(wavFrom, wavTo);
                                    }
                                    catch (Exception ex) {
                                        Logger.write(typeof(FormMain) + ".menuSettingPreference_Click; ex=" + ex + "\n");
                                        serr.println("FormMain#menuSettingPreference_Click; ex=" + ex);
                                    }

                                    // xmlを移動
                                    String xmlFrom = Path.Combine(projectCacheDir, i + ".xml");
                                    String xmlTo = Path.Combine(commonCacheDir, i + ".xml");
                                    if (!System.IO.File.Exists(xmlFrom)) {
                                        continue;
                                    }
                                    if (System.IO.File.Exists(xmlTo)) {
                                        try {
                                            PortUtil.deleteFile(xmlTo);
                                        }
                                        catch (Exception ex) {
                                            Logger.write(typeof(FormMain) + ".menuSettingPreference_Click; ex=" + ex + "\n");
                                            serr.println("FormMain#menuSettingPreference_Click; ex=" + ex);
                                            continue;
                                        }
                                    }
                                    try {
                                        PortUtil.moveFile(xmlFrom, xmlTo);
                                    }
                                    catch (Exception ex) {
                                        Logger.write(typeof(FormMain) + ".menuSettingPreference_Click; ex=" + ex + "\n");
                                        serr.println("FormMain#menuSettingPreference_Click; ex=" + ex);
                                    }
                                }

                                // projectCacheDirが空なら，ディレクトリごと削除する
                                String[] files = PortUtil.listFiles(projectCacheDir, "*.*");
                                if (files.Length <= 0) {
                                    try {
                                        PortUtil.deleteDirectory(projectCacheDir);
                                    }
                                    catch (Exception ex) {
                                        Logger.write(typeof(FormMain) + ".menuSettingPreference_Click; ex=" + ex + "\n");
                                        serr.println("FormMain#menuSettingPreference_Click; ex=" + ex);
                                    }
                                }

                                // キャッシュのディレクトリを再指定
                                AppManager.setTempWaveDir(commonCacheDir);
                            }
                        }
                    }
                    AppManager.editorConfig.UseProjectCache = mDialogPreference.isUseProjectCache();
                    AppManager.editorConfig.DoNotUseVocaloid1 = !mDialogPreference.isVocaloid1Required();
                    AppManager.editorConfig.DoNotUseVocaloid2 = !mDialogPreference.isVocaloid2Required();
                    AppManager.editorConfig.BufferSizeMilliSeconds = mDialogPreference.getBufferSize();
                    AppManager.editorConfig.DefaultSynthesizer = mDialogPreference.getDefaultSynthesizer();
                    AppManager.editorConfig.UseUserDefinedAutoVibratoType = mDialogPreference.isUseUserDefinedAutoVibratoType();
                    AppManager.editorConfig.WinePrefix = mDialogPreference.getWinePrefix();
                    AppManager.editorConfig.WineTop = mDialogPreference.getWineTop();
                    AppManager.editorConfig.WineTopBuiltin = mDialogPreference.isWineBuiltin();
                    AppManager.editorConfig.UseWideCharacterWorkaround = mDialogPreference.isEnableWideCharacterWorkaround();

                    //trackSelector.prepareSingerMenu(VsqFileEx.getTrackRendererKind(AppManager.getVsqFile().Track.get(AppManager.getSelected())));
                    //trackSelector.updateVisibleCurves();

                    //updateRendererMenu();
                    AppManager.updateAutoBackupTimerStatus();

                    // editorConfig.PxTrackHeightが変更されている可能性があるので，更新が必要
                    //controller.setStartToDrawY(calculateStartToDrawY(vScroll.Value));

                    //if (menuVisualControlTrack.Checked) {
                    //    splitContainer1.setPanel2MinSize(trackSelector.getPreferredMinSize());
                    //}

                    AppManager.saveConfig();
                    //applyLanguage();
#if ENABLE_SCRIPT
                    //updateScriptShortcut();
#endif

                    //updateDrawObjectList();
                    //refreshScreen();
                }
            }
            catch (Exception ex) {
                Logger.write(typeof(FormMain) + ".menuSettingPreference_Click; ex=" + ex + "\n");
                AppManager.debugWriteLine("FormMain#menuSettingPreference_Click; ex=" + ex);
            }
        }
    }
}
