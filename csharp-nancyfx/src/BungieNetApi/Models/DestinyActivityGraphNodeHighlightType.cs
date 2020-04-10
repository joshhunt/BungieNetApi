using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// The various known UI styles in which an item can be highlighted. It&#39;ll be up to you to determine what you want to show based on this highlighting, BNet doesn&#39;t have any assets that correspond to these states. And yeah, RiseOfIron and Comet have their own special highlight states. Don&#39;t ask me, I can&#39;t imagine they&#39;re still used.
    /// </summary>
    /// <value>The various known UI styles in which an item can be highlighted. It&#39;ll be up to you to determine what you want to show based on this highlighting, BNet doesn&#39;t have any assets that correspond to these states. And yeah, RiseOfIron and Comet have their own special highlight states. Don&#39;t ask me, I can&#39;t imagine they&#39;re still used.</value>
    public enum DestinyActivityGraphNodeHighlightType
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
        _4 = 5
    }

}