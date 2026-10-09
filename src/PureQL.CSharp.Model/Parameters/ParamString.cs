using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Parameters;

public sealed record ParamString : IParameter
{
    public ParamString(string name)
    {
        Name = name;
    }

    public string Name { get; }

    public IType Type => new TypeString();
}
