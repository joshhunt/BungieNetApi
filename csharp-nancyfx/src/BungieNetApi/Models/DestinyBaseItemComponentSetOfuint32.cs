using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyBaseItemComponentSetOfuint32
    /// </summary>
    public sealed class DestinyBaseItemComponentSetOfuint32:  IEquatable<DestinyBaseItemComponentSetOfuint32>
    { 
        /// <summary>
        /// Objectives
        /// </summary>
        public DictionaryComponentResponseOfuint32AndDestinyItemObjectivesComponent Objectives { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyBaseItemComponentSetOfuint32.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyBaseItemComponentSetOfuint32()
        {
        }

        private DestinyBaseItemComponentSetOfuint32(DictionaryComponentResponseOfuint32AndDestinyItemObjectivesComponent Objectives)
        {
            
            this.Objectives = Objectives;
            
        }

        /// <summary>
        /// Returns builder of DestinyBaseItemComponentSetOfuint32.
        /// </summary>
        /// <returns>DestinyBaseItemComponentSetOfuint32Builder</returns>
        public static DestinyBaseItemComponentSetOfuint32Builder Builder()
        {
            return new DestinyBaseItemComponentSetOfuint32Builder();
        }

        /// <summary>
        /// Returns DestinyBaseItemComponentSetOfuint32Builder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyBaseItemComponentSetOfuint32Builder</returns>
        public DestinyBaseItemComponentSetOfuint32Builder With()
        {
            return Builder()
                .Objectives(Objectives);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyBaseItemComponentSetOfuint32 other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyBaseItemComponentSetOfuint32.
        /// </summary>
        /// <param name="left">Compared (DestinyBaseItemComponentSetOfuint32</param>
        /// <param name="right">Compared (DestinyBaseItemComponentSetOfuint32</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyBaseItemComponentSetOfuint32 left, DestinyBaseItemComponentSetOfuint32 right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyBaseItemComponentSetOfuint32.
        /// </summary>
        /// <param name="left">Compared (DestinyBaseItemComponentSetOfuint32</param>
        /// <param name="right">Compared (DestinyBaseItemComponentSetOfuint32</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyBaseItemComponentSetOfuint32 left, DestinyBaseItemComponentSetOfuint32 right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyBaseItemComponentSetOfuint32.
        /// </summary>
        public sealed class DestinyBaseItemComponentSetOfuint32Builder
        {
            private DictionaryComponentResponseOfuint32AndDestinyItemObjectivesComponent _Objectives;

            internal DestinyBaseItemComponentSetOfuint32Builder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyBaseItemComponentSetOfuint32.Objectives property.
            /// </summary>
            /// <param name="value">Objectives</param>
            public DestinyBaseItemComponentSetOfuint32Builder Objectives(DictionaryComponentResponseOfuint32AndDestinyItemObjectivesComponent value)
            {
                _Objectives = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyBaseItemComponentSetOfuint32.
            /// </summary>
            /// <returns>DestinyBaseItemComponentSetOfuint32</returns>
            public DestinyBaseItemComponentSetOfuint32 Build()
            {
                Validate();
                return new DestinyBaseItemComponentSetOfuint32(
                    Objectives: _Objectives
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}