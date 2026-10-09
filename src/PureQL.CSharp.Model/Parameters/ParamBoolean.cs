using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Parameters;

public sealed record ParamBoolean : IParameter
{
    public ParamBoolean(string name)
    {
        Name = name;
    }

    public string Name { get; }

    public IType Type => new TypeBoolean();
}
