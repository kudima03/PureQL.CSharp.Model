namespace PureQL.CSharp.Model.Scalars;

public interface IStringScalar
{
    public string Value { get; }
}

public sealed record StringScalar : IStringScalar
{
    public StringScalar(string value)
    {
        Value = value;
    }

    public string Value { get; }
}
