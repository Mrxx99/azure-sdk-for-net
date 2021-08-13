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
    /// <summary> A class representing collection of LocalNetworkGateway and their operations over a ResourceGroup. </summary>
    public partial class LocalNetworkGatewayContainer : ArmContainer
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly LocalNetworkGatewaysRestOperations _restClient;

        /// <summary> Initializes a new instance of the <see cref="LocalNetworkGatewayContainer"/> class for mocking. </summary>
        protected LocalNetworkGatewayContainer()
        {
        }

        /// <summary> Initializes a new instance of LocalNetworkGatewayContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal LocalNetworkGatewayContainer(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _restClient = new LocalNetworkGatewaysRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ResourceGroup.ResourceType;

        // Container level operations.

        /// <summary> Creates or updates a local network gateway in the specified resource group. </summary>
        /// <param name="localNetworkGatewayName"> The name of the local network gateway. </param>
        /// <param name="parameters"> Parameters supplied to the create or update local network gateway operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="localNetworkGatewayName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual Response<LocalNetworkGateway> CreateOrUpdate(string localNetworkGatewayName, LocalNetworkGatewayData parameters, CancellationToken cancellationToken = default)
        {
            if (localNetworkGatewayName == null)
            {
                throw new ArgumentNullException(nameof(localNetworkGatewayName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("LocalNetworkGatewayContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = StartCreateOrUpdate(localNetworkGatewayName, parameters, cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a local network gateway in the specified resource group. </summary>
        /// <param name="localNetworkGatewayName"> The name of the local network gateway. </param>
        /// <param name="parameters"> Parameters supplied to the create or update local network gateway operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="localNetworkGatewayName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<Response<LocalNetworkGateway>> CreateOrUpdateAsync(string localNetworkGatewayName, LocalNetworkGatewayData parameters, CancellationToken cancellationToken = default)
        {
            if (localNetworkGatewayName == null)
            {
                throw new ArgumentNullException(nameof(localNetworkGatewayName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("LocalNetworkGatewayContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = await StartCreateOrUpdateAsync(localNetworkGatewayName, parameters, cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a local network gateway in the specified resource group. </summary>
        /// <param name="localNetworkGatewayName"> The name of the local network gateway. </param>
        /// <param name="parameters"> Parameters supplied to the create or update local network gateway operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="localNetworkGatewayName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual LocalNetworkGatewayCreateOrUpdateOperation StartCreateOrUpdate(string localNetworkGatewayName, LocalNetworkGatewayData parameters, CancellationToken cancellationToken = default)
        {
            if (localNetworkGatewayName == null)
            {
                throw new ArgumentNullException(nameof(localNetworkGatewayName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("LocalNetworkGatewayContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = _restClient.CreateOrUpdate(Id.ResourceGroupName, localNetworkGatewayName, parameters, cancellationToken);
                return new LocalNetworkGatewayCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, localNetworkGatewayName, parameters).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a local network gateway in the specified resource group. </summary>
        /// <param name="localNetworkGatewayName"> The name of the local network gateway. </param>
        /// <param name="parameters"> Parameters supplied to the create or update local network gateway operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="localNetworkGatewayName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<LocalNetworkGatewayCreateOrUpdateOperation> StartCreateOrUpdateAsync(string localNetworkGatewayName, LocalNetworkGatewayData parameters, CancellationToken cancellationToken = default)
        {
            if (localNetworkGatewayName == null)
            {
                throw new ArgumentNullException(nameof(localNetworkGatewayName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("LocalNetworkGatewayContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _restClient.CreateOrUpdateAsync(Id.ResourceGroupName, localNetworkGatewayName, parameters, cancellationToken).ConfigureAwait(false);
                return new LocalNetworkGatewayCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, localNetworkGatewayName, parameters).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="localNetworkGatewayName"> The name of the local network gateway. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<LocalNetworkGateway> Get(string localNetworkGatewayName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("LocalNetworkGatewayContainer.Get");
            scope.Start();
            try
            {
                if (localNetworkGatewayName == null)
                {
                    throw new ArgumentNullException(nameof(localNetworkGatewayName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, localNetworkGatewayName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new LocalNetworkGateway(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="localNetworkGatewayName"> The name of the local network gateway. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<LocalNetworkGateway>> GetAsync(string localNetworkGatewayName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("LocalNetworkGatewayContainer.Get");
            scope.Start();
            try
            {
                if (localNetworkGatewayName == null)
                {
                    throw new ArgumentNullException(nameof(localNetworkGatewayName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, localNetworkGatewayName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new LocalNetworkGateway(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="localNetworkGatewayName"> The name of the local network gateway. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<LocalNetworkGateway> GetIfExists(string localNetworkGatewayName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("LocalNetworkGatewayContainer.GetIfExists");
            scope.Start();
            try
            {
                if (localNetworkGatewayName == null)
                {
                    throw new ArgumentNullException(nameof(localNetworkGatewayName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, localNetworkGatewayName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<LocalNetworkGateway>(null, response.GetRawResponse())
                    : Response.FromValue(new LocalNetworkGateway(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="localNetworkGatewayName"> The name of the local network gateway. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<LocalNetworkGateway>> GetIfExistsAsync(string localNetworkGatewayName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("LocalNetworkGatewayContainer.GetIfExists");
            scope.Start();
            try
            {
                if (localNetworkGatewayName == null)
                {
                    throw new ArgumentNullException(nameof(localNetworkGatewayName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, localNetworkGatewayName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<LocalNetworkGateway>(null, response.GetRawResponse())
                    : Response.FromValue(new LocalNetworkGateway(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="localNetworkGatewayName"> The name of the local network gateway. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<bool> CheckIfExists(string localNetworkGatewayName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("LocalNetworkGatewayContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (localNetworkGatewayName == null)
                {
                    throw new ArgumentNullException(nameof(localNetworkGatewayName));
                }

                var response = GetIfExists(localNetworkGatewayName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="localNetworkGatewayName"> The name of the local network gateway. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string localNetworkGatewayName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("LocalNetworkGatewayContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (localNetworkGatewayName == null)
                {
                    throw new ArgumentNullException(nameof(localNetworkGatewayName));
                }

                var response = await GetIfExistsAsync(localNetworkGatewayName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets all the local network gateways in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="LocalNetworkGateway" /> that may take multiple service requests to iterate over. </returns>
        public Pageable<LocalNetworkGateway> GetAll(CancellationToken cancellationToken = default)
        {
            Page<LocalNetworkGateway> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("LocalNetworkGatewayContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetAll(Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new LocalNetworkGateway(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<LocalNetworkGateway> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("LocalNetworkGatewayContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetAllNextPage(nextLink, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new LocalNetworkGateway(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all the local network gateways in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="LocalNetworkGateway" /> that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<LocalNetworkGateway> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<LocalNetworkGateway>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("LocalNetworkGatewayContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetAllAsync(Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new LocalNetworkGateway(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<LocalNetworkGateway>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("LocalNetworkGatewayContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetAllNextPageAsync(nextLink, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new LocalNetworkGateway(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="LocalNetworkGateway" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("LocalNetworkGatewayContainer.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(LocalNetworkGateway.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="LocalNetworkGateway" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("LocalNetworkGatewayContainer.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(LocalNetworkGateway.ResourceType);
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
        // public ArmBuilder<ResourceIdentifier, LocalNetworkGateway, LocalNetworkGatewayData> Construct() { }
    }
}
