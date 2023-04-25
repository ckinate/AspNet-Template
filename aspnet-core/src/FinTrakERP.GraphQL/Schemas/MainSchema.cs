using Abp.Dependency;
using GraphQL.Types;
using GraphQL.Utilities;
using FinTrakERP.Queries.Container;
using System;

namespace FinTrakERP.Schemas
{
    public class MainSchema : Schema, ITransientDependency
    {
        public MainSchema(IServiceProvider provider) :
            base(provider)
        {
            Query = provider.GetRequiredService<QueryContainer>();
        }
    }
}