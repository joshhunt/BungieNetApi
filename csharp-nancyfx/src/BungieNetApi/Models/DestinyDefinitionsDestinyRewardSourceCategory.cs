using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// BNet&#39;s custom categorization of reward sources. We took a look at the existing ways that items could be spawned, and tried to make high-level categorizations of them. This needs to be re-evaluated for Destiny 2.
    /// </summary>
    /// <value>BNet&#39;s custom categorization of reward sources. We took a look at the existing ways that items could be spawned, and tried to make high-level categorizations of them. This needs to be re-evaluated for Destiny 2.</value>
    public enum DestinyDefinitionsDestinyRewardSourceCategory
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
        _3 = 4
    }

}