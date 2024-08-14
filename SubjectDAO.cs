using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace subjectmanager
{
    internal class SubjectDAO
    {
        private List<Subject> subjects = new List<Subject>();
        public void AddSubject(Subject subject) { subjects.Add(subject); }
        public List<Subject> GetSubjects() { return new List<Subject>(subjects); }
    }
}
