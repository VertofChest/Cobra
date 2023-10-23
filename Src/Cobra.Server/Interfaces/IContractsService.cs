﻿using Cobra.Server.Controllers.Hitman;
using Cobra.Server.Models;

namespace Cobra.Server.Interfaces
{
    public interface IContractsService
    {
        void RebuildCache();
        string CreateContract(HitmanController.UploadContractRequest request);
        string CreateContract(string compressedBase64Contract);
        void RemoveContract(string contractId);
        IEnumerable<Contract> GetContracts(HitmanController.SearchForContracts2Request request, Func<Contract, bool> additionalFilter = null);
        string GetShareableContractLink(string contractId);
        string GetLevelName(Contract contract);
        string GetDifficultyName(Contract contract);
    }
}
