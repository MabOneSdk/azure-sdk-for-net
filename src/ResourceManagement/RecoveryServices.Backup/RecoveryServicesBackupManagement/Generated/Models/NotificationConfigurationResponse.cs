// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using System.Linq;

    /// <summary>
    /// Notification configuration response.
    /// </summary>
    public partial class NotificationConfigurationResponse
    {
        /// <summary>
        /// Initializes a new instance of the NotificationConfigurationResponse
        /// class.
        /// </summary>
        public NotificationConfigurationResponse() { }

        /// <summary>
        /// Initializes a new instance of the NotificationConfigurationResponse
        /// class.
        /// </summary>
        /// <param name="id">Fully qualified ARM URI of the resource. Eg:
        /// “/subscriptions/{id}/resourceGroups/{group}/providers/Microsoft.Backup/backupVault/{resourceName}/containers/{name}”,</param>
        /// <param name="name">Unique name of the resource. This name should
        /// match with the last segment of id.</param>
        /// <param name="type">ARM type of the resource. Eg:
        /// "Microsoft.Backup/backupVault/containers"</param>
        public NotificationConfigurationResponse(NotificationConfiguration properties = default(NotificationConfiguration), string id = default(string), string name = default(string), string type = default(string))
        {
            Properties = properties;
            Id = id;
            Name = name;
            Type = type;
        }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties")]
        public NotificationConfiguration Properties { get; set; }

        /// <summary>
        /// Gets or sets fully qualified ARM URI of the resource. Eg:
        /// “/subscriptions/{id}/resourceGroups/{group}/providers/Microsoft.Backup/backupVault/{resourceName}/containers/{name}”,
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets unique name of the resource. This name should match
        /// with the last segment of id.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets ARM type of the resource. Eg:
        /// "Microsoft.Backup/backupVault/containers"
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

    }
}
