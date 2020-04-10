using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// A Flags Enumeration/bitmask where each bit represents a different state that the Collectible can be in. A collectible can be in any number of these states, and you can choose to use or ignore any or all of them when making your own UI that shows Collectible info. Our displays are going to honor them, but we&#39;re also the kind of people who only pretend to inhale before quickly passing it to the left. So, you know, do what you got to do.  (All joking aside, please note the caveat I mention around the Invisible flag: there are cases where it is in the best interest of your users to honor these flags even if you&#39;re a \&quot;show all the data\&quot; person. Collector-oriented compulsion is a very unfortunate and real thing, and I would hate to instill that compulsion in others through showing them items that they cannot earn. Please consider this when you are making your own apps/sites.)
    /// </summary>
    /// <value>A Flags Enumeration/bitmask where each bit represents a different state that the Collectible can be in. A collectible can be in any number of these states, and you can choose to use or ignore any or all of them when making your own UI that shows Collectible info. Our displays are going to honor them, but we&#39;re also the kind of people who only pretend to inhale before quickly passing it to the left. So, you know, do what you got to do.  (All joking aside, please note the caveat I mention around the Invisible flag: there are cases where it is in the best interest of your users to honor these flags even if you&#39;re a \&quot;show all the data\&quot; person. Collector-oriented compulsion is a very unfortunate and real thing, and I would hate to instill that compulsion in others through showing them items that they cannot earn. Please consider this when you are making your own apps/sites.)</value>
    public enum DestinyDestinyCollectibleState
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
        /// Enum _4
        /// </summary>
        _4 = 4,
        
        /// <summary>
        /// Enum _8
        /// </summary>
        _8 = 5,
        
        /// <summary>
        /// Enum _16
        /// </summary>
        _16 = 6,
        
        /// <summary>
        /// Enum _32
        /// </summary>
        _32 = 7,
        
        /// <summary>
        /// Enum _64
        /// </summary>
        _64 = 8
    }

}