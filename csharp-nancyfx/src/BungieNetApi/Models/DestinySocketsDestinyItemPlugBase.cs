using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinySocketsDestinyItemPlugBase
    /// </summary>
    public sealed class DestinySocketsDestinyItemPlugBase:  IEquatable<DestinySocketsDestinyItemPlugBase>
    { 
        /// <summary>
        /// The hash identifier of the DestinyInventoryItemDefinition that represents this plug.
        /// </summary>
        public int? PlugItemHash { get; private set; }

        /// <summary>
        /// If true, this plug has met all of its insertion requirements. Big if true.
        /// </summary>
        public bool? CanInsert { get; private set; }

        /// <summary>
        /// If true, this plug will provide its benefits while inserted.
        /// </summary>
        public bool? Enabled { get; private set; }

        /// <summary>
        /// If the plug cannot be inserted for some reason, this will have the indexes into the plug item definition&#39;s plug.insertionRules property, so you can show the reasons why it can&#39;t be inserted.  This list will be empty if the plug can be inserted.
        /// </summary>
        public List<int?> InsertFailIndexes { get; private set; }

        /// <summary>
        /// If a plug is not enabled, this will be populated with indexes into the plug item definition&#39;s plug.enabledRules property, so that you can show the reasons why it is not enabled.  This list will be empty if the plug is enabled.
        /// </summary>
        public List<int?> EnableFailIndexes { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinySocketsDestinyItemPlugBase.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinySocketsDestinyItemPlugBase()
        {
        }

        private DestinySocketsDestinyItemPlugBase(int? PlugItemHash, bool? CanInsert, bool? Enabled, List<int?> InsertFailIndexes, List<int?> EnableFailIndexes)
        {
            
            this.PlugItemHash = PlugItemHash;
            
            this.CanInsert = CanInsert;
            
            this.Enabled = Enabled;
            
            this.InsertFailIndexes = InsertFailIndexes;
            
            this.EnableFailIndexes = EnableFailIndexes;
            
        }

        /// <summary>
        /// Returns builder of DestinySocketsDestinyItemPlugBase.
        /// </summary>
        /// <returns>DestinySocketsDestinyItemPlugBaseBuilder</returns>
        public static DestinySocketsDestinyItemPlugBaseBuilder Builder()
        {
            return new DestinySocketsDestinyItemPlugBaseBuilder();
        }

        /// <summary>
        /// Returns DestinySocketsDestinyItemPlugBaseBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinySocketsDestinyItemPlugBaseBuilder</returns>
        public DestinySocketsDestinyItemPlugBaseBuilder With()
        {
            return Builder()
                .PlugItemHash(PlugItemHash)
                .CanInsert(CanInsert)
                .Enabled(Enabled)
                .InsertFailIndexes(InsertFailIndexes)
                .EnableFailIndexes(EnableFailIndexes);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinySocketsDestinyItemPlugBase other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinySocketsDestinyItemPlugBase.
        /// </summary>
        /// <param name="left">Compared (DestinySocketsDestinyItemPlugBase</param>
        /// <param name="right">Compared (DestinySocketsDestinyItemPlugBase</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinySocketsDestinyItemPlugBase left, DestinySocketsDestinyItemPlugBase right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinySocketsDestinyItemPlugBase.
        /// </summary>
        /// <param name="left">Compared (DestinySocketsDestinyItemPlugBase</param>
        /// <param name="right">Compared (DestinySocketsDestinyItemPlugBase</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinySocketsDestinyItemPlugBase left, DestinySocketsDestinyItemPlugBase right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinySocketsDestinyItemPlugBase.
        /// </summary>
        public sealed class DestinySocketsDestinyItemPlugBaseBuilder
        {
            private int? _PlugItemHash;
            private bool? _CanInsert;
            private bool? _Enabled;
            private List<int?> _InsertFailIndexes;
            private List<int?> _EnableFailIndexes;

            internal DestinySocketsDestinyItemPlugBaseBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinySocketsDestinyItemPlugBase.PlugItemHash property.
            /// </summary>
            /// <param name="value">The hash identifier of the DestinyInventoryItemDefinition that represents this plug.</param>
            public DestinySocketsDestinyItemPlugBaseBuilder PlugItemHash(int? value)
            {
                _PlugItemHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinySocketsDestinyItemPlugBase.CanInsert property.
            /// </summary>
            /// <param name="value">If true, this plug has met all of its insertion requirements. Big if true.</param>
            public DestinySocketsDestinyItemPlugBaseBuilder CanInsert(bool? value)
            {
                _CanInsert = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinySocketsDestinyItemPlugBase.Enabled property.
            /// </summary>
            /// <param name="value">If true, this plug will provide its benefits while inserted.</param>
            public DestinySocketsDestinyItemPlugBaseBuilder Enabled(bool? value)
            {
                _Enabled = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinySocketsDestinyItemPlugBase.InsertFailIndexes property.
            /// </summary>
            /// <param name="value">If the plug cannot be inserted for some reason, this will have the indexes into the plug item definition&#39;s plug.insertionRules property, so you can show the reasons why it can&#39;t be inserted.  This list will be empty if the plug can be inserted.</param>
            public DestinySocketsDestinyItemPlugBaseBuilder InsertFailIndexes(List<int?> value)
            {
                _InsertFailIndexes = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinySocketsDestinyItemPlugBase.EnableFailIndexes property.
            /// </summary>
            /// <param name="value">If a plug is not enabled, this will be populated with indexes into the plug item definition&#39;s plug.enabledRules property, so that you can show the reasons why it is not enabled.  This list will be empty if the plug is enabled.</param>
            public DestinySocketsDestinyItemPlugBaseBuilder EnableFailIndexes(List<int?> value)
            {
                _EnableFailIndexes = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinySocketsDestinyItemPlugBase.
            /// </summary>
            /// <returns>DestinySocketsDestinyItemPlugBase</returns>
            public DestinySocketsDestinyItemPlugBase Build()
            {
                Validate();
                return new DestinySocketsDestinyItemPlugBase(
                    PlugItemHash: _PlugItemHash,
                    CanInsert: _CanInsert,
                    Enabled: _Enabled,
                    InsertFailIndexes: _InsertFailIndexes,
                    EnableFailIndexes: _EnableFailIndexes
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}