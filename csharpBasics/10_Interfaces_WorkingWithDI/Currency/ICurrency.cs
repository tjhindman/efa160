
//We want to use Dependency Injection to "de-couple" code
// Dependency is something we depend on
// This makes coding easier to interact with and test (we can swap out specific implemetations of interfaces)
public interface ICurrency
{
    string Name { get; }

    //currency value
    decimal Value { get; }

}
