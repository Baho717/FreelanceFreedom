using System;
using FreelaneApplication.AddNewProjects;

namespace FreelaneApplication.CurrentProjects
{
    public interface ICurrentProjects
    {
        string ViewProject { get; set; }
        void ProjectName(string name);
        void ClientName(string name);
        void ClientEmail(string email);
        void ProjectPrice(Int32 price);
        void ProjectDeadline(DateTime timeline);
        void ProjectDescription(string descritpion);
        void ProjectSize(Int32 size);
        void ConcludingNotes(string notes);
    }
}

