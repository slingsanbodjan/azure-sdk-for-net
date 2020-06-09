// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> Deployment on error behavior with additional details. </summary>
    public partial class OnErrorDeploymentExtended
    {
        /// <summary> Initializes a new instance of OnErrorDeploymentExtended. </summary>
        internal OnErrorDeploymentExtended()
        {
        }

        /// <summary> Initializes a new instance of OnErrorDeploymentExtended. </summary>
        /// <param name="provisioningState"> The state of the provisioning for the on error deployment. </param>
        /// <param name="type"> The deployment on error behavior type. Possible values are LastSuccessful and SpecificDeployment. </param>
        /// <param name="deploymentName"> The deployment to be used on error case. </param>
        internal OnErrorDeploymentExtended(string provisioningState, OnErrorDeploymentType? type, string deploymentName)
        {
            ProvisioningState = provisioningState;
            Type = type;
            DeploymentName = deploymentName;
        }

        /// <summary> The state of the provisioning for the on error deployment. </summary>
        public string ProvisioningState { get; }
        /// <summary> The deployment on error behavior type. Possible values are LastSuccessful and SpecificDeployment. </summary>
        public OnErrorDeploymentType? Type { get; }
        /// <summary> The deployment to be used on error case. </summary>
        public string DeploymentName { get; }
    }
}