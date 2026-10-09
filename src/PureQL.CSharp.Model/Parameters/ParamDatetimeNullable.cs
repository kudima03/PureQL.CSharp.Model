using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Parameters;

public sealed record ParamDatetimeNullable : IParameter
{
    public ParamDatetimeNullable(string name)
    {
        Name = name;
    }

    public string Name { get; }

    public IType Type => new TypeDatetimeNullable();
}
