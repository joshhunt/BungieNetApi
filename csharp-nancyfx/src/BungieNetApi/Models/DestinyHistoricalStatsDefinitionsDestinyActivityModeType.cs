using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// For historical reasons, this list will have both D1 and D2-relevant Activity Modes in it. Please don&#39;t take this to mean that some D1-only feature is coming back!
    /// </summary>
    /// <value>For historical reasons, this list will have both D1 and D2-relevant Activity Modes in it. Please don&#39;t take this to mean that some D1-only feature is coming back!</value>
    public enum DestinyHistoricalStatsDefinitionsDestinyActivityModeType
    {
        
        /// <summary>
        /// Enum _0
        /// </summary>
        _0 = 1,
        
        /// <summary>
        /// Enum _2
        /// </summary>
        _2 = 2,
        
        /// <summary>
        /// Enum _3
        /// </summary>
        _3 = 3,
        
        /// <summary>
        /// Enum _4
        /// </summary>
        _4 = 4,
        
        /// <summary>
        /// Enum _5
        /// </summary>
        _5 = 5,
        
        /// <summary>
        /// Enum _6
        /// </summary>
        _6 = 6,
        
        /// <summary>
        /// Enum _7
        /// </summary>
        _7 = 7,
        
        /// <summary>
        /// Enum _9
        /// </summary>
        _9 = 8,
        
        /// <summary>
        /// Enum _10
        /// </summary>
        _10 = 9,
        
        /// <summary>
        /// Enum _11
        /// </summary>
        _11 = 10,
        
        /// <summary>
        /// Enum _12
        /// </summary>
        _12 = 11,
        
        /// <summary>
        /// Enum _13
        /// </summary>
        _13 = 12,
        
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
        /// Enum _24
        /// </summary>
        _24 = 21,
        
        /// <summary>
        /// Enum _25
        /// </summary>
        _25 = 22,
        
        /// <summary>
        /// Enum _26
        /// </summary>
        _26 = 23,
        
        /// <summary>
        /// Enum _27
        /// </summary>
        _27 = 24,
        
        /// <summary>
        /// Enum _28
        /// </summary>
        _28 = 25,
        
        /// <summary>
        /// Enum _29
        /// </summary>
        _29 = 26,
        
        /// <summary>
        /// Enum _30
        /// </summary>
        _30 = 27,
        
        /// <summary>
        /// Enum _31
        /// </summary>
        _31 = 28,
        
        /// <summary>
        /// Enum _32
        /// </summary>
        _32 = 29,
        
        /// <summary>
        /// Enum _37
        /// </summary>
        _37 = 30,
        
        /// <summary>
        /// Enum _38
        /// </summary>
        _38 = 31,
        
        /// <summary>
        /// Enum _39
        /// </summary>
        _39 = 32,
        
        /// <summary>
        /// Enum _40
        /// </summary>
        _40 = 33,
        
        /// <summary>
        /// Enum _41
        /// </summary>
        _41 = 34,
        
        /// <summary>
        /// Enum _42
        /// </summary>
        _42 = 35,
        
        /// <summary>
        /// Enum _43
        /// </summary>
        _43 = 36,
        
        /// <summary>
        /// Enum _44
        /// </summary>
        _44 = 37,
        
        /// <summary>
        /// Enum _45
        /// </summary>
        _45 = 38,
        
        /// <summary>
        /// Enum _46
        /// </summary>
        _46 = 39,
        
        /// <summary>
        /// Enum _47
        /// </summary>
        _47 = 40,
        
        /// <summary>
        /// Enum _48
        /// </summary>
        _48 = 41,
        
        /// <summary>
        /// Enum _49
        /// </summary>
        _49 = 42,
        
        /// <summary>
        /// Enum _50
        /// </summary>
        _50 = 43,
        
        /// <summary>
        /// Enum _51
        /// </summary>
        _51 = 44,
        
        /// <summary>
        /// Enum _52
        /// </summary>
        _52 = 45,
        
        /// <summary>
        /// Enum _53
        /// </summary>
        _53 = 46,
        
        /// <summary>
        /// Enum _54
        /// </summary>
        _54 = 47,
        
        /// <summary>
        /// Enum _55
        /// </summary>
        _55 = 48,
        
        /// <summary>
        /// Enum _56
        /// </summary>
        _56 = 49,
        
        /// <summary>
        /// Enum _57
        /// </summary>
        _57 = 50,
        
        /// <summary>
        /// Enum _58
        /// </summary>
        _58 = 51,
        
        /// <summary>
        /// Enum _59
        /// </summary>
        _59 = 52,
        
        /// <summary>
        /// Enum _60
        /// </summary>
        _60 = 53,
        
        /// <summary>
        /// Enum _61
        /// </summary>
        _61 = 54,
        
        /// <summary>
        /// Enum _62
        /// </summary>
        _62 = 55,
        
        /// <summary>
        /// Enum _63
        /// </summary>
        _63 = 56,
        
        /// <summary>
        /// Enum _64
        /// </summary>
        _64 = 57,
        
        /// <summary>
        /// Enum _65
        /// </summary>
        _65 = 58,
        
        /// <summary>
        /// Enum _66
        /// </summary>
        _66 = 59,
        
        /// <summary>
        /// Enum _67
        /// </summary>
        _67 = 60,
        
        /// <summary>
        /// Enum _68
        /// </summary>
        _68 = 61,
        
        /// <summary>
        /// Enum _69
        /// </summary>
        _69 = 62,
        
        /// <summary>
        /// Enum _70
        /// </summary>
        _70 = 63,
        
        /// <summary>
        /// Enum _71
        /// </summary>
        _71 = 64,
        
        /// <summary>
        /// Enum _72
        /// </summary>
        _72 = 65,
        
        /// <summary>
        /// Enum _73
        /// </summary>
        _73 = 66,
        
        /// <summary>
        /// Enum _74
        /// </summary>
        _74 = 67,
        
        /// <summary>
        /// Enum _75
        /// </summary>
        _75 = 68,
        
        /// <summary>
        /// Enum _76
        /// </summary>
        _76 = 69,
        
        /// <summary>
        /// Enum _77
        /// </summary>
        _77 = 70,
        
        /// <summary>
        /// Enum _78
        /// </summary>
        _78 = 71,
        
        /// <summary>
        /// Enum _79
        /// </summary>
        _79 = 72,
        
        /// <summary>
        /// Enum _80
        /// </summary>
        _80 = 73,
        
        /// <summary>
        /// Enum _81
        /// </summary>
        _81 = 74,
        
        /// <summary>
        /// Enum _82
        /// </summary>
        _82 = 75,
        
        /// <summary>
        /// Enum _83
        /// </summary>
        _83 = 76,
        
        /// <summary>
        /// Enum _84
        /// </summary>
        _84 = 77
    }

}