using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// This enum determines whether the plug is available to be inserted.  - Normal means that all existing rules for plug insertion apply.  - UnavailableIfSocketContainsMatchingPlugCategory means that the plug is only available if the socket does NOT match the plug category.  - AvailableIfSocketContainsMatchingPlugCategory means that the plug is only available if the socket DOES match the plug category.  For category matching, use the plug&#39;s \&quot;plugCategoryIdentifier\&quot; property, comparing it to
    /// </summary>
    /// <value>This enum determines whether the plug is available to be inserted.  - Normal means that all existing rules for plug insertion apply.  - UnavailableIfSocketContainsMatchingPlugCategory means that the plug is only available if the socket does NOT match the plug category.  - AvailableIfSocketContainsMatchingPlugCategory means that the plug is only available if the socket DOES match the plug category.  For category matching, use the plug&#39;s \&quot;plugCategoryIdentifier\&quot; property, comparing it to</value>
    public enum DestinyPlugAvailabilityMode
    {
        
        /// <summary>
        /// Enum _0
        /// </summary>
        _0 = 1,
        
        /// <summary>
        /// Enum _1
        /// </summary>
        _1 = 2,
        
        /// <summary>
        /// Enum _2
        /// </summary>
        _2 = 3
    }

}