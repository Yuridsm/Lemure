namespace lemure.DesignPatterns.Builder
{
    public interface IBuilder
    {
        IBuilder BuildWalls();
        IBuilder BuildDoors();
        IBuilder BuildWindows();
        IBuilder BuildRoof();
        IBuilder BuildGarage();
        void Reset();
    }
}