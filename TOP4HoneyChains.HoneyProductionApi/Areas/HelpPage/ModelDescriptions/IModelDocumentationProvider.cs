using System;
using System.Reflection;

namespace TOP4HoneyChains.HoneyProductionApi.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}