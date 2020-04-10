using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// If this record has an expiration after which it cannot be earned, this is some information about that expiration.
    /// </summary>
    public sealed class DestinyDefinitionsRecordsDestinyRecordExpirationBlock:  IEquatable<DestinyDefinitionsRecordsDestinyRecordExpirationBlock>
    { 
        /// <summary>
        /// HasExpiration
        /// </summary>
        public bool? HasExpiration { get; private set; }

        /// <summary>
        /// Description
        /// </summary>
        public string Description { get; private set; }

        /// <summary>
        /// Icon
        /// </summary>
        public string Icon { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsRecordsDestinyRecordExpirationBlock.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsRecordsDestinyRecordExpirationBlock()
        {
        }

        private DestinyDefinitionsRecordsDestinyRecordExpirationBlock(bool? HasExpiration, string Description, string Icon)
        {
            
            this.HasExpiration = HasExpiration;
            
            this.Description = Description;
            
            this.Icon = Icon;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsRecordsDestinyRecordExpirationBlock.
        /// </summary>
        /// <returns>DestinyDefinitionsRecordsDestinyRecordExpirationBlockBuilder</returns>
        public static DestinyDefinitionsRecordsDestinyRecordExpirationBlockBuilder Builder()
        {
            return new DestinyDefinitionsRecordsDestinyRecordExpirationBlockBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsRecordsDestinyRecordExpirationBlockBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsRecordsDestinyRecordExpirationBlockBuilder</returns>
        public DestinyDefinitionsRecordsDestinyRecordExpirationBlockBuilder With()
        {
            return Builder()
                .HasExpiration(HasExpiration)
                .Description(Description)
                .Icon(Icon);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsRecordsDestinyRecordExpirationBlock other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsRecordsDestinyRecordExpirationBlock.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsRecordsDestinyRecordExpirationBlock</param>
        /// <param name="right">Compared (DestinyDefinitionsRecordsDestinyRecordExpirationBlock</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsRecordsDestinyRecordExpirationBlock left, DestinyDefinitionsRecordsDestinyRecordExpirationBlock right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsRecordsDestinyRecordExpirationBlock.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsRecordsDestinyRecordExpirationBlock</param>
        /// <param name="right">Compared (DestinyDefinitionsRecordsDestinyRecordExpirationBlock</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsRecordsDestinyRecordExpirationBlock left, DestinyDefinitionsRecordsDestinyRecordExpirationBlock right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsRecordsDestinyRecordExpirationBlock.
        /// </summary>
        public sealed class DestinyDefinitionsRecordsDestinyRecordExpirationBlockBuilder
        {
            private bool? _HasExpiration;
            private string _Description;
            private string _Icon;

            internal DestinyDefinitionsRecordsDestinyRecordExpirationBlockBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsRecordsDestinyRecordExpirationBlock.HasExpiration property.
            /// </summary>
            /// <param name="value">HasExpiration</param>
            public DestinyDefinitionsRecordsDestinyRecordExpirationBlockBuilder HasExpiration(bool? value)
            {
                _HasExpiration = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsRecordsDestinyRecordExpirationBlock.Description property.
            /// </summary>
            /// <param name="value">Description</param>
            public DestinyDefinitionsRecordsDestinyRecordExpirationBlockBuilder Description(string value)
            {
                _Description = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsRecordsDestinyRecordExpirationBlock.Icon property.
            /// </summary>
            /// <param name="value">Icon</param>
            public DestinyDefinitionsRecordsDestinyRecordExpirationBlockBuilder Icon(string value)
            {
                _Icon = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsRecordsDestinyRecordExpirationBlock.
            /// </summary>
            /// <returns>DestinyDefinitionsRecordsDestinyRecordExpirationBlock</returns>
            public DestinyDefinitionsRecordsDestinyRecordExpirationBlock Build()
            {
                Validate();
                return new DestinyDefinitionsRecordsDestinyRecordExpirationBlock(
                    HasExpiration: _HasExpiration,
                    Description: _Description,
                    Icon: _Icon
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}