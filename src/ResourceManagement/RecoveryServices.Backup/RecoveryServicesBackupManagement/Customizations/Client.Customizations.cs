using Microsoft.Azure.Management.RecoveryServices.Backup.Models;
using Microsoft.Rest;
using Microsoft.Rest.Serialization;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microsoft.Azure.Management.RecoveryServices.Backup
{
    public partial class RecoveryServicesBackupClient
    {
        /// <summary>
        /// donot allow dispose incase the http client is shared.
        /// </summary>
        public bool donotAllowDispose
        {
            get;set;
        }

        public void SetHttpClient(System.Net.Http.HttpClient client)
        {
            base.HttpClient = client;
        }

        public new void Dispose()
        {
            if (this.donotAllowDispose)
            {
                return;
            }

            base.Dispose();
        }

        partial void CustomInitialize()
        {
            var iso8601TimeSpanConverter = DeserializationSettings.Converters.First(conv => conv is Iso8601TimeSpanConverter);
            if (iso8601TimeSpanConverter != null)
            {
                DeserializationSettings.Converters.Remove(iso8601TimeSpanConverter);
            }
        }
    }
}