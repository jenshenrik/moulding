using Moulding.Domain.MouldCards;

namespace Moulding.Domain;

public class MouldingMachineReading
{
    public MouldingMachineId MouldingMachineId { get; private set; }
    public int CycleTimeInSeconds { get; private set; }
    public int InjectionTimeInSeconds { get; private set; }
    public double InletTemperatureInCelcius { get; private set; }
    public PressureValue Airflow { get; private set; }
    public PressureValue Waterflow { get; private set; }

    public MouldingMachineReading(
        MouldingMachineId mouldingMachineId,
        int cycleTimeInSeconds,
        int injecetionTimeInSeconds,
        double inletTemperatureInCelcius,
        PressureValue airflow,
        PressureValue waterflow
    )
    {
        MouldingMachineId = mouldingMachineId;
        CycleTimeInSeconds = cycleTimeInSeconds;
        InjectionTimeInSeconds = injecetionTimeInSeconds;
        InletTemperatureInCelcius = inletTemperatureInCelcius;
        Airflow = airflow;
        Waterflow = waterflow;
    }
}
