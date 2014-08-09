﻿using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Linq;
using HTML5ClassLibrary.Attributes;

namespace HTML5ClassLibrary.BaseElements.Structure_Header
{
    public class HTML :BaseContainingElement
    {

        internal const string ElementName = "html";

        private readonly LanguageAttr _language = new LanguageAttr();
        private readonly DirectionAttr _direction = new DirectionAttr();

        private readonly XmlNsAttribute _xhtmlNameSpaceAttribute = new XmlNsAttribute();
        private readonly ManifestAttribute _manifestAttribute = new ManifestAttribute();


        public static XNamespace XhtmlNameSpace = @"http://www.w3.org/1999/xhtml";


        /// <summary>
        /// This attribute has been deprecated (made outdated). 
        /// It is redundant, because version information is now provided by the DOCTYPE.
        /// </summary>
        public ManifestAttribute Manifest { get {return _manifestAttribute;}}

        /// <summary>
        /// This attribute specifies the base direction of text. 
        /// Possible values:
        /// ltr: Left-to-right 
        /// rtl: Right-to-left
        /// </summary>
        public DirectionAttr Direction
        {
            get { return _direction; }
        }

        /// <summary>
        /// This attribute specifies the base language of an element's attribute values and text content.
        /// </summary>
        public LanguageAttr Language
        {
            get { return _language; }
        }

        public override void Load(XNode xNode)
        {
            if (xNode.NodeType != XmlNodeType.Element)
            {
                throw new Exception("xNode is not of element type");
            }
            var xElement = (XElement)xNode;
            if (xElement.Name.LocalName != ElementName)
            {
                throw new Exception(string.Format("xNode is not {0} element", ElementName));
            }

            _language.ReadAttribute(xElement);
            _direction.ReadAttribute(xElement);

            // XhtmlNameSpaceAttribute.ReadAttribute(xElement); - no need to read , always the same value should be there
            _manifestAttribute.ReadAttribute(xElement);


            Content.Clear();
            IEnumerable<XNode> descendants = xElement.Nodes();
            foreach (var node in descendants)
            {
                IHTML5Item item = ElementFactory.CreateElement(node);
                if ((item != null) && IsValidSubType(item))
                {
                    try
                    {
                        item.Load(node);
                   }
                    catch (Exception)
                    {
                        continue;
                    }
                    Content.Add(item);
                }
            }


        }

        protected override bool IsValidSubType(IHTML5Item item)
        {
            if (Content.Count >= 2) // no more than two sub elements
            {
                return false;
            }
            if (Content.Count == 0) // head have to be first
            {
                if (!(item is Head)  )
                {
                    return false;
                }
            }
            if (Content.Count == 1) // body have to be second
            {
                if (!(item is Body)  )
                {
                    return false;
                }
            }

            return item.IsValid();
        }

        public override XNode Generate()
        {
            var xElement = new XElement(XhtmlNameSpace + ElementName);

            _xhtmlNameSpaceAttribute.AddAttribute(xElement);
            _manifestAttribute.AddAttribute(xElement);

            _language.AddAttribute(xElement);
            _direction.AddAttribute(xElement);

            foreach (var item in Content)
            {
                xElement.Add(item.Generate());
            }


            return xElement;

        }

        public override bool IsValid()
        {
            if (Content.Count != 2)
            {
                return false;
            }
            if (!(Content[0] is Head))
            {
                return false;
            }
            if (!(Content[1] is Body))
            {
                return false;
            }
            return (Content[0].IsValid() && Content[1].IsValid());
        }
    }
}