using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Parameters;

public sealed record ParamDecimalNullable : IParameter
{
    public ParamDecimalNullable(string name)
    {
        Name = name;
    }

    public string Name { get; }

    public IType Type => new TypeDecimalNullable();
}
