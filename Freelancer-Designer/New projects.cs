using System;

namespace FreelaneApplication.AddNewProjects
{
    public class NewProjects
    {
        private string projectName;
        private string clientName;
        private string clientEmail;
        private int projectPrice;
        private DateTime projectDeadline;
        private string projectDescription;
        private int projectSize;
        private string concludingNotes;

        public NewProjects(string ProjectName, string ClientName, string ClientEmail, int ProjectPrice, DateTime ProjectDeadline, string ProjectDescription, int ProjectSize, string ConcludingNotes)
        {
            this.projectName = ProjectName;
            this.clientName = ClientName;
            this.clientEmail = ClientEmail;
            this.projectPrice = ProjectPrice;
            this.projectDeadline = ProjectDeadline;
            this.projectDescription = ProjectDescription;
            this.projectSize = ProjectSize;
            this.concludingNotes = ConcludingNotes;
        }


        public NewProjects()
        {
            this.projectName = string.Empty;
            this.clientName = string.Empty;
            this.clientEmail = string.Empty;
            this.projectPrice = 0;
            this.projectDeadline = DateTime.Now;
            this.projectDescription = string.Empty;
            this.projectSize = 0;
            this.concludingNotes = string.Empty;
        }

        public NewProjects(string projectName)
        {
            this.projectName = projectName;
        }

        public string ProjectName
        {
            get { return projectName; }
            set { ProjectName = value; }
        }

        public string ClientName
        {
            get { return clientName; }
            set { ClientName = value; }
        }

        public string ClientEmail
        {
            get { return clientEmail; }
            set { ClientEmail = value; }
        }

        public double ProjectPrice
        {
            get { return projectPrice; }
            set { ProjectPrice = Convert.ToDouble(value); }
        }

        public DateTime ProjectDeadline
        {
            get { return projectDeadline; }
            set { ProjectDeadline = Convert.ToDateTime(value); }
        }

        public string ProjectDescription
        {
            get { return projectDescription; }
            set { ProjectDescription = value; }
        }

        public double ProjectSize
        {
            get { return projectSize; }
            set
            {
                { ProjectSize = Convert.ToInt32(value); }
            }
        }

        public string ConcludingNotes
        {
            get { return concludingNotes; }
            set { ConcludingNotes = value; }
        }

        internal void Add(NewProjects np)
        {
            Console.WriteLine(ProjectName, ProjectDescription);
        }
    }
}