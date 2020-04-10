using System;
using Nancy;
using Nancy.ModelBinding;
using System.Collections.Generic;
using Sharpility.Base;
using BungieNetApi._Platform.Models;
using BungieNetApi._Platform.Utils;
using NodaTime;

namespace BungieNetApi._Platform.Modules
{ 

    /// <summary>
    /// Module processing requests of User domain.
    /// </summary>
    public sealed class UserModule : NancyModule
    {
        /// <summary>
        /// Sets up HTTP methods mappings.
        /// </summary>
        /// <param name="service">Service handling requests</param>
        public UserModule(UserService service) : base("/Platform")
        { 
            Get["/User/GetAvailableThemes/"] = parameters =>
            {
                
                return service.UserGetAvailableThemes(Context);
            };

            Get["/User/GetBungieNetUserById/{id}/"] = parameters =>
            {
                var id = Parameters.ValueOf<long?>(parameters, Context.Request, "id", ParameterType.Path);
                Preconditions.IsNotNull(id, "Required parameter: 'id' is missing at 'UserGetBungieNetUserById'");
                
                return service.UserGetBungieNetUserById(Context, id);
            };

            Get["/User/GetMembershipsById/{membershipId}/{membershipType}/"] = parameters =>
            {
                var membershipId = Parameters.ValueOf<long?>(parameters, Context.Request, "membershipId", ParameterType.Path);
                var membershipType = Parameters.ValueOf<int?>(parameters, Context.Request, "membershipType", ParameterType.Path);
                Preconditions.IsNotNull(membershipId, "Required parameter: 'membershipId' is missing at 'UserGetMembershipDataById'");
                
                Preconditions.IsNotNull(membershipType, "Required parameter: 'membershipType' is missing at 'UserGetMembershipDataById'");
                
                return service.UserGetMembershipDataById(Context, membershipId, membershipType);
            };

            Get["/User/GetMembershipsForCurrentUser/"] = parameters =>
            {
                
                return service.UserGetMembershipDataForCurrentUser(Context);
            };

            Get["/User/GetMembershipFromHardLinkedCredential/{crType}/{credential}/"] = parameters =>
            {
                var credential = Parameters.ValueOf<string>(parameters, Context.Request, "credential", ParameterType.Path);
                var crType = Parameters.ValueOf<int?>(parameters, Context.Request, "crType", ParameterType.Path);
                Preconditions.IsNotNull(credential, "Required parameter: 'credential' is missing at 'UserGetMembershipFromHardLinkedCredential'");
                
                Preconditions.IsNotNull(crType, "Required parameter: 'crType' is missing at 'UserGetMembershipFromHardLinkedCredential'");
                
                return service.UserGetMembershipFromHardLinkedCredential(Context, credential, crType);
            };

            Get["/User/SearchUsers/"] = parameters =>
            {
                var q = Parameters.ValueOf<string>(parameters, Context.Request, "q", ParameterType.Query);
                return service.UserSearchUsers(Context, q);
            };
        }
    }

    /// <summary>
    /// Service handling User requests.
    /// </summary>
    public interface UserService
    {
        /// <summary>
        /// Returns a list of all available user themes.
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <returns>InlineResponse2004</returns>
        InlineResponse2004 UserGetAvailableThemes(NancyContext context);

        /// <summary>
        /// Loads a bungienet user by membership id.
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <param name="id">The requested Bungie.net membership id.</param>
        /// <returns>InlineResponse2002</returns>
        InlineResponse2002 UserGetBungieNetUserById(NancyContext context, long? id);

        /// <summary>
        /// Returns a list of accounts associated with the supplied membership ID and membership type. This will include all linked accounts (even when hidden) if supplied credentials permit it.
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <param name="membershipId">The membership ID of the target user.</param>
        /// <param name="membershipType">Type of the supplied membership ID.</param>
        /// <returns>InlineResponse2005</returns>
        InlineResponse2005 UserGetMembershipDataById(NancyContext context, long? membershipId, int? membershipType);

        /// <summary>
        /// Returns a list of accounts associated with signed in user. This is useful for OAuth implementations that do not give you access to the token response.
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <returns>InlineResponse2005</returns>
        InlineResponse2005 UserGetMembershipDataForCurrentUser(NancyContext context);

        /// <summary>
        /// Gets any hard linked membership given a credential. Only works for credentials that are public (just SteamID64 right now). Cross Save aware.
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <param name="credential">The credential to look up. Must be a valid SteamID64.</param>
        /// <param name="crType">The credential type. &#39;SteamId&#39; is the only valid value at present.</param>
        /// <returns>InlineResponse2006</returns>
        InlineResponse2006 UserGetMembershipFromHardLinkedCredential(NancyContext context, string credential, int? crType);

        /// <summary>
        /// Returns a list of possible users based on the search string
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <param name="q">The search string. (optional)</param>
        /// <returns>InlineResponse2003</returns>
        InlineResponse2003 UserSearchUsers(NancyContext context, string q);
    }

    /// <summary>
    /// Abstraction of UserService.
    /// </summary>
    public abstract class AbstractUserService: UserService
    {
        public virtual InlineResponse2004 UserGetAvailableThemes(NancyContext context)
        {
            return UserGetAvailableThemes();
        }

        public virtual InlineResponse2002 UserGetBungieNetUserById(NancyContext context, long? id)
        {
            return UserGetBungieNetUserById(id);
        }

        public virtual InlineResponse2005 UserGetMembershipDataById(NancyContext context, long? membershipId, int? membershipType)
        {
            return UserGetMembershipDataById(membershipId, membershipType);
        }

        public virtual InlineResponse2005 UserGetMembershipDataForCurrentUser(NancyContext context)
        {
            return UserGetMembershipDataForCurrentUser();
        }

        public virtual InlineResponse2006 UserGetMembershipFromHardLinkedCredential(NancyContext context, string credential, int? crType)
        {
            return UserGetMembershipFromHardLinkedCredential(credential, crType);
        }

        public virtual InlineResponse2003 UserSearchUsers(NancyContext context, string q)
        {
            return UserSearchUsers(q);
        }

        protected abstract InlineResponse2004 UserGetAvailableThemes();

        protected abstract InlineResponse2002 UserGetBungieNetUserById(long? id);

        protected abstract InlineResponse2005 UserGetMembershipDataById(long? membershipId, int? membershipType);

        protected abstract InlineResponse2005 UserGetMembershipDataForCurrentUser();

        protected abstract InlineResponse2006 UserGetMembershipFromHardLinkedCredential(string credential, int? crType);

        protected abstract InlineResponse2003 UserSearchUsers(string q);
    }

}
