using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone2
{
    class Tasks
    {
        #region fields
        private string name;
        private string description;
        private string dueDate;
        private bool completed;
        
        #endregion

        #region properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public string DueDate
        {
            get { return dueDate; }
            set { dueDate = value; }
        }
        public bool Completed
        {
            get { return completed; }
            set { completed = value; }
        }
        
        #endregion

        #region constructors
        public Tasks() { }

        public Tasks( string Name, string Description, string DueDate, bool Completed)
        {
            
            name = Name;
            description = Description;
            dueDate = DueDate;
            completed = Completed;
            
        }
        #endregion

        public void Completion()
        {
            completed = true;
        }
    }
}
