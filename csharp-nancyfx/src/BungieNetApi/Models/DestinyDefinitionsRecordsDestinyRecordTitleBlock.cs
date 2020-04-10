using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyDefinitionsRecordsDestinyRecordTitleBlock
    /// </summary>
    public sealed class DestinyDefinitionsRecordsDestinyRecordTitleBlock:  IEquatable<DestinyDefinitionsRecordsDestinyRecordTitleBlock>
    { 
        /// <summary>
        /// HasTitle
        /// </summary>
        public bool? HasTitle { get; private set; }

        /// <summary>
        /// TitlesByGender
        /// </summary>
        public Dictionary<string, string> TitlesByGender { get; private set; }

        /// <summary>
        /// For those who prefer to use the definitions.
        /// </summary>
        public Dictionary<string, string> TitlesByGenderHash { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsRecordsDestinyRecordTitleBlock.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsRecordsDestinyRecordTitleBlock()
        {
        }

        private DestinyDefinitionsRecordsDestinyRecordTitleBlock(bool? HasTitle, Dictionary<string, string> TitlesByGender, Dictionary<string, string> TitlesByGenderHash)
        {
            
            this.HasTitle = HasTitle;
            
            this.TitlesByGender = TitlesByGender;
            
            this.TitlesByGenderHash = TitlesByGenderHash;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsRecordsDestinyRecordTitleBlock.
        /// </summary>
        /// <returns>DestinyDefinitionsRecordsDestinyRecordTitleBlockBuilder</returns>
        public static DestinyDefinitionsRecordsDestinyRecordTitleBlockBuilder Builder()
        {
            return new DestinyDefinitionsRecordsDestinyRecordTitleBlockBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsRecordsDestinyRecordTitleBlockBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsRecordsDestinyRecordTitleBlockBuilder</returns>
        public DestinyDefinitionsRecordsDestinyRecordTitleBlockBuilder With()
        {
            return Builder()
                .HasTitle(HasTitle)
                .TitlesByGender(TitlesByGender)
                .TitlesByGenderHash(TitlesByGenderHash);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsRecordsDestinyRecordTitleBlock other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsRecordsDestinyRecordTitleBlock.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsRecordsDestinyRecordTitleBlock</param>
        /// <param name="right">Compared (DestinyDefinitionsRecordsDestinyRecordTitleBlock</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsRecordsDestinyRecordTitleBlock left, DestinyDefinitionsRecordsDestinyRecordTitleBlock right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsRecordsDestinyRecordTitleBlock.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsRecordsDestinyRecordTitleBlock</param>
        /// <param name="right">Compared (DestinyDefinitionsRecordsDestinyRecordTitleBlock</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsRecordsDestinyRecordTitleBlock left, DestinyDefinitionsRecordsDestinyRecordTitleBlock right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsRecordsDestinyRecordTitleBlock.
        /// </summary>
        public sealed class DestinyDefinitionsRecordsDestinyRecordTitleBlockBuilder
        {
            private bool? _HasTitle;
            private Dictionary<string, string> _TitlesByGender;
            private Dictionary<string, string> _TitlesByGenderHash;

            internal DestinyDefinitionsRecordsDestinyRecordTitleBlockBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsRecordsDestinyRecordTitleBlock.HasTitle property.
            /// </summary>
            /// <param name="value">HasTitle</param>
            public DestinyDefinitionsRecordsDestinyRecordTitleBlockBuilder HasTitle(bool? value)
            {
                _HasTitle = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsRecordsDestinyRecordTitleBlock.TitlesByGender property.
            /// </summary>
            /// <param name="value">TitlesByGender</param>
            public DestinyDefinitionsRecordsDestinyRecordTitleBlockBuilder TitlesByGender(Dictionary<string, string> value)
            {
                _TitlesByGender = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsRecordsDestinyRecordTitleBlock.TitlesByGenderHash property.
            /// </summary>
            /// <param name="value">For those who prefer to use the definitions.</param>
            public DestinyDefinitionsRecordsDestinyRecordTitleBlockBuilder TitlesByGenderHash(Dictionary<string, string> value)
            {
                _TitlesByGenderHash = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsRecordsDestinyRecordTitleBlock.
            /// </summary>
            /// <returns>DestinyDefinitionsRecordsDestinyRecordTitleBlock</returns>
            public DestinyDefinitionsRecordsDestinyRecordTitleBlock Build()
            {
                Validate();
                return new DestinyDefinitionsRecordsDestinyRecordTitleBlock(
                    HasTitle: _HasTitle,
                    TitlesByGender: _TitlesByGender,
                    TitlesByGenderHash: _TitlesByGenderHash
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}