using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Parameters;

/// <summary>PureQL <c>param.date</c>.</summary>
public sealed record ParamDate : IParameter
{
    public ParamDate(string param)
    {
        Param = param;
    }

    public string Param { get; }

    public IType Type => new TypeDate();
}
