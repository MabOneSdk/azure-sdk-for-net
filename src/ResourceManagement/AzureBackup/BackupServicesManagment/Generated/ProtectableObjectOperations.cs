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
    /// Definition of Protectable ObjectOperation operations for the Azure
    /// Backup extension.
    /// </summary>
    internal partial class ProtectableObjectOperations : IServiceOperations<BackupServicesManagementClient>, IProtectableObjectOperations
    {
        /// <summary>
        /// Initializes a new instance of the ProtectableObjectOperations class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        internal ProtectableObjectOperations(BackupServicesManagementClient client)
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
        /// Get the list of all Protectable Objects.
        /// </summary>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response model for the list ProtectableObject operation.
        /// </returns>
        public async Task<ProtectableObjectListResponse> ListAsync(CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken)
        {
            // Validate
            
            // Tracing
            bool shouldTrace = TracingAdapter.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = TracingAdapter.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("customRequestHeaders", customRequestHeaders);
                TracingAdapter.Enter(invocationId, this, "ListAsync", tracingParameters);
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
            url = url + "/protectableobjects";
            List<string> queryParameters = new List<string>();
            queryParameters.Add("api-version=2014-09-01.1.0");
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
                    ProtectableObjectListResponse result = null;
                    // Deserialize Response
                    if (statusCode == HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        string responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                        result = new ProtectableObjectListResponse();
                        JToken responseDoc = null;
                        if (string.IsNullOrEmpty(responseContent) == false)
                        {
                            responseDoc = JToken.Parse(responseContent);
                        }
                        
                        if (responseDoc != null && responseDoc.Type != JTokenType.Null)
                        {
                            ProtectableObjectResponse protectableObjectInstance = new ProtectableObjectResponse();
                            result.ProtectableObject = protectableObjectInstance;
                            
                            JToken objectsArray = responseDoc["Objects"];
                            if (objectsArray != null && objectsArray.Type != JTokenType.Null)
                            {
                                foreach (JToken objectsValue in ((JArray)objectsArray))
                                {
                                    ProtectableObjectInfo protectableObjectInfoInstance = new ProtectableObjectInfo();
                                    protectableObjectInstance.Objects.Add(protectableObjectInfoInstance);
                                    
                                    JToken friendlyNameValue = objectsValue["FriendlyName"];
                                    if (friendlyNameValue != null && friendlyNameValue.Type != JTokenType.Null)
                                    {
                                        string friendlyNameInstance = ((string)friendlyNameValue);
                                        protectableObjectInfoInstance.FriendlyName = friendlyNameInstance;
                                    }
                                    
                                    JToken typeValue = objectsValue["Type"];
                                    if (typeValue != null && typeValue.Type != JTokenType.Null)
                                    {
                                        string typeInstance = ((string)typeValue);
                                        protectableObjectInfoInstance.Type = typeInstance;
                                    }
                                    
                                    JToken protectionStatusValue = objectsValue["ProtectionStatus"];
                                    if (protectionStatusValue != null && protectionStatusValue.Type != JTokenType.Null)
                                    {
                                        string protectionStatusInstance = ((string)protectionStatusValue);
                                        protectableObjectInfoInstance.ProtectionStatus = protectionStatusInstance;
                                    }
                                    
                                    JToken containerNameValue = objectsValue["ContainerName"];
                                    if (containerNameValue != null && containerNameValue.Type != JTokenType.Null)
                                    {
                                        string containerNameInstance = ((string)containerNameValue);
                                        protectableObjectInfoInstance.ContainerName = containerNameInstance;
                                    }
                                    
                                    JToken containerFriendlyNameValue = objectsValue["ContainerFriendlyName"];
                                    if (containerFriendlyNameValue != null && containerFriendlyNameValue.Type != JTokenType.Null)
                                    {
                                        string containerFriendlyNameInstance = ((string)containerFriendlyNameValue);
                                        protectableObjectInfoInstance.ContainerFriendlyName = containerFriendlyNameInstance;
                                    }
                                    
                                    JToken containerTypeValue = objectsValue["ContainerType"];
                                    if (containerTypeValue != null && containerTypeValue.Type != JTokenType.Null)
                                    {
                                        string containerTypeInstance = ((string)containerTypeValue);
                                        protectableObjectInfoInstance.ContainerType = containerTypeInstance;
                                    }
                                    
                                    JToken parentContainerNameValue = objectsValue["ParentContainerName"];
                                    if (parentContainerNameValue != null && parentContainerNameValue.Type != JTokenType.Null)
                                    {
                                        string parentContainerNameInstance = ((string)parentContainerNameValue);
                                        protectableObjectInfoInstance.ParentContainerName = parentContainerNameInstance;
                                    }
                                    
                                    JToken parentContainerFriendlyNameValue = objectsValue["ParentContainerFriendlyName"];
                                    if (parentContainerFriendlyNameValue != null && parentContainerFriendlyNameValue.Type != JTokenType.Null)
                                    {
                                        string parentContainerFriendlyNameInstance = ((string)parentContainerFriendlyNameValue);
                                        protectableObjectInfoInstance.ParentContainerFriendlyName = parentContainerFriendlyNameInstance;
                                    }
                                    
                                    JToken parentContainerTypeValue = objectsValue["ParentContainerType"];
                                    if (parentContainerTypeValue != null && parentContainerTypeValue.Type != JTokenType.Null)
                                    {
                                        string parentContainerTypeInstance = ((string)parentContainerTypeValue);
                                        protectableObjectInfoInstance.ParentContainerType = parentContainerTypeInstance;
                                    }
                                    
                                    JToken instanceIdValue = objectsValue["InstanceId"];
                                    if (instanceIdValue != null && instanceIdValue.Type != JTokenType.Null)
                                    {
                                        string instanceIdInstance = ((string)instanceIdValue);
                                        protectableObjectInfoInstance.InstanceId = instanceIdInstance;
                                    }
                                    
                                    JToken nameValue = objectsValue["Name"];
                                    if (nameValue != null && nameValue.Type != JTokenType.Null)
                                    {
                                        string nameInstance = ((string)nameValue);
                                        protectableObjectInfoInstance.Name = nameInstance;
                                    }
                                    
                                    JToken operationInProgressValue = objectsValue["OperationInProgress"];
                                    if (operationInProgressValue != null && operationInProgressValue.Type != JTokenType.Null)
                                    {
                                        bool operationInProgressInstance = ((bool)operationInProgressValue);
                                        protectableObjectInfoInstance.OperationInProgress = operationInProgressInstance;
                                    }
                                }
                            }
                            
                            JToken resultCountValue = responseDoc["ResultCount"];
                            if (resultCountValue != null && resultCountValue.Type != JTokenType.Null)
                            {
                                int resultCountInstance = ((int)resultCountValue);
                                protectableObjectInstance.ResultCount = resultCountInstance;
                            }
                            
                            JToken skiptokenValue = responseDoc["Skiptoken"];
                            if (skiptokenValue != null && skiptokenValue.Type != JTokenType.Null)
                            {
                                string skiptokenInstance = ((string)skiptokenValue);
                                protectableObjectInstance.Skiptoken = skiptokenInstance;
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