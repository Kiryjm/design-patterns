 // we introduce two new interfaces that are open for extension: IFilter and abstract class Specification

public interface IFilter<T>
  {
    IEnumerable<T> Filter(IEnumerable<T> items, Specification<T> spec);
  }