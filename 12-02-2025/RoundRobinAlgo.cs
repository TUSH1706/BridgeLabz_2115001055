
using System;

class ProcessNode
{
    public int ProcessID;
    public int BurstTime;
    public int Priority;
    public ProcessNode Next;

    public ProcessNode(int processID, int burstTime, int priority)
    {
        ProcessID = processID;
        BurstTime = burstTime;
        Priority = priority;
        Next = null;
    }
}

class RoundRobinScheduler
{
    private ProcessNode head;
    private ProcessNode tail;
    private int timeQuantum;

    public RoundRobinScheduler(int quantum)
    {
        head = null;
        tail = null;
        timeQuantum = quantum;
    }
    public void AddProcess(int processID, int burstTime, int priority)
    {
        ProcessNode newNode = new ProcessNode(processID, burstTime, priority);
        if (head == null)
        {
            head = newNode;
            tail = newNode;
            tail.Next = head; 
        }
        else
        {
            tail.Next = newNode;
            tail = newNode;
            tail.Next = head;
        }
    }
    public void RemoveProcess(int processID)
    {
        if (head == null)
        {
            Console.WriteLine("No processes available!");
            return;
        }

        ProcessNode temp = head;
        ProcessNode prev = null;
        do
        {
            if (temp.ProcessID == processID)
                break;
            prev = temp;
            temp = temp.Next;
        } while (temp != head);

        // If process not found
        if (temp.ProcessID != processID)
        {
            Console.WriteLine("Process with ID " + processID + " not found.");
            return;
        }
        if (temp.Next == head && prev == null)
        {
            head = null;
            tail = null;
            Console.WriteLine("Process with ID " + processID + " removed.");
            return;
        }
        if (temp == head)
        {
            head = head.Next;
            tail.Next = head;
        }
        else if (temp == tail)
        {
            prev.Next = head;
            tail = prev;
        }
        else
        {
            prev.Next = temp.Next;
        }

        Console.WriteLine("Process with ID " + processID + " removed.");
    }
    public void SimulateRoundRobin()
    {
        if (head == null)
        {
            Console.WriteLine("No processes to schedule.");
            return;
        }

        int totalWaitingTime = 0;
        int totalTurnAroundTime = 0;
        int totalProcesses = 0;

        ProcessNode current = head;

        Console.WriteLine("Starting Round Robin Scheduling...");
        while (head != null)
        {
            Console.WriteLine("Processing Process ID: " + current.ProcessID + ", Remaining Burst Time: " + current.BurstTime);

            if (current.BurstTime > timeQuantum)
            {
                current.BurstTime -= timeQuantum;
                totalWaitingTime += timeQuantum;
            }
            else
            {
                totalWaitingTime += current.BurstTime;
                totalTurnAroundTime += totalWaitingTime;
                Console.WriteLine("Process ID " + current.ProcessID + " completed.");
                RemoveProcess(current.ProcessID);
                totalProcesses++;
            }

            current = current.Next;
            DisplayProcesses();
        }

        // Calculate and display average waiting time and turn-around time
        double avgWaitingTime = (double)totalWaitingTime / totalProcesses;
        double avgTurnAroundTime = (double)totalTurnAroundTime / totalProcesses;

        Console.WriteLine("Average Waiting Time: " + avgWaitingTime);
        Console.WriteLine("Average Turn-Around Time: " + avgTurnAroundTime);
    }

    // Display the list of processes in the circular queue
    public void DisplayProcesses()
    {
        if (head == null)
        {
            Console.WriteLine("No processes in the queue.");
            return;
        }

        ProcessNode temp = head;
        Console.WriteLine("Current Processes in the Queue:");
        do
        {
            Console.WriteLine("Process ID: " + temp.ProcessID + ", Burst Time: " + temp.BurstTime + ", Priority: " + temp.Priority);
            temp = temp.Next;
        } while (temp != head);
    }
}

class Program
{
    static void Main(string[] args)
    {
        RoundRobinScheduler scheduler = new RoundRobinScheduler(4); // Time quantum = 4
        scheduler.AddProcess(1, 10, 2);
        scheduler.AddProcess(2, 5, 1);
        scheduler.AddProcess(3, 8, 3);
        scheduler.DisplayProcesses();
        scheduler.SimulateRoundRobin();
    }
}

