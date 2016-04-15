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
using System.Threading;
using System.Threading.Tasks;
using Hyak.Common;
using Microsoft.Azure.Management.RecoveryServices.Backup;
using Microsoft.Azure.Management.RecoveryServices.Backup.Models;
using Newtonsoft.Json.Linq;

namespace Microsoft.Azure.Management.RecoveryServices.Backup
{
    /// <summary>
    /// Definition of OperationResults operations for the Azure Backup
    /// extension.
    /// </summary>
    internal partial class BackupOperationResults : IServiceOperations<RecoveryServicesBackupManagementClient>, IBackupOperationResults
    {
        /// <summary>
        /// Initializes a new instance of the BackupOperationResults class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        internal BackupOperationResults(RecoveryServicesBackupManagementClient client)
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
        /// Get the Delete Item Operation Result by OperationId
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Required. ResourceGroupName for recoveryServices Vault.
        /// </param>
        /// <param name='resourceName'>
        /// Required. ResourceName for recoveryServices Vault.
        /// </param>
        /// <param name='operationId'>
        /// Required.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The definition of a GetOperationResultResponse.
        /// </returns>
        public async Task<GetOperationResultResponse> GetBackupOperationResultAsync(string resourceGroupName, string resourceName, string operationId, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken)
        {
            // Validate
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException("resourceGroupName");
            }
            if (resourceName == null)
            {
                throw new ArgumentNullException("resourceName");
            }
            if (operationId == null)
            {
                throw new ArgumentNullException("operationId");
            }
            
            // Tracing
            bool shouldTrace = TracingAdapter.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = TracingAdapter.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("resourceGroupName", resourceGroupName);
                tracingParameters.Add("resourceName", resourceName);
                tracingParameters.Add("operationId", operationId);
                tracingParameters.Add("customRequestHeaders", customRequestHeaders);
                TracingAdapter.Enter(invocationId, this, "GetBackupOperationResultAsync", tracingParameters);
            }
            
            // Construct URL
            string url = "";
            url = url + "/Subscriptions/";
            if (this.Client.Credentials.SubscriptionId != null)
            {
                url = url + Uri.EscapeDataString(this.Client.Credentials.SubscriptionId.ToString());
            }
            url = url + "/resourceGroups/";
            url = url + Uri.EscapeDataString(resourceGroupName);
            url = url + "/providers/";
            url = url + Uri.EscapeDataString(this.Client.ResourceNamespace);
            url = url + "/";
            url = url + "vaults";
            url = url + "/";
            url = url + Uri.EscapeDataString(resourceName);
            url = url + "/backupOperationResults/";
            url = url + Uri.EscapeDataString(operationId);
            List<string> queryParameters = new List<string>();
            queryParameters.Add("api-version=2016-05-01");
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
                httpRequest.Method = HttpMethod.Get;
                httpRequest.RequestUri = new Uri(url);
                
                // Set Headers
                httpRequest.Headers.Add("Accept-Language", customRequestHeaders.Culture);
                httpRequest.Headers.Add("x-ms-client-request-id", customRequestHeaders.ClientRequestId);
                
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
                    if (statusCode != HttpStatusCode.OK && statusCode != HttpStatusCode.Accepted && statusCode != HttpStatusCode.NoContent && statusCode != HttpStatusCode.BadRequest)
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
                    GetOperationResultResponse result = null;
                    // Deserialize Response
                    if (statusCode == HttpStatusCode.OK || statusCode == HttpStatusCode.Accepted || statusCode == HttpStatusCode.NoContent || statusCode == HttpStatusCode.BadRequest)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        string responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                        result = new GetOperationResultResponse();
                        JToken responseDoc = null;
                        if (string.IsNullOrEmpty(responseContent) == false)
                        {
                            responseDoc = JToken.Parse(responseContent);
                        }
                        
                        if (responseDoc != null && responseDoc.Type != JTokenType.Null)
                        {
                            JToken operationValue = responseDoc["operation"];
                            if (operationValue != null && operationValue.Type != JTokenType.Null)
                            {
                                string typeName = ((string)operationValue["objectType"]);
                                if (typeName == "OperationResultInfo")
                                {
                                    OperationResultInfo operationResultInfoInstance = new OperationResultInfo();
                                    
                                    JToken jobListArray = operationValue["jobList"];
                                    if (jobListArray != null && jobListArray.Type != JTokenType.Null)
                                    {
                                        foreach (JToken jobListValue in ((JArray)jobListArray))
                                        {
                                            operationResultInfoInstance.JobList.Add(((string)jobListValue));
                                        }
                                    }
                                    result.Operation = operationResultInfoInstance;
                                }
                                if (typeName == "ExportJobsOperationResultInfo")
                                {
                                    ExportJobsOperationResultInfo exportJobsOperationResultInfoInstance = new ExportJobsOperationResultInfo();
                                    
                                    JToken blobUrlValue = operationValue["blobUrl"];
                                    if (blobUrlValue != null && blobUrlValue.Type != JTokenType.Null)
                                    {
                                        string blobUrlInstance = ((string)blobUrlValue);
                                        exportJobsOperationResultInfoInstance.BlobUrl = blobUrlInstance;
                                    }
                                    
                                    JToken blobSasKeyValue = operationValue["blobSasKey"];
                                    if (blobSasKeyValue != null && blobSasKeyValue.Type != JTokenType.Null)
                                    {
                                        string blobSasKeyInstance = ((string)blobSasKeyValue);
                                        exportJobsOperationResultInfoInstance.BlobSasKey = blobSasKeyInstance;
                                    }
                                    result.Operation = exportJobsOperationResultInfoInstance;
                                }
                            }
                            
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
        /// Get the Delete Item Operation Result by URL
        /// </summary>
        /// <param name='operationResultLink'>
        /// Required. Location value returned by operation.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The definition of a GetOperationResultResponse.
        /// </returns>
        public async Task<GetOperationResultResponse> GetBackupOperationResultByURLAsync(string operationResultLink, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken)
        {
            // Validate
            if (operationResultLink == null)
            {
                throw new ArgumentNullException("operationResultLink");
            }
            
            // Tracing
            bool shouldTrace = TracingAdapter.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = TracingAdapter.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("operationResultLink", operationResultLink);
                tracingParameters.Add("customRequestHeaders", customRequestHeaders);
                TracingAdapter.Enter(invocationId, this, "GetBackupOperationResultByURLAsync", tracingParameters);
            }
            
            // Construct URL
            string url = "";
            url = url + operationResultLink;
            url = url.Replace(" ", "%20");
            
            // Create HTTP transport objects
            HttpRequestMessage httpRequest = null;
            try
            {
                httpRequest = new HttpRequestMessage();
                httpRequest.Method = HttpMethod.Get;
                httpRequest.RequestUri = new Uri(url);
                
                // Set Headers
                httpRequest.Headers.Add("Accept-Language", customRequestHeaders.Culture);
                httpRequest.Headers.Add("x-ms-client-request-id", customRequestHeaders.ClientRequestId);
                
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
                    if (statusCode != HttpStatusCode.OK && statusCode != HttpStatusCode.Accepted)
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
                    GetOperationResultResponse result = null;
                    // Deserialize Response
                    if (statusCode == HttpStatusCode.OK || statusCode == HttpStatusCode.Accepted)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        string responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                        result = new GetOperationResultResponse();
                        JToken responseDoc = null;
                        if (string.IsNullOrEmpty(responseContent) == false)
                        {
                            responseDoc = JToken.Parse(responseContent);
                        }
                        
                        if (responseDoc != null && responseDoc.Type != JTokenType.Null)
                        {
                            JToken operationValue = responseDoc["operation"];
                            if (operationValue != null && operationValue.Type != JTokenType.Null)
                            {
                                string typeName = ((string)operationValue["objectType"]);
                                if (typeName == "OperationResultInfo")
                                {
                                    OperationResultInfo operationResultInfoInstance = new OperationResultInfo();
                                    
                                    JToken jobListArray = operationValue["jobList"];
                                    if (jobListArray != null && jobListArray.Type != JTokenType.Null)
                                    {
                                        foreach (JToken jobListValue in ((JArray)jobListArray))
                                        {
                                            operationResultInfoInstance.JobList.Add(((string)jobListValue));
                                        }
                                    }
                                    result.Operation = operationResultInfoInstance;
                                }
                                if (typeName == "ExportJobsOperationResultInfo")
                                {
                                    ExportJobsOperationResultInfo exportJobsOperationResultInfoInstance = new ExportJobsOperationResultInfo();
                                    
                                    JToken blobUrlValue = operationValue["blobUrl"];
                                    if (blobUrlValue != null && blobUrlValue.Type != JTokenType.Null)
                                    {
                                        string blobUrlInstance = ((string)blobUrlValue);
                                        exportJobsOperationResultInfoInstance.BlobUrl = blobUrlInstance;
                                    }
                                    
                                    JToken blobSasKeyValue = operationValue["blobSasKey"];
                                    if (blobSasKeyValue != null && blobSasKeyValue.Type != JTokenType.Null)
                                    {
                                        string blobSasKeyInstance = ((string)blobSasKeyValue);
                                        exportJobsOperationResultInfoInstance.BlobSasKey = blobSasKeyInstance;
                                    }
                                    result.Operation = exportJobsOperationResultInfoInstance;
                                }
                            }
                            
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
    }
}