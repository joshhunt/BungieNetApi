using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// SingleComponentResponseOfDestinyInventoryComponent
    /// </summary>
    public sealed class SingleComponentResponseOfDestinyInventoryComponent:  IEquatable<SingleComponentResponseOfDestinyInventoryComponent>
    { 
        /// <summary>
        /// Data
        /// </summary>
        public DestinyEntitiesInventoryDestinyInventoryComponent Data { get; private set; }

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
        /// Use SingleComponentResponseOfDestinyInventoryComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public SingleComponentResponseOfDestinyInventoryComponent()
        {
        }

        private SingleComponentResponseOfDestinyInventoryComponent(DestinyEntitiesInventoryDestinyInventoryComponent Data, int? Privacy, bool? Disabled)
        {
            
            this.Data = Data;
            
            this.Privacy = Privacy;
            
            this.Disabled = Disabled;
            
        }

        /// <summary>
        /// Returns builder of SingleComponentResponseOfDestinyInventoryComponent.
        /// </summary>
        /// <returns>SingleComponentResponseOfDestinyInventoryComponentBuilder</returns>
        public static SingleComponentResponseOfDestinyInventoryComponentBuilder Builder()
        {
            return new SingleComponentResponseOfDestinyInventoryComponentBuilder();
        }

        /// <summary>
        /// Returns SingleComponentResponseOfDestinyInventoryComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>SingleComponentResponseOfDestinyInventoryComponentBuilder</returns>
        public SingleComponentResponseOfDestinyInventoryComponentBuilder With()
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

        public bool Equals(SingleComponentResponseOfDestinyInventoryComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (SingleComponentResponseOfDestinyInventoryComponent.
        /// </summary>
        /// <param name="left">Compared (SingleComponentResponseOfDestinyInventoryComponent</param>
        /// <param name="right">Compared (SingleComponentResponseOfDestinyInventoryComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (SingleComponentResponseOfDestinyInventoryComponent left, SingleComponentResponseOfDestinyInventoryComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (SingleComponentResponseOfDestinyInventoryComponent.
        /// </summary>
        /// <param name="left">Compared (SingleComponentResponseOfDestinyInventoryComponent</param>
        /// <param name="right">Compared (SingleComponentResponseOfDestinyInventoryComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (SingleComponentResponseOfDestinyInventoryComponent left, SingleComponentResponseOfDestinyInventoryComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of SingleComponentResponseOfDestinyInventoryComponent.
        /// </summary>
        public sealed class SingleComponentResponseOfDestinyInventoryComponentBuilder
        {
            private DestinyEntitiesInventoryDestinyInventoryComponent _Data;
            private int? _Privacy;
            private bool? _Disabled;

            internal SingleComponentResponseOfDestinyInventoryComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for SingleComponentResponseOfDestinyInventoryComponent.Data property.
            /// </summary>
            /// <param name="value">Data</param>
            public SingleComponentResponseOfDestinyInventoryComponentBuilder Data(DestinyEntitiesInventoryDestinyInventoryComponent value)
            {
                _Data = value;
                return this;
            }

            /// <summary>
            /// Sets value for SingleComponentResponseOfDestinyInventoryComponent.Privacy property.
            /// </summary>
            /// <param name="value">Privacy</param>
            public SingleComponentResponseOfDestinyInventoryComponentBuilder Privacy(int? value)
            {
                _Privacy = value;
                return this;
            }

            /// <summary>
            /// Sets value for SingleComponentResponseOfDestinyInventoryComponent.Disabled property.
            /// </summary>
            /// <param name="value">If true, this component is disabled.</param>
            public SingleComponentResponseOfDestinyInventoryComponentBuilder Disabled(bool? value)
            {
                _Disabled = value;
                return this;
            }


            /// <summary>
            /// Builds instance of SingleComponentResponseOfDestinyInventoryComponent.
            /// </summary>
            /// <returns>SingleComponentResponseOfDestinyInventoryComponent</returns>
            public SingleComponentResponseOfDestinyInventoryComponent Build()
            {
                Validate();
                return new SingleComponentResponseOfDestinyInventoryComponent(
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