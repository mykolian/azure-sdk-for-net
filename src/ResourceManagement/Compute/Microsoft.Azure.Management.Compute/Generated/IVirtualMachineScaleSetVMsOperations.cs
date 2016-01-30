// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.14.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure.OData;
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// VirtualMachineScaleSetVMsOperations operations.
    /// </summary>
    public partial interface IVirtualMachineScaleSetVMsOperations
    {
        /// <summary>
        /// The operation to deallocate a virtual machine scale set.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// The name of the virtual machine scale set.
        /// </param>
        /// <param name='instanceId'>
        /// The instance id of the virtual machine.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> DeallocateWithHttpMessagesAsync(string resourceGroupName, string vmScaleSetName, string instanceId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// The operation to deallocate a virtual machine scale set.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// The name of the virtual machine scale set.
        /// </param>
        /// <param name='instanceId'>
        /// The instance id of the virtual machine.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> BeginDeallocateWithHttpMessagesAsync(string resourceGroupName, string vmScaleSetName, string instanceId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// The operation to delete a virtual machine scale set.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// The name of the virtual machine scale set.
        /// </param>
        /// <param name='instanceId'>
        /// The instance id of the virtual machine.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string vmScaleSetName, string instanceId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// The operation to delete a virtual machine scale set.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// The name of the virtual machine scale set.
        /// </param>
        /// <param name='instanceId'>
        /// The instance id of the virtual machine.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> BeginDeleteWithHttpMessagesAsync(string resourceGroupName, string vmScaleSetName, string instanceId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// The operation to get a virtual machine scale set virtual machine.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// The name of the virtual machine scale set.
        /// </param>
        /// <param name='instanceId'>
        /// The instance id of the virtual machine.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<VirtualMachineScaleSetVM>> GetWithHttpMessagesAsync(string resourceGroupName, string vmScaleSetName, string instanceId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// The operation to get a virtual machine scale set virtual machine.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// The name of the virtual machine scale set.
        /// </param>
        /// <param name='instanceId'>
        /// The instance id of the virtual machine.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<VirtualMachineScaleSetVMInstanceView>> GetInstanceViewWithHttpMessagesAsync(string resourceGroupName, string vmScaleSetName, string instanceId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// The operation to list virtual machine scale sets VMs.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='virtualMachineScaleSetName'>
        /// The name of the virtual machine scale set.
        /// </param>
        /// <param name='odataQuery'>
        /// OData parameters to apply to the operation.
        /// </param>
        /// <param name='select'>
        /// The list parameters.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IEnumerable<VirtualMachineScaleSetVM>>> ListWithHttpMessagesAsync(string resourceGroupName, string virtualMachineScaleSetName, ODataQuery<VirtualMachineScaleSetVM> odataQuery = default(ODataQuery<VirtualMachineScaleSetVM>), string select = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// The operation to power off (stop) a virtual machine scale set.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// The name of the virtual machine scale set.
        /// </param>
        /// <param name='instanceId'>
        /// The instance id of the virtual machine.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> PowerOffWithHttpMessagesAsync(string resourceGroupName, string vmScaleSetName, string instanceId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// The operation to power off (stop) a virtual machine scale set.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// The name of the virtual machine scale set.
        /// </param>
        /// <param name='instanceId'>
        /// The instance id of the virtual machine.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> BeginPowerOffWithHttpMessagesAsync(string resourceGroupName, string vmScaleSetName, string instanceId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// The operation to restart a virtual machine scale set.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// The name of the virtual machine scale set.
        /// </param>
        /// <param name='instanceId'>
        /// The instance id of the virtual machine.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> RestartWithHttpMessagesAsync(string resourceGroupName, string vmScaleSetName, string instanceId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// The operation to restart a virtual machine scale set.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// The name of the virtual machine scale set.
        /// </param>
        /// <param name='instanceId'>
        /// The instance id of the virtual machine.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> BeginRestartWithHttpMessagesAsync(string resourceGroupName, string vmScaleSetName, string instanceId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// The operation to start a virtual machine scale set.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// The name of the virtual machine scale set.
        /// </param>
        /// <param name='instanceId'>
        /// The instance id of the virtual machine.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> StartWithHttpMessagesAsync(string resourceGroupName, string vmScaleSetName, string instanceId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// The operation to start a virtual machine scale set.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// The name of the virtual machine scale set.
        /// </param>
        /// <param name='instanceId'>
        /// The instance id of the virtual machine.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> BeginStartWithHttpMessagesAsync(string resourceGroupName, string vmScaleSetName, string instanceId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
