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
    /// Definition of BackupEningOperations for the Azure Backup extension with
    /// RecoveryService Vault.
    /// </summary>
    internal partial class BackupEngineOperations : IServiceOperations<RecoveryServicesBackupManagementClient>, IBackupEngineOperations
    {
        /// <summary>
        /// Initializes a new instance of the BackupEngineOperations class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        internal BackupEngineOperations(RecoveryServicesBackupManagementClient client)
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
        /// List all backup engine.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Required. ResourceGroupName for recoveryServices Vault.
        /// </param>
        /// <param name='resourceName'>
        /// Required. ResourceName for recoveryServices Vault.
        /// </param>
        /// <param name='queryParams'>
        /// Required. Query params for backup engine.
        /// </param>
        /// <param name='paginationParams'>
        /// Optional. Pagination parameter for skip token and top.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Required. Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The definition of a BackupEngineListResponse.
        /// </returns>
        public async Task<BackupEngineListResponse> ListAsync(string resourceGroupName, string resourceName, BackupEngineListQueryParams queryParams, PaginationRequest paginationParams, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken)
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
            if (queryParams == null)
            {
                throw new ArgumentNullException("queryParams");
            }
            if (customRequestHeaders == null)
            {
                throw new ArgumentNullException("customRequestHeaders");
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
                tracingParameters.Add("queryParams", queryParams);
                tracingParameters.Add("paginationParams", paginationParams);
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
            url = url + Uri.EscapeDataString(resourceGroupName);
            url = url + "/providers/";
            url = url + Uri.EscapeDataString(this.Client.ResourceNamespace);
            url = url + "/";
            url = url + "vaults";
            url = url + "/";
            url = url + Uri.EscapeDataString(resourceName);
            url = url + "/backupEngines";
            List<string> queryParameters = new List<string>();
            queryParameters.Add("api-version=2015-03-15");
            List<string> odataFilter = new List<string>();
            if (queryParams.ProviderType != null)
            {
                odataFilter.Add("providerType eq '" + Uri.EscapeDataString(queryParams.ProviderType) + "'");
            }
            if (odataFilter.Count > 0)
            {
                queryParameters.Add("$filter=" + string.Join(null, odataFilter));
            }
            if (paginationParams != null && paginationParams.SkipToken != null)
            {
                queryParameters.Add("$skiptoken=" + Uri.EscapeDataString(paginationParams.SkipToken));
            }
            if (paginationParams != null && paginationParams.Top != null)
            {
                queryParameters.Add("$top=" + Uri.EscapeDataString(paginationParams.Top));
            }
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
                    BackupEngineListResponse result = null;
                    // Deserialize Response
                    if (statusCode == HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        string responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                        result = new BackupEngineListResponse();
                        JToken responseDoc = null;
                        if (string.IsNullOrEmpty(responseContent) == false)
                        {
                            responseDoc = JToken.Parse(responseContent);
                        }
                        
                        if (responseDoc != null && responseDoc.Type != JTokenType.Null)
                        {
                            BackupEngineResourceList itemListInstance = new BackupEngineResourceList();
                            result.ItemList = itemListInstance;
                            
                            JToken valueArray = responseDoc["value"];
                            if (valueArray != null && valueArray.Type != JTokenType.Null)
                            {
                                foreach (JToken valueValue in ((JArray)valueArray))
                                {
                                    BackupEngineResource backupEngineResourceInstance = new BackupEngineResource();
                                    itemListInstance.BackupEngines.Add(backupEngineResourceInstance);
                                    
                                    JToken propertiesValue = valueValue["properties"];
                                    if (propertiesValue != null && propertiesValue.Type != JTokenType.Null)
                                    {
                                        string typeName = ((string)propertiesValue["backupEngineType"]);
                                        if (typeName == "DpmBackupEngine")
                                        {
                                            DpmBackupEngine dpmBackupEngineInstance = new DpmBackupEngine();
                                            
                                            JToken canReRegisterValue = propertiesValue["canReRegister"];
                                            if (canReRegisterValue != null && canReRegisterValue.Type != JTokenType.Null)
                                            {
                                                bool canReRegisterInstance = ((bool)canReRegisterValue);
                                                dpmBackupEngineInstance.CanReRegister = canReRegisterInstance;
                                            }
                                            
                                            JToken backupEngineIdValue = propertiesValue["backupEngineId"];
                                            if (backupEngineIdValue != null && backupEngineIdValue.Type != JTokenType.Null)
                                            {
                                                string backupEngineIdInstance = ((string)backupEngineIdValue);
                                                dpmBackupEngineInstance.BackupEngineId = backupEngineIdInstance;
                                            }
                                            
                                            JToken friendlyNameValue = propertiesValue["friendlyName"];
                                            if (friendlyNameValue != null && friendlyNameValue.Type != JTokenType.Null)
                                            {
                                                string friendlyNameInstance = ((string)friendlyNameValue);
                                                dpmBackupEngineInstance.FriendlyName = friendlyNameInstance;
                                            }
                                            
                                            JToken backupManagementTypeValue = propertiesValue["backupManagementType"];
                                            if (backupManagementTypeValue != null && backupManagementTypeValue.Type != JTokenType.Null)
                                            {
                                                string backupManagementTypeInstance = ((string)backupManagementTypeValue);
                                                dpmBackupEngineInstance.BackupManagementType = backupManagementTypeInstance;
                                            }
                                            
                                            JToken registrationStatusValue = propertiesValue["registrationStatus"];
                                            if (registrationStatusValue != null && registrationStatusValue.Type != JTokenType.Null)
                                            {
                                                string registrationStatusInstance = ((string)registrationStatusValue);
                                                dpmBackupEngineInstance.RegistrationStatus = registrationStatusInstance;
                                            }
                                            
                                            JToken healthStatusValue = propertiesValue["healthStatus"];
                                            if (healthStatusValue != null && healthStatusValue.Type != JTokenType.Null)
                                            {
                                                string healthStatusInstance = ((string)healthStatusValue);
                                                dpmBackupEngineInstance.HealthStatus = healthStatusInstance;
                                            }
                                            
                                            JToken backupEngineTypeValue = propertiesValue["backupEngineType"];
                                            if (backupEngineTypeValue != null && backupEngineTypeValue.Type != JTokenType.Null)
                                            {
                                                string backupEngineTypeInstance = ((string)backupEngineTypeValue);
                                                dpmBackupEngineInstance.BackupEngineType = backupEngineTypeInstance;
                                            }
                                            backupEngineResourceInstance.Properties = dpmBackupEngineInstance;
                                        }
                                    }
                                    
                                    JToken idValue = valueValue["id"];
                                    if (idValue != null && idValue.Type != JTokenType.Null)
                                    {
                                        string idInstance = ((string)idValue);
                                        backupEngineResourceInstance.Id = idInstance;
                                    }
                                    
                                    JToken nameValue = valueValue["name"];
                                    if (nameValue != null && nameValue.Type != JTokenType.Null)
                                    {
                                        string nameInstance = ((string)nameValue);
                                        backupEngineResourceInstance.Name = nameInstance;
                                    }
                                    
                                    JToken typeValue = valueValue["type"];
                                    if (typeValue != null && typeValue.Type != JTokenType.Null)
                                    {
                                        string typeInstance = ((string)typeValue);
                                        backupEngineResourceInstance.Type = typeInstance;
                                    }
                                    
                                    JToken locationValue = valueValue["location"];
                                    if (locationValue != null && locationValue.Type != JTokenType.Null)
                                    {
                                        string locationInstance = ((string)locationValue);
                                        backupEngineResourceInstance.Location = locationInstance;
                                    }
                                    
                                    JToken tagsSequenceElement = ((JToken)valueValue["tags"]);
                                    if (tagsSequenceElement != null && tagsSequenceElement.Type != JTokenType.Null)
                                    {
                                        foreach (JProperty property in tagsSequenceElement)
                                        {
                                            string tagsKey = ((string)property.Name);
                                            string tagsValue = ((string)property.Value);
                                            backupEngineResourceInstance.Tags.Add(tagsKey, tagsValue);
                                        }
                                    }
                                    
                                    JToken eTagValue = valueValue["eTag"];
                                    if (eTagValue != null && eTagValue.Type != JTokenType.Null)
                                    {
                                        string eTagInstance = ((string)eTagValue);
                                        backupEngineResourceInstance.ETag = eTagInstance;
                                    }
                                }
                            }
                            
                            JToken nextLinkValue = responseDoc["nextLink"];
                            if (nextLinkValue != null && nextLinkValue.Type != JTokenType.Null)
                            {
                                string nextLinkInstance = ((string)nextLinkValue);
                                itemListInstance.NextLink = nextLinkInstance;
                            }
                        }
                        
                    }
                    result.StatusCode = statusCode;
                    
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