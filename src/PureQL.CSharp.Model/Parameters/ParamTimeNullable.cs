using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Parameters;

/// <summary>PureQL <c>param.time.nullable</c>.</summary>
public sealed record ParamTimeNullable : IParameter
{
    public ParamTimeNullable(string param)
    {
        Param = param;
    }

    public string Param { get; }

    public IType Type => new TypeTimeNullable();
}
