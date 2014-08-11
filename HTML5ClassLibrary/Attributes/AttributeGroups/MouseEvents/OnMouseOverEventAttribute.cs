﻿using HTML5ClassLibrary.Attributes.Events;

namespace HTML5ClassLibrary.Attributes.AttributeGroups.MouseEvents
{
    /// <summary>
    /// 
    /// </summary>
    public class OnMouseOverEventAttribute : OnEventAttribute
    {
        #region Overrides of OnEventAttribute

        protected override string GetAttributeName()
        {
            return "onmouseover";
        }

        #endregion
    }
}