using OneOf;

namespace PureQL.CSharp.Model.Fields;

public sealed class FieldAsTimeNullable : OneOfBase<FieldTime, FieldTimeNullable>
{
    public FieldAsTimeNullable(FieldTime value)
        : this((OneOf<FieldTime, FieldTimeNullable>)value) { }

    public FieldAsTimeNullable(FieldTimeNullable value)
        : this((OneOf<FieldTime, FieldTimeNullable>)value) { }

    private FieldAsTimeNullable(OneOf<FieldTime, FieldTimeNullable> input)
        : base(input) { }
}
