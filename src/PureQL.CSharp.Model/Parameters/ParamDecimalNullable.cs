using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Parameters;

/// <summary>PureQL <c>param.decimal.nullable</c>.</summary>
public sealed record ParamDecimalNullable : IParameter
{
    public ParamDecimalNullable(string param)
    {
        Param = param;
    }

    public string Param { get; }

    public IType Type => new TypeDecimalNullable();
}
