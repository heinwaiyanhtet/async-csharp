using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        // Start tasks concurrently
        Task<int> task1 = PerformTaskAsync(1, 2000);
        Task<int> task2 = PerformTaskAsync(2, 3000);
        Task<int> task3 = PerformTaskAsync(3, 1000);

        // Option 1: Await all tasks concurrently using Task.WhenAll
        int[] results = await Task.WhenAll(task1, task2, task3);

        Console.WriteLine($"All tasks completed. Results: {string.Join(", ", results)}");

     
    }

    static async Task<int> PerformTaskAsync(int taskId, int delay)
    {
        Console.WriteLine($"Task {taskId} starting.");
        await Task.Delay(delay); // Simulate async work
        Console.WriteLine($"Task {taskId} completed.");
        return taskId; // Return some result
    }
}
