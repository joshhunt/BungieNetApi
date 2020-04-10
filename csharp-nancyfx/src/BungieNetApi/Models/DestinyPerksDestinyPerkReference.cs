using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// The list of perks to display in an item tooltip - and whether or not they have been activated.  Perks apply a variety of effects to a character, and are generally either intrinsic to the item or provided in activated talent nodes or sockets.
    /// </summary>
    public sealed class DestinyPerksDestinyPerkReference:  IEquatable<DestinyPerksDestinyPerkReference>
    { 
        /// <summary>
        /// The hash identifier for the perk, which can be used to look up DestinySandboxPerkDefinition if it exists. Be warned, perks frequently do not have user-viewable information. You should examine whether you actually found a name/description in the perk&#39;s definition before you show it to the user.
        /// </summary>
        public int? PerkHash { get; private set; }

        /// <summary>
        /// The icon for the perk.
        /// </summary>
        public string IconPath { get; private set; }

        /// <summary>
        /// Whether this perk is currently active. (We may return perks that you have not actually activated yet: these represent perks that you should show in the item&#39;s tooltip, but that the user has not yet activated.)
        /// </summary>
        public bool? IsActive { get; private set; }

        /// <summary>
        /// Some perks provide benefits, but aren&#39;t visible in the UI. This value will let you know if this is perk should be shown in your UI.
        /// </summary>
        public bool? Visible { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyPerksDestinyPerkReference.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyPerksDestinyPerkReference()
        {
        }

        private DestinyPerksDestinyPerkReference(int? PerkHash, string IconPath, bool? IsActive, bool? Visible)
        {
            
            this.PerkHash = PerkHash;
            
            this.IconPath = IconPath;
            
            this.IsActive = IsActive;
            
            this.Visible = Visible;
            
        }

        /// <summary>
        /// Returns builder of DestinyPerksDestinyPerkReference.
        /// </summary>
        /// <returns>DestinyPerksDestinyPerkReferenceBuilder</returns>
        public static DestinyPerksDestinyPerkReferenceBuilder Builder()
        {
            return new DestinyPerksDestinyPerkReferenceBuilder();
        }

        /// <summary>
        /// Returns DestinyPerksDestinyPerkReferenceBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyPerksDestinyPerkReferenceBuilder</returns>
        public DestinyPerksDestinyPerkReferenceBuilder With()
        {
            return Builder()
                .PerkHash(PerkHash)
                .IconPath(IconPath)
                .IsActive(IsActive)
                .Visible(Visible);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyPerksDestinyPerkReference other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyPerksDestinyPerkReference.
        /// </summary>
        /// <param name="left">Compared (DestinyPerksDestinyPerkReference</param>
        /// <param name="right">Compared (DestinyPerksDestinyPerkReference</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyPerksDestinyPerkReference left, DestinyPerksDestinyPerkReference right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyPerksDestinyPerkReference.
        /// </summary>
        /// <param name="left">Compared (DestinyPerksDestinyPerkReference</param>
        /// <param name="right">Compared (DestinyPerksDestinyPerkReference</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyPerksDestinyPerkReference left, DestinyPerksDestinyPerkReference right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyPerksDestinyPerkReference.
        /// </summary>
        public sealed class DestinyPerksDestinyPerkReferenceBuilder
        {
            private int? _PerkHash;
            private string _IconPath;
            private bool? _IsActive;
            private bool? _Visible;

            internal DestinyPerksDestinyPerkReferenceBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyPerksDestinyPerkReference.PerkHash property.
            /// </summary>
            /// <param name="value">The hash identifier for the perk, which can be used to look up DestinySandboxPerkDefinition if it exists. Be warned, perks frequently do not have user-viewable information. You should examine whether you actually found a name/description in the perk&#39;s definition before you show it to the user.</param>
            public DestinyPerksDestinyPerkReferenceBuilder PerkHash(int? value)
            {
                _PerkHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyPerksDestinyPerkReference.IconPath property.
            /// </summary>
            /// <param name="value">The icon for the perk.</param>
            public DestinyPerksDestinyPerkReferenceBuilder IconPath(string value)
            {
                _IconPath = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyPerksDestinyPerkReference.IsActive property.
            /// </summary>
            /// <param name="value">Whether this perk is currently active. (We may return perks that you have not actually activated yet: these represent perks that you should show in the item&#39;s tooltip, but that the user has not yet activated.)</param>
            public DestinyPerksDestinyPerkReferenceBuilder IsActive(bool? value)
            {
                _IsActive = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyPerksDestinyPerkReference.Visible property.
            /// </summary>
            /// <param name="value">Some perks provide benefits, but aren&#39;t visible in the UI. This value will let you know if this is perk should be shown in your UI.</param>
            public DestinyPerksDestinyPerkReferenceBuilder Visible(bool? value)
            {
                _Visible = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyPerksDestinyPerkReference.
            /// </summary>
            /// <returns>DestinyPerksDestinyPerkReference</returns>
            public DestinyPerksDestinyPerkReference Build()
            {
                Validate();
                return new DestinyPerksDestinyPerkReference(
                    PerkHash: _PerkHash,
                    IconPath: _IconPath,
                    IsActive: _IsActive,
                    Visible: _Visible
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}