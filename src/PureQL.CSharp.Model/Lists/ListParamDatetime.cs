using PureQL.CSharp.Model.Parameters;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Lists;

public sealed record ListParamDatetime : IParameter
{
    public ListParamDatetime(string param)
    {
        Param = param;
    }

    public string Param { get; }

    public IType Type => new TypeDatetimeList();
}
