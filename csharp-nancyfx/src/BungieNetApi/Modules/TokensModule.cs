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
    /// Module processing requests of Tokens domain.
    /// </summary>
    public sealed class TokensModule : NancyModule
    {
        /// <summary>
        /// Sets up HTTP methods mappings.
        /// </summary>
        /// <param name="service">Service handling requests</param>
        public TokensModule(TokensService service) : base("/Platform")
        { 
            Post["/Tokens/Partner/ApplyMissingOffers/{partnerApplicationId}/{targetBnetMembershipId}/"] = parameters =>
            {
                var partnerApplicationId = Parameters.ValueOf<int?>(parameters, Context.Request, "partnerApplicationId", ParameterType.Path);
                var targetBnetMembershipId = Parameters.ValueOf<long?>(parameters, Context.Request, "targetBnetMembershipId", ParameterType.Path);
                Preconditions.IsNotNull(partnerApplicationId, "Required parameter: 'partnerApplicationId' is missing at 'TokensApplyMissingPartnerOffersWithoutClaim'");
                
                Preconditions.IsNotNull(targetBnetMembershipId, "Required parameter: 'targetBnetMembershipId' is missing at 'TokensApplyMissingPartnerOffersWithoutClaim'");
                
                return service.TokensApplyMissingPartnerOffersWithoutClaim(Context, partnerApplicationId, targetBnetMembershipId);
            };

            Post["/Tokens/Partner/ClaimOffer/"] = parameters =>
            {
                
                return service.TokensClaimPartnerOffer(Context);
            };

            Get["/Tokens/Partner/History/{partnerApplicationId}/{targetBnetMembershipId}/"] = parameters =>
            {
                var partnerApplicationId = Parameters.ValueOf<int?>(parameters, Context.Request, "partnerApplicationId", ParameterType.Path);
                var targetBnetMembershipId = Parameters.ValueOf<long?>(parameters, Context.Request, "targetBnetMembershipId", ParameterType.Path);
                Preconditions.IsNotNull(partnerApplicationId, "Required parameter: 'partnerApplicationId' is missing at 'TokensGetPartnerOfferSkuHistory'");
                
                Preconditions.IsNotNull(targetBnetMembershipId, "Required parameter: 'targetBnetMembershipId' is missing at 'TokensGetPartnerOfferSkuHistory'");
                
                return service.TokensGetPartnerOfferSkuHistory(Context, partnerApplicationId, targetBnetMembershipId);
            };
        }
    }

    /// <summary>
    /// Service handling Tokens requests.
    /// </summary>
    public interface TokensService
    {
        /// <summary>
        /// Apply a partner offer to the targeted user. This endpoint does not claim a new offer, but any already claimed offers will be applied to the game if not already.
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <param name="partnerApplicationId">The partner application identifier.</param>
        /// <param name="targetBnetMembershipId">The bungie.net user to apply missing offers to. If not self, elevated permissions are required.</param>
        /// <returns>InlineResponse20017</returns>
        InlineResponse20017 TokensApplyMissingPartnerOffersWithoutClaim(NancyContext context, int? partnerApplicationId, long? targetBnetMembershipId);

        /// <summary>
        /// Claim a partner offer as the authenticated user.
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <returns>InlineResponse20017</returns>
        InlineResponse20017 TokensClaimPartnerOffer(NancyContext context);

        /// <summary>
        /// Returns the partner sku and offer history of the targeted user. Elevated permissions are required to see users that are not yourself.
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <param name="partnerApplicationId">The partner application identifier.</param>
        /// <param name="targetBnetMembershipId">The bungie.net user to apply missing offers to. If not self, elevated permissions are required.</param>
        /// <returns>InlineResponse20032</returns>
        InlineResponse20032 TokensGetPartnerOfferSkuHistory(NancyContext context, int? partnerApplicationId, long? targetBnetMembershipId);
    }

    /// <summary>
    /// Abstraction of TokensService.
    /// </summary>
    public abstract class AbstractTokensService: TokensService
    {
        public virtual InlineResponse20017 TokensApplyMissingPartnerOffersWithoutClaim(NancyContext context, int? partnerApplicationId, long? targetBnetMembershipId)
        {
            return TokensApplyMissingPartnerOffersWithoutClaim(partnerApplicationId, targetBnetMembershipId);
        }

        public virtual InlineResponse20017 TokensClaimPartnerOffer(NancyContext context)
        {
            return TokensClaimPartnerOffer();
        }

        public virtual InlineResponse20032 TokensGetPartnerOfferSkuHistory(NancyContext context, int? partnerApplicationId, long? targetBnetMembershipId)
        {
            return TokensGetPartnerOfferSkuHistory(partnerApplicationId, targetBnetMembershipId);
        }

        protected abstract InlineResponse20017 TokensApplyMissingPartnerOffersWithoutClaim(int? partnerApplicationId, long? targetBnetMembershipId);

        protected abstract InlineResponse20017 TokensClaimPartnerOffer();

        protected abstract InlineResponse20032 TokensGetPartnerOfferSkuHistory(int? partnerApplicationId, long? targetBnetMembershipId);
    }

}
