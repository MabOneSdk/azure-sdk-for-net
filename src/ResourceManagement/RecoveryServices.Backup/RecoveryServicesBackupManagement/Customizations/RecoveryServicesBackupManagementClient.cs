using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Hyak.Common;
using Microsoft.Azure;
using Microsoft.Azure.Management.RecoveryServices.Backup;
using Microsoft.Azure.Management.RecoveryServices.Backup.Models;
using Newtonsoft.Json.Linq;

namespace Microsoft.Azure.Management.RecoveryServices.Backup
{
    public partial class RecoveryServicesBackupManagementClient
    {
        /// <summary>
        /// donot allow dispose incase the http client is shared.
        /// </summary>
        private bool donotAllowDispose = false;

        /// <summary>
        /// Initializes a new instance of the
        /// RecoveryServicesBackupManagementClient class.
        /// </summary>
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
        public RecoveryServicesBackupManagementClient(SubscriptionCloudCredentials credentials, Uri baseUri, HttpClient httpClient, bool donotAllowDisposeOnHttpClient)
            : base(httpClient)
        {
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            if (baseUri == null)
            {
                throw new ArgumentNullException("baseUri");
            }

            this._alertConfigurations = new AlertConfigurationOperations(this);
            this._alerts = new AlertOperations(this);
            this._backupEngines = new BackupEngineOperations(this);
            this._backups = new BackupOperations(this);
            this._containers = new ContainerOperations(this);
            this._fileFolderRestores = new FileFolderRestoreOperations(this);
            this._jobs = new JobOperations(this);
            this._protectableObjects = new ProtectableObjectOperations(this);
            this._protectedItems = new ProtectedItemOperations(this);
            this._protectionPolicies = new ProtectionPolicyOperations(this);
            this._recoveryPoints = new RecoveryPointOperations(this);
            this._restores = new RestoreOperations(this);
            this._resourceNamespace = "Microsoft.RecoveryServices";
            this._apiVersion = "2015-03-15";
            this._longRunningOperationInitialTimeout = -1;
            this._longRunningOperationRetryTimeout = -1;

            // Set if the underneath http client is supposed to be disposed or not.
            this.donotAllowDispose = donotAllowDisposeOnHttpClient;
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
                throw new Exception("Dispose is not allowed on this object as the HTTP client underneath is shared");
            }

            base.Dispose();
        }
    }
}