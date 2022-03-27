﻿using System;
using FreelaneApplication.AddNewProjects;

namespace Freelancer_Designer.Name
{
    public class Name
    {
        public string aName { get; set; }
        public string userName { get; set; }
        public string clientName { get; set; }

        public Name(string AName, string UserName, string ClientName)
        {
            this.aName = AName;
            this.userName = UserName;
            this.clientName= ClientName;

        }

        public Name()
        {
            this.aName = string.Empty;
        }
    }
}
