using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Parameters;

/// <summary>PureQL <c>param.string</c>.</summary>
public sealed record ParamString : IParameter
{
    public ParamString(string param)
    {
        Param = param;
    }

    public string Param { get; }

    public IType Type => new TypeString();
}
