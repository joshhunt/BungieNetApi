using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// NOTE: GroupQuery, as of Destiny 2, has essentially two totally different and incompatible \&quot;modes\&quot;.  If you are querying for a group, you can pass any of the properties below.  If you are querying for a Clan, you MUST NOT pass any of the following properties (they must be null or undefined in your request, not just empty string/default values):  - groupMemberCountFilter - localeFilter - tagText  If you pass these, you will get a useless InvalidParameters error.
    /// </summary>
    public sealed class GroupsV2GroupQuery:  IEquatable<GroupsV2GroupQuery>
    { 
        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// GroupType
        /// </summary>
        public int? GroupType { get; private set; }

        /// <summary>
        /// CreationDate
        /// </summary>
        public int? CreationDate { get; private set; }

        /// <summary>
        /// SortBy
        /// </summary>
        public int? SortBy { get; private set; }

        /// <summary>
        /// GroupMemberCountFilter
        /// </summary>
        public GroupMemberCountFilterEnum? GroupMemberCountFilter { get; private set; }

        /// <summary>
        /// LocaleFilter
        /// </summary>
        public string LocaleFilter { get; private set; }

        /// <summary>
        /// TagText
        /// </summary>
        public string TagText { get; private set; }

        /// <summary>
        /// ItemsPerPage
        /// </summary>
        public int? ItemsPerPage { get; private set; }

        /// <summary>
        /// CurrentPage
        /// </summary>
        public int? CurrentPage { get; private set; }

        /// <summary>
        /// RequestContinuationToken
        /// </summary>
        public string RequestContinuationToken { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use GroupsV2GroupQuery.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public GroupsV2GroupQuery()
        {
        }

        private GroupsV2GroupQuery(string Name, int? GroupType, int? CreationDate, int? SortBy, GroupMemberCountFilterEnum? GroupMemberCountFilter, string LocaleFilter, string TagText, int? ItemsPerPage, int? CurrentPage, string RequestContinuationToken)
        {
            
            this.Name = Name;
            
            this.GroupType = GroupType;
            
            this.CreationDate = CreationDate;
            
            this.SortBy = SortBy;
            
            this.GroupMemberCountFilter = GroupMemberCountFilter;
            
            this.LocaleFilter = LocaleFilter;
            
            this.TagText = TagText;
            
            this.ItemsPerPage = ItemsPerPage;
            
            this.CurrentPage = CurrentPage;
            
            this.RequestContinuationToken = RequestContinuationToken;
            
        }

        /// <summary>
        /// Returns builder of GroupsV2GroupQuery.
        /// </summary>
        /// <returns>GroupsV2GroupQueryBuilder</returns>
        public static GroupsV2GroupQueryBuilder Builder()
        {
            return new GroupsV2GroupQueryBuilder();
        }

        /// <summary>
        /// Returns GroupsV2GroupQueryBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>GroupsV2GroupQueryBuilder</returns>
        public GroupsV2GroupQueryBuilder With()
        {
            return Builder()
                .Name(Name)
                .GroupType(GroupType)
                .CreationDate(CreationDate)
                .SortBy(SortBy)
                .GroupMemberCountFilter(GroupMemberCountFilter)
                .LocaleFilter(LocaleFilter)
                .TagText(TagText)
                .ItemsPerPage(ItemsPerPage)
                .CurrentPage(CurrentPage)
                .RequestContinuationToken(RequestContinuationToken);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(GroupsV2GroupQuery other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (GroupsV2GroupQuery.
        /// </summary>
        /// <param name="left">Compared (GroupsV2GroupQuery</param>
        /// <param name="right">Compared (GroupsV2GroupQuery</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (GroupsV2GroupQuery left, GroupsV2GroupQuery right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (GroupsV2GroupQuery.
        /// </summary>
        /// <param name="left">Compared (GroupsV2GroupQuery</param>
        /// <param name="right">Compared (GroupsV2GroupQuery</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (GroupsV2GroupQuery left, GroupsV2GroupQuery right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of GroupsV2GroupQuery.
        /// </summary>
        public sealed class GroupsV2GroupQueryBuilder
        {
            private string _Name;
            private int? _GroupType;
            private int? _CreationDate;
            private int? _SortBy;
            private GroupMemberCountFilterEnum? _GroupMemberCountFilter;
            private string _LocaleFilter;
            private string _TagText;
            private int? _ItemsPerPage;
            private int? _CurrentPage;
            private string _RequestContinuationToken;

            internal GroupsV2GroupQueryBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for GroupsV2GroupQuery.Name property.
            /// </summary>
            /// <param name="value">Name</param>
            public GroupsV2GroupQueryBuilder Name(string value)
            {
                _Name = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupQuery.GroupType property.
            /// </summary>
            /// <param name="value">GroupType</param>
            public GroupsV2GroupQueryBuilder GroupType(int? value)
            {
                _GroupType = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupQuery.CreationDate property.
            /// </summary>
            /// <param name="value">CreationDate</param>
            public GroupsV2GroupQueryBuilder CreationDate(int? value)
            {
                _CreationDate = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupQuery.SortBy property.
            /// </summary>
            /// <param name="value">SortBy</param>
            public GroupsV2GroupQueryBuilder SortBy(int? value)
            {
                _SortBy = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupQuery.GroupMemberCountFilter property.
            /// </summary>
            /// <param name="value">GroupMemberCountFilter</param>
            public GroupsV2GroupQueryBuilder GroupMemberCountFilter(GroupMemberCountFilterEnum? value)
            {
                _GroupMemberCountFilter = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupQuery.LocaleFilter property.
            /// </summary>
            /// <param name="value">LocaleFilter</param>
            public GroupsV2GroupQueryBuilder LocaleFilter(string value)
            {
                _LocaleFilter = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupQuery.TagText property.
            /// </summary>
            /// <param name="value">TagText</param>
            public GroupsV2GroupQueryBuilder TagText(string value)
            {
                _TagText = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupQuery.ItemsPerPage property.
            /// </summary>
            /// <param name="value">ItemsPerPage</param>
            public GroupsV2GroupQueryBuilder ItemsPerPage(int? value)
            {
                _ItemsPerPage = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupQuery.CurrentPage property.
            /// </summary>
            /// <param name="value">CurrentPage</param>
            public GroupsV2GroupQueryBuilder CurrentPage(int? value)
            {
                _CurrentPage = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupQuery.RequestContinuationToken property.
            /// </summary>
            /// <param name="value">RequestContinuationToken</param>
            public GroupsV2GroupQueryBuilder RequestContinuationToken(string value)
            {
                _RequestContinuationToken = value;
                return this;
            }


            /// <summary>
            /// Builds instance of GroupsV2GroupQuery.
            /// </summary>
            /// <returns>GroupsV2GroupQuery</returns>
            public GroupsV2GroupQuery Build()
            {
                Validate();
                return new GroupsV2GroupQuery(
                    Name: _Name,
                    GroupType: _GroupType,
                    CreationDate: _CreationDate,
                    SortBy: _SortBy,
                    GroupMemberCountFilter: _GroupMemberCountFilter,
                    LocaleFilter: _LocaleFilter,
                    TagText: _TagText,
                    ItemsPerPage: _ItemsPerPage,
                    CurrentPage: _CurrentPage,
                    RequestContinuationToken: _RequestContinuationToken
                );
            }

            private void Validate()
            { 
            }
        }

        
        public enum GroupMemberCountFilterEnum { _0, _1, _2, _3 };
    }
}