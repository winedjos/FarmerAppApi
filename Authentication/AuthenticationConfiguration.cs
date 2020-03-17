using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.DependencyInjection;

namespace ThaniyasFarmerAppAPI.Authentication
{
    public static class AuthenticationConfiguration
    {
        public static void AddAuthenticationAndAuthorization(this IServiceCollection services)
        {
            services.AddAuthentication()
                .AddScheme<AuthenticationSchemeOptions, LandDetailFacingApiAuthHandler>(AuthenticationSchema.Schema,
                    opts =>
                    {
                        // Do Nothing
                    });

            services.AddAuthorization(options =>
            {
                options.AddPolicy(AuthenticationSchema.Policy, policy =>
                {
                    policy.AddAuthenticationSchemes(AuthenticationSchema.Schema);
                    policy.RequireAuthenticatedUser();
                });
            });
        }
    }
}
