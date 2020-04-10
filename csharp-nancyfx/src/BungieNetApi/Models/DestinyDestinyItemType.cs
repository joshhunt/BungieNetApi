using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// An enumeration that indicates the high-level \&quot;type\&quot; of the item, attempting to iron out the context specific differences for specific instances of an entity. For instance, though a weapon may be of various weapon \&quot;Types\&quot;, in DestinyItemType they are all classified as \&quot;Weapon\&quot;. This allows for better filtering on a higher level of abstraction for the concept of types.   This enum is provided for historical compatibility with Destiny 1, but an ideal alternative is to use DestinyItemCategoryDefinitions and the DestinyItemDefinition.itemCategories property instead. Item Categories allow for arbitrary hierarchies of specificity, and for items to belong to multiple categories across multiple hierarchies simultaneously. For this enum, we pick a single type as a \&quot;best guess\&quot; fit.   NOTE: This is not all of the item types available, and some of these are holdovers from Destiny 1 that may or may not still exist.   I keep updating these because they&#39;re so damn convenient. I guess I shouldn&#39;t fight it.
    /// </summary>
    /// <value>An enumeration that indicates the high-level \&quot;type\&quot; of the item, attempting to iron out the context specific differences for specific instances of an entity. For instance, though a weapon may be of various weapon \&quot;Types\&quot;, in DestinyItemType they are all classified as \&quot;Weapon\&quot;. This allows for better filtering on a higher level of abstraction for the concept of types.   This enum is provided for historical compatibility with Destiny 1, but an ideal alternative is to use DestinyItemCategoryDefinitions and the DestinyItemDefinition.itemCategories property instead. Item Categories allow for arbitrary hierarchies of specificity, and for items to belong to multiple categories across multiple hierarchies simultaneously. For this enum, we pick a single type as a \&quot;best guess\&quot; fit.   NOTE: This is not all of the item types available, and some of these are holdovers from Destiny 1 that may or may not still exist.   I keep updating these because they&#39;re so damn convenient. I guess I shouldn&#39;t fight it.</value>
    public enum DestinyDestinyItemType
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
        /// Enum _3
        /// </summary>
        _3 = 4,
        
        /// <summary>
        /// Enum _7
        /// </summary>
        _7 = 5,
        
        /// <summary>
        /// Enum _8
        /// </summary>
        _8 = 6,
        
        /// <summary>
        /// Enum _9
        /// </summary>
        _9 = 7,
        
        /// <summary>
        /// Enum _10
        /// </summary>
        _10 = 8,
        
        /// <summary>
        /// Enum _11
        /// </summary>
        _11 = 9,
        
        /// <summary>
        /// Enum _12
        /// </summary>
        _12 = 10,
        
        /// <summary>
        /// Enum _13
        /// </summary>
        _13 = 11,
        
        /// <summary>
        /// Enum _14
        /// </summary>
        _14 = 12,
        
        /// <summary>
        /// Enum _15
        /// </summary>
        _15 = 13,
        
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
        _29 = 27
    }

}