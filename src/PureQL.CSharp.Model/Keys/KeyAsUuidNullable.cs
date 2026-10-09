using OneOf;

namespace PureQL.CSharp.Model.Keys;

public sealed class KeyAsUuidNullable : OneOfBase<KeyUuid, KeyUuidNullable>
{
    public KeyAsUuidNullable(KeyUuid value)
        : this((OneOf<KeyUuid, KeyUuidNullable>)value) { }

    public KeyAsUuidNullable(KeyUuidNullable value)
        : this((OneOf<KeyUuid, KeyUuidNullable>)value) { }

    private KeyAsUuidNullable(OneOf<KeyUuid, KeyUuidNullable> input)
        : base(input) { }
}
