namespace CounterApp;

public interface ICounterStateService
{
    Task<int> GetCounterValueAsync();
    Task SetCounterValueAsync(int value);
}

public class CounterStateService : ICounterStateService
{
    private int _value;
    public Task<int> GetCounterValueAsync() => 
        Task.FromResult(_value);

    public Task SetCounterValueAsync(int value)
    {
        _value = value;
        return Task.CompletedTask;
    }
}
