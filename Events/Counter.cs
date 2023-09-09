using System;

namespace Lemure.Events;

public class Counter
{
    private int _value;
    private int _limit;

    public event EventHandler DangerLimitReached;
    public event EventHandler LimitReached;

    public Counter(int limit)
    {
        _limit = limit;
    }

    public void Increment()
    {
        _value++;
        if(_value == _limit) OnLimitReached(EventArgs.Empty);

        if (_value > _limit) OnDangerLimitReached(EventArgs.Empty);
    }

    protected virtual void OnDangerLimitReached(EventArgs e)
    {
        DangerLimitReached?.Invoke(this, e);
    }

    protected virtual void OnLimitReached(EventArgs e)
    {
        LimitReached?.Invoke(this, e);
    }
}

public class ProgramTwoEvents
{
    public static void Execute()
    {
        var c = new Counter(5);
        c.LimitReached += c_LimitReached;

        for (int i = 0; i < 7; i++)
        {
            c.Increment();
        }
    }

    public static void c_LimitReached(object sender, EventArgs e)
    {
        Console.WriteLine("Limit Reached!");
    }
}