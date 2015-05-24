using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy
{
    public enum State
    {
        Open,Closed
    }
    class Project
    {
        private string projectName;
        private DateTime startProjectDate;
        private string details;
        private State state;

        public Project(string projectName, DateTime startProjectDate, string details, State state)
        {
            this.ProjectName = projectName;
            this.StartProjectDate = startProjectDate;
            this.Details = details;
            this.state = state;
        }

        public string  ProjectName
        {
            get
            {
                return this.projectName;
            }
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid project name!");
                }
                this.projectName = value;
            }
        }

        public DateTime StartProjectDate 
        {
            get
            {
                return this.startProjectDate;
            }
            set
            {
                this.startProjectDate = value;
            }
        }

        public string Details
        {
            get
            {
                return this.details;
            }
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid details!");
                }
                this.details = value;
            }
        }

        public void ClosedProject()
        {
            this.state = State.Closed;
        }

        public  void toString()
        {
            Console.WriteLine("Project name: {0},\nStart date: {1},\nDetails: {2},\nState: {3}", this.projectName, this.startProjectDate, this.details, this.state);
        }
        
    }
}
