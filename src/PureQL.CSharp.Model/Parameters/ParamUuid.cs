using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Parameters;

public sealed record ParamUuid : IParameter
{
    public ParamUuid(string name)
    {
        Name = name;
    }

    public string Name { get; }

    public IType Type => new TypeUuid();
}
