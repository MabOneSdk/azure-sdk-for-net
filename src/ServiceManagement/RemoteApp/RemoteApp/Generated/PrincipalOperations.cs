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
using Hyak.Common.Internals;
using Microsoft.WindowsAzure.Management.RemoteApp;
using Microsoft.WindowsAzure.Management.RemoteApp.Models;
using Newtonsoft.Json.Linq;

namespace Microsoft.WindowsAzure.Management.RemoteApp
{
    /// <summary>
    /// RemoteApp principal operations.
    /// </summary>
    internal partial class PrincipalOperations : IServiceOperations<RemoteAppManagementClient>, IPrincipalOperations
    {
        /// <summary>
        /// Initializes a new instance of the PrincipalOperations class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        internal PrincipalOperations(RemoteAppManagementClient client)
        {
            this._client = client;
        }
        
        private RemoteAppManagementClient _client;
        
        /// <summary>
        /// Gets a reference to the
        /// Microsoft.WindowsAzure.Management.RemoteApp.RemoteAppManagementClient.
        /// </summary>
        public RemoteAppManagementClient Client
        {
            get { return this._client; }
        }
        
        /// <summary>
        /// Adds a list of principals to the given collection.
        /// </summary>
        /// <param name='collectionName'>
        /// Required. The RemoteApp collection name.
        /// </param>
        /// <param name='securityPrincipalList'>
        /// Required. A list of RemoteApp principals to add.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response for the collection user operation.
        /// </returns>
        public async Task<SecurityPrincipalOperationsResult> AddAsync(string collectionName, SecurityPrincipalList securityPrincipalList, CancellationToken cancellationToken)
        {
            // Validate
            if (collectionName == null)
            {
                throw new ArgumentNullException("collectionName");
            }
            if (securityPrincipalList == null)
            {
                throw new ArgumentNullException("securityPrincipalList");
            }
            if (securityPrincipalList.SecurityPrincipals != null)
            {
                foreach (SecurityPrincipal securityPrincipalsParameterItem in securityPrincipalList.SecurityPrincipals)
                {
                    if (securityPrincipalsParameterItem.Name == null)
                    {
                        throw new ArgumentNullException("securityPrincipalList.SecurityPrincipals.Name");
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
                tracingParameters.Add("collectionName", collectionName);
                tracingParameters.Add("securityPrincipalList", securityPrincipalList);
                TracingAdapter.Enter(invocationId, this, "AddAsync", tracingParameters);
            }
            
            // Construct URL
            string url = "";
            url = url + "/";
            if (this.Client.Credentials.SubscriptionId != null)
            {
                url = url + Uri.EscapeDataString(this.Client.Credentials.SubscriptionId);
            }
            url = url + "/services/";
            if (this.Client.RdfeNamespace != null)
            {
                url = url + Uri.EscapeDataString(this.Client.RdfeNamespace);
            }
            url = url + "/collections/";
            url = url + Uri.EscapeDataString(collectionName);
            url = url + "/securityPrincipals";
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
                httpRequest.Method = HttpMethod.Post;
                httpRequest.RequestUri = new Uri(url);
                
                // Set Headers
                httpRequest.Headers.Add("Accept", "application/json; charset=utf-8");
                httpRequest.Headers.Add("x-ms-version", "2014-08-01");
                
                // Set Credentials
                cancellationToken.ThrowIfCancellationRequested();
                await this.Client.Credentials.ProcessHttpRequestAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                
                // Serialize Request
                string requestContent = null;
                JToken requestDoc = null;
                
                if (securityPrincipalList.SecurityPrincipals != null)
                {
                    if (securityPrincipalList.SecurityPrincipals is ILazyCollection == false || ((ILazyCollection)securityPrincipalList.SecurityPrincipals).IsInitialized)
                    {
                        JArray securityPrincipalsArray = new JArray();
                        foreach (SecurityPrincipal securityPrincipalsItem in securityPrincipalList.SecurityPrincipals)
                        {
                            JObject securityPrincipalValue = new JObject();
                            securityPrincipalsArray.Add(securityPrincipalValue);
                            
                            securityPrincipalValue["SecurityPrincipalType"] = ((int)securityPrincipalsItem.SecurityPrincipalType);
                            
                            securityPrincipalValue["UserIdType"] = ((int)securityPrincipalsItem.UserIdType);
                            
                            securityPrincipalValue["Name"] = securityPrincipalsItem.Name;
                            
                            if (securityPrincipalsItem.AadObjectId != null)
                            {
                                securityPrincipalValue["AadObjectId"] = securityPrincipalsItem.AadObjectId;
                            }
                            
                            if (securityPrincipalsItem.Description != null)
                            {
                                securityPrincipalValue["Description"] = securityPrincipalsItem.Description;
                            }
                        }
                        requestDoc = securityPrincipalsArray;
                    }
                }
                
                requestContent = requestDoc.ToString(Newtonsoft.Json.Formatting.Indented);
                httpRequest.Content = new StringContent(requestContent, Encoding.UTF8);
                httpRequest.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json; charset=utf-8");
                
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
                        CloudException ex = CloudException.Create(httpRequest, requestContent, httpResponse, await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false));
                        if (shouldTrace)
                        {
                            TracingAdapter.Error(invocationId, ex);
                        }
                        throw ex;
                    }
                    
                    // Create Result
                    SecurityPrincipalOperationsResult result = null;
                    // Deserialize Response
                    if (statusCode == HttpStatusCode.OK || statusCode == HttpStatusCode.Accepted)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        string responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                        result = new SecurityPrincipalOperationsResult();
                        JToken responseDoc = null;
                        if (string.IsNullOrEmpty(responseContent) == false)
                        {
                            responseDoc = JToken.Parse(responseContent);
                        }
                        
                        if (responseDoc != null && responseDoc.Type != JTokenType.Null)
                        {
                            JToken failedSecurityPrincipalsArray = responseDoc["FailedSecurityPrincipals"];
                            if (failedSecurityPrincipalsArray != null && failedSecurityPrincipalsArray.Type != JTokenType.Null)
                            {
                                foreach (JToken failedSecurityPrincipalsValue in ((JArray)failedSecurityPrincipalsArray))
                                {
                                    SecurityPrincipalOperationErrorDetails securityPrincipalOperationErrorDetailsInstance = new SecurityPrincipalOperationErrorDetails();
                                    result.Errors.Add(securityPrincipalOperationErrorDetailsInstance);
                                    
                                    JToken securityPrincipalValue2 = failedSecurityPrincipalsValue["SecurityPrincipal"];
                                    if (securityPrincipalValue2 != null && securityPrincipalValue2.Type != JTokenType.Null)
                                    {
                                        string securityPrincipalInstance = ((string)securityPrincipalValue2);
                                        securityPrincipalOperationErrorDetailsInstance.SecurityPrincipal = securityPrincipalInstance;
                                    }
                                    
                                    JToken errorValue = failedSecurityPrincipalsValue["Error"];
                                    if (errorValue != null && errorValue.Type != JTokenType.Null)
                                    {
                                        SecurityPrincipalOperationError errorInstance = ((SecurityPrincipalOperationError)(((int)errorValue)));
                                        securityPrincipalOperationErrorDetailsInstance.Error = errorInstance;
                                    }
                                    
                                    JToken errorDetailsValue = failedSecurityPrincipalsValue["ErrorDetails"];
                                    if (errorDetailsValue != null && errorDetailsValue.Type != JTokenType.Null)
                                    {
                                        string errorDetailsInstance = ((string)errorDetailsValue);
                                        securityPrincipalOperationErrorDetailsInstance.ErrorDetails = errorDetailsInstance;
                                    }
                                }
                            }
                            
                            JToken trackingIdValue = responseDoc["TrackingId"];
                            if (trackingIdValue != null && trackingIdValue.Type != JTokenType.Null)
                            {
                                string trackingIdInstance = ((string)trackingIdValue);
                                result.TrackingId = trackingIdInstance;
                            }
                        }
                        
                    }
                    result.StatusCode = statusCode;
                    if (httpResponse.Headers.Contains("x-ms-request-id"))
                    {
                        result.RequestId = httpResponse.Headers.GetValues("x-ms-request-id").FirstOrDefault();
                    }
                    if (httpResponse.Headers.Contains("x-remoteapp-operation-tracking-id"))
                    {
                        result.TrackingId = httpResponse.Headers.GetValues("x-remoteapp-operation-tracking-id").FirstOrDefault();
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
        /// Deletes a list of principals from the given collection.
        /// </summary>
        /// <param name='collectionName'>
        /// Required. The RemoteApp collection name.
        /// </param>
        /// <param name='securityPrincipalList'>
        /// Required. A list of RemoteApp principals to delete.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response for the collection user operation.
        /// </returns>
        public async Task<SecurityPrincipalOperationsResult> DeleteAsync(string collectionName, SecurityPrincipalList securityPrincipalList, CancellationToken cancellationToken)
        {
            // Validate
            if (collectionName == null)
            {
                throw new ArgumentNullException("collectionName");
            }
            if (securityPrincipalList == null)
            {
                throw new ArgumentNullException("securityPrincipalList");
            }
            if (securityPrincipalList.SecurityPrincipals != null)
            {
                foreach (SecurityPrincipal securityPrincipalsParameterItem in securityPrincipalList.SecurityPrincipals)
                {
                    if (securityPrincipalsParameterItem.Name == null)
                    {
                        throw new ArgumentNullException("securityPrincipalList.SecurityPrincipals.Name");
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
                tracingParameters.Add("collectionName", collectionName);
                tracingParameters.Add("securityPrincipalList", securityPrincipalList);
                TracingAdapter.Enter(invocationId, this, "DeleteAsync", tracingParameters);
            }
            
            // Construct URL
            string url = "";
            url = url + "/";
            if (this.Client.Credentials.SubscriptionId != null)
            {
                url = url + Uri.EscapeDataString(this.Client.Credentials.SubscriptionId);
            }
            url = url + "/services/";
            if (this.Client.RdfeNamespace != null)
            {
                url = url + Uri.EscapeDataString(this.Client.RdfeNamespace);
            }
            url = url + "/collections/";
            url = url + Uri.EscapeDataString(collectionName);
            url = url + "/securityPrincipals";
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
                httpRequest.Method = HttpMethod.Delete;
                httpRequest.RequestUri = new Uri(url);
                
                // Set Headers
                httpRequest.Headers.Add("Accept", "application/json; charset=utf-8");
                httpRequest.Headers.Add("x-ms-version", "2014-08-01");
                
                // Set Credentials
                cancellationToken.ThrowIfCancellationRequested();
                await this.Client.Credentials.ProcessHttpRequestAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                
                // Serialize Request
                string requestContent = null;
                JToken requestDoc = null;
                
                if (securityPrincipalList.SecurityPrincipals != null)
                {
                    if (securityPrincipalList.SecurityPrincipals is ILazyCollection == false || ((ILazyCollection)securityPrincipalList.SecurityPrincipals).IsInitialized)
                    {
                        JArray securityPrincipalsArray = new JArray();
                        foreach (SecurityPrincipal securityPrincipalsItem in securityPrincipalList.SecurityPrincipals)
                        {
                            JObject securityPrincipalValue = new JObject();
                            securityPrincipalsArray.Add(securityPrincipalValue);
                            
                            securityPrincipalValue["SecurityPrincipalType"] = ((int)securityPrincipalsItem.SecurityPrincipalType);
                            
                            securityPrincipalValue["UserIdType"] = ((int)securityPrincipalsItem.UserIdType);
                            
                            securityPrincipalValue["Name"] = securityPrincipalsItem.Name;
                            
                            if (securityPrincipalsItem.AadObjectId != null)
                            {
                                securityPrincipalValue["AadObjectId"] = securityPrincipalsItem.AadObjectId;
                            }
                            
                            if (securityPrincipalsItem.Description != null)
                            {
                                securityPrincipalValue["Description"] = securityPrincipalsItem.Description;
                            }
                        }
                        requestDoc = securityPrincipalsArray;
                    }
                }
                
                requestContent = requestDoc.ToString(Newtonsoft.Json.Formatting.Indented);
                httpRequest.Content = new StringContent(requestContent, Encoding.UTF8);
                httpRequest.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json; charset=utf-8");
                
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
                        CloudException ex = CloudException.Create(httpRequest, requestContent, httpResponse, await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false));
                        if (shouldTrace)
                        {
                            TracingAdapter.Error(invocationId, ex);
                        }
                        throw ex;
                    }
                    
                    // Create Result
                    SecurityPrincipalOperationsResult result = null;
                    // Deserialize Response
                    if (statusCode == HttpStatusCode.OK || statusCode == HttpStatusCode.Accepted)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        string responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                        result = new SecurityPrincipalOperationsResult();
                        JToken responseDoc = null;
                        if (string.IsNullOrEmpty(responseContent) == false)
                        {
                            responseDoc = JToken.Parse(responseContent);
                        }
                        
                        if (responseDoc != null && responseDoc.Type != JTokenType.Null)
                        {
                            JToken failedSecurityPrincipalsArray = responseDoc["FailedSecurityPrincipals"];
                            if (failedSecurityPrincipalsArray != null && failedSecurityPrincipalsArray.Type != JTokenType.Null)
                            {
                                foreach (JToken failedSecurityPrincipalsValue in ((JArray)failedSecurityPrincipalsArray))
                                {
                                    SecurityPrincipalOperationErrorDetails securityPrincipalOperationErrorDetailsInstance = new SecurityPrincipalOperationErrorDetails();
                                    result.Errors.Add(securityPrincipalOperationErrorDetailsInstance);
                                    
                                    JToken securityPrincipalValue2 = failedSecurityPrincipalsValue["SecurityPrincipal"];
                                    if (securityPrincipalValue2 != null && securityPrincipalValue2.Type != JTokenType.Null)
                                    {
                                        string securityPrincipalInstance = ((string)securityPrincipalValue2);
                                        securityPrincipalOperationErrorDetailsInstance.SecurityPrincipal = securityPrincipalInstance;
                                    }
                                    
                                    JToken errorValue = failedSecurityPrincipalsValue["Error"];
                                    if (errorValue != null && errorValue.Type != JTokenType.Null)
                                    {
                                        SecurityPrincipalOperationError errorInstance = ((SecurityPrincipalOperationError)(((int)errorValue)));
                                        securityPrincipalOperationErrorDetailsInstance.Error = errorInstance;
                                    }
                                    
                                    JToken errorDetailsValue = failedSecurityPrincipalsValue["ErrorDetails"];
                                    if (errorDetailsValue != null && errorDetailsValue.Type != JTokenType.Null)
                                    {
                                        string errorDetailsInstance = ((string)errorDetailsValue);
                                        securityPrincipalOperationErrorDetailsInstance.ErrorDetails = errorDetailsInstance;
                                    }
                                }
                            }
                            
                            JToken trackingIdValue = responseDoc["TrackingId"];
                            if (trackingIdValue != null && trackingIdValue.Type != JTokenType.Null)
                            {
                                string trackingIdInstance = ((string)trackingIdValue);
                                result.TrackingId = trackingIdInstance;
                            }
                        }
                        
                    }
                    result.StatusCode = statusCode;
                    if (httpResponse.Headers.Contains("x-ms-request-id"))
                    {
                        result.RequestId = httpResponse.Headers.GetValues("x-ms-request-id").FirstOrDefault();
                    }
                    if (httpResponse.Headers.Contains("x-remoteapp-operation-tracking-id"))
                    {
                        result.TrackingId = httpResponse.Headers.GetValues("x-remoteapp-operation-tracking-id").FirstOrDefault();
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
        /// Gets a list of all RemoteApp principals associated with the given
        /// collection.
        /// </summary>
        /// <param name='collectionName'>
        /// Required. The RemoteApp collection name.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The list of principals with consent status.
        /// </returns>
        public async Task<SecurityPrincipalInfoListResult> ListAsync(string collectionName, CancellationToken cancellationToken)
        {
            // Validate
            if (collectionName == null)
            {
                throw new ArgumentNullException("collectionName");
            }
            
            // Tracing
            bool shouldTrace = TracingAdapter.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = TracingAdapter.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("collectionName", collectionName);
                TracingAdapter.Enter(invocationId, this, "ListAsync", tracingParameters);
            }
            
            // Construct URL
            string url = "";
            url = url + "/";
            if (this.Client.Credentials.SubscriptionId != null)
            {
                url = url + Uri.EscapeDataString(this.Client.Credentials.SubscriptionId);
            }
            url = url + "/services/";
            if (this.Client.RdfeNamespace != null)
            {
                url = url + Uri.EscapeDataString(this.Client.RdfeNamespace);
            }
            url = url + "/collections/";
            url = url + Uri.EscapeDataString(collectionName);
            url = url + "/securityPrincipals";
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
                httpRequest.Headers.Add("Accept", "application/json; charset=utf-8");
                httpRequest.Headers.Add("x-ms-version", "2014-08-01");
                
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
                    SecurityPrincipalInfoListResult result = null;
                    // Deserialize Response
                    if (statusCode == HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        string responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                        result = new SecurityPrincipalInfoListResult();
                        JToken responseDoc = null;
                        if (string.IsNullOrEmpty(responseContent) == false)
                        {
                            responseDoc = JToken.Parse(responseContent);
                        }
                        
                        if (responseDoc != null && responseDoc.Type != JTokenType.Null)
                        {
                            JToken securityPrincipalInfoListArray = responseDoc;
                            if (securityPrincipalInfoListArray != null && securityPrincipalInfoListArray.Type != JTokenType.Null)
                            {
                                foreach (JToken securityPrincipalInfoListValue in ((JArray)securityPrincipalInfoListArray))
                                {
                                    SecurityPrincipalInfo securityPrincipalInfoInstance = new SecurityPrincipalInfo();
                                    result.SecurityPrincipalInfoList.Add(securityPrincipalInfoInstance);
                                    
                                    JToken userValue = securityPrincipalInfoListValue["User"];
                                    if (userValue != null && userValue.Type != JTokenType.Null)
                                    {
                                        SecurityPrincipal userInstance = new SecurityPrincipal();
                                        securityPrincipalInfoInstance.SecurityPrincipal = userInstance;
                                        
                                        JToken securityPrincipalTypeValue = userValue["SecurityPrincipalType"];
                                        if (securityPrincipalTypeValue != null && securityPrincipalTypeValue.Type != JTokenType.Null)
                                        {
                                            PrincipalType securityPrincipalTypeInstance = ((PrincipalType)(((int)securityPrincipalTypeValue)));
                                            userInstance.SecurityPrincipalType = securityPrincipalTypeInstance;
                                        }
                                        
                                        JToken userIdTypeValue = userValue["UserIdType"];
                                        if (userIdTypeValue != null && userIdTypeValue.Type != JTokenType.Null)
                                        {
                                            PrincipalProviderType userIdTypeInstance = ((PrincipalProviderType)(((int)userIdTypeValue)));
                                            userInstance.UserIdType = userIdTypeInstance;
                                        }
                                        
                                        JToken nameValue = userValue["Name"];
                                        if (nameValue != null && nameValue.Type != JTokenType.Null)
                                        {
                                            string nameInstance = ((string)nameValue);
                                            userInstance.Name = nameInstance;
                                        }
                                        
                                        JToken aadObjectIdValue = userValue["AadObjectId"];
                                        if (aadObjectIdValue != null && aadObjectIdValue.Type != JTokenType.Null)
                                        {
                                            string aadObjectIdInstance = ((string)aadObjectIdValue);
                                            userInstance.AadObjectId = aadObjectIdInstance;
                                        }
                                        
                                        JToken descriptionValue = userValue["Description"];
                                        if (descriptionValue != null && descriptionValue.Type != JTokenType.Null)
                                        {
                                            string descriptionInstance = ((string)descriptionValue);
                                            userInstance.Description = descriptionInstance;
                                        }
                                    }
                                    
                                    JToken statusValue = securityPrincipalInfoListValue["Status"];
                                    if (statusValue != null && statusValue.Type != JTokenType.Null)
                                    {
                                        ConsentStatus statusInstance = ((ConsentStatus)(((int)statusValue)));
                                        securityPrincipalInfoInstance.Status = statusInstance;
                                    }
                                }
                            }
                        }
                        
                    }
                    result.StatusCode = statusCode;
                    if (httpResponse.Headers.Contains("x-ms-request-id"))
                    {
                        result.RequestId = httpResponse.Headers.GetValues("x-ms-request-id").FirstOrDefault();
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
