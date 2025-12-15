using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Parameters;

public sealed record UuidParameter : IParameter
{
    public UuidParameter(string name)
    {
        Name = name;
    }

    public string Name { get; }

    public IType Type => new UuidType();
}
