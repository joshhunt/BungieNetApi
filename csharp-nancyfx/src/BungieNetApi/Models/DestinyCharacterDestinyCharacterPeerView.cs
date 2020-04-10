using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// A minimal view of a character&#39;s equipped items, for the purpose of rendering a summary screen or showing the character in 3D.
    /// </summary>
    public sealed class DestinyCharacterDestinyCharacterPeerView:  IEquatable<DestinyCharacterDestinyCharacterPeerView>
    { 
        /// <summary>
        /// Equipment
        /// </summary>
        public List<DestinyCharacterDestinyItemPeerView> Equipment { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyCharacterDestinyCharacterPeerView.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyCharacterDestinyCharacterPeerView()
        {
        }

        private DestinyCharacterDestinyCharacterPeerView(List<DestinyCharacterDestinyItemPeerView> Equipment)
        {
            
            this.Equipment = Equipment;
            
        }

        /// <summary>
        /// Returns builder of DestinyCharacterDestinyCharacterPeerView.
        /// </summary>
        /// <returns>DestinyCharacterDestinyCharacterPeerViewBuilder</returns>
        public static DestinyCharacterDestinyCharacterPeerViewBuilder Builder()
        {
            return new DestinyCharacterDestinyCharacterPeerViewBuilder();
        }

        /// <summary>
        /// Returns DestinyCharacterDestinyCharacterPeerViewBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyCharacterDestinyCharacterPeerViewBuilder</returns>
        public DestinyCharacterDestinyCharacterPeerViewBuilder With()
        {
            return Builder()
                .Equipment(Equipment);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyCharacterDestinyCharacterPeerView other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyCharacterDestinyCharacterPeerView.
        /// </summary>
        /// <param name="left">Compared (DestinyCharacterDestinyCharacterPeerView</param>
        /// <param name="right">Compared (DestinyCharacterDestinyCharacterPeerView</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyCharacterDestinyCharacterPeerView left, DestinyCharacterDestinyCharacterPeerView right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyCharacterDestinyCharacterPeerView.
        /// </summary>
        /// <param name="left">Compared (DestinyCharacterDestinyCharacterPeerView</param>
        /// <param name="right">Compared (DestinyCharacterDestinyCharacterPeerView</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyCharacterDestinyCharacterPeerView left, DestinyCharacterDestinyCharacterPeerView right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyCharacterDestinyCharacterPeerView.
        /// </summary>
        public sealed class DestinyCharacterDestinyCharacterPeerViewBuilder
        {
            private List<DestinyCharacterDestinyItemPeerView> _Equipment;

            internal DestinyCharacterDestinyCharacterPeerViewBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyCharacterDestinyCharacterPeerView.Equipment property.
            /// </summary>
            /// <param name="value">Equipment</param>
            public DestinyCharacterDestinyCharacterPeerViewBuilder Equipment(List<DestinyCharacterDestinyItemPeerView> value)
            {
                _Equipment = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyCharacterDestinyCharacterPeerView.
            /// </summary>
            /// <returns>DestinyCharacterDestinyCharacterPeerView</returns>
            public DestinyCharacterDestinyCharacterPeerView Build()
            {
                Validate();
                return new DestinyCharacterDestinyCharacterPeerView(
                    Equipment: _Equipment
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}