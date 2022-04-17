namespace Leetcode.Solution.Concurrency;


// The same instance of Foo will be passed to three different threads. Thread A will call first(), thread B will call second(), and thread C will call third(). Design a mechanism and modify the program to ensure that second() is executed after first(), and third() is executed after second().
// Example 1:
//
// Input: nums = [1,2,3]
// Output: "firstsecondthird"
// Explanation: There are three threads being fired asynchronously. The input [1,2,3] means thread A calls first(), thread B calls second(), and thread C calls third(). "firstsecondthird" is the correct output.

public class Foo
{
    private readonly Semaphore _first;
    private readonly Semaphore _second;
    private readonly Semaphore _third;

    public Foo()
    {
        _first = new(1, 1);
        _second = new(0, 1);
        _third = new(0, 1);
    }

    public void First(Action printFirst)
    {
        _first.WaitOne();
        // printFirst() outputs "first". Do not change or remove this line.
        printFirst();
        _second.Release();
    }

    public void Second(Action printSecond)
    {
        _second.WaitOne();
        // printSecond() outputs "second". Do not change or remove this line.
        printSecond();
        _third.Release();
    }

    public void Third(Action printThird)
    {
        _third.WaitOne();
        // printThird() outputs "third". Do not change or remove this line.
        printThird();
        _first.Release();
    }
}