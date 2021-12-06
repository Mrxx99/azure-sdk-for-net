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
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing collection of RemotePrivateEndpointConnectionARMResource and their operations over its parent. </summary>
    public partial class HostingEnvironmentPrivateEndpointConnectionCollection : ArmCollection, IEnumerable<HostingEnvironmentPrivateEndpointConnection>, IAsyncEnumerable<HostingEnvironmentPrivateEndpointConnection>

    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly AppServiceEnvironmentsRestOperations _appServiceEnvironmentsRestClient;

        /// <summary> Initializes a new instance of the <see cref="HostingEnvironmentPrivateEndpointConnectionCollection"/> class for mocking. </summary>
        protected HostingEnvironmentPrivateEndpointConnectionCollection()
        {
        }

        /// <summary> Initializes a new instance of HostingEnvironmentPrivateEndpointConnectionCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal HostingEnvironmentPrivateEndpointConnectionCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _appServiceEnvironmentsRestClient = new AppServiceEnvironmentsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => AppServiceEnvironment.ResourceType;

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/privateEndpointConnections/{privateEndpointConnectionName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}
        /// OperationId: AppServiceEnvironments_ApproveOrRejectPrivateEndpointConnection
        /// <summary> Description for Approves or rejects a private endpoint connection. </summary>
        /// <param name="privateEndpointConnectionName"> The String to use. </param>
        /// <param name="privateEndpointWrapper"> The PrivateLinkConnectionApprovalRequestResource to use. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionName"/> or <paramref name="privateEndpointWrapper"/> is null. </exception>
        public virtual AppServiceEnvironmentApproveOrRejectPrivateEndpointConnectionOperation CreateOrUpdate(string privateEndpointConnectionName, PrivateLinkConnectionApprovalRequestResource privateEndpointWrapper, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (privateEndpointConnectionName == null)
            {
                throw new ArgumentNullException(nameof(privateEndpointConnectionName));
            }
            if (privateEndpointWrapper == null)
            {
                throw new ArgumentNullException(nameof(privateEndpointWrapper));
            }

            using var scope = _clientDiagnostics.CreateScope("HostingEnvironmentPrivateEndpointConnectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _appServiceEnvironmentsRestClient.ApproveOrRejectPrivateEndpointConnection(Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, privateEndpointWrapper, cancellationToken);
                var operation = new AppServiceEnvironmentApproveOrRejectPrivateEndpointConnectionOperation(Parent, _clientDiagnostics, Pipeline, _appServiceEnvironmentsRestClient.CreateApproveOrRejectPrivateEndpointConnectionRequest(Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, privateEndpointWrapper).Request, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/privateEndpointConnections/{privateEndpointConnectionName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}
        /// OperationId: AppServiceEnvironments_ApproveOrRejectPrivateEndpointConnection
        /// <summary> Description for Approves or rejects a private endpoint connection. </summary>
        /// <param name="privateEndpointConnectionName"> The String to use. </param>
        /// <param name="privateEndpointWrapper"> The PrivateLinkConnectionApprovalRequestResource to use. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionName"/> or <paramref name="privateEndpointWrapper"/> is null. </exception>
        public async virtual Task<AppServiceEnvironmentApproveOrRejectPrivateEndpointConnectionOperation> CreateOrUpdateAsync(string privateEndpointConnectionName, PrivateLinkConnectionApprovalRequestResource privateEndpointWrapper, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (privateEndpointConnectionName == null)
            {
                throw new ArgumentNullException(nameof(privateEndpointConnectionName));
            }
            if (privateEndpointWrapper == null)
            {
                throw new ArgumentNullException(nameof(privateEndpointWrapper));
            }

            using var scope = _clientDiagnostics.CreateScope("HostingEnvironmentPrivateEndpointConnectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _appServiceEnvironmentsRestClient.ApproveOrRejectPrivateEndpointConnectionAsync(Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, privateEndpointWrapper, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceEnvironmentApproveOrRejectPrivateEndpointConnectionOperation(Parent, _clientDiagnostics, Pipeline, _appServiceEnvironmentsRestClient.CreateApproveOrRejectPrivateEndpointConnectionRequest(Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, privateEndpointWrapper).Request, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/privateEndpointConnections/{privateEndpointConnectionName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}
        /// OperationId: AppServiceEnvironments_GetPrivateEndpointConnection
        /// <summary> Description for Gets a private endpoint connection. </summary>
        /// <param name="privateEndpointConnectionName"> Name of the private endpoint connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionName"/> is null. </exception>
        public virtual Response<HostingEnvironmentPrivateEndpointConnection> Get(string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            if (privateEndpointConnectionName == null)
            {
                throw new ArgumentNullException(nameof(privateEndpointConnectionName));
            }

            using var scope = _clientDiagnostics.CreateScope("HostingEnvironmentPrivateEndpointConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = _appServiceEnvironmentsRestClient.GetPrivateEndpointConnection(Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HostingEnvironmentPrivateEndpointConnection(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/privateEndpointConnections/{privateEndpointConnectionName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}
        /// OperationId: AppServiceEnvironments_GetPrivateEndpointConnection
        /// <summary> Description for Gets a private endpoint connection. </summary>
        /// <param name="privateEndpointConnectionName"> Name of the private endpoint connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionName"/> is null. </exception>
        public async virtual Task<Response<HostingEnvironmentPrivateEndpointConnection>> GetAsync(string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            if (privateEndpointConnectionName == null)
            {
                throw new ArgumentNullException(nameof(privateEndpointConnectionName));
            }

            using var scope = _clientDiagnostics.CreateScope("HostingEnvironmentPrivateEndpointConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = await _appServiceEnvironmentsRestClient.GetPrivateEndpointConnectionAsync(Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new HostingEnvironmentPrivateEndpointConnection(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="privateEndpointConnectionName"> Name of the private endpoint connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionName"/> is null. </exception>
        public virtual Response<HostingEnvironmentPrivateEndpointConnection> GetIfExists(string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            if (privateEndpointConnectionName == null)
            {
                throw new ArgumentNullException(nameof(privateEndpointConnectionName));
            }

            using var scope = _clientDiagnostics.CreateScope("HostingEnvironmentPrivateEndpointConnectionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _appServiceEnvironmentsRestClient.GetPrivateEndpointConnection(Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<HostingEnvironmentPrivateEndpointConnection>(null, response.GetRawResponse())
                    : Response.FromValue(new HostingEnvironmentPrivateEndpointConnection(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="privateEndpointConnectionName"> Name of the private endpoint connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionName"/> is null. </exception>
        public async virtual Task<Response<HostingEnvironmentPrivateEndpointConnection>> GetIfExistsAsync(string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            if (privateEndpointConnectionName == null)
            {
                throw new ArgumentNullException(nameof(privateEndpointConnectionName));
            }

            using var scope = _clientDiagnostics.CreateScope("HostingEnvironmentPrivateEndpointConnectionCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _appServiceEnvironmentsRestClient.GetPrivateEndpointConnectionAsync(Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<HostingEnvironmentPrivateEndpointConnection>(null, response.GetRawResponse())
                    : Response.FromValue(new HostingEnvironmentPrivateEndpointConnection(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="privateEndpointConnectionName"> Name of the private endpoint connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionName"/> is null. </exception>
        public virtual Response<bool> CheckIfExists(string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            if (privateEndpointConnectionName == null)
            {
                throw new ArgumentNullException(nameof(privateEndpointConnectionName));
            }

            using var scope = _clientDiagnostics.CreateScope("HostingEnvironmentPrivateEndpointConnectionCollection.CheckIfExists");
            scope.Start();
            try
            {
                var response = GetIfExists(privateEndpointConnectionName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="privateEndpointConnectionName"> Name of the private endpoint connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionName"/> is null. </exception>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            if (privateEndpointConnectionName == null)
            {
                throw new ArgumentNullException(nameof(privateEndpointConnectionName));
            }

            using var scope = _clientDiagnostics.CreateScope("HostingEnvironmentPrivateEndpointConnectionCollection.CheckIfExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(privateEndpointConnectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/privateEndpointConnections
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}
        /// OperationId: AppServiceEnvironments_GetPrivateEndpointConnectionList
        /// <summary> Description for Gets the list of private endpoints associated with a hosting environment. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="HostingEnvironmentPrivateEndpointConnection" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<HostingEnvironmentPrivateEndpointConnection> GetAll(CancellationToken cancellationToken = default)
        {
            Page<HostingEnvironmentPrivateEndpointConnection> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("HostingEnvironmentPrivateEndpointConnectionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _appServiceEnvironmentsRestClient.GetPrivateEndpointConnectionList(Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new HostingEnvironmentPrivateEndpointConnection(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<HostingEnvironmentPrivateEndpointConnection> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("HostingEnvironmentPrivateEndpointConnectionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _appServiceEnvironmentsRestClient.GetPrivateEndpointConnectionListNextPage(nextLink, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new HostingEnvironmentPrivateEndpointConnection(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/privateEndpointConnections
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}
        /// OperationId: AppServiceEnvironments_GetPrivateEndpointConnectionList
        /// <summary> Description for Gets the list of private endpoints associated with a hosting environment. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="HostingEnvironmentPrivateEndpointConnection" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<HostingEnvironmentPrivateEndpointConnection> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<HostingEnvironmentPrivateEndpointConnection>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("HostingEnvironmentPrivateEndpointConnectionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _appServiceEnvironmentsRestClient.GetPrivateEndpointConnectionListAsync(Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new HostingEnvironmentPrivateEndpointConnection(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<HostingEnvironmentPrivateEndpointConnection>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("HostingEnvironmentPrivateEndpointConnectionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _appServiceEnvironmentsRestClient.GetPrivateEndpointConnectionListNextPageAsync(nextLink, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new HostingEnvironmentPrivateEndpointConnection(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<HostingEnvironmentPrivateEndpointConnection> IEnumerable<HostingEnvironmentPrivateEndpointConnection>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<HostingEnvironmentPrivateEndpointConnection> IAsyncEnumerable<HostingEnvironmentPrivateEndpointConnection>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, HostingEnvironmentPrivateEndpointConnection, RemotePrivateEndpointConnectionARMResourceData> Construct() { }
    }
}
