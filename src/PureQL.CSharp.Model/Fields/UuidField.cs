using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Fields;

public sealed record UuidField : IField
{
    public UuidField(string entity, string field)
    {
        Entity = entity;
        Field = field;
    }

    public string Entity { get; }

    public string Field { get; }

    public IType Type => new UuidType();
}
