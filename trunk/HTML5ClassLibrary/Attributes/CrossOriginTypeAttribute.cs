﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace XHTMLClassLibrary.Attributes
{
    public class CrossOriginTypeAttribute : BaseAttribute
    {
        private enum CrossOriginValues
        {
            Invalid,
            Anonymous,
            UseCredentials,
        }

        private CrossOriginValues _crossOrigin = CrossOriginValues.Invalid;


        public override string Value
        {
            get
            {
                switch (_crossOrigin)
                {
                    case CrossOriginValues.Anonymous:
                        return "anonymous";
                    case CrossOriginValues.UseCredentials:
                        return "use-credentials";
                }
                return string.Empty;
            }

            set
            {
                switch (value.ToLower())
                {
                    case "anonymous":
                        _crossOrigin = CrossOriginValues.Anonymous;
                        break;
                    case "use-credentials":
                        _crossOrigin = CrossOriginValues.UseCredentials;
                        break;
                    default:
                        _crossOrigin = CrossOriginValues.Invalid;
                        break;
                }
            }
        }


        public override void AddAttribute(XElement xElement)
        {
            if (!AttributeHasValue)
            {
                return;
            }
            xElement.Add(new XAttribute(GetAttributeName(), Value));
        }

        public override void ReadAttribute(XElement element)
        {
            AttributeHasValue = false;
            XAttribute xObject = element.Attribute(GetAttributeName());
            if (xObject != null)
            {
                Value = xObject.Value;
            }
        }

    }
}