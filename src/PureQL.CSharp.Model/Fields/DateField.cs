using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Fields;

public sealed record DateField : IField
{
    public DateField(string entity, string field)
    {
        Entity = entity;
        Field = field;
    }

    public string Entity { get; }

    public string Field { get; }

    public IType Type => new DateType();
}
