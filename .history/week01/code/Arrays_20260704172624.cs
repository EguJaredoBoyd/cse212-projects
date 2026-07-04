public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'. For
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}. Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // Plan:
        // 1. Create a new array with the requested length.
        // 2. Loop through every position in the array.
        // 3. Multiply the given number by (index + 1) to get each multiple.
        // 4. Store each multiple in the corresponding array position.
        // 5. Return the completed array.

        double[] result = new double[length];

        for (int i = 0; i < length; i++)
        {
            result[i] = number * (i + 1);
        }

        return result;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'. For example, if the data is
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}. The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // Plan:
        // 1. Repeat the rotation the required number of times.
        // 2. Save the last element in the list.
        // 3. Shift every other element one position to the right.
        // 4. Place the saved last element into the first position.
        // 5. Continue until all rotations have been completed.

        for (int r = 0; r < amount; r++)
        {
            int last = data[data.Count - 1];

            for (int i = data.Count - 1; i > 0; i--)
            {
                data[i] = data[i - 1];
            }

            data[0] = last;
        }
    }
}