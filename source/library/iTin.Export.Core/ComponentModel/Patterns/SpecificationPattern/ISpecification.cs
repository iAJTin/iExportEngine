
namespace iTin.Export.ComponentModel.Patterns
{
    public interface ISpecification<T>
    {
        bool IsSatisfiedBy(T candidate);

        ISpecification<T> And(ISpecification<T> other);

        ISpecification<T> AndNot(ISpecification<T> other);

        ISpecification<T> Not();

        ISpecification<T> Or(ISpecification<T> other);

        ISpecification<T> OrNot(ISpecification<T> other);
    }
}
