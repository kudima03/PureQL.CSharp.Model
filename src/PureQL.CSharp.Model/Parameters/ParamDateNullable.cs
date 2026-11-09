using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Parameters;

/// <summary>PureQL <c>param.date.nullable</c>.</summary>
public sealed record ParamDateNullable : IParameter
{
    public ParamDateNullable(string param)
    {
        Param = param;
    }

    public string Param { get; }

    public IType Type => new TypeDateNullable();
}
