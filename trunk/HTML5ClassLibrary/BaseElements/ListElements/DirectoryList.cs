﻿using XHTMLClassLibrary.Attributes;
using XHTMLClassLibrary.Attributes.FlaggedAttributes;
using XHTMLClassLibrary.BaseElements.BlockElements;

namespace XHTMLClassLibrary.BaseElements.ListElements
{
    [HTMLItemAttribute(ElementName = "dir", SupportedStandards = HTMLElementType.Transitional | HTMLElementType.FrameSet)]    
    public class DirectoryList : HTMLItem, IBlockElement
    {
        [AttributeTypeAttributeMember(Name = "compact", SupportedStandards = HTMLElementType.Transitional | HTMLElementType.FrameSet)]
        private readonly FlagAttribute _compactAttribute = new FlagAttribute();


        /// <summary>
        /// Specifies that the list should render smaller than normal
        /// Not supported in HTML5.
        /// </summary>
        public FlagAttribute Compact { get { return _compactAttribute; }}

        protected override bool IsValidSubType(IHTMLItem item)
        {
            if (item is ListItem)
            {
                return item.IsValid();
            }
            return false;
        }


        public override bool IsValid()
        {
            return (Subitems.Count > 0);
        }
    }
}
