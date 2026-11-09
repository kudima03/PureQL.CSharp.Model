using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Parameters;

/// <summary>PureQL <c>param.uuid.nullable</c>.</summary>
public sealed record ParamUuidNullable : IParameter
{
    public ParamUuidNullable(string param)
    {
        Param = param;
    }

    public string Param { get; }

    public IType Type => new TypeUuidNullable();
}
