using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyDefinitionsRecordsDestinyRecordCompletionBlock
    /// </summary>
    public sealed class DestinyDefinitionsRecordsDestinyRecordCompletionBlock:  IEquatable<DestinyDefinitionsRecordsDestinyRecordCompletionBlock>
    { 
        /// <summary>
        /// The number of objectives that must be completed before the objective is considered \&quot;complete\&quot;
        /// </summary>
        public int? PartialCompletionObjectiveCountThreshold { get; private set; }

        /// <summary>
        /// ScoreValue
        /// </summary>
        public int? ScoreValue { get; private set; }

        /// <summary>
        /// ShouldFireToast
        /// </summary>
        public bool? ShouldFireToast { get; private set; }

        /// <summary>
        /// ToastStyle
        /// </summary>
        public int? ToastStyle { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsRecordsDestinyRecordCompletionBlock.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsRecordsDestinyRecordCompletionBlock()
        {
        }

        private DestinyDefinitionsRecordsDestinyRecordCompletionBlock(int? PartialCompletionObjectiveCountThreshold, int? ScoreValue, bool? ShouldFireToast, int? ToastStyle)
        {
            
            this.PartialCompletionObjectiveCountThreshold = PartialCompletionObjectiveCountThreshold;
            
            this.ScoreValue = ScoreValue;
            
            this.ShouldFireToast = ShouldFireToast;
            
            this.ToastStyle = ToastStyle;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsRecordsDestinyRecordCompletionBlock.
        /// </summary>
        /// <returns>DestinyDefinitionsRecordsDestinyRecordCompletionBlockBuilder</returns>
        public static DestinyDefinitionsRecordsDestinyRecordCompletionBlockBuilder Builder()
        {
            return new DestinyDefinitionsRecordsDestinyRecordCompletionBlockBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsRecordsDestinyRecordCompletionBlockBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsRecordsDestinyRecordCompletionBlockBuilder</returns>
        public DestinyDefinitionsRecordsDestinyRecordCompletionBlockBuilder With()
        {
            return Builder()
                .PartialCompletionObjectiveCountThreshold(PartialCompletionObjectiveCountThreshold)
                .ScoreValue(ScoreValue)
                .ShouldFireToast(ShouldFireToast)
                .ToastStyle(ToastStyle);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsRecordsDestinyRecordCompletionBlock other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsRecordsDestinyRecordCompletionBlock.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsRecordsDestinyRecordCompletionBlock</param>
        /// <param name="right">Compared (DestinyDefinitionsRecordsDestinyRecordCompletionBlock</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsRecordsDestinyRecordCompletionBlock left, DestinyDefinitionsRecordsDestinyRecordCompletionBlock right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsRecordsDestinyRecordCompletionBlock.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsRecordsDestinyRecordCompletionBlock</param>
        /// <param name="right">Compared (DestinyDefinitionsRecordsDestinyRecordCompletionBlock</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsRecordsDestinyRecordCompletionBlock left, DestinyDefinitionsRecordsDestinyRecordCompletionBlock right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsRecordsDestinyRecordCompletionBlock.
        /// </summary>
        public sealed class DestinyDefinitionsRecordsDestinyRecordCompletionBlockBuilder
        {
            private int? _PartialCompletionObjectiveCountThreshold;
            private int? _ScoreValue;
            private bool? _ShouldFireToast;
            private int? _ToastStyle;

            internal DestinyDefinitionsRecordsDestinyRecordCompletionBlockBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsRecordsDestinyRecordCompletionBlock.PartialCompletionObjectiveCountThreshold property.
            /// </summary>
            /// <param name="value">The number of objectives that must be completed before the objective is considered \&quot;complete\&quot;</param>
            public DestinyDefinitionsRecordsDestinyRecordCompletionBlockBuilder PartialCompletionObjectiveCountThreshold(int? value)
            {
                _PartialCompletionObjectiveCountThreshold = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsRecordsDestinyRecordCompletionBlock.ScoreValue property.
            /// </summary>
            /// <param name="value">ScoreValue</param>
            public DestinyDefinitionsRecordsDestinyRecordCompletionBlockBuilder ScoreValue(int? value)
            {
                _ScoreValue = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsRecordsDestinyRecordCompletionBlock.ShouldFireToast property.
            /// </summary>
            /// <param name="value">ShouldFireToast</param>
            public DestinyDefinitionsRecordsDestinyRecordCompletionBlockBuilder ShouldFireToast(bool? value)
            {
                _ShouldFireToast = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsRecordsDestinyRecordCompletionBlock.ToastStyle property.
            /// </summary>
            /// <param name="value">ToastStyle</param>
            public DestinyDefinitionsRecordsDestinyRecordCompletionBlockBuilder ToastStyle(int? value)
            {
                _ToastStyle = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsRecordsDestinyRecordCompletionBlock.
            /// </summary>
            /// <returns>DestinyDefinitionsRecordsDestinyRecordCompletionBlock</returns>
            public DestinyDefinitionsRecordsDestinyRecordCompletionBlock Build()
            {
                Validate();
                return new DestinyDefinitionsRecordsDestinyRecordCompletionBlock(
                    PartialCompletionObjectiveCountThreshold: _PartialCompletionObjectiveCountThreshold,
                    ScoreValue: _ScoreValue,
                    ShouldFireToast: _ShouldFireToast,
                    ToastStyle: _ToastStyle
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}