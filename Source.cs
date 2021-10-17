namespace Sorting
    {
        public static class BubbleSort
        {
            public static void Sort(ref int[] array, SortingOrder order = SortingOrder.LowestToHighest)
            {
                if (order == SortingOrder.HighestToLowest)
                {
                    for(int n=array.Length; n>1; n--)
                    {
                        for(int i=0; i<n-1; i++)
                        {
                            if (array[i] < array[i + 1])
                            {
                                int temp = array[i + 1];
                                array[i + 1] = array[i];
                                array[i] = temp;
                            }
                        }
                    }
                }
                else if (order == SortingOrder.LowestToHighest)
                {
                    for (int n = array.Length; n > 1; n--)
                    {
                        for (int i = 0; i < n - 1; i++)
                        {
                            if (array[i] > array[i + 1])
                            {
                                int temp = array[i + 1];
                                array[i + 1] = array[i];
                                array[i] = temp;
                            }
                        }
                    }
                }
                else
                {
                    throw new NotSupportedException("This order is not supported!");
                }
            }

            public enum SortingOrder
            {
                LowestToHighest,
                HighestToLowest
            }
        }
    }
