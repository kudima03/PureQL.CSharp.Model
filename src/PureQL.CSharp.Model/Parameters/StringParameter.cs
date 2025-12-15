using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Parameters;

public sealed record StringParameter : IParameter
{
    public StringParameter(string name)
    {
        Name = name;
    }

    public string Name { get; }

    public IType Type => new StringType();
}
