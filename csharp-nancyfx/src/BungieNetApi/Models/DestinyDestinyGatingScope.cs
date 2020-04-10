using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// This enumeration represents the most restrictive type of gating that is being performed by an entity. This is useful as a shortcut to avoid a lot of lookups when determining whether the gating on an Entity applies to everyone equally, or to their specific Profile or Character states.  None &#x3D; There is no gating on this item.  Global &#x3D; The gating on this item is based entirely on global game state. It will be gated the same for everyone.  Clan &#x3D; The gating on this item is at the Clan level. For instance, if you&#39;re gated by Clan level this will be the case.  Profile &#x3D; The gating includes Profile-specific checks, but not on the Profile&#39;s characters. An example of this might be when you acquire an Emblem: the Emblem will be available in your Kiosk for all characters in your Profile from that point onward.  Character &#x3D; The gating includes Character-specific checks, including character level restrictions. An example of this might be an item that you can&#39;t purchase from a Vendor until you reach a specific Character Level.  Item &#x3D; The gating includes item-specific checks. For BNet, this generally implies that we&#39;ll show this data only on a character level or deeper.  AssumedWorstCase &#x3D; The unlocks and checks being used for this calculation are of an unknown type and are used for unknown purposes. For instance, if some great person decided that an unlock value should be globally scoped, but then the game changes it using character-specific data in a way that BNet doesn&#39;t know about. Because of the open-ended potential for this to occur, many unlock checks for \&quot;globally\&quot; scoped unlock data may be assumed as the worst case unless it has been specifically whitelisted as otherwise. That sucks, but them&#39;s the breaks.
    /// </summary>
    /// <value>This enumeration represents the most restrictive type of gating that is being performed by an entity. This is useful as a shortcut to avoid a lot of lookups when determining whether the gating on an Entity applies to everyone equally, or to their specific Profile or Character states.  None &#x3D; There is no gating on this item.  Global &#x3D; The gating on this item is based entirely on global game state. It will be gated the same for everyone.  Clan &#x3D; The gating on this item is at the Clan level. For instance, if you&#39;re gated by Clan level this will be the case.  Profile &#x3D; The gating includes Profile-specific checks, but not on the Profile&#39;s characters. An example of this might be when you acquire an Emblem: the Emblem will be available in your Kiosk for all characters in your Profile from that point onward.  Character &#x3D; The gating includes Character-specific checks, including character level restrictions. An example of this might be an item that you can&#39;t purchase from a Vendor until you reach a specific Character Level.  Item &#x3D; The gating includes item-specific checks. For BNet, this generally implies that we&#39;ll show this data only on a character level or deeper.  AssumedWorstCase &#x3D; The unlocks and checks being used for this calculation are of an unknown type and are used for unknown purposes. For instance, if some great person decided that an unlock value should be globally scoped, but then the game changes it using character-specific data in a way that BNet doesn&#39;t know about. Because of the open-ended potential for this to occur, many unlock checks for \&quot;globally\&quot; scoped unlock data may be assumed as the worst case unless it has been specifically whitelisted as otherwise. That sucks, but them&#39;s the breaks.</value>
    public enum DestinyDestinyGatingScope
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
        /// Enum _4
        /// </summary>
        _4 = 5,
        
        /// <summary>
        /// Enum _5
        /// </summary>
        _5 = 6,
        
        /// <summary>
        /// Enum _6
        /// </summary>
        _6 = 7
    }

}