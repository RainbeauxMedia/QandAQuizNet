//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QandaQuizEntityFramework
{
    using System;
    using System.Collections.Generic;
    
    public partial class QuizAnswer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public QuizAnswer()
        {
            this.QuizPlayDetails = new HashSet<QuizPlayDetail>();
        }
    
        public string quizAnswerText { get; set; }
        public bool quizAnswerCorrect { get; set; }
        public int quizQuestionId { get; set; }
        public int Id { get; set; }
    
        public virtual QuizQuestion QuizQuestion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QuizPlayDetail> QuizPlayDetails { get; set; }
    }
}
