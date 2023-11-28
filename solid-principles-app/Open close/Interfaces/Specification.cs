  // we introduce two new interfaces that are open for extension: IFilter and abstract class Specification
 
 public abstract class Specification<T>
  {
    public abstract bool IsSatisfied(T p);

 // Specification is realized as abstract class 
 // cause we can override operators in abstract classes
    public static Specification<T> operator &(
      Specification<T> first, Specification<T> second)
    {
      return new AndSpecification<T>(first, second);
    }
  }