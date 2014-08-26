﻿using System.Collections.Generic;
using System.Xml.Linq;
using XHTMLClassLibrary.AttributeDataTypes;
using XHTMLClassLibrary.Attributes;


namespace XHTMLClassLibrary.BaseElements.Structure_Header
{
    /// <summary>
    /// The link element conveys relationship information that can be used by Web browsers and search engines. 
    /// You can have multiple link elements that link to different resources or describe different relationships. 
    /// The link elements can be contained in the head element.
    /// </summary>
    [HTMLItemAttribute(ElementName = "link", SupportedStandards = HTMLElementType.HTML5 |  HTMLElementType.XHTML5 | HTMLElementType.XHTML11 | HTMLElementType.Transitional | HTMLElementType.Strict | HTMLElementType.FrameSet)]    
    public class Link : HTMLItem
    {
        [AttributeTypeAttributeMember(Name = "charset", SupportedStandards = HTMLElementType.XHTML11 | HTMLElementType.Transitional | HTMLElementType.Strict | HTMLElementType.FrameSet)]
        private readonly CharsetTypeAttribute _charsetAttribute = new CharsetTypeAttribute();

        [AttributeTypeAttributeMember(Name = "href", SupportedStandards = HTMLElementType.HTML5 | HTMLElementType.XHTML5 | HTMLElementType.XHTML11 | HTMLElementType.Transitional | HTMLElementType.Strict | HTMLElementType.FrameSet)]
        private readonly URITypeAttribute _hrefAttribute = new URITypeAttribute();

        [AttributeTypeAttributeMember(Name = "hreflang", SupportedStandards = HTMLElementType.HTML5 | HTMLElementType.XHTML5 | HTMLElementType.XHTML11 | HTMLElementType.Transitional | HTMLElementType.Strict | HTMLElementType.FrameSet)]
        private readonly LanguageTypeAttribute _hrefLangAttribute = new LanguageTypeAttribute();

        [AttributeTypeAttributeMember(Name = "media", SupportedStandards = HTMLElementType.HTML5 | HTMLElementType.XHTML5 | HTMLElementType.XHTML11 | HTMLElementType.Transitional | HTMLElementType.Strict | HTMLElementType.FrameSet)]
        private readonly MediaDescriptionsTypeAttribute _mediaAttribute = new MediaDescriptionsTypeAttribute();

        [AttributeTypeAttributeMember(Name = "rel", SupportedStandards = HTMLElementType.HTML5 | HTMLElementType.XHTML5 | HTMLElementType.XHTML11 | HTMLElementType.Transitional | HTMLElementType.Strict | HTMLElementType.FrameSet)]
        private readonly ValuesSelectionTypeAttribute<Text> _relAttribute = new ValuesSelectionTypeAttribute<Text>("alternate;archives;author;bookmark;external;first;help;icon;last;license;next;nofollow;norefferer;pingback;prefetch;prev;search;sidebar;stylesheet;tag;up");

        [AttributeTypeAttributeMember(Name = "rev", SupportedStandards = HTMLElementType.XHTML11 | HTMLElementType.Transitional | HTMLElementType.Strict | HTMLElementType.FrameSet)]
        private readonly LinkTypeAttribute _reverseRelationAttribute = new LinkTypeAttribute();

        [AttributeTypeAttributeMember(Name = "sizes", SupportedStandards = HTMLElementType.HTML5 | HTMLElementType.XHTML5)]
        private readonly SizesTypeAttribute _sizesAttribute = new SizesTypeAttribute();

        [AttributeTypeAttributeMember(Name = "type", SupportedStandards = HTMLElementType.HTML5 | HTMLElementType.XHTML5 | HTMLElementType.XHTML11 | HTMLElementType.Transitional | HTMLElementType.Strict | HTMLElementType.FrameSet)]
        private readonly MIMETypeAttribute _typeAttribute = new MIMETypeAttribute();


        public static XNamespace XhtmlNameSpace = @"http://www.w3.org/1999/xhtml";

        #region public_properties


        /// <summary>
        /// Specifies the character encoding of the linked document
        /// Not supported in HTML5.
        /// </summary>
        public IAttributeDataAccess Charset { get { return _charsetAttribute; }}

        /// <summary>
        /// Specifies the primary language of the resource designated by href and may only be used when href is specified.
        /// </summary>
        public IAttributeDataAccess RefLanguage { get { return _hrefLangAttribute; } }

        /// <summary>
        /// Describes the forward relationship from the current document to the resource specified by the href attribute. 
        /// The value of this attribute is a space-separated list of link types.
        /// </summary>
        public IAttributeDataAccess Relation { get { return _relAttribute; } }


        /// <summary>
        /// Specifies the relationship between the linked document and the current document
        /// Not supported in HTML5.
        /// </summary>
        public IAttributeDataAccess Rev { get { return _reverseRelationAttribute; } }

        /// <summary>
        /// This attribute specifies the location of a Web resource.
        /// </summary>
        public IAttributeDataAccess HRef { get { return _hrefAttribute; } }

        /// <summary>
        /// his attribute specifies the intended destination medium for style information. 
        /// It may be a single media descriptor or a comma-separated list. 
        /// The default value for this attribute is "screen".
        /// </summary>
        public IAttributeDataAccess Media { get { return _mediaAttribute; } }

        /// <summary>
        /// Style sheet language. 
        /// For example: text/css.
        /// </summary>
        public IAttributeDataAccess Type { get { return _typeAttribute; } }


        /// <summary>
        /// Specifies the size of the linked resource. Only for rel="icon"
        /// </summary>
        public IAttributeDataAccess Sizes { get { return _sizesAttribute; } }


        #endregion


        public override bool IsValid()
        {
            return true;
        }

        public override List<IHTMLItem> SubElements()
        {
            return null;
        }

    }
}
