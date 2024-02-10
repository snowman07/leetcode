// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


// Hard-coded array input

int[] nums = { 1, 2, 3, 4, 1 };

bool containsDuplicate = ContainsDuplicate(nums);

if (containsDuplicate)
{
    Console.WriteLine("TRUE. Input contains duplicate.");
}
else
{
    Console.WriteLine("FALSE. Input does not contain duplicate.");
}

bool ContainsDuplicate(int[] nums)
{
    // Use a HashSet to keep track of unique elements encounteres so far
    HashSet<int> set = new HashSet<int>();

    foreach (int x in nums)
    {
        // If the element is already in the set, it's a duplicate
        if (set.Contains(x))
        {
            return true;
        }
        // Add the element to the set
        set.Add(x);
    }

    // No duplicates found
    return false;
}