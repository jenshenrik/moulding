namespace Moulding.Domain;

public record PressureValue
{
    public double Value { get; private set; }
    public string UnitOfMeasure { get; private set; }

    public PressureValue(double value, string unitOfMeasure)
    {
        Value = value;
        UnitOfMeasure = unitOfMeasure;
    }
}
