﻿using Cobra.Server.Attributes;
using Cobra.Server.Enums;
using Cobra.Server.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Cobra.Server.Controllers.Hitman
{
    /**
     * Invoke: ZContractManager::UpdateLikesDislikes @ 0060FC20
     * Callback: None
     */
    public partial class HitmanController
    {
        [EdmFunctionImport("UpdateContractLikeDislikes", HttpMethods.GET, null)]
        public class UpdateContractLikeDislikesRequest : IEdmFunctionImport
        {
            [NormalizedString]
            [SFunctionParameter("fromUserId", EdmTypes.String)]
            public string FromUserId { get; set; }

            [NormalizedString]
            [SFunctionParameter("contractId", EdmTypes.String)]
            public string ContractId { get; set; }

            [SFunctionParameter("likesIncrement", EdmTypes.Int32)]
            public int LikesIncrement { get; set; }

            [SFunctionParameter("dislikesIncrement", EdmTypes.Int32)]
            public int DislikesIncrement { get; set; }
        }

        [HttpGet]
        [Route("UpdateContractLikeDislikes")]
        public IActionResult UpdateContractLikeDislikes([FromQuery] UpdateContractLikeDislikesRequest request)
        {
            return Ok();
        }
    }
}
