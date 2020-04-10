using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// As you run into items that need to be classified for Milestone purposes in ways that we cannot infer via direct data, add a new classification here and use a string constant to represent it in the local item config file.  NOTE: This is not all of the item types available, and some of these are holdovers from Destiny 1 that may or may not still exist.
    /// </summary>
    /// <value>As you run into items that need to be classified for Milestone purposes in ways that we cannot infer via direct data, add a new classification here and use a string constant to represent it in the local item config file.  NOTE: This is not all of the item types available, and some of these are holdovers from Destiny 1 that may or may not still exist.</value>
    public enum DestinySpecialItemType
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
        /// Enum _8
        /// </summary>
        _8 = 3,
        
        /// <summary>
        /// Enum _9
        /// </summary>
        _9 = 4,
        
        /// <summary>
        /// Enum _23
        /// </summary>
        _23 = 5,
        
        /// <summary>
        /// Enum _24
        /// </summary>
        _24 = 6,
        
        /// <summary>
        /// Enum _25
        /// </summary>
        _25 = 7,
        
        /// <summary>
        /// Enum _27
        /// </summary>
        _27 = 8,
        
        /// <summary>
        /// Enum _29
        /// </summary>
        _29 = 9
    }

}