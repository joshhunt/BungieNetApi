using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Represents the possible components that can be returned from Destiny \&quot;Get\&quot; calls such as GetProfile, GetCharacter, GetVendor etc...  When making one of these requests, you will pass one or more of these components as a comma separated list in the \&quot;?components&#x3D;\&quot; querystring parameter. For instance, if you want baseline Profile data, Character Data, and character progressions, you would pass \&quot;?components&#x3D;Profiles,Characters,CharacterProgressions\&quot; You may use either the numerical or string values.
    /// </summary>
    /// <value>Represents the possible components that can be returned from Destiny \&quot;Get\&quot; calls such as GetProfile, GetCharacter, GetVendor etc...  When making one of these requests, you will pass one or more of these components as a comma separated list in the \&quot;?components&#x3D;\&quot; querystring parameter. For instance, if you want baseline Profile data, Character Data, and character progressions, you would pass \&quot;?components&#x3D;Profiles,Characters,CharacterProgressions\&quot; You may use either the numerical or string values.</value>
    public enum DestinyDestinyComponentType
    {
        
        /// <summary>
        /// Enum _0
        /// </summary>
        _0 = 1,
        
        /// <summary>
        /// Enum _100
        /// </summary>
        _100 = 2,
        
        /// <summary>
        /// Enum _101
        /// </summary>
        _101 = 3,
        
        /// <summary>
        /// Enum _102
        /// </summary>
        _102 = 4,
        
        /// <summary>
        /// Enum _103
        /// </summary>
        _103 = 5,
        
        /// <summary>
        /// Enum _104
        /// </summary>
        _104 = 6,
        
        /// <summary>
        /// Enum _105
        /// </summary>
        _105 = 7,
        
        /// <summary>
        /// Enum _200
        /// </summary>
        _200 = 8,
        
        /// <summary>
        /// Enum _201
        /// </summary>
        _201 = 9,
        
        /// <summary>
        /// Enum _202
        /// </summary>
        _202 = 10,
        
        /// <summary>
        /// Enum _203
        /// </summary>
        _203 = 11,
        
        /// <summary>
        /// Enum _204
        /// </summary>
        _204 = 12,
        
        /// <summary>
        /// Enum _205
        /// </summary>
        _205 = 13,
        
        /// <summary>
        /// Enum _300
        /// </summary>
        _300 = 14,
        
        /// <summary>
        /// Enum _301
        /// </summary>
        _301 = 15,
        
        /// <summary>
        /// Enum _302
        /// </summary>
        _302 = 16,
        
        /// <summary>
        /// Enum _303
        /// </summary>
        _303 = 17,
        
        /// <summary>
        /// Enum _304
        /// </summary>
        _304 = 18,
        
        /// <summary>
        /// Enum _305
        /// </summary>
        _305 = 19,
        
        /// <summary>
        /// Enum _306
        /// </summary>
        _306 = 20,
        
        /// <summary>
        /// Enum _307
        /// </summary>
        _307 = 21,
        
        /// <summary>
        /// Enum _308
        /// </summary>
        _308 = 22,
        
        /// <summary>
        /// Enum _309
        /// </summary>
        _309 = 23,
        
        /// <summary>
        /// Enum _310
        /// </summary>
        _310 = 24,
        
        /// <summary>
        /// Enum _400
        /// </summary>
        _400 = 25,
        
        /// <summary>
        /// Enum _401
        /// </summary>
        _401 = 26,
        
        /// <summary>
        /// Enum _402
        /// </summary>
        _402 = 27,
        
        /// <summary>
        /// Enum _500
        /// </summary>
        _500 = 28,
        
        /// <summary>
        /// Enum _600
        /// </summary>
        _600 = 29,
        
        /// <summary>
        /// Enum _700
        /// </summary>
        _700 = 30,
        
        /// <summary>
        /// Enum _800
        /// </summary>
        _800 = 31,
        
        /// <summary>
        /// Enum _900
        /// </summary>
        _900 = 32,
        
        /// <summary>
        /// Enum _1000
        /// </summary>
        _1000 = 33,
        
        /// <summary>
        /// Enum _1100
        /// </summary>
        _1100 = 34
    }

}