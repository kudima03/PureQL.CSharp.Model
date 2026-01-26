namespace PureQL.CSharp.Model.ArrayScalars;

public interface IUuidArrayScalar
{
    public IEnumerable<Guid> Value { get; }
}

public sealed record UuidArrayScalar : IUuidArrayScalar
{
    public UuidArrayScalar(IEnumerable<Guid> value)
    {
        Value = value;
    }

    public IEnumerable<Guid> Value { get; }
}
