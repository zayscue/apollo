using System;
using System.Collections.Generic;
using System.Text;

namespace Apollo.OpenAssessments.ContentManagement.Domain.Entities
{
    public class QuestionTags
    {
        public Guid QuestionId { get; set; }
        public string Tag { get; set; }

        public Question Question { get; set; }
        public ContentTag ContentTag { get; set; }
    }
}
