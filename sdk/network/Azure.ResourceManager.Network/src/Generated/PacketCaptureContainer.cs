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
    /// <summary> A class representing collection of PacketCapture and their operations over a NetworkWatcher. </summary>
    public partial class PacketCaptureContainer : ArmContainer
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly PacketCapturesRestOperations _restClient;

        /// <summary> Initializes a new instance of the <see cref="PacketCaptureContainer"/> class for mocking. </summary>
        protected PacketCaptureContainer()
        {
        }

        /// <summary> Initializes a new instance of PacketCaptureContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal PacketCaptureContainer(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _restClient = new PacketCapturesRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => NetworkWatcher.ResourceType;

        // Container level operations.

        /// <summary> Create and start a packet capture on the specified VM. </summary>
        /// <param name="packetCaptureName"> The name of the packet capture session. </param>
        /// <param name="parameters"> Parameters that define the create packet capture operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="packetCaptureName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual Response<PacketCapture> CreateOrUpdate(string packetCaptureName, PacketCaptureInput parameters, CancellationToken cancellationToken = default)
        {
            if (packetCaptureName == null)
            {
                throw new ArgumentNullException(nameof(packetCaptureName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("PacketCaptureContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = StartCreateOrUpdate(packetCaptureName, parameters, cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create and start a packet capture on the specified VM. </summary>
        /// <param name="packetCaptureName"> The name of the packet capture session. </param>
        /// <param name="parameters"> Parameters that define the create packet capture operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="packetCaptureName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<Response<PacketCapture>> CreateOrUpdateAsync(string packetCaptureName, PacketCaptureInput parameters, CancellationToken cancellationToken = default)
        {
            if (packetCaptureName == null)
            {
                throw new ArgumentNullException(nameof(packetCaptureName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("PacketCaptureContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = await StartCreateOrUpdateAsync(packetCaptureName, parameters, cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create and start a packet capture on the specified VM. </summary>
        /// <param name="packetCaptureName"> The name of the packet capture session. </param>
        /// <param name="parameters"> Parameters that define the create packet capture operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="packetCaptureName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual PacketCaptureCreateOperation StartCreateOrUpdate(string packetCaptureName, PacketCaptureInput parameters, CancellationToken cancellationToken = default)
        {
            if (packetCaptureName == null)
            {
                throw new ArgumentNullException(nameof(packetCaptureName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("PacketCaptureContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = _restClient.Create(Id.ResourceGroupName, Id.Name, packetCaptureName, parameters, cancellationToken);
                return new PacketCaptureCreateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateRequest(Id.ResourceGroupName, Id.Name, packetCaptureName, parameters).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create and start a packet capture on the specified VM. </summary>
        /// <param name="packetCaptureName"> The name of the packet capture session. </param>
        /// <param name="parameters"> Parameters that define the create packet capture operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="packetCaptureName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<PacketCaptureCreateOperation> StartCreateOrUpdateAsync(string packetCaptureName, PacketCaptureInput parameters, CancellationToken cancellationToken = default)
        {
            if (packetCaptureName == null)
            {
                throw new ArgumentNullException(nameof(packetCaptureName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("PacketCaptureContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _restClient.CreateAsync(Id.ResourceGroupName, Id.Name, packetCaptureName, parameters, cancellationToken).ConfigureAwait(false);
                return new PacketCaptureCreateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateRequest(Id.ResourceGroupName, Id.Name, packetCaptureName, parameters).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="packetCaptureName"> The name of the packet capture session. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<PacketCapture> Get(string packetCaptureName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PacketCaptureContainer.Get");
            scope.Start();
            try
            {
                if (packetCaptureName == null)
                {
                    throw new ArgumentNullException(nameof(packetCaptureName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, Id.Name, packetCaptureName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PacketCapture(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="packetCaptureName"> The name of the packet capture session. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<PacketCapture>> GetAsync(string packetCaptureName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PacketCaptureContainer.Get");
            scope.Start();
            try
            {
                if (packetCaptureName == null)
                {
                    throw new ArgumentNullException(nameof(packetCaptureName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, Id.Name, packetCaptureName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new PacketCapture(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="packetCaptureName"> The name of the packet capture session. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<PacketCapture> GetIfExists(string packetCaptureName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PacketCaptureContainer.GetIfExists");
            scope.Start();
            try
            {
                if (packetCaptureName == null)
                {
                    throw new ArgumentNullException(nameof(packetCaptureName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, Id.Name, packetCaptureName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<PacketCapture>(null, response.GetRawResponse())
                    : Response.FromValue(new PacketCapture(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="packetCaptureName"> The name of the packet capture session. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<PacketCapture>> GetIfExistsAsync(string packetCaptureName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PacketCaptureContainer.GetIfExists");
            scope.Start();
            try
            {
                if (packetCaptureName == null)
                {
                    throw new ArgumentNullException(nameof(packetCaptureName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, Id.Name, packetCaptureName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<PacketCapture>(null, response.GetRawResponse())
                    : Response.FromValue(new PacketCapture(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="packetCaptureName"> The name of the packet capture session. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<bool> CheckIfExists(string packetCaptureName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PacketCaptureContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (packetCaptureName == null)
                {
                    throw new ArgumentNullException(nameof(packetCaptureName));
                }

                var response = GetIfExists(packetCaptureName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="packetCaptureName"> The name of the packet capture session. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string packetCaptureName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PacketCaptureContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (packetCaptureName == null)
                {
                    throw new ArgumentNullException(nameof(packetCaptureName));
                }

                var response = await GetIfExistsAsync(packetCaptureName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all packet capture sessions within the specified resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PacketCapture" /> that may take multiple service requests to iterate over. </returns>
        public Pageable<PacketCapture> GetAll(CancellationToken cancellationToken = default)
        {
            Page<PacketCapture> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PacketCaptureContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetAll(Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new PacketCapture(Parent, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary> Lists all packet capture sessions within the specified resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PacketCapture" /> that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<PacketCapture> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<PacketCapture>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PacketCaptureContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetAllAsync(Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new PacketCapture(Parent, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary> Filters the list of <see cref="PacketCapture" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PacketCaptureContainer.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(PacketCapture.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="PacketCapture" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PacketCaptureContainer.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(PacketCapture.ResourceType);
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
        // public ArmBuilder<ResourceIdentifier, PacketCapture, PacketCaptureData> Construct() { }
    }
}
