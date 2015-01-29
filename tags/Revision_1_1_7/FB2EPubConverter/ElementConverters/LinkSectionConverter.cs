﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FB2Library.Elements;
using XHTMLClassLibrary.BaseElements;
using XHTMLClassLibrary.BaseElements.BlockElements;
using XHTMLClassLibrary.BaseElements.InlineElements;
using XHTMLClassLibrary.Exceptions;

namespace FB2EPubConverter.ElementConverters
{
    internal class LinkSectionConverter : BaseElementConverter
    {
        /// <summary>
        /// Convert FB2 "notes" and "comments" and other "additional" sections
        /// </summary>
        /// <param name="linkSectionItem">item to convert</param>
        /// <returns>XHTML representation</returns>
        public IXHTMLItem Convert(SectionItem linkSectionItem)
        {
            if (linkSectionItem == null)
            {
                throw new ArgumentNullException("linkSectionItem");
            }
            IBlockElement content = new Div();
            Anchor a = new Anchor();
            TitleConverter titleConverter = new TitleConverter{ Settings = Settings };
            foreach (var item in titleConverter.Convert(linkSectionItem.Title, 2).SubElements())
            {
                content.Add(item);                    
            }
            string newId = Settings.ReferencesManager.EnsureGoodId(linkSectionItem.ID);
            a.Add(new SimpleEPubText { Text = newId });
            a.HRef.Value = string.Format("{0}_back", newId);
            if (a.HRef.Value.StartsWith("_back") == false)
            {
                a.Class.Value = "note_anchor";
                Settings.ReferencesManager.AddBackReference(a.HRef.Value, a);
                //content.Add(a);
            }
            SetClassType(content);
            return content;

        }

    
        public override string GetElementType()
        {
            return "note_section";
        }
    }
}