using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Fields;

public sealed record BooleanField : IField
{
    public BooleanField(string entity, string field)
    {
        Entity = entity;
        Field = field;
    }

    public string Entity { get; }

    public string Field { get; }

    public IType Type => new BooleanType();
}
