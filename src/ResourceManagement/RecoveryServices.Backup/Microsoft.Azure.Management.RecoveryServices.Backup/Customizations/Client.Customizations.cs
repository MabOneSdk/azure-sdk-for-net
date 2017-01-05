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
            var iso8601TimeSpanConverter = DeserializationSettings.Converters.First(conv => conv is Iso8601TimeSpanConverter);
            if (iso8601TimeSpanConverter != null)
            {
                DeserializationSettings.Converters.Remove(iso8601TimeSpanConverter);
            }
        }
    }
}