using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// EntitiesEntityActionResult
    /// </summary>
    public sealed class EntitiesEntityActionResult:  IEquatable<EntitiesEntityActionResult>
    { 
        /// <summary>
        /// EntityId
        /// </summary>
        public long? EntityId { get; private set; }

        /// <summary>
        /// Result
        /// </summary>
        public int? Result { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use EntitiesEntityActionResult.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public EntitiesEntityActionResult()
        {
        }

        private EntitiesEntityActionResult(long? EntityId, int? Result)
        {
            
            this.EntityId = EntityId;
            
            this.Result = Result;
            
        }

        /// <summary>
        /// Returns builder of EntitiesEntityActionResult.
        /// </summary>
        /// <returns>EntitiesEntityActionResultBuilder</returns>
        public static EntitiesEntityActionResultBuilder Builder()
        {
            return new EntitiesEntityActionResultBuilder();
        }

        /// <summary>
        /// Returns EntitiesEntityActionResultBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>EntitiesEntityActionResultBuilder</returns>
        public EntitiesEntityActionResultBuilder With()
        {
            return Builder()
                .EntityId(EntityId)
                .Result(Result);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(EntitiesEntityActionResult other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (EntitiesEntityActionResult.
        /// </summary>
        /// <param name="left">Compared (EntitiesEntityActionResult</param>
        /// <param name="right">Compared (EntitiesEntityActionResult</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (EntitiesEntityActionResult left, EntitiesEntityActionResult right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (EntitiesEntityActionResult.
        /// </summary>
        /// <param name="left">Compared (EntitiesEntityActionResult</param>
        /// <param name="right">Compared (EntitiesEntityActionResult</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (EntitiesEntityActionResult left, EntitiesEntityActionResult right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of EntitiesEntityActionResult.
        /// </summary>
        public sealed class EntitiesEntityActionResultBuilder
        {
            private long? _EntityId;
            private int? _Result;

            internal EntitiesEntityActionResultBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for EntitiesEntityActionResult.EntityId property.
            /// </summary>
            /// <param name="value">EntityId</param>
            public EntitiesEntityActionResultBuilder EntityId(long? value)
            {
                _EntityId = value;
                return this;
            }

            /// <summary>
            /// Sets value for EntitiesEntityActionResult.Result property.
            /// </summary>
            /// <param name="value">Result</param>
            public EntitiesEntityActionResultBuilder Result(int? value)
            {
                _Result = value;
                return this;
            }


            /// <summary>
            /// Builds instance of EntitiesEntityActionResult.
            /// </summary>
            /// <returns>EntitiesEntityActionResult</returns>
            public EntitiesEntityActionResult Build()
            {
                Validate();
                return new EntitiesEntityActionResult(
                    EntityId: _EntityId,
                    Result: _Result
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}