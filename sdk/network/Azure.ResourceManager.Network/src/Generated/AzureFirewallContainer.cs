// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing collection of AzureFirewall and their operations over a ResourceGroup. </summary>
    public partial class AzureFirewallContainer : ArmContainer
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly AzureFirewallsRestOperations _restClient;

        /// <summary> Initializes a new instance of the <see cref="AzureFirewallContainer"/> class for mocking. </summary>
        protected AzureFirewallContainer()
        {
        }

        /// <summary> Initializes a new instance of AzureFirewallContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal AzureFirewallContainer(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _restClient = new AzureFirewallsRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ResourceGroup.ResourceType;

        // Container level operations.

        /// <summary> Creates or updates the specified Azure Firewall. </summary>
        /// <param name="azureFirewallName"> The name of the Azure Firewall. </param>
        /// <param name="parameters"> Parameters supplied to the create or update Azure Firewall operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="azureFirewallName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual Response<AzureFirewall> CreateOrUpdate(string azureFirewallName, AzureFirewallData parameters, CancellationToken cancellationToken = default)
        {
            if (azureFirewallName == null)
            {
                throw new ArgumentNullException(nameof(azureFirewallName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("AzureFirewallContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = StartCreateOrUpdate(azureFirewallName, parameters, cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates the specified Azure Firewall. </summary>
        /// <param name="azureFirewallName"> The name of the Azure Firewall. </param>
        /// <param name="parameters"> Parameters supplied to the create or update Azure Firewall operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="azureFirewallName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<Response<AzureFirewall>> CreateOrUpdateAsync(string azureFirewallName, AzureFirewallData parameters, CancellationToken cancellationToken = default)
        {
            if (azureFirewallName == null)
            {
                throw new ArgumentNullException(nameof(azureFirewallName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("AzureFirewallContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = await StartCreateOrUpdateAsync(azureFirewallName, parameters, cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates the specified Azure Firewall. </summary>
        /// <param name="azureFirewallName"> The name of the Azure Firewall. </param>
        /// <param name="parameters"> Parameters supplied to the create or update Azure Firewall operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="azureFirewallName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual AzureFirewallCreateOrUpdateOperation StartCreateOrUpdate(string azureFirewallName, AzureFirewallData parameters, CancellationToken cancellationToken = default)
        {
            if (azureFirewallName == null)
            {
                throw new ArgumentNullException(nameof(azureFirewallName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("AzureFirewallContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = _restClient.CreateOrUpdate(Id.ResourceGroupName, azureFirewallName, parameters, cancellationToken);
                return new AzureFirewallCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, azureFirewallName, parameters).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates the specified Azure Firewall. </summary>
        /// <param name="azureFirewallName"> The name of the Azure Firewall. </param>
        /// <param name="parameters"> Parameters supplied to the create or update Azure Firewall operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="azureFirewallName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<AzureFirewallCreateOrUpdateOperation> StartCreateOrUpdateAsync(string azureFirewallName, AzureFirewallData parameters, CancellationToken cancellationToken = default)
        {
            if (azureFirewallName == null)
            {
                throw new ArgumentNullException(nameof(azureFirewallName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("AzureFirewallContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _restClient.CreateOrUpdateAsync(Id.ResourceGroupName, azureFirewallName, parameters, cancellationToken).ConfigureAwait(false);
                return new AzureFirewallCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, azureFirewallName, parameters).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="azureFirewallName"> The name of the Azure Firewall. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<AzureFirewall> Get(string azureFirewallName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AzureFirewallContainer.Get");
            scope.Start();
            try
            {
                if (azureFirewallName == null)
                {
                    throw new ArgumentNullException(nameof(azureFirewallName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, azureFirewallName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AzureFirewall(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="azureFirewallName"> The name of the Azure Firewall. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<AzureFirewall>> GetAsync(string azureFirewallName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AzureFirewallContainer.Get");
            scope.Start();
            try
            {
                if (azureFirewallName == null)
                {
                    throw new ArgumentNullException(nameof(azureFirewallName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, azureFirewallName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new AzureFirewall(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="azureFirewallName"> The name of the Azure Firewall. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<AzureFirewall> GetIfExists(string azureFirewallName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AzureFirewallContainer.GetIfExists");
            scope.Start();
            try
            {
                if (azureFirewallName == null)
                {
                    throw new ArgumentNullException(nameof(azureFirewallName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, azureFirewallName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<AzureFirewall>(null, response.GetRawResponse())
                    : Response.FromValue(new AzureFirewall(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="azureFirewallName"> The name of the Azure Firewall. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<AzureFirewall>> GetIfExistsAsync(string azureFirewallName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AzureFirewallContainer.GetIfExists");
            scope.Start();
            try
            {
                if (azureFirewallName == null)
                {
                    throw new ArgumentNullException(nameof(azureFirewallName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, azureFirewallName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<AzureFirewall>(null, response.GetRawResponse())
                    : Response.FromValue(new AzureFirewall(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="azureFirewallName"> The name of the Azure Firewall. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<bool> CheckIfExists(string azureFirewallName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AzureFirewallContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (azureFirewallName == null)
                {
                    throw new ArgumentNullException(nameof(azureFirewallName));
                }

                var response = GetIfExists(azureFirewallName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="azureFirewallName"> The name of the Azure Firewall. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string azureFirewallName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AzureFirewallContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (azureFirewallName == null)
                {
                    throw new ArgumentNullException(nameof(azureFirewallName));
                }

                var response = await GetIfExistsAsync(azureFirewallName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all Azure Firewalls in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AzureFirewall" /> that may take multiple service requests to iterate over. </returns>
        public Pageable<AzureFirewall> GetAll(CancellationToken cancellationToken = default)
        {
            Page<AzureFirewall> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AzureFirewallContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetAll(Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new AzureFirewall(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<AzureFirewall> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AzureFirewallContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetAllNextPage(nextLink, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new AzureFirewall(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists all Azure Firewalls in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AzureFirewall" /> that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<AzureFirewall> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<AzureFirewall>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AzureFirewallContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetAllAsync(Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new AzureFirewall(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<AzureFirewall>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AzureFirewallContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetAllNextPageAsync(nextLink, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new AzureFirewall(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="AzureFirewall" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AzureFirewallContainer.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(AzureFirewall.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="AzureFirewall" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AzureFirewallContainer.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(AzureFirewall.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // Builders.
        // public ArmBuilder<ResourceIdentifier, AzureFirewall, AzureFirewallData> Construct() { }
    }
}
