// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Hyak.Common;
using Microsoft.Azure;
using Microsoft.Azure.Management.RecoveryServices.Backup;
using Microsoft.Azure.Management.RecoveryServices.Backup.Models;
using Newtonsoft.Json.Linq;

namespace Microsoft.Azure.Management.RecoveryServices.Backup
{
    /// <summary>
    /// The Resource Manager API includes operations for triggering and
    /// managing actions of the file / folder recovery of items protected by
    /// your Recovery Services Vault.
    /// </summary>
    internal partial class FileFolderRestoreOperations : IServiceOperations<RecoveryServicesBackupManagementClient>, IFileFolderRestoreOperations
    {
        /// <summary>
        /// Initializes a new instance of the FileFolderRestoreOperations class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        internal FileFolderRestoreOperations(RecoveryServicesBackupManagementClient client)
        {
            this._client = client;
        }
        
        private RecoveryServicesBackupManagementClient _client;
        
        /// <summary>
        /// Gets a reference to the
        /// Microsoft.Azure.Management.RecoveryServices.Backup.RecoveryServicesBackupManagementClient.
        /// </summary>
        public RecoveryServicesBackupManagementClient Client
        {
            get { return this._client; }
        }
        
        /// <summary>
        /// Provisions an iSCSI connection which can be used to download a
        /// script which when run opens the file explorer displaying all
        /// recoverable files and folders. This is an asynchronous operation.
        /// To determine whether the backend service has finished processing
        /// the request, call Get Protected Item Operation Result API.
        /// </summary>
        /// <param name='parameters'>
        /// Required. Common parameters to be used with the file folder restore
        /// APIs.
        /// </param>
        /// <param name='request'>
        /// Optional. File / folder restore request for the backup item.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Base recovery job response for all the asynchronous operations.
        /// </returns>
        public async Task<BaseRecoveryServicesJobResponse> ProvisionAsync(FileFolderRestoreParameters parameters, ProvisionILRRequest request, CancellationToken cancellationToken)
        {
            // Validate
            if (parameters == null)
            {
                throw new ArgumentNullException("parameters");
            }
            if (parameters.ResourceGroupName == null)
            {
                throw new ArgumentNullException("parameters.ResourceGroupName");
            }
            if (parameters.ResourceName == null)
            {
                throw new ArgumentNullException("parameters.ResourceName");
            }
            if (request != null)
            {
                if (request.Item != null)
                {
                    if (request.Item.Properties == null)
                    {
                        throw new ArgumentNullException("request.Item.Properties");
                    }
                }
            }
            
            // Tracing
            bool shouldTrace = TracingAdapter.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = TracingAdapter.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("parameters", parameters);
                tracingParameters.Add("request", request);
                TracingAdapter.Enter(invocationId, this, "ProvisionAsync", tracingParameters);
            }
            
            // Construct URL
            string url = "";
            url = url + "/subscriptions/";
            if (this.Client.Credentials.SubscriptionId != null)
            {
                url = url + Uri.EscapeDataString(this.Client.Credentials.SubscriptionId);
            }
            url = url + "/resourceGroups/";
            url = url + Uri.EscapeDataString(parameters.ResourceGroupName);
            url = url + "/providers/";
            if (this.Client.ResourceNamespace != null)
            {
                url = url + Uri.EscapeDataString(this.Client.ResourceNamespace);
            }
            url = url + "/";
            url = url + "vaults";
            url = url + "/";
            url = url + Uri.EscapeDataString(parameters.ResourceName);
            url = url + "/backupFabrics/";
            if (parameters.FabricName != null)
            {
                url = url + Uri.EscapeDataString(parameters.FabricName);
            }
            url = url + "/protectionContainers/";
            if (parameters.ContainerName != null)
            {
                url = url + Uri.EscapeDataString(parameters.ContainerName);
            }
            url = url + "/protectedItems/";
            if (parameters.ProtectedItemName != null)
            {
                url = url + Uri.EscapeDataString(parameters.ProtectedItemName);
            }
            url = url + "/recoveryPoints/";
            if (parameters.RecoveryPointId != null)
            {
                url = url + Uri.EscapeDataString(parameters.RecoveryPointId);
            }
            url = url + "/provisionInstantItemRecovery";
            List<string> queryParameters = new List<string>();
            queryParameters.Add("api-version=2016-06-01");
            if (queryParameters.Count > 0)
            {
                url = url + "?" + string.Join("&", queryParameters);
            }
            string baseUrl = this.Client.BaseUri.AbsoluteUri;
            // Trim '/' character from the end of baseUrl and beginning of url.
            if (baseUrl[baseUrl.Length - 1] == '/')
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            if (url[0] == '/')
            {
                url = url.Substring(1);
            }
            url = baseUrl + "/" + url;
            url = url.Replace(" ", "%20");
            
            // Create HTTP transport objects
            HttpRequestMessage httpRequest = null;
            try
            {
                httpRequest = new HttpRequestMessage();
                httpRequest.Method = HttpMethod.Post;
                httpRequest.RequestUri = new Uri(url);
                
                // Set Headers
                httpRequest.Headers.Add("Accept-Language", parameters.CustomRequestHeaders.Culture);
                httpRequest.Headers.Add("x-ms-client-request-id", parameters.CustomRequestHeaders.ClientRequestId);
                
                // Set Credentials
                cancellationToken.ThrowIfCancellationRequested();
                await this.Client.Credentials.ProcessHttpRequestAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                
                // Serialize Request
                string requestContent = null;
                JToken requestDoc = null;
                
                if (request != null)
                {
                    if (request.Item != null)
                    {
                        JObject itemValue = new JObject();
                        requestDoc = itemValue;
                        
                        JObject propertiesValue = new JObject();
                        itemValue["properties"] = propertiesValue;
                        if (request.Item.Properties is IaasVMILRRegistrationRequest)
                        {
                            propertiesValue["objectType"] = "IaasVMILRRegistrationRequest";
                            IaasVMILRRegistrationRequest derived = ((IaasVMILRRegistrationRequest)request.Item.Properties);
                            
                            if (derived.RecoveryPointId != null)
                            {
                                propertiesValue["recoveryPointId"] = derived.RecoveryPointId;
                            }
                            
                            if (derived.VirtualMachineId != null)
                            {
                                propertiesValue["virtualMachineId"] = derived.VirtualMachineId;
                            }
                            
                            if (derived.InitiatorName != null)
                            {
                                propertiesValue["initiatorName"] = derived.InitiatorName;
                            }
                            
                            propertiesValue["renewExistingRegistration"] = derived.RenewExistingRegistration;
                        }
                    }
                }
                
                requestContent = requestDoc.ToString(Newtonsoft.Json.Formatting.Indented);
                httpRequest.Content = new StringContent(requestContent, Encoding.UTF8);
                httpRequest.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                
                // Send Request
                HttpResponseMessage httpResponse = null;
                try
                {
                    if (shouldTrace)
                    {
                        TracingAdapter.SendRequest(invocationId, httpRequest);
                    }
                    cancellationToken.ThrowIfCancellationRequested();
                    httpResponse = await this.Client.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                    if (shouldTrace)
                    {
                        TracingAdapter.ReceiveResponse(invocationId, httpResponse);
                    }
                    HttpStatusCode statusCode = httpResponse.StatusCode;
                    if (statusCode != HttpStatusCode.Accepted)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        CloudException ex = CloudException.Create(httpRequest, requestContent, httpResponse, await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false));
                        if (shouldTrace)
                        {
                            TracingAdapter.Error(invocationId, ex);
                        }
                        throw ex;
                    }
                    
                    // Create Result
                    BaseRecoveryServicesJobResponse result = null;
                    // Deserialize Response
                    if (statusCode == HttpStatusCode.Accepted)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        string responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                        result = new BaseRecoveryServicesJobResponse();
                        JToken responseDoc = null;
                        if (string.IsNullOrEmpty(responseContent) == false)
                        {
                            responseDoc = JToken.Parse(responseContent);
                        }
                        
                        if (responseDoc != null && responseDoc.Type != JTokenType.Null)
                        {
                            JToken locationValue = responseDoc["location"];
                            if (locationValue != null && locationValue.Type != JTokenType.Null)
                            {
                                string locationInstance = ((string)locationValue);
                                result.Location = locationInstance;
                            }
                            
                            JToken azureAsyncOperationValue = responseDoc["azureAsyncOperation"];
                            if (azureAsyncOperationValue != null && azureAsyncOperationValue.Type != JTokenType.Null)
                            {
                                string azureAsyncOperationInstance = ((string)azureAsyncOperationValue);
                                result.AzureAsyncOperation = azureAsyncOperationInstance;
                            }
                            
                            JToken retryAfterValue = responseDoc["retryAfter"];
                            if (retryAfterValue != null && retryAfterValue.Type != JTokenType.Null)
                            {
                                string retryAfterInstance = ((string)retryAfterValue);
                                result.RetryAfter = retryAfterInstance;
                            }
                            
                            JToken statusValue = responseDoc["Status"];
                            if (statusValue != null && statusValue.Type != JTokenType.Null)
                            {
                                OperationStatus statusInstance = ((OperationStatus)Enum.Parse(typeof(OperationStatus), ((string)statusValue), true));
                                result.Status = statusInstance;
                            }
                        }
                        
                    }
                    result.StatusCode = statusCode;
                    if (httpResponse.Headers.Contains("Azure-AsyncOperation"))
                    {
                        result.AzureAsyncOperation = httpResponse.Headers.GetValues("Azure-AsyncOperation").FirstOrDefault();
                    }
                    if (httpResponse.Headers.Contains("Location"))
                    {
                        result.Location = httpResponse.Headers.GetValues("Location").FirstOrDefault();
                    }
                    if (httpResponse.Headers.Contains("Retry-After"))
                    {
                        result.RetryAfter = httpResponse.Headers.GetValues("Retry-After").FirstOrDefault();
                    }
                    
                    if (shouldTrace)
                    {
                        TracingAdapter.Exit(invocationId, result);
                    }
                    return result;
                }
                finally
                {
                    if (httpResponse != null)
                    {
                        httpResponse.Dispose();
                    }
                }
            }
            finally
            {
                if (httpRequest != null)
                {
                    httpRequest.Dispose();
                }
            }
        }
        
        /// <summary>
        /// Revokes an iSCSI connection which can be used to download a script
        /// which when run opens the file explorer displaying all recoverable
        /// files and folders. This is an asynchronous operation. To determine
        /// whether the backend service has finished processing the request,
        /// call --- API.
        /// </summary>
        /// <param name='parameters'>
        /// Required. Common parameters to be used with the file folder restore
        /// APIs.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Base recovery job response for all the asynchronous operations.
        /// </returns>
        public async Task<BaseRecoveryServicesJobResponse> RevokeAsync(FileFolderRestoreParameters parameters, CancellationToken cancellationToken)
        {
            // Validate
            if (parameters == null)
            {
                throw new ArgumentNullException("parameters");
            }
            if (parameters.ResourceGroupName == null)
            {
                throw new ArgumentNullException("parameters.ResourceGroupName");
            }
            if (parameters.ResourceName == null)
            {
                throw new ArgumentNullException("parameters.ResourceName");
            }
            
            // Tracing
            bool shouldTrace = TracingAdapter.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = TracingAdapter.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("parameters", parameters);
                TracingAdapter.Enter(invocationId, this, "RevokeAsync", tracingParameters);
            }
            
            // Construct URL
            string url = "";
            url = url + "/subscriptions/";
            if (this.Client.Credentials.SubscriptionId != null)
            {
                url = url + Uri.EscapeDataString(this.Client.Credentials.SubscriptionId);
            }
            url = url + "/resourceGroups/";
            url = url + Uri.EscapeDataString(parameters.ResourceGroupName);
            url = url + "/providers/";
            if (this.Client.ResourceNamespace != null)
            {
                url = url + Uri.EscapeDataString(this.Client.ResourceNamespace);
            }
            url = url + "/";
            url = url + "vaults";
            url = url + "/";
            url = url + Uri.EscapeDataString(parameters.ResourceName);
            url = url + "/backupFabrics/";
            if (parameters.FabricName != null)
            {
                url = url + Uri.EscapeDataString(parameters.FabricName);
            }
            url = url + "/protectionContainers/";
            if (parameters.ContainerName != null)
            {
                url = url + Uri.EscapeDataString(parameters.ContainerName);
            }
            url = url + "/protectedItems/";
            if (parameters.ProtectedItemName != null)
            {
                url = url + Uri.EscapeDataString(parameters.ProtectedItemName);
            }
            url = url + "/recoveryPoints/";
            if (parameters.RecoveryPointId != null)
            {
                url = url + Uri.EscapeDataString(parameters.RecoveryPointId);
            }
            url = url + "/revokeInstantItemRecovery";
            List<string> queryParameters = new List<string>();
            queryParameters.Add("api-version=2016-06-01");
            if (queryParameters.Count > 0)
            {
                url = url + "?" + string.Join("&", queryParameters);
            }
            string baseUrl = this.Client.BaseUri.AbsoluteUri;
            // Trim '/' character from the end of baseUrl and beginning of url.
            if (baseUrl[baseUrl.Length - 1] == '/')
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            if (url[0] == '/')
            {
                url = url.Substring(1);
            }
            url = baseUrl + "/" + url;
            url = url.Replace(" ", "%20");
            
            // Create HTTP transport objects
            HttpRequestMessage httpRequest = null;
            try
            {
                httpRequest = new HttpRequestMessage();
                httpRequest.Method = HttpMethod.Post;
                httpRequest.RequestUri = new Uri(url);
                
                // Set Headers
                httpRequest.Headers.Add("Accept-Language", parameters.CustomRequestHeaders.Culture);
                httpRequest.Headers.Add("x-ms-client-request-id", parameters.CustomRequestHeaders.ClientRequestId);
                
                // Set Credentials
                cancellationToken.ThrowIfCancellationRequested();
                await this.Client.Credentials.ProcessHttpRequestAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                
                // Send Request
                HttpResponseMessage httpResponse = null;
                try
                {
                    if (shouldTrace)
                    {
                        TracingAdapter.SendRequest(invocationId, httpRequest);
                    }
                    cancellationToken.ThrowIfCancellationRequested();
                    httpResponse = await this.Client.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                    if (shouldTrace)
                    {
                        TracingAdapter.ReceiveResponse(invocationId, httpResponse);
                    }
                    HttpStatusCode statusCode = httpResponse.StatusCode;
                    if (statusCode != HttpStatusCode.Accepted)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        CloudException ex = CloudException.Create(httpRequest, null, httpResponse, await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false));
                        if (shouldTrace)
                        {
                            TracingAdapter.Error(invocationId, ex);
                        }
                        throw ex;
                    }
                    
                    // Create Result
                    BaseRecoveryServicesJobResponse result = null;
                    // Deserialize Response
                    result = new BaseRecoveryServicesJobResponse();
                    result.StatusCode = statusCode;
                    if (httpResponse.Headers.Contains("Azure-AsyncOperation"))
                    {
                        result.AzureAsyncOperation = httpResponse.Headers.GetValues("Azure-AsyncOperation").FirstOrDefault();
                    }
                    if (httpResponse.Headers.Contains("Location"))
                    {
                        result.Location = httpResponse.Headers.GetValues("Location").FirstOrDefault();
                    }
                    if (httpResponse.Headers.Contains("Retry-After"))
                    {
                        result.RetryAfter = httpResponse.Headers.GetValues("Retry-After").FirstOrDefault();
                    }
                    
                    if (shouldTrace)
                    {
                        TracingAdapter.Exit(invocationId, result);
                    }
                    return result;
                }
                finally
                {
                    if (httpResponse != null)
                    {
                        httpResponse.Dispose();
                    }
                }
            }
            finally
            {
                if (httpRequest != null)
                {
                    httpRequest.Dispose();
                }
            }
        }
    }
}
