using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Parameters;

public sealed record DateTimeParameter : IParameter
{
    public DateTimeParameter(string name)
    {
        Name = name;
    }

    public string Name { get; }

    public IType Type => new DateTimeType();
}
