using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyDefinitionsDestinyVendorGroupReference
    /// </summary>
    public sealed class DestinyDefinitionsDestinyVendorGroupReference:  IEquatable<DestinyDefinitionsDestinyVendorGroupReference>
    { 
        /// <summary>
        /// The DestinyVendorGroupDefinition to which this Vendor can belong.
        /// </summary>
        public int? VendorGroupHash { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsDestinyVendorGroupReference.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyVendorGroupReference()
        {
        }

        private DestinyDefinitionsDestinyVendorGroupReference(int? VendorGroupHash)
        {
            
            this.VendorGroupHash = VendorGroupHash;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyVendorGroupReference.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyVendorGroupReferenceBuilder</returns>
        public static DestinyDefinitionsDestinyVendorGroupReferenceBuilder Builder()
        {
            return new DestinyDefinitionsDestinyVendorGroupReferenceBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyVendorGroupReferenceBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyVendorGroupReferenceBuilder</returns>
        public DestinyDefinitionsDestinyVendorGroupReferenceBuilder With()
        {
            return Builder()
                .VendorGroupHash(VendorGroupHash);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsDestinyVendorGroupReference other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyVendorGroupReference.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyVendorGroupReference</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyVendorGroupReference</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyVendorGroupReference left, DestinyDefinitionsDestinyVendorGroupReference right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyVendorGroupReference.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyVendorGroupReference</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyVendorGroupReference</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyVendorGroupReference left, DestinyDefinitionsDestinyVendorGroupReference right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyVendorGroupReference.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyVendorGroupReferenceBuilder
        {
            private int? _VendorGroupHash;

            internal DestinyDefinitionsDestinyVendorGroupReferenceBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorGroupReference.VendorGroupHash property.
            /// </summary>
            /// <param name="value">The DestinyVendorGroupDefinition to which this Vendor can belong.</param>
            public DestinyDefinitionsDestinyVendorGroupReferenceBuilder VendorGroupHash(int? value)
            {
                _VendorGroupHash = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyVendorGroupReference.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyVendorGroupReference</returns>
            public DestinyDefinitionsDestinyVendorGroupReference Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyVendorGroupReference(
                    VendorGroupHash: _VendorGroupHash
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}