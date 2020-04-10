using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyDefinitionsPresentationDestinyPresentationChildBlock
    /// </summary>
    public sealed class DestinyDefinitionsPresentationDestinyPresentationChildBlock:  IEquatable<DestinyDefinitionsPresentationDestinyPresentationChildBlock>
    { 
        /// <summary>
        /// PresentationNodeType
        /// </summary>
        public int? PresentationNodeType { get; private set; }

        /// <summary>
        /// ParentPresentationNodeHashes
        /// </summary>
        public List<int?> ParentPresentationNodeHashes { get; private set; }

        /// <summary>
        /// DisplayStyle
        /// </summary>
        public int? DisplayStyle { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsPresentationDestinyPresentationChildBlock.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsPresentationDestinyPresentationChildBlock()
        {
        }

        private DestinyDefinitionsPresentationDestinyPresentationChildBlock(int? PresentationNodeType, List<int?> ParentPresentationNodeHashes, int? DisplayStyle)
        {
            
            this.PresentationNodeType = PresentationNodeType;
            
            this.ParentPresentationNodeHashes = ParentPresentationNodeHashes;
            
            this.DisplayStyle = DisplayStyle;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsPresentationDestinyPresentationChildBlock.
        /// </summary>
        /// <returns>DestinyDefinitionsPresentationDestinyPresentationChildBlockBuilder</returns>
        public static DestinyDefinitionsPresentationDestinyPresentationChildBlockBuilder Builder()
        {
            return new DestinyDefinitionsPresentationDestinyPresentationChildBlockBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsPresentationDestinyPresentationChildBlockBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsPresentationDestinyPresentationChildBlockBuilder</returns>
        public DestinyDefinitionsPresentationDestinyPresentationChildBlockBuilder With()
        {
            return Builder()
                .PresentationNodeType(PresentationNodeType)
                .ParentPresentationNodeHashes(ParentPresentationNodeHashes)
                .DisplayStyle(DisplayStyle);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsPresentationDestinyPresentationChildBlock other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsPresentationDestinyPresentationChildBlock.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsPresentationDestinyPresentationChildBlock</param>
        /// <param name="right">Compared (DestinyDefinitionsPresentationDestinyPresentationChildBlock</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsPresentationDestinyPresentationChildBlock left, DestinyDefinitionsPresentationDestinyPresentationChildBlock right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsPresentationDestinyPresentationChildBlock.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsPresentationDestinyPresentationChildBlock</param>
        /// <param name="right">Compared (DestinyDefinitionsPresentationDestinyPresentationChildBlock</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsPresentationDestinyPresentationChildBlock left, DestinyDefinitionsPresentationDestinyPresentationChildBlock right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsPresentationDestinyPresentationChildBlock.
        /// </summary>
        public sealed class DestinyDefinitionsPresentationDestinyPresentationChildBlockBuilder
        {
            private int? _PresentationNodeType;
            private List<int?> _ParentPresentationNodeHashes;
            private int? _DisplayStyle;

            internal DestinyDefinitionsPresentationDestinyPresentationChildBlockBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsPresentationDestinyPresentationChildBlock.PresentationNodeType property.
            /// </summary>
            /// <param name="value">PresentationNodeType</param>
            public DestinyDefinitionsPresentationDestinyPresentationChildBlockBuilder PresentationNodeType(int? value)
            {
                _PresentationNodeType = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsPresentationDestinyPresentationChildBlock.ParentPresentationNodeHashes property.
            /// </summary>
            /// <param name="value">ParentPresentationNodeHashes</param>
            public DestinyDefinitionsPresentationDestinyPresentationChildBlockBuilder ParentPresentationNodeHashes(List<int?> value)
            {
                _ParentPresentationNodeHashes = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsPresentationDestinyPresentationChildBlock.DisplayStyle property.
            /// </summary>
            /// <param name="value">DisplayStyle</param>
            public DestinyDefinitionsPresentationDestinyPresentationChildBlockBuilder DisplayStyle(int? value)
            {
                _DisplayStyle = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsPresentationDestinyPresentationChildBlock.
            /// </summary>
            /// <returns>DestinyDefinitionsPresentationDestinyPresentationChildBlock</returns>
            public DestinyDefinitionsPresentationDestinyPresentationChildBlock Build()
            {
                Validate();
                return new DestinyDefinitionsPresentationDestinyPresentationChildBlock(
                    PresentationNodeType: _PresentationNodeType,
                    ParentPresentationNodeHashes: _ParentPresentationNodeHashes,
                    DisplayStyle: _DisplayStyle
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}