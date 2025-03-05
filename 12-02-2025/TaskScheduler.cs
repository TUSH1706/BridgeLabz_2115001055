
using System;

namespace CircularLinkedListTaskScheduler
{
    public class TaskNode
    {
        public int TaskID;
        public string TaskName;
        public int Priority;
        public DateTime DueDate;
        public TaskNode Next;

        public TaskNode(int taskID, string taskName, int priority, DateTime dueDate)
        {
            TaskID = taskID;
            TaskName = taskName;
            Priority = priority;
            DueDate = dueDate;
            Next = null;
        }
    }
    public class CircularLinkedList
    {
        private TaskNode head;
        private TaskNode current;

        public CircularLinkedList()
        {
            head = null;
            current = null;
        }
        public void AddTaskAtBeginning(int taskID, string taskName, int priority, DateTime dueDate)
        {
            TaskNode newNode = new TaskNode(taskID, taskName, priority, dueDate);
            if (head == null)
            {
                head = newNode;
                head.Next = head;
                current = head;
            }
            else
            {
                newNode.Next = head;
                TaskNode temp = head;
                while (temp.Next != head)
                {
                    temp = temp.Next;
                }
                temp.Next = newNode;
                head = newNode;
            }
        }
        public void AddTaskAtEnd(int taskID, string taskName, int priority, DateTime dueDate)
        {
            TaskNode newNode = new TaskNode(taskID, taskName, priority, dueDate);
            if (head == null)
            {
                head = newNode;
                head.Next = head; // Circular reference
                current = head;
            }
            else
            {
                TaskNode temp = head;
                while (temp.Next != head)
                {
                    temp = temp.Next;
                }
                temp.Next = newNode;
                newNode.Next = head;
            }
        }
        public void AddTaskAtPosition(int taskID, string taskName, int priority, DateTime dueDate, int position)
        {
            if (position < 1)
            {
                Console.WriteLine("Invalid position. Position should be >= 1.");
                return;
            }

            TaskNode newNode = new TaskNode(taskID, taskName, priority, dueDate);
            if (position == 1)
            {
                AddTaskAtBeginning(taskID, taskName, priority, dueDate);
                return;
            }

            TaskNode temp = head;
            for (int i = 1; i < position - 1; i++)
            {
                if (temp.Next == head)
                {
                    Console.WriteLine("Position out of range.");
                    return;
                }
                temp = temp.Next;
            }

            newNode.Next = temp.Next;
            temp.Next = newNode;
        }
        public void RemoveTaskByID(int taskID)
        {
            if (head == null)
            {
                Console.WriteLine("List is empty. No task to remove.");
                return;
            }

            TaskNode temp = head;
            TaskNode prev = null;
            do
            {
                if (temp.TaskID == taskID)
                {
                    break;
                }
                prev = temp;
                temp = temp.Next;
            } while (temp != head);
            if (temp.TaskID != taskID)
            {
                Console.WriteLine("Task with ID " +taskID+  "not found.");
                return;
            }
            if (temp.Next == head && prev == null)
            {
                head = null;
                current = null;
                Console.WriteLine("Task with ID " +taskID+  " removed.");
                return;
            }
            if (temp == head)
            {
                prev = head;
                while (prev.Next != head)
                {
                    prev = prev.Next;
                }
                head = head.Next;
                prev.Next = head;
            }
            else
            {
                prev.Next = temp.Next;
            }

            Console.WriteLine("Task with ID " +taskID + "removed.");
        }
        public void ViewCurrentAndMoveNext()
        {
            if (current == null)
            {
                Console.WriteLine("No tasks in the list.");
                return;
            }

            Console.WriteLine("Current Task: ID = " +current.TaskID," Name = " +current.TaskName, "Priority = " +current.Priority," Due Date = "+current.DueDate.ToShortDateString());
            current = current.Next;
        }
        public void DisplayAllTasks()
        {
            if (head == null)
            {
                Console.WriteLine("No tasks in the list.");
                return;
            }

            TaskNode temp = head;
            do
            {
                Console.WriteLine("Task: ID = " +temp.TaskID, " Name = "+temp.TaskName, "Priority = " +temp.Priority," Due Date = " +temp.DueDate.ToShortDateString());
                temp = temp.Next;
            } while (temp != head);
        }
        public void SearchTasksByPriority(int priority)
        {
            if (head == null)
            {
                Console.WriteLine("No tasks in the list.");
                return;
            }

            TaskNode temp = head;
            bool found = false;
            do
            {
                if (temp.Priority == priority)
                {
                    Console.WriteLine("Task: ID = " +temp.TaskID," Name =" +temp.TaskName, "Priority = "+temp.Priority, "Due Date = " +temp.DueDate.ToShortDateString());
                    found = true;
                }
                temp = temp.Next;
            } while (temp != head);

            if (!found)
            {
                Console.WriteLine("No tasks found with priority " +priority);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            CircularLinkedList scheduler = new CircularLinkedList();
            scheduler.AddTaskAtBeginning(1, "Task 1", 2, DateTime.Now.AddDays(5));
            scheduler.AddTaskAtEnd(2, "Task 2", 1, DateTime.Now.AddDays(3));
            scheduler.AddTaskAtPosition(3, "Task 3", 3, DateTime.Now.AddDays(7), 2);
            Console.WriteLine("All Tasks:");
            scheduler.DisplayAllTasks();
            Console.WriteLine("\nView Current and Move Next:");
            scheduler.ViewCurrentAndMoveNext();
            scheduler.ViewCurrentAndMoveNext();
            Console.WriteLine("\nSearch Tasks by Priority (2):");
            scheduler.SearchTasksByPriority(2);
            Console.WriteLine("\nRemove Task with ID 2:");
            scheduler.RemoveTaskByID(2);
            scheduler.DisplayAllTasks();
        }
    }
}

