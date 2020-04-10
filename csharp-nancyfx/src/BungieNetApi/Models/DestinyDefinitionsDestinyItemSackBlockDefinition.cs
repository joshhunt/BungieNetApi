using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Some items are \&quot;sacks\&quot; - they can be \&quot;opened\&quot; to produce other items. This is information related to its sack status, mostly UI strings. Engrams are an example of items that are considered to be \&quot;Sacks\&quot;.
    /// </summary>
    public sealed class DestinyDefinitionsDestinyItemSackBlockDefinition:  IEquatable<DestinyDefinitionsDestinyItemSackBlockDefinition>
    { 
        /// <summary>
        /// A description of what will happen when you open the sack. As far as I can tell, this is blank currently. Unknown whether it will eventually be populated with useful info.
        /// </summary>
        public string DetailAction { get; private set; }

        /// <summary>
        /// The localized name of the action being performed when you open the sack.
        /// </summary>
        public string OpenAction { get; private set; }

        /// <summary>
        /// SelectItemCount
        /// </summary>
        public int? SelectItemCount { get; private set; }

        /// <summary>
        /// VendorSackType
        /// </summary>
        public string VendorSackType { get; private set; }

        /// <summary>
        /// OpenOnAcquire
        /// </summary>
        public bool? OpenOnAcquire { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsDestinyItemSackBlockDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyItemSackBlockDefinition()
        {
        }

        private DestinyDefinitionsDestinyItemSackBlockDefinition(string DetailAction, string OpenAction, int? SelectItemCount, string VendorSackType, bool? OpenOnAcquire)
        {
            
            this.DetailAction = DetailAction;
            
            this.OpenAction = OpenAction;
            
            this.SelectItemCount = SelectItemCount;
            
            this.VendorSackType = VendorSackType;
            
            this.OpenOnAcquire = OpenOnAcquire;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyItemSackBlockDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyItemSackBlockDefinitionBuilder</returns>
        public static DestinyDefinitionsDestinyItemSackBlockDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsDestinyItemSackBlockDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyItemSackBlockDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyItemSackBlockDefinitionBuilder</returns>
        public DestinyDefinitionsDestinyItemSackBlockDefinitionBuilder With()
        {
            return Builder()
                .DetailAction(DetailAction)
                .OpenAction(OpenAction)
                .SelectItemCount(SelectItemCount)
                .VendorSackType(VendorSackType)
                .OpenOnAcquire(OpenOnAcquire);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsDestinyItemSackBlockDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyItemSackBlockDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyItemSackBlockDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyItemSackBlockDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyItemSackBlockDefinition left, DestinyDefinitionsDestinyItemSackBlockDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyItemSackBlockDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyItemSackBlockDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyItemSackBlockDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyItemSackBlockDefinition left, DestinyDefinitionsDestinyItemSackBlockDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyItemSackBlockDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyItemSackBlockDefinitionBuilder
        {
            private string _DetailAction;
            private string _OpenAction;
            private int? _SelectItemCount;
            private string _VendorSackType;
            private bool? _OpenOnAcquire;

            internal DestinyDefinitionsDestinyItemSackBlockDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemSackBlockDefinition.DetailAction property.
            /// </summary>
            /// <param name="value">A description of what will happen when you open the sack. As far as I can tell, this is blank currently. Unknown whether it will eventually be populated with useful info.</param>
            public DestinyDefinitionsDestinyItemSackBlockDefinitionBuilder DetailAction(string value)
            {
                _DetailAction = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemSackBlockDefinition.OpenAction property.
            /// </summary>
            /// <param name="value">The localized name of the action being performed when you open the sack.</param>
            public DestinyDefinitionsDestinyItemSackBlockDefinitionBuilder OpenAction(string value)
            {
                _OpenAction = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemSackBlockDefinition.SelectItemCount property.
            /// </summary>
            /// <param name="value">SelectItemCount</param>
            public DestinyDefinitionsDestinyItemSackBlockDefinitionBuilder SelectItemCount(int? value)
            {
                _SelectItemCount = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemSackBlockDefinition.VendorSackType property.
            /// </summary>
            /// <param name="value">VendorSackType</param>
            public DestinyDefinitionsDestinyItemSackBlockDefinitionBuilder VendorSackType(string value)
            {
                _VendorSackType = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemSackBlockDefinition.OpenOnAcquire property.
            /// </summary>
            /// <param name="value">OpenOnAcquire</param>
            public DestinyDefinitionsDestinyItemSackBlockDefinitionBuilder OpenOnAcquire(bool? value)
            {
                _OpenOnAcquire = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyItemSackBlockDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyItemSackBlockDefinition</returns>
            public DestinyDefinitionsDestinyItemSackBlockDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyItemSackBlockDefinition(
                    DetailAction: _DetailAction,
                    OpenAction: _OpenAction,
                    SelectItemCount: _SelectItemCount,
                    VendorSackType: _VendorSackType,
                    OpenOnAcquire: _OpenOnAcquire
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}