using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Parameters;

public sealed record ParamDecimal : IParameter
{
    public ParamDecimal(string name)
    {
        Name = name;
    }

    public string Name { get; }

    public IType Type => new TypeDecimal();
}
