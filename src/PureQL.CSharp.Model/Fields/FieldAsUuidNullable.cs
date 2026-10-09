using OneOf;

namespace PureQL.CSharp.Model.Fields;

public sealed class FieldAsUuidNullable : OneOfBase<FieldUuid, FieldUuidNullable>
{
    public FieldAsUuidNullable(FieldUuid value)
        : this((OneOf<FieldUuid, FieldUuidNullable>)value) { }

    public FieldAsUuidNullable(FieldUuidNullable value)
        : this((OneOf<FieldUuid, FieldUuidNullable>)value) { }

    private FieldAsUuidNullable(OneOf<FieldUuid, FieldUuidNullable> input)
        : base(input) { }
}
