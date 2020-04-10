using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Used for setting the guided game permission level override (admins and founders can always host guided games).
    /// </summary>
    /// <value>Used for setting the guided game permission level override (admins and founders can always host guided games).</value>
    public enum GroupsV2HostGuidedGamesPermissionLevel
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