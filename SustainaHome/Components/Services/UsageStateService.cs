public class UsageStateService
{
    public List<int> WeeklyUsage { get; set; } = new List<int> { 50, 70, 65, 80, 75, 60, 85 };
    public double EnergyUsage { get; set; } = 24.0;
    public bool GoalActive { get; set; } = false;
    public int WeeklyGoal { get; set; } = 60;
}