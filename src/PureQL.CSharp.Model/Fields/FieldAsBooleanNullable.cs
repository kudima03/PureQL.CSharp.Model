using OneOf;

namespace PureQL.CSharp.Model.Fields;

public sealed class FieldAsBooleanNullable : OneOfBase<FieldBoolean, FieldBooleanNullable>
{
    public FieldAsBooleanNullable(FieldBoolean value)
        : this((OneOf<FieldBoolean, FieldBooleanNullable>)value) { }

    public FieldAsBooleanNullable(FieldBooleanNullable value)
        : this((OneOf<FieldBoolean, FieldBooleanNullable>)value) { }

    private FieldAsBooleanNullable(OneOf<FieldBoolean, FieldBooleanNullable> input)
        : base(input) { }
}
