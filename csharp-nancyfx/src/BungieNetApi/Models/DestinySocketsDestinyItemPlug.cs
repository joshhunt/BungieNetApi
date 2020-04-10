using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinySocketsDestinyItemPlug
    /// </summary>
    public sealed class DestinySocketsDestinyItemPlug:  IEquatable<DestinySocketsDestinyItemPlug>
    { 
        /// <summary>
        /// Sometimes, Plugs may have objectives: these are often used for flavor and display purposes, but they can be used for any arbitrary purpose (both fortunately and unfortunately). Recently (with Season 2) they were expanded in use to be used as the \&quot;gating\&quot; for whether the plug can be inserted at all. For instance, a Plug might be tracking the number of PVP kills you have made. It will use the parent item&#39;s data about that tracking status to determine what to show, and will generally show it using the DestinyObjectiveDefinition&#39;s progressDescription property. Refer to the plug&#39;s itemHash and objective property for more information if you would like to display even more data.
        /// </summary>
        public List<DestinyQuestsDestinyObjectiveProgress> PlugObjectives { get; private set; }

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
        /// Use DestinySocketsDestinyItemPlug.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinySocketsDestinyItemPlug()
        {
        }

        private DestinySocketsDestinyItemPlug(List<DestinyQuestsDestinyObjectiveProgress> PlugObjectives, int? PlugItemHash, bool? CanInsert, bool? Enabled, List<int?> InsertFailIndexes, List<int?> EnableFailIndexes)
        {
            
            this.PlugObjectives = PlugObjectives;
            
            this.PlugItemHash = PlugItemHash;
            
            this.CanInsert = CanInsert;
            
            this.Enabled = Enabled;
            
            this.InsertFailIndexes = InsertFailIndexes;
            
            this.EnableFailIndexes = EnableFailIndexes;
            
        }

        /// <summary>
        /// Returns builder of DestinySocketsDestinyItemPlug.
        /// </summary>
        /// <returns>DestinySocketsDestinyItemPlugBuilder</returns>
        public static DestinySocketsDestinyItemPlugBuilder Builder()
        {
            return new DestinySocketsDestinyItemPlugBuilder();
        }

        /// <summary>
        /// Returns DestinySocketsDestinyItemPlugBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinySocketsDestinyItemPlugBuilder</returns>
        public DestinySocketsDestinyItemPlugBuilder With()
        {
            return Builder()
                .PlugObjectives(PlugObjectives)
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

        public bool Equals(DestinySocketsDestinyItemPlug other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinySocketsDestinyItemPlug.
        /// </summary>
        /// <param name="left">Compared (DestinySocketsDestinyItemPlug</param>
        /// <param name="right">Compared (DestinySocketsDestinyItemPlug</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinySocketsDestinyItemPlug left, DestinySocketsDestinyItemPlug right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinySocketsDestinyItemPlug.
        /// </summary>
        /// <param name="left">Compared (DestinySocketsDestinyItemPlug</param>
        /// <param name="right">Compared (DestinySocketsDestinyItemPlug</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinySocketsDestinyItemPlug left, DestinySocketsDestinyItemPlug right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinySocketsDestinyItemPlug.
        /// </summary>
        public sealed class DestinySocketsDestinyItemPlugBuilder
        {
            private List<DestinyQuestsDestinyObjectiveProgress> _PlugObjectives;
            private int? _PlugItemHash;
            private bool? _CanInsert;
            private bool? _Enabled;
            private List<int?> _InsertFailIndexes;
            private List<int?> _EnableFailIndexes;

            internal DestinySocketsDestinyItemPlugBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinySocketsDestinyItemPlug.PlugObjectives property.
            /// </summary>
            /// <param name="value">Sometimes, Plugs may have objectives: these are often used for flavor and display purposes, but they can be used for any arbitrary purpose (both fortunately and unfortunately). Recently (with Season 2) they were expanded in use to be used as the \&quot;gating\&quot; for whether the plug can be inserted at all. For instance, a Plug might be tracking the number of PVP kills you have made. It will use the parent item&#39;s data about that tracking status to determine what to show, and will generally show it using the DestinyObjectiveDefinition&#39;s progressDescription property. Refer to the plug&#39;s itemHash and objective property for more information if you would like to display even more data.</param>
            public DestinySocketsDestinyItemPlugBuilder PlugObjectives(List<DestinyQuestsDestinyObjectiveProgress> value)
            {
                _PlugObjectives = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinySocketsDestinyItemPlug.PlugItemHash property.
            /// </summary>
            /// <param name="value">The hash identifier of the DestinyInventoryItemDefinition that represents this plug.</param>
            public DestinySocketsDestinyItemPlugBuilder PlugItemHash(int? value)
            {
                _PlugItemHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinySocketsDestinyItemPlug.CanInsert property.
            /// </summary>
            /// <param name="value">If true, this plug has met all of its insertion requirements. Big if true.</param>
            public DestinySocketsDestinyItemPlugBuilder CanInsert(bool? value)
            {
                _CanInsert = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinySocketsDestinyItemPlug.Enabled property.
            /// </summary>
            /// <param name="value">If true, this plug will provide its benefits while inserted.</param>
            public DestinySocketsDestinyItemPlugBuilder Enabled(bool? value)
            {
                _Enabled = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinySocketsDestinyItemPlug.InsertFailIndexes property.
            /// </summary>
            /// <param name="value">If the plug cannot be inserted for some reason, this will have the indexes into the plug item definition&#39;s plug.insertionRules property, so you can show the reasons why it can&#39;t be inserted.  This list will be empty if the plug can be inserted.</param>
            public DestinySocketsDestinyItemPlugBuilder InsertFailIndexes(List<int?> value)
            {
                _InsertFailIndexes = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinySocketsDestinyItemPlug.EnableFailIndexes property.
            /// </summary>
            /// <param name="value">If a plug is not enabled, this will be populated with indexes into the plug item definition&#39;s plug.enabledRules property, so that you can show the reasons why it is not enabled.  This list will be empty if the plug is enabled.</param>
            public DestinySocketsDestinyItemPlugBuilder EnableFailIndexes(List<int?> value)
            {
                _EnableFailIndexes = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinySocketsDestinyItemPlug.
            /// </summary>
            /// <returns>DestinySocketsDestinyItemPlug</returns>
            public DestinySocketsDestinyItemPlug Build()
            {
                Validate();
                return new DestinySocketsDestinyItemPlug(
                    PlugObjectives: _PlugObjectives,
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