namespace PureQL.CSharp.Model;

public interface IPagination
{
    public long Skip { get; }

    public long Take { get; }
}
