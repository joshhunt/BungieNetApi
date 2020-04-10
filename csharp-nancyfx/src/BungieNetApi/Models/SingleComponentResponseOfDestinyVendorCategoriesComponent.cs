using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// SingleComponentResponseOfDestinyVendorCategoriesComponent
    /// </summary>
    public sealed class SingleComponentResponseOfDestinyVendorCategoriesComponent:  IEquatable<SingleComponentResponseOfDestinyVendorCategoriesComponent>
    { 
        /// <summary>
        /// Data
        /// </summary>
        public DestinyEntitiesVendorsDestinyVendorCategoriesComponent Data { get; private set; }

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
        /// Use SingleComponentResponseOfDestinyVendorCategoriesComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public SingleComponentResponseOfDestinyVendorCategoriesComponent()
        {
        }

        private SingleComponentResponseOfDestinyVendorCategoriesComponent(DestinyEntitiesVendorsDestinyVendorCategoriesComponent Data, int? Privacy, bool? Disabled)
        {
            
            this.Data = Data;
            
            this.Privacy = Privacy;
            
            this.Disabled = Disabled;
            
        }

        /// <summary>
        /// Returns builder of SingleComponentResponseOfDestinyVendorCategoriesComponent.
        /// </summary>
        /// <returns>SingleComponentResponseOfDestinyVendorCategoriesComponentBuilder</returns>
        public static SingleComponentResponseOfDestinyVendorCategoriesComponentBuilder Builder()
        {
            return new SingleComponentResponseOfDestinyVendorCategoriesComponentBuilder();
        }

        /// <summary>
        /// Returns SingleComponentResponseOfDestinyVendorCategoriesComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>SingleComponentResponseOfDestinyVendorCategoriesComponentBuilder</returns>
        public SingleComponentResponseOfDestinyVendorCategoriesComponentBuilder With()
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

        public bool Equals(SingleComponentResponseOfDestinyVendorCategoriesComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (SingleComponentResponseOfDestinyVendorCategoriesComponent.
        /// </summary>
        /// <param name="left">Compared (SingleComponentResponseOfDestinyVendorCategoriesComponent</param>
        /// <param name="right">Compared (SingleComponentResponseOfDestinyVendorCategoriesComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (SingleComponentResponseOfDestinyVendorCategoriesComponent left, SingleComponentResponseOfDestinyVendorCategoriesComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (SingleComponentResponseOfDestinyVendorCategoriesComponent.
        /// </summary>
        /// <param name="left">Compared (SingleComponentResponseOfDestinyVendorCategoriesComponent</param>
        /// <param name="right">Compared (SingleComponentResponseOfDestinyVendorCategoriesComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (SingleComponentResponseOfDestinyVendorCategoriesComponent left, SingleComponentResponseOfDestinyVendorCategoriesComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of SingleComponentResponseOfDestinyVendorCategoriesComponent.
        /// </summary>
        public sealed class SingleComponentResponseOfDestinyVendorCategoriesComponentBuilder
        {
            private DestinyEntitiesVendorsDestinyVendorCategoriesComponent _Data;
            private int? _Privacy;
            private bool? _Disabled;

            internal SingleComponentResponseOfDestinyVendorCategoriesComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for SingleComponentResponseOfDestinyVendorCategoriesComponent.Data property.
            /// </summary>
            /// <param name="value">Data</param>
            public SingleComponentResponseOfDestinyVendorCategoriesComponentBuilder Data(DestinyEntitiesVendorsDestinyVendorCategoriesComponent value)
            {
                _Data = value;
                return this;
            }

            /// <summary>
            /// Sets value for SingleComponentResponseOfDestinyVendorCategoriesComponent.Privacy property.
            /// </summary>
            /// <param name="value">Privacy</param>
            public SingleComponentResponseOfDestinyVendorCategoriesComponentBuilder Privacy(int? value)
            {
                _Privacy = value;
                return this;
            }

            /// <summary>
            /// Sets value for SingleComponentResponseOfDestinyVendorCategoriesComponent.Disabled property.
            /// </summary>
            /// <param name="value">If true, this component is disabled.</param>
            public SingleComponentResponseOfDestinyVendorCategoriesComponentBuilder Disabled(bool? value)
            {
                _Disabled = value;
                return this;
            }


            /// <summary>
            /// Builds instance of SingleComponentResponseOfDestinyVendorCategoriesComponent.
            /// </summary>
            /// <returns>SingleComponentResponseOfDestinyVendorCategoriesComponent</returns>
            public SingleComponentResponseOfDestinyVendorCategoriesComponent Build()
            {
                Validate();
                return new SingleComponentResponseOfDestinyVendorCategoriesComponent(
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