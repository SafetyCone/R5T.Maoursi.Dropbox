using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Bulgaria.UserProfileDirectory;
using R5T.Kalamaria.Standard;
using R5T.Lombardy.Standard;

using R5T.Maoursi.Bulgaria;


namespace R5T.Maoursi.Dropbox
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddDropboxOrganizationsDirectoryPathProvider(this IServiceCollection services)
        {
            services
                .AddSingleton<IOrganizationsDirectoryPathProvider, DropboxOrganizationsDirectoryPathProvider>()
                .AddOrganizationsDirectoryNameConvention()
                .AddDropboxDirectoryPathProvider()
                .AddStringlyTypedPathOperator()
                ;

            return services;
        }
    }
}
