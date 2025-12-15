using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Parameters;

public sealed record DateParameter : IParameter
{
    public DateParameter(string name)
    {
        Name = name;
    }

    public string Name { get; }

    public IType Type => new DateType();
}
