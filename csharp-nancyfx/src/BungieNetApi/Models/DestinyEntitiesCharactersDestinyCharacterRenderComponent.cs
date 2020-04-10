using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Only really useful if you&#39;re attempting to render the character&#39;s current appearance in 3D, this returns a bare minimum of information, pre-aggregated, that you&#39;ll need to perform that rendering. Note that you need to combine this with other 3D assets and data from our servers.  Examine the Javascript returned by https://bungie.net/sharedbundle/spasm to see how we use this data, but be warned: the rabbit hole goes pretty deep.
    /// </summary>
    public sealed class DestinyEntitiesCharactersDestinyCharacterRenderComponent:  IEquatable<DestinyEntitiesCharactersDestinyCharacterRenderComponent>
    { 
        /// <summary>
        /// Custom dyes, calculated by iterating over the character&#39;s equipped items. Useful for pre-fetching all of the dye data needed from our server.
        /// </summary>
        public List<DestinyDyeReference> CustomDyes { get; private set; }

        /// <summary>
        /// This is actually something that Spasm.js *doesn&#39;t* do right now, and that we don&#39;t return assets for yet. This is the data about what character customization options you picked. You can combine this with DestinyCharacterCustomizationOptionDefinition to show some cool info, and hopefully someday to actually render a user&#39;s face in 3D. We&#39;ll see if we ever end up with time for that.
        /// </summary>
        public DestinyCharacterDestinyCharacterCustomization Customization { get; private set; }

        /// <summary>
        /// A minimal view of:  - Equipped items  - The rendering-related custom options on those equipped items  Combined, that should be enough to render all of the items on the equipped character.
        /// </summary>
        public DestinyCharacterDestinyCharacterPeerView PeerView { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyEntitiesCharactersDestinyCharacterRenderComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyEntitiesCharactersDestinyCharacterRenderComponent()
        {
        }

        private DestinyEntitiesCharactersDestinyCharacterRenderComponent(List<DestinyDyeReference> CustomDyes, DestinyCharacterDestinyCharacterCustomization Customization, DestinyCharacterDestinyCharacterPeerView PeerView)
        {
            
            this.CustomDyes = CustomDyes;
            
            this.Customization = Customization;
            
            this.PeerView = PeerView;
            
        }

        /// <summary>
        /// Returns builder of DestinyEntitiesCharactersDestinyCharacterRenderComponent.
        /// </summary>
        /// <returns>DestinyEntitiesCharactersDestinyCharacterRenderComponentBuilder</returns>
        public static DestinyEntitiesCharactersDestinyCharacterRenderComponentBuilder Builder()
        {
            return new DestinyEntitiesCharactersDestinyCharacterRenderComponentBuilder();
        }

        /// <summary>
        /// Returns DestinyEntitiesCharactersDestinyCharacterRenderComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyEntitiesCharactersDestinyCharacterRenderComponentBuilder</returns>
        public DestinyEntitiesCharactersDestinyCharacterRenderComponentBuilder With()
        {
            return Builder()
                .CustomDyes(CustomDyes)
                .Customization(Customization)
                .PeerView(PeerView);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyEntitiesCharactersDestinyCharacterRenderComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyEntitiesCharactersDestinyCharacterRenderComponent.
        /// </summary>
        /// <param name="left">Compared (DestinyEntitiesCharactersDestinyCharacterRenderComponent</param>
        /// <param name="right">Compared (DestinyEntitiesCharactersDestinyCharacterRenderComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyEntitiesCharactersDestinyCharacterRenderComponent left, DestinyEntitiesCharactersDestinyCharacterRenderComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyEntitiesCharactersDestinyCharacterRenderComponent.
        /// </summary>
        /// <param name="left">Compared (DestinyEntitiesCharactersDestinyCharacterRenderComponent</param>
        /// <param name="right">Compared (DestinyEntitiesCharactersDestinyCharacterRenderComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyEntitiesCharactersDestinyCharacterRenderComponent left, DestinyEntitiesCharactersDestinyCharacterRenderComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyEntitiesCharactersDestinyCharacterRenderComponent.
        /// </summary>
        public sealed class DestinyEntitiesCharactersDestinyCharacterRenderComponentBuilder
        {
            private List<DestinyDyeReference> _CustomDyes;
            private DestinyCharacterDestinyCharacterCustomization _Customization;
            private DestinyCharacterDestinyCharacterPeerView _PeerView;

            internal DestinyEntitiesCharactersDestinyCharacterRenderComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyEntitiesCharactersDestinyCharacterRenderComponent.CustomDyes property.
            /// </summary>
            /// <param name="value">Custom dyes, calculated by iterating over the character&#39;s equipped items. Useful for pre-fetching all of the dye data needed from our server.</param>
            public DestinyEntitiesCharactersDestinyCharacterRenderComponentBuilder CustomDyes(List<DestinyDyeReference> value)
            {
                _CustomDyes = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyEntitiesCharactersDestinyCharacterRenderComponent.Customization property.
            /// </summary>
            /// <param name="value">This is actually something that Spasm.js *doesn&#39;t* do right now, and that we don&#39;t return assets for yet. This is the data about what character customization options you picked. You can combine this with DestinyCharacterCustomizationOptionDefinition to show some cool info, and hopefully someday to actually render a user&#39;s face in 3D. We&#39;ll see if we ever end up with time for that.</param>
            public DestinyEntitiesCharactersDestinyCharacterRenderComponentBuilder Customization(DestinyCharacterDestinyCharacterCustomization value)
            {
                _Customization = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyEntitiesCharactersDestinyCharacterRenderComponent.PeerView property.
            /// </summary>
            /// <param name="value">A minimal view of:  - Equipped items  - The rendering-related custom options on those equipped items  Combined, that should be enough to render all of the items on the equipped character.</param>
            public DestinyEntitiesCharactersDestinyCharacterRenderComponentBuilder PeerView(DestinyCharacterDestinyCharacterPeerView value)
            {
                _PeerView = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyEntitiesCharactersDestinyCharacterRenderComponent.
            /// </summary>
            /// <returns>DestinyEntitiesCharactersDestinyCharacterRenderComponent</returns>
            public DestinyEntitiesCharactersDestinyCharacterRenderComponent Build()
            {
                Validate();
                return new DestinyEntitiesCharactersDestinyCharacterRenderComponent(
                    CustomDyes: _CustomDyes,
                    Customization: _Customization,
                    PeerView: _PeerView
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}