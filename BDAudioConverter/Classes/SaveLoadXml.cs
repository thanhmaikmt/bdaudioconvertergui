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
using System.Xml;

namespace BDAudioConverterGUI.Classes
{
    class SaveLoadXml
    {
        //Fields
        private XmlWriter _writer;
        private XmlReader _reader;
        private String _sCurrentGroup;
        private List<String> _listGroup = new List<String>();
        private List<String> _listObject = new List<String>();
        private List<String> _listValue = new List<String>();
        

        //Constructor
        public SaveLoadXml(string sOption, string sPath)
        {
            if (sOption.Equals("save"))
            {
                XmlWriterSettings settings = new XmlWriterSettings();
                settings.Indent = true;
                settings.IndentChars = "  ";
                _writer = XmlWriter.Create(sPath + "\\Settings.xml", settings);
                _sCurrentGroup = "";
            }
            if (sOption.Equals("load"))
            {
                XmlReaderSettings settings = new XmlReaderSettings();
                settings.IgnoreWhitespace = true;
                settings.IgnoreComments = true;

                try
                {
                    using (_reader = XmlReader.Create(sPath + "\\Settings.xml", settings))
                    {
                        _reader.ReadStartElement("settings");
                        while (!_reader.EOF)
                        {
                            if (_reader.IsStartElement() && !_reader.Name.Equals(_sCurrentGroup))
                            {
                                _sCurrentGroup = _reader.Name;
                            }
                            while (_reader.Read() && _reader.Name.Equals("object"))
                            {
                                _listGroup.Add(_sCurrentGroup);
                                _listObject.Add(_reader.GetAttribute("name"));
                                _listValue.Add(_reader.ReadString());
                            }
                        }
                        //Because we have used the "using"-methode, we can finally release the file
                        //with "Close();".
                        _reader.Close();
                    }
                }
                catch( XmlException e)
                {
                    Console.WriteLine("Fehler beim Auslesen der Datei!" + e);
                }
            }
        }
        

        //Methods
        public string loadValue(string sGroup, string sObject)
        {
            for (int x = 0; x < _listValue.Count; x++)
            {
                if (_listGroup[x].Equals(sGroup) && _listObject[x].Equals(sObject))
                {
                    return _listValue[x];
                }
            }
            return "";
        }


        public void OpenXmlWriting()
        {
            _writer.WriteStartDocument();
            _writer.WriteComment("BDAudioConverterGUI Settings");
            _writer.WriteStartElement("settings"); //<settings>
        }

        public void saveValue(string sGroup, string sObject, string sValue)
        {
            save(sGroup, sObject, sValue);
        }
        public void saveValue(string sGroup, string sObject, int iValue)
        {
            save(sGroup, sObject, Convert.ToString(iValue));
        }
        public void saveValue(string sGroup, string sObject, bool bValue)
        {
            save(sGroup,sObject,Convert.ToString(bValue));
        }

        public void CloseXmlWriting()
        {
            _writer.WriteEndElement(); //Close Group
            _writer.WriteEndElement(); //</settings>
            _writer.WriteComment("Saved on: " + Convert.ToString(System.DateTime.Now));
            _writer.WriteEndDocument();
            _writer.Close();
        }

        private void save(string sGroup, string sObject, string sValue)
        {
            //If the group changes
            if (_sCurrentGroup != sGroup)
            {
                //First close group if one exists before
                if (_sCurrentGroup != "")
                {
                    _writer.WriteEndElement();
                }
                _writer.WriteStartElement(sGroup);
                _sCurrentGroup = sGroup;
            }
            //Finally Save Value
            _writer.WriteStartElement("object");
            _writer.WriteAttributeString("name", sObject);
            _writer.WriteString(sValue);
            _writer.WriteEndElement();
        }
    }
}
