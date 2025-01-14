public enum Icons
{
    Backend,
    FullStack,
    Other,
    Mobile
};

public class Job
{
    static int NextIndex;
    public int Index { get; private set; }
    public string Name { get; set; } = "Empty title";
    public string Content { get; set; } = "";
    public string Url { get; set; } = "";
    public string Repo { get; set; } = "";
    public string Time { get; set; } = "";
    public Icons Icon { get; set; } = Icons.Other;


    public Job()
    {
        Index = Interlocked.Increment(ref NextIndex);
    }
}