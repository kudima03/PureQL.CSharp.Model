using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Parameters;

public sealed record NullParameter : IParameter
{
    public NullParameter(string name)
    {
        Name = name;
    }

    public string Name { get; }

    public IType Type => new NullType();
}
