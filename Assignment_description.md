# Eset assigmnent
The main task is to read input.txt file. Transform data, sort and save to output.txt file as fast as possible.

## Description to solution
- The first problem was with native dll from C++ which i added to C# via **InteropServices.DllImport("Transform.dll")**.
- This library contains function Transport for 32-bit integer input and output is the 32-bit integer with new values, for the same input value is the same at output.
- As data structure for saving input data from file i choose ArrayList(Not need to know actual size like in array). In .net i use wrapper arround array and that is List<T>.
- This wrapper has the same accessing to items in complexity of O(1) through indexes.

### SORT
For sorting purposes is the best to use QuickSort algorythm. In .Net we have two options how quicksort is implemented.
1. Array.Sort(unstable, inplace)
2. IEnumerable<x>.OrderBy(stable)

- I went for an option with the **Array.Sort**. Despite it will **mutate** my unordered list of numbers but for this purpose it's acceptable.
- This type of sorting is inplace and is more memory efficient.
- Computational complexity of this algo is if we choose pivot as (median) -> (N*log2N).
- Trick is that quicksort always divide unordered table at two sides less from the median, more then median
- Algo is finish first iteration(in recursion proceess) when index from left side is greater than index from right side __(i > j)__
- The next trick in my solution is using knownglade that transform metdhod always is returning the same numbers beside the same input.
    - So i used this dictionary for loading unique values from file and translate them upon the key/value pair
    - This translate numbers i applied to numbers in content of the file.
    - So there is no need to run transform method on every one number in file.
- for write to file i used **File.WriteAllLinesAsync**, if the target file already exists, it is overwritten.


### RUNNING MANUAL
- The application is console application.
- We need to pass input txt where our application is located and wait for output.txt with sorted numbers inside.