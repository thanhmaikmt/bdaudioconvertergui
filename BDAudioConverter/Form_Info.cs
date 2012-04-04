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

namespace BDAudioConverterGUI
{
    public partial class Form_Info : Form
    {
        public Form_Info()
        {
            InitializeComponent();
        }

        private void buttonInfoClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabelBeLight_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://forum.doom9.org/showthread.php?t=122700");
        }

        private void linkLabelAften_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://aften.sourceforge.net/");
        }

        private void linkLabelEac3to_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://forum.doom9.org/showthread.php?t=125966");
        }

        private void linkLabelLameMP3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://lame.sourceforge.net/");
        }

        private void linkLabelNeroAAC_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.nero.com/deu/technologies-aac-codec.html");
        }

        private void linkLabelSoXeXchange_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://sox.sourceforge.net/");
        }

        private void linkLabelPsdGraphics_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.psdgraphics.com/psd-icons/speaker-icon/");
        }

        private void linkLabelDcaenc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://aepatrakov.narod.ru/dcaenc/");
        }

        private void linkLabelMediaInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://mediainfo.sourceforge.net/");
        }
    }
}