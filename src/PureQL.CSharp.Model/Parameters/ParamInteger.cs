using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Parameters;

public sealed record ParamInteger : IParameter
{
    public ParamInteger(string name)
    {
        Name = name;
    }

    public string Name { get; }

    public IType Type => new TypeInteger();
}
