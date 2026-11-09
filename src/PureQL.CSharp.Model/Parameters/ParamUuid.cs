using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Parameters;

/// <summary>PureQL <c>param.uuid</c>.</summary>
public sealed record ParamUuid : IParameter
{
    public ParamUuid(string param)
    {
        Param = param;
    }

    public string Param { get; }

    public IType Type => new TypeUuid();
}
