// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using System.Linq;

    /// <summary>
    /// MAB workload-specific job.
    /// </summary>
    public partial class MabJob : Job
    {
        /// <summary>
        /// Initializes a new instance of the MabJob class.
        /// </summary>
        public MabJob() { }

        /// <summary>
        /// Initializes a new instance of the MabJob class.
        /// </summary>
        /// <param name="entityFriendlyName">Friendly name of the entity on
        /// which the current job is executing.</param>
        /// <param name="backupManagementType">Backup management type to
        /// execute the current job. Possible values include: 'Invalid',
        /// 'AzureIaasVM', 'MAB', 'DPM', 'AzureBackupServer',
        /// 'AzureSql'</param>
        /// <param name="operation">The operation name.</param>
        /// <param name="status">Job status.</param>
        /// <param name="startTime">The start time.</param>
        /// <param name="endTime">The end time.</param>
        /// <param name="activityId">ActivityId of job.</param>
        /// <param name="duration">Time taken by job to run.</param>
        /// <param name="actionsInfo">The state/actions applicable on jobs like
        /// cancel/retry.</param>
        /// <param name="mabServerName">Name of server protecting the
        /// DS.</param>
        /// <param name="mabServerType">Server type of MAB container. Possible
        /// values include: 'Invalid', 'Unknown', 'IaasVMContainer',
        /// 'IaasVMServiceContainer', 'DPMContainer', 'DPMVenusContainer',
        /// 'MABContainer', 'ClusterResource', 'AzureSqlContainer',
        /// 'WindowsServer', 'Windows'</param>
        /// <param name="workloadType">Workload type of backup item. Possible
        /// values include: 'Invalid', 'VM', 'FileFolder', 'AzureSqlDb',
        /// 'SQLDB', 'Exchange', 'Sharepoint', 'DPMUnknown'</param>
        /// <param name="errorDetails">The errors.</param>
        /// <param name="extendedInfo">Additional information on the
        /// job.</param>
        public MabJob(string entityFriendlyName = default(string), string backupManagementType = default(string), string operation = default(string), string status = default(string), System.DateTime? startTime = default(System.DateTime?), System.DateTime? endTime = default(System.DateTime?), string activityId = default(string), System.TimeSpan? duration = default(System.TimeSpan?), System.Collections.Generic.IList<JobSupportedAction?> actionsInfo = default(System.Collections.Generic.IList<JobSupportedAction?>), string mabServerName = default(string), MabServerType? mabServerType = default(MabServerType?), WorkloadType? workloadType = default(WorkloadType?), System.Collections.Generic.IList<MabErrorInfo> errorDetails = default(System.Collections.Generic.IList<MabErrorInfo>), MabJobExtendedInfo extendedInfo = default(MabJobExtendedInfo))
            : base(entityFriendlyName, backupManagementType, operation, status, startTime, endTime, activityId)
        {
            Duration = duration;
            ActionsInfo = actionsInfo;
            MabServerName = mabServerName;
            MabServerType = mabServerType;
            WorkloadType = workloadType;
            ErrorDetails = errorDetails;
            ExtendedInfo = extendedInfo;
        }

        /// <summary>
        /// Gets or sets time taken by job to run.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "duration")]
        public System.TimeSpan? Duration { get; set; }

        /// <summary>
        /// Gets or sets the state/actions applicable on jobs like
        /// cancel/retry.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "actionsInfo")]
        public System.Collections.Generic.IList<JobSupportedAction?> ActionsInfo { get; set; }

        /// <summary>
        /// Gets or sets name of server protecting the DS.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "mabServerName")]
        public string MabServerName { get; set; }

        /// <summary>
        /// Gets or sets server type of MAB container. Possible values include:
        /// 'Invalid', 'Unknown', 'IaasVMContainer', 'IaasVMServiceContainer',
        /// 'DPMContainer', 'DPMVenusContainer', 'MABContainer',
        /// 'ClusterResource', 'AzureSqlContainer', 'WindowsServer', 'Windows'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "mabServerType")]
        public MabServerType? MabServerType { get; set; }

        /// <summary>
        /// Gets or sets workload type of backup item. Possible values include:
        /// 'Invalid', 'VM', 'FileFolder', 'AzureSqlDb', 'SQLDB', 'Exchange',
        /// 'Sharepoint', 'DPMUnknown'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "workloadType")]
        public WorkloadType? WorkloadType { get; set; }

        /// <summary>
        /// Gets or sets the errors.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "errorDetails")]
        public System.Collections.Generic.IList<MabErrorInfo> ErrorDetails { get; set; }

        /// <summary>
        /// Gets or sets additional information on the job.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "extendedInfo")]
        public MabJobExtendedInfo ExtendedInfo { get; set; }

    }
}
