﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager.AppService.Tests.Helpers;
using NUnit.Framework;

namespace Azure.ResourceManager.AppService.Tests.TestsCase
{
    public class SiteSlotConfigWebCollectionTests : AppServiceTestBase
    {
        public SiteSlotConfigWebCollectionTests(bool isAsync)
           : base(isAsync, Azure.Core.TestFramework.RecordedTestMode.Record)
        {
        }

        private async Task<SiteSlotConfigWebCollection> GetSiteSlotConfigWebCollectionAsync()
        {
            var resourceGroup = await CreateResourceGroupAsync();
            var SiteName = Recording.GenerateAssetName("testSite");
            var SiteSlotName = Recording.GenerateAssetName("testSiteSlot");
            var SiteInput = ResourceDataHelper.GetBasicSiteData(DefaultLocation);
            var lro = await resourceGroup.GetSites().CreateOrUpdateAsync(SiteName, SiteInput);
            var Site = lro.Value;
            var lroSiteSlot = await Site.GetSiteSlots().CreateOrUpdateAsync(SiteSlotName,SiteInput);
            var siteSlot = lroSiteSlot.Value;
            return siteSlot.GetSiteSlotConfigWebs();
        }

        [TestCase]
        [RecordedTest]
        public async Task CreateOrUpdate()
        {
            var container = await GetSiteSlotConfigWebCollectionAsync();
            var name = Recording.GenerateAssetName("testSiteSlotConfigWeb");
            var Input = ResourceDataHelper.GetBasicSiteConfigResourceData(DefaultLocation);
            var lro = await container.CreateOrUpdateAsync(Input);
            SiteSlotConfigWeb siteSlotConfigWeb = lro.Value;
            Assert.AreEqual(name, siteSlotConfigWeb.Data.Name);
        }
    }
}
