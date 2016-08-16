using System.Collections.Generic;
using IdentityServer3.Core.Models;

namespace ShibbolethAuth.Identity
{
    public static class Scopes
    {
        public static IEnumerable<Scope> Get()
        {
            var scopes = new List<Scope>
            {
                new Scope
                {
                    Enabled = true,
                    Name = "saml",
                    Type = ScopeType.Identity,
                    Required = true,
                    Claims = new List<ScopeClaim>
                    {
                        new ScopeClaim("urn:oid:0.9.2342.19200300.100.1.1"),
                        new ScopeClaim("urn:oid:1.3.6.1.4.1.5923.1.1.1.6") { Description = "email" }
                    }
                }
            };

            scopes.AddRange(StandardScopes.All);

            return scopes;
        }
    }
}