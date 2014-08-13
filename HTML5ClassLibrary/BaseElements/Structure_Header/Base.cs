﻿using HTML5ClassLibrary.Attributes;
using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Linq;
using HTML5ClassLibrary.Exceptions;

namespace HTML5ClassLibrary.BaseElements.Structure_Header
{
    /// <summary>
    /// To resolve relative URLs, Web browsers will use the base URL from where the Web page was downloaded. 
    /// In some circumstances, it is necessary to instruct the Web browser to use a different base URL, 
    /// in which case the base element is used.
    /// </summary>
    public class Base : HTML5Item
    {
        public const string ElementName = "base";


        public Base()
        {
            RegisterAttribute(_hrefAttribute);
            RegisterAttribute(_targetAttribute);
        }

        // Basic attributes
        private readonly HrefAttribute _hrefAttribute = new HrefAttribute();
        private readonly FormTargetAttribute _targetAttribute = new FormTargetAttribute();




        /// <summary>
        /// Specifies an absolute URL that acts as the base URL for resolving relative URLs. 
        /// This attribute is required.
        /// </summary>
        public static XNamespace XhtmlNameSpace = @"http://www.w3.org/1999/xhtml";

        /// <summary>
        /// Specifies the base URL for all relative URLs in the page
        /// </summary>
        public HrefAttribute HRef { get { return _hrefAttribute; } }

        /// <summary>
        /// Specifies the default target for all hyperlinks and forms in the page
        /// </summary>
        public FormTargetAttribute Target { get { return _targetAttribute; }}
        
        public override void Load(XNode xNode)
        {
            if (xNode.NodeType != XmlNodeType.Element)
            {
                throw new HTML5ViolationException("xNode is not of element type");
            }
            var xElement = (XElement)xNode;
            if (xElement.Name.LocalName != ElementName)
            {
                throw new HTML5ViolationException(string.Format("xNode is not {0} element", ElementName));
            }
             
            ReadAttributes(xElement);
        }


        public override XNode Generate()
        {
            var xElement = new XElement(XhtmlNameSpace + ElementName);
            
            AddAttributes(xElement);
            return xElement;
        }


        public override bool IsValid()
        {
            return true;
        }

        /// <summary>
        /// Adds sub-item to the item , only if 
        /// allowed by the rules and element can accept content
        /// </summary>
        /// <param name="item">sub-item to add</param>
        public override void Add(IHTML5Item item)
        {
            throw new Exception("This element does not contain sub-items");
        }

        public override void Remove(IHTML5Item item)
        {
            throw new Exception("This element does not contain sub-items");
        }

        public override List<IHTML5Item> SubElements()
        {
            return null;
        }
    }
}
