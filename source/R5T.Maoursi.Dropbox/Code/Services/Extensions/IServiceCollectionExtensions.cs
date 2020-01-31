using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Bulgaria.UserProfileDirectory;
using R5T.Dacia;
using R5T.Kalamaria.Standard;
using R5T.Lombardy.Standard;

using R5T.Maoursi.Bulgaria;


namespace R5T.Maoursi.Dropbox
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="IOrganizationsDirectoryPathProvider"/> service.
        /// </summary>
        public static IServiceCollection AddOrganizationsDirectoryPathProvider(this IServiceCollection services)
        {
            services.AddDropboxOrganizationsDirectoryPathProvider(
                services.AddDropboxDirectoryPathProviderAction(),
                services.AddOrganizationsDirectoryNameConventionAction(),
                services.AddStringlyTypedPathOperatorAction())
                ;

            return services;
        }

        /// <summary>
        /// Adds the <see cref="IOrganizationsDirectoryPathProvider"/> service.
        /// </summary>
        public static ServiceAction<IOrganizationsDirectoryPathProvider> AddOrganizationsDirectoryPathProviderAction(this IServiceCollection services)
        {
            var serviceProvider = new ServiceAction<IOrganizationsDirectoryPathProvider>(() => services.AddOrganizationsDirectoryPathProvider());
            return serviceProvider;
        }
    }
}
