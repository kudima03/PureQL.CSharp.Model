using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Parameters;

public sealed record ParamStringNullable : IParameter
{
    public ParamStringNullable(string name)
    {
        Name = name;
    }

    public string Name { get; }

    public IType Type => new TypeStringNullable();
}
