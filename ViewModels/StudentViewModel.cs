using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight.Command;
using System.Collections.ObjectModel;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ViewModels
{
    public class StudentViewModel
    {
        public ObservableCollection<Student> Students { get; set; }
        public string name { get; set; }
        public string zachet { get; set; }
        public Student SelectedStudent { get; set; }
        public object TitleOfNewStudent { get; private set; }

        public RelayCommand AddStudentCommand { get; set; }
        public RelayCommand DeleteStudentCommand { get; set; }
        public StudentViewModel()
        {
            Students = new ObservableCollection<Student>();
            AddStudentCommand = new RelayCommand(AddStudent);
            DeleteStudentCommand = new RelayCommand(DeleteStudent);
        }




        private void AddStudent()
        {
            Student NewStudent = new Student
            {
                name = name,
                zachet = zachet,
            };
            Students.Add(NewStudent);
        }
        private void DeleteStudent()

        {
            Students.Remove(SelectedStudent);
        }
    }
}