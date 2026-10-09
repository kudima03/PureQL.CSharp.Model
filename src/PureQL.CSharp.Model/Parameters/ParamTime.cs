using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Parameters;

public sealed record ParamTime : IParameter
{
    public ParamTime(string name)
    {
        Name = name;
    }

    public string Name { get; }

    public IType Type => new TypeTime();
}
