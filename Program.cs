﻿using System;
using System.Collections.Generic;//Generic collection
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEmo_Collections_in_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Getting sarted with Collections in C#
            //TYpes of collections in C#
            //1. Arrays
            //2. Lists : it can store a collection of objects, similar to arrays but with dynamic size
            //3. Dictionaries : it can store key-value pairs ex Combination of a string and an integer ex <username,password>
            //4. HashSets : it can store unique values, similar to a set in mathematics
            //5. Queues : it can store a collection of objects in a first-in-first-out (FIFO) order
            //6. Stacks : it can store a collection of objects in a last-in-first-out (LIFO) order
            //7. LinkedLists : it can store a collection of objects in a linked list structure, where each object points to the next object in the list
            //8. SortedLists : it can store a collection of objects in a sorted order, similar to a dictionary but with sorted keys
            //9. SortedSets : it can store a collection of unique values in a sorted order, similar to a HashSet but with sorted values
            //10. Concurrent Collections : it can store a collection of objects that can be accessed by multiple threads simultaneously, such as ConcurrentDictionary, ConcurrentQueue, and ConcurrentBag

            //We can categories collections in C# into two main categories:
            //1. Generic Collections : These collections are type-safe and can store any type of object. They are defined in the System.Collections.Generic namespace.
            //List<string> names = new List<string> { "Alice", "Bob", "Charlie" };
            //Dictionary<string, int> ageDictionary = new Dictionary<string, int>
            //{
            //    { "Alice", 30 },
            //    { "Bob", 25 },
            //    { "Charlie", 35 }
            //};
            //HashSet<int> uniqueNumbers = new HashSet<int> { 1, 2, 3, 4, 5 };
            ////2. Non-Generic Collections : These collections are not type-safe and can store any type of object. They are defined in the System.Collections namespace.

            ////Scenario to implement Array list of generic type based on Employee names 
            //List<string> employeeNames = new List<string>();//Step 1: Creating a list to store employee names
            ////Step 2: Adding employee names to the list
            //employeeNames.Add("John Doe");
            //employeeNames.Add("Jane Smith");
            //employeeNames.Add("Alice Johnson");// Adding more employee names
            //employeeNames.Add("Bob Brown");
            //employeeNames.Add("Charlie White");
            //employeeNames.Add("David Green");
            //employeeNames.Add("Eve Black");
            ////Step 3: Displaying the employee names
            //Console.WriteLine("Employee Names:");
            //foreach (var name in employeeNames)
            //{
            //    Console.WriteLine(name);
            //}
            ////Step 4: Removing an employee name from the list
            //employeeNames.Remove("Jane Smith");
            ////Step 5: Displaying the updated employee names
            //Console.WriteLine("\nUpdated Employee Names:");
            //foreach (var name in employeeNames)
            //{
            //    Console.WriteLine(name);
            //}
            ////Step 6: Searching for an employee name in the list using contains()
            //string searchName = "Alice Johnson";
            //if (employeeNames.Contains(searchName))
            //{
            //    Console.WriteLine($"\n{searchName} is found in the employee list.");
            //}
            //else
            //{
            //    Console.WriteLine($"\n{searchName} is not found in the employee list.");
            //}
            ////Step 7: Sorting the employee names in alphabetical order
            //employeeNames.Sort();
            ////Step 8: Displaying the sorted employee names
            //Console.WriteLine("\nSorted Employee Names:");
            //foreach (var name in employeeNames)
            //{
            //    Console.WriteLine(name);
            //}
            ////Step 9: Finding the count of employee names in the list Imp Diff beween Count and Size of the collection
            //int count = employeeNames.Count;
            //Console.WriteLine($"\nTotal number of employees: {count}");
            ////Step 10: Clearing the list of employee names
            ////employeeNames.Clear();
            ////Step 11: Displaying the count after clearing the list
            //Console.WriteLine($"\nTotal number of employees after clearing the list: {employeeNames.Count}");

            ////Updating the employee names in the list
            //Console.WriteLine("\nUpdating Employee Names:");



            ////Lets insert element in collection using input from user bases on int values ie salaries of an employee
            //List<int> salaries = new List<int>();//Step 1: Creating a list to store employee salaries
            //Console.WriteLine("\nEnter employee salaries (type 'done' to finish):");
            ////reading salaries from user input

            ////Step 2: Looping through the employee names to get salaries

            //foreach (var name in employeeNames)
            //{
            //    Console.Write($"Enter salary for {name}: ");
            //    string input = Console.ReadLine();
            //    if (input.ToLower() == "done")
            //    {
            //        break; // Exit the loop if user types 'done'
            //    }
            //    if (int.TryParse(input, out int salary))//here try parse is used to check if the input can be converted to an integer
            //                                            //out int salary is used to store the converted integer value
            //    {
            //        salaries.Add(salary); // Add the salary to the list
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid input. Please enter a valid salary.");
            //    }
            //    Console.WriteLine(employeeNames.Count > 0 ? "Salaries entered successfully." : "No salaries entered.");
            //    //Showing the count of the collection
            //    Console.WriteLine($"Total number of salaries entered: {salaries.Count}");
            //    //Showing the salaries entered
            //    Console.WriteLine("\nSalaries Entered:");
            //    foreach (var mysalary in salaries)
            //    {
            //        Console.WriteLine(mysalary);
            //    }
            //    //Showing the size of the collection in terms of memory
            //    Console.WriteLine(salaries.Capacity);// Capacity is the number of elements that the list can hold before it needs to resize by the logic 2^N
            //    //capacity is dynamically increased as elements are added to the list by doubling the current capacity by default (CLR)
            //    Console.WriteLine(salaries.Count);// Count is the number of elements that are currently in the list

            //}

            Console.WriteLine(" Need to implement a Stack and Queue using Generic Collection in C#");

            //Scenario: Need to create a C# program that maintains Browser navigaion/URL history anf printout job queues using Stack and Queue
            //Stack: Last In First Out (LIFO) — Used for Browser navigation history
            //Queue: First In First Out (FIFO) — Used for Job Queues
            //Step 1: Create a Stack for Browser navigation history
            //Step 2: Create a Queue for Job Queues
            //Step 3: Implement methods to push and pop URLs in Stack( methods are predefined in Stack class)
            //Step 4: Implement methods to enqueue and dequeue jobs in Queue(methods are predefined in Queue class)
            //Step 5: Print out the contents of Stack and Queue
            //Step 6: Test the program with sample data

            //Step 1: Create a Stack for Browser navigation history
            Stack<string> browserHistory = new Stack<string>();

            //Step 2: Create a Queue for Job Queues
            Queue<string> jobQueue = new Queue<string>();

            //Step 3: Implement methods to push and pop URLs in Stack
            //Pushing URLs to the Stack
            browserHistory.Push("https://www.example.com");
            browserHistory.Push("https://www.google.com");
            browserHistory.Push("https://www.github.com");

            //Step 4: Implement methods to enqueue and dequeue jobs in Queue
            //Enqueuing jobs to the Queue
            jobQueue.Enqueue("Job 1: Data Processing");
            jobQueue.Enqueue("Job 2: Report Generation");
            jobQueue.Enqueue("Job 3: Email Notification");

            //Step 5: Print out the contents of Stack and Queue
            Console.WriteLine("\nBrowser History (Stack):");
            foreach (var url in browserHistory)
            {
                Console.WriteLine(url);
            }
            Console.WriteLine("\nJob Queue (Queue):");
            foreach (var job in jobQueue)
            {
                Console.WriteLine(job);
            }

            //Step 6: Test the program with sample data
            //Popping URLs from the Stack
            Console.WriteLine("\nPopping URLs from Browser History:");
            while (browserHistory.Count > 0)
            {
                Console.WriteLine(browserHistory.Pop());
            }
            // printing the count of browser history

            Console.WriteLine($"Total URLs in Browser History: {browserHistory.Count}");


            //Dequeuing jobs from the Queue
            Console.WriteLine("\nDequeuing Jobs from Job Queue:");
            while (jobQueue.Count > 0)
            {
                Console.WriteLine(jobQueue.Dequeue());
            }
            // printing the count of job queue
            Console.WriteLine($"Total Jobs in Job Queue: {jobQueue.Count}");
            
        }
    }
}
