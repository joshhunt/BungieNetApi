using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyDefinitionsRecordsSchemaRecordStateBlock
    /// </summary>
    public sealed class DestinyDefinitionsRecordsSchemaRecordStateBlock:  IEquatable<DestinyDefinitionsRecordsSchemaRecordStateBlock>
    { 
        /// <summary>
        /// FeaturedPriority
        /// </summary>
        public int? FeaturedPriority { get; private set; }

        /// <summary>
        /// ObscuredString
        /// </summary>
        public string ObscuredString { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsRecordsSchemaRecordStateBlock.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsRecordsSchemaRecordStateBlock()
        {
        }

        private DestinyDefinitionsRecordsSchemaRecordStateBlock(int? FeaturedPriority, string ObscuredString)
        {
            
            this.FeaturedPriority = FeaturedPriority;
            
            this.ObscuredString = ObscuredString;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsRecordsSchemaRecordStateBlock.
        /// </summary>
        /// <returns>DestinyDefinitionsRecordsSchemaRecordStateBlockBuilder</returns>
        public static DestinyDefinitionsRecordsSchemaRecordStateBlockBuilder Builder()
        {
            return new DestinyDefinitionsRecordsSchemaRecordStateBlockBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsRecordsSchemaRecordStateBlockBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsRecordsSchemaRecordStateBlockBuilder</returns>
        public DestinyDefinitionsRecordsSchemaRecordStateBlockBuilder With()
        {
            return Builder()
                .FeaturedPriority(FeaturedPriority)
                .ObscuredString(ObscuredString);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsRecordsSchemaRecordStateBlock other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsRecordsSchemaRecordStateBlock.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsRecordsSchemaRecordStateBlock</param>
        /// <param name="right">Compared (DestinyDefinitionsRecordsSchemaRecordStateBlock</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsRecordsSchemaRecordStateBlock left, DestinyDefinitionsRecordsSchemaRecordStateBlock right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsRecordsSchemaRecordStateBlock.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsRecordsSchemaRecordStateBlock</param>
        /// <param name="right">Compared (DestinyDefinitionsRecordsSchemaRecordStateBlock</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsRecordsSchemaRecordStateBlock left, DestinyDefinitionsRecordsSchemaRecordStateBlock right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsRecordsSchemaRecordStateBlock.
        /// </summary>
        public sealed class DestinyDefinitionsRecordsSchemaRecordStateBlockBuilder
        {
            private int? _FeaturedPriority;
            private string _ObscuredString;

            internal DestinyDefinitionsRecordsSchemaRecordStateBlockBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsRecordsSchemaRecordStateBlock.FeaturedPriority property.
            /// </summary>
            /// <param name="value">FeaturedPriority</param>
            public DestinyDefinitionsRecordsSchemaRecordStateBlockBuilder FeaturedPriority(int? value)
            {
                _FeaturedPriority = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsRecordsSchemaRecordStateBlock.ObscuredString property.
            /// </summary>
            /// <param name="value">ObscuredString</param>
            public DestinyDefinitionsRecordsSchemaRecordStateBlockBuilder ObscuredString(string value)
            {
                _ObscuredString = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsRecordsSchemaRecordStateBlock.
            /// </summary>
            /// <returns>DestinyDefinitionsRecordsSchemaRecordStateBlock</returns>
            public DestinyDefinitionsRecordsSchemaRecordStateBlock Build()
            {
                Validate();
                return new DestinyDefinitionsRecordsSchemaRecordStateBlock(
                    FeaturedPriority: _FeaturedPriority,
                    ObscuredString: _ObscuredString
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}