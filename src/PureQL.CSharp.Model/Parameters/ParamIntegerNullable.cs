using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Parameters;

public sealed record ParamIntegerNullable : IParameter
{
    public ParamIntegerNullable(string name)
    {
        Name = name;
    }

    public string Name { get; }

    public IType Type => new TypeIntegerNullable();
}
