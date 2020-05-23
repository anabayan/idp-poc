// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdentityModel;
using IdentityServer4.Test;
using System.Collections.Generic;
using System.Security.Claims;

namespace Eproducts.IDP
{
    public class TestUsers
    {
        public static List<TestUser> Users = new List<TestUser>
        {
            new TestUser{SubjectId = "56", Username = "kevin", Password = "kevin", 
                Claims = 
                {
                    new Claim(JwtClaimTypes.Name, "Kevin Sultz"),
                    new Claim(JwtClaimTypes.GivenName, "Kevin"),
                    new Claim(JwtClaimTypes.FamilyName, "Sultz"),
                    new Claim(JwtClaimTypes.Email, "KSultz@jcrinc.com"),
                    new Claim(JwtClaimTypes.EmailVerified, "true", ClaimValueTypes.Boolean)
                }
            },
            new TestUser{SubjectId = "85", Username = "darlene", Password = "darlene", 
                Claims = 
                {
                    new Claim(JwtClaimTypes.Name, "Darlene Luttmann"),
                    new Claim(JwtClaimTypes.GivenName, "Darlene"),
                    new Claim(JwtClaimTypes.FamilyName, "Luttmann"),
                    new Claim(JwtClaimTypes.Email, "dluttman@tenethealth.com"),
                    new Claim(JwtClaimTypes.EmailVerified, "true", ClaimValueTypes.Boolean)
                }
            }
        };
    }
}