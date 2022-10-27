//todo: THIS IS A "HAS A" RELATIONSHIP
//todo: this is a CONTRACT
//todo: I don't care what you do, but you better fulfill the contract
//todo: THESE ARE ALWAYS PUBLIC
public interface IFruit
{
    string Name { get; } //property w/ only a get
    bool IsPeeled { get; }
    string Peel(); //Method that returns a string
}
