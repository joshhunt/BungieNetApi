using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// The possible states of Destiny Profile Records. IMPORTANT: Any given item can theoretically have many of these states simultaneously: as a result, this was altered to be a flags enumeration/bitmask for v3.2.0.
    /// </summary>
    /// <value>The possible states of Destiny Profile Records. IMPORTANT: Any given item can theoretically have many of these states simultaneously: as a result, this was altered to be a flags enumeration/bitmask for v3.2.0.</value>
    public enum DestinyDestinyVendorItemState
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
        _64 = 8,
        
        /// <summary>
        /// Enum _128
        /// </summary>
        _128 = 9,
        
        /// <summary>
        /// Enum _256
        /// </summary>
        _256 = 10,
        
        /// <summary>
        /// Enum _512
        /// </summary>
        _512 = 11,
        
        /// <summary>
        /// Enum _1024
        /// </summary>
        _1024 = 12,
        
        /// <summary>
        /// Enum _2048
        /// </summary>
        _2048 = 13,
        
        /// <summary>
        /// Enum _4096
        /// </summary>
        _4096 = 14
    }

}