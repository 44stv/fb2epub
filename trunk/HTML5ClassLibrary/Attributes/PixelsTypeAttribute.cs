﻿using System.Xml.Linq;
using XHTMLClassLibrary.AttributeDataTypes;

namespace XHTMLClassLibrary.Attributes
{
    public class PixelsTypeAttribute : BaseAttribute
    {
        private Pixels _attrObject = new Pixels();

        public override void AddAttribute(XElement xElement)
        {
            if (!AttributeHasValue)
            {
                return;
            }
            xElement.Add(new XAttribute(GetAttributeName(), _attrObject.Value));
        }

        public override void ReadAttribute(XElement element)
        {
            AttributeHasValue = false;
            _attrObject = null;
            XAttribute xObject = element.Attribute(GetAttributeName());
            if ((xObject != null) && (xObject.Value.Length > 0))
            {
                _attrObject = new Pixels();
                _attrObject.Value = xObject.Value;
                AttributeHasValue = true;
            }

        }

        public override string Value
        {
            get { return _attrObject.Value; }
            set
            {
                _attrObject.Value = value;
                AttributeHasValue = (value != string.Empty);
            }
        }
    }
}