// ***********************************************************************************
// 
// BDAudioConverter - An GUI for Eac3to, SoX and other tools for converting audio files
// Copyright (C) 2012 Adrian Kauz, akauz@3dfx.ch
// Version: 0.2.0
// 
// This program is free software; you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation; either version 3 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program; if not, see <http://www.gnu.org/licenses/>.
// 
// ***********************************************************************************

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MediaInfoLib;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using BDAudioConverterGUI.Classes;
using System.Collections;
using System.Threading;
using System.Management;
using System.Xml;

namespace BDAudioConverterGUI
{
    partial class Form_Main : Form
    {
        public DataTable dt;
        public String sProgrammPath = Application.StartupPath;
        public List<AudioFile> listAudioFiles = new List<AudioFile>();

        public Color ColorDataGridHeaderBackground = Color.FromArgb(70, 70, 70);
        public Color ColorDataGridHeaderForeground = Color.FromArgb(255, 255, 255);
        public Color ColorDataGridBackground = Color.FromArgb(20, 20, 20); //Dunkelgrau
        public Color ColorDataGridForeground = Color.FromArgb(200,225,255);
        public Color ColorDataGridGrid = Color.FromArgb(10, 10, 10); //Dunkelgrau
        public Color ColorDataGridAlternatingRows = Color.FromArgb(30, 30, 30);
        public Color ColorDataGridSelectionBackColor = Color.FromArgb(53, 68, 77);
        public Color ColorDataGridSelectionForeColor = Color.FromArgb(255, 255, 255);

        public Form_Main()
        {
            InitializeComponent();
            InitializeDatatable();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Generiere Hauptmenu
            //******************** 
            MainMenu mainMenu1 = new MainMenu();

            MenuItem menuItem1 = new MenuItem();
            MenuItem menuItem2 = new MenuItem();
            MenuItem menuItem3 = new MenuItem();
            MenuItem menuItem1quit = new MenuItem();
            MenuItem menuItem3about = new MenuItem();

            menuItem1.Text = "File";
            menuItem2.Text = "Options";
            menuItem3.Text = "Info";
            menuItem1quit.Text = "Quit";
            menuItem1quit.Click +=new EventHandler(this.menuitem1quit_Click);
            menuItem3about.Text = "About BDAudioConverterGUI...";
            menuItem3about.Click +=new EventHandler(this.menuItem3about_Click);

            mainMenu1.MenuItems.Add(menuItem1);
            //mainMenu1.MenuItems.Add(menuItem2);
            mainMenu1.MenuItems.Add(menuItem3);
            menuItem1.MenuItems.Add(menuItem1quit);
            menuItem3.MenuItems.Add(menuItem3about);

            Menu = mainMenu1;

            //Setze Standartwerte
            comboBoxMP3OptionsChannelModes.Text = "Joint Stereo";
            comboBoxSoXSettingsMainBufferSize.Text = "8192";
            comboBoxSoXSettingsDownmixProLogic.Text = "Dolby Surround / ProLogic I";
            comboBoxSoXSettingsInputConvertAudioResolution.Text = "32";
            comboBoxSoXSettingsInputConvertEncodingType.Text = "Floating Point";
            comboBoxSoXSettingsInputConvertSamplingRate.Text = "96000";
            comboBoxAC3BitsreamInfoCentermix.Text = "-3.0 dB (default)";
            comboBoxAC3BitsreamInfoSurroundmix.Text = "-3.0 dB (default)";
            comboBoxAC3BitstreamInfoDolbySurround.Text = "not indicated (default)";
            comboBoxAC3DynamicRange.Text = "None (default)";
            comboBoxAC3DialogNormalization.Items.Add(" 0 dB");
            for (int x = 1; x <= 30; x++)
            {
                comboBoxAC3DialogNormalization.Items.Add("-" + x + " dB");
            }
            comboBoxAC3DialogNormalization.Items.Add("-31 dB (default)");
            comboBoxAC3DialogNormalization.Text = "-31 dB (default)";
            loadSettings();
        }



        //****************************************************************************************************
        // Drag&Drop DataGridView
        //****************************************************************************************************
        private void dataGridView1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void dataGridView1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            foreach(String sFullPath in files)
            {
                String sFileExtension = System.IO.Path.GetExtension(sFullPath).ToLower();

                if (sFileExtension == ".ac3" || sFileExtension == ".ddp" || sFileExtension == ".dts" || sFileExtension == ".dtshd" ||
                    sFileExtension == ".flac" || sFileExtension == ".wav")
                {
                    MediaInfo MI = new MediaInfo();
                    AudioFile af = new AudioFile();

                    MI.Open(sFullPath);
                 
                    af.bAllowToConvert = true;
                    af.sBitDepth = MI.Get(StreamKind.Audio, 0, "BitDepth", InfoKind.Text, InfoKind.Name);
                    af.sBitrate = MI.Get(StreamKind.Audio, 0, "BitRate", InfoKind.Text, InfoKind.Name);
                    af.sChannels = MI.Get(StreamKind.Audio, 0, "Channels", InfoKind.Text, InfoKind.Name);
                    af.sCodec = MI.Get(StreamKind.Audio, 0, "Codec", InfoKind.Text, InfoKind.Name);
                    af.sDuration = MI.Get(StreamKind.Audio, 0, "Duration/String", InfoKind.Text, InfoKind.Name);
                    af.sFileName = System.IO.Path.GetFileNameWithoutExtension(sFullPath);
                    af.sFullFileName = System.IO.Path.GetFileName(sFullPath);
                    af.sPath = System.IO.Path.GetDirectoryName(sFullPath);
                    af.sSamplingRate = MI.Get(StreamKind.Audio, 0, "SamplingRate", InfoKind.Text, InfoKind.Name);
                    af.sDescription = af.sCodec + " - " + af.sChannels + " Channel - " + Convert.ToInt32(af.sBitrate) / 1000 + " Kbps - " + af.sSamplingRate + " Hz - " + af.sDuration;
                    listAudioFiles.Add(af);
                    
                    MI.Close();

                    dt.Rows.Add(af.bAllowToConvert, af.sFullFileName, af.sDescription);
                    buttonStartConverting.Enabled = true;
                }
            }
        }
        

        //****************************************************************************************************
        // Datatable & DataGridView
        //****************************************************************************************************
        private void InitializeDatatable()
        {
            //Erzeuge zuerst ein Datatable
            dt = new DataTable("Filebox");

            //Die Anzahl Spalten, deren Name etc. können hier in diesen Arrays verändert werden
            String[] sColumnName =  { " ",       "Filename", "Description" };
            Boolean[] bTypeOfBool = { true,      false,      false,        };
            int[] iWidth =          { 25,        380,        325,          };
            Boolean[] bReadOnly =   { false,     true,       true,         };
            int[] iPaddingLeft =    { 0,         3,          3,            };
            Boolean[] bSortable =   { false,     false,      false,        };
            
            //Erzeuge ein Array für die Spalten
            DataColumn[] Column = new DataColumn[sColumnName.Length];

            //Erzeuge die Spalten
            for (int x = 0; x < sColumnName.Length; x++)
            {
                //Zweimal "if" ist besser als "if, else", da
                if ( bTypeOfBool[x])
                {
                    Column[x] = new DataColumn(sColumnName[x], typeof(Boolean));
                }
                else
                {
                    Column[x] = new DataColumn(sColumnName[x], typeof(String)); 
                }

                dt.Columns.Add(Column[x]);             
            }


            //Verknüpfe Datatable mit dataGridView1
            dataGridViewMain.DataSource = dt;

            //Setze Eigenschaften des DataGridViews
            //*************************************
            //Farben
            dataGridViewMain.BackgroundColor = ColorDataGridBackground;
            dataGridViewMain.ForeColor = ColorDataGridForeground;
            dataGridViewMain.GridColor = ColorDataGridGrid;
            dataGridViewMain.AlternatingRowsDefaultCellStyle.BackColor = ColorDataGridAlternatingRows;
            dataGridViewMain.DefaultCellStyle.BackColor = ColorDataGridBackground;
            dataGridViewMain.DefaultCellStyle.SelectionBackColor = ColorDataGridSelectionBackColor;
            dataGridViewMain.DefaultCellStyle.SelectionForeColor = ColorDataGridSelectionForeColor;
            dataGridViewMain.ColumnHeadersDefaultCellStyle.BackColor = ColorDataGridHeaderBackground;
            dataGridViewMain.ColumnHeadersDefaultCellStyle.ForeColor = ColorDataGridHeaderForeground;
            dataGridViewMain.AdvancedColumnHeadersBorderStyle.All = DataGridViewAdvancedCellBorderStyle.Single;

            //dataGridViewMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            //dataGridViewMain.ColumnHeadersHeight = 40;
            dataGridViewMain.AllowUserToOrderColumns = false;
            dataGridViewMain.AllowUserToAddRows = false;
            dataGridViewMain.AllowUserToResizeColumns = false;
            dataGridViewMain.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewMain.DefaultCellStyle.Font = new Font("Arial", FontHeight = 8);
            dataGridViewMain.RowTemplate.Height = 18;
            dataGridViewMain.RowTemplate.Resizable = DataGridViewTriState.False;

            for (int x = 0; x < sColumnName.Length; x++)
            {
                dataGridViewMain.Columns[x].DefaultCellStyle.Padding = new Padding(iPaddingLeft[x], 0, 0, 0);
                dataGridViewMain.Columns[x].ReadOnly = bReadOnly[x];
                dataGridViewMain.Columns[x].Width = iWidth[x];

                if (bSortable[x])
                {
                    dataGridViewMain.Columns[x].SortMode = DataGridViewColumnSortMode.Automatic;
                }
                else
                {
                    dataGridViewMain.Columns[x].SortMode = DataGridViewColumnSortMode.NotSortable;
                }
            }
        }



        //****************************************************************************************************
        // ToolStripMenuItem
        //****************************************************************************************************
        private void clearListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dt.Clear();
            listAudioFiles.Clear();
            buttonStartConverting.Enabled = false;
        }

        private void checkAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int x = 0 ; x < dt.Rows.Count; x++)
            {
                dt.Rows[x][0] = true;
                listAudioFiles[x].bAllowToConvert = true;
            }
        }

        private void checkNoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < dt.Rows.Count; x++)
            {
                dt.Rows[x][0] = false;
                listAudioFiles[x].bAllowToConvert = false;
            }
        }

        private void removeUncheckedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Zuerst wird die Tabelle aktualisiert, damit wirklich alle Änderungen im DataGridview übernommen werden.
            //Hierfür reicht es aus den Fokus auf eine andere Zelle auszurichten.
            this.dataGridViewMain.CurrentCell = dataGridViewMain.Rows[0].Cells[0];

            int iRows = dt.Rows.Count;
            for (int x = 0; x < iRows; x++)
            {
                if (Convert.ToBoolean(dt.Rows[x][0]) == false)
                {
                    dt.Rows[x].Delete();
                    listAudioFiles.RemoveAt(x);
                    
                    //Da die Zeile gelöscht wurde, rückt automatisch nie nächste Zeile nach.
                    //Damit diese auch wieder bearbeitet wird, decrementieren wir "x" um eine Stelle
                    x--;
                    //Wird eine Zeile gelöscht, so ändert sich auch die Anzahl Zeilen in der Tabelle
                    iRows--;
                }
            }
        }

        //****************************************************************************************************
        // Conversations Routine
        //****************************************************************************************************

        private void buttonStartConverting_Click(object sender, EventArgs e)
        {
            //Zuerst werden die Checkboxen aus der Liste neu eingelesen. Somit werden alle Änderung berücksichtigt
            dataGridViewMain.CurrentCell = dataGridViewMain.Rows[0].Cells[0];
            for (int x = 0; x < listAudioFiles.Count; x++)
            {
                listAudioFiles[x].bAllowToConvert = Convert.ToBoolean(dt.Rows[x][0]);
            }

            buttonCancelConverting.Enabled = true;
            FillCommandArray();
            backgroundWorker.RunWorkerAsync();
        }

        private void buttonCancelConverting_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to cancel the running conversion?", "Warning!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                backgroundWorker.CancelAsync();
            } 
        }
        
        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            foreach (AudioFile af in listAudioFiles)
            {
                if (!backgroundWorker.CancellationPending && af.bAllowToConvert)
                {
                    //Write Cmd-File
                    StreamWriter myFile = new StreamWriter("convert.cmd");
                    myFile.Write(af.sCommandoLine);
                    myFile.Close();

                    //Start Process
                    Process myProcess = new Process();
                    try
                    {
                        myProcess.StartInfo.FileName = sProgrammPath + "\\convert.cmd";
                        myProcess.StartInfo.CreateNoWindow = false;
                        myProcess.StartInfo.UseShellExecute = true;
                        myProcess.StartInfo.WindowStyle = ProcessWindowStyle.Minimized;
                        myProcess.StartInfo.RedirectStandardOutput = false;
                        myProcess.StartInfo.RedirectStandardInput = false;
                        myProcess.Start();
                        int iProcessPID = Convert.ToInt32(myProcess.Id);
                        Console.WriteLine(iProcessPID);
                        while (!myProcess.HasExited)
                        {
                            if (backgroundWorker.CancellationPending)
                            {
                                KillChildren(iProcessPID);
                            }
                            Thread.Sleep(250);
                        }
                        myProcess.Close();
                        //Report to the form, that a new convertion from a file is done
                        backgroundWorker.ReportProgress(1);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                }
            }
        }

        private void KillChildren(int parentPid)
        {
            foreach (var pid in
                from ManagementBaseObject m in new ManagementObjectSearcher("select ProcessId from Win32_Process where ParentProcessId=" + parentPid).Get()
                select Convert.ToInt32(m["ProcessId"]))
                KillChildren(pid);
            try
            {
                Process.GetProcessById(parentPid).Kill();
            }
            catch (ArgumentException)
            {
                //Process already exited
            }
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            buttonCancelConverting.Enabled = false;
            buttonStartConverting.Enabled = true;
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Boolean bUncheckDone = false;
            for (int x = 0; x < dt.Rows.Count; x++)
            {
                if (Convert.ToBoolean(dt.Rows[x][0]) && !bUncheckDone)
                {
                    dt.Rows[x][0] = false;
                    listAudioFiles[x].bAllowToConvert = false;
                    bUncheckDone = true;
                }
            }
        }

        private void FillCommandArray()
        {
            for (int x = 0; x < listAudioFiles.Count; x++)
            {
                if (listAudioFiles[x].bAllowToConvert)
                {
                    String sCommand = "";
                    if (listAudioFiles[x].sCodec == "FLAC" | listAudioFiles[x].sCodec == "PCM")
                    {
                        //Generiere SoX-Instanz
                        sCommand += generateInputCommand(x);
                    }
                    else
                    {
                        //Generiere eac3to-Instanz
                        sCommand += generateInputCommand(x);
                    }
                    //Generiere SoX-Instanz für Stream-Aufbereitung vor dem Editieren
                    if (checkBoxSoXSettingsInputConvertAudioResolution.Checked || checkBoxSoXSettingsInputConvertEncodingType.Checked ||
                        checkBoxSoXSettingsInputConvertSamplingRate.Checked)
                    {
                        sCommand += generateCmdSoXPrepareStreamBeforeEditting();
                    }
                    //Generiere SoX-Instanz für Pitch & Tempoänderungen
                    if (checkBoxSoXEffectsChangeTempo.Checked || checkBoxSoXEffectsPitch.Checked || checkBoxSoXSettingsGain.Checked)
                    {
                        sCommand += generateCmdSoXPitchNTempo();
                    }
                    //Generiere SoX-Instanz für Downmix                
                    if (checkBoxSoXSettingsDownmixActivate.Checked)
                    {
                        sCommand += generateCmdSoXDownmix();
                    }
                    //Generiere SoX-Instanz für Stream-Aufbereitung vor dem Enkodieren
                    if (checkBoxSoXSettingsOutputConvertAudioResolution.Checked || checkBoxSoXSettingsOutputConvertEncodingType.Checked ||
                        checkBoxSoXSettingsOutputConvertSamplingRate.Checked)
                    {
                        sCommand += generateCmdSoXPrepareStreamBeforeEncoding();
                    }
                    //Generiere Cmd-Befehl für Output
                    sCommand += generateOutputCommand(tabControl1.SelectedTab.Text, listAudioFiles[x].sPath + "\\" + listAudioFiles[x].sFileName);
                    //Then write the corresponding commandoline to the value
                    listAudioFiles[x].sCommandoLine = sCommand;
                }
            }
        }
        

        // Konfiguriere Input
        //*******************
        private String generateInputCommand(int x)
        {
            String sGenerateInputCommand = "";
            if (listAudioFiles[x].sCodec == "FLAC" | listAudioFiles[x].sCodec == "PCM")
            {
                //SoX Programm Path
                sGenerateInputCommand += "\"" + sProgrammPath + "\\sox\\sox.exe\"";
                //Buffer
                sGenerateInputCommand += " --input-buffer " + comboBoxSoXSettingsMainBufferSize.Text;
                //Input Typ
                if (listAudioFiles[x].sCodec == "FLAC")
                {
                    sGenerateInputCommand += " --type flac";
                }
                else
                {
                    sGenerateInputCommand += " --type wav";
                }
                //Input File
                sGenerateInputCommand += " \"" + listAudioFiles[x].sPath + "\\" + listAudioFiles[x].sFullFileName + "\"";
                //Output Typ
                sGenerateInputCommand += " --type wav";
                //Output als Stream
                sGenerateInputCommand += " -";
            }
            else
            {
                //Eac3to.exe Path
                sGenerateInputCommand += "\"" + sProgrammPath + "\\eac3to\\eac3to.exe\"";
                //Imput File
                sGenerateInputCommand += " \"" + listAudioFiles[x].sPath + "\\" + listAudioFiles[x].sFullFileName + "\"";
                //Output File
                sGenerateInputCommand += " stdout.wav";
                //Downmix
                if (checkBoxEac3toSettingsConvertChannels.Checked)
                {
                    if (radioButtonEac3toSettingsConvertToStereo.Checked)
                    {
                        sGenerateInputCommand += " -down2 -mixlfe";
                    }

                    if (radioButtonEac3toSettingsConvertTo51.Checked)
                    {
                        sGenerateInputCommand += " -down6";
                    }
                }
                //Gebe Audiostream als 32-bit Integer aus
                sGenerateInputCommand += " -down32";
                //Dialog normalization
                if (checkBoxEac3toSettingsDialogNormalization.Checked)
                {
                    sGenerateInputCommand += " -keepDialnorm";
                }
            }
            return sGenerateInputCommand;
        }

        // Konfiguriere SoX Stream-Aufbereitung vor dem Editieren
        //*******************************************************
        private String generateCmdSoXPrepareStreamBeforeEditting()
        {
            String sGenerateSoXCommand = "";
            //SoX Programm Path
            sGenerateSoXCommand += " | \"" + sProgrammPath + "\\sox\\sox.exe\"";
            //Buffer
            sGenerateSoXCommand += " --input-buffer " + comboBoxSoXSettingsMainBufferSize.Text;
            //Input Typ
            sGenerateSoXCommand += " --type wav";
            //Da SoX ein Stream empfängt und keine Datei, wird nun so lange convertiert, bis der Stream zu Ende ist
            sGenerateSoXCommand += " --ignore-length";
            //Input ist ein Stream
            sGenerateSoXCommand += " -";
            //Setze Auflösung des Output-Streams
            if (checkBoxSoXSettingsInputConvertAudioResolution.Checked)
            {
                sGenerateSoXCommand += " --bits " + comboBoxSoXSettingsInputConvertAudioResolution.Text;
            }
            //Setze Encoding Typ des Output-Streams
            if (checkBoxSoXSettingsInputConvertEncodingType.Checked)
            {
                switch (comboBoxSoXSettingsInputConvertEncodingType.Text)
                {
                    case "Signed Integer":
                        sGenerateSoXCommand += " --encoding signed-integer";
                        break;
                    case "Unsigned Integer":
                        sGenerateSoXCommand += " --encoding unsigned-integer";
                        break;
                    case "Floating Point":
                        sGenerateSoXCommand += " --encoding floating-point";
                        break;
                    default:
                        break;
                }
            }
            //Setze Sampling Rate des Ouput-Streams
            if (checkBoxSoXSettingsInputConvertSamplingRate.Checked)
            {
                sGenerateSoXCommand += " --rate " + comboBoxSoXSettingsInputConvertSamplingRate.Text;
            }
            //Output Typ
            sGenerateSoXCommand += " --type wav";
            //Output als Stream
            sGenerateSoXCommand += " -";
            
            return sGenerateSoXCommand;
        }

        // Konfiguriere SoX für Frame Rate Conversation, Pitch etc.
        //*********************************************************
        private String generateCmdSoXPitchNTempo()
        {
            String sGenerateSoXCommand = "";
            //SoX Programm Path
            sGenerateSoXCommand += " | \"" + sProgrammPath + "\\sox\\sox.exe\"";
            //Buffer
            sGenerateSoXCommand += " --input-buffer " + comboBoxSoXSettingsMainBufferSize.Text;
            //Input Typ
            sGenerateSoXCommand += " --type wav";
            //Da SoX ein Stream empfängt und keine Datei, wird nun so lange convertiert, bis der Stream zu Ende ist
            sGenerateSoXCommand += " --ignore-length";
            //Input ist ein Stream
            sGenerateSoXCommand += " -";
            //Output Typ
            sGenerateSoXCommand += " --type wav";
            //Output als Stream
            sGenerateSoXCommand += " -";
            //Change Tempo (without changing Pitch)
            if (checkBoxSoXEffectsChangeTempo.Checked)
            {
                if (radioButtonSoXEffectsChangeTempoWithFPS.Checked)
                {
                    double dSource = Convert.ToDouble(textBoxSoxEffectsChangeFrameRateSource.Text);
                    double dTarget = Convert.ToDouble(textBoxSoxEffectsChangeFrameRateTarget.Text);
                    sGenerateSoXCommand += " tempo " + Convert.ToString(Math.Round(dTarget / dSource, 7));
                }
                if (radioButtonSoXEffectsChangeTempoDuration.Checked)
                {
                    double dSource = convertTime(textBoxSoxEffectsChangeDurationSource.Text);
                    double dTarget = convertTime(textBoxSoxEffectsChangeDurationTarget.Text);
                    sGenerateSoXCommand += " tempo " + Convert.ToString(Math.Round(dSource / dTarget, 7));
                    
                }
                if (radioButtonSoXEffectsChangeTempoValue.Checked)
                {
                    sGenerateSoXCommand += " tempo " + textBoxSoxEffectsChangeTempoValue.Text;
                }

            }
            //Change Pitch
            if (checkBoxSoXEffectsPitch.Checked)
            {
                sGenerateSoXCommand += " pitch " + Convert.ToDouble(textBoxSoXSettingsPitch.Text)*10;
            }
            //Change Volume
            if (checkBoxSoXSettingsGain.Checked)
            {
                sGenerateSoXCommand += " gain -l " + textBoxSoXSettingsGain.Text;
            }

            return sGenerateSoXCommand;
        }

        private double convertTime(String sTime)
        {
            int iCounter = 0;
            String sHour = "";
            String sMinutes = "";
            String sSeconds = "";
            String sMilliseconds = "";
            double dMillisecondsTotal = 0;
            foreach (char cChar in sTime.ToCharArray())
            {
                if (Char.IsNumber(cChar))
                {
                    switch (iCounter)
                    {
                        case 0: case 1:
                            sHour += cChar;
                            break;
                        case 3: case 4:
                            sMinutes += cChar;
                            break;
                        case 6: case 7:
                            sSeconds += cChar;
                            break;
                        case 9: case 10: case 11:
                            sMilliseconds += cChar;
                            break;
                        default:
                            break;
                    }
                }
                iCounter++;
            }
            dMillisecondsTotal = Convert.ToDouble(sMilliseconds) + Convert.ToDouble(sSeconds) * 1000 +
                                 Convert.ToDouble(sMinutes) * 60000 + Convert.ToDouble(sHour) * 3600000;

            return dMillisecondsTotal;
        }

        // Konfiguriere SoX für 5.1 Downmix
        //*********************************
        private String generateCmdSoXDownmix()
        {
            String sGenerateSoXCommand = "";
            //SoX Programm Path
            sGenerateSoXCommand += " | \"" + sProgrammPath + "\\sox\\sox.exe\"";
            //Buffer
            sGenerateSoXCommand += " --input-buffer " + comboBoxSoXSettingsMainBufferSize.Text;
            //Input Typ
            sGenerateSoXCommand += " --type wav";
            //Da SoX ein Stream empfängt und keine Datei, wird nun so lange convertiert, bis der Stream zu Ende ist
            sGenerateSoXCommand += " --ignore-length";
            //Input ist ein Stream
            sGenerateSoXCommand += " -";
            //Output Typ
            sGenerateSoXCommand += " --type wav";
            //Output als Stream
            sGenerateSoXCommand += " -";
            //SoX Remix Befehl
            sGenerateSoXCommand += " remix -m";
            //Remix für Kanal 1 (Links)
            sGenerateSoXCommand += " 1v" + textBoxSoXSettings51Matrix00.Text; //L
            sGenerateSoXCommand += ",3v" + textBoxSoXSettings51Matrix02.Text; //C
            sGenerateSoXCommand += ",4v" + textBoxSoXSettings51Matrix03.Text; //LFE
            sGenerateSoXCommand += ",5v" + textBoxSoXSettings51Matrix04.Text; //SL
            sGenerateSoXCommand += ",6v" + textBoxSoXSettings51Matrix05.Text; //SR
            //Remix für Kanal 2 (Rechts)
            sGenerateSoXCommand += " 2v" + textBoxSoXSettings51Matrix11.Text; //R
            sGenerateSoXCommand += ",3v" + textBoxSoXSettings51Matrix12.Text; //C
            sGenerateSoXCommand += ",4v" + textBoxSoXSettings51Matrix13.Text; //LFE
            sGenerateSoXCommand += ",5v" + textBoxSoXSettings51Matrix14.Text; //SL
            sGenerateSoXCommand += ",6v" + textBoxSoXSettings51Matrix15.Text; //SR

            return sGenerateSoXCommand;
        }

        // Konfiguriere SoX Stream-Aufbereitung vor dem Enkodieren
        //********************************************************
        private String generateCmdSoXPrepareStreamBeforeEncoding()
        {
            String sGenerateSoXCommand = "";
            //SoX Programm Path
            sGenerateSoXCommand += " | \"" + sProgrammPath + "\\sox\\sox.exe\"";
            //Buffer
            sGenerateSoXCommand += " --input-buffer " + comboBoxSoXSettingsMainBufferSize.Text;
            //Input Typ
            sGenerateSoXCommand += " --type wav";
            //Da SoX ein Stream empfängt und keine Datei, wird nun so lange convertiert, bis der Stream zu Ende ist
            sGenerateSoXCommand += " --ignore-length";
            //Input ist ein Stream
            sGenerateSoXCommand += " -";
            //Setze Auflösung des Output-Streams
            if (checkBoxSoXSettingsOutputConvertAudioResolution.Checked)
            {
                sGenerateSoXCommand += " --bits " + comboBoxSoXSettingsOutputConvertAudioResolution.Text;
            }
            //Setze Encoding Typ des Output-Streams
            if (checkBoxSoXSettingsOutputConvertEncodingType.Checked)
            {
                switch (comboBoxSoXSettingsOutputConvertEncodingType.Text)
                {
                    case "Signed Integer":
                        sGenerateSoXCommand += " --encoding signed-integer";
                        break;
                    case "Unsigned Integer":
                        sGenerateSoXCommand += " --encoding unsigned-integer";
                        break;
                    case "Floating Point":
                        sGenerateSoXCommand += " --encoding floating-point";
                        break;
                    default:
                        break;
                }
            }
            //Setze Sampling Rate des Ouput-Streams
            if (checkBoxSoXSettingsOutputConvertSamplingRate.Checked)
            {
                sGenerateSoXCommand += " --rate " + comboBoxSoXSettingsOutputConvertSamplingRate.Text;
            }
            //Output Typ
            sGenerateSoXCommand += " --type wav";
            //Output als Stream
            sGenerateSoXCommand += " -";

            return sGenerateSoXCommand;
        }

        // Konfiguriere Output
        //*************************************************************************
        private String generateOutputCommand(String sTabTitle, String sOutputFileName)
        {
            String sOutputCommand = "";
            switch (sTabTitle)
            {
                case "AAC":
                    {
                        // Konfiguriere AAC Output (Nero AAC Encoder)
                        //*******************************************
                        sOutputCommand += " | \"" + sProgrammPath + "\\neroaacenc\\neroaacenc.exe\"";

                        if (radioButtonAACQuality.Checked)
                        {
                            sOutputCommand += " -q " + Convert.ToDouble(trackBarAACQuality.Value) / 100;
                        }
                        if (radioButtonAACBitrate.Checked)
                        {
                            if (checkBoxAACRestrictEncoder.Checked)
                            {
                                sOutputCommand += " -cbr " + trackBarAACBitrate.Value * 8000;
                            }
                            else
                            {
                                sOutputCommand += " -br " + trackBarAACBitrate.Value * 8000;
                            }
                        }
                        switch (comboBoxAACProfiles.Text)
                        {
                            case "LC":
                                sOutputCommand += " -lc";
                                break;
                            case "HC":
                                sOutputCommand += " -hc";
                                break;
                            case "HEV2":
                                sOutputCommand += " -hev2";
                                break;
                            default:
                                break;
                        }
                        if (checkBoxAACRTPHinttrack.Checked)
                        {
                            sOutputCommand += " -hinttrack";
                        }

                        sOutputCommand += " -ignorelength";
                        //Input ist ein Stream
                        sOutputCommand += " -if -";
                        //Output Typ ist eine Datei *.M4A
                        sOutputCommand += " -of \"" + sOutputFileName + ".m4a\"";
                    }
                    break;
                case "AC3":
                    {
                        // Konfiguriere AC3 Output (Aften)
                        //********************************
                        sOutputCommand += " | \"" + sProgrammPath + "\\aften\\aften.exe\"";
                        //Aften Infos
                        sOutputCommand += " -v 2";
                        //Da Aften ein Stream empfängt, wird so lange encodiert, bis der Stream zu Ende ist
                        sOutputCommand += " -readtoeof 1";
                        //Feste Bitrate
                        sOutputCommand += " -b " + trackBarAC3Bitrate.Value * 32;
                        //Exponent strategy search size
                        sOutputCommand += " -exps " + trackBarAC3ExponentStrategySearchSize.Value;
                        //Center mix level
                        switch (comboBoxAC3BitsreamInfoCentermix.Text)
                        {
                            case "-3.0 dB (default)":
                                sOutputCommand += " -cmix 0";
                                break;
                            case "-4.5 dB":
                                sOutputCommand += " -cmix 1";
                                break;
                            case "-6.0 dB":
                                sOutputCommand += " -cmix 2";
                                break;
                            default:
                                break;
                        }
                        //Surround mix level
                        switch (comboBoxAC3BitsreamInfoSurroundmix.Text)
                        {
                            case "-3.0 dB (default)":
                                sOutputCommand += " -smix 0";
                                break;
                            case "-6.0 dB":
                                sOutputCommand += " -smix 1";
                                break;
                            case "0":
                                sOutputCommand += " -smix 2";
                                break;
                            default:
                                break;
                        }
                        //Dolby Surround mode
                        switch (comboBoxAC3BitstreamInfoDolbySurround.Text)
                        {
                            case "Not indicated (default)":
                                sOutputCommand += " -dsur 0";
                                break;
                            case "Not Dolby surround encoded":
                                sOutputCommand += " -dsur 1";
                                break;
                            case "Dolby surround encoded":
                                sOutputCommand += " -dsur 2";
                                break;
                            default:
                                break;
                        }
                        //Dynamic Range Compression profile
                        switch (comboBoxAC3DynamicRange.Text)
                        {
                            case "Film Light":
                                sOutputCommand += " -dynrng 0";
                                break;
                            case "Film Standard":
                                sOutputCommand += " -dynrng 1";
                                break;
                            case "Music Light":
                                sOutputCommand += " -dynrng 2";
                                break;
                            case "Music Standard":
                                sOutputCommand += " -dynrng 3";
                                break;
                            case "Speech":
                                sOutputCommand += " -dynrng 4";
                                break;
                            case "None (default)":
                                sOutputCommand += " -dynrng 5";
                                break;
                            default:
                                break;
                        }
                        //Dialog normalization 
                        sOutputCommand += " -dnorm ";
                        foreach (char text in comboBoxAC3DialogNormalization.Text.ToCharArray())
                        {
                            if (Char.IsNumber(text))
                            {
                                sOutputCommand += text.ToString();
                            }
                        }
                        //Input Typ ist ein Stream
                        sOutputCommand += " -";
                        //Output Typ ist eine Datei *.AC3
                        if (System.IO.File.Exists(sOutputFileName + ".ac3"))
                        {
                            sOutputCommand += " \"" + sOutputFileName + "_new.ac3\"";
                        }
                        else
                        {
                            sOutputCommand += " \"" + sOutputFileName + ".ac3\"";
                        }
                    }
                    break;
                case "DTS":
                    {
                        // Konfiguriere DTS Output (dcaenc)
                        //*********************************
                        sOutputCommand += " | \"" + sProgrammPath + "\\dcaenc\\dcaenc.exe\"";
                        //Input ist ein Stream
                        sOutputCommand += " -i -";
                        //Output is a file
                        if (System.IO.File.Exists(sOutputFileName + ".dts"))
                        {
                            sOutputCommand += " -o \"" + sOutputFileName + "_new.dts\"";
                        }
                        else
                        {
                            sOutputCommand += " -o \"" + sOutputFileName + ".dts\"";
                        }
                        //Ignore input length
                        sOutputCommand += " -l";
                        //Set bitrate
                        if (radioButtonDTSBitrate7545.Checked)
                        {
                            sOutputCommand += " -b 754.5";
                        }
                        if (radioButtonDTSBitrate150975.Checked)
                        {
                            sOutputCommand += " -b 1509.75";
                        }
                    }
                    break;
                case "FLAC":
                    {
                        // Konfiguriere FLAC Output (SoX)
                        //*******************************
                        sOutputCommand += " | \"" + sProgrammPath + "\\sox\\sox.exe\"";
                        //Buffer
                        sOutputCommand += " --input-buffer " + comboBoxSoXSettingsMainBufferSize.Text;
                        //SoX Infos
                        sOutputCommand += " -S";
                        //Input Typ
                        sOutputCommand += " --type wav";
                        //Da SoX ein Stream empfängt und keine Datei, wird nun so lange convertiert, bis der Stream zu Ende ist
                        sOutputCommand += " --ignore-length";
                        //Input ist ein Stream
                        sOutputCommand += " -";
                        //Output Typ
                        sOutputCommand += " --type flac";
                        //FLAC Compressions-Level
                        sOutputCommand += " -C " + trackBarFLACCompression.Value;
                        //Output Typ ist eine Datei *.FLAC
                        if (System.IO.File.Exists(sOutputFileName + ".flac"))
                        {
                            sOutputCommand += " \"" + sOutputFileName + "_new.flac\"";
                        }
                        else
                        {
                            sOutputCommand += " \"" + sOutputFileName + ".flac\"";
                        }
                    }
                    break;

                case "MP3":
                    {
                        // Konfiguriere MP3 Output (LAME)
                        //*******************************
                        sOutputCommand += " | \"" + sProgrammPath + "\\lame\\lame.exe\"";
                        //Aktiviere Encoder-Infos
                        sOutputCommand += " --verbose";
                        //Channel Modus
                        switch (comboBoxMP3OptionsChannelModes.Text)
                        {
                            case "Mono":
                                sOutputCommand += " -m m";
                                break;
                            case "Forced L/R Stereo":
                                sOutputCommand += " -m s";
                                break;
                            case "Joint Stereo":
                                sOutputCommand += " -m j";
                                break;
                            case "Forced Mid/Side Stereo":
                                sOutputCommand += " -m f";
                                break;
                            case "Dual Channel":
                                sOutputCommand += " -m d";
                                break;
                            default:
                                break;
                        }

                        if (radioButtonMP3Quality.Checked)
                        {
                            sOutputCommand += " -V " + (10 - trackBarMP3Quality.Value);
                        }

                        if (radioButtonMP3Bitrate.Checked)
                        {
                            if (checkBoxMP3RestrictEncoder.Checked)
                            {
                                sOutputCommand += " --abr " + trackBarMP3Bitrate.Value * 8;
                            }
                            else
                            {
                                sOutputCommand += " -b " + trackBarMP3Bitrate.Value * 8;
                            }
                        }

                        //Aktiviere CRC Error Protection
                        if (checkBoxMP3OptionsErrorProtection.Checked)
                        {
                            sOutputCommand += " -p";
                        }
                        //Input Typ ist ein Stream
                        sOutputCommand += " -";
                        //Output Typ ist eine Datei *.MP3
                        if (System.IO.File.Exists(sOutputFileName + ".mp3"))
                        {
                            sOutputCommand += " \"" + sOutputFileName + "_new.mp3\"";
                        }
                        else
                        {
                            sOutputCommand += " \"" + sOutputFileName + ".mp3\"";
                        }

                    }
                    break;
                case "WAV":
                    {
                        // Konfiguriere WAV/AIF Output (SoX)
                        //**********************************
                        sOutputCommand += " | \"" + sProgrammPath + "\\sox\\sox.exe\"";
                        //Buffer
                        sOutputCommand += " --input-buffer " + comboBoxSoXSettingsMainBufferSize.Text;
                        //SoX Infos
                        sOutputCommand += " -S";
                        //Input Typ
                        sOutputCommand += " -t wav";
                        //Da SoX ein Stream empfängt und keine Datei, wird nun so lange convertiert, bis der Stream zu Ende ist
                        sOutputCommand += " --ignore-length";
                        //Input ist ein Stream
                        sOutputCommand += " -";
                        if (radioButtonWAVOutputFormatAIFF.Checked)
                        {
                            //Output Typ
                            sOutputCommand += " -t aif";
                            //Output Typ ist eine Datei *.AIF
                            if (System.IO.File.Exists(sOutputFileName + ".aif"))
                            {
                                sOutputCommand += " \"" + sOutputFileName + "_new.aif\"";
                            }
                            else
                            {
                                sOutputCommand += " \"" + sOutputFileName + ".aif\"";
                            }
                        }
                        if (radioButtonWAVOutputFormatWAV.Checked)
                        {
                            //Output Typ
                            sOutputCommand += " -t wavpcm";
                            //Output Typ ist eine Datei *.WAV
                            if (System.IO.File.Exists(sOutputFileName + ".wav"))
                            {
                                sOutputCommand += " \"" + sOutputFileName + "_new.wav\"";
                            }
                            else
                            {
                                sOutputCommand += " \"" + sOutputFileName + ".wav\"";
                            }
                        }
                    }
                    break;
                default:
                    break;
            }
            return sOutputCommand;
        }


        //****************************************************************************************************
        // Eac3to Settings
        //****************************************************************************************************

        private void checkBoxEac3toSettingsConvertChannels_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonEac3toSettingsConvertToStereo.Enabled = !radioButtonEac3toSettingsConvertToStereo.Enabled;
            radioButtonEac3toSettingsConvertTo51.Enabled = !radioButtonEac3toSettingsConvertTo51.Enabled;
        }


        //****************************************************************************************************
        // SoX-Tap: Input
        //****************************************************************************************************

        //Convert Audio Resolution
        private void checkBoxSoXSettingsInputConvertAudioResolution_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxSoXSettingsInputConvertAudioResolution.Enabled = !comboBoxSoXSettingsInputConvertAudioResolution.Enabled;
        }
        //Convert Encoding Type
        private void checkBoxSoXSettingsInputConvertEncodingType_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxSoXSettingsInputConvertEncodingType.Enabled = !comboBoxSoXSettingsInputConvertEncodingType.Enabled;
        }
        //Convert Sampling Rate
        private void checkBoxSoXSettingsInputConvertSamplingRate_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxSoXSettingsInputConvertSamplingRate.Enabled = !comboBoxSoXSettingsInputConvertSamplingRate.Enabled;
        }


        //****************************************************************************************************
        // SoX-Tap: Effects
        //****************************************************************************************************
        
        private void checkBoxSoXEffectsChangeTempo_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonSoXEffectsChangeTempoWithFPS.Enabled = !radioButtonSoXEffectsChangeTempoWithFPS.Enabled;
            radioButtonSoXEffectsChangeTempoDuration.Enabled = !radioButtonSoXEffectsChangeTempoDuration.Enabled;
            radioButtonSoXEffectsChangeTempoValue.Enabled = !radioButtonSoXEffectsChangeTempoValue.Enabled;
            textBoxSoxEffectsChangeDurationSource.Enabled = !textBoxSoxEffectsChangeDurationSource.Enabled;
            textBoxSoxEffectsChangeDurationTarget.Enabled = !textBoxSoxEffectsChangeDurationTarget.Enabled;
            textBoxSoxEffectsChangeFrameRateSource.Enabled = !textBoxSoxEffectsChangeFrameRateSource.Enabled;
            textBoxSoxEffectsChangeFrameRateTarget.Enabled = !textBoxSoxEffectsChangeFrameRateTarget.Enabled;
            textBoxSoxEffectsChangeTempoValue.Enabled = !textBoxSoxEffectsChangeTempoValue.Enabled;
        }
        //Check Textpattern "00.000"
        private void textBoxSoxEffectsChangeFrameRateSource_Leave(object sender, EventArgs e)
        {
            CheckValue valuecheck = new CheckValue("00.000", textBoxSoxEffectsChangeFrameRateSource.Text);
            if (!valuecheck.bResult)
            {
                textBoxSoxEffectsChangeFrameRateSource.Focus();
            }
            textBoxSoxEffectsChangeFrameRateSource.BackColor = valuecheck.oColor;
            valuecheck = null;
        }
        //Check Textpattern "00.000"
        private void textBoxSoxEffectsChangeFrameRateTarget_Leave(object sender, EventArgs e)
        {
            CheckValue valuecheck = new CheckValue("00.000", textBoxSoxEffectsChangeFrameRateTarget.Text);
            if (!valuecheck.bResult)
            {
                textBoxSoxEffectsChangeFrameRateTarget.Focus();
            }
            textBoxSoxEffectsChangeFrameRateTarget.BackColor = valuecheck.oColor;
            valuecheck = null;
        }
        //Check Textpattern "[00]:[00]:[00]:[000]"
        private void textBoxSoxSettingsChangeDurationSource_Leave(object sender, EventArgs e)
        {
            CheckValue valuecheck = new CheckValue("[00]:[00]:[00]:[000]", textBoxSoxEffectsChangeDurationSource.Text);
            if (!valuecheck.bResult)
            {
                textBoxSoxEffectsChangeDurationSource.Focus();
            }
            textBoxSoxEffectsChangeDurationSource.BackColor = valuecheck.oColor;
            valuecheck = null;
        }
        //Check Textpattern "[00]:[00]:[00]:[000]"
        private void textBoxSoxSettingsChangeDurationTarget_Leave(object sender, EventArgs e)
        {
            CheckValue valuecheck = new CheckValue("[00]:[00]:[00]:[000]", textBoxSoxEffectsChangeDurationTarget.Text);
            if (!valuecheck.bResult)
            {
                textBoxSoxEffectsChangeDurationTarget.Focus();
            }
            textBoxSoxEffectsChangeDurationTarget.BackColor = valuecheck.oColor;
            valuecheck = null;
        }
        //Check Textpattern "0.0"
        private void textBoxSoxEffectsChangeTempoValue_Leave(object sender, EventArgs e)
        {
            CheckValue valuecheck = new CheckValue("0.0", textBoxSoxEffectsChangeTempoValue.Text);
            if (!valuecheck.bResult)
            {
                textBoxSoxEffectsChangeTempoValue.Focus();
            }
            textBoxSoxEffectsChangeTempoValue.BackColor = valuecheck.oColor;
            valuecheck = null;
        }
        //Check Textpattern "+/-0.0"
        private void textBoxSoXSettingsPitch_Leave(object sender, EventArgs e)
        {
            CheckValue valuecheck = new CheckValue("+/-0.0", textBoxSoXSettingsPitch.Text);
            if (!valuecheck.bResult)
            {
                textBoxSoXSettingsPitch.Focus();
            }
            textBoxSoXSettingsPitch.BackColor = valuecheck.oColor;
            valuecheck = null;
        }

        // Convert Pitch
        private void checkBoxSoXSettingsPitch_CheckedChanged(object sender, EventArgs e)
        {
            textBoxSoXSettingsPitch.Enabled = !textBoxSoXSettingsPitch.Enabled;
        }


        //****************************************************************************************************
        // SoX-Tap: Downmix
        //****************************************************************************************************

        private void checkBoxSoXSettingsDownmixActivate_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxSoXSettingsDownmixProLogic.Enabled = !comboBoxSoXSettingsDownmixProLogic.Enabled;
            groupBoxSoXSettingsMatrix.Enabled = !groupBoxSoXSettingsMatrix.Enabled;
            set51Matrix();
        }

        private void comboBoxSoXSettingsDownmixProLogic_SelectedIndexChanged(object sender, EventArgs e)
        {
            set51Matrix();
        }

        private void checkBoxSoXSettings51DownmixNormalize_CheckedChanged(object sender, EventArgs e)
        {
            set51Matrix();
        }

        private void checkBoxSoXSettings51MixLFE_CheckedChanged(object sender, EventArgs e)
        {
            set51Matrix();
        }

        private void set51Matrix()
        {
            //                                    L        R         C        LFE        SL         SR
            //--------------------------------------------------------------------------------------------------
            float[,] fMatrixProLogicI =      {{1.0f,     0.0f,     0.7071f,  0.7071f,  -1.0f,     -1.0f},     //L
                                              {0.0f,     1.0f,     0.7071f,  0.7071f,   1.0f,      1.0f}};    //R

            float[,] fMatrixProLogicII =     {{1.0f,     0.0f,     0.7071f,  0.7071f,  -0.8718f,  -0.4899f},  //L
                                              {0.0f,     1.0f,     0.7071f,  0.7071f,   0.4899f,   0.8718f}}; //R

            if (!checkBoxSoXSettings51MixLFE.Checked)
            {
                fMatrixProLogicI[0, 3] = 0;
                fMatrixProLogicI[1, 3] = 0;
                fMatrixProLogicII[0, 3] = 0;
                fMatrixProLogicII[1, 3] = 0;
            }
            
            if (comboBoxSoXSettingsDownmixProLogic.Text == "Dolby Surround / ProLogic I")
            {
                if (checkBoxSoXSettings51DownmixNormalize.Checked)
                {
                    fill51Matrix(normalizeMatrix(fMatrixProLogicI));
                }
                else
                {
                    fill51Matrix(fMatrixProLogicI);
                }
            }
            if (comboBoxSoXSettingsDownmixProLogic.Text == "Dolby ProLogic II")
            {
                if (checkBoxSoXSettings51DownmixNormalize.Checked)
                {
                    fill51Matrix(normalizeMatrix(fMatrixProLogicII));
                }
                else
                {
                    fill51Matrix(fMatrixProLogicII);
                }
            }
        }

        //Normalize Matrix => http://ac3filter.net/wiki/Mixing_matrix
        private float[,] normalizeMatrix(float[,] fMatrix)
        {
            float fNormFactor = 0;

            for (int x = 0; x < fMatrix.Length / 2; x++)
            {
                fNormFactor = fNormFactor + Math.Abs(fMatrix[0,x]);
            }

            for (int x = 0; x < fMatrix.Length / 2; x++)
            {
                for (int y = 0; y < 2; y++)
                {
                    fMatrix[y,x] = (float)Math.Round(Convert.ToDouble((fMatrix[y,x] / fNormFactor)),4);
                }
            }
                     
            return fMatrix;
        }


        private void fill51Matrix(float[,] fMatrix)
        {
            //Unpretty but works fast
            textBoxSoXSettings51Matrix00.Text = Convert.ToString(fMatrix[0, 0]); textBoxSoXSettings51Matrix10.Text = Convert.ToString(fMatrix[1, 0]);
            textBoxSoXSettings51Matrix01.Text = Convert.ToString(fMatrix[0, 1]); textBoxSoXSettings51Matrix11.Text = Convert.ToString(fMatrix[1, 1]);
            textBoxSoXSettings51Matrix02.Text = Convert.ToString(fMatrix[0, 2]); textBoxSoXSettings51Matrix12.Text = Convert.ToString(fMatrix[1, 2]);
            textBoxSoXSettings51Matrix03.Text = Convert.ToString(fMatrix[0, 3]); textBoxSoXSettings51Matrix13.Text = Convert.ToString(fMatrix[1, 3]);
            textBoxSoXSettings51Matrix04.Text = Convert.ToString(fMatrix[0, 4]); textBoxSoXSettings51Matrix14.Text = Convert.ToString(fMatrix[1, 4]);
            textBoxSoXSettings51Matrix05.Text = Convert.ToString(fMatrix[0, 5]); textBoxSoXSettings51Matrix15.Text = Convert.ToString(fMatrix[1, 5]);

            //Works slow
            /*for (int x = 0; x < 2; x++)
            {
                for (int y = 0; y < 6; y++)
                {
                    foreach (Control ctrl in groupBoxSoXSettings51Matrix.Controls)
                    {
                        if (ctrl.Name == "textBoxSoXSettingsMatrix" + x + y)
                        {
                            ctrl.Text = Convert.ToString(fMatrix[x, y]);
                        }

                        System.Console.WriteLine("textBoxSoXSettingsMatrix" + x + y);
                    }
                }
            }*/
        }


        //****************************************************************************************************
        // SoX-Tap: Output
        //****************************************************************************************************
        
        //Convert Audio Resolution
        private void checkBoxSoXSettingsOutputConvertAudioResolution_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxSoXSettingsOutputConvertAudioResolution.Enabled = !comboBoxSoXSettingsOutputConvertAudioResolution.Enabled;
        }
        //Convert Encoding Type
        private void checkBoxSoXSettingsOutputConvertEncodingType_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxSoXSettingsOutputConvertEncodingType.Enabled = !comboBoxSoXSettingsOutputConvertEncodingType.Enabled;
        }
        //Convert Sampling Rate
        private void checkBoxSoXSettingsOutputConvertSamplingRate_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxSoXSettingsOutputConvertSamplingRate.Enabled = !comboBoxSoXSettingsOutputConvertSamplingRate.Enabled;
        }


        //****************************************************************************************************
        // Output-Tap
        //****************************************************************************************************
        
        // AAC
        //----------------------------------------------------------------------------------------------------
        private void radioButtonAACQuality_CheckedChanged(object sender, EventArgs e)
        {
            enableAACBitrateOrQuality();
        }

        private void radioButtonAACBitrate_CheckedChanged(object sender, EventArgs e)
        {
            enableAACBitrateOrQuality();
        }

        private void enableAACBitrateOrQuality()
        {
            if (radioButtonAACQuality.Checked)
            {
                groupBoxAACQuality.Enabled = true;
                groupBoxAACBitrate.Enabled = false;
            }
            else
            {
                groupBoxAACQuality.Enabled = false;
                groupBoxAACBitrate.Enabled = true;
            }
        }
        
        //AAC Tooltip Quality
        private void trackBarAACQuality_Tooltip(object sender, EventArgs e)
        {
            toolTipInfo.SetToolTip(trackBarAACQuality, Convert.ToString(Convert.ToDouble(trackBarAACQuality.Value) / 100));
        }
        //AAC Tooltip Bitrate
        private void trackBarAACBitrate_Tooltip(object sender, EventArgs e)
        {
            toolTipInfo.SetToolTip(trackBarAACBitrate, trackBarAACBitrate.Value * 8 + " Kbit/s");
        }

        // AC3
        //----------------------------------------------------------------------------------------------------
        //AC3 Tooltip Bitrate
        private void trackBarAC3Bitrate_Tooltip(object sender, EventArgs e)
        {
            toolTipInfo.SetToolTip(trackBarAC3Bitrate, Convert.ToString(trackBarAC3Bitrate.Value * 32) + " Kbits/s");

        }
        //AC3 Tooltip Exponent Strategy Search Size
        private void trackBarAC3ExponentStrategySearchSize_Tooltip(object sender, EventArgs e)
        {
            toolTipInfo.SetToolTip(trackBarAC3ExponentStrategySearchSize, Convert.ToString(trackBarAC3ExponentStrategySearchSize.Value));

        }

        // MP3
        //----------------------------------------------------------------------------------------------------
        private void radioButtonMP3Quality_CheckedChanged(object sender, EventArgs e)
        {
            enableMP3BitrateOrQuality();
        }

        private void radioButtonMP3Bitrate_CheckedChanged(object sender, EventArgs e)
        {
            enableMP3BitrateOrQuality();
        }

        private void enableMP3BitrateOrQuality()
        {
            if (radioButtonMP3Quality.Checked)
            {
                groupBoxMP3Quality.Enabled = true;
                groupBoxMP3Bitrate.Enabled = false;
            }
            else
            {
                groupBoxMP3Quality.Enabled = false;
                groupBoxMP3Bitrate.Enabled = true;
            }
        }
        // MP3 Tooltip Quality
        private void trackBarMP3Quality_Tooltip(object sender, EventArgs e)
        {
            String sTooltip = "";
            switch (trackBarMP3Quality.Value)
            {
                case 1:
                    sTooltip = "~ 65 Kbit/s";
                    break;
                case 2:
                    sTooltip = "~ 85 Kbit/s";
                    break;
                case 3:
                    sTooltip = "~ 100 Kbit/s";
                    break;
                case 4:
                    sTooltip = "~ 115 Kbit/s";
                    break;
                case 5:
                    sTooltip = "~ 130 Kbit/s";
                    break;
                case 6:
                    sTooltip = "~ 165 Kbit/s";
                    break;
                case 7:
                    sTooltip = "~ 175 Kbit/s";
                    break;
                case 8:
                    sTooltip = "~ 190 Kbit/s";
                    break;
                case 9:
                    sTooltip = "~ 225 Kbit/s";
                    break;
                case 10:
                    sTooltip = "~ 245 Kbit/s";
                    break;
                default:
                    break;
            }

            toolTipInfo.SetToolTip(trackBarMP3Quality, sTooltip);
        }
        // MP3 Tooltip Bitrate
        private void trackBarMP3Bitrate_Tooltip(object sender, EventArgs e)
        {
            toolTipInfo.SetToolTip(trackBarMP3Bitrate, Convert.ToString(trackBarMP3Bitrate.Value * 8) + " Kbit/s");

        }

        // Audio Gain
        //***********
        private void checkBoxSoXSettingsGain_CheckedChanged(object sender, EventArgs e)
        {
            textBoxSoXSettingsGain.Enabled = !textBoxSoXSettingsGain.Enabled;
        }

        
        //****************************************************************************************************
        // ToolTips
        //****************************************************************************************************

        private void trackBarFLACCompression_Tooltip(object sender, EventArgs e)
        {
            toolTipInfo.SetToolTip(trackBarFLACCompression, Convert.ToString(trackBarFLACCompression.Value));
        }

        private void linkLabelAAC_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.nero.com/eng/downloads-nerodigital-nero-aac-codec.php");
        }

        private void linkLabelAC3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://aften.sourceforge.net/");
        }

        private void linkLabelDTS_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://aepatrakov.narod.ru/dcaenc/");
        }

        private void linkLabelFLAC_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://flac.sourceforge.net/");
        }

        private void linkLabelMP3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://lame.sourceforge.net/");
        }

        private void menuItem3about_Click(object sender, EventArgs e)
        {
            Form Info = new Form_Info();
            Info.ShowDialog(this);
        }

        private void menuitem1quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            saveSettings();
        }


        //****************************************************************************************************
        // Load & Save
        //****************************************************************************************************

        private void loadSettings()
        {
            try
            {
                SaveLoadXml doc = new SaveLoadXml("load", sProgrammPath);
                //Load eac3to settings
                checkBoxEac3toSettingsConvertChannels.Checked = Convert.ToBoolean(doc.loadValue("eac3to", "convert_channels"));
                radioButtonEac3toSettingsConvertToStereo.Checked = Convert.ToBoolean(doc.loadValue("eac3to", "convert_to_stereo"));
                checkBoxEac3toSettingsDialogNormalization.Checked = Convert.ToBoolean(doc.loadValue("eac3to", "dialog_normalization"));
                //Load SoX settings
                comboBoxSoXSettingsMainBufferSize.Text = doc.loadValue("sox", "main_buffer_size");
                checkBoxSoXSettingsInputConvertAudioResolution.Checked = Convert.ToBoolean(doc.loadValue("sox", "convert_input_audio_resolution"));
                comboBoxSoXSettingsInputConvertAudioResolution.Text = doc.loadValue("sox", "convert_input_audio_resolution_value");
                checkBoxSoXSettingsInputConvertEncodingType.Checked = Convert.ToBoolean(doc.loadValue("sox", "convert_input_encoding_type"));
                comboBoxSoXSettingsInputConvertEncodingType.Text = doc.loadValue("sox", "convert_input_encoding_type_value");
                checkBoxSoXSettingsInputConvertSamplingRate.Checked = Convert.ToBoolean(doc.loadValue("sox", "convert_input_sampling_rate"));
                comboBoxSoXSettingsInputConvertSamplingRate.Text = doc.loadValue("sox", "convert_input_sampling_rate_value");
                checkBoxSoXEffectsChangeTempo.Checked = Convert.ToBoolean(doc.loadValue("sox", "effects_change_tempo"));
                radioButtonSoXEffectsChangeTempoWithFPS.Checked = Convert.ToBoolean(doc.loadValue("sox", "effects_change_tempo_with_fps"));
                textBoxSoxEffectsChangeFrameRateSource.Text = doc.loadValue("sox", "effects_change_tempo_with_fps_source");
                textBoxSoxEffectsChangeFrameRateTarget.Text = doc.loadValue("sox", "effects_change_tempo_with_fps_target");
                radioButtonSoXEffectsChangeTempoDuration.Checked = Convert.ToBoolean(doc.loadValue("sox", "effects_change_tempo_with_duration"));
                textBoxSoxEffectsChangeDurationSource.Text = doc.loadValue("sox", "effects_change_tempo_with_duration_source");
                textBoxSoxEffectsChangeDurationTarget.Text = doc.loadValue("sox", "effects_change_tempo_with_duration_target");
                radioButtonSoXEffectsChangeTempoValue.Checked = Convert.ToBoolean(doc.loadValue("sox", "effects_change_tempo_with_direct_value"));
                textBoxSoxEffectsChangeTempoValue.Text = doc.loadValue("sox", "effects_change_tempo_with_direct_value_source");
                checkBoxSoXEffectsPitch.Checked = Convert.ToBoolean(doc.loadValue("sox", "effects_change_pitch"));
                textBoxSoXSettingsPitch.Text = doc.loadValue("sox", "effects_change_pitch_value");
                checkBoxSoXSettingsGain.Checked = Convert.ToBoolean(doc.loadValue("sox", "effects_change_gain"));
                textBoxSoXSettingsGain.Text = doc.loadValue("sox", "effects_change_gain_value");
                checkBoxSoXSettingsDownmixActivate.Checked = Convert.ToBoolean(doc.loadValue("sox", "effects_activate_stereo_downmix"));
                comboBoxSoXSettingsDownmixProLogic.Text = doc.loadValue("sox", "effects_activate_stereo_downmix_value");
                checkBoxSoXSettings51DownmixNormalize.Checked = Convert.ToBoolean(doc.loadValue("sox", "effects_normalize_51_downmix_matrix"));
                checkBoxSoXSettings51MixLFE.Checked = Convert.ToBoolean(doc.loadValue("sox", "effects_mix_lfe"));
                checkBoxSoXSettingsOutputConvertAudioResolution.Checked = Convert.ToBoolean(doc.loadValue("sox", "convert_output_audio_resolution"));
                comboBoxSoXSettingsOutputConvertAudioResolution.Text = doc.loadValue("sox", "convert_output_audio_resolution_value");
                checkBoxSoXSettingsOutputConvertEncodingType.Checked = Convert.ToBoolean(doc.loadValue("sox", "convert_output_encoding_type"));
                comboBoxSoXSettingsOutputConvertEncodingType.Text = doc.loadValue("sox", "convert_output_encoding_type_value");
                checkBoxSoXSettingsOutputConvertSamplingRate.Checked = Convert.ToBoolean(doc.loadValue("sox", "convert_output_sampling_rate"));
                comboBoxSoXSettingsOutputConvertSamplingRate.Text = doc.loadValue("sox", "convert_output_sampling_rate_value");
                //Load AAC settings
                radioButtonAACQuality.Checked = Convert.ToBoolean(doc.loadValue("aac", "output_target_quality"));
                radioButtonAACBitrate.Checked = Convert.ToBoolean(doc.loadValue("aac", "output_target_bitrate"));
                trackBarAACQuality.Value = Convert.ToInt32(doc.loadValue("aac", "output_target_quality_value"));
                trackBarAACBitrate.Value = Convert.ToInt32(doc.loadValue("aac", "output_target_bitrate_value"));
                checkBoxAACRestrictEncoder.Checked = Convert.ToBoolean(doc.loadValue("aac", "restrict_encoder"));
                comboBoxAACProfiles.Text = doc.loadValue("aac", "profile");
                checkBoxAACRTPHinttrack.Checked = Convert.ToBoolean(doc.loadValue("aac", "generate_rtp_hinttrack"));
                //Load AC3 settings
                trackBarAC3Bitrate.Value = Convert.ToInt32(doc.loadValue("ac3", "output_target_bitrate"));
                trackBarAC3ExponentStrategySearchSize.Value = Convert.ToInt32(doc.loadValue("ac3", "exponent_strategy_search_size"));
                comboBoxAC3BitsreamInfoCentermix.Text = doc.loadValue("ac3", "center_mix_level");
                comboBoxAC3BitsreamInfoSurroundmix.Text = doc.loadValue("ac3", "surround_mix_level");
                comboBoxAC3BitstreamInfoDolbySurround.Text = doc.loadValue("ac3", "dolby_surround_mode");
                comboBoxAC3DynamicRange.Text = doc.loadValue("ac3", "dynamic_range_compression_level");
                comboBoxAC3DialogNormalization.Text = doc.loadValue("ac3", "dialog_normalization_compression_level");
                //Load DTS settings
                radioButtonDTSBitrate7545.Checked = Convert.ToBoolean(doc.loadValue("dts", "754.5 kbits"));
                radioButtonDTSBitrate150975.Checked = Convert.ToBoolean(doc.loadValue("dts", "1509.75 kbits"));
                //Load FLAC settings
                trackBarFLACCompression.Value = Convert.ToInt32(doc.loadValue("flac", "compression_level"));
                //Load MP3 settings
                radioButtonMP3Quality.Checked = Convert.ToBoolean(doc.loadValue("mp3", "output_target_quality"));
                radioButtonMP3Bitrate.Checked = Convert.ToBoolean(doc.loadValue("mp3", "output_target_bitrate"));
                trackBarMP3Quality.Value = Convert.ToInt32(doc.loadValue("mp3", "output_target_quality_value"));
                trackBarMP3Bitrate.Value = Convert.ToInt32(doc.loadValue("mp3", "output_target_bitrate_value"));
                checkBoxMP3RestrictEncoder.Checked = Convert.ToBoolean(doc.loadValue("mp3", "restrict_encoder"));
                comboBoxMP3OptionsChannelModes.Text = doc.loadValue("mp3", "channel_mode");
                checkBoxMP3OptionsErrorProtection.Checked = Convert.ToBoolean(doc.loadValue("mp3", "activate_error_protection"));
                //Load WAV settings
                radioButtonWAVOutputFormatWAV.Checked = Convert.ToBoolean(doc.loadValue("wav", "target_format_wav"));
                radioButtonWAVOutputFormatAIFF.Checked = Convert.ToBoolean(doc.loadValue("wav", "target_format_aiff"));
                doc = null;
            }
            catch (Exception e)
            {
                Console.WriteLine("Fehler beim Laden der Einstellungen! " + e);
            }
        }
        
        private void saveSettings()
        {
            //"settings.xml" will be overwritten
            SaveLoadXml doc = new SaveLoadXml("save", sProgrammPath);
            doc.OpenXmlWriting();
            //Save eac3to settings
            doc.saveValue("eac3to", "convert_channels", checkBoxEac3toSettingsConvertChannels.Checked);
            doc.saveValue("eac3to", "convert_to_stereo", radioButtonEac3toSettingsConvertToStereo.Checked);
            doc.saveValue("eac3to", "dialog_normalization", checkBoxEac3toSettingsDialogNormalization.Checked);
            //Save SoX settings
            doc.saveValue("sox", "main_buffer_size", comboBoxSoXSettingsMainBufferSize.Text);
            doc.saveValue("sox", "convert_input_audio_resolution", checkBoxSoXSettingsInputConvertAudioResolution.Checked);
            doc.saveValue("sox", "convert_input_audio_resolution_value", comboBoxSoXSettingsInputConvertAudioResolution.Text);
            doc.saveValue("sox", "convert_input_encoding_type", checkBoxSoXSettingsInputConvertEncodingType.Checked);
            doc.saveValue("sox", "convert_input_encoding_type_value", comboBoxSoXSettingsInputConvertEncodingType.Text);
            doc.saveValue("sox", "convert_input_sampling_rate", checkBoxSoXSettingsInputConvertSamplingRate.Checked);
            doc.saveValue("sox", "convert_input_sampling_rate_value", comboBoxSoXSettingsInputConvertSamplingRate.Text);
            doc.saveValue("sox", "effects_change_tempo", checkBoxSoXEffectsChangeTempo.Checked);
            doc.saveValue("sox", "effects_change_tempo_with_fps", radioButtonSoXEffectsChangeTempoWithFPS.Checked);
            doc.saveValue("sox", "effects_change_tempo_with_fps_source", textBoxSoxEffectsChangeFrameRateSource.Text);
            doc.saveValue("sox", "effects_change_tempo_with_fps_target", textBoxSoxEffectsChangeFrameRateTarget.Text);
            doc.saveValue("sox", "effects_change_tempo_with_duration", radioButtonSoXEffectsChangeTempoDuration.Checked);
            doc.saveValue("sox", "effects_change_tempo_with_duration_source", textBoxSoxEffectsChangeDurationSource.Text);
            doc.saveValue("sox", "effects_change_tempo_with_duration_target", textBoxSoxEffectsChangeDurationTarget.Text);
            doc.saveValue("sox", "effects_change_tempo_with_direct_value", radioButtonSoXEffectsChangeTempoValue.Checked);
            doc.saveValue("sox", "effects_change_tempo_with_direct_value_source", textBoxSoxEffectsChangeTempoValue.Text);
            doc.saveValue("sox", "effects_change_pitch", checkBoxSoXEffectsPitch.Checked);
            doc.saveValue("sox", "effects_change_pitch_value", textBoxSoXSettingsPitch.Text);
            doc.saveValue("sox", "effects_change_gain", checkBoxSoXSettingsGain.Checked);
            doc.saveValue("sox", "effects_change_gain_value", textBoxSoXSettingsGain.Text);
            doc.saveValue("sox", "effects_activate_stereo_downmix", checkBoxSoXSettingsDownmixActivate.Checked);
            doc.saveValue("sox", "effects_activate_stereo_downmix_value", comboBoxSoXSettingsDownmixProLogic.Text);
            doc.saveValue("sox", "effects_normalize_51_downmix_matrix", checkBoxSoXSettings51DownmixNormalize.Checked);
            doc.saveValue("sox", "effects_mix_lfe", checkBoxSoXSettings51MixLFE.Checked);
            doc.saveValue("sox", "convert_output_audio_resolution", checkBoxSoXSettingsOutputConvertAudioResolution.Checked);
            doc.saveValue("sox", "convert_output_audio_resolution_value", comboBoxSoXSettingsOutputConvertAudioResolution.Text);
            doc.saveValue("sox", "convert_output_encoding_type", checkBoxSoXSettingsOutputConvertEncodingType.Checked);
            doc.saveValue("sox", "convert_output_encoding_type_value", comboBoxSoXSettingsOutputConvertEncodingType.Text);
            doc.saveValue("sox", "convert_output_sampling_rate", checkBoxSoXSettingsOutputConvertSamplingRate.Checked);
            doc.saveValue("sox", "convert_output_sampling_rate_value", comboBoxSoXSettingsOutputConvertSamplingRate.Text);
            //Save AAC settings
            doc.saveValue("aac", "output_target_quality", radioButtonAACQuality.Checked);
            doc.saveValue("aac", "output_target_bitrate", radioButtonAACBitrate.Checked);
            doc.saveValue("aac", "output_target_quality_value", trackBarAACQuality.Value);
            doc.saveValue("aac", "output_target_bitrate_value", trackBarAACBitrate.Value);
            doc.saveValue("aac", "restrict_encoder", checkBoxAACRestrictEncoder.Checked);
            doc.saveValue("aac", "profile", comboBoxAACProfiles.Text);
            doc.saveValue("aac", "generate_rtp_hinttrack", checkBoxAACRTPHinttrack.Checked);
            //Save AC3 settings
            doc.saveValue("ac3", "output_target_bitrate", trackBarAC3Bitrate.Value);
            doc.saveValue("ac3", "exponent_strategy_search_size", trackBarAC3ExponentStrategySearchSize.Value);
            doc.saveValue("ac3", "center_mix_level", comboBoxAC3BitsreamInfoCentermix.Text);
            doc.saveValue("ac3", "surround_mix_level", comboBoxAC3BitsreamInfoSurroundmix.Text);
            doc.saveValue("ac3", "dolby_surround_mode", comboBoxAC3BitstreamInfoDolbySurround.Text);
            doc.saveValue("ac3", "dynamic_range_compression_level", comboBoxAC3DynamicRange.Text);
            doc.saveValue("ac3", "dialog_normalization_compression_level", comboBoxAC3DialogNormalization.Text);
            //Save DTS settings
            doc.saveValue("dts", "754.5 kbits", radioButtonDTSBitrate7545.Checked);
            doc.saveValue("dts", "1509.75 kbits", radioButtonDTSBitrate150975.Checked);
            //Save FLAC settings
            doc.saveValue("flac", "compression_level", trackBarFLACCompression.Value);
            //Save MP3 settings
            doc.saveValue("mp3", "output_target_quality", radioButtonMP3Quality.Checked);
            doc.saveValue("mp3", "output_target_bitrate", radioButtonMP3Bitrate.Checked);
            doc.saveValue("mp3", "output_target_quality_value", trackBarMP3Quality.Value);
            doc.saveValue("mp3", "output_target_bitrate_value", trackBarMP3Bitrate.Value);
            doc.saveValue("mp3", "restrict_encoder", checkBoxMP3RestrictEncoder.Checked);
            doc.saveValue("mp3", "channel_mode", comboBoxMP3OptionsChannelModes.Text);
            doc.saveValue("mp3", "activate_error_protection", checkBoxMP3OptionsErrorProtection.Checked);
            //Save WAV settings
            doc.saveValue("wav", "target_format_wav", radioButtonWAVOutputFormatWAV.Checked);
            doc.saveValue("wav", "target_format_aiff", radioButtonWAVOutputFormatAIFF.Checked);
            doc.CloseXmlWriting();
            doc = null;

        }
    }
}
