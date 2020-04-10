using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Raw data about the customization options chosen for a character&#39;s face and appearance.  You can look up the relevant class/race/gender combo in DestinyCharacterCustomizationOptionDefinition for the character, and then look up these values within the CustomizationOptions found to pull some data about their choices. Warning: not all of that data is meaningful. Some data has useful icons. Others have nothing, and are only meant for 3D rendering purposes (which we sadly do not expose yet)
    /// </summary>
    public sealed class DestinyCharacterDestinyCharacterCustomization:  IEquatable<DestinyCharacterDestinyCharacterCustomization>
    { 
        /// <summary>
        /// Personality
        /// </summary>
        public int? Personality { get; private set; }

        /// <summary>
        /// Face
        /// </summary>
        public int? Face { get; private set; }

        /// <summary>
        /// SkinColor
        /// </summary>
        public int? SkinColor { get; private set; }

        /// <summary>
        /// LipColor
        /// </summary>
        public int? LipColor { get; private set; }

        /// <summary>
        /// EyeColor
        /// </summary>
        public int? EyeColor { get; private set; }

        /// <summary>
        /// HairColors
        /// </summary>
        public List<int?> HairColors { get; private set; }

        /// <summary>
        /// FeatureColors
        /// </summary>
        public List<int?> FeatureColors { get; private set; }

        /// <summary>
        /// DecalColor
        /// </summary>
        public int? DecalColor { get; private set; }

        /// <summary>
        /// WearHelmet
        /// </summary>
        public bool? WearHelmet { get; private set; }

        /// <summary>
        /// HairIndex
        /// </summary>
        public int? HairIndex { get; private set; }

        /// <summary>
        /// FeatureIndex
        /// </summary>
        public int? FeatureIndex { get; private set; }

        /// <summary>
        /// DecalIndex
        /// </summary>
        public int? DecalIndex { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyCharacterDestinyCharacterCustomization.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyCharacterDestinyCharacterCustomization()
        {
        }

        private DestinyCharacterDestinyCharacterCustomization(int? Personality, int? Face, int? SkinColor, int? LipColor, int? EyeColor, List<int?> HairColors, List<int?> FeatureColors, int? DecalColor, bool? WearHelmet, int? HairIndex, int? FeatureIndex, int? DecalIndex)
        {
            
            this.Personality = Personality;
            
            this.Face = Face;
            
            this.SkinColor = SkinColor;
            
            this.LipColor = LipColor;
            
            this.EyeColor = EyeColor;
            
            this.HairColors = HairColors;
            
            this.FeatureColors = FeatureColors;
            
            this.DecalColor = DecalColor;
            
            this.WearHelmet = WearHelmet;
            
            this.HairIndex = HairIndex;
            
            this.FeatureIndex = FeatureIndex;
            
            this.DecalIndex = DecalIndex;
            
        }

        /// <summary>
        /// Returns builder of DestinyCharacterDestinyCharacterCustomization.
        /// </summary>
        /// <returns>DestinyCharacterDestinyCharacterCustomizationBuilder</returns>
        public static DestinyCharacterDestinyCharacterCustomizationBuilder Builder()
        {
            return new DestinyCharacterDestinyCharacterCustomizationBuilder();
        }

        /// <summary>
        /// Returns DestinyCharacterDestinyCharacterCustomizationBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyCharacterDestinyCharacterCustomizationBuilder</returns>
        public DestinyCharacterDestinyCharacterCustomizationBuilder With()
        {
            return Builder()
                .Personality(Personality)
                .Face(Face)
                .SkinColor(SkinColor)
                .LipColor(LipColor)
                .EyeColor(EyeColor)
                .HairColors(HairColors)
                .FeatureColors(FeatureColors)
                .DecalColor(DecalColor)
                .WearHelmet(WearHelmet)
                .HairIndex(HairIndex)
                .FeatureIndex(FeatureIndex)
                .DecalIndex(DecalIndex);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyCharacterDestinyCharacterCustomization other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyCharacterDestinyCharacterCustomization.
        /// </summary>
        /// <param name="left">Compared (DestinyCharacterDestinyCharacterCustomization</param>
        /// <param name="right">Compared (DestinyCharacterDestinyCharacterCustomization</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyCharacterDestinyCharacterCustomization left, DestinyCharacterDestinyCharacterCustomization right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyCharacterDestinyCharacterCustomization.
        /// </summary>
        /// <param name="left">Compared (DestinyCharacterDestinyCharacterCustomization</param>
        /// <param name="right">Compared (DestinyCharacterDestinyCharacterCustomization</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyCharacterDestinyCharacterCustomization left, DestinyCharacterDestinyCharacterCustomization right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyCharacterDestinyCharacterCustomization.
        /// </summary>
        public sealed class DestinyCharacterDestinyCharacterCustomizationBuilder
        {
            private int? _Personality;
            private int? _Face;
            private int? _SkinColor;
            private int? _LipColor;
            private int? _EyeColor;
            private List<int?> _HairColors;
            private List<int?> _FeatureColors;
            private int? _DecalColor;
            private bool? _WearHelmet;
            private int? _HairIndex;
            private int? _FeatureIndex;
            private int? _DecalIndex;

            internal DestinyCharacterDestinyCharacterCustomizationBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyCharacterDestinyCharacterCustomization.Personality property.
            /// </summary>
            /// <param name="value">Personality</param>
            public DestinyCharacterDestinyCharacterCustomizationBuilder Personality(int? value)
            {
                _Personality = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyCharacterDestinyCharacterCustomization.Face property.
            /// </summary>
            /// <param name="value">Face</param>
            public DestinyCharacterDestinyCharacterCustomizationBuilder Face(int? value)
            {
                _Face = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyCharacterDestinyCharacterCustomization.SkinColor property.
            /// </summary>
            /// <param name="value">SkinColor</param>
            public DestinyCharacterDestinyCharacterCustomizationBuilder SkinColor(int? value)
            {
                _SkinColor = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyCharacterDestinyCharacterCustomization.LipColor property.
            /// </summary>
            /// <param name="value">LipColor</param>
            public DestinyCharacterDestinyCharacterCustomizationBuilder LipColor(int? value)
            {
                _LipColor = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyCharacterDestinyCharacterCustomization.EyeColor property.
            /// </summary>
            /// <param name="value">EyeColor</param>
            public DestinyCharacterDestinyCharacterCustomizationBuilder EyeColor(int? value)
            {
                _EyeColor = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyCharacterDestinyCharacterCustomization.HairColors property.
            /// </summary>
            /// <param name="value">HairColors</param>
            public DestinyCharacterDestinyCharacterCustomizationBuilder HairColors(List<int?> value)
            {
                _HairColors = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyCharacterDestinyCharacterCustomization.FeatureColors property.
            /// </summary>
            /// <param name="value">FeatureColors</param>
            public DestinyCharacterDestinyCharacterCustomizationBuilder FeatureColors(List<int?> value)
            {
                _FeatureColors = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyCharacterDestinyCharacterCustomization.DecalColor property.
            /// </summary>
            /// <param name="value">DecalColor</param>
            public DestinyCharacterDestinyCharacterCustomizationBuilder DecalColor(int? value)
            {
                _DecalColor = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyCharacterDestinyCharacterCustomization.WearHelmet property.
            /// </summary>
            /// <param name="value">WearHelmet</param>
            public DestinyCharacterDestinyCharacterCustomizationBuilder WearHelmet(bool? value)
            {
                _WearHelmet = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyCharacterDestinyCharacterCustomization.HairIndex property.
            /// </summary>
            /// <param name="value">HairIndex</param>
            public DestinyCharacterDestinyCharacterCustomizationBuilder HairIndex(int? value)
            {
                _HairIndex = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyCharacterDestinyCharacterCustomization.FeatureIndex property.
            /// </summary>
            /// <param name="value">FeatureIndex</param>
            public DestinyCharacterDestinyCharacterCustomizationBuilder FeatureIndex(int? value)
            {
                _FeatureIndex = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyCharacterDestinyCharacterCustomization.DecalIndex property.
            /// </summary>
            /// <param name="value">DecalIndex</param>
            public DestinyCharacterDestinyCharacterCustomizationBuilder DecalIndex(int? value)
            {
                _DecalIndex = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyCharacterDestinyCharacterCustomization.
            /// </summary>
            /// <returns>DestinyCharacterDestinyCharacterCustomization</returns>
            public DestinyCharacterDestinyCharacterCustomization Build()
            {
                Validate();
                return new DestinyCharacterDestinyCharacterCustomization(
                    Personality: _Personality,
                    Face: _Face,
                    SkinColor: _SkinColor,
                    LipColor: _LipColor,
                    EyeColor: _EyeColor,
                    HairColors: _HairColors,
                    FeatureColors: _FeatureColors,
                    DecalColor: _DecalColor,
                    WearHelmet: _WearHelmet,
                    HairIndex: _HairIndex,
                    FeatureIndex: _FeatureIndex,
                    DecalIndex: _DecalIndex
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}