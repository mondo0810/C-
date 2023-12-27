namespace GenericExample
{
    public class CurdTest<T>
    {
        private List<T> items;

        public CurdTest()
        {
            items = new List<T>();
        }

        public void AddItem(T item)
        {
            items.Add(item);
            Console.WriteLine("Item added successfully.");
        }

        public void DisplayItems()
        {
            Console.WriteLine($"Displaying {typeof(T).Name} items:");
            int index = 0;
            foreach (var item in items)
            {
                Console.WriteLine($"[{index}] {item}");
                index++;
            }
        }

        public void UpdateItem(int index, T newItem)
        {
            if (index >= 0 && index < items.Count)
            {
                items[index] = newItem;
                Console.WriteLine("Item updated successfully.");
            }
            else
            {
                Console.WriteLine("Invalid index. Update failed.");
            }
        }

        public void DeleteItem(int index)
        {
            if (index >= 0 && index < items.Count)
            {
                items.RemoveAt(index);
                Console.WriteLine("Item deleted successfully.");
            }
            else
            {
                Console.WriteLine("Invalid index. Deletion failed.");
            }
        }
    }
}