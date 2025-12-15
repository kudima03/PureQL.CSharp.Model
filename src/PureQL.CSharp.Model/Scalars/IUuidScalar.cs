namespace PureQL.CSharp.Model.Scalars;

public interface IUuidScalar
{
    public Guid Value { get; }
}

public sealed record UuidScalar : IUuidScalar
{
    public UuidScalar(Guid value)
    {
        Value = value;
    }

    public Guid Value { get; }
}
