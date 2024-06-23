using System.Diagnostics.CodeAnalysis;

namespace SchoolWebApp6_24.Models {
      public class Subject {
        public int Id { get; set; }
        [NotNull]
        public String Name { get; set; }
    }
}
