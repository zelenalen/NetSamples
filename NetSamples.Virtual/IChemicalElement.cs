namespace NetSamples.OOP;

public interface IChemicalElement
{
    IChemicalElement Merge(IChemicalElement element);

    IChemicalElement[] Disassemble();

    void Heat();
}