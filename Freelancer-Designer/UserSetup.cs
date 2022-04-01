using System;
using Freelancer_Designer.Name;

namespace FreelaneApplication.UserSetup
{
    public class UserSetup : Name
    {
        public string userEmail { get; set; }
        public string userAddress { get; set; }
        public string userPhone { get; set; }

        public UserSetup(string UserEmail, string UserAddress, string UserPhone)
        {
            this.userEmail = UserEmail;
            this.userAddress = UserAddress;
            this.userPhone = UserPhone;
        }

        public UserSetup()
        {
            this.userEmail = string.Empty;
            this.userAddress = string.Empty;
            this.userPhone = string.Empty;
        }

        public UserSetup(string userEmail)
        {
            this.userEmail = userEmail;
        }


        public override string ToString()
        {
            return $"\nUser Information:\nUser Name: {userName},\n User Email: {this.userEmail},\n User Address: {this.userAddress},\n User Phone Number: {this.userPhone}.";

        }
    }
}
