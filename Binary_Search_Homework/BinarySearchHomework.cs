using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Homework // don't edit this line!!!
{
    public class BinarySearchHomework // don't edit this line!!!
    {
        public static int TernarySearch(int[] arr, int key, int start, int end) // don't edit this line!!!
                                                                                // يمكنك تجاهل برمترات البداية والنهاية إذا لا تريد استخدام الطريقة العودية 
                                                                                // لكن لاتقوم بحذفهم أو التعديل عليهم هنا تحت اي ظرف!!!
                                                                                // من الممكن تمرير قيمة 0 لتجاهلهم
        {
            //TODO: write code for the ternary search algorithm and return the index of the element
            if (end >= start)
            {
                int mid1 = start + (end - 1) / 3;
                int mid2 = end - (end - 1) / 3;
                if (arr[mid1] == key)
                {
                    return mid1;

                }
                if (arr[mid2] == key)
                {
                    return mid2;
                }
                if (key < arr[mid1])
                {
                    return TernarySearch(arr, key, start, mid1 - 1);
                }
                else if (key > arr[mid2])
                {
                    return TernarySearch(arr, key, mid1 + 1, end);
                }
                else
                {
                    return TernarySearch(arr, key, mid1 + 1, mid2 - 1);
                }


            }
            return -1;
        }

        public static int BinarySearchForCalculatingRepeated
            (int[] arr, int key, bool is_first, int start, int end) // don't edit this line!!!
                                                                    // يمكنك تجاهل برمترات البداية والنهاية إذا لا تريد استخدام الطريقة العودية 
                                                                    // لكن لاتقوم بحذفهم أو التعديل عليهم هنا تحت اي ظرف!!!
                                                                    // من الممكن تمرير قيمة 0 لتجاهلهم
        {
            //TODO: this methods is for getting the first accurence of the key and the last accurance
            return -1;
        }

        public static int GetRepeatCount(int[] arr, int key) // don't edit this line!!!
        {
            //TODO: write code to calculate the repeat count of a spacific element
            // make sure to use the previous method in this method
            int count = 0;
            int left = 0;
            int right = arr.Length - 1;


            while (left <= right)
            {
                int middle = (left + right) / 2;

                if (arr[middle] == key)
                {
                    count++;
                    break;
                }
                else if (arr[middle] < key)
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle - 1;
                }
            }

            if (count > 0)
            {
                int index = Array.IndexOf(arr, key);

                while (index + 1 < arr.Length && arr[index + 1] == key)
                {
                    count++;
                    index++;
                }
            }

            return count;
        }
    }
}
