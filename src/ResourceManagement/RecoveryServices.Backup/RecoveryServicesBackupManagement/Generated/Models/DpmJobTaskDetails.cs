// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using System.Linq;

    /// <summary>
    /// DPM workload-specific job task details.
    /// </summary>
    public partial class DpmJobTaskDetails
    {
        /// <summary>
        /// Initializes a new instance of the DpmJobTaskDetails class.
        /// </summary>
        public DpmJobTaskDetails() { }

        /// <summary>
        /// Initializes a new instance of the DpmJobTaskDetails class.
        /// </summary>
        /// <param name="taskId">The task display name.</param>
        /// <param name="startTime">The start time.</param>
        /// <param name="endTime">The end time.</param>
        /// <param name="duration">Time elapsed for task.</param>
        /// <param name="status">The status.</param>
        public DpmJobTaskDetails(string taskId = default(string), System.DateTime? startTime = default(System.DateTime?), System.DateTime? endTime = default(System.DateTime?), System.TimeSpan? duration = default(System.TimeSpan?), string status = default(string))
        {
            TaskId = taskId;
            StartTime = startTime;
            EndTime = endTime;
            Duration = duration;
            Status = status;
        }

        /// <summary>
        /// Gets or sets the task display name.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "taskId")]
        public string TaskId { get; set; }

        /// <summary>
        /// Gets or sets the start time.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "startTime")]
        public System.DateTime? StartTime { get; set; }

        /// <summary>
        /// Gets or sets the end time.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "endTime")]
        public System.DateTime? EndTime { get; set; }

        /// <summary>
        /// Gets or sets time elapsed for task.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "duration")]
        public System.TimeSpan? Duration { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

    }
}
