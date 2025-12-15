using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Parameters;

public sealed record TimeParameter : IParameter
{
    public TimeParameter(string name)
    {
        Name = name;
    }

    public string Name { get; }

    public IType Type => new TimeType();
}
