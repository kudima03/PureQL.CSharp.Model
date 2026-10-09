using OneOf;

namespace PureQL.CSharp.Model.Fields;

public sealed class FieldAsDateNullable : OneOfBase<FieldDate, FieldDateNullable>
{
    public FieldAsDateNullable(FieldDate value)
        : this((OneOf<FieldDate, FieldDateNullable>)value) { }

    public FieldAsDateNullable(FieldDateNullable value)
        : this((OneOf<FieldDate, FieldDateNullable>)value) { }

    private FieldAsDateNullable(OneOf<FieldDate, FieldDateNullable> input)
        : base(input) { }
}
