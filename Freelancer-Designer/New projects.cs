using System;
using Freelancer_Designer.Name;

namespace FreelaneApplication.AddNewProjects
{

    public class NewProjects: Name

    {
        
        public string projectName { get; set; }
        public string clientEmail { get; set; }
        public int projectPrice { get; set; }
        public DateTime projectDeadline { get; set; }
        public string projectDescription { get; set; }
        public int projectSize { get; set; }
        public string concludingNotes { get; set; }


        public NewProjects(string ProjectName, string ClientEmail, int ProjectPrice, DateTime ProjectDeadline, string ProjectDescription, int ProjectSize, string ConcludingNotes)
        {
            this.projectName = ProjectName;
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

        public override string ToString()
        {
            return $"\nProject Name: {projectName},\n Client Name: {this.clientName},\n Client Email: {this.clientEmail},\n Project Price: {this.projectPrice},\n Project Deadline: {this.projectDeadline},\n Project Description: {this.projectDescription},\n Project Size {this.projectSize},\n Concluding Notes: {this.concludingNotes}.".ToString();
        }
        public string ToArray()
        {

            return Convert.ToString($"\n{projectName}: {this.projectDeadline}.").ToString();

        }
    }
}