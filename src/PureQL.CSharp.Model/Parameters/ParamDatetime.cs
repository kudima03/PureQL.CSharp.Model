using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Parameters;

public sealed record ParamDatetime : IParameter
{
    public ParamDatetime(string name)
    {
        Name = name;
    }

    public string Name { get; }

    public IType Type => new TypeDatetime();
}
