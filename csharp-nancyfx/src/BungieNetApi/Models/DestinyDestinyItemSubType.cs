using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// This Enumeration further classifies items by more specific categorizations than DestinyItemType. The \&quot;Sub-Type\&quot; is where we classify and categorize items one step further in specificity: \&quot;Auto Rifle\&quot; instead of just \&quot;Weapon\&quot; for example, or \&quot;Vanguard Bounty\&quot; instead of merely \&quot;Bounty\&quot;.  These sub-types are provided for historical compatibility with Destiny 1, but an ideal alternative is to use DestinyItemCategoryDefinitions and the DestinyItemDefinition.itemCategories property instead. Item Categories allow for arbitrary hierarchies of specificity, and for items to belong to multiple categories across multiple hierarchies simultaneously. For this enum, we pick a single type as a \&quot;best guess\&quot; fit.  NOTE: This is not all of the item types available, and some of these are holdovers from Destiny 1 that may or may not still exist.
    /// </summary>
    /// <value>This Enumeration further classifies items by more specific categorizations than DestinyItemType. The \&quot;Sub-Type\&quot; is where we classify and categorize items one step further in specificity: \&quot;Auto Rifle\&quot; instead of just \&quot;Weapon\&quot; for example, or \&quot;Vanguard Bounty\&quot; instead of merely \&quot;Bounty\&quot;.  These sub-types are provided for historical compatibility with Destiny 1, but an ideal alternative is to use DestinyItemCategoryDefinitions and the DestinyItemDefinition.itemCategories property instead. Item Categories allow for arbitrary hierarchies of specificity, and for items to belong to multiple categories across multiple hierarchies simultaneously. For this enum, we pick a single type as a \&quot;best guess\&quot; fit.  NOTE: This is not all of the item types available, and some of these are holdovers from Destiny 1 that may or may not still exist.</value>
    public enum DestinyDestinyItemSubType
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
        _2 = 3,
        
        /// <summary>
        /// Enum _5
        /// </summary>
        _5 = 4,
        
        /// <summary>
        /// Enum _6
        /// </summary>
        _6 = 5,
        
        /// <summary>
        /// Enum _7
        /// </summary>
        _7 = 6,
        
        /// <summary>
        /// Enum _8
        /// </summary>
        _8 = 7,
        
        /// <summary>
        /// Enum _9
        /// </summary>
        _9 = 8,
        
        /// <summary>
        /// Enum _10
        /// </summary>
        _10 = 9,
        
        /// <summary>
        /// Enum _11
        /// </summary>
        _11 = 10,
        
        /// <summary>
        /// Enum _12
        /// </summary>
        _12 = 11,
        
        /// <summary>
        /// Enum _13
        /// </summary>
        _13 = 12,
        
        /// <summary>
        /// Enum _14
        /// </summary>
        _14 = 13,
        
        /// <summary>
        /// Enum _16
        /// </summary>
        _16 = 14,
        
        /// <summary>
        /// Enum _17
        /// </summary>
        _17 = 15,
        
        /// <summary>
        /// Enum _18
        /// </summary>
        _18 = 16,
        
        /// <summary>
        /// Enum _19
        /// </summary>
        _19 = 17,
        
        /// <summary>
        /// Enum _20
        /// </summary>
        _20 = 18,
        
        /// <summary>
        /// Enum _21
        /// </summary>
        _21 = 19,
        
        /// <summary>
        /// Enum _22
        /// </summary>
        _22 = 20,
        
        /// <summary>
        /// Enum _23
        /// </summary>
        _23 = 21,
        
        /// <summary>
        /// Enum _24
        /// </summary>
        _24 = 22,
        
        /// <summary>
        /// Enum _25
        /// </summary>
        _25 = 23,
        
        /// <summary>
        /// Enum _26
        /// </summary>
        _26 = 24,
        
        /// <summary>
        /// Enum _27
        /// </summary>
        _27 = 25,
        
        /// <summary>
        /// Enum _28
        /// </summary>
        _28 = 26,
        
        /// <summary>
        /// Enum _29
        /// </summary>
        _29 = 27,
        
        /// <summary>
        /// Enum _30
        /// </summary>
        _30 = 28,
        
        /// <summary>
        /// Enum _31
        /// </summary>
        _31 = 29
    }

}