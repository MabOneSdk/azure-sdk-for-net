// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using System.Linq;

    /// <summary>
    /// Additional information on Azure SQL specific backup item.
    /// </summary>
    public partial class AzureSqlProtectedItemExtendedInfo
    {
        /// <summary>
        /// Initializes a new instance of the AzureSqlProtectedItemExtendedInfo
        /// class.
        /// </summary>
        public AzureSqlProtectedItemExtendedInfo() { }

        /// <summary>
        /// Initializes a new instance of the AzureSqlProtectedItemExtendedInfo
        /// class.
        /// </summary>
        /// <param name="oldestRecoveryPoint">The oldest backup copy available
        /// for this item in the service.</param>
        /// <param name="recoveryPointCount">Number of available backup copies
        /// associated with this backup item.</param>
        /// <param name="policyState">State of the backup policy associated
        /// with this backup item.</param>
        public AzureSqlProtectedItemExtendedInfo(System.DateTime? oldestRecoveryPoint = default(System.DateTime?), int? recoveryPointCount = default(int?), string policyState = default(string))
        {
            OldestRecoveryPoint = oldestRecoveryPoint;
            RecoveryPointCount = recoveryPointCount;
            PolicyState = policyState;
        }

        /// <summary>
        /// Gets or sets the oldest backup copy available for this item in the
        /// service.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "oldestRecoveryPoint")]
        public System.DateTime? OldestRecoveryPoint { get; set; }

        /// <summary>
        /// Gets or sets number of available backup copies associated with this
        /// backup item.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "recoveryPointCount")]
        public int? RecoveryPointCount { get; set; }

        /// <summary>
        /// Gets or sets state of the backup policy associated with this backup
        /// item.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "policyState")]
        public string PolicyState { get; set; }

    }
}
