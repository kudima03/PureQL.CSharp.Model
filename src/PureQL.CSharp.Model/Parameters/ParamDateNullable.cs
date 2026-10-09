using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Parameters;

public sealed record ParamDateNullable : IParameter
{
    public ParamDateNullable(string name)
    {
        Name = name;
    }

    public string Name { get; }

    public IType Type => new TypeDateNullable();
}
