// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.Management.RecoveryServices.Backup;
using Microsoft.Azure.Management.RecoveryServices.Backup.Models;

namespace Microsoft.Azure.Management.RecoveryServices.Backup
{
    public static partial class AlertConfigurationOperationsExtensions
    {
        /// <summary>
        /// Get Alert notification configuration.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.RecoveryServices.Backup.IAlertConfigurationOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. ResourceGroupName for recoveryServices Vault.
        /// </param>
        /// <param name='resourceName'>
        /// Required. ResourceName for recoveryServices Vault.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// The definition of a NotificationConfigurationResponse.
        /// </returns>
        public static NotificationConfigurationResponse Get(this IAlertConfigurationOperations operations, string resourceGroupName, string resourceName, CustomRequestHeaders customRequestHeaders)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IAlertConfigurationOperations)s).GetAsync(resourceGroupName, resourceName, customRequestHeaders);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Get Alert notification configuration.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.RecoveryServices.Backup.IAlertConfigurationOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. ResourceGroupName for recoveryServices Vault.
        /// </param>
        /// <param name='resourceName'>
        /// Required. ResourceName for recoveryServices Vault.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// The definition of a NotificationConfigurationResponse.
        /// </returns>
        public static Task<NotificationConfigurationResponse> GetAsync(this IAlertConfigurationOperations operations, string resourceGroupName, string resourceName, CustomRequestHeaders customRequestHeaders)
        {
            return operations.GetAsync(resourceGroupName, resourceName, customRequestHeaders, CancellationToken.None);
        }
        
        /// <summary>
        /// Resolve the specific Alert.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.RecoveryServices.Backup.IAlertConfigurationOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. ResourceGroupName for recoveryServices Vault.
        /// </param>
        /// <param name='resourceName'>
        /// Required. ResourceName for recoveryServices Vault.
        /// </param>
        /// <param name='request'>
        /// Required. Update request for notificationConfiguration
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// The definition of a NotificationConfigurationResponse.
        /// </returns>
        public static NotificationConfigurationResponse Update(this IAlertConfigurationOperations operations, string resourceGroupName, string resourceName, ConfigureNotificationRequest request, CustomRequestHeaders customRequestHeaders)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IAlertConfigurationOperations)s).UpdateAsync(resourceGroupName, resourceName, request, customRequestHeaders);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Resolve the specific Alert.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.RecoveryServices.Backup.IAlertConfigurationOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. ResourceGroupName for recoveryServices Vault.
        /// </param>
        /// <param name='resourceName'>
        /// Required. ResourceName for recoveryServices Vault.
        /// </param>
        /// <param name='request'>
        /// Required. Update request for notificationConfiguration
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// The definition of a NotificationConfigurationResponse.
        /// </returns>
        public static Task<NotificationConfigurationResponse> UpdateAsync(this IAlertConfigurationOperations operations, string resourceGroupName, string resourceName, ConfigureNotificationRequest request, CustomRequestHeaders customRequestHeaders)
        {
            return operations.UpdateAsync(resourceGroupName, resourceName, request, customRequestHeaders, CancellationToken.None);
        }
    }
}