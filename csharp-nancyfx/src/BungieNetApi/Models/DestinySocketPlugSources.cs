using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Indicates how a socket is populated, and where you should look for valid plug data.   This is a flags enumeration/bitmask field, as you may have to look in multiple sources across multiple components for valid plugs.   For instance, a socket could have plugs that are sourced from its own definition, as well as plugs that are sourced from Character-scoped AND profile-scoped Plug Sets. Only by combining plug data for every indicated source will you be able to know all of the plugs available for a socket.
    /// </summary>
    /// <value>Indicates how a socket is populated, and where you should look for valid plug data.   This is a flags enumeration/bitmask field, as you may have to look in multiple sources across multiple components for valid plugs.   For instance, a socket could have plugs that are sourced from its own definition, as well as plugs that are sourced from Character-scoped AND profile-scoped Plug Sets. Only by combining plug data for every indicated source will you be able to know all of the plugs available for a socket.</value>
    public enum DestinySocketPlugSources
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
        _8 = 5
    }

}