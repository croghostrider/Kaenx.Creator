﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Kaenx.Creator.Models
{
    public class ComObject : INotifyPropertyChanged
    {
        private int _uid = -1;
        public int UId
        {
            get { return _uid; }
            set { _uid = value; Changed("UId"); }
        }

        private int _id = -1;
        public int Id
        {
            get { return _id; }
            set { _id = value; Changed("Id"); }
        }

        private string _name = "Kommunikationsobjekt";
        public string Name
        {
            get { return _name; }
            set { _name = value; Changed("Name"); }
        }

        private string _text = "Taste n";
        public string Text
        {
            get { return _text; }
            set { _text = value; Changed("Text"); }
        }

        private string _funcText = "Kurze Tastenbetätigung";
        public string FunctionText
        {
            get { return _funcText; }
            set { _funcText = value; Changed("FunctionText"); }
        }

        private string _desc = "";
        public string Description
        {
            get { return _desc; }
            set { _desc = value; Changed("Description"); }
        }

        private int _numb = 0;
        public int Number
        {
            get { return _numb; }
            set { _numb = value; Changed("Number"); }
        }


        private FlagType _flagRead = FlagType.Disabled;
        public FlagType FlagRead
        {
            get { return _flagRead; }
            set { _flagRead = value; Changed("FlagRead"); }
        }

        private FlagType _flagWrite = FlagType.Disabled;
        public FlagType FlagWrite
        {
            get { return _flagWrite; }
            set { _flagWrite = value; Changed("FlagWrite"); }
        }

        private FlagType _flagTrans = FlagType.Disabled;
        public FlagType FlagTrans
        {
            get { return _flagTrans; }
            set { _flagTrans = value; Changed("FlagTrans"); }
        }

        private FlagType _flagComm = FlagType.Enabled;
        public FlagType FlagComm
        {
            get { return _flagComm; }
            set { _flagComm = value; Changed("FlagComm"); }
        }

        private FlagType _flagUpdate = FlagType.Disabled;
        public FlagType FlagUpdate
        {
            get { return _flagUpdate; }
            set { _flagUpdate = value; Changed("FlagUpdate"); }
        }

        private FlagType _flagOnInit = FlagType.Disabled;
        public FlagType FlagOnInit
        {
            get { return _flagOnInit; }
            set { _flagOnInit = value; Changed("FlagOnInit"); }
        }






        private string _typeValue;
        public string TypeValue
        {
            get { return _typeValue; }
            set { if (value == null) return; _typeValue = value; Changed("TypeValue"); }
        }

        private bool _hasDpt = false;
        public bool HasDpt
        {
            get { return _hasDpt; }
            set { _hasDpt = value; Changed("HasDpt"); }
        }

        private bool _hasDpts = false;
        public bool HasDpts
        {
            get { return _hasDpts; }
            set { _hasDpts = value; Changed("HasDpts"); }
        }




        [JsonIgnore]
        public string _subTypeNumber;
        public string SubTypeNumber
        {
            get { return SubType?.Number; }
            set { _subTypeNumber = value; Changed("SubTypeNumber"); }
        }

        private DataPointSubType _subType;
        public DataPointSubType SubType
        {
            get { return _subType; }
            set { if (value == null) return; _subType = value; Changed("SubType"); }
        }

        [JsonIgnore]
        public string _typeNumber;
        public string TypeNumber
        {
            get { return Type?.Number; }
            set { if (value == null) return; _typeNumber = value; Changed("TypeNumber"); }
        }

        private DataPointType _type;
        public DataPointType Type
        {
            get { return _type; }
            set { if (value == null) return; _type = value; Changed("Type"); }
        }



        public event PropertyChangedEventHandler PropertyChanged;
        private void Changed(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }

    public enum FlagType
    {
        Enabled,
        Disabled,
        Undefined
    }
}
