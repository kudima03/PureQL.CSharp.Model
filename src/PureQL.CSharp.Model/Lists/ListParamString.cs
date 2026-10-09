using PureQL.CSharp.Model.Parameters;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Lists;

public sealed record ListParamString : IParameter
{
    public ListParamString(string name)
    {
        Name = name;
    }

    public string Name { get; }

    public IType Type => new TypeStringList();
}
