using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Parameters;

public sealed record BooleanParameter : IParameter
{
    public BooleanParameter(string name)
    {
        Name = name;
    }

    public string Name { get; }

    public IType Type => new BooleanType();
}
