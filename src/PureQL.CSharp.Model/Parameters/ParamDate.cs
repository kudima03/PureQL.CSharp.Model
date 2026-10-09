using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Parameters;

public sealed record ParamDate : IParameter
{
    public ParamDate(string name)
    {
        Name = name;
    }

    public string Name { get; }

    public IType Type => new TypeDate();
}
