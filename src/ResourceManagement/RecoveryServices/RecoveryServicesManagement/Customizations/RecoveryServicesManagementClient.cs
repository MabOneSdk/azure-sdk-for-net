using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Hyak.Common;
using Microsoft.Azure;
using Microsoft.Azure.Management.RecoveryServices;
using Microsoft.Azure.Management.RecoveryServices.Models;
using Newtonsoft.Json.Linq;

namespace Microsoft.Azure.Management.RecoveryServices
{
    public partial class RecoveryServicesManagementClient
    {
        /// <summary>
        /// donot allow dispose incase the http client is shared.
        /// </summary>
        private bool donotAllowDispose = false;

        /// <summary>
        /// Initializes a new instance of the RecoveryServicesManagementClient
        /// class.
        /// </summary>
        /// <param name='resourceNamespace'>
        /// Required.
        /// </param>
        /// <param name='credentials'>
        /// Required. Gets subscription credentials which uniquely identify
        /// Microsoft Azure subscription. The subscription ID forms part of
        /// the URI for every service call.
        /// </param>
        /// <param name='baseUri'>
        /// Optional. Gets the URI used as the base for all cloud service
        /// requests.
        /// </param>
        /// <param name='httpClient'>
        /// The Http client
        /// </param>
        /// <param name='donotAllowDisposeOnHttpClient'>
        /// True if Http client is intended to be shared and not supposed to be disposed.
        /// </param>
        public RecoveryServicesManagementClient(string resourceNamespace, SubscriptionCloudCredentials credentials, Uri baseUri, HttpClient httpClient, bool donotAllowDisposeOnHttpClient)
            : base(httpClient)
        {
            if (resourceNamespace == null)
            {
                throw new ArgumentNullException("resourceNamespace");
            }
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            if (baseUri == null)
            {
                throw new ArgumentNullException("baseUri");
            }

            this._replicationUsages = new ReplicationUsagesOperations(this);
            this._resourceGroup = new ResourceGroupsOperations(this);
            this._vaultExtendedInfo = new VaultExtendedInfoOperations(this);
            this._vaults = new VaultOperations(this);
            this._vaultUsage = new VaultUsageOperations(this);
            this._apiVersion = "2015-01-01";
            this._longRunningOperationInitialTimeout = -1;
            this._longRunningOperationRetryTimeout = -1;

            // Set if the underneath http client is supposed to be disposed or not.
            this.donotAllowDispose = donotAllowDisposeOnHttpClient;
            this._resourceNamespace = resourceNamespace;
            this._credentials = credentials;
            this._baseUri = baseUri;

            this.Credentials.InitializeServiceClient(this);
        }

        /// <summary>
        ///  Override the dispose method.
        /// </summary>
        public override void Dispose()
        {
            if (this.donotAllowDispose)
            {
                return;
            }

            base.Dispose();
        }
    }
}