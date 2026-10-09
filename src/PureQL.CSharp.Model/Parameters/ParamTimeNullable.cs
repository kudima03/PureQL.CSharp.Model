using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Parameters;

public sealed record ParamTimeNullable : IParameter
{
    public ParamTimeNullable(string name)
    {
        Name = name;
    }

    public string Name { get; }

    public IType Type => new TypeTimeNullable();
}
