using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// SingleComponentResponseOfDestinyItemPerksComponent
    /// </summary>
    public sealed class SingleComponentResponseOfDestinyItemPerksComponent:  IEquatable<SingleComponentResponseOfDestinyItemPerksComponent>
    { 
        /// <summary>
        /// Data
        /// </summary>
        public DestinyEntitiesItemsDestinyItemPerksComponent Data { get; private set; }

        /// <summary>
        /// Privacy
        /// </summary>
        public int? Privacy { get; private set; }

        /// <summary>
        /// If true, this component is disabled.
        /// </summary>
        public bool? Disabled { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use SingleComponentResponseOfDestinyItemPerksComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public SingleComponentResponseOfDestinyItemPerksComponent()
        {
        }

        private SingleComponentResponseOfDestinyItemPerksComponent(DestinyEntitiesItemsDestinyItemPerksComponent Data, int? Privacy, bool? Disabled)
        {
            
            this.Data = Data;
            
            this.Privacy = Privacy;
            
            this.Disabled = Disabled;
            
        }

        /// <summary>
        /// Returns builder of SingleComponentResponseOfDestinyItemPerksComponent.
        /// </summary>
        /// <returns>SingleComponentResponseOfDestinyItemPerksComponentBuilder</returns>
        public static SingleComponentResponseOfDestinyItemPerksComponentBuilder Builder()
        {
            return new SingleComponentResponseOfDestinyItemPerksComponentBuilder();
        }

        /// <summary>
        /// Returns SingleComponentResponseOfDestinyItemPerksComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>SingleComponentResponseOfDestinyItemPerksComponentBuilder</returns>
        public SingleComponentResponseOfDestinyItemPerksComponentBuilder With()
        {
            return Builder()
                .Data(Data)
                .Privacy(Privacy)
                .Disabled(Disabled);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(SingleComponentResponseOfDestinyItemPerksComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (SingleComponentResponseOfDestinyItemPerksComponent.
        /// </summary>
        /// <param name="left">Compared (SingleComponentResponseOfDestinyItemPerksComponent</param>
        /// <param name="right">Compared (SingleComponentResponseOfDestinyItemPerksComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (SingleComponentResponseOfDestinyItemPerksComponent left, SingleComponentResponseOfDestinyItemPerksComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (SingleComponentResponseOfDestinyItemPerksComponent.
        /// </summary>
        /// <param name="left">Compared (SingleComponentResponseOfDestinyItemPerksComponent</param>
        /// <param name="right">Compared (SingleComponentResponseOfDestinyItemPerksComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (SingleComponentResponseOfDestinyItemPerksComponent left, SingleComponentResponseOfDestinyItemPerksComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of SingleComponentResponseOfDestinyItemPerksComponent.
        /// </summary>
        public sealed class SingleComponentResponseOfDestinyItemPerksComponentBuilder
        {
            private DestinyEntitiesItemsDestinyItemPerksComponent _Data;
            private int? _Privacy;
            private bool? _Disabled;

            internal SingleComponentResponseOfDestinyItemPerksComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for SingleComponentResponseOfDestinyItemPerksComponent.Data property.
            /// </summary>
            /// <param name="value">Data</param>
            public SingleComponentResponseOfDestinyItemPerksComponentBuilder Data(DestinyEntitiesItemsDestinyItemPerksComponent value)
            {
                _Data = value;
                return this;
            }

            /// <summary>
            /// Sets value for SingleComponentResponseOfDestinyItemPerksComponent.Privacy property.
            /// </summary>
            /// <param name="value">Privacy</param>
            public SingleComponentResponseOfDestinyItemPerksComponentBuilder Privacy(int? value)
            {
                _Privacy = value;
                return this;
            }

            /// <summary>
            /// Sets value for SingleComponentResponseOfDestinyItemPerksComponent.Disabled property.
            /// </summary>
            /// <param name="value">If true, this component is disabled.</param>
            public SingleComponentResponseOfDestinyItemPerksComponentBuilder Disabled(bool? value)
            {
                _Disabled = value;
                return this;
            }


            /// <summary>
            /// Builds instance of SingleComponentResponseOfDestinyItemPerksComponent.
            /// </summary>
            /// <returns>SingleComponentResponseOfDestinyItemPerksComponent</returns>
            public SingleComponentResponseOfDestinyItemPerksComponent Build()
            {
                Validate();
                return new SingleComponentResponseOfDestinyItemPerksComponent(
                    Data: _Data,
                    Privacy: _Privacy,
                    Disabled: _Disabled
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}