using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Parameters;

/// <summary>PureQL <c>param.boolean.nullable</c>.</summary>
public sealed record ParamBooleanNullable : IParameter
{
    public ParamBooleanNullable(string param)
    {
        Param = param;
    }

    public string Param { get; }

    public IType Type => new TypeBooleanNullable();
}
