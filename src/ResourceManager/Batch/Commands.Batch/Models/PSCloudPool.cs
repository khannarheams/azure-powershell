﻿// -----------------------------------------------------------------------------
﻿//
﻿// Copyright Microsoft Corporation
﻿// Licensed under the Apache License, Version 2.0 (the "License");
﻿// you may not use this file except in compliance with the License.
﻿// You may obtain a copy of the License at
﻿// http://www.apache.org/licenses/LICENSE-2.0
﻿// Unless required by applicable law or agreed to in writing, software
﻿// distributed under the License is distributed on an "AS IS" BASIS,
﻿// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
﻿// See the License for the specific language governing permissions and
﻿// limitations under the License.
﻿// -----------------------------------------------------------------------------
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Azure.Commands.Batch.Models
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using Microsoft.Azure.Batch;
    
    
    public class PSCloudPool
    {
        
        internal Microsoft.Azure.Batch.ICloudPool omObject;
        
        private PSAutoScaleRun autoScaleRun;
        
        private IList<PSCertificateReference> certificateReferences;
        
        private IList<PSMetadataItem> metadata;
        
        private PSResizeError resizeError;
        
        private PSSchedulingPolicy schedulingPolicy;
        
        private PSStartTask startTask;
        
        private PSPoolStatistics statistics;
        
        internal PSCloudPool(Microsoft.Azure.Batch.ICloudPool omObject)
        {
            if ((omObject == null))
            {
                throw new System.ArgumentNullException("omObject");
            }
            this.omObject = omObject;
        }
        
        public Microsoft.Azure.Batch.Common.AllocationState AllocationState
        {
            get
            {
                return this.omObject.AllocationState;
            }
        }
        
        public System.DateTime? AllocationStateTransitionTime
        {
            get
            {
                return this.omObject.AllocationStateTransitionTime;
            }
        }
        
        public string AutoScaleFormula
        {
            get
            {
                return this.omObject.AutoScaleFormula;
            }
            set
            {
                this.omObject.AutoScaleFormula = value;
            }
        }
        
        public PSAutoScaleRun AutoScaleRun
        {
            get
            {
                if (((this.autoScaleRun == null) 
                            && (this.omObject.AutoScaleRun != null)))
                {
                    this.autoScaleRun = new PSAutoScaleRun(this.omObject.AutoScaleRun);
                }
                return this.autoScaleRun;
            }
        }
        
        public IList<PSCertificateReference> CertificateReferences
        {
            get
            {
                if (((this.certificateReferences == null) 
                            && (this.omObject.CertificateReferences != null)))
                {
                    List<PSCertificateReference> list;
                    list = new List<PSCertificateReference>();
                    IEnumerator<Microsoft.Azure.Batch.ICertificateReference> enumerator;
                    enumerator = this.omObject.CertificateReferences.GetEnumerator();
                    for (
                    ; enumerator.MoveNext(); 
                    )
                    {
                        list.Add(new PSCertificateReference(enumerator.Current));
                    }
                    this.certificateReferences = list;
                }
                return this.certificateReferences;
            }
            set
            {
                if ((value == null))
                {
                    this.omObject.CertificateReferences = null;
                }
                else
                {
                    this.omObject.CertificateReferences = new List<Microsoft.Azure.Batch.ICertificateReference>();
                }
                this.certificateReferences = value;
            }
        }
        
        public System.Boolean? Communication
        {
            get
            {
                return this.omObject.Communication;
            }
            set
            {
                this.omObject.Communication = value;
            }
        }
        
        public System.DateTime CreationTime
        {
            get
            {
                return this.omObject.CreationTime;
            }
        }
        
        public System.Int32? CurrentDedicated
        {
            get
            {
                return this.omObject.CurrentDedicated;
            }
        }
        
        public string CurrentOSVersion
        {
            get
            {
                return this.omObject.CurrentOSVersion;
            }
        }
        
        public System.Boolean? AutoScaleEnabled
        {
            get
            {
                return this.omObject.AutoScaleEnabled;
            }
            set
            {
                this.omObject.AutoScaleEnabled = value;
            }
        }
        
        public System.DateTime LastModified
        {
            get
            {
                return this.omObject.LastModified;
            }
        }
        
        public System.Int32? MaxTasksPerVM
        {
            get
            {
                return this.omObject.MaxTasksPerVM;
            }
            set
            {
                this.omObject.MaxTasksPerVM = value;
            }
        }
        
        public IList<PSMetadataItem> Metadata
        {
            get
            {
                if (((this.metadata == null) 
                            && (this.omObject.Metadata != null)))
                {
                    List<PSMetadataItem> list;
                    list = new List<PSMetadataItem>();
                    IEnumerator<Microsoft.Azure.Batch.IMetadataItem> enumerator;
                    enumerator = this.omObject.Metadata.GetEnumerator();
                    for (
                    ; enumerator.MoveNext(); 
                    )
                    {
                        list.Add(new PSMetadataItem(enumerator.Current));
                    }
                    this.metadata = list;
                }
                return this.metadata;
            }
            set
            {
                if ((value == null))
                {
                    this.omObject.Metadata = null;
                }
                else
                {
                    this.omObject.Metadata = new List<Microsoft.Azure.Batch.IMetadataItem>();
                }
                this.metadata = value;
            }
        }
        
        public string Name
        {
            get
            {
                return this.omObject.Name;
            }
            set
            {
                this.omObject.Name = value;
            }
        }
        
        public string OSFamily
        {
            get
            {
                return this.omObject.OSFamily;
            }
            set
            {
                this.omObject.OSFamily = value;
            }
        }
        
        public PSResizeError ResizeError
        {
            get
            {
                if (((this.resizeError == null) 
                            && (this.omObject.ResizeError != null)))
                {
                    this.resizeError = new PSResizeError(this.omObject.ResizeError);
                }
                return this.resizeError;
            }
        }
        
        public System.TimeSpan? ResizeTimeout
        {
            get
            {
                return this.omObject.ResizeTimeout;
            }
            set
            {
                this.omObject.ResizeTimeout = value;
            }
        }
        
        public PSSchedulingPolicy SchedulingPolicy
        {
            get
            {
                if (((this.schedulingPolicy == null) 
                            && (this.omObject.SchedulingPolicy != null)))
                {
                    this.schedulingPolicy = new PSSchedulingPolicy(this.omObject.SchedulingPolicy);
                }
                return this.schedulingPolicy;
            }
            set
            {
                if ((value == null))
                {
                    this.omObject.SchedulingPolicy = null;
                }
                else
                {
                    this.omObject.SchedulingPolicy = value.omObject;
                }
                this.schedulingPolicy = value;
            }
        }
        
        public PSStartTask StartTask
        {
            get
            {
                if (((this.startTask == null) 
                            && (this.omObject.StartTask != null)))
                {
                    this.startTask = new PSStartTask(this.omObject.StartTask);
                }
                return this.startTask;
            }
            set
            {
                if ((value == null))
                {
                    this.omObject.StartTask = null;
                }
                else
                {
                    this.omObject.StartTask = value.omObject;
                }
                this.startTask = value;
            }
        }
        
        public Microsoft.Azure.Batch.Common.PoolState State
        {
            get
            {
                return this.omObject.State;
            }
        }
        
        public System.DateTime StateTransitionTime
        {
            get
            {
                return this.omObject.StateTransitionTime;
            }
        }
        
        public PSPoolStatistics Statistics
        {
            get
            {
                if (((this.statistics == null) 
                            && (this.omObject.Statistics != null)))
                {
                    this.statistics = new PSPoolStatistics(this.omObject.Statistics);
                }
                return this.statistics;
            }
        }
        
        public System.Int32? TargetDedicated
        {
            get
            {
                return this.omObject.TargetDedicated;
            }
            set
            {
                this.omObject.TargetDedicated = value;
            }
        }
        
        public string TargetOSVersion
        {
            get
            {
                return this.omObject.TargetOSVersion;
            }
            set
            {
                this.omObject.TargetOSVersion = value;
            }
        }
        
        public string VMSize
        {
            get
            {
                return this.omObject.VMSize;
            }
            set
            {
                this.omObject.VMSize = value;
            }
        }
        
        public string Url
        {
            get
            {
                return this.omObject.Url;
            }
        }
    }
}
