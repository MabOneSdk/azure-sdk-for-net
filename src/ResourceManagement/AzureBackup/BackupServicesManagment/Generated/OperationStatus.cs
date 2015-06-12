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
using Microsoft.Azure.Management.BackupServices;
using Microsoft.Azure.Management.BackupServices.Models;
using Newtonsoft.Json.Linq;

namespace Microsoft.Azure.Management.BackupServices
{
    /// <summary>
    /// Definition of Workflow operation for the Azure Backup extension.
    /// </summary>
    internal partial class OperationStatus : IServiceOperations<BackupServicesManagementClient>, IOperationStatus
    {
        /// <summary>
        /// Initializes a new instance of the OperationStatus class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        internal OperationStatus(BackupServicesManagementClient client)
        {
            this._client = client;
        }
        
        private BackupServicesManagementClient _client;
        
        /// <summary>
        /// Gets a reference to the
        /// Microsoft.Azure.Management.BackupServices.BackupServicesManagementClient.
        /// </summary>
        public BackupServicesManagementClient Client
        {
            get { return this._client; }
        }
        
        /// <summary>
        /// Get the Operation Status.
        /// </summary>
        /// <param name='operationId'>
        /// Required. OperationId.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The definition of a BMSOperationStatusResponse.
        /// </returns>
        public async Task<BMSOperationStatusResponse> GetAsync(string operationId, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken)
        {
            // Validate
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
                tracingParameters.Add("operationId", operationId);
                tracingParameters.Add("customRequestHeaders", customRequestHeaders);
                TracingAdapter.Enter(invocationId, this, "GetAsync", tracingParameters);
            }
            
            // Construct URL
            string url = "";
            url = url + "/Subscriptions/";
            if (this.Client.Credentials.SubscriptionId != null)
            {
                url = url + Uri.EscapeDataString(this.Client.Credentials.SubscriptionId);
            }
            url = url + "/resourceGroups/";
            url = url + Uri.EscapeDataString(this.Client.ResourceGroupName);
            url = url + "/providers/";
            url = url + "Microsoft.Backupseadev01";
            url = url + "/";
            url = url + "BackupVault";
            url = url + "/";
            url = url + Uri.EscapeDataString(this.Client.ResourceName);
            url = url + "/operations/";
            url = url + Uri.EscapeDataString(operationId);
            List<string> queryParameters = new List<string>();
            queryParameters.Add("api-version=2014-09-01");
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
                httpRequest.Headers.Add("Accept-Language", "en-us");
                httpRequest.Headers.Add("x-ms-version", "2013-03-01");
                
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
                    if (statusCode != HttpStatusCode.OK)
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
                    BMSOperationStatusResponse result = null;
                    // Deserialize Response
                    if (statusCode == HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        string responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                        result = new BMSOperationStatusResponse();
                        JToken responseDoc = null;
                        if (string.IsNullOrEmpty(responseContent) == false)
                        {
                            responseDoc = JToken.Parse(responseContent);
                        }
                        
                        JToken bMSOperationStatusResponseValue = responseDoc["BMSOperationStatusResponse"];
                        if (bMSOperationStatusResponseValue != null && bMSOperationStatusResponseValue.Type != JTokenType.Null)
                        {
                            BMSOperationStatusResponse bMSOperationStatusResponseInstance = new BMSOperationStatusResponse();
                            
                            JToken operationStatusValue = bMSOperationStatusResponseValue["OperationStatus"];
                            if (operationStatusValue != null && operationStatusValue.Type != JTokenType.Null)
                            {
                                string operationStatusInstance = ((string)operationStatusValue);
                                bMSOperationStatusResponseInstance.OperationStatus = operationStatusInstance;
                            }
                            
                            JToken operationResultValue = bMSOperationStatusResponseValue["OperationResult"];
                            if (operationResultValue != null && operationResultValue.Type != JTokenType.Null)
                            {
                                string operationResultInstance = ((string)operationResultValue);
                                bMSOperationStatusResponseInstance.OperationResult = operationResultInstance;
                            }
                            
                            JToken messageValue = bMSOperationStatusResponseValue["Message"];
                            if (messageValue != null && messageValue.Type != JTokenType.Null)
                            {
                                string messageInstance = ((string)messageValue);
                                bMSOperationStatusResponseInstance.Message = messageInstance;
                            }
                            
                            JToken objectsArray = bMSOperationStatusResponseValue["Objects"];
                            if (objectsArray != null && objectsArray.Type != JTokenType.Null)
                            {
                                foreach (JToken objectsValue in ((JArray)objectsArray))
                                {
                                    JobStep managementBaseObjectInstance = new JobStep();
                                    bMSOperationStatusResponseInstance.JobSteps.Add(managementBaseObjectInstance);
                                    
                                    JToken operationStatusValue2 = objectsValue["OperationStatus"];
                                    if (operationStatusValue2 != null && operationStatusValue2.Type != JTokenType.Null)
                                    {
                                        string operationStatusInstance2 = ((string)operationStatusValue2);
                                        managementBaseObjectInstance.OperationStatus = operationStatusInstance2;
                                    }
                                    
                                    JToken operationResultValue2 = objectsValue["OperationResult"];
                                    if (operationResultValue2 != null && operationResultValue2.Type != JTokenType.Null)
                                    {
                                        string operationResultInstance2 = ((string)operationResultValue2);
                                        managementBaseObjectInstance.OperationResult = operationResultInstance2;
                                    }
                                    
                                    JToken messageValue2 = objectsValue["Message"];
                                    if (messageValue2 != null && messageValue2.Type != JTokenType.Null)
                                    {
                                        string messageInstance2 = ((string)messageValue2);
                                        managementBaseObjectInstance.Message = messageInstance2;
                                    }
                                    
                                    JToken detailValue = objectsValue["Detail"];
                                    if (detailValue != null && detailValue.Type != JTokenType.Null)
                                    {
                                        string detailInstance = ((string)detailValue);
                                        managementBaseObjectInstance.Detail = detailInstance;
                                    }
                                }
                            }
                            
                            JToken errorCodeValue = bMSOperationStatusResponseValue["ErrorCode"];
                            if (errorCodeValue != null && errorCodeValue.Type != JTokenType.Null)
                            {
                                string errorCodeInstance = ((string)errorCodeValue);
                                bMSOperationStatusResponseInstance.ErrorCode = errorCodeInstance;
                            }
                        }
                        
                    }
                    result.StatusCode = statusCode;
                    if (httpResponse.Headers.Contains("x-ms-client-request-id"))
                    {
                        customRequestHeaders.ClientRequestId = httpResponse.Headers.GetValues("x-ms-client-request-id").FirstOrDefault();
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