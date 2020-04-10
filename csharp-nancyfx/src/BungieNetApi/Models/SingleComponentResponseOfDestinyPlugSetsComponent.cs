using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// SingleComponentResponseOfDestinyPlugSetsComponent
    /// </summary>
    public sealed class SingleComponentResponseOfDestinyPlugSetsComponent:  IEquatable<SingleComponentResponseOfDestinyPlugSetsComponent>
    { 
        /// <summary>
        /// Data
        /// </summary>
        public DestinyComponentsPlugSetsDestinyPlugSetsComponent Data { get; private set; }

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
        /// Use SingleComponentResponseOfDestinyPlugSetsComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public SingleComponentResponseOfDestinyPlugSetsComponent()
        {
        }

        private SingleComponentResponseOfDestinyPlugSetsComponent(DestinyComponentsPlugSetsDestinyPlugSetsComponent Data, int? Privacy, bool? Disabled)
        {
            
            this.Data = Data;
            
            this.Privacy = Privacy;
            
            this.Disabled = Disabled;
            
        }

        /// <summary>
        /// Returns builder of SingleComponentResponseOfDestinyPlugSetsComponent.
        /// </summary>
        /// <returns>SingleComponentResponseOfDestinyPlugSetsComponentBuilder</returns>
        public static SingleComponentResponseOfDestinyPlugSetsComponentBuilder Builder()
        {
            return new SingleComponentResponseOfDestinyPlugSetsComponentBuilder();
        }

        /// <summary>
        /// Returns SingleComponentResponseOfDestinyPlugSetsComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>SingleComponentResponseOfDestinyPlugSetsComponentBuilder</returns>
        public SingleComponentResponseOfDestinyPlugSetsComponentBuilder With()
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

        public bool Equals(SingleComponentResponseOfDestinyPlugSetsComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (SingleComponentResponseOfDestinyPlugSetsComponent.
        /// </summary>
        /// <param name="left">Compared (SingleComponentResponseOfDestinyPlugSetsComponent</param>
        /// <param name="right">Compared (SingleComponentResponseOfDestinyPlugSetsComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (SingleComponentResponseOfDestinyPlugSetsComponent left, SingleComponentResponseOfDestinyPlugSetsComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (SingleComponentResponseOfDestinyPlugSetsComponent.
        /// </summary>
        /// <param name="left">Compared (SingleComponentResponseOfDestinyPlugSetsComponent</param>
        /// <param name="right">Compared (SingleComponentResponseOfDestinyPlugSetsComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (SingleComponentResponseOfDestinyPlugSetsComponent left, SingleComponentResponseOfDestinyPlugSetsComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of SingleComponentResponseOfDestinyPlugSetsComponent.
        /// </summary>
        public sealed class SingleComponentResponseOfDestinyPlugSetsComponentBuilder
        {
            private DestinyComponentsPlugSetsDestinyPlugSetsComponent _Data;
            private int? _Privacy;
            private bool? _Disabled;

            internal SingleComponentResponseOfDestinyPlugSetsComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for SingleComponentResponseOfDestinyPlugSetsComponent.Data property.
            /// </summary>
            /// <param name="value">Data</param>
            public SingleComponentResponseOfDestinyPlugSetsComponentBuilder Data(DestinyComponentsPlugSetsDestinyPlugSetsComponent value)
            {
                _Data = value;
                return this;
            }

            /// <summary>
            /// Sets value for SingleComponentResponseOfDestinyPlugSetsComponent.Privacy property.
            /// </summary>
            /// <param name="value">Privacy</param>
            public SingleComponentResponseOfDestinyPlugSetsComponentBuilder Privacy(int? value)
            {
                _Privacy = value;
                return this;
            }

            /// <summary>
            /// Sets value for SingleComponentResponseOfDestinyPlugSetsComponent.Disabled property.
            /// </summary>
            /// <param name="value">If true, this component is disabled.</param>
            public SingleComponentResponseOfDestinyPlugSetsComponentBuilder Disabled(bool? value)
            {
                _Disabled = value;
                return this;
            }


            /// <summary>
            /// Builds instance of SingleComponentResponseOfDestinyPlugSetsComponent.
            /// </summary>
            /// <returns>SingleComponentResponseOfDestinyPlugSetsComponent</returns>
            public SingleComponentResponseOfDestinyPlugSetsComponent Build()
            {
                Validate();
                return new SingleComponentResponseOfDestinyPlugSetsComponent(
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