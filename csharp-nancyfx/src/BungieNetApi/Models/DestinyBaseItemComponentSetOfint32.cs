using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyBaseItemComponentSetOfint32
    /// </summary>
    public sealed class DestinyBaseItemComponentSetOfint32:  IEquatable<DestinyBaseItemComponentSetOfint32>
    { 
        /// <summary>
        /// Objectives
        /// </summary>
        public DictionaryComponentResponseOfint32AndDestinyItemObjectivesComponent Objectives { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyBaseItemComponentSetOfint32.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyBaseItemComponentSetOfint32()
        {
        }

        private DestinyBaseItemComponentSetOfint32(DictionaryComponentResponseOfint32AndDestinyItemObjectivesComponent Objectives)
        {
            
            this.Objectives = Objectives;
            
        }

        /// <summary>
        /// Returns builder of DestinyBaseItemComponentSetOfint32.
        /// </summary>
        /// <returns>DestinyBaseItemComponentSetOfint32Builder</returns>
        public static DestinyBaseItemComponentSetOfint32Builder Builder()
        {
            return new DestinyBaseItemComponentSetOfint32Builder();
        }

        /// <summary>
        /// Returns DestinyBaseItemComponentSetOfint32Builder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyBaseItemComponentSetOfint32Builder</returns>
        public DestinyBaseItemComponentSetOfint32Builder With()
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

        public bool Equals(DestinyBaseItemComponentSetOfint32 other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyBaseItemComponentSetOfint32.
        /// </summary>
        /// <param name="left">Compared (DestinyBaseItemComponentSetOfint32</param>
        /// <param name="right">Compared (DestinyBaseItemComponentSetOfint32</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyBaseItemComponentSetOfint32 left, DestinyBaseItemComponentSetOfint32 right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyBaseItemComponentSetOfint32.
        /// </summary>
        /// <param name="left">Compared (DestinyBaseItemComponentSetOfint32</param>
        /// <param name="right">Compared (DestinyBaseItemComponentSetOfint32</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyBaseItemComponentSetOfint32 left, DestinyBaseItemComponentSetOfint32 right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyBaseItemComponentSetOfint32.
        /// </summary>
        public sealed class DestinyBaseItemComponentSetOfint32Builder
        {
            private DictionaryComponentResponseOfint32AndDestinyItemObjectivesComponent _Objectives;

            internal DestinyBaseItemComponentSetOfint32Builder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyBaseItemComponentSetOfint32.Objectives property.
            /// </summary>
            /// <param name="value">Objectives</param>
            public DestinyBaseItemComponentSetOfint32Builder Objectives(DictionaryComponentResponseOfint32AndDestinyItemObjectivesComponent value)
            {
                _Objectives = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyBaseItemComponentSetOfint32.
            /// </summary>
            /// <returns>DestinyBaseItemComponentSetOfint32</returns>
            public DestinyBaseItemComponentSetOfint32 Build()
            {
                Validate();
                return new DestinyBaseItemComponentSetOfint32(
                    Objectives: _Objectives
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}