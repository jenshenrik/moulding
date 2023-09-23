namespace Moulding.Domain;

/// <summary>
/// Mould card entity class
/// </summary>
public class MouldCard
{
    public MouldCardId Id { get; private set; }
    public MouldingMachineId MouldingMachineId { get; private set; }
    public int CycleTimeInSeconds { get; private set; }
    public int InjectionTimeInSeconds { get; private set; }
    public double InletTemperatureInCelcius { get; private set; }
    public PressureValue Airflow { get; private set; }
    public PressureValue Waterflow { get; private set; }

    #region constructors
    private MouldCard(
        MouldingMachineId mouldingMachineId,
        int cycleTimeInSeconds,
        int injecetionTimeInSeconds,
        double inletTemperatureInCelcius,
        PressureValue airflow,
        PressureValue waterflow
    )
    {
        Id = MouldCardId.Create();
        MouldingMachineId = mouldingMachineId;
        CycleTimeInSeconds = cycleTimeInSeconds;
        InjectionTimeInSeconds = injecetionTimeInSeconds;
        InletTemperatureInCelcius = inletTemperatureInCelcius;
        Airflow = airflow;
        Waterflow = waterflow;
    }

    private MouldCard(
        MouldCardId mouldCardId,
        MouldingMachineId mouldingMachineId,
        int cycleTimeInSeconds,
        int injectionTimeInSeconds,
        double inletTemperatureInCelcius,
        PressureValue airflow,
        PressureValue waterflow
    )
    {
        Id = mouldCardId;
        MouldingMachineId = mouldingMachineId;
        CycleTimeInSeconds = cycleTimeInSeconds;
        InjectionTimeInSeconds = injectionTimeInSeconds;
        InletTemperatureInCelcius = inletTemperatureInCelcius;
        Airflow = airflow;
        Waterflow = waterflow;
    }
    #endregion constructors

    #region factory_methods
    /// <summary>
    /// Create an instance of the mould card entity.
    /// Should be used when generating new mould cards.
    /// </summary>
    /// <param name="mouldingMachineId">The ID of the moulding machine the card is associated with</param>
    /// <param name="cycleTimeInSeconds">The time it takes to complete a moulding process for a mould, measured in seconds</param>
    /// <param name="injecetionTimeInSeconds">The time used to fill the mould with material, measured in seconds</param>
    /// <param name="inletTemperatureInCelcius">The temperature at the inlet where materials flow through, measured in Celsius</param>
    /// <param name="airflow">The pressure of the airflow to cool down the mould, measured in psi or bar</param>
    /// <param name="waterflow">The pressure of the waterflow to cool down the mould, measured in psi or bar</param>
    /// <returns>A new instance of a mould card</returns>
    public static MouldCard Create(
        MouldingMachineId mouldingMachineId,
        int cycleTimeInSeconds,
        int injecetionTimeInSeconds,
        double inletTemperatureInCelcius,
        PressureValue airflow,
        PressureValue waterflow
    )
    {
        return new MouldCard(
            mouldingMachineId,
            cycleTimeInSeconds,
            injecetionTimeInSeconds,
            inletTemperatureInCelcius,
            airflow,
            waterflow
        );
    }

    /// <summary>
    /// Create an instance of the mould card entity.
    /// Should be used when recreating existing mould cards.
    /// </summary>
    /// <param name="mouldCardId">The ID of the mould card</param>
    /// <param name="mouldingMachineId">The ID of the moulding machine the card is associated with</param>
    /// <param name="cycleTimeInSeconds">The time it takes to complete a moulding process for a mould, measured in seconds</param>
    /// <param name="injecetionTimeInSeconds">The time used to fill the mould with material, measured in seconds</param>
    /// <param name="inletTemperatureInCelcius">The temperature at the inlet where materials flow through, measured in Celsius</param>
    /// <param name="airflow">The pressure of the airflow to cool down the mould, measured in psi or bar</param>
    /// <param name="waterflow">The pressure of the waterflow to cool down the mould, measured in psi or bar</param>
    /// <returns>A new instance of a mould card</returns>
    public static MouldCard Create(
        MouldCardId mouldCardId,
        MouldingMachineId mouldingMachineId,
        int cycleTimeInSeconds,
        int injecetionTimeInSeconds,
        double inletTemperatureInCelcius,
        PressureValue airflow,
        PressureValue waterflow
    )
    {
        return new MouldCard(
            mouldCardId,
            mouldingMachineId,
            cycleTimeInSeconds,
            injecetionTimeInSeconds,
            inletTemperatureInCelcius,
            airflow,
            waterflow
        );
    }
    #endregion factory_methods
}
