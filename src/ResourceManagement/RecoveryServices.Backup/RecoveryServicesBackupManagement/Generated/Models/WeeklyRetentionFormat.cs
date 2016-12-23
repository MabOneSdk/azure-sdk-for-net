// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using System.Linq;

    /// <summary>
    /// Weekly retention format.
    /// </summary>
    public partial class WeeklyRetentionFormat
    {
        /// <summary>
        /// Initializes a new instance of the WeeklyRetentionFormat class.
        /// </summary>
        public WeeklyRetentionFormat() { }

        /// <summary>
        /// Initializes a new instance of the WeeklyRetentionFormat class.
        /// </summary>
        /// <param name="daysOfTheWeek">List of days of the week.</param>
        /// <param name="weeksOfTheMonth">List of weeks of month.</param>
        public WeeklyRetentionFormat(System.Collections.Generic.IList<DayOfWeek?> daysOfTheWeek = default(System.Collections.Generic.IList<DayOfWeek?>), System.Collections.Generic.IList<WeekOfMonth?> weeksOfTheMonth = default(System.Collections.Generic.IList<WeekOfMonth?>))
        {
            DaysOfTheWeek = daysOfTheWeek;
            WeeksOfTheMonth = weeksOfTheMonth;
        }

        /// <summary>
        /// Gets or sets list of days of the week.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "daysOfTheWeek")]
        public System.Collections.Generic.IList<DayOfWeek?> DaysOfTheWeek { get; set; }

        /// <summary>
        /// Gets or sets list of weeks of month.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "weeksOfTheMonth")]
        public System.Collections.Generic.IList<WeekOfMonth?> WeeksOfTheMonth { get; set; }

    }
}
