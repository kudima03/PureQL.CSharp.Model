using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Parameters;

public sealed record ParamUuidNullable : IParameter
{
    public ParamUuidNullable(string name)
    {
        Name = name;
    }

    public string Name { get; }

    public IType Type => new TypeUuidNullable();
}
