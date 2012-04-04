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
using System.Linq;
using System.Text;

namespace BDAudioConverterGUI.Classes
{
    public class AudioFile
    {
        //Field
        private Boolean _bAllowToConvert;
        private string _sBitrate;
        private string _sBitDepth;
        private string _sChannels;
        private string _sCodec;
        private string _sCommandoLine;
        private string _sDescription;
        private string _sDuration;
        private string _sFileName;
        private string _sFullFileName;
        private string _sPath;
        private string _sSamplingRate;


        //Get'nSet
        public Boolean bAllowToConvert { get { return _bAllowToConvert; } set { _bAllowToConvert = value; } }
        public string sBitrate { get { return _sBitrate; } set { _sBitrate = value; } }
        public string sBitDepth { get { return _sBitDepth; } set { _sBitDepth = value; } }
        public string sChannels { get { return _sChannels; } set { _sChannels = value; } }
        public string sCodec { get { return _sCodec; } set { _sCodec = value; } }
        public string sCommandoLine { get { return _sCommandoLine; } set { _sCommandoLine = value; } }
        public string sDescription { get { return _sDescription; } set { _sDescription = value; } }
        public string sDuration { get { return _sDuration; } set { _sDuration = value; } }
        public string sFileName { get { return _sFileName; } set { _sFileName = value; } }
        public string sFullFileName { get { return _sFullFileName; } set { _sFullFileName = value; } }
        public string sPath { get { return _sPath; } set { _sPath = value; } }
        public string sSamplingRate { get { return _sSamplingRate; } set { _sSamplingRate = value; } }

        
        //Constructor
        public  AudioFile()
        {
            _bAllowToConvert = false;
            _sPath = "";
            _sFileName = "";
            _sFullFileName = "";
            _sCodec = "";
            _sBitrate = "";
            _sBitDepth = "";
            _sCommandoLine = "";
            _sSamplingRate = "";
            _sDescription = "";
            _sDuration = "";
            _sChannels = "";
        }
    }
}
