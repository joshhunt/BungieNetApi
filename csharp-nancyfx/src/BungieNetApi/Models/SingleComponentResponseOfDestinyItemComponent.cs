using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// SingleComponentResponseOfDestinyItemComponent
    /// </summary>
    public sealed class SingleComponentResponseOfDestinyItemComponent:  IEquatable<SingleComponentResponseOfDestinyItemComponent>
    { 
        /// <summary>
        /// Data
        /// </summary>
        public DestinyEntitiesItemsDestinyItemComponent Data { get; private set; }

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
        /// Use SingleComponentResponseOfDestinyItemComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public SingleComponentResponseOfDestinyItemComponent()
        {
        }

        private SingleComponentResponseOfDestinyItemComponent(DestinyEntitiesItemsDestinyItemComponent Data, int? Privacy, bool? Disabled)
        {
            
            this.Data = Data;
            
            this.Privacy = Privacy;
            
            this.Disabled = Disabled;
            
        }

        /// <summary>
        /// Returns builder of SingleComponentResponseOfDestinyItemComponent.
        /// </summary>
        /// <returns>SingleComponentResponseOfDestinyItemComponentBuilder</returns>
        public static SingleComponentResponseOfDestinyItemComponentBuilder Builder()
        {
            return new SingleComponentResponseOfDestinyItemComponentBuilder();
        }

        /// <summary>
        /// Returns SingleComponentResponseOfDestinyItemComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>SingleComponentResponseOfDestinyItemComponentBuilder</returns>
        public SingleComponentResponseOfDestinyItemComponentBuilder With()
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

        public bool Equals(SingleComponentResponseOfDestinyItemComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (SingleComponentResponseOfDestinyItemComponent.
        /// </summary>
        /// <param name="left">Compared (SingleComponentResponseOfDestinyItemComponent</param>
        /// <param name="right">Compared (SingleComponentResponseOfDestinyItemComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (SingleComponentResponseOfDestinyItemComponent left, SingleComponentResponseOfDestinyItemComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (SingleComponentResponseOfDestinyItemComponent.
        /// </summary>
        /// <param name="left">Compared (SingleComponentResponseOfDestinyItemComponent</param>
        /// <param name="right">Compared (SingleComponentResponseOfDestinyItemComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (SingleComponentResponseOfDestinyItemComponent left, SingleComponentResponseOfDestinyItemComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of SingleComponentResponseOfDestinyItemComponent.
        /// </summary>
        public sealed class SingleComponentResponseOfDestinyItemComponentBuilder
        {
            private DestinyEntitiesItemsDestinyItemComponent _Data;
            private int? _Privacy;
            private bool? _Disabled;

            internal SingleComponentResponseOfDestinyItemComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for SingleComponentResponseOfDestinyItemComponent.Data property.
            /// </summary>
            /// <param name="value">Data</param>
            public SingleComponentResponseOfDestinyItemComponentBuilder Data(DestinyEntitiesItemsDestinyItemComponent value)
            {
                _Data = value;
                return this;
            }

            /// <summary>
            /// Sets value for SingleComponentResponseOfDestinyItemComponent.Privacy property.
            /// </summary>
            /// <param name="value">Privacy</param>
            public SingleComponentResponseOfDestinyItemComponentBuilder Privacy(int? value)
            {
                _Privacy = value;
                return this;
            }

            /// <summary>
            /// Sets value for SingleComponentResponseOfDestinyItemComponent.Disabled property.
            /// </summary>
            /// <param name="value">If true, this component is disabled.</param>
            public SingleComponentResponseOfDestinyItemComponentBuilder Disabled(bool? value)
            {
                _Disabled = value;
                return this;
            }


            /// <summary>
            /// Builds instance of SingleComponentResponseOfDestinyItemComponent.
            /// </summary>
            /// <returns>SingleComponentResponseOfDestinyItemComponent</returns>
            public SingleComponentResponseOfDestinyItemComponent Build()
            {
                Validate();
                return new SingleComponentResponseOfDestinyItemComponent(
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