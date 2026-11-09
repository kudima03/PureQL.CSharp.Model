using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Parameters;

/// <summary>PureQL <c>param.time</c>.</summary>
public sealed record ParamTime : IParameter
{
    public ParamTime(string param)
    {
        Param = param;
    }

    public string Param { get; }

    public IType Type => new TypeTime();
}
