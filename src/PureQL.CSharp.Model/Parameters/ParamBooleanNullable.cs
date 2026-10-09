using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Parameters;

public sealed record ParamBooleanNullable : IParameter
{
    public ParamBooleanNullable(string name)
    {
        Name = name;
    }

    public string Name { get; }

    public IType Type => new TypeBooleanNullable();
}
