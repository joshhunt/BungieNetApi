using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyBaseItemComponentSetOfint64
    /// </summary>
    public sealed class DestinyBaseItemComponentSetOfint64:  IEquatable<DestinyBaseItemComponentSetOfint64>
    { 
        /// <summary>
        /// Objectives
        /// </summary>
        public DictionaryComponentResponseOfint64AndDestinyItemObjectivesComponent Objectives { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyBaseItemComponentSetOfint64.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyBaseItemComponentSetOfint64()
        {
        }

        private DestinyBaseItemComponentSetOfint64(DictionaryComponentResponseOfint64AndDestinyItemObjectivesComponent Objectives)
        {
            
            this.Objectives = Objectives;
            
        }

        /// <summary>
        /// Returns builder of DestinyBaseItemComponentSetOfint64.
        /// </summary>
        /// <returns>DestinyBaseItemComponentSetOfint64Builder</returns>
        public static DestinyBaseItemComponentSetOfint64Builder Builder()
        {
            return new DestinyBaseItemComponentSetOfint64Builder();
        }

        /// <summary>
        /// Returns DestinyBaseItemComponentSetOfint64Builder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyBaseItemComponentSetOfint64Builder</returns>
        public DestinyBaseItemComponentSetOfint64Builder With()
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

        public bool Equals(DestinyBaseItemComponentSetOfint64 other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyBaseItemComponentSetOfint64.
        /// </summary>
        /// <param name="left">Compared (DestinyBaseItemComponentSetOfint64</param>
        /// <param name="right">Compared (DestinyBaseItemComponentSetOfint64</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyBaseItemComponentSetOfint64 left, DestinyBaseItemComponentSetOfint64 right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyBaseItemComponentSetOfint64.
        /// </summary>
        /// <param name="left">Compared (DestinyBaseItemComponentSetOfint64</param>
        /// <param name="right">Compared (DestinyBaseItemComponentSetOfint64</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyBaseItemComponentSetOfint64 left, DestinyBaseItemComponentSetOfint64 right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyBaseItemComponentSetOfint64.
        /// </summary>
        public sealed class DestinyBaseItemComponentSetOfint64Builder
        {
            private DictionaryComponentResponseOfint64AndDestinyItemObjectivesComponent _Objectives;

            internal DestinyBaseItemComponentSetOfint64Builder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyBaseItemComponentSetOfint64.Objectives property.
            /// </summary>
            /// <param name="value">Objectives</param>
            public DestinyBaseItemComponentSetOfint64Builder Objectives(DictionaryComponentResponseOfint64AndDestinyItemObjectivesComponent value)
            {
                _Objectives = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyBaseItemComponentSetOfint64.
            /// </summary>
            /// <returns>DestinyBaseItemComponentSetOfint64</returns>
            public DestinyBaseItemComponentSetOfint64 Build()
            {
                Validate();
                return new DestinyBaseItemComponentSetOfint64(
                    Objectives: _Objectives
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}