using SchoolWebApp6_24.Models;

namespace SchoolWebApp6_24.ViewModels {
    public class GradesDropdownsViewModel {
        public IEnumerable<Student> Students { get; set; }
        public IEnumerable<Subject> Subjects { get; set; }
        public GradesDropdownsViewModel() {
            Students = new List<Student>();
            Subjects = new List<Subject>();
        }
    }
}
