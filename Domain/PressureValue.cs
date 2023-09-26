namespace Moulding.Domain;

/// <summary>
/// Value type for pressure.
/// </summary>
public record PressureValue
{
    public double Value { get; private set; }
    public string UnitOfMeasure { get; private set; }

    private PressureValue(double value, string unitOfMeasure)
    {
        Value = value;
        UnitOfMeasure = unitOfMeasure;
    }

    /// <summary>
    /// Instantiate a pressure value with a value and a unit of measure.
    /// </summary>
    /// <param name="value">The amount of pressure.</param>
    /// <param name="unitOfMeasure">The unit of measure. Must be either "Bar" or "PSI".</param>
    /// <returns>A new instance of pressure value</returns>
    public static PressureValue Create(double value, string unitOfMeasure)
    {
        if (unitOfMeasure == "Bar" || unitOfMeasure == "PSI")
        {
            return new PressureValue(value, unitOfMeasure);
        }

        throw new ArgumentException(
            $"{unitOfMeasure} is not a valid pressure unit. Must be \"Bar\" or \"PSI\"."
        );
    }
}
