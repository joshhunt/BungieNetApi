using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// This Block defines the rendering data associated with the item, if any.
    /// </summary>
    public sealed class DestinyDefinitionsDestinyItemTranslationBlockDefinition:  IEquatable<DestinyDefinitionsDestinyItemTranslationBlockDefinition>
    { 
        /// <summary>
        /// WeaponPatternIdentifier
        /// </summary>
        public string WeaponPatternIdentifier { get; private set; }

        /// <summary>
        /// WeaponPatternHash
        /// </summary>
        public int? WeaponPatternHash { get; private set; }

        /// <summary>
        /// DefaultDyes
        /// </summary>
        public List<DestinyDyeReference> DefaultDyes { get; private set; }

        /// <summary>
        /// LockedDyes
        /// </summary>
        public List<DestinyDyeReference> LockedDyes { get; private set; }

        /// <summary>
        /// CustomDyes
        /// </summary>
        public List<DestinyDyeReference> CustomDyes { get; private set; }

        /// <summary>
        /// Arrangements
        /// </summary>
        public List<DestinyDefinitionsDestinyGearArtArrangementReference> Arrangements { get; private set; }

        /// <summary>
        /// HasGeometry
        /// </summary>
        public bool? HasGeometry { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsDestinyItemTranslationBlockDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyItemTranslationBlockDefinition()
        {
        }

        private DestinyDefinitionsDestinyItemTranslationBlockDefinition(string WeaponPatternIdentifier, int? WeaponPatternHash, List<DestinyDyeReference> DefaultDyes, List<DestinyDyeReference> LockedDyes, List<DestinyDyeReference> CustomDyes, List<DestinyDefinitionsDestinyGearArtArrangementReference> Arrangements, bool? HasGeometry)
        {
            
            this.WeaponPatternIdentifier = WeaponPatternIdentifier;
            
            this.WeaponPatternHash = WeaponPatternHash;
            
            this.DefaultDyes = DefaultDyes;
            
            this.LockedDyes = LockedDyes;
            
            this.CustomDyes = CustomDyes;
            
            this.Arrangements = Arrangements;
            
            this.HasGeometry = HasGeometry;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyItemTranslationBlockDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyItemTranslationBlockDefinitionBuilder</returns>
        public static DestinyDefinitionsDestinyItemTranslationBlockDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsDestinyItemTranslationBlockDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyItemTranslationBlockDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyItemTranslationBlockDefinitionBuilder</returns>
        public DestinyDefinitionsDestinyItemTranslationBlockDefinitionBuilder With()
        {
            return Builder()
                .WeaponPatternIdentifier(WeaponPatternIdentifier)
                .WeaponPatternHash(WeaponPatternHash)
                .DefaultDyes(DefaultDyes)
                .LockedDyes(LockedDyes)
                .CustomDyes(CustomDyes)
                .Arrangements(Arrangements)
                .HasGeometry(HasGeometry);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsDestinyItemTranslationBlockDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyItemTranslationBlockDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyItemTranslationBlockDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyItemTranslationBlockDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyItemTranslationBlockDefinition left, DestinyDefinitionsDestinyItemTranslationBlockDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyItemTranslationBlockDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyItemTranslationBlockDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyItemTranslationBlockDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyItemTranslationBlockDefinition left, DestinyDefinitionsDestinyItemTranslationBlockDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyItemTranslationBlockDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyItemTranslationBlockDefinitionBuilder
        {
            private string _WeaponPatternIdentifier;
            private int? _WeaponPatternHash;
            private List<DestinyDyeReference> _DefaultDyes;
            private List<DestinyDyeReference> _LockedDyes;
            private List<DestinyDyeReference> _CustomDyes;
            private List<DestinyDefinitionsDestinyGearArtArrangementReference> _Arrangements;
            private bool? _HasGeometry;

            internal DestinyDefinitionsDestinyItemTranslationBlockDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemTranslationBlockDefinition.WeaponPatternIdentifier property.
            /// </summary>
            /// <param name="value">WeaponPatternIdentifier</param>
            public DestinyDefinitionsDestinyItemTranslationBlockDefinitionBuilder WeaponPatternIdentifier(string value)
            {
                _WeaponPatternIdentifier = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemTranslationBlockDefinition.WeaponPatternHash property.
            /// </summary>
            /// <param name="value">WeaponPatternHash</param>
            public DestinyDefinitionsDestinyItemTranslationBlockDefinitionBuilder WeaponPatternHash(int? value)
            {
                _WeaponPatternHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemTranslationBlockDefinition.DefaultDyes property.
            /// </summary>
            /// <param name="value">DefaultDyes</param>
            public DestinyDefinitionsDestinyItemTranslationBlockDefinitionBuilder DefaultDyes(List<DestinyDyeReference> value)
            {
                _DefaultDyes = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemTranslationBlockDefinition.LockedDyes property.
            /// </summary>
            /// <param name="value">LockedDyes</param>
            public DestinyDefinitionsDestinyItemTranslationBlockDefinitionBuilder LockedDyes(List<DestinyDyeReference> value)
            {
                _LockedDyes = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemTranslationBlockDefinition.CustomDyes property.
            /// </summary>
            /// <param name="value">CustomDyes</param>
            public DestinyDefinitionsDestinyItemTranslationBlockDefinitionBuilder CustomDyes(List<DestinyDyeReference> value)
            {
                _CustomDyes = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemTranslationBlockDefinition.Arrangements property.
            /// </summary>
            /// <param name="value">Arrangements</param>
            public DestinyDefinitionsDestinyItemTranslationBlockDefinitionBuilder Arrangements(List<DestinyDefinitionsDestinyGearArtArrangementReference> value)
            {
                _Arrangements = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemTranslationBlockDefinition.HasGeometry property.
            /// </summary>
            /// <param name="value">HasGeometry</param>
            public DestinyDefinitionsDestinyItemTranslationBlockDefinitionBuilder HasGeometry(bool? value)
            {
                _HasGeometry = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyItemTranslationBlockDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyItemTranslationBlockDefinition</returns>
            public DestinyDefinitionsDestinyItemTranslationBlockDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyItemTranslationBlockDefinition(
                    WeaponPatternIdentifier: _WeaponPatternIdentifier,
                    WeaponPatternHash: _WeaponPatternHash,
                    DefaultDyes: _DefaultDyes,
                    LockedDyes: _LockedDyes,
                    CustomDyes: _CustomDyes,
                    Arrangements: _Arrangements,
                    HasGeometry: _HasGeometry
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}