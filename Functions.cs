public class Functions {
    public static int[] SortArray(int[] array) {
        return array.OrderBy(x => x).ToArray();
    }

    public static int? FindMissingNumber(int[] array) {
        int[] InputSorted = SortArray(array);

        int CurrentInt = InputSorted[0];

        for (int Idx = 1; Idx < InputSorted.Length; Idx++) {
            int NextInt = InputSorted[Idx];

            if (NextInt == CurrentInt + 1) {
                CurrentInt = NextInt;
            } else {
                return CurrentInt + 1; // Missing number found
            }
        }

        return null; // No missing number found
    }
}