using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Parameters;

/// <summary>PureQL <c>param.string.nullable</c>.</summary>
public sealed record ParamStringNullable : IParameter
{
    public ParamStringNullable(string param)
    {
        Param = param;
    }

    public string Param { get; }

    public IType Type => new TypeStringNullable();
}
