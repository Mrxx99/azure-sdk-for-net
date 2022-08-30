// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.SecurityCenter
{
    /// <summary>
    /// A class representing a collection of <see cref="RegulatoryComplianceStandardResource" /> and their operations.
    /// Each <see cref="RegulatoryComplianceStandardResource" /> in the collection will belong to the same instance of <see cref="SubscriptionResource" />.
    /// To get a <see cref="RegulatoryComplianceStandardCollection" /> instance call the GetRegulatoryComplianceStandards method from an instance of <see cref="SubscriptionResource" />.
    /// </summary>
    public partial class RegulatoryComplianceStandardCollection : ArmCollection, IEnumerable<RegulatoryComplianceStandardResource>, IAsyncEnumerable<RegulatoryComplianceStandardResource>
    {
        private readonly ClientDiagnostics _regulatoryComplianceStandardClientDiagnostics;
        private readonly RegulatoryComplianceStandardsRestOperations _regulatoryComplianceStandardRestClient;

        /// <summary> Initializes a new instance of the <see cref="RegulatoryComplianceStandardCollection"/> class for mocking. </summary>
        protected RegulatoryComplianceStandardCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="RegulatoryComplianceStandardCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal RegulatoryComplianceStandardCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _regulatoryComplianceStandardClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityCenter", RegulatoryComplianceStandardResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(RegulatoryComplianceStandardResource.ResourceType, out string regulatoryComplianceStandardApiVersion);
            _regulatoryComplianceStandardRestClient = new RegulatoryComplianceStandardsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, regulatoryComplianceStandardApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SubscriptionResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SubscriptionResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Supported regulatory compliance details state for selected standard
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Security/regulatoryComplianceStandards/{regulatoryComplianceStandardName}
        /// Operation Id: RegulatoryComplianceStandards_Get
        /// </summary>
        /// <param name="regulatoryComplianceStandardName"> Name of the regulatory compliance standard object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="regulatoryComplianceStandardName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="regulatoryComplianceStandardName"/> is null. </exception>
        public virtual async Task<Response<RegulatoryComplianceStandardResource>> GetAsync(string regulatoryComplianceStandardName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(regulatoryComplianceStandardName, nameof(regulatoryComplianceStandardName));

            using var scope = _regulatoryComplianceStandardClientDiagnostics.CreateScope("RegulatoryComplianceStandardCollection.Get");
            scope.Start();
            try
            {
                var response = await _regulatoryComplianceStandardRestClient.GetAsync(Id.SubscriptionId, regulatoryComplianceStandardName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RegulatoryComplianceStandardResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Supported regulatory compliance details state for selected standard
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Security/regulatoryComplianceStandards/{regulatoryComplianceStandardName}
        /// Operation Id: RegulatoryComplianceStandards_Get
        /// </summary>
        /// <param name="regulatoryComplianceStandardName"> Name of the regulatory compliance standard object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="regulatoryComplianceStandardName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="regulatoryComplianceStandardName"/> is null. </exception>
        public virtual Response<RegulatoryComplianceStandardResource> Get(string regulatoryComplianceStandardName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(regulatoryComplianceStandardName, nameof(regulatoryComplianceStandardName));

            using var scope = _regulatoryComplianceStandardClientDiagnostics.CreateScope("RegulatoryComplianceStandardCollection.Get");
            scope.Start();
            try
            {
                var response = _regulatoryComplianceStandardRestClient.Get(Id.SubscriptionId, regulatoryComplianceStandardName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RegulatoryComplianceStandardResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Supported regulatory compliance standards details and state
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Security/regulatoryComplianceStandards
        /// Operation Id: RegulatoryComplianceStandards_List
        /// </summary>
        /// <param name="filter"> OData filter. Optional. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="RegulatoryComplianceStandardResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<RegulatoryComplianceStandardResource> GetAllAsync(string filter = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<RegulatoryComplianceStandardResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _regulatoryComplianceStandardClientDiagnostics.CreateScope("RegulatoryComplianceStandardCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _regulatoryComplianceStandardRestClient.ListAsync(Id.SubscriptionId, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new RegulatoryComplianceStandardResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<RegulatoryComplianceStandardResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _regulatoryComplianceStandardClientDiagnostics.CreateScope("RegulatoryComplianceStandardCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _regulatoryComplianceStandardRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new RegulatoryComplianceStandardResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Supported regulatory compliance standards details and state
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Security/regulatoryComplianceStandards
        /// Operation Id: RegulatoryComplianceStandards_List
        /// </summary>
        /// <param name="filter"> OData filter. Optional. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="RegulatoryComplianceStandardResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<RegulatoryComplianceStandardResource> GetAll(string filter = null, CancellationToken cancellationToken = default)
        {
            Page<RegulatoryComplianceStandardResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _regulatoryComplianceStandardClientDiagnostics.CreateScope("RegulatoryComplianceStandardCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _regulatoryComplianceStandardRestClient.List(Id.SubscriptionId, filter, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new RegulatoryComplianceStandardResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<RegulatoryComplianceStandardResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _regulatoryComplianceStandardClientDiagnostics.CreateScope("RegulatoryComplianceStandardCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _regulatoryComplianceStandardRestClient.ListNextPage(nextLink, Id.SubscriptionId, filter, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new RegulatoryComplianceStandardResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Security/regulatoryComplianceStandards/{regulatoryComplianceStandardName}
        /// Operation Id: RegulatoryComplianceStandards_Get
        /// </summary>
        /// <param name="regulatoryComplianceStandardName"> Name of the regulatory compliance standard object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="regulatoryComplianceStandardName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="regulatoryComplianceStandardName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string regulatoryComplianceStandardName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(regulatoryComplianceStandardName, nameof(regulatoryComplianceStandardName));

            using var scope = _regulatoryComplianceStandardClientDiagnostics.CreateScope("RegulatoryComplianceStandardCollection.Exists");
            scope.Start();
            try
            {
                var response = await _regulatoryComplianceStandardRestClient.GetAsync(Id.SubscriptionId, regulatoryComplianceStandardName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Security/regulatoryComplianceStandards/{regulatoryComplianceStandardName}
        /// Operation Id: RegulatoryComplianceStandards_Get
        /// </summary>
        /// <param name="regulatoryComplianceStandardName"> Name of the regulatory compliance standard object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="regulatoryComplianceStandardName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="regulatoryComplianceStandardName"/> is null. </exception>
        public virtual Response<bool> Exists(string regulatoryComplianceStandardName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(regulatoryComplianceStandardName, nameof(regulatoryComplianceStandardName));

            using var scope = _regulatoryComplianceStandardClientDiagnostics.CreateScope("RegulatoryComplianceStandardCollection.Exists");
            scope.Start();
            try
            {
                var response = _regulatoryComplianceStandardRestClient.Get(Id.SubscriptionId, regulatoryComplianceStandardName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<RegulatoryComplianceStandardResource> IEnumerable<RegulatoryComplianceStandardResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<RegulatoryComplianceStandardResource> IAsyncEnumerable<RegulatoryComplianceStandardResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
