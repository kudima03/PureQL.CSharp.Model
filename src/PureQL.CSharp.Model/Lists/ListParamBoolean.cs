using PureQL.CSharp.Model.Parameters;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Lists;

public sealed record ListParamBoolean : IParameter
{
    public ListParamBoolean(string name)
    {
        Name = name;
    }

    public string Name { get; }

    public IType Type => new TypeBooleanList();
}
