using OneOf;

namespace PureQL.CSharp.Model.Fields;

public sealed class FieldAsDatetimeNullable
    : OneOfBase<FieldDatetime, FieldDatetimeNullable>
{
    public FieldAsDatetimeNullable(FieldDatetime value)
        : this((OneOf<FieldDatetime, FieldDatetimeNullable>)value) { }

    public FieldAsDatetimeNullable(FieldDatetimeNullable value)
        : this((OneOf<FieldDatetime, FieldDatetimeNullable>)value) { }

    private FieldAsDatetimeNullable(OneOf<FieldDatetime, FieldDatetimeNullable> input)
        : base(input) { }
}
