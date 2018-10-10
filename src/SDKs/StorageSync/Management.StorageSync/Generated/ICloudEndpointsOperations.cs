// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.StorageSync
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// CloudEndpointsOperations operations.
    /// </summary>
    public partial interface ICloudEndpointsOperations
    {
        /// <summary>
        /// Create a new CloudEndpoint.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='storageSyncServiceName'>
        /// Name of Storage Sync Service resource.
        /// </param>
        /// <param name='syncGroupName'>
        /// Name of Sync Group resource.
        /// </param>
        /// <param name='cloudEndpointName'>
        /// Name of Cloud Endpoint object.
        /// </param>
        /// <param name='parameters'>
        /// Body of Cloud Endpoint resource.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="StorageSyncErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<CloudEndpoint,CloudEndpointsCreateHeaders>> CreateWithHttpMessagesAsync(string resourceGroupName, string storageSyncServiceName, string syncGroupName, string cloudEndpointName, CloudEndpointCreateParameters parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get a given CloudEndpoint.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='storageSyncServiceName'>
        /// Name of Storage Sync Service resource.
        /// </param>
        /// <param name='syncGroupName'>
        /// Name of Sync Group resource.
        /// </param>
        /// <param name='cloudEndpointName'>
        /// Name of Cloud Endpoint object.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="StorageSyncErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<CloudEndpoint,CloudEndpointsGetHeaders>> GetWithHttpMessagesAsync(string resourceGroupName, string storageSyncServiceName, string syncGroupName, string cloudEndpointName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Delete a given CloudEndpoint.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='storageSyncServiceName'>
        /// Name of Storage Sync Service resource.
        /// </param>
        /// <param name='syncGroupName'>
        /// Name of Sync Group resource.
        /// </param>
        /// <param name='cloudEndpointName'>
        /// Name of Cloud Endpoint object.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="StorageSyncErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationHeaderResponse<CloudEndpointsDeleteHeaders>> DeleteWithHttpMessagesAsync(string resourceGroupName, string storageSyncServiceName, string syncGroupName, string cloudEndpointName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get a CloudEndpoint List.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='storageSyncServiceName'>
        /// Name of Storage Sync Service resource.
        /// </param>
        /// <param name='syncGroupName'>
        /// Name of Sync Group resource.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="StorageSyncErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IEnumerable<CloudEndpoint>,CloudEndpointsListBySyncGroupHeaders>> ListBySyncGroupWithHttpMessagesAsync(string resourceGroupName, string storageSyncServiceName, string syncGroupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Pre Backup a given CloudEndpoint.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='storageSyncServiceName'>
        /// Name of Storage Sync Service resource.
        /// </param>
        /// <param name='syncGroupName'>
        /// Name of Sync Group resource.
        /// </param>
        /// <param name='cloudEndpointName'>
        /// Name of Cloud Endpoint object.
        /// </param>
        /// <param name='azureFileShare'>
        /// Azure File Share.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="StorageSyncErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationHeaderResponse<CloudEndpointsPreBackupHeaders>> PreBackupWithHttpMessagesAsync(string resourceGroupName, string storageSyncServiceName, string syncGroupName, string cloudEndpointName, string azureFileShare = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Post Backup a given CloudEndpoint.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='storageSyncServiceName'>
        /// Name of Storage Sync Service resource.
        /// </param>
        /// <param name='syncGroupName'>
        /// Name of Sync Group resource.
        /// </param>
        /// <param name='cloudEndpointName'>
        /// Name of Cloud Endpoint object.
        /// </param>
        /// <param name='azureFileShare'>
        /// Azure File Share.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="StorageSyncErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<PostBackupResponse,CloudEndpointsPostBackupHeaders>> PostBackupWithHttpMessagesAsync(string resourceGroupName, string storageSyncServiceName, string syncGroupName, string cloudEndpointName, string azureFileShare = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Pre Restore a given CloudEndpoint.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='storageSyncServiceName'>
        /// Name of Storage Sync Service resource.
        /// </param>
        /// <param name='syncGroupName'>
        /// Name of Sync Group resource.
        /// </param>
        /// <param name='cloudEndpointName'>
        /// Name of Cloud Endpoint object.
        /// </param>
        /// <param name='parameters'>
        /// Body of Cloud Endpoint object.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="StorageSyncErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationHeaderResponse<CloudEndpointsPreRestoreHeaders>> PreRestoreWithHttpMessagesAsync(string resourceGroupName, string storageSyncServiceName, string syncGroupName, string cloudEndpointName, PreRestoreRequest parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Restore Heartbeat a given CloudEndpoint.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='storageSyncServiceName'>
        /// Name of Storage Sync Service resource.
        /// </param>
        /// <param name='syncGroupName'>
        /// Name of Sync Group resource.
        /// </param>
        /// <param name='cloudEndpointName'>
        /// Name of Cloud Endpoint object.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="StorageSyncErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationHeaderResponse<CloudEndpointsRestoreheartbeatHeaders>> RestoreheartbeatWithHttpMessagesAsync(string resourceGroupName, string storageSyncServiceName, string syncGroupName, string cloudEndpointName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Post Restore a given CloudEndpoint.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='storageSyncServiceName'>
        /// Name of Storage Sync Service resource.
        /// </param>
        /// <param name='syncGroupName'>
        /// Name of Sync Group resource.
        /// </param>
        /// <param name='cloudEndpointName'>
        /// Name of Cloud Endpoint object.
        /// </param>
        /// <param name='parameters'>
        /// Body of Cloud Endpoint object.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="StorageSyncErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationHeaderResponse<CloudEndpointsPostRestoreHeaders>> PostRestoreWithHttpMessagesAsync(string resourceGroupName, string storageSyncServiceName, string syncGroupName, string cloudEndpointName, PostRestoreRequest parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Create a new CloudEndpoint.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='storageSyncServiceName'>
        /// Name of Storage Sync Service resource.
        /// </param>
        /// <param name='syncGroupName'>
        /// Name of Sync Group resource.
        /// </param>
        /// <param name='cloudEndpointName'>
        /// Name of Cloud Endpoint object.
        /// </param>
        /// <param name='parameters'>
        /// Body of Cloud Endpoint resource.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="StorageSyncErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<CloudEndpoint,CloudEndpointsCreateHeaders>> BeginCreateWithHttpMessagesAsync(string resourceGroupName, string storageSyncServiceName, string syncGroupName, string cloudEndpointName, CloudEndpointCreateParameters parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Delete a given CloudEndpoint.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='storageSyncServiceName'>
        /// Name of Storage Sync Service resource.
        /// </param>
        /// <param name='syncGroupName'>
        /// Name of Sync Group resource.
        /// </param>
        /// <param name='cloudEndpointName'>
        /// Name of Cloud Endpoint object.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="StorageSyncErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationHeaderResponse<CloudEndpointsDeleteHeaders>> BeginDeleteWithHttpMessagesAsync(string resourceGroupName, string storageSyncServiceName, string syncGroupName, string cloudEndpointName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Pre Backup a given CloudEndpoint.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='storageSyncServiceName'>
        /// Name of Storage Sync Service resource.
        /// </param>
        /// <param name='syncGroupName'>
        /// Name of Sync Group resource.
        /// </param>
        /// <param name='cloudEndpointName'>
        /// Name of Cloud Endpoint object.
        /// </param>
        /// <param name='azureFileShare'>
        /// Azure File Share.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="StorageSyncErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationHeaderResponse<CloudEndpointsPreBackupHeaders>> BeginPreBackupWithHttpMessagesAsync(string resourceGroupName, string storageSyncServiceName, string syncGroupName, string cloudEndpointName, string azureFileShare = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Post Backup a given CloudEndpoint.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='storageSyncServiceName'>
        /// Name of Storage Sync Service resource.
        /// </param>
        /// <param name='syncGroupName'>
        /// Name of Sync Group resource.
        /// </param>
        /// <param name='cloudEndpointName'>
        /// Name of Cloud Endpoint object.
        /// </param>
        /// <param name='azureFileShare'>
        /// Azure File Share.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="StorageSyncErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<PostBackupResponse,CloudEndpointsPostBackupHeaders>> BeginPostBackupWithHttpMessagesAsync(string resourceGroupName, string storageSyncServiceName, string syncGroupName, string cloudEndpointName, string azureFileShare = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Pre Restore a given CloudEndpoint.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='storageSyncServiceName'>
        /// Name of Storage Sync Service resource.
        /// </param>
        /// <param name='syncGroupName'>
        /// Name of Sync Group resource.
        /// </param>
        /// <param name='cloudEndpointName'>
        /// Name of Cloud Endpoint object.
        /// </param>
        /// <param name='parameters'>
        /// Body of Cloud Endpoint object.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="StorageSyncErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationHeaderResponse<CloudEndpointsPreRestoreHeaders>> BeginPreRestoreWithHttpMessagesAsync(string resourceGroupName, string storageSyncServiceName, string syncGroupName, string cloudEndpointName, PreRestoreRequest parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Post Restore a given CloudEndpoint.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='storageSyncServiceName'>
        /// Name of Storage Sync Service resource.
        /// </param>
        /// <param name='syncGroupName'>
        /// Name of Sync Group resource.
        /// </param>
        /// <param name='cloudEndpointName'>
        /// Name of Cloud Endpoint object.
        /// </param>
        /// <param name='parameters'>
        /// Body of Cloud Endpoint object.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="StorageSyncErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationHeaderResponse<CloudEndpointsPostRestoreHeaders>> BeginPostRestoreWithHttpMessagesAsync(string resourceGroupName, string storageSyncServiceName, string syncGroupName, string cloudEndpointName, PostRestoreRequest parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}