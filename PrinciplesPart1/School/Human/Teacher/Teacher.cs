﻿namespace School
{
    using System.Collections.Generic;

    public class Teacher : Human
    {
        private List<Discipline> setOfDisciplines;

        public Teacher(string name):base(name)
        {
             this.setOfDisciplines = new List<Discipline>();
        }
      
        public List<Discipline>SetOfDisciplines
        {
            get { return this.setOfDisciplines; }
            set { this.setOfDisciplines = value; }
        }

        public void AddDisciplines(Discipline disciplineType)
        {
            this.setOfDisciplines.Add(disciplineType);
        }

    }
}
