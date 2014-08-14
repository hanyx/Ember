﻿using System;
using System.Windows.Forms;

namespace Screenshot.Forms
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            checkBoxEnableSoundEffect.Checked = Settings.Default.EnableSoundEffect;
            hotkeyTextBoxCaptureArea.Hotkey = Settings.Default.CaptureAreaHotkey;
            checkBoxUploadImage.Checked = Settings.Default.UploadImage;
            radioButtonCopyLinkToClipboard.Checked = Settings.Default.OnUploadCopyLinkToClipboard;
            radioButtonOpenImageInBrowser.Checked = Settings.Default.OnUploadOpenImageInBrowser;
            hotkeyTextBoxCaptureFullscreen.Hotkey = Settings.Default.CaptureFullscreenHotkey;
            hotkeyTextBoxCaptureActiveWindow.Hotkey = Settings.Default.CaptureActiveWindowHotkey;
            checkBoxSaveImage.Checked = Settings.Default.SaveImage;
        }

        private void SettingsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Settings.Default.EnableSoundEffect = checkBoxEnableSoundEffect.Checked;
            Settings.Default.CaptureAreaHotkey = hotkeyTextBoxCaptureArea.Hotkey;
            Settings.Default.UploadImage = checkBoxUploadImage.Checked;
            Settings.Default.OnUploadCopyLinkToClipboard = radioButtonCopyLinkToClipboard.Checked;
            Settings.Default.OnUploadOpenImageInBrowser = radioButtonOpenImageInBrowser.Checked;
            Settings.Default.CaptureFullscreenHotkey = hotkeyTextBoxCaptureFullscreen.Hotkey;
            Settings.Default.CaptureActiveWindowHotkey = hotkeyTextBoxCaptureActiveWindow.Hotkey;
            Settings.Default.SaveImage = checkBoxSaveImage.Checked;

            Settings.Default.Save();
        }
    }
}
