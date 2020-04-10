using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyDefinitionsDestinyObjectiveDisplayProperties
    /// </summary>
    public sealed class DestinyDefinitionsDestinyObjectiveDisplayProperties:  IEquatable<DestinyDefinitionsDestinyObjectiveDisplayProperties>
    { 
        /// <summary>
        /// The activity associated with this objective in the context of this item, if any.
        /// </summary>
        public int? ActivityHash { get; private set; }

        /// <summary>
        /// If true, the game shows this objective on item preview screens.
        /// </summary>
        public bool? DisplayOnItemPreviewScreen { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsDestinyObjectiveDisplayProperties.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyObjectiveDisplayProperties()
        {
        }

        private DestinyDefinitionsDestinyObjectiveDisplayProperties(int? ActivityHash, bool? DisplayOnItemPreviewScreen)
        {
            
            this.ActivityHash = ActivityHash;
            
            this.DisplayOnItemPreviewScreen = DisplayOnItemPreviewScreen;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyObjectiveDisplayProperties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyObjectiveDisplayPropertiesBuilder</returns>
        public static DestinyDefinitionsDestinyObjectiveDisplayPropertiesBuilder Builder()
        {
            return new DestinyDefinitionsDestinyObjectiveDisplayPropertiesBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyObjectiveDisplayPropertiesBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyObjectiveDisplayPropertiesBuilder</returns>
        public DestinyDefinitionsDestinyObjectiveDisplayPropertiesBuilder With()
        {
            return Builder()
                .ActivityHash(ActivityHash)
                .DisplayOnItemPreviewScreen(DisplayOnItemPreviewScreen);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsDestinyObjectiveDisplayProperties other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyObjectiveDisplayProperties.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyObjectiveDisplayProperties</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyObjectiveDisplayProperties</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyObjectiveDisplayProperties left, DestinyDefinitionsDestinyObjectiveDisplayProperties right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyObjectiveDisplayProperties.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyObjectiveDisplayProperties</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyObjectiveDisplayProperties</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyObjectiveDisplayProperties left, DestinyDefinitionsDestinyObjectiveDisplayProperties right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyObjectiveDisplayProperties.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyObjectiveDisplayPropertiesBuilder
        {
            private int? _ActivityHash;
            private bool? _DisplayOnItemPreviewScreen;

            internal DestinyDefinitionsDestinyObjectiveDisplayPropertiesBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyObjectiveDisplayProperties.ActivityHash property.
            /// </summary>
            /// <param name="value">The activity associated with this objective in the context of this item, if any.</param>
            public DestinyDefinitionsDestinyObjectiveDisplayPropertiesBuilder ActivityHash(int? value)
            {
                _ActivityHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyObjectiveDisplayProperties.DisplayOnItemPreviewScreen property.
            /// </summary>
            /// <param name="value">If true, the game shows this objective on item preview screens.</param>
            public DestinyDefinitionsDestinyObjectiveDisplayPropertiesBuilder DisplayOnItemPreviewScreen(bool? value)
            {
                _DisplayOnItemPreviewScreen = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyObjectiveDisplayProperties.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyObjectiveDisplayProperties</returns>
            public DestinyDefinitionsDestinyObjectiveDisplayProperties Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyObjectiveDisplayProperties(
                    ActivityHash: _ActivityHash,
                    DisplayOnItemPreviewScreen: _DisplayOnItemPreviewScreen
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}