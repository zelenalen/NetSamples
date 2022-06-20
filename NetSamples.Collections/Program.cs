using System.Runtime.InteropServices;

namespace NetSamples.Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new [] { 1, 2, 3, 4, 5 };

            var us = new UserService(new List<User>());

            foreach (var u in us)
            {
                
            }
        }

        static void ListSample()
        {
            var numbersList = new List<int> { 1, 2, 3, 4, 5 };

            var secondElement = numbersList[1];

            numbersList.Add(2);//will add element at the end of collection
            numbersList.Insert(2, 55);//if not in the end
            numbersList.AddRange(new []{1,2,3,4,5});
            numbersList.Remove(3);//remove 3 from list
            numbersList.RemoveAll(i => i==3);//remove all 3 from list
            numbersList.RemoveRange(2,4);//remove 4 element from [2](including)
            numbersList.RemoveAt(4);//remove [4] element
            numbersList.Contains(5);//true if collection exists 5
            numbersList.IndexOf(6);//return index if exists, -1 if not exists
            numbersList.Sort();//sort by ascending 
            numbersList.Reverse();//list values will be reversed

        }

        static void LinkedListSample()
        {
            var ll = new LinkedList<string>(new List<string>()
            {
                "Tom",
                "Bob",
                "Alice"
            });

            var firstElement = ll.First;
            var secondElement = firstElement?.Next;
            firstElement = secondElement?.Previous;
        }

        static void QueueSample()
        {
            var queue = new Queue<int>
                (new List<int>() { 1, 2, 3, 4, 5, 6 });

            queue.Enqueue(5); // add new element to end of collection
            var firstElement = queue.Peek(); //check value of first element
            var firstElementButWithDeleting = queue.Dequeue(); // get first element and remove it from collection

        }

        static void StackSample()
        {
            var stack = new Stack<int>
                (new List<int>() { 1, 2, 3, 4, 5, 6 });

            var lastElement = stack.Peek();
            stack.Push(5); // add element to the top(end)
            var lastElementWithDeleting = stack.Pop(); // get last element and remove it from collection
        }


        static void Sample(List<User> users)
        {
            var newDict = new Dictionary<string, User>();

            foreach (var user in users)
            {
                var isAddingSuccessful = newDict
                    .TryAdd(user.Id.ToString(), user);
                //newDict.Add(user.Id.ToString(), user);
            }

            var isContainsKey = newDict.ContainsKey("15336");//check is key exists in dict

            var searchedUser = newDict["15336"];
        }
    }

}