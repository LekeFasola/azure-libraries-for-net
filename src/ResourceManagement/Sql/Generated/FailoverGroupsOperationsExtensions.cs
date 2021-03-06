// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql.Fluent
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for FailoverGroupsOperations.
    /// </summary>
    public static partial class FailoverGroupsOperationsExtensions
    {
            /// <summary>
            /// Gets a failover group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server containing the failover group.
            /// </param>
            /// <param name='failoverGroupName'>
            /// The name of the failover group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<FailoverGroupInner> GetAsync(this IFailoverGroupsOperations operations, string resourceGroupName, string serverName, string failoverGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, serverName, failoverGroupName, SqlManagementClient.SetJsonAcceptHeader(), cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates a failover group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server containing the failover group.
            /// </param>
            /// <param name='failoverGroupName'>
            /// The name of the failover group.
            /// </param>
            /// <param name='parameters'>
            /// The failover group parameters.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<FailoverGroupInner> CreateOrUpdateAsync(this IFailoverGroupsOperations operations, string resourceGroupName, string serverName, string failoverGroupName, FailoverGroupInner parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, serverName, failoverGroupName, parameters, SqlManagementClient.SetJsonAcceptHeader(), cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a failover group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server containing the failover group.
            /// </param>
            /// <param name='failoverGroupName'>
            /// The name of the failover group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IFailoverGroupsOperations operations, string resourceGroupName, string serverName, string failoverGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, serverName, failoverGroupName, SqlManagementClient.SetJsonAcceptHeader(), cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Updates a failover group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server containing the failover group.
            /// </param>
            /// <param name='failoverGroupName'>
            /// The name of the failover group.
            /// </param>
            /// <param name='parameters'>
            /// The failover group parameters.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<FailoverGroupInner> UpdateAsync(this IFailoverGroupsOperations operations, string resourceGroupName, string serverName, string failoverGroupName, FailoverGroupUpdateInner parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, serverName, failoverGroupName, parameters, SqlManagementClient.SetJsonAcceptHeader(), cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the failover groups in a server.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server containing the failover group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<FailoverGroupInner>> ListByServerAsync(this IFailoverGroupsOperations operations, string resourceGroupName, string serverName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByServerWithHttpMessagesAsync(resourceGroupName, serverName, SqlManagementClient.SetJsonAcceptHeader(), cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Fails over from the current primary server to this server.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server containing the failover group.
            /// </param>
            /// <param name='failoverGroupName'>
            /// The name of the failover group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<FailoverGroupInner> FailoverAsync(this IFailoverGroupsOperations operations, string resourceGroupName, string serverName, string failoverGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.FailoverWithHttpMessagesAsync(resourceGroupName, serverName, failoverGroupName, SqlManagementClient.SetJsonAcceptHeader(), cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Fails over from the current primary server to this server. This operation
            /// might result in data loss.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server containing the failover group.
            /// </param>
            /// <param name='failoverGroupName'>
            /// The name of the failover group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<FailoverGroupInner> ForceFailoverAllowDataLossAsync(this IFailoverGroupsOperations operations, string resourceGroupName, string serverName, string failoverGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ForceFailoverAllowDataLossWithHttpMessagesAsync(resourceGroupName, serverName, failoverGroupName, SqlManagementClient.SetJsonAcceptHeader(), cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates a failover group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server containing the failover group.
            /// </param>
            /// <param name='failoverGroupName'>
            /// The name of the failover group.
            /// </param>
            /// <param name='parameters'>
            /// The failover group parameters.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<FailoverGroupInner> BeginCreateOrUpdateAsync(this IFailoverGroupsOperations operations, string resourceGroupName, string serverName, string failoverGroupName, FailoverGroupInner parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, serverName, failoverGroupName, parameters, SqlManagementClient.SetJsonAcceptHeader(), cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a failover group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server containing the failover group.
            /// </param>
            /// <param name='failoverGroupName'>
            /// The name of the failover group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IFailoverGroupsOperations operations, string resourceGroupName, string serverName, string failoverGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, serverName, failoverGroupName, SqlManagementClient.SetJsonAcceptHeader(), cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Updates a failover group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server containing the failover group.
            /// </param>
            /// <param name='failoverGroupName'>
            /// The name of the failover group.
            /// </param>
            /// <param name='parameters'>
            /// The failover group parameters.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<FailoverGroupInner> BeginUpdateAsync(this IFailoverGroupsOperations operations, string resourceGroupName, string serverName, string failoverGroupName, FailoverGroupUpdateInner parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginUpdateWithHttpMessagesAsync(resourceGroupName, serverName, failoverGroupName, parameters, SqlManagementClient.SetJsonAcceptHeader(), cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Fails over from the current primary server to this server.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server containing the failover group.
            /// </param>
            /// <param name='failoverGroupName'>
            /// The name of the failover group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<FailoverGroupInner> BeginFailoverAsync(this IFailoverGroupsOperations operations, string resourceGroupName, string serverName, string failoverGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginFailoverWithHttpMessagesAsync(resourceGroupName, serverName, failoverGroupName, SqlManagementClient.SetJsonAcceptHeader(), cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Fails over from the current primary server to this server. This operation
            /// might result in data loss.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server containing the failover group.
            /// </param>
            /// <param name='failoverGroupName'>
            /// The name of the failover group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<FailoverGroupInner> BeginForceFailoverAllowDataLossAsync(this IFailoverGroupsOperations operations, string resourceGroupName, string serverName, string failoverGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginForceFailoverAllowDataLossWithHttpMessagesAsync(resourceGroupName, serverName, failoverGroupName, SqlManagementClient.SetJsonAcceptHeader(), cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the failover groups in a server.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<FailoverGroupInner>> ListByServerNextAsync(this IFailoverGroupsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByServerNextWithHttpMessagesAsync(nextPageLink, SqlManagementClient.SetJsonAcceptHeader(), cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
