using System;
using System.Collections.Generic;
using System.Text;

namespace Apollo.OpenAssessments.ContentManagement.Domain.Common
{
    public class AuditableEntity
    {
        public Guid CreatedBy { get; set; }
        public DateTime Created { get; set; }
        public Guid LastModifiedBy { get; set; }
        public DateTime? LastModified { get; set; }
        public Guid DeletedBy { get; set; }
        public DateTime? Deleted { get; set; }
    }
}
