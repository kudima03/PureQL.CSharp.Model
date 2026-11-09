using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Parameters;

/// <summary>PureQL <c>param.datetime</c>.</summary>
public sealed record ParamDatetime : IParameter
{
    public ParamDatetime(string param)
    {
        Param = param;
    }

    public string Param { get; }

    public IType Type => new TypeDatetime();
}
