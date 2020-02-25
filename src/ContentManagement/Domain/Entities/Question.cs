using System;
using System.Collections.Generic;
using Apollo.OpenAssessments.ContentManagement.Domain.Common;
using Apollo.OpenAssessments.ContentManagement.Domain.Enums;

namespace Apollo.OpenAssessments.ContentManagement.Domain.Entities
{
    public class Question : AuditableEntity
    {
        public Question()
        {
            Tags = new HashSet<ContentTag>();
            SupplementalMaterials = new HashSet<SupplementalMaterial>();
            Choices = new HashSet<Choice>();
        }

        public Guid Id { get; set; }
        public QuestionTypes QuestionType { get; set; }
        public string QuestionText { get; set; }
        public string Hint { get; set; }
        public QuestionDifficulties DifficultyLevel { get; set; }
        public string AnswerRationale { get; set; }

        public ICollection<ContentTag> Tags { get; set; }
        public ICollection<SupplementalMaterial> SupplementalMaterials { get; set; }
        public ICollection<Choice> Choices { get; set; }

    }
}
