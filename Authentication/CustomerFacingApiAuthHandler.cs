using System;
using System.Security.Claims;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace ThaniyasFarmerAppAPI.Authentication
{
    public class LandDetailFacingApiAuthHandler : AuthenticationHandler<AuthenticationSchemeOptions>
    {
        //private readonly LandDetailFacingDataContext _dataContext;
        private readonly IConfiguration _configurations;

        public LandDetailFacingApiAuthHandler(IOptionsMonitor<AuthenticationSchemeOptions> options, ILoggerFactory logger, UrlEncoder encoder, ISystemClock clock, IConfiguration configurations
            ) 
            : base(options, logger, encoder, clock)
        {
            //_dataContext = dataContext;
            _configurations = configurations;
        }

        protected override async Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            // Should we care about this request?            
            Request.Headers.TryGetValue(LandDetailFacingHeaderNames.ApiKeyValue, out var apiKeyValue);
            if (string.IsNullOrWhiteSpace(apiKeyValue))
            {
                return AuthenticateResult.Fail($"Authentication headers not provided. You must send a valid '{LandDetailFacingHeaderNames.ApiKeyValue}'");
            }

            // At this point we have values on both expected header keys, so we need to validate them            
            var apiKey = _configurations.GetValue<string>("apiKeyValue");//
            if (apiKey == null || apiKey.Equals(apiKeyValue, StringComparison.InvariantCultureIgnoreCase) == false)
            {
                return AuthenticateResult.Fail("Invalid Key Id or Key Value");
            }

            // So we have a valid key id/value pair, let's sign in our user
            var claimsIdentity = new ClaimsIdentity(AuthenticationSchema.Policy);
            claimsIdentity.AddClaim(new Claim(ClaimNames.ApiKeyId, apiKey.ToString()));
            var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);

            var ticket = new AuthenticationTicket(claimsPrincipal, AuthenticationSchema.Policy);
            return AuthenticateResult.Success(ticket);
        }
    }
}
