using System;
using System.Reflection;

namespace HoNguyenThanhPhong_5951071074.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}