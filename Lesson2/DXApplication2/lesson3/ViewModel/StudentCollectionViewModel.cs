using DevExpress.Mvvm.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson3
{
    class StudentCollectionViewModel
    {
        public StudentCollectionViewModel()
        {
            GroupList.Add(new Group { Name = "BPI" });
            GroupList.Add(new Group { Name = "BIS" });
            GroupList.Add(new Group { Name = "BIK" });
        }

        [BindableProperty]
        public virtual ObservableCollection<Student> StudentList { get; set; }
        public virtual ObservableCollection<Student> ExpilledList { get; set; }
        public virtual ObservableCollection<Group> GroupList { get; set; }


        [BindableProperty]
        public virtual Student CurrentStudent { get; set; }
        [Command]
        public void NewStudent()
        {
            StudentList.Add(new Student());
        }
        [Command]
        public void DeleteStudent(Student stud)
        {
            StudentList.Single(w => w.Id == stud.Id).IsRemoved = true;
        }
        [Command]
        public void EditStudent(Student stud)
        {

        }
        [Command]
        public void StudentOnExpulsion(Student stud)
        {
            ExpilledList.Add(stud);
            StudentList.Remove(stud);
        }


    }
}
