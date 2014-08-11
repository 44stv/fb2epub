﻿using System.ComponentModel;
using System.Xml.Linq;

namespace HTML5ClassLibrary.Attributes.AttributeGroups.HTMLGlobal
{
    public enum TextDirection
    {
        Unknown,
        LtR, // left to right
        RtL, // Right to left
        Auto,
    }

    /// <summary>
    /// The dir attribute specifies the text direction of the element's content.
    /// </summary>
    public class DirectionAttribute : BaseAttribute
    {
        private TextDirection _direction = TextDirection.Unknown;

        private const string AttributeName = "dir";

        #region Implementation of IBaseAttribute

        public override void AddAttribute(XElement xElement)
        {
            if (!_hasValue)
            {
                return;
            }
            string dir;
            switch (_direction)
            {
                case TextDirection.LtR:
                    dir = "ltr";
                    break;
                case TextDirection.RtL:
                    dir = "rtl";
                    break;
                case TextDirection.Auto:
                    dir = "auto";
                    break;
                default:
                    throw new InvalidEnumArgumentException();
            }
            var xLang = new XAttribute(AttributeName, dir);
            xElement.Add(xLang);

        }

        public override void ReadAttribute(XElement element)
        {
            _direction = TextDirection.Unknown;
            _hasValue = false;
            XAttribute xDirection = element.Attribute(AttributeName);
            if (xDirection != null)
            {
                _hasValue = true;
                switch (xDirection.Value.ToLower())
                {
                    case "ltr":
                        _direction = TextDirection.LtR;
                        break;
                    case "rtl":
                        _direction = TextDirection.RtL;
                        break;
                    case "auto":
                        _direction = TextDirection.Auto;
                        break;
                    default:
                        _direction = TextDirection.Unknown;
                        break;
                }
            }

        }

        public override string Value
        {
            get
            {
                switch (_direction)
                {
                    case TextDirection.LtR:
                        return "ltr";
                    case TextDirection.RtL:
                        return "rtl";
                }
                return string.Empty;
            }
            set
            {
                _hasValue = true;
                switch (value.ToLower())
                {
                    case "ltr":
                        _direction = TextDirection.LtR;
                        break;
                    case "rtl":
                        _direction = TextDirection.RtL;
                        break;
                    default:
                        _direction = TextDirection.Unknown;
                        _hasValue = false;
                        break;
                }
                
            }
        }

        #endregion
    }
}