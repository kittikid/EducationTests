//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EducationTests.Base
{
    using System;
    using System.Collections.Generic;
    
    public partial class user_score
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public user_score()
        {
            this.user_tests = new HashSet<user_tests>();
        }
    
        public int id { get; set; }
        public Nullable<int> id_user { get; set; }
        public Nullable<int> id_test { get; set; }
        public string status { get; set; }
        public Nullable<int> progress { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public Nullable<System.TimeSpan> time_start { get; set; }
    
        public virtual question_table question_table { get; set; }
        public virtual Users Users { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<user_tests> user_tests { get; set; }
    }
}
