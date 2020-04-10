using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// If you look in the DestinyInventoryItemDefinition&#39;s \&quot;sockets\&quot; property, you&#39;ll see that there are two types of sockets: intrinsic, and \&quot;socketEntry.\&quot;  Unfortunately, because Intrinsic sockets are a whole separate array, it is no longer sufficient to know the index into that array to know which socket we&#39;re talking about. You have to know whether it&#39;s in the default \&quot;socketEntries\&quot; or if it&#39;s in the \&quot;intrinsic\&quot; list.
    /// </summary>
    /// <value>If you look in the DestinyInventoryItemDefinition&#39;s \&quot;sockets\&quot; property, you&#39;ll see that there are two types of sockets: intrinsic, and \&quot;socketEntry.\&quot;  Unfortunately, because Intrinsic sockets are a whole separate array, it is no longer sufficient to know the index into that array to know which socket we&#39;re talking about. You have to know whether it&#39;s in the default \&quot;socketEntries\&quot; or if it&#39;s in the \&quot;intrinsic\&quot; list.</value>
    public enum DestinyRequestsActionsDestinySocketArrayType
    {
        
        /// <summary>
        /// Enum _0
        /// </summary>
        _0 = 1,
        
        /// <summary>
        /// Enum _1
        /// </summary>
        _1 = 2
    }

}