// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing collection of TriggeredJobHistory and their operations over its parent. </summary>
    public partial class SiteSlotTriggeredWebJobHistoryCollection : ArmCollection, IEnumerable<SiteSlotTriggeredWebJobHistory>, IAsyncEnumerable<SiteSlotTriggeredWebJobHistory>

    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly WebAppsRestOperations _webAppsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SiteSlotTriggeredWebJobHistoryCollection"/> class for mocking. </summary>
        protected SiteSlotTriggeredWebJobHistoryCollection()
        {
        }

        /// <summary> Initializes a new instance of SiteSlotTriggeredWebJobHistoryCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal SiteSlotTriggeredWebJobHistoryCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _webAppsRestClient = new WebAppsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => SiteSlotTriggeredWebJob.ResourceType;

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/triggeredwebjobs/{webJobName}/history/{id}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/triggeredwebjobs/{webJobName}
        /// OperationId: WebApps_GetTriggeredWebJobHistory
        /// <summary> Description for Gets a triggered web job&apos;s history by its ID for an app, , or a deployment slot. </summary>
        /// <param name="id"> History ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public virtual Response<SiteSlotTriggeredWebJobHistory> Get(string id, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteSlotTriggeredWebJobHistoryCollection.Get");
            scope.Start();
            try
            {
                var response = _webAppsRestClient.GetTriggeredWebJobHistory(Id.ResourceGroupName, Id.Parent.Name, Id.Name, id, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteSlotTriggeredWebJobHistory(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/triggeredwebjobs/{webJobName}/history/{id}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/triggeredwebjobs/{webJobName}
        /// OperationId: WebApps_GetTriggeredWebJobHistory
        /// <summary> Description for Gets a triggered web job&apos;s history by its ID for an app, , or a deployment slot. </summary>
        /// <param name="id"> History ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public async virtual Task<Response<SiteSlotTriggeredWebJobHistory>> GetAsync(string id, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteSlotTriggeredWebJobHistoryCollection.Get");
            scope.Start();
            try
            {
                var response = await _webAppsRestClient.GetTriggeredWebJobHistoryAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, id, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new SiteSlotTriggeredWebJobHistory(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="id"> History ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public virtual Response<SiteSlotTriggeredWebJobHistory> GetIfExists(string id, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteSlotTriggeredWebJobHistoryCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _webAppsRestClient.GetTriggeredWebJobHistory(Id.ResourceGroupName, Id.Parent.Name, Id.Name, id, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<SiteSlotTriggeredWebJobHistory>(null, response.GetRawResponse())
                    : Response.FromValue(new SiteSlotTriggeredWebJobHistory(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="id"> History ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public async virtual Task<Response<SiteSlotTriggeredWebJobHistory>> GetIfExistsAsync(string id, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteSlotTriggeredWebJobHistoryCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _webAppsRestClient.GetTriggeredWebJobHistoryAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, id, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<SiteSlotTriggeredWebJobHistory>(null, response.GetRawResponse())
                    : Response.FromValue(new SiteSlotTriggeredWebJobHistory(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="id"> History ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public virtual Response<bool> CheckIfExists(string id, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteSlotTriggeredWebJobHistoryCollection.CheckIfExists");
            scope.Start();
            try
            {
                var response = GetIfExists(id, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="id"> History ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string id, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteSlotTriggeredWebJobHistoryCollection.CheckIfExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(id, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/triggeredwebjobs/{webJobName}/history
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/triggeredwebjobs/{webJobName}
        /// OperationId: WebApps_ListTriggeredWebJobHistory
        /// <summary> Description for List a triggered web job&apos;s history for an app, or a deployment slot. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SiteSlotTriggeredWebJobHistory" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SiteSlotTriggeredWebJobHistory> GetAll(CancellationToken cancellationToken = default)
        {
            Page<SiteSlotTriggeredWebJobHistory> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SiteSlotTriggeredWebJobHistoryCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _webAppsRestClient.ListTriggeredWebJobHistory(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteSlotTriggeredWebJobHistory(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SiteSlotTriggeredWebJobHistory> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SiteSlotTriggeredWebJobHistoryCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _webAppsRestClient.ListTriggeredWebJobHistoryNextPage(nextLink, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteSlotTriggeredWebJobHistory(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/triggeredwebjobs/{webJobName}/history
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/triggeredwebjobs/{webJobName}
        /// OperationId: WebApps_ListTriggeredWebJobHistory
        /// <summary> Description for List a triggered web job&apos;s history for an app, or a deployment slot. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SiteSlotTriggeredWebJobHistory" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SiteSlotTriggeredWebJobHistory> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SiteSlotTriggeredWebJobHistory>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SiteSlotTriggeredWebJobHistoryCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _webAppsRestClient.ListTriggeredWebJobHistoryAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteSlotTriggeredWebJobHistory(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SiteSlotTriggeredWebJobHistory>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SiteSlotTriggeredWebJobHistoryCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _webAppsRestClient.ListTriggeredWebJobHistoryNextPageAsync(nextLink, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteSlotTriggeredWebJobHistory(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<SiteSlotTriggeredWebJobHistory> IEnumerable<SiteSlotTriggeredWebJobHistory>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SiteSlotTriggeredWebJobHistory> IAsyncEnumerable<SiteSlotTriggeredWebJobHistory>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, SiteSlotTriggeredWebJobHistory, TriggeredJobHistoryData> Construct() { }
    }
}
