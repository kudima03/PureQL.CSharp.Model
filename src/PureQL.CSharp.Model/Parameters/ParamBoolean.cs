using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Parameters;

/// <summary>PureQL <c>param.boolean</c>.</summary>
public sealed record ParamBoolean : IParameter
{
    public ParamBoolean(string param)
    {
        Param = param;
    }

    public string Param { get; }

    public IType Type => new TypeBoolean();
}
