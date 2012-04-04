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
using System.Text.RegularExpressions;
using System.Drawing;

namespace BDAudioConverterGUI.Classes
{
    public class CheckValue
    {
        //Field
        private Color _Color;
        private String _sPattern;
        private String _sValue;

        //Get'nSet
        public Color oColor { get { return _Color; } }
        public Boolean bResult { get { return checktextbox(); } }

        //Constructor
        public CheckValue(String sPattern, String sValue)
        {
            _Color = SystemColors.Window;
            _sPattern = sPattern;
            _sValue = sValue;
        }

        private Boolean checktextbox()
        {
            String pattern = "";
            switch (_sPattern)
            {
                case "[00]:[00]:[00]:[000]":
                    pattern = @"^\s?[0-9]{2}[:][0-5][0-9][:][0-5][0-9][:][0-9]{3}$";
                    break;
                case "00.000":
                    pattern = @"^\s?[0-9]{2}[.][0-9]{3}$";
                    break;
                case "0.0":
                    pattern = @"^\s?[0-9]+[.][0-9]+$";
                    break;
                case "+/-0.0":
                    pattern = @"^\s?[+-][0-9]+[.][0-9]+$";
                    break;
            }
                        
            Regex rgx = new Regex(pattern);
            if (rgx.IsMatch(_sValue))
            {
                return true;
            }
            else
            {
                _Color = Color.LightSteelBlue;
                return false;
            }
        }
    }
}
