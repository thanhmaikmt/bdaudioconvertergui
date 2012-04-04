namespace BDAudioConverterGUI
{
    partial class Form_Main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.dataGridViewMain = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clearListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkNoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeUncheckedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.linkLabelAAC = new System.Windows.Forms.LinkLabel();
            this.groupBoxAACTarget = new System.Windows.Forms.GroupBox();
            this.radioButtonAACBitrate = new System.Windows.Forms.RadioButton();
            this.radioButtonAACQuality = new System.Windows.Forms.RadioButton();
            this.groupBoxAACOptions = new System.Windows.Forms.GroupBox();
            this.checkBoxAACRTPHinttrack = new System.Windows.Forms.CheckBox();
            this.labelAACProfile = new System.Windows.Forms.Label();
            this.comboBoxAACProfiles = new System.Windows.Forms.ComboBox();
            this.groupBoxAACBitrate = new System.Windows.Forms.GroupBox();
            this.checkBoxAACRestrictEncoder = new System.Windows.Forms.CheckBox();
            this.labelAACBitrate = new System.Windows.Forms.Label();
            this.trackBarAACBitrate = new System.Windows.Forms.TrackBar();
            this.groupBoxAACQuality = new System.Windows.Forms.GroupBox();
            this.labelAACQuality = new System.Windows.Forms.Label();
            this.trackBarAACQuality = new System.Windows.Forms.TrackBar();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBoxAC3DynamicRangeDialogNormalization = new System.Windows.Forms.GroupBox();
            this.comboBoxAC3DialogNormalization = new System.Windows.Forms.ComboBox();
            this.labelAC3DialogNormalization = new System.Windows.Forms.Label();
            this.comboBoxAC3DynamicRange = new System.Windows.Forms.ComboBox();
            this.labelAC3DynamicRange = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBoxAC3BitstreamInfoDolbySurround = new System.Windows.Forms.ComboBox();
            this.labelAC3BitstreamInfoDolbySurround = new System.Windows.Forms.Label();
            this.comboBoxAC3BitsreamInfoSurroundmix = new System.Windows.Forms.ComboBox();
            this.labelAC3BitsreamInfoSurroundmix = new System.Windows.Forms.Label();
            this.comboBoxAC3BitsreamInfoCentermix = new System.Windows.Forms.ComboBox();
            this.labelAC3BitsreamInfoCentermix = new System.Windows.Forms.Label();
            this.groupBoxAC3ExponentStrategySearchSize = new System.Windows.Forms.GroupBox();
            this.labelAC3ExponentStrategySearchSize = new System.Windows.Forms.Label();
            this.trackBarAC3ExponentStrategySearchSize = new System.Windows.Forms.TrackBar();
            this.linkLabelAC3 = new System.Windows.Forms.LinkLabel();
            this.groupBoxAC3Bitrate = new System.Windows.Forms.GroupBox();
            this.labelAC3Bitrate = new System.Windows.Forms.Label();
            this.trackBarAC3Bitrate = new System.Windows.Forms.TrackBar();
            this.tabPage11 = new System.Windows.Forms.TabPage();
            this.groupBoxDTSBitrate = new System.Windows.Forms.GroupBox();
            this.radioButtonDTSBitrate150975 = new System.Windows.Forms.RadioButton();
            this.radioButtonDTSBitrate7545 = new System.Windows.Forms.RadioButton();
            this.linkLabelDTS = new System.Windows.Forms.LinkLabel();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.linkLabelFLAC = new System.Windows.Forms.LinkLabel();
            this.groupBoxFLACCompression = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelFLACCompression = new System.Windows.Forms.Label();
            this.trackBarFLACCompression = new System.Windows.Forms.TrackBar();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.linkLabelMP3 = new System.Windows.Forms.LinkLabel();
            this.groupBoxMP3Options = new System.Windows.Forms.GroupBox();
            this.checkBoxMP3OptionsErrorProtection = new System.Windows.Forms.CheckBox();
            this.labelMP3OptionsChannelModes = new System.Windows.Forms.Label();
            this.comboBoxMP3OptionsChannelModes = new System.Windows.Forms.ComboBox();
            this.groupBoxMP3Bitrate = new System.Windows.Forms.GroupBox();
            this.checkBoxMP3RestrictEncoder = new System.Windows.Forms.CheckBox();
            this.labelMP3Bitrate = new System.Windows.Forms.Label();
            this.trackBarMP3Bitrate = new System.Windows.Forms.TrackBar();
            this.groupBoxMP3Quality = new System.Windows.Forms.GroupBox();
            this.labelMP3Quality = new System.Windows.Forms.Label();
            this.trackBarMP3Quality = new System.Windows.Forms.TrackBar();
            this.groupBoxMP3Target = new System.Windows.Forms.GroupBox();
            this.radioButtonMP3Bitrate = new System.Windows.Forms.RadioButton();
            this.radioButtonMP3Quality = new System.Windows.Forms.RadioButton();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.groupBoxWAVOutputFormat = new System.Windows.Forms.GroupBox();
            this.radioButtonWAVOutputFormatAIFF = new System.Windows.Forms.RadioButton();
            this.radioButtonWAVOutputFormatWAV = new System.Windows.Forms.RadioButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelSoXSettingsMainBufferSize = new System.Windows.Forms.Label();
            this.comboBoxSoXSettingsMainBufferSize = new System.Windows.Forms.ComboBox();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.groupBoxSoXSettingsMainPrepareStream = new System.Windows.Forms.GroupBox();
            this.comboBoxSoXSettingsInputConvertEncodingType = new System.Windows.Forms.ComboBox();
            this.checkBoxSoXSettingsInputConvertEncodingType = new System.Windows.Forms.CheckBox();
            this.comboBoxSoXSettingsInputConvertSamplingRate = new System.Windows.Forms.ComboBox();
            this.checkBoxSoXSettingsInputConvertSamplingRate = new System.Windows.Forms.CheckBox();
            this.checkBoxSoXSettingsInputConvertAudioResolution = new System.Windows.Forms.CheckBox();
            this.comboBoxSoXSettingsInputConvertAudioResolution = new System.Windows.Forms.ComboBox();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBoxSoxEffectsChangeTempoValue = new System.Windows.Forms.TextBox();
            this.radioButtonSoXEffectsChangeTempoValue = new System.Windows.Forms.RadioButton();
            this.textBoxSoxEffectsChangeDurationSource = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSoxEffectsChangeDurationTarget = new System.Windows.Forms.TextBox();
            this.checkBoxSoXEffectsPitch = new System.Windows.Forms.CheckBox();
            this.textBoxSoXSettingsPitch = new System.Windows.Forms.TextBox();
            this.radioButtonSoXEffectsChangeTempoDuration = new System.Windows.Forms.RadioButton();
            this.checkBoxSoXEffectsChangeTempo = new System.Windows.Forms.CheckBox();
            this.radioButtonSoXEffectsChangeTempoWithFPS = new System.Windows.Forms.RadioButton();
            this.textBoxSoxEffectsChangeFrameRateSource = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSoxEffectsChangeFrameRateTarget = new System.Windows.Forms.TextBox();
            this.checkBoxSoXSettingsGain = new System.Windows.Forms.CheckBox();
            this.textBoxSoXSettingsGain = new System.Windows.Forms.TextBox();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.comboBoxSoXSettingsDownmixProLogic = new System.Windows.Forms.ComboBox();
            this.checkBoxSoXSettingsDownmixActivate = new System.Windows.Forms.CheckBox();
            this.groupBoxSoXSettingsMatrix = new System.Windows.Forms.GroupBox();
            this.checkBoxSoXSettings51MixLFE = new System.Windows.Forms.CheckBox();
            this.checkBoxSoXSettings51DownmixNormalize = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxSoXSettings51Matrix00 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSoXSettings51Matrix01 = new System.Windows.Forms.TextBox();
            this.textBoxSoXSettings51Matrix15 = new System.Windows.Forms.TextBox();
            this.textBoxSoXSettings51Matrix02 = new System.Windows.Forms.TextBox();
            this.textBoxSoXSettings51Matrix14 = new System.Windows.Forms.TextBox();
            this.textBoxSoXSettings51Matrix03 = new System.Windows.Forms.TextBox();
            this.textBoxSoXSettings51Matrix13 = new System.Windows.Forms.TextBox();
            this.textBoxSoXSettings51Matrix04 = new System.Windows.Forms.TextBox();
            this.textBoxSoXSettings51Matrix12 = new System.Windows.Forms.TextBox();
            this.textBoxSoXSettings51Matrix05 = new System.Windows.Forms.TextBox();
            this.textBoxSoXSettings51Matrix11 = new System.Windows.Forms.TextBox();
            this.textBoxSoXSettings51Matrix10 = new System.Windows.Forms.TextBox();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.comboBoxSoXSettingsOutputConvertEncodingType = new System.Windows.Forms.ComboBox();
            this.checkBoxSoXSettingsOutputConvertEncodingType = new System.Windows.Forms.CheckBox();
            this.checkBoxSoXSettingsOutputConvertAudioResolution = new System.Windows.Forms.CheckBox();
            this.comboBoxSoXSettingsOutputConvertSamplingRate = new System.Windows.Forms.ComboBox();
            this.comboBoxSoXSettingsOutputConvertAudioResolution = new System.Windows.Forms.ComboBox();
            this.checkBoxSoXSettingsOutputConvertSamplingRate = new System.Windows.Forms.CheckBox();
            this.groupBoxEac3toSettings = new System.Windows.Forms.GroupBox();
            this.checkBoxEac3toSettingsConvertChannels = new System.Windows.Forms.CheckBox();
            this.checkBoxEac3toSettingsDialogNormalization = new System.Windows.Forms.CheckBox();
            this.radioButtonEac3toSettingsConvertTo51 = new System.Windows.Forms.RadioButton();
            this.radioButtonEac3toSettingsConvertToStereo = new System.Windows.Forms.RadioButton();
            this.buttonStartConverting = new System.Windows.Forms.Button();
            this.toolTipInfo = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxSoXSettings = new System.Windows.Forms.GroupBox();
            this.buttonCancelConverting = new System.Windows.Forms.Button();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBoxAACTarget.SuspendLayout();
            this.groupBoxAACOptions.SuspendLayout();
            this.groupBoxAACBitrate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAACBitrate)).BeginInit();
            this.groupBoxAACQuality.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAACQuality)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBoxAC3DynamicRangeDialogNormalization.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBoxAC3ExponentStrategySearchSize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAC3ExponentStrategySearchSize)).BeginInit();
            this.groupBoxAC3Bitrate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAC3Bitrate)).BeginInit();
            this.tabPage11.SuspendLayout();
            this.groupBoxDTSBitrate.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBoxFLACCompression.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFLACCompression)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBoxMP3Options.SuspendLayout();
            this.groupBoxMP3Bitrate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMP3Bitrate)).BeginInit();
            this.groupBoxMP3Quality.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMP3Quality)).BeginInit();
            this.groupBoxMP3Target.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.groupBoxWAVOutputFormat.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage10.SuspendLayout();
            this.groupBoxSoXSettingsMainPrepareStream.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabPage9.SuspendLayout();
            this.groupBoxSoXSettingsMatrix.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBoxEac3toSettings.SuspendLayout();
            this.groupBoxSoXSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewMain
            // 
            this.dataGridViewMain.AllowDrop = true;
            this.dataGridViewMain.AllowUserToAddRows = false;
            this.dataGridViewMain.AllowUserToDeleteRows = false;
            this.dataGridViewMain.AllowUserToResizeRows = false;
            this.dataGridViewMain.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewMain.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewMain.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridViewMain.ColumnHeadersHeight = 20;
            this.dataGridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewMain.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridViewMain.EnableHeadersVisualStyles = false;
            this.dataGridViewMain.GridColor = System.Drawing.Color.White;
            this.dataGridViewMain.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewMain.MultiSelect = false;
            this.dataGridViewMain.Name = "dataGridViewMain";
            this.dataGridViewMain.RowHeadersVisible = false;
            this.dataGridViewMain.RowHeadersWidth = 80;
            this.dataGridViewMain.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewMain.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMain.Size = new System.Drawing.Size(730, 202);
            this.dataGridViewMain.TabIndex = 0;
            this.dataGridViewMain.DragDrop += new System.Windows.Forms.DragEventHandler(this.dataGridView1_DragDrop);
            this.dataGridViewMain.DragEnter += new System.Windows.Forms.DragEventHandler(this.dataGridView1_DragEnter);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearListToolStripMenuItem,
            this.checkAllToolStripMenuItem,
            this.checkNoneToolStripMenuItem,
            this.removeUncheckedToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(180, 92);
            // 
            // clearListToolStripMenuItem
            // 
            this.clearListToolStripMenuItem.Name = "clearListToolStripMenuItem";
            this.clearListToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.clearListToolStripMenuItem.Text = "Clear List";
            this.clearListToolStripMenuItem.Click += new System.EventHandler(this.clearListToolStripMenuItem_Click);
            // 
            // checkAllToolStripMenuItem
            // 
            this.checkAllToolStripMenuItem.Name = "checkAllToolStripMenuItem";
            this.checkAllToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.checkAllToolStripMenuItem.Text = "Check All";
            this.checkAllToolStripMenuItem.Click += new System.EventHandler(this.checkAllToolStripMenuItem_Click);
            // 
            // checkNoneToolStripMenuItem
            // 
            this.checkNoneToolStripMenuItem.Name = "checkNoneToolStripMenuItem";
            this.checkNoneToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.checkNoneToolStripMenuItem.Text = "Check None";
            this.checkNoneToolStripMenuItem.Click += new System.EventHandler(this.checkNoneToolStripMenuItem_Click);
            // 
            // removeUncheckedToolStripMenuItem
            // 
            this.removeUncheckedToolStripMenuItem.Name = "removeUncheckedToolStripMenuItem";
            this.removeUncheckedToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.removeUncheckedToolStripMenuItem.Text = "Remove Unchecked";
            this.removeUncheckedToolStripMenuItem.Click += new System.EventHandler(this.removeUncheckedToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage11);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(6, 19);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(336, 405);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.linkLabelAAC);
            this.tabPage1.Controls.Add(this.groupBoxAACTarget);
            this.tabPage1.Controls.Add(this.groupBoxAACOptions);
            this.tabPage1.Controls.Add(this.groupBoxAACBitrate);
            this.tabPage1.Controls.Add(this.groupBoxAACQuality);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(328, 379);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "AAC";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // linkLabelAAC
            // 
            this.linkLabelAAC.AutoSize = true;
            this.linkLabelAAC.Location = new System.Drawing.Point(6, 355);
            this.linkLabelAAC.Name = "linkLabelAAC";
            this.linkLabelAAC.Size = new System.Drawing.Size(114, 13);
            this.linkLabelAAC.TabIndex = 5;
            this.linkLabelAAC.TabStop = true;
            this.linkLabelAAC.Text = "http://www.nero.com/";
            this.linkLabelAAC.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelAAC_LinkClicked);
            // 
            // groupBoxAACTarget
            // 
            this.groupBoxAACTarget.Controls.Add(this.radioButtonAACBitrate);
            this.groupBoxAACTarget.Controls.Add(this.radioButtonAACQuality);
            this.groupBoxAACTarget.Location = new System.Drawing.Point(6, 6);
            this.groupBoxAACTarget.Name = "groupBoxAACTarget";
            this.groupBoxAACTarget.Size = new System.Drawing.Size(313, 50);
            this.groupBoxAACTarget.TabIndex = 4;
            this.groupBoxAACTarget.TabStop = false;
            this.groupBoxAACTarget.Text = "Target";
            // 
            // radioButtonAACBitrate
            // 
            this.radioButtonAACBitrate.AutoSize = true;
            this.radioButtonAACBitrate.Location = new System.Drawing.Point(210, 19);
            this.radioButtonAACBitrate.Name = "radioButtonAACBitrate";
            this.radioButtonAACBitrate.Size = new System.Drawing.Size(55, 17);
            this.radioButtonAACBitrate.TabIndex = 1;
            this.radioButtonAACBitrate.Text = "Bitrate";
            this.radioButtonAACBitrate.UseVisualStyleBackColor = true;
            this.radioButtonAACBitrate.CheckedChanged += new System.EventHandler(this.radioButtonAACBitrate_CheckedChanged);
            // 
            // radioButtonAACQuality
            // 
            this.radioButtonAACQuality.AutoSize = true;
            this.radioButtonAACQuality.Checked = true;
            this.radioButtonAACQuality.Location = new System.Drawing.Point(58, 19);
            this.radioButtonAACQuality.Name = "radioButtonAACQuality";
            this.radioButtonAACQuality.Size = new System.Drawing.Size(57, 17);
            this.radioButtonAACQuality.TabIndex = 0;
            this.radioButtonAACQuality.TabStop = true;
            this.radioButtonAACQuality.Text = "Quality";
            this.radioButtonAACQuality.UseVisualStyleBackColor = true;
            this.radioButtonAACQuality.CheckedChanged += new System.EventHandler(this.radioButtonAACQuality_CheckedChanged);
            // 
            // groupBoxAACOptions
            // 
            this.groupBoxAACOptions.Controls.Add(this.checkBoxAACRTPHinttrack);
            this.groupBoxAACOptions.Controls.Add(this.labelAACProfile);
            this.groupBoxAACOptions.Controls.Add(this.comboBoxAACProfiles);
            this.groupBoxAACOptions.Location = new System.Drawing.Point(6, 259);
            this.groupBoxAACOptions.Name = "groupBoxAACOptions";
            this.groupBoxAACOptions.Size = new System.Drawing.Size(315, 85);
            this.groupBoxAACOptions.TabIndex = 3;
            this.groupBoxAACOptions.TabStop = false;
            this.groupBoxAACOptions.Text = "Options";
            // 
            // checkBoxAACRTPHinttrack
            // 
            this.checkBoxAACRTPHinttrack.AutoSize = true;
            this.checkBoxAACRTPHinttrack.Location = new System.Drawing.Point(14, 62);
            this.checkBoxAACRTPHinttrack.Name = "checkBoxAACRTPHinttrack";
            this.checkBoxAACRTPHinttrack.Size = new System.Drawing.Size(198, 17);
            this.checkBoxAACRTPHinttrack.TabIndex = 2;
            this.checkBoxAACRTPHinttrack.Text = "Generate RTP hint track (Streaming)";
            this.checkBoxAACRTPHinttrack.UseVisualStyleBackColor = true;
            // 
            // labelAACProfile
            // 
            this.labelAACProfile.AutoSize = true;
            this.labelAACProfile.Location = new System.Drawing.Point(11, 27);
            this.labelAACProfile.Name = "labelAACProfile";
            this.labelAACProfile.Size = new System.Drawing.Size(36, 13);
            this.labelAACProfile.TabIndex = 1;
            this.labelAACProfile.Text = "Profile";
            // 
            // comboBoxAACProfiles
            // 
            this.comboBoxAACProfiles.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxAACProfiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAACProfiles.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBoxAACProfiles.FormattingEnabled = true;
            this.comboBoxAACProfiles.Items.AddRange(new object[] {
            "Automatic",
            "LC",
            "HE",
            "HEV2"});
            this.comboBoxAACProfiles.Location = new System.Drawing.Point(58, 24);
            this.comboBoxAACProfiles.Name = "comboBoxAACProfiles";
            this.comboBoxAACProfiles.Size = new System.Drawing.Size(105, 21);
            this.comboBoxAACProfiles.TabIndex = 0;
            // 
            // groupBoxAACBitrate
            // 
            this.groupBoxAACBitrate.Controls.Add(this.checkBoxAACRestrictEncoder);
            this.groupBoxAACBitrate.Controls.Add(this.labelAACBitrate);
            this.groupBoxAACBitrate.Controls.Add(this.trackBarAACBitrate);
            this.groupBoxAACBitrate.Enabled = false;
            this.groupBoxAACBitrate.Location = new System.Drawing.Point(6, 153);
            this.groupBoxAACBitrate.Name = "groupBoxAACBitrate";
            this.groupBoxAACBitrate.Size = new System.Drawing.Size(316, 99);
            this.groupBoxAACBitrate.TabIndex = 2;
            this.groupBoxAACBitrate.TabStop = false;
            this.groupBoxAACBitrate.Text = "Bitrate";
            // 
            // checkBoxAACRestrictEncoder
            // 
            this.checkBoxAACRestrictEncoder.AutoSize = true;
            this.checkBoxAACRestrictEncoder.Location = new System.Drawing.Point(14, 76);
            this.checkBoxAACRestrictEncoder.Name = "checkBoxAACRestrictEncoder";
            this.checkBoxAACRestrictEncoder.Size = new System.Drawing.Size(251, 17);
            this.checkBoxAACRestrictEncoder.TabIndex = 2;
            this.checkBoxAACRestrictEncoder.Text = "Restrict Encoder to Constant Bitrate (Streaming)";
            this.checkBoxAACRestrictEncoder.UseVisualStyleBackColor = true;
            // 
            // labelAACBitrate
            // 
            this.labelAACBitrate.AutoSize = true;
            this.labelAACBitrate.Location = new System.Drawing.Point(11, 18);
            this.labelAACBitrate.Name = "labelAACBitrate";
            this.labelAACBitrate.Size = new System.Drawing.Size(298, 13);
            this.labelAACBitrate.TabIndex = 1;
            this.labelAACBitrate.Text = "8           64          128         192         256         320             400";
            // 
            // trackBarAACBitrate
            // 
            this.trackBarAACBitrate.BackColor = System.Drawing.Color.White;
            this.trackBarAACBitrate.LargeChange = 1;
            this.trackBarAACBitrate.Location = new System.Drawing.Point(6, 34);
            this.trackBarAACBitrate.Maximum = 50;
            this.trackBarAACBitrate.Minimum = 1;
            this.trackBarAACBitrate.Name = "trackBarAACBitrate";
            this.trackBarAACBitrate.Size = new System.Drawing.Size(303, 45);
            this.trackBarAACBitrate.TabIndex = 0;
            this.trackBarAACBitrate.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBarAACBitrate.Value = 24;
            this.trackBarAACBitrate.Scroll += new System.EventHandler(this.trackBarAACBitrate_Tooltip);
            this.trackBarAACBitrate.MouseHover += new System.EventHandler(this.trackBarAACBitrate_Tooltip);
            // 
            // groupBoxAACQuality
            // 
            this.groupBoxAACQuality.Controls.Add(this.labelAACQuality);
            this.groupBoxAACQuality.Controls.Add(this.trackBarAACQuality);
            this.groupBoxAACQuality.Location = new System.Drawing.Point(6, 62);
            this.groupBoxAACQuality.Name = "groupBoxAACQuality";
            this.groupBoxAACQuality.Size = new System.Drawing.Size(316, 85);
            this.groupBoxAACQuality.TabIndex = 1;
            this.groupBoxAACQuality.TabStop = false;
            this.groupBoxAACQuality.Text = "Quality";
            // 
            // labelAACQuality
            // 
            this.labelAACQuality.AutoSize = true;
            this.labelAACQuality.Location = new System.Drawing.Point(14, 17);
            this.labelAACQuality.Name = "labelAACQuality";
            this.labelAACQuality.Size = new System.Drawing.Size(289, 13);
            this.labelAACQuality.TabIndex = 1;
            this.labelAACQuality.Text = "0                                           0.5                                  " +
                "        1";
            // 
            // trackBarAACQuality
            // 
            this.trackBarAACQuality.BackColor = System.Drawing.Color.White;
            this.trackBarAACQuality.LargeChange = 1;
            this.trackBarAACQuality.Location = new System.Drawing.Point(6, 33);
            this.trackBarAACQuality.Maximum = 100;
            this.trackBarAACQuality.Name = "trackBarAACQuality";
            this.trackBarAACQuality.Size = new System.Drawing.Size(304, 45);
            this.trackBarAACQuality.TabIndex = 0;
            this.trackBarAACQuality.TickFrequency = 10;
            this.trackBarAACQuality.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBarAACQuality.Value = 50;
            this.trackBarAACQuality.Scroll += new System.EventHandler(this.trackBarAACQuality_Tooltip);
            this.trackBarAACQuality.MouseHover += new System.EventHandler(this.trackBarAACQuality_Tooltip);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBoxAC3DynamicRangeDialogNormalization);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBoxAC3ExponentStrategySearchSize);
            this.tabPage2.Controls.Add(this.linkLabelAC3);
            this.tabPage2.Controls.Add(this.groupBoxAC3Bitrate);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(328, 379);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "AC3";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBoxAC3DynamicRangeDialogNormalization
            // 
            this.groupBoxAC3DynamicRangeDialogNormalization.Controls.Add(this.comboBoxAC3DialogNormalization);
            this.groupBoxAC3DynamicRangeDialogNormalization.Controls.Add(this.labelAC3DialogNormalization);
            this.groupBoxAC3DynamicRangeDialogNormalization.Controls.Add(this.comboBoxAC3DynamicRange);
            this.groupBoxAC3DynamicRangeDialogNormalization.Controls.Add(this.labelAC3DynamicRange);
            this.groupBoxAC3DynamicRangeDialogNormalization.Location = new System.Drawing.Point(6, 277);
            this.groupBoxAC3DynamicRangeDialogNormalization.Name = "groupBoxAC3DynamicRangeDialogNormalization";
            this.groupBoxAC3DynamicRangeDialogNormalization.Size = new System.Drawing.Size(316, 75);
            this.groupBoxAC3DynamicRangeDialogNormalization.TabIndex = 11;
            this.groupBoxAC3DynamicRangeDialogNormalization.TabStop = false;
            this.groupBoxAC3DynamicRangeDialogNormalization.Text = "Dynamic Range Compression and Dialog normalization";
            // 
            // comboBoxAC3DialogNormalization
            // 
            this.comboBoxAC3DialogNormalization.DropDownHeight = 67;
            this.comboBoxAC3DialogNormalization.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAC3DialogNormalization.FormattingEnabled = true;
            this.comboBoxAC3DialogNormalization.IntegralHeight = false;
            this.comboBoxAC3DialogNormalization.Location = new System.Drawing.Point(198, 42);
            this.comboBoxAC3DialogNormalization.MaxDropDownItems = 5;
            this.comboBoxAC3DialogNormalization.Name = "comboBoxAC3DialogNormalization";
            this.comboBoxAC3DialogNormalization.Size = new System.Drawing.Size(102, 21);
            this.comboBoxAC3DialogNormalization.TabIndex = 3;
            // 
            // labelAC3DialogNormalization
            // 
            this.labelAC3DialogNormalization.AutoSize = true;
            this.labelAC3DialogNormalization.Location = new System.Drawing.Point(15, 45);
            this.labelAC3DialogNormalization.Name = "labelAC3DialogNormalization";
            this.labelAC3DialogNormalization.Size = new System.Drawing.Size(101, 13);
            this.labelAC3DialogNormalization.TabIndex = 2;
            this.labelAC3DialogNormalization.Text = "Dialog normalization";
            this.toolTipInfo.SetToolTip(this.labelAC3DialogNormalization, resources.GetString("labelAC3DialogNormalization.ToolTip"));
            // 
            // comboBoxAC3DynamicRange
            // 
            this.comboBoxAC3DynamicRange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAC3DynamicRange.FormattingEnabled = true;
            this.comboBoxAC3DynamicRange.Items.AddRange(new object[] {
            "Film Light",
            "Film Standard",
            "Music Light",
            "Music Standard",
            "Speech",
            "None (default)"});
            this.comboBoxAC3DynamicRange.Location = new System.Drawing.Point(198, 17);
            this.comboBoxAC3DynamicRange.Name = "comboBoxAC3DynamicRange";
            this.comboBoxAC3DynamicRange.Size = new System.Drawing.Size(102, 21);
            this.comboBoxAC3DynamicRange.TabIndex = 1;
            // 
            // labelAC3DynamicRange
            // 
            this.labelAC3DynamicRange.AutoSize = true;
            this.labelAC3DynamicRange.Location = new System.Drawing.Point(15, 20);
            this.labelAC3DynamicRange.Name = "labelAC3DynamicRange";
            this.labelAC3DynamicRange.Size = new System.Drawing.Size(177, 13);
            this.labelAC3DynamicRange.TabIndex = 0;
            this.labelAC3DynamicRange.Text = "Dynamic Range Compression profile";
            this.toolTipInfo.SetToolTip(this.labelAC3DynamicRange, resources.GetString("labelAC3DynamicRange.ToolTip"));
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBoxAC3BitstreamInfoDolbySurround);
            this.groupBox3.Controls.Add(this.labelAC3BitstreamInfoDolbySurround);
            this.groupBox3.Controls.Add(this.comboBoxAC3BitsreamInfoSurroundmix);
            this.groupBox3.Controls.Add(this.labelAC3BitsreamInfoSurroundmix);
            this.groupBox3.Controls.Add(this.comboBoxAC3BitsreamInfoCentermix);
            this.groupBox3.Controls.Add(this.labelAC3BitsreamInfoCentermix);
            this.groupBox3.Location = new System.Drawing.Point(6, 174);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(316, 100);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bitstream info metadata";
            // 
            // comboBoxAC3BitstreamInfoDolbySurround
            // 
            this.comboBoxAC3BitstreamInfoDolbySurround.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAC3BitstreamInfoDolbySurround.FormattingEnabled = true;
            this.comboBoxAC3BitstreamInfoDolbySurround.Items.AddRange(new object[] {
            "Not indicated (default)",
            "Not Dolby Surround encoded",
            "Dolby Surround encoded"});
            this.comboBoxAC3BitstreamInfoDolbySurround.Location = new System.Drawing.Point(135, 67);
            this.comboBoxAC3BitstreamInfoDolbySurround.Name = "comboBoxAC3BitstreamInfoDolbySurround";
            this.comboBoxAC3BitstreamInfoDolbySurround.Size = new System.Drawing.Size(165, 21);
            this.comboBoxAC3BitstreamInfoDolbySurround.TabIndex = 5;
            // 
            // labelAC3BitstreamInfoDolbySurround
            // 
            this.labelAC3BitstreamInfoDolbySurround.AutoSize = true;
            this.labelAC3BitstreamInfoDolbySurround.Location = new System.Drawing.Point(15, 70);
            this.labelAC3BitstreamInfoDolbySurround.Name = "labelAC3BitstreamInfoDolbySurround";
            this.labelAC3BitstreamInfoDolbySurround.Size = new System.Drawing.Size(109, 13);
            this.labelAC3BitstreamInfoDolbySurround.TabIndex = 4;
            this.labelAC3BitstreamInfoDolbySurround.Text = "Dolby Surround mode";
            this.toolTipInfo.SetToolTip(this.labelAC3BitstreamInfoDolbySurround, "If surround channels are in use, this code indicates\r\nthe nominal down mix level " +
                    "of the surround channels.\r\n(Source: \"aften.exe --longhelp\")");
            // 
            // comboBoxAC3BitsreamInfoSurroundmix
            // 
            this.comboBoxAC3BitsreamInfoSurroundmix.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAC3BitsreamInfoSurroundmix.FormattingEnabled = true;
            this.comboBoxAC3BitsreamInfoSurroundmix.Items.AddRange(new object[] {
            "-3.0 dB (default)",
            "-6.0 dB",
            "0"});
            this.comboBoxAC3BitsreamInfoSurroundmix.Location = new System.Drawing.Point(190, 42);
            this.comboBoxAC3BitsreamInfoSurroundmix.Name = "comboBoxAC3BitsreamInfoSurroundmix";
            this.comboBoxAC3BitsreamInfoSurroundmix.Size = new System.Drawing.Size(110, 21);
            this.comboBoxAC3BitsreamInfoSurroundmix.TabIndex = 3;
            // 
            // labelAC3BitsreamInfoSurroundmix
            // 
            this.labelAC3BitsreamInfoSurroundmix.AutoSize = true;
            this.labelAC3BitsreamInfoSurroundmix.Location = new System.Drawing.Point(15, 45);
            this.labelAC3BitsreamInfoSurroundmix.Name = "labelAC3BitsreamInfoSurroundmix";
            this.labelAC3BitsreamInfoSurroundmix.Size = new System.Drawing.Size(93, 13);
            this.labelAC3BitsreamInfoSurroundmix.TabIndex = 2;
            this.labelAC3BitsreamInfoSurroundmix.Text = "Surround mix level";
            this.toolTipInfo.SetToolTip(this.labelAC3BitsreamInfoSurroundmix, "If surround channels are in use, this code indicates\r\nthe nominal down mix level " +
                    "of the surround channels.\r\n(Source: \"aften.exe --longhelp\")");
            // 
            // comboBoxAC3BitsreamInfoCentermix
            // 
            this.comboBoxAC3BitsreamInfoCentermix.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAC3BitsreamInfoCentermix.FormattingEnabled = true;
            this.comboBoxAC3BitsreamInfoCentermix.Items.AddRange(new object[] {
            "-3.0 dB (default)",
            "-4.5 dB",
            "-6.0 dB"});
            this.comboBoxAC3BitsreamInfoCentermix.Location = new System.Drawing.Point(190, 17);
            this.comboBoxAC3BitsreamInfoCentermix.Name = "comboBoxAC3BitsreamInfoCentermix";
            this.comboBoxAC3BitsreamInfoCentermix.Size = new System.Drawing.Size(110, 21);
            this.comboBoxAC3BitsreamInfoCentermix.TabIndex = 1;
            // 
            // labelAC3BitsreamInfoCentermix
            // 
            this.labelAC3BitsreamInfoCentermix.AutoSize = true;
            this.labelAC3BitsreamInfoCentermix.Location = new System.Drawing.Point(15, 20);
            this.labelAC3BitsreamInfoCentermix.Name = "labelAC3BitsreamInfoCentermix";
            this.labelAC3BitsreamInfoCentermix.Size = new System.Drawing.Size(81, 13);
            this.labelAC3BitsreamInfoCentermix.TabIndex = 0;
            this.labelAC3BitsreamInfoCentermix.Text = "Center mix level";
            this.toolTipInfo.SetToolTip(this.labelAC3BitsreamInfoCentermix, "When three front channels are in use, this code\r\nindicates the nominal down mix l" +
                    "evel of the center\r\nchannel with respect to the left and right channels.\r\n(Sourc" +
                    "e: \"aften.exe --longhelp\")");
            // 
            // groupBoxAC3ExponentStrategySearchSize
            // 
            this.groupBoxAC3ExponentStrategySearchSize.Controls.Add(this.labelAC3ExponentStrategySearchSize);
            this.groupBoxAC3ExponentStrategySearchSize.Controls.Add(this.trackBarAC3ExponentStrategySearchSize);
            this.groupBoxAC3ExponentStrategySearchSize.Location = new System.Drawing.Point(6, 91);
            this.groupBoxAC3ExponentStrategySearchSize.Name = "groupBoxAC3ExponentStrategySearchSize";
            this.groupBoxAC3ExponentStrategySearchSize.Size = new System.Drawing.Size(316, 80);
            this.groupBoxAC3ExponentStrategySearchSize.TabIndex = 9;
            this.groupBoxAC3ExponentStrategySearchSize.TabStop = false;
            this.groupBoxAC3ExponentStrategySearchSize.Text = "Exponent strategy search size";
            this.toolTipInfo.SetToolTip(this.groupBoxAC3ExponentStrategySearchSize, resources.GetString("groupBoxAC3ExponentStrategySearchSize.ToolTip"));
            // 
            // labelAC3ExponentStrategySearchSize
            // 
            this.labelAC3ExponentStrategySearchSize.AutoSize = true;
            this.labelAC3ExponentStrategySearchSize.Location = new System.Drawing.Point(11, 18);
            this.labelAC3ExponentStrategySearchSize.Name = "labelAC3ExponentStrategySearchSize";
            this.labelAC3ExponentStrategySearchSize.Size = new System.Drawing.Size(295, 13);
            this.labelAC3ExponentStrategySearchSize.TabIndex = 3;
            this.labelAC3ExponentStrategySearchSize.Text = "1                    8                    16                    24               " +
                "     32";
            // 
            // trackBarAC3ExponentStrategySearchSize
            // 
            this.trackBarAC3ExponentStrategySearchSize.BackColor = System.Drawing.Color.White;
            this.trackBarAC3ExponentStrategySearchSize.LargeChange = 1;
            this.trackBarAC3ExponentStrategySearchSize.Location = new System.Drawing.Point(6, 32);
            this.trackBarAC3ExponentStrategySearchSize.Maximum = 32;
            this.trackBarAC3ExponentStrategySearchSize.Minimum = 1;
            this.trackBarAC3ExponentStrategySearchSize.Name = "trackBarAC3ExponentStrategySearchSize";
            this.trackBarAC3ExponentStrategySearchSize.Size = new System.Drawing.Size(303, 45);
            this.trackBarAC3ExponentStrategySearchSize.TabIndex = 2;
            this.trackBarAC3ExponentStrategySearchSize.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBarAC3ExponentStrategySearchSize.Value = 8;
            this.trackBarAC3ExponentStrategySearchSize.Scroll += new System.EventHandler(this.trackBarAC3ExponentStrategySearchSize_Tooltip);
            this.trackBarAC3ExponentStrategySearchSize.MouseHover += new System.EventHandler(this.trackBarAC3ExponentStrategySearchSize_Tooltip);
            // 
            // linkLabelAC3
            // 
            this.linkLabelAC3.AutoSize = true;
            this.linkLabelAC3.Location = new System.Drawing.Point(6, 355);
            this.linkLabelAC3.Name = "linkLabelAC3";
            this.linkLabelAC3.Size = new System.Drawing.Size(144, 13);
            this.linkLabelAC3.TabIndex = 8;
            this.linkLabelAC3.TabStop = true;
            this.linkLabelAC3.Text = "http://aften.sourceforge.net/";
            this.linkLabelAC3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelAC3_LinkClicked);
            // 
            // groupBoxAC3Bitrate
            // 
            this.groupBoxAC3Bitrate.Controls.Add(this.labelAC3Bitrate);
            this.groupBoxAC3Bitrate.Controls.Add(this.trackBarAC3Bitrate);
            this.groupBoxAC3Bitrate.Location = new System.Drawing.Point(6, 8);
            this.groupBoxAC3Bitrate.Name = "groupBoxAC3Bitrate";
            this.groupBoxAC3Bitrate.Size = new System.Drawing.Size(316, 80);
            this.groupBoxAC3Bitrate.TabIndex = 6;
            this.groupBoxAC3Bitrate.TabStop = false;
            this.groupBoxAC3Bitrate.Text = "Bitrate";
            // 
            // labelAC3Bitrate
            // 
            this.labelAC3Bitrate.AutoSize = true;
            this.labelAC3Bitrate.Location = new System.Drawing.Point(11, 18);
            this.labelAC3Bitrate.Name = "labelAC3Bitrate";
            this.labelAC3Bitrate.Size = new System.Drawing.Size(295, 13);
            this.labelAC3Bitrate.TabIndex = 1;
            this.labelAC3Bitrate.Text = "32              160                  320                  480                  64" +
                "0";
            // 
            // trackBarAC3Bitrate
            // 
            this.trackBarAC3Bitrate.BackColor = System.Drawing.Color.White;
            this.trackBarAC3Bitrate.LargeChange = 1;
            this.trackBarAC3Bitrate.Location = new System.Drawing.Point(6, 32);
            this.trackBarAC3Bitrate.Maximum = 20;
            this.trackBarAC3Bitrate.Minimum = 1;
            this.trackBarAC3Bitrate.Name = "trackBarAC3Bitrate";
            this.trackBarAC3Bitrate.Size = new System.Drawing.Size(303, 45);
            this.trackBarAC3Bitrate.TabIndex = 0;
            this.trackBarAC3Bitrate.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBarAC3Bitrate.Value = 10;
            this.trackBarAC3Bitrate.Scroll += new System.EventHandler(this.trackBarAC3Bitrate_Tooltip);
            this.trackBarAC3Bitrate.MouseHover += new System.EventHandler(this.trackBarAC3Bitrate_Tooltip);
            // 
            // tabPage11
            // 
            this.tabPage11.Controls.Add(this.groupBoxDTSBitrate);
            this.tabPage11.Controls.Add(this.linkLabelDTS);
            this.tabPage11.Location = new System.Drawing.Point(4, 22);
            this.tabPage11.Name = "tabPage11";
            this.tabPage11.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage11.Size = new System.Drawing.Size(328, 379);
            this.tabPage11.TabIndex = 5;
            this.tabPage11.Text = "DTS";
            this.tabPage11.UseVisualStyleBackColor = true;
            // 
            // groupBoxDTSBitrate
            // 
            this.groupBoxDTSBitrate.Controls.Add(this.radioButtonDTSBitrate150975);
            this.groupBoxDTSBitrate.Controls.Add(this.radioButtonDTSBitrate7545);
            this.groupBoxDTSBitrate.Location = new System.Drawing.Point(6, 6);
            this.groupBoxDTSBitrate.Name = "groupBoxDTSBitrate";
            this.groupBoxDTSBitrate.Size = new System.Drawing.Size(316, 50);
            this.groupBoxDTSBitrate.TabIndex = 7;
            this.groupBoxDTSBitrate.TabStop = false;
            this.groupBoxDTSBitrate.Text = "Bitrate";
            // 
            // radioButtonDTSBitrate150975
            // 
            this.radioButtonDTSBitrate150975.AutoSize = true;
            this.radioButtonDTSBitrate150975.Location = new System.Drawing.Point(171, 19);
            this.radioButtonDTSBitrate150975.Name = "radioButtonDTSBitrate150975";
            this.radioButtonDTSBitrate150975.Size = new System.Drawing.Size(96, 17);
            this.radioButtonDTSBitrate150975.TabIndex = 3;
            this.radioButtonDTSBitrate150975.Text = "1\'509.75 kbit/s";
            this.radioButtonDTSBitrate150975.UseVisualStyleBackColor = true;
            // 
            // radioButtonDTSBitrate7545
            // 
            this.radioButtonDTSBitrate7545.AutoSize = true;
            this.radioButtonDTSBitrate7545.Checked = true;
            this.radioButtonDTSBitrate7545.Location = new System.Drawing.Point(52, 19);
            this.radioButtonDTSBitrate7545.Name = "radioButtonDTSBitrate7545";
            this.radioButtonDTSBitrate7545.Size = new System.Drawing.Size(82, 17);
            this.radioButtonDTSBitrate7545.TabIndex = 2;
            this.radioButtonDTSBitrate7545.TabStop = true;
            this.radioButtonDTSBitrate7545.Text = "754.5 kbit/s";
            this.radioButtonDTSBitrate7545.UseVisualStyleBackColor = true;
            // 
            // linkLabelDTS
            // 
            this.linkLabelDTS.AutoSize = true;
            this.linkLabelDTS.Location = new System.Drawing.Point(6, 355);
            this.linkLabelDTS.Name = "linkLabelDTS";
            this.linkLabelDTS.Size = new System.Drawing.Size(180, 13);
            this.linkLabelDTS.TabIndex = 6;
            this.linkLabelDTS.TabStop = true;
            this.linkLabelDTS.Text = "http://aepatrakov.narod.ru/dcaenc/";
            this.linkLabelDTS.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelDTS_LinkClicked);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.linkLabelFLAC);
            this.tabPage4.Controls.Add(this.groupBoxFLACCompression);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(328, 379);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "FLAC";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // linkLabelFLAC
            // 
            this.linkLabelFLAC.AutoSize = true;
            this.linkLabelFLAC.Location = new System.Drawing.Point(6, 355);
            this.linkLabelFLAC.Name = "linkLabelFLAC";
            this.linkLabelFLAC.Size = new System.Drawing.Size(137, 13);
            this.linkLabelFLAC.TabIndex = 10;
            this.linkLabelFLAC.TabStop = true;
            this.linkLabelFLAC.Text = "http://flac.sourceforge.net/";
            this.linkLabelFLAC.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelFLAC_LinkClicked);
            // 
            // groupBoxFLACCompression
            // 
            this.groupBoxFLACCompression.Controls.Add(this.label2);
            this.groupBoxFLACCompression.Controls.Add(this.labelFLACCompression);
            this.groupBoxFLACCompression.Controls.Add(this.trackBarFLACCompression);
            this.groupBoxFLACCompression.Location = new System.Drawing.Point(6, 6);
            this.groupBoxFLACCompression.Name = "groupBoxFLACCompression";
            this.groupBoxFLACCompression.Size = new System.Drawing.Size(316, 85);
            this.groupBoxFLACCompression.TabIndex = 0;
            this.groupBoxFLACCompression.TabStop = false;
            this.groupBoxFLACCompression.Text = "Compression Level";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 4;
            // 
            // labelFLACCompression
            // 
            this.labelFLACCompression.AutoSize = true;
            this.labelFLACCompression.Location = new System.Drawing.Point(7, 17);
            this.labelFLACCompression.Name = "labelFLACCompression";
            this.labelFLACCompression.Size = new System.Drawing.Size(305, 13);
            this.labelFLACCompression.TabIndex = 3;
            this.labelFLACCompression.Text = "Fastest                                                                          " +
                "       Best";
            // 
            // trackBarFLACCompression
            // 
            this.trackBarFLACCompression.BackColor = System.Drawing.Color.White;
            this.trackBarFLACCompression.LargeChange = 1;
            this.trackBarFLACCompression.Location = new System.Drawing.Point(6, 34);
            this.trackBarFLACCompression.Maximum = 8;
            this.trackBarFLACCompression.Name = "trackBarFLACCompression";
            this.trackBarFLACCompression.Size = new System.Drawing.Size(304, 45);
            this.trackBarFLACCompression.TabIndex = 2;
            this.trackBarFLACCompression.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBarFLACCompression.Value = 5;
            this.trackBarFLACCompression.Scroll += new System.EventHandler(this.trackBarFLACCompression_Tooltip);
            this.trackBarFLACCompression.MouseHover += new System.EventHandler(this.trackBarFLACCompression_Tooltip);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.linkLabelMP3);
            this.tabPage3.Controls.Add(this.groupBoxMP3Options);
            this.tabPage3.Controls.Add(this.groupBoxMP3Bitrate);
            this.tabPage3.Controls.Add(this.groupBoxMP3Quality);
            this.tabPage3.Controls.Add(this.groupBoxMP3Target);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(328, 379);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "MP3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // linkLabelMP3
            // 
            this.linkLabelMP3.AutoSize = true;
            this.linkLabelMP3.Location = new System.Drawing.Point(6, 355);
            this.linkLabelMP3.Name = "linkLabelMP3";
            this.linkLabelMP3.Size = new System.Drawing.Size(142, 13);
            this.linkLabelMP3.TabIndex = 9;
            this.linkLabelMP3.TabStop = true;
            this.linkLabelMP3.Text = "http://lame.sourceforge.net/";
            this.linkLabelMP3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelMP3_LinkClicked);
            // 
            // groupBoxMP3Options
            // 
            this.groupBoxMP3Options.Controls.Add(this.checkBoxMP3OptionsErrorProtection);
            this.groupBoxMP3Options.Controls.Add(this.labelMP3OptionsChannelModes);
            this.groupBoxMP3Options.Controls.Add(this.comboBoxMP3OptionsChannelModes);
            this.groupBoxMP3Options.Location = new System.Drawing.Point(7, 258);
            this.groupBoxMP3Options.Name = "groupBoxMP3Options";
            this.groupBoxMP3Options.Size = new System.Drawing.Size(315, 88);
            this.groupBoxMP3Options.TabIndex = 8;
            this.groupBoxMP3Options.TabStop = false;
            this.groupBoxMP3Options.Text = "Options";
            // 
            // checkBoxMP3OptionsErrorProtection
            // 
            this.checkBoxMP3OptionsErrorProtection.AutoSize = true;
            this.checkBoxMP3OptionsErrorProtection.Location = new System.Drawing.Point(14, 53);
            this.checkBoxMP3OptionsErrorProtection.Name = "checkBoxMP3OptionsErrorProtection";
            this.checkBoxMP3OptionsErrorProtection.Size = new System.Drawing.Size(197, 17);
            this.checkBoxMP3OptionsErrorProtection.TabIndex = 2;
            this.checkBoxMP3OptionsErrorProtection.Text = "Activate Error Protection (Streaming)";
            this.checkBoxMP3OptionsErrorProtection.UseVisualStyleBackColor = true;
            // 
            // labelMP3OptionsChannelModes
            // 
            this.labelMP3OptionsChannelModes.AutoSize = true;
            this.labelMP3OptionsChannelModes.Location = new System.Drawing.Point(11, 25);
            this.labelMP3OptionsChannelModes.Name = "labelMP3OptionsChannelModes";
            this.labelMP3OptionsChannelModes.Size = new System.Drawing.Size(80, 13);
            this.labelMP3OptionsChannelModes.TabIndex = 1;
            this.labelMP3OptionsChannelModes.Text = "Channel modes";
            // 
            // comboBoxMP3OptionsChannelModes
            // 
            this.comboBoxMP3OptionsChannelModes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMP3OptionsChannelModes.FormattingEnabled = true;
            this.comboBoxMP3OptionsChannelModes.Items.AddRange(new object[] {
            "Mono",
            "Forced L/R Stereo",
            "Joint Stereo",
            "Forced Mid/Side Stereo",
            "Dual Channel"});
            this.comboBoxMP3OptionsChannelModes.Location = new System.Drawing.Point(157, 22);
            this.comboBoxMP3OptionsChannelModes.Name = "comboBoxMP3OptionsChannelModes";
            this.comboBoxMP3OptionsChannelModes.Size = new System.Drawing.Size(140, 21);
            this.comboBoxMP3OptionsChannelModes.TabIndex = 0;
            this.toolTipInfo.SetToolTip(this.comboBoxMP3OptionsChannelModes, resources.GetString("comboBoxMP3OptionsChannelModes.ToolTip"));
            // 
            // groupBoxMP3Bitrate
            // 
            this.groupBoxMP3Bitrate.Controls.Add(this.checkBoxMP3RestrictEncoder);
            this.groupBoxMP3Bitrate.Controls.Add(this.labelMP3Bitrate);
            this.groupBoxMP3Bitrate.Controls.Add(this.trackBarMP3Bitrate);
            this.groupBoxMP3Bitrate.Enabled = false;
            this.groupBoxMP3Bitrate.Location = new System.Drawing.Point(7, 153);
            this.groupBoxMP3Bitrate.Name = "groupBoxMP3Bitrate";
            this.groupBoxMP3Bitrate.Size = new System.Drawing.Size(315, 99);
            this.groupBoxMP3Bitrate.TabIndex = 7;
            this.groupBoxMP3Bitrate.TabStop = false;
            this.groupBoxMP3Bitrate.Text = "Bitrate";
            // 
            // checkBoxMP3RestrictEncoder
            // 
            this.checkBoxMP3RestrictEncoder.AutoSize = true;
            this.checkBoxMP3RestrictEncoder.Location = new System.Drawing.Point(14, 76);
            this.checkBoxMP3RestrictEncoder.Name = "checkBoxMP3RestrictEncoder";
            this.checkBoxMP3RestrictEncoder.Size = new System.Drawing.Size(195, 17);
            this.checkBoxMP3RestrictEncoder.TabIndex = 2;
            this.checkBoxMP3RestrictEncoder.Text = "Restrict Encoder to Constant Bitrate";
            this.checkBoxMP3RestrictEncoder.UseVisualStyleBackColor = true;
            // 
            // labelMP3Bitrate
            // 
            this.labelMP3Bitrate.AutoSize = true;
            this.labelMP3Bitrate.Location = new System.Drawing.Point(11, 18);
            this.labelMP3Bitrate.Name = "labelMP3Bitrate";
            this.labelMP3Bitrate.Size = new System.Drawing.Size(298, 13);
            this.labelMP3Bitrate.TabIndex = 1;
            this.labelMP3Bitrate.Text = "8               64             128             192             256             32" +
                "0";
            // 
            // trackBarMP3Bitrate
            // 
            this.trackBarMP3Bitrate.BackColor = System.Drawing.Color.White;
            this.trackBarMP3Bitrate.LargeChange = 1;
            this.trackBarMP3Bitrate.Location = new System.Drawing.Point(6, 34);
            this.trackBarMP3Bitrate.Maximum = 40;
            this.trackBarMP3Bitrate.Minimum = 1;
            this.trackBarMP3Bitrate.Name = "trackBarMP3Bitrate";
            this.trackBarMP3Bitrate.Size = new System.Drawing.Size(303, 45);
            this.trackBarMP3Bitrate.TabIndex = 0;
            this.trackBarMP3Bitrate.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBarMP3Bitrate.Value = 32;
            this.trackBarMP3Bitrate.Scroll += new System.EventHandler(this.trackBarMP3Bitrate_Tooltip);
            this.trackBarMP3Bitrate.MouseHover += new System.EventHandler(this.trackBarMP3Bitrate_Tooltip);
            // 
            // groupBoxMP3Quality
            // 
            this.groupBoxMP3Quality.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxMP3Quality.Controls.Add(this.labelMP3Quality);
            this.groupBoxMP3Quality.Controls.Add(this.trackBarMP3Quality);
            this.groupBoxMP3Quality.Location = new System.Drawing.Point(6, 62);
            this.groupBoxMP3Quality.Name = "groupBoxMP3Quality";
            this.groupBoxMP3Quality.Size = new System.Drawing.Size(316, 85);
            this.groupBoxMP3Quality.TabIndex = 6;
            this.groupBoxMP3Quality.TabStop = false;
            this.groupBoxMP3Quality.Text = "Quality";
            // 
            // labelMP3Quality
            // 
            this.labelMP3Quality.AutoSize = true;
            this.labelMP3Quality.Location = new System.Drawing.Point(13, 17);
            this.labelMP3Quality.Name = "labelMP3Quality";
            this.labelMP3Quality.Size = new System.Drawing.Size(292, 13);
            this.labelMP3Quality.TabIndex = 1;
            this.labelMP3Quality.Text = "1                                                                                " +
                "         10";
            // 
            // trackBarMP3Quality
            // 
            this.trackBarMP3Quality.BackColor = System.Drawing.Color.White;
            this.trackBarMP3Quality.LargeChange = 1;
            this.trackBarMP3Quality.Location = new System.Drawing.Point(6, 34);
            this.trackBarMP3Quality.Minimum = 1;
            this.trackBarMP3Quality.Name = "trackBarMP3Quality";
            this.trackBarMP3Quality.Size = new System.Drawing.Size(304, 45);
            this.trackBarMP3Quality.TabIndex = 0;
            this.trackBarMP3Quality.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBarMP3Quality.Value = 5;
            this.trackBarMP3Quality.Scroll += new System.EventHandler(this.trackBarMP3Quality_Tooltip);
            this.trackBarMP3Quality.MouseHover += new System.EventHandler(this.trackBarMP3Quality_Tooltip);
            // 
            // groupBoxMP3Target
            // 
            this.groupBoxMP3Target.Controls.Add(this.radioButtonMP3Bitrate);
            this.groupBoxMP3Target.Controls.Add(this.radioButtonMP3Quality);
            this.groupBoxMP3Target.Location = new System.Drawing.Point(6, 6);
            this.groupBoxMP3Target.Name = "groupBoxMP3Target";
            this.groupBoxMP3Target.Size = new System.Drawing.Size(316, 50);
            this.groupBoxMP3Target.TabIndex = 5;
            this.groupBoxMP3Target.TabStop = false;
            this.groupBoxMP3Target.Text = "Target";
            // 
            // radioButtonMP3Bitrate
            // 
            this.radioButtonMP3Bitrate.AutoSize = true;
            this.radioButtonMP3Bitrate.Location = new System.Drawing.Point(210, 19);
            this.radioButtonMP3Bitrate.Name = "radioButtonMP3Bitrate";
            this.radioButtonMP3Bitrate.Size = new System.Drawing.Size(55, 17);
            this.radioButtonMP3Bitrate.TabIndex = 1;
            this.radioButtonMP3Bitrate.Text = "Bitrate";
            this.radioButtonMP3Bitrate.UseVisualStyleBackColor = true;
            this.radioButtonMP3Bitrate.CheckedChanged += new System.EventHandler(this.radioButtonMP3Bitrate_CheckedChanged);
            // 
            // radioButtonMP3Quality
            // 
            this.radioButtonMP3Quality.AutoSize = true;
            this.radioButtonMP3Quality.Checked = true;
            this.radioButtonMP3Quality.Location = new System.Drawing.Point(58, 19);
            this.radioButtonMP3Quality.Name = "radioButtonMP3Quality";
            this.radioButtonMP3Quality.Size = new System.Drawing.Size(57, 17);
            this.radioButtonMP3Quality.TabIndex = 0;
            this.radioButtonMP3Quality.TabStop = true;
            this.radioButtonMP3Quality.Text = "Quality";
            this.radioButtonMP3Quality.UseVisualStyleBackColor = true;
            this.radioButtonMP3Quality.CheckedChanged += new System.EventHandler(this.radioButtonMP3Quality_CheckedChanged);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.groupBoxWAVOutputFormat);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(328, 379);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "WAV";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // groupBoxWAVOutputFormat
            // 
            this.groupBoxWAVOutputFormat.Controls.Add(this.radioButtonWAVOutputFormatAIFF);
            this.groupBoxWAVOutputFormat.Controls.Add(this.radioButtonWAVOutputFormatWAV);
            this.groupBoxWAVOutputFormat.Location = new System.Drawing.Point(6, 6);
            this.groupBoxWAVOutputFormat.Name = "groupBoxWAVOutputFormat";
            this.groupBoxWAVOutputFormat.Size = new System.Drawing.Size(316, 50);
            this.groupBoxWAVOutputFormat.TabIndex = 0;
            this.groupBoxWAVOutputFormat.TabStop = false;
            this.groupBoxWAVOutputFormat.Text = "Output Format";
            // 
            // radioButtonWAVOutputFormatAIFF
            // 
            this.radioButtonWAVOutputFormatAIFF.AutoSize = true;
            this.radioButtonWAVOutputFormatAIFF.Location = new System.Drawing.Point(210, 19);
            this.radioButtonWAVOutputFormatAIFF.Name = "radioButtonWAVOutputFormatAIFF";
            this.radioButtonWAVOutputFormatAIFF.Size = new System.Drawing.Size(47, 17);
            this.radioButtonWAVOutputFormatAIFF.TabIndex = 1;
            this.radioButtonWAVOutputFormatAIFF.Text = "AIFF";
            this.radioButtonWAVOutputFormatAIFF.UseVisualStyleBackColor = true;
            // 
            // radioButtonWAVOutputFormatWAV
            // 
            this.radioButtonWAVOutputFormatWAV.AutoSize = true;
            this.radioButtonWAVOutputFormatWAV.Checked = true;
            this.radioButtonWAVOutputFormatWAV.Location = new System.Drawing.Point(58, 19);
            this.radioButtonWAVOutputFormatWAV.Name = "radioButtonWAVOutputFormatWAV";
            this.radioButtonWAVOutputFormatWAV.Size = new System.Drawing.Size(50, 17);
            this.radioButtonWAVOutputFormatWAV.TabIndex = 0;
            this.radioButtonWAVOutputFormatWAV.TabStop = true;
            this.radioButtonWAVOutputFormatWAV.Text = "WAV";
            this.radioButtonWAVOutputFormatWAV.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 700);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(754, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(394, 236);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 430);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Target Format";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage6);
            this.tabControl2.Controls.Add(this.tabPage10);
            this.tabControl2.Controls.Add(this.tabPage8);
            this.tabControl2.Controls.Add(this.tabPage9);
            this.tabControl2.Controls.Add(this.tabPage7);
            this.tabControl2.Location = new System.Drawing.Point(7, 20);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(363, 263);
            this.tabControl2.TabIndex = 17;
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.Transparent;
            this.tabPage6.Controls.Add(this.groupBox2);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(355, 237);
            this.tabPage6.TabIndex = 0;
            this.tabPage6.Text = "Main";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelSoXSettingsMainBufferSize);
            this.groupBox2.Controls.Add(this.comboBoxSoXSettingsMainBufferSize);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(344, 61);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "General";
            this.toolTipInfo.SetToolTip(this.groupBox2, "Valid for every SoX instance");
            // 
            // labelSoXSettingsMainBufferSize
            // 
            this.labelSoXSettingsMainBufferSize.AutoSize = true;
            this.labelSoXSettingsMainBufferSize.Location = new System.Drawing.Point(15, 25);
            this.labelSoXSettingsMainBufferSize.Name = "labelSoXSettingsMainBufferSize";
            this.labelSoXSettingsMainBufferSize.Size = new System.Drawing.Size(91, 13);
            this.labelSoXSettingsMainBufferSize.TabIndex = 15;
            this.labelSoXSettingsMainBufferSize.Text = "Buffer size [Bytes]";
            // 
            // comboBoxSoXSettingsMainBufferSize
            // 
            this.comboBoxSoXSettingsMainBufferSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSoXSettingsMainBufferSize.FormattingEnabled = true;
            this.comboBoxSoXSettingsMainBufferSize.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBoxSoXSettingsMainBufferSize.Items.AddRange(new object[] {
            "1024",
            "2048",
            "4096",
            "8192",
            "16384",
            "32768"});
            this.comboBoxSoXSettingsMainBufferSize.Location = new System.Drawing.Point(190, 22);
            this.comboBoxSoXSettingsMainBufferSize.Name = "comboBoxSoXSettingsMainBufferSize";
            this.comboBoxSoXSettingsMainBufferSize.Size = new System.Drawing.Size(60, 21);
            this.comboBoxSoXSettingsMainBufferSize.TabIndex = 14;
            this.toolTipInfo.SetToolTip(this.comboBoxSoXSettingsMainBufferSize, "SoX Default: 8192");
            // 
            // tabPage10
            // 
            this.tabPage10.BackColor = System.Drawing.Color.Transparent;
            this.tabPage10.Controls.Add(this.groupBoxSoXSettingsMainPrepareStream);
            this.tabPage10.Location = new System.Drawing.Point(4, 22);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage10.Size = new System.Drawing.Size(355, 237);
            this.tabPage10.TabIndex = 4;
            this.tabPage10.Text = "Input";
            this.tabPage10.UseVisualStyleBackColor = true;
            // 
            // groupBoxSoXSettingsMainPrepareStream
            // 
            this.groupBoxSoXSettingsMainPrepareStream.Controls.Add(this.comboBoxSoXSettingsInputConvertEncodingType);
            this.groupBoxSoXSettingsMainPrepareStream.Controls.Add(this.checkBoxSoXSettingsInputConvertEncodingType);
            this.groupBoxSoXSettingsMainPrepareStream.Controls.Add(this.comboBoxSoXSettingsInputConvertSamplingRate);
            this.groupBoxSoXSettingsMainPrepareStream.Controls.Add(this.checkBoxSoXSettingsInputConvertSamplingRate);
            this.groupBoxSoXSettingsMainPrepareStream.Controls.Add(this.checkBoxSoXSettingsInputConvertAudioResolution);
            this.groupBoxSoXSettingsMainPrepareStream.Controls.Add(this.comboBoxSoXSettingsInputConvertAudioResolution);
            this.groupBoxSoXSettingsMainPrepareStream.Location = new System.Drawing.Point(6, 6);
            this.groupBoxSoXSettingsMainPrepareStream.Name = "groupBoxSoXSettingsMainPrepareStream";
            this.groupBoxSoXSettingsMainPrepareStream.Size = new System.Drawing.Size(344, 105);
            this.groupBoxSoXSettingsMainPrepareStream.TabIndex = 18;
            this.groupBoxSoXSettingsMainPrepareStream.TabStop = false;
            this.groupBoxSoXSettingsMainPrepareStream.Text = "Prepare stream before editing";
            // 
            // comboBoxSoXSettingsInputConvertEncodingType
            // 
            this.comboBoxSoXSettingsInputConvertEncodingType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSoXSettingsInputConvertEncodingType.Enabled = false;
            this.comboBoxSoXSettingsInputConvertEncodingType.FormattingEnabled = true;
            this.comboBoxSoXSettingsInputConvertEncodingType.Items.AddRange(new object[] {
            "Signed Integer",
            "Unsigned Integer",
            "Floating Point"});
            this.comboBoxSoXSettingsInputConvertEncodingType.Location = new System.Drawing.Point(190, 48);
            this.comboBoxSoXSettingsInputConvertEncodingType.Name = "comboBoxSoXSettingsInputConvertEncodingType";
            this.comboBoxSoXSettingsInputConvertEncodingType.Size = new System.Drawing.Size(110, 21);
            this.comboBoxSoXSettingsInputConvertEncodingType.TabIndex = 16;
            // 
            // checkBoxSoXSettingsInputConvertEncodingType
            // 
            this.checkBoxSoXSettingsInputConvertEncodingType.AutoSize = true;
            this.checkBoxSoXSettingsInputConvertEncodingType.Location = new System.Drawing.Point(15, 50);
            this.checkBoxSoXSettingsInputConvertEncodingType.Name = "checkBoxSoXSettingsInputConvertEncodingType";
            this.checkBoxSoXSettingsInputConvertEncodingType.Size = new System.Drawing.Size(133, 17);
            this.checkBoxSoXSettingsInputConvertEncodingType.TabIndex = 15;
            this.checkBoxSoXSettingsInputConvertEncodingType.Text = "Convert encoding type";
            this.checkBoxSoXSettingsInputConvertEncodingType.UseVisualStyleBackColor = true;
            this.checkBoxSoXSettingsInputConvertEncodingType.CheckedChanged += new System.EventHandler(this.checkBoxSoXSettingsInputConvertEncodingType_CheckedChanged);
            // 
            // comboBoxSoXSettingsInputConvertSamplingRate
            // 
            this.comboBoxSoXSettingsInputConvertSamplingRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSoXSettingsInputConvertSamplingRate.Enabled = false;
            this.comboBoxSoXSettingsInputConvertSamplingRate.FormattingEnabled = true;
            this.comboBoxSoXSettingsInputConvertSamplingRate.Items.AddRange(new object[] {
            "8000",
            "11025",
            "12000",
            "16000",
            "22050",
            "24000",
            "32000",
            "44100",
            "48000",
            "96000",
            "192000"});
            this.comboBoxSoXSettingsInputConvertSamplingRate.Location = new System.Drawing.Point(190, 73);
            this.comboBoxSoXSettingsInputConvertSamplingRate.Name = "comboBoxSoXSettingsInputConvertSamplingRate";
            this.comboBoxSoXSettingsInputConvertSamplingRate.Size = new System.Drawing.Size(60, 21);
            this.comboBoxSoXSettingsInputConvertSamplingRate.TabIndex = 12;
            // 
            // checkBoxSoXSettingsInputConvertSamplingRate
            // 
            this.checkBoxSoXSettingsInputConvertSamplingRate.AutoSize = true;
            this.checkBoxSoXSettingsInputConvertSamplingRate.Location = new System.Drawing.Point(15, 75);
            this.checkBoxSoXSettingsInputConvertSamplingRate.Name = "checkBoxSoXSettingsInputConvertSamplingRate";
            this.checkBoxSoXSettingsInputConvertSamplingRate.Size = new System.Drawing.Size(150, 17);
            this.checkBoxSoXSettingsInputConvertSamplingRate.TabIndex = 11;
            this.checkBoxSoXSettingsInputConvertSamplingRate.Text = "Convert sampling rate [Hz]";
            this.checkBoxSoXSettingsInputConvertSamplingRate.UseVisualStyleBackColor = true;
            this.checkBoxSoXSettingsInputConvertSamplingRate.CheckedChanged += new System.EventHandler(this.checkBoxSoXSettingsInputConvertSamplingRate_CheckedChanged);
            // 
            // checkBoxSoXSettingsInputConvertAudioResolution
            // 
            this.checkBoxSoXSettingsInputConvertAudioResolution.AutoSize = true;
            this.checkBoxSoXSettingsInputConvertAudioResolution.Location = new System.Drawing.Point(15, 25);
            this.checkBoxSoXSettingsInputConvertAudioResolution.Name = "checkBoxSoXSettingsInputConvertAudioResolution";
            this.checkBoxSoXSettingsInputConvertAudioResolution.Size = new System.Drawing.Size(160, 17);
            this.checkBoxSoXSettingsInputConvertAudioResolution.TabIndex = 13;
            this.checkBoxSoXSettingsInputConvertAudioResolution.Text = "Convert audio resolution [bit]";
            this.checkBoxSoXSettingsInputConvertAudioResolution.UseVisualStyleBackColor = true;
            this.checkBoxSoXSettingsInputConvertAudioResolution.CheckedChanged += new System.EventHandler(this.checkBoxSoXSettingsInputConvertAudioResolution_CheckedChanged);
            // 
            // comboBoxSoXSettingsInputConvertAudioResolution
            // 
            this.comboBoxSoXSettingsInputConvertAudioResolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSoXSettingsInputConvertAudioResolution.Enabled = false;
            this.comboBoxSoXSettingsInputConvertAudioResolution.FormattingEnabled = true;
            this.comboBoxSoXSettingsInputConvertAudioResolution.Items.AddRange(new object[] {
            "8",
            "16",
            "24",
            "32"});
            this.comboBoxSoXSettingsInputConvertAudioResolution.Location = new System.Drawing.Point(190, 23);
            this.comboBoxSoXSettingsInputConvertAudioResolution.Name = "comboBoxSoXSettingsInputConvertAudioResolution";
            this.comboBoxSoXSettingsInputConvertAudioResolution.Size = new System.Drawing.Size(60, 21);
            this.comboBoxSoXSettingsInputConvertAudioResolution.TabIndex = 14;
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.groupBox5);
            this.tabPage8.Controls.Add(this.checkBoxSoXSettingsGain);
            this.tabPage8.Controls.Add(this.textBoxSoXSettingsGain);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(355, 237);
            this.tabPage8.TabIndex = 2;
            this.tabPage8.Text = "Effects";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBoxSoxEffectsChangeTempoValue);
            this.groupBox5.Controls.Add(this.radioButtonSoXEffectsChangeTempoValue);
            this.groupBox5.Controls.Add(this.textBoxSoxEffectsChangeDurationSource);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.textBoxSoxEffectsChangeDurationTarget);
            this.groupBox5.Controls.Add(this.checkBoxSoXEffectsPitch);
            this.groupBox5.Controls.Add(this.textBoxSoXSettingsPitch);
            this.groupBox5.Controls.Add(this.radioButtonSoXEffectsChangeTempoDuration);
            this.groupBox5.Controls.Add(this.checkBoxSoXEffectsChangeTempo);
            this.groupBox5.Controls.Add(this.radioButtonSoXEffectsChangeTempoWithFPS);
            this.groupBox5.Controls.Add(this.textBoxSoxEffectsChangeFrameRateSource);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.textBoxSoxEffectsChangeFrameRateTarget);
            this.groupBox5.Location = new System.Drawing.Point(6, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(344, 170);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Tempo / Pitch";
            // 
            // textBoxSoxEffectsChangeTempoValue
            // 
            this.textBoxSoxEffectsChangeTempoValue.Enabled = false;
            this.textBoxSoxEffectsChangeTempoValue.Location = new System.Drawing.Point(183, 99);
            this.textBoxSoxEffectsChangeTempoValue.Name = "textBoxSoxEffectsChangeTempoValue";
            this.textBoxSoxEffectsChangeTempoValue.Size = new System.Drawing.Size(55, 20);
            this.textBoxSoxEffectsChangeTempoValue.TabIndex = 16;
            this.textBoxSoxEffectsChangeTempoValue.Text = "0.0";
            this.textBoxSoxEffectsChangeTempoValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxSoxEffectsChangeTempoValue.Leave += new System.EventHandler(this.textBoxSoxEffectsChangeTempoValue_Leave);
            // 
            // radioButtonSoXEffectsChangeTempoValue
            // 
            this.radioButtonSoXEffectsChangeTempoValue.AutoSize = true;
            this.radioButtonSoXEffectsChangeTempoValue.Enabled = false;
            this.radioButtonSoXEffectsChangeTempoValue.Location = new System.Drawing.Point(33, 100);
            this.radioButtonSoXEffectsChangeTempoValue.Name = "radioButtonSoXEffectsChangeTempoValue";
            this.radioButtonSoXEffectsChangeTempoValue.Size = new System.Drawing.Size(105, 17);
            this.radioButtonSoXEffectsChangeTempoValue.TabIndex = 15;
            this.radioButtonSoXEffectsChangeTempoValue.TabStop = true;
            this.radioButtonSoXEffectsChangeTempoValue.Text = "With direct value";
            this.radioButtonSoXEffectsChangeTempoValue.UseVisualStyleBackColor = true;
            // 
            // textBoxSoxEffectsChangeDurationSource
            // 
            this.textBoxSoxEffectsChangeDurationSource.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxSoxEffectsChangeDurationSource.Enabled = false;
            this.textBoxSoxEffectsChangeDurationSource.Location = new System.Drawing.Point(168, 74);
            this.textBoxSoxEffectsChangeDurationSource.Name = "textBoxSoxEffectsChangeDurationSource";
            this.textBoxSoxEffectsChangeDurationSource.Size = new System.Drawing.Size(70, 20);
            this.textBoxSoxEffectsChangeDurationSource.TabIndex = 12;
            this.textBoxSoxEffectsChangeDurationSource.Text = "00:00:00:000";
            this.textBoxSoxEffectsChangeDurationSource.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTipInfo.SetToolTip(this.textBoxSoxEffectsChangeDurationSource, "Input the duration from the source file.\r\nFormat: [hours]:[minutes]:[seconds]:[mi" +
                    "lliseconds]\r\n");
            this.textBoxSoxEffectsChangeDurationSource.Leave += new System.EventHandler(this.textBoxSoxSettingsChangeDurationSource_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(242, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "to";
            // 
            // textBoxSoxEffectsChangeDurationTarget
            // 
            this.textBoxSoxEffectsChangeDurationTarget.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxSoxEffectsChangeDurationTarget.Enabled = false;
            this.textBoxSoxEffectsChangeDurationTarget.Location = new System.Drawing.Point(259, 74);
            this.textBoxSoxEffectsChangeDurationTarget.Name = "textBoxSoxEffectsChangeDurationTarget";
            this.textBoxSoxEffectsChangeDurationTarget.Size = new System.Drawing.Size(70, 20);
            this.textBoxSoxEffectsChangeDurationTarget.TabIndex = 13;
            this.textBoxSoxEffectsChangeDurationTarget.Text = "00:00:00:000";
            this.textBoxSoxEffectsChangeDurationTarget.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTipInfo.SetToolTip(this.textBoxSoxEffectsChangeDurationTarget, "Input the target duration for the new file.\r\nFormat: [hours]:[minutes]:[seconds]:" +
                    "[milliseconds]\r\n");
            this.textBoxSoxEffectsChangeDurationTarget.Leave += new System.EventHandler(this.textBoxSoxSettingsChangeDurationTarget_Leave);
            // 
            // checkBoxSoXEffectsPitch
            // 
            this.checkBoxSoXEffectsPitch.AutoSize = true;
            this.checkBoxSoXEffectsPitch.Location = new System.Drawing.Point(14, 135);
            this.checkBoxSoXEffectsPitch.Name = "checkBoxSoXEffectsPitch";
            this.checkBoxSoXEffectsPitch.Size = new System.Drawing.Size(107, 17);
            this.checkBoxSoXEffectsPitch.TabIndex = 11;
            this.checkBoxSoXEffectsPitch.Text = "Change Pitch [%]";
            this.checkBoxSoXEffectsPitch.UseVisualStyleBackColor = true;
            this.checkBoxSoXEffectsPitch.CheckedChanged += new System.EventHandler(this.checkBoxSoXSettingsPitch_CheckedChanged);
            // 
            // textBoxSoXSettingsPitch
            // 
            this.textBoxSoXSettingsPitch.Enabled = false;
            this.textBoxSoXSettingsPitch.Location = new System.Drawing.Point(183, 134);
            this.textBoxSoXSettingsPitch.Name = "textBoxSoXSettingsPitch";
            this.textBoxSoXSettingsPitch.Size = new System.Drawing.Size(55, 20);
            this.textBoxSoXSettingsPitch.TabIndex = 12;
            this.textBoxSoXSettingsPitch.Text = "+0.0";
            this.textBoxSoXSettingsPitch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTipInfo.SetToolTip(this.textBoxSoXSettingsPitch, resources.GetString("textBoxSoXSettingsPitch.ToolTip"));
            this.textBoxSoXSettingsPitch.Leave += new System.EventHandler(this.textBoxSoXSettingsPitch_Leave);
            // 
            // radioButtonSoXEffectsChangeTempoDuration
            // 
            this.radioButtonSoXEffectsChangeTempoDuration.AutoSize = true;
            this.radioButtonSoXEffectsChangeTempoDuration.Enabled = false;
            this.radioButtonSoXEffectsChangeTempoDuration.Location = new System.Drawing.Point(33, 75);
            this.radioButtonSoXEffectsChangeTempoDuration.Name = "radioButtonSoXEffectsChangeTempoDuration";
            this.radioButtonSoXEffectsChangeTempoDuration.Size = new System.Drawing.Size(88, 17);
            this.radioButtonSoXEffectsChangeTempoDuration.TabIndex = 11;
            this.radioButtonSoXEffectsChangeTempoDuration.Text = "With duration";
            this.radioButtonSoXEffectsChangeTempoDuration.UseVisualStyleBackColor = true;
            // 
            // checkBoxSoXEffectsChangeTempo
            // 
            this.checkBoxSoXEffectsChangeTempo.AutoSize = true;
            this.checkBoxSoXEffectsChangeTempo.Location = new System.Drawing.Point(15, 25);
            this.checkBoxSoXEffectsChangeTempo.Name = "checkBoxSoXEffectsChangeTempo";
            this.checkBoxSoXEffectsChangeTempo.Size = new System.Drawing.Size(209, 17);
            this.checkBoxSoXEffectsChangeTempo.TabIndex = 10;
            this.checkBoxSoXEffectsChangeTempo.Text = "Change Tempo without changing pitch";
            this.checkBoxSoXEffectsChangeTempo.UseVisualStyleBackColor = true;
            this.checkBoxSoXEffectsChangeTempo.CheckedChanged += new System.EventHandler(this.checkBoxSoXEffectsChangeTempo_CheckedChanged);
            // 
            // radioButtonSoXEffectsChangeTempoWithFPS
            // 
            this.radioButtonSoXEffectsChangeTempoWithFPS.AutoSize = true;
            this.radioButtonSoXEffectsChangeTempoWithFPS.Checked = true;
            this.radioButtonSoXEffectsChangeTempoWithFPS.Enabled = false;
            this.radioButtonSoXEffectsChangeTempoWithFPS.Location = new System.Drawing.Point(33, 50);
            this.radioButtonSoXEffectsChangeTempoWithFPS.Name = "radioButtonSoXEffectsChangeTempoWithFPS";
            this.radioButtonSoXEffectsChangeTempoWithFPS.Size = new System.Drawing.Size(64, 17);
            this.radioButtonSoXEffectsChangeTempoWithFPS.TabIndex = 9;
            this.radioButtonSoXEffectsChangeTempoWithFPS.TabStop = true;
            this.radioButtonSoXEffectsChangeTempoWithFPS.Text = "With fps";
            this.radioButtonSoXEffectsChangeTempoWithFPS.UseVisualStyleBackColor = true;
            // 
            // textBoxSoxEffectsChangeFrameRateSource
            // 
            this.textBoxSoxEffectsChangeFrameRateSource.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxSoxEffectsChangeFrameRateSource.Enabled = false;
            this.textBoxSoxEffectsChangeFrameRateSource.Location = new System.Drawing.Point(183, 49);
            this.textBoxSoxEffectsChangeFrameRateSource.Name = "textBoxSoxEffectsChangeFrameRateSource";
            this.textBoxSoxEffectsChangeFrameRateSource.Size = new System.Drawing.Size(55, 20);
            this.textBoxSoxEffectsChangeFrameRateSource.TabIndex = 6;
            this.textBoxSoxEffectsChangeFrameRateSource.Text = "25.000";
            this.textBoxSoxEffectsChangeFrameRateSource.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxSoxEffectsChangeFrameRateSource.Leave += new System.EventHandler(this.textBoxSoxEffectsChangeFrameRateSource_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(242, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "to";
            // 
            // textBoxSoxEffectsChangeFrameRateTarget
            // 
            this.textBoxSoxEffectsChangeFrameRateTarget.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxSoxEffectsChangeFrameRateTarget.Enabled = false;
            this.textBoxSoxEffectsChangeFrameRateTarget.Location = new System.Drawing.Point(259, 49);
            this.textBoxSoxEffectsChangeFrameRateTarget.Name = "textBoxSoxEffectsChangeFrameRateTarget";
            this.textBoxSoxEffectsChangeFrameRateTarget.Size = new System.Drawing.Size(55, 20);
            this.textBoxSoxEffectsChangeFrameRateTarget.TabIndex = 7;
            this.textBoxSoxEffectsChangeFrameRateTarget.Text = "23.976";
            this.textBoxSoxEffectsChangeFrameRateTarget.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxSoxEffectsChangeFrameRateTarget.Leave += new System.EventHandler(this.textBoxSoxEffectsChangeFrameRateTarget_Leave);
            // 
            // checkBoxSoXSettingsGain
            // 
            this.checkBoxSoXSettingsGain.AutoSize = true;
            this.checkBoxSoXSettingsGain.Location = new System.Drawing.Point(21, 196);
            this.checkBoxSoXSettingsGain.Name = "checkBoxSoXSettingsGain";
            this.checkBoxSoXSettingsGain.Size = new System.Drawing.Size(70, 17);
            this.checkBoxSoXSettingsGain.TabIndex = 3;
            this.checkBoxSoXSettingsGain.Text = "Gain [dB]";
            this.checkBoxSoXSettingsGain.UseVisualStyleBackColor = true;
            this.checkBoxSoXSettingsGain.CheckedChanged += new System.EventHandler(this.checkBoxSoXSettingsGain_CheckedChanged);
            // 
            // textBoxSoXSettingsGain
            // 
            this.textBoxSoXSettingsGain.Enabled = false;
            this.textBoxSoXSettingsGain.Location = new System.Drawing.Point(199, 196);
            this.textBoxSoXSettingsGain.Name = "textBoxSoXSettingsGain";
            this.textBoxSoXSettingsGain.Size = new System.Drawing.Size(45, 20);
            this.textBoxSoXSettingsGain.TabIndex = 4;
            this.textBoxSoXSettingsGain.Text = "+3";
            // 
            // tabPage9
            // 
            this.tabPage9.Controls.Add(this.comboBoxSoXSettingsDownmixProLogic);
            this.tabPage9.Controls.Add(this.checkBoxSoXSettingsDownmixActivate);
            this.tabPage9.Controls.Add(this.groupBoxSoXSettingsMatrix);
            this.tabPage9.Location = new System.Drawing.Point(4, 22);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(355, 237);
            this.tabPage9.TabIndex = 3;
            this.tabPage9.Text = "Downmix";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // comboBoxSoXSettingsDownmixProLogic
            // 
            this.comboBoxSoXSettingsDownmixProLogic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSoXSettingsDownmixProLogic.Enabled = false;
            this.comboBoxSoXSettingsDownmixProLogic.FormattingEnabled = true;
            this.comboBoxSoXSettingsDownmixProLogic.Items.AddRange(new object[] {
            "Dolby Surround / ProLogic I",
            "Dolby ProLogic II"});
            this.comboBoxSoXSettingsDownmixProLogic.Location = new System.Drawing.Point(181, 18);
            this.comboBoxSoXSettingsDownmixProLogic.Name = "comboBoxSoXSettingsDownmixProLogic";
            this.comboBoxSoXSettingsDownmixProLogic.Size = new System.Drawing.Size(168, 21);
            this.comboBoxSoXSettingsDownmixProLogic.TabIndex = 15;
            this.comboBoxSoXSettingsDownmixProLogic.SelectedIndexChanged += new System.EventHandler(this.comboBoxSoXSettingsDownmixProLogic_SelectedIndexChanged);
            // 
            // checkBoxSoXSettingsDownmixActivate
            // 
            this.checkBoxSoXSettingsDownmixActivate.AutoSize = true;
            this.checkBoxSoXSettingsDownmixActivate.Location = new System.Drawing.Point(20, 20);
            this.checkBoxSoXSettingsDownmixActivate.Name = "checkBoxSoXSettingsDownmixActivate";
            this.checkBoxSoXSettingsDownmixActivate.Size = new System.Drawing.Size(155, 17);
            this.checkBoxSoXSettingsDownmixActivate.TabIndex = 16;
            this.checkBoxSoXSettingsDownmixActivate.Text = "Activate downmix to Stereo";
            this.checkBoxSoXSettingsDownmixActivate.UseVisualStyleBackColor = true;
            this.checkBoxSoXSettingsDownmixActivate.CheckedChanged += new System.EventHandler(this.checkBoxSoXSettingsDownmixActivate_CheckedChanged);
            // 
            // groupBoxSoXSettingsMatrix
            // 
            this.groupBoxSoXSettingsMatrix.Controls.Add(this.checkBoxSoXSettings51MixLFE);
            this.groupBoxSoXSettingsMatrix.Controls.Add(this.checkBoxSoXSettings51DownmixNormalize);
            this.groupBoxSoXSettingsMatrix.Controls.Add(this.label4);
            this.groupBoxSoXSettingsMatrix.Controls.Add(this.label6);
            this.groupBoxSoXSettingsMatrix.Controls.Add(this.textBoxSoXSettings51Matrix00);
            this.groupBoxSoXSettingsMatrix.Controls.Add(this.label5);
            this.groupBoxSoXSettingsMatrix.Controls.Add(this.textBoxSoXSettings51Matrix01);
            this.groupBoxSoXSettingsMatrix.Controls.Add(this.textBoxSoXSettings51Matrix15);
            this.groupBoxSoXSettingsMatrix.Controls.Add(this.textBoxSoXSettings51Matrix02);
            this.groupBoxSoXSettingsMatrix.Controls.Add(this.textBoxSoXSettings51Matrix14);
            this.groupBoxSoXSettingsMatrix.Controls.Add(this.textBoxSoXSettings51Matrix03);
            this.groupBoxSoXSettingsMatrix.Controls.Add(this.textBoxSoXSettings51Matrix13);
            this.groupBoxSoXSettingsMatrix.Controls.Add(this.textBoxSoXSettings51Matrix04);
            this.groupBoxSoXSettingsMatrix.Controls.Add(this.textBoxSoXSettings51Matrix12);
            this.groupBoxSoXSettingsMatrix.Controls.Add(this.textBoxSoXSettings51Matrix05);
            this.groupBoxSoXSettingsMatrix.Controls.Add(this.textBoxSoXSettings51Matrix11);
            this.groupBoxSoXSettingsMatrix.Controls.Add(this.textBoxSoXSettings51Matrix10);
            this.groupBoxSoXSettingsMatrix.Enabled = false;
            this.groupBoxSoXSettingsMatrix.Location = new System.Drawing.Point(5, 49);
            this.groupBoxSoXSettingsMatrix.Name = "groupBoxSoXSettingsMatrix";
            this.groupBoxSoXSettingsMatrix.Size = new System.Drawing.Size(344, 117);
            this.groupBoxSoXSettingsMatrix.TabIndex = 15;
            this.groupBoxSoXSettingsMatrix.TabStop = false;
            this.groupBoxSoXSettingsMatrix.Text = "5.1 Matrix";
            // 
            // checkBoxSoXSettings51MixLFE
            // 
            this.checkBoxSoXSettings51MixLFE.AutoSize = true;
            this.checkBoxSoXSettings51MixLFE.Location = new System.Drawing.Point(184, 90);
            this.checkBoxSoXSettings51MixLFE.Name = "checkBoxSoXSettings51MixLFE";
            this.checkBoxSoXSettings51MixLFE.Size = new System.Drawing.Size(64, 17);
            this.checkBoxSoXSettings51MixLFE.TabIndex = 16;
            this.checkBoxSoXSettings51MixLFE.Text = "Mix LFE";
            this.checkBoxSoXSettings51MixLFE.UseVisualStyleBackColor = true;
            this.checkBoxSoXSettings51MixLFE.CheckedChanged += new System.EventHandler(this.checkBoxSoXSettings51MixLFE_CheckedChanged);
            // 
            // checkBoxSoXSettings51DownmixNormalize
            // 
            this.checkBoxSoXSettings51DownmixNormalize.AutoSize = true;
            this.checkBoxSoXSettings51DownmixNormalize.Location = new System.Drawing.Point(31, 90);
            this.checkBoxSoXSettings51DownmixNormalize.Name = "checkBoxSoXSettings51DownmixNormalize";
            this.checkBoxSoXSettings51DownmixNormalize.Size = new System.Drawing.Size(102, 17);
            this.checkBoxSoXSettings51DownmixNormalize.TabIndex = 15;
            this.checkBoxSoXSettings51DownmixNormalize.Text = "Normalize matrix";
            this.toolTipInfo.SetToolTip(this.checkBoxSoXSettings51DownmixNormalize, "Prevents clipping");
            this.checkBoxSoXSettings51DownmixNormalize.UseVisualStyleBackColor = true;
            this.checkBoxSoXSettings51DownmixNormalize.CheckedChanged += new System.EventHandler(this.checkBoxSoXSettings51DownmixNormalize_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(273, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "L               R               C            LFE           SL             SR";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "R";
            // 
            // textBoxSoXSettings51Matrix00
            // 
            this.textBoxSoXSettings51Matrix00.Location = new System.Drawing.Point(31, 38);
            this.textBoxSoXSettings51Matrix00.Name = "textBoxSoXSettings51Matrix00";
            this.textBoxSoXSettings51Matrix00.ReadOnly = true;
            this.textBoxSoXSettings51Matrix00.Size = new System.Drawing.Size(45, 20);
            this.textBoxSoXSettings51Matrix00.TabIndex = 1;
            this.textBoxSoXSettings51Matrix00.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "L";
            // 
            // textBoxSoXSettings51Matrix01
            // 
            this.textBoxSoXSettings51Matrix01.Location = new System.Drawing.Point(82, 38);
            this.textBoxSoXSettings51Matrix01.Name = "textBoxSoXSettings51Matrix01";
            this.textBoxSoXSettings51Matrix01.ReadOnly = true;
            this.textBoxSoXSettings51Matrix01.Size = new System.Drawing.Size(45, 20);
            this.textBoxSoXSettings51Matrix01.TabIndex = 2;
            this.textBoxSoXSettings51Matrix01.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxSoXSettings51Matrix15
            // 
            this.textBoxSoXSettings51Matrix15.Location = new System.Drawing.Point(286, 64);
            this.textBoxSoXSettings51Matrix15.Name = "textBoxSoXSettings51Matrix15";
            this.textBoxSoXSettings51Matrix15.ReadOnly = true;
            this.textBoxSoXSettings51Matrix15.Size = new System.Drawing.Size(45, 20);
            this.textBoxSoXSettings51Matrix15.TabIndex = 12;
            this.textBoxSoXSettings51Matrix15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxSoXSettings51Matrix02
            // 
            this.textBoxSoXSettings51Matrix02.Location = new System.Drawing.Point(133, 38);
            this.textBoxSoXSettings51Matrix02.Name = "textBoxSoXSettings51Matrix02";
            this.textBoxSoXSettings51Matrix02.ReadOnly = true;
            this.textBoxSoXSettings51Matrix02.Size = new System.Drawing.Size(45, 20);
            this.textBoxSoXSettings51Matrix02.TabIndex = 3;
            this.textBoxSoXSettings51Matrix02.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxSoXSettings51Matrix14
            // 
            this.textBoxSoXSettings51Matrix14.Location = new System.Drawing.Point(235, 64);
            this.textBoxSoXSettings51Matrix14.Name = "textBoxSoXSettings51Matrix14";
            this.textBoxSoXSettings51Matrix14.ReadOnly = true;
            this.textBoxSoXSettings51Matrix14.Size = new System.Drawing.Size(45, 20);
            this.textBoxSoXSettings51Matrix14.TabIndex = 11;
            this.textBoxSoXSettings51Matrix14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxSoXSettings51Matrix03
            // 
            this.textBoxSoXSettings51Matrix03.Location = new System.Drawing.Point(184, 38);
            this.textBoxSoXSettings51Matrix03.Name = "textBoxSoXSettings51Matrix03";
            this.textBoxSoXSettings51Matrix03.ReadOnly = true;
            this.textBoxSoXSettings51Matrix03.Size = new System.Drawing.Size(45, 20);
            this.textBoxSoXSettings51Matrix03.TabIndex = 4;
            this.textBoxSoXSettings51Matrix03.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxSoXSettings51Matrix13
            // 
            this.textBoxSoXSettings51Matrix13.Location = new System.Drawing.Point(184, 64);
            this.textBoxSoXSettings51Matrix13.Name = "textBoxSoXSettings51Matrix13";
            this.textBoxSoXSettings51Matrix13.ReadOnly = true;
            this.textBoxSoXSettings51Matrix13.Size = new System.Drawing.Size(45, 20);
            this.textBoxSoXSettings51Matrix13.TabIndex = 10;
            this.textBoxSoXSettings51Matrix13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxSoXSettings51Matrix04
            // 
            this.textBoxSoXSettings51Matrix04.Location = new System.Drawing.Point(235, 38);
            this.textBoxSoXSettings51Matrix04.Name = "textBoxSoXSettings51Matrix04";
            this.textBoxSoXSettings51Matrix04.ReadOnly = true;
            this.textBoxSoXSettings51Matrix04.Size = new System.Drawing.Size(45, 20);
            this.textBoxSoXSettings51Matrix04.TabIndex = 5;
            this.textBoxSoXSettings51Matrix04.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxSoXSettings51Matrix12
            // 
            this.textBoxSoXSettings51Matrix12.Location = new System.Drawing.Point(133, 64);
            this.textBoxSoXSettings51Matrix12.Name = "textBoxSoXSettings51Matrix12";
            this.textBoxSoXSettings51Matrix12.ReadOnly = true;
            this.textBoxSoXSettings51Matrix12.Size = new System.Drawing.Size(45, 20);
            this.textBoxSoXSettings51Matrix12.TabIndex = 9;
            this.textBoxSoXSettings51Matrix12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxSoXSettings51Matrix05
            // 
            this.textBoxSoXSettings51Matrix05.Location = new System.Drawing.Point(286, 38);
            this.textBoxSoXSettings51Matrix05.Name = "textBoxSoXSettings51Matrix05";
            this.textBoxSoXSettings51Matrix05.ReadOnly = true;
            this.textBoxSoXSettings51Matrix05.Size = new System.Drawing.Size(45, 20);
            this.textBoxSoXSettings51Matrix05.TabIndex = 6;
            this.textBoxSoXSettings51Matrix05.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxSoXSettings51Matrix11
            // 
            this.textBoxSoXSettings51Matrix11.Location = new System.Drawing.Point(82, 64);
            this.textBoxSoXSettings51Matrix11.Name = "textBoxSoXSettings51Matrix11";
            this.textBoxSoXSettings51Matrix11.ReadOnly = true;
            this.textBoxSoXSettings51Matrix11.Size = new System.Drawing.Size(45, 20);
            this.textBoxSoXSettings51Matrix11.TabIndex = 8;
            this.textBoxSoXSettings51Matrix11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxSoXSettings51Matrix10
            // 
            this.textBoxSoXSettings51Matrix10.Location = new System.Drawing.Point(31, 64);
            this.textBoxSoXSettings51Matrix10.Name = "textBoxSoXSettings51Matrix10";
            this.textBoxSoXSettings51Matrix10.ReadOnly = true;
            this.textBoxSoXSettings51Matrix10.Size = new System.Drawing.Size(45, 20);
            this.textBoxSoXSettings51Matrix10.TabIndex = 7;
            this.textBoxSoXSettings51Matrix10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.groupBox4);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(355, 237);
            this.tabPage7.TabIndex = 1;
            this.tabPage7.Text = "Output";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.comboBoxSoXSettingsOutputConvertEncodingType);
            this.groupBox4.Controls.Add(this.checkBoxSoXSettingsOutputConvertEncodingType);
            this.groupBox4.Controls.Add(this.checkBoxSoXSettingsOutputConvertAudioResolution);
            this.groupBox4.Controls.Add(this.comboBoxSoXSettingsOutputConvertSamplingRate);
            this.groupBox4.Controls.Add(this.comboBoxSoXSettingsOutputConvertAudioResolution);
            this.groupBox4.Controls.Add(this.checkBoxSoXSettingsOutputConvertSamplingRate);
            this.groupBox4.Location = new System.Drawing.Point(6, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(344, 105);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Prepare stream before encoding";
            // 
            // comboBoxSoXSettingsOutputConvertEncodingType
            // 
            this.comboBoxSoXSettingsOutputConvertEncodingType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSoXSettingsOutputConvertEncodingType.Enabled = false;
            this.comboBoxSoXSettingsOutputConvertEncodingType.FormattingEnabled = true;
            this.comboBoxSoXSettingsOutputConvertEncodingType.Items.AddRange(new object[] {
            "Signed Integer",
            "Unsigned Integer",
            "Floating Point"});
            this.comboBoxSoXSettingsOutputConvertEncodingType.Location = new System.Drawing.Point(190, 48);
            this.comboBoxSoXSettingsOutputConvertEncodingType.Name = "comboBoxSoXSettingsOutputConvertEncodingType";
            this.comboBoxSoXSettingsOutputConvertEncodingType.Size = new System.Drawing.Size(110, 21);
            this.comboBoxSoXSettingsOutputConvertEncodingType.TabIndex = 12;
            // 
            // checkBoxSoXSettingsOutputConvertEncodingType
            // 
            this.checkBoxSoXSettingsOutputConvertEncodingType.AutoSize = true;
            this.checkBoxSoXSettingsOutputConvertEncodingType.Location = new System.Drawing.Point(15, 50);
            this.checkBoxSoXSettingsOutputConvertEncodingType.Name = "checkBoxSoXSettingsOutputConvertEncodingType";
            this.checkBoxSoXSettingsOutputConvertEncodingType.Size = new System.Drawing.Size(133, 17);
            this.checkBoxSoXSettingsOutputConvertEncodingType.TabIndex = 11;
            this.checkBoxSoXSettingsOutputConvertEncodingType.Text = "Convert encoding type";
            this.checkBoxSoXSettingsOutputConvertEncodingType.UseVisualStyleBackColor = true;
            this.checkBoxSoXSettingsOutputConvertEncodingType.CheckedChanged += new System.EventHandler(this.checkBoxSoXSettingsOutputConvertEncodingType_CheckedChanged);
            // 
            // checkBoxSoXSettingsOutputConvertAudioResolution
            // 
            this.checkBoxSoXSettingsOutputConvertAudioResolution.AutoSize = true;
            this.checkBoxSoXSettingsOutputConvertAudioResolution.Location = new System.Drawing.Point(15, 25);
            this.checkBoxSoXSettingsOutputConvertAudioResolution.Name = "checkBoxSoXSettingsOutputConvertAudioResolution";
            this.checkBoxSoXSettingsOutputConvertAudioResolution.Size = new System.Drawing.Size(160, 17);
            this.checkBoxSoXSettingsOutputConvertAudioResolution.TabIndex = 9;
            this.checkBoxSoXSettingsOutputConvertAudioResolution.Text = "Convert audio resolution [bit]";
            this.checkBoxSoXSettingsOutputConvertAudioResolution.UseVisualStyleBackColor = true;
            this.checkBoxSoXSettingsOutputConvertAudioResolution.CheckedChanged += new System.EventHandler(this.checkBoxSoXSettingsOutputConvertAudioResolution_CheckedChanged);
            // 
            // comboBoxSoXSettingsOutputConvertSamplingRate
            // 
            this.comboBoxSoXSettingsOutputConvertSamplingRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSoXSettingsOutputConvertSamplingRate.Enabled = false;
            this.comboBoxSoXSettingsOutputConvertSamplingRate.FormattingEnabled = true;
            this.comboBoxSoXSettingsOutputConvertSamplingRate.Items.AddRange(new object[] {
            "8000",
            "11025",
            "12000",
            "16000",
            "22050",
            "24000",
            "32000",
            "44100",
            "48000",
            "96000",
            "192000"});
            this.comboBoxSoXSettingsOutputConvertSamplingRate.Location = new System.Drawing.Point(190, 73);
            this.comboBoxSoXSettingsOutputConvertSamplingRate.Name = "comboBoxSoXSettingsOutputConvertSamplingRate";
            this.comboBoxSoXSettingsOutputConvertSamplingRate.Size = new System.Drawing.Size(60, 21);
            this.comboBoxSoXSettingsOutputConvertSamplingRate.TabIndex = 1;
            // 
            // comboBoxSoXSettingsOutputConvertAudioResolution
            // 
            this.comboBoxSoXSettingsOutputConvertAudioResolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSoXSettingsOutputConvertAudioResolution.Enabled = false;
            this.comboBoxSoXSettingsOutputConvertAudioResolution.FormattingEnabled = true;
            this.comboBoxSoXSettingsOutputConvertAudioResolution.Items.AddRange(new object[] {
            "8",
            "16",
            "24",
            "32"});
            this.comboBoxSoXSettingsOutputConvertAudioResolution.Location = new System.Drawing.Point(190, 23);
            this.comboBoxSoXSettingsOutputConvertAudioResolution.Name = "comboBoxSoXSettingsOutputConvertAudioResolution";
            this.comboBoxSoXSettingsOutputConvertAudioResolution.Size = new System.Drawing.Size(60, 21);
            this.comboBoxSoXSettingsOutputConvertAudioResolution.TabIndex = 10;
            // 
            // checkBoxSoXSettingsOutputConvertSamplingRate
            // 
            this.checkBoxSoXSettingsOutputConvertSamplingRate.AutoSize = true;
            this.checkBoxSoXSettingsOutputConvertSamplingRate.Location = new System.Drawing.Point(15, 75);
            this.checkBoxSoXSettingsOutputConvertSamplingRate.Name = "checkBoxSoXSettingsOutputConvertSamplingRate";
            this.checkBoxSoXSettingsOutputConvertSamplingRate.Size = new System.Drawing.Size(150, 17);
            this.checkBoxSoXSettingsOutputConvertSamplingRate.TabIndex = 0;
            this.checkBoxSoXSettingsOutputConvertSamplingRate.Text = "Convert sampling rate [Hz]";
            this.checkBoxSoXSettingsOutputConvertSamplingRate.UseVisualStyleBackColor = true;
            this.checkBoxSoXSettingsOutputConvertSamplingRate.CheckedChanged += new System.EventHandler(this.checkBoxSoXSettingsOutputConvertSamplingRate_CheckedChanged);
            // 
            // groupBoxEac3toSettings
            // 
            this.groupBoxEac3toSettings.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxEac3toSettings.Controls.Add(this.checkBoxEac3toSettingsConvertChannels);
            this.groupBoxEac3toSettings.Controls.Add(this.checkBoxEac3toSettingsDialogNormalization);
            this.groupBoxEac3toSettings.Controls.Add(this.radioButtonEac3toSettingsConvertTo51);
            this.groupBoxEac3toSettings.Controls.Add(this.radioButtonEac3toSettingsConvertToStereo);
            this.groupBoxEac3toSettings.ForeColor = System.Drawing.Color.Black;
            this.groupBoxEac3toSettings.Location = new System.Drawing.Point(12, 236);
            this.groupBoxEac3toSettings.Name = "groupBoxEac3toSettings";
            this.groupBoxEac3toSettings.Size = new System.Drawing.Size(376, 97);
            this.groupBoxEac3toSettings.TabIndex = 5;
            this.groupBoxEac3toSettings.TabStop = false;
            this.groupBoxEac3toSettings.Text = "eac3to Settings";
            // 
            // checkBoxEac3toSettingsConvertChannels
            // 
            this.checkBoxEac3toSettingsConvertChannels.AutoSize = true;
            this.checkBoxEac3toSettingsConvertChannels.Location = new System.Drawing.Point(15, 28);
            this.checkBoxEac3toSettingsConvertChannels.Name = "checkBoxEac3toSettingsConvertChannels";
            this.checkBoxEac3toSettingsConvertChannels.Size = new System.Drawing.Size(81, 17);
            this.checkBoxEac3toSettingsConvertChannels.TabIndex = 11;
            this.checkBoxEac3toSettingsConvertChannels.Text = "Downmix to";
            this.checkBoxEac3toSettingsConvertChannels.UseVisualStyleBackColor = true;
            this.checkBoxEac3toSettingsConvertChannels.CheckedChanged += new System.EventHandler(this.checkBoxEac3toSettingsConvertChannels_CheckedChanged);
            // 
            // checkBoxEac3toSettingsDialogNormalization
            // 
            this.checkBoxEac3toSettingsDialogNormalization.AutoSize = true;
            this.checkBoxEac3toSettingsDialogNormalization.Location = new System.Drawing.Point(15, 72);
            this.checkBoxEac3toSettingsDialogNormalization.Name = "checkBoxEac3toSettingsDialogNormalization";
            this.checkBoxEac3toSettingsDialogNormalization.Size = new System.Drawing.Size(278, 17);
            this.checkBoxEac3toSettingsDialogNormalization.TabIndex = 6;
            this.checkBoxEac3toSettingsDialogNormalization.Text = "Disable dialog normalization removal (not recommend)";
            this.checkBoxEac3toSettingsDialogNormalization.UseVisualStyleBackColor = true;
            // 
            // radioButtonEac3toSettingsConvertTo51
            // 
            this.radioButtonEac3toSettingsConvertTo51.AutoSize = true;
            this.radioButtonEac3toSettingsConvertTo51.Enabled = false;
            this.radioButtonEac3toSettingsConvertTo51.Location = new System.Drawing.Point(102, 49);
            this.radioButtonEac3toSettingsConvertTo51.Name = "radioButtonEac3toSettingsConvertTo51";
            this.radioButtonEac3toSettingsConvertTo51.Size = new System.Drawing.Size(183, 17);
            this.radioButtonEac3toSettingsConvertTo51.TabIndex = 4;
            this.radioButtonEac3toSettingsConvertTo51.Text = "5.1 (Only from 6.1 or 7.1 Sources)";
            this.radioButtonEac3toSettingsConvertTo51.UseVisualStyleBackColor = true;
            // 
            // radioButtonEac3toSettingsConvertToStereo
            // 
            this.radioButtonEac3toSettingsConvertToStereo.AutoSize = true;
            this.radioButtonEac3toSettingsConvertToStereo.Checked = true;
            this.radioButtonEac3toSettingsConvertToStereo.Enabled = false;
            this.radioButtonEac3toSettingsConvertToStereo.Location = new System.Drawing.Point(102, 26);
            this.radioButtonEac3toSettingsConvertToStereo.Name = "radioButtonEac3toSettingsConvertToStereo";
            this.radioButtonEac3toSettingsConvertToStereo.Size = new System.Drawing.Size(262, 17);
            this.radioButtonEac3toSettingsConvertToStereo.TabIndex = 3;
            this.radioButtonEac3toSettingsConvertToStereo.TabStop = true;
            this.radioButtonEac3toSettingsConvertToStereo.Text = "Stereo (Dolby Pro Logic II) (Only from 5.1 Sources)";
            this.radioButtonEac3toSettingsConvertToStereo.UseVisualStyleBackColor = true;
            // 
            // buttonStartConverting
            // 
            this.buttonStartConverting.Enabled = false;
            this.buttonStartConverting.Location = new System.Drawing.Point(23, 634);
            this.buttonStartConverting.Name = "buttonStartConverting";
            this.buttonStartConverting.Size = new System.Drawing.Size(123, 32);
            this.buttonStartConverting.TabIndex = 6;
            this.buttonStartConverting.Text = "Start Converting";
            this.buttonStartConverting.UseVisualStyleBackColor = true;
            this.buttonStartConverting.Click += new System.EventHandler(this.buttonStartConverting_Click);
            // 
            // toolTipInfo
            // 
            this.toolTipInfo.AutoPopDelay = 20000;
            this.toolTipInfo.InitialDelay = 500;
            this.toolTipInfo.ReshowDelay = 100;
            // 
            // groupBoxSoXSettings
            // 
            this.groupBoxSoXSettings.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxSoXSettings.Controls.Add(this.tabControl2);
            this.groupBoxSoXSettings.Location = new System.Drawing.Point(12, 339);
            this.groupBoxSoXSettings.Name = "groupBoxSoXSettings";
            this.groupBoxSoXSettings.Size = new System.Drawing.Size(376, 289);
            this.groupBoxSoXSettings.TabIndex = 18;
            this.groupBoxSoXSettings.TabStop = false;
            this.groupBoxSoXSettings.Text = "SoX Settings";
            // 
            // buttonCancelConverting
            // 
            this.buttonCancelConverting.Enabled = false;
            this.buttonCancelConverting.Location = new System.Drawing.Point(255, 634);
            this.buttonCancelConverting.Name = "buttonCancelConverting";
            this.buttonCancelConverting.Size = new System.Drawing.Size(123, 32);
            this.buttonCancelConverting.TabIndex = 19;
            this.buttonCancelConverting.Text = "Cancel";
            this.buttonCancelConverting.UseVisualStyleBackColor = true;
            this.buttonCancelConverting.Click += new System.EventHandler(this.buttonCancelConverting_Click);
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(754, 722);
            this.Controls.Add(this.groupBoxSoXSettings);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxEac3toSettings);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.buttonCancelConverting);
            this.Controls.Add(this.dataGridViewMain);
            this.Controls.Add(this.buttonStartConverting);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BDAudioConverterGUI - Version: 0.2.0";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Main_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBoxAACTarget.ResumeLayout(false);
            this.groupBoxAACTarget.PerformLayout();
            this.groupBoxAACOptions.ResumeLayout(false);
            this.groupBoxAACOptions.PerformLayout();
            this.groupBoxAACBitrate.ResumeLayout(false);
            this.groupBoxAACBitrate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAACBitrate)).EndInit();
            this.groupBoxAACQuality.ResumeLayout(false);
            this.groupBoxAACQuality.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAACQuality)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBoxAC3DynamicRangeDialogNormalization.ResumeLayout(false);
            this.groupBoxAC3DynamicRangeDialogNormalization.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBoxAC3ExponentStrategySearchSize.ResumeLayout(false);
            this.groupBoxAC3ExponentStrategySearchSize.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAC3ExponentStrategySearchSize)).EndInit();
            this.groupBoxAC3Bitrate.ResumeLayout(false);
            this.groupBoxAC3Bitrate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAC3Bitrate)).EndInit();
            this.tabPage11.ResumeLayout(false);
            this.tabPage11.PerformLayout();
            this.groupBoxDTSBitrate.ResumeLayout(false);
            this.groupBoxDTSBitrate.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.groupBoxFLACCompression.ResumeLayout(false);
            this.groupBoxFLACCompression.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFLACCompression)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBoxMP3Options.ResumeLayout(false);
            this.groupBoxMP3Options.PerformLayout();
            this.groupBoxMP3Bitrate.ResumeLayout(false);
            this.groupBoxMP3Bitrate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMP3Bitrate)).EndInit();
            this.groupBoxMP3Quality.ResumeLayout(false);
            this.groupBoxMP3Quality.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMP3Quality)).EndInit();
            this.groupBoxMP3Target.ResumeLayout(false);
            this.groupBoxMP3Target.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.groupBoxWAVOutputFormat.ResumeLayout(false);
            this.groupBoxWAVOutputFormat.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage10.ResumeLayout(false);
            this.groupBoxSoXSettingsMainPrepareStream.ResumeLayout(false);
            this.groupBoxSoXSettingsMainPrepareStream.PerformLayout();
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabPage9.ResumeLayout(false);
            this.tabPage9.PerformLayout();
            this.groupBoxSoXSettingsMatrix.ResumeLayout(false);
            this.groupBoxSoXSettingsMatrix.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBoxEac3toSettings.ResumeLayout(false);
            this.groupBoxEac3toSettings.PerformLayout();
            this.groupBoxSoXSettings.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clearListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkNoneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeUncheckedToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar trackBarAACQuality;
        private System.Windows.Forms.GroupBox groupBoxAACQuality;
        private System.Windows.Forms.GroupBox groupBoxAACBitrate;
        private System.Windows.Forms.TrackBar trackBarAACBitrate;
        private System.Windows.Forms.GroupBox groupBoxAACOptions;
        private System.Windows.Forms.ComboBox comboBoxAACProfiles;
        private System.Windows.Forms.CheckBox checkBoxAACRestrictEncoder;
        private System.Windows.Forms.Label labelAACBitrate;
        private System.Windows.Forms.Label labelAACQuality;
        private System.Windows.Forms.Label labelAACProfile;
        private System.Windows.Forms.GroupBox groupBoxAACTarget;
        private System.Windows.Forms.CheckBox checkBoxAACRTPHinttrack;
        private System.Windows.Forms.RadioButton radioButtonAACBitrate;
        private System.Windows.Forms.RadioButton radioButtonAACQuality;
        private System.Windows.Forms.ComboBox comboBoxSoXSettingsOutputConvertSamplingRate;
        private System.Windows.Forms.CheckBox checkBoxSoXSettingsOutputConvertSamplingRate;
        private System.Windows.Forms.ComboBox comboBoxSoXSettingsOutputConvertAudioResolution;
        private System.Windows.Forms.CheckBox checkBoxSoXSettingsOutputConvertAudioResolution;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSoxEffectsChangeFrameRateTarget;
        private System.Windows.Forms.TextBox textBoxSoxEffectsChangeFrameRateSource;
        private System.Windows.Forms.TextBox textBoxSoXSettingsGain;
        private System.Windows.Forms.CheckBox checkBoxSoXSettingsGain;
        private System.Windows.Forms.GroupBox groupBoxEac3toSettings;
        private System.Windows.Forms.RadioButton radioButtonEac3toSettingsConvertTo51;
        private System.Windows.Forms.RadioButton radioButtonEac3toSettingsConvertToStereo;
        private System.Windows.Forms.CheckBox checkBoxEac3toSettingsDialogNormalization;
        private System.Windows.Forms.TextBox textBoxSoXSettingsPitch;
        private System.Windows.Forms.CheckBox checkBoxSoXEffectsPitch;
        private System.Windows.Forms.CheckBox checkBoxEac3toSettingsConvertChannels;
        private System.Windows.Forms.Button buttonStartConverting;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.GroupBox groupBoxWAVOutputFormat;
        private System.Windows.Forms.RadioButton radioButtonWAVOutputFormatAIFF;
        private System.Windows.Forms.RadioButton radioButtonWAVOutputFormatWAV;
        public System.Windows.Forms.DataGridView dataGridViewMain;
        private System.Windows.Forms.GroupBox groupBoxFLACCompression;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelFLACCompression;
        private System.Windows.Forms.TrackBar trackBarFLACCompression;
        private System.Windows.Forms.ToolTip toolTipInfo;
        private System.Windows.Forms.ComboBox comboBoxSoXSettingsMainBufferSize;
        private System.Windows.Forms.Label labelSoXSettingsMainBufferSize;
        private System.Windows.Forms.GroupBox groupBoxMP3Bitrate;
        private System.Windows.Forms.CheckBox checkBoxMP3RestrictEncoder;
        private System.Windows.Forms.Label labelMP3Bitrate;
        private System.Windows.Forms.TrackBar trackBarMP3Bitrate;
        private System.Windows.Forms.GroupBox groupBoxMP3Quality;
        private System.Windows.Forms.Label labelMP3Quality;
        private System.Windows.Forms.TrackBar trackBarMP3Quality;
        private System.Windows.Forms.GroupBox groupBoxMP3Target;
        private System.Windows.Forms.RadioButton radioButtonMP3Bitrate;
        private System.Windows.Forms.RadioButton radioButtonMP3Quality;
        private System.Windows.Forms.GroupBox groupBoxMP3Options;
        private System.Windows.Forms.ComboBox comboBoxMP3OptionsChannelModes;
        private System.Windows.Forms.Label labelMP3OptionsChannelModes;
        private System.Windows.Forms.CheckBox checkBoxMP3OptionsErrorProtection;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.ComboBox comboBoxSoXSettingsDownmixProLogic;
        private System.Windows.Forms.CheckBox checkBoxSoXSettingsDownmixActivate;
        private System.Windows.Forms.CheckBox checkBoxSoXSettings51DownmixNormalize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxSoXSettings51Matrix00;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxSoXSettings51Matrix01;
        private System.Windows.Forms.TextBox textBoxSoXSettings51Matrix15;
        private System.Windows.Forms.TextBox textBoxSoXSettings51Matrix02;
        private System.Windows.Forms.TextBox textBoxSoXSettings51Matrix14;
        private System.Windows.Forms.TextBox textBoxSoXSettings51Matrix03;
        private System.Windows.Forms.TextBox textBoxSoXSettings51Matrix13;
        private System.Windows.Forms.TextBox textBoxSoXSettings51Matrix04;
        private System.Windows.Forms.TextBox textBoxSoXSettings51Matrix12;
        private System.Windows.Forms.TextBox textBoxSoXSettings51Matrix05;
        private System.Windows.Forms.TextBox textBoxSoXSettings51Matrix11;
        private System.Windows.Forms.TextBox textBoxSoXSettings51Matrix10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabPage tabPage10;
        private System.Windows.Forms.GroupBox groupBoxSoXSettingsMainPrepareStream;
        private System.Windows.Forms.ComboBox comboBoxSoXSettingsInputConvertEncodingType;
        private System.Windows.Forms.CheckBox checkBoxSoXSettingsInputConvertEncodingType;
        private System.Windows.Forms.ComboBox comboBoxSoXSettingsInputConvertSamplingRate;
        private System.Windows.Forms.CheckBox checkBoxSoXSettingsInputConvertSamplingRate;
        private System.Windows.Forms.CheckBox checkBoxSoXSettingsInputConvertAudioResolution;
        private System.Windows.Forms.ComboBox comboBoxSoXSettingsInputConvertAudioResolution;
        private System.Windows.Forms.TabPage tabPage11;
        private System.Windows.Forms.GroupBox groupBoxAC3Bitrate;
        private System.Windows.Forms.Label labelAC3Bitrate;
        private System.Windows.Forms.TrackBar trackBarAC3Bitrate;
        private System.Windows.Forms.LinkLabel linkLabelAAC;
        private System.Windows.Forms.LinkLabel linkLabelAC3;
        private System.Windows.Forms.LinkLabel linkLabelMP3;
        private System.Windows.Forms.GroupBox groupBoxAC3ExponentStrategySearchSize;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBoxAC3BitsreamInfoSurroundmix;
        private System.Windows.Forms.Label labelAC3BitsreamInfoSurroundmix;
        private System.Windows.Forms.ComboBox comboBoxAC3BitsreamInfoCentermix;
        private System.Windows.Forms.Label labelAC3BitsreamInfoCentermix;
        private System.Windows.Forms.ComboBox comboBoxAC3BitstreamInfoDolbySurround;
        private System.Windows.Forms.Label labelAC3BitstreamInfoDolbySurround;
        private System.Windows.Forms.Label labelAC3ExponentStrategySearchSize;
        private System.Windows.Forms.TrackBar trackBarAC3ExponentStrategySearchSize;
        private System.Windows.Forms.GroupBox groupBoxAC3DynamicRangeDialogNormalization;
        private System.Windows.Forms.ComboBox comboBoxAC3DialogNormalization;
        private System.Windows.Forms.Label labelAC3DialogNormalization;
        private System.Windows.Forms.ComboBox comboBoxAC3DynamicRange;
        private System.Windows.Forms.Label labelAC3DynamicRange;
        private System.Windows.Forms.LinkLabel linkLabelDTS;
        private System.Windows.Forms.LinkLabel linkLabelFLAC;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox comboBoxSoXSettingsOutputConvertEncodingType;
        private System.Windows.Forms.CheckBox checkBoxSoXSettingsOutputConvertEncodingType;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSoxEffectsChangeDurationTarget;
        private System.Windows.Forms.RadioButton radioButtonSoXEffectsChangeTempoDuration;
        private System.Windows.Forms.CheckBox checkBoxSoXEffectsChangeTempo;
        private System.Windows.Forms.RadioButton radioButtonSoXEffectsChangeTempoWithFPS;
        private System.Windows.Forms.TextBox textBoxSoxEffectsChangeDurationSource;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.GroupBox groupBoxSoXSettings;
        private System.Windows.Forms.CheckBox checkBoxSoXSettings51MixLFE;
        private System.Windows.Forms.GroupBox groupBoxSoXSettingsMatrix;
        private System.Windows.Forms.TextBox textBoxSoxEffectsChangeTempoValue;
        private System.Windows.Forms.RadioButton radioButtonSoXEffectsChangeTempoValue;
        private System.Windows.Forms.Button buttonCancelConverting;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.GroupBox groupBoxDTSBitrate;
        private System.Windows.Forms.RadioButton radioButtonDTSBitrate150975;
        private System.Windows.Forms.RadioButton radioButtonDTSBitrate7545;



    }
}

