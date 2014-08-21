﻿using System.Xml.Linq;

namespace XHTMLClassLibrary.Attributes
{
    /// <summary>
    /// The dropzone attribute specifies whether the dragged data is copied, moved, or linked, when it is dropped on an element.
    /// </summary>
    public class DropZoneTypeAttribute : BaseAttribute
    {
        private enum DropZoneValues
        {
            Invalid,
            Copy,
            Move,
            Link,
        }

        private DropZoneValues _dropZone = DropZoneValues.Invalid;


        public override string Value
        {
            get
            {
                switch (_dropZone)
                {
                    case DropZoneValues.Copy:
                        return "copy";
                    case DropZoneValues.Move:
                        return "move";
                    case DropZoneValues.Link:
                        return "link";
                }
                return string.Empty;
            }

            set
            {
                switch (value.ToLower())
                {
                    case "copy":
                        _dropZone = DropZoneValues.Copy;
                        break;
                    case "move":
                        _dropZone = DropZoneValues.Move;
                        break;
                    case "link":
                        _dropZone = DropZoneValues.Link;
                        break;
                    default:
                        _dropZone = DropZoneValues.Invalid;
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