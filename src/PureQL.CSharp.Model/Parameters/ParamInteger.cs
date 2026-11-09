using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Parameters;

/// <summary>PureQL <c>param.integer</c>.</summary>
public sealed record ParamInteger : IParameter
{
    public ParamInteger(string param)
    {
        Param = param;
    }

    public string Param { get; }

    public IType Type => new TypeInteger();
}
