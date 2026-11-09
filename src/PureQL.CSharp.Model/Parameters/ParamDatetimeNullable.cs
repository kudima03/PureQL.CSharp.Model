using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Parameters;

/// <summary>PureQL <c>param.datetime.nullable</c>.</summary>
public sealed record ParamDatetimeNullable : IParameter
{
    public ParamDatetimeNullable(string param)
    {
        Param = param;
    }

    public string Param { get; }

    public IType Type => new TypeDatetimeNullable();
}
