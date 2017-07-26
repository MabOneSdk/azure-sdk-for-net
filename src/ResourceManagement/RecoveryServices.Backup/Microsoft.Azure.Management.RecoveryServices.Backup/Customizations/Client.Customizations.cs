using System.Linq;
using System.Net.Http;
using Microsoft.Rest.Serialization;

namespace Microsoft.Azure.Management.RecoveryServices.Backup
{
    public partial class RecoveryServicesBackupClient
    {
        /// <summary>
        /// Don't allow dispose in case the http client is shared.
        /// </summary>
        public bool DisableDispose { get; set; }

        public void SetHttpClient(HttpClient client)
        {
            HttpClient = client;
        }

        public new void Dispose()
        {
            if (!DisableDispose)
            {
                base.Dispose();
            }
        }

        partial void CustomInitialize()
        {
        }
    }
}
