using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Parameters;

/// <summary>PureQL <c>param.integer.nullable</c>.</summary>
public sealed record ParamIntegerNullable : IParameter
{
    public ParamIntegerNullable(string param)
    {
        Param = param;
    }

    public string Param { get; }

    public IType Type => new TypeIntegerNullable();
}
