namespace Moulding.Domain;

public record PressureValue
{
    public double Value { get; private set; }
    public string UnitOfMeasure { get; private set; }

    private PressureValue(double value, string unitOfMeasure)
    {
        Value = value;
        UnitOfMeasure = unitOfMeasure;
    }

    public static PressureValue Create(double value, string unitOfMeasure)
    {
        return new PressureValue(value, unitOfMeasure);
    }
}
