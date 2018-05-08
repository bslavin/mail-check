﻿namespace Dmarc.Common.Api.Identity.Domain
{
    public class IdentityForCreation
    {
        public IdentityForCreation(string firstName, string lastName, string email, string roleType)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            RoleType = roleType;
        }

        public string FirstName { get; }
        public string LastName { get; }
        public string Email { get; }
        public string RoleType { get;}
    }
}