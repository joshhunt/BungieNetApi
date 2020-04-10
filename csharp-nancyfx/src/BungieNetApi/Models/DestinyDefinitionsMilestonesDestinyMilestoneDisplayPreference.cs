using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// A hint for the UI as to what display information ought to be shown. Defaults to showing the static MilestoneDefinition&#39;s display properties.   If for some reason the indicated property is not populated, fall back to the MilestoneDefinition.displayProperties.
    /// </summary>
    /// <value>A hint for the UI as to what display information ought to be shown. Defaults to showing the static MilestoneDefinition&#39;s display properties.   If for some reason the indicated property is not populated, fall back to the MilestoneDefinition.displayProperties.</value>
    public enum DestinyDefinitionsMilestonesDestinyMilestoneDisplayPreference
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