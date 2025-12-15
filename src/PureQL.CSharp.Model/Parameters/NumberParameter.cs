using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Parameters;

public sealed record NumberParameter : IParameter
{
    public NumberParameter(string name)
    {
        Name = name;
    }

    public string Name { get; }

    public IType Type => new NumberType();
}
