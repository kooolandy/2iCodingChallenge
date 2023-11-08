First assumption array in order
No limit to size of array sepecified but let's choose 6

Examples
ie { 1,2,3,4,5,6 } => 16

First thing I noticed is that if the two largest dont add up to the X integer then the output is 0 pairs
Also if the lowest number is greater than X there are 0 pairs

X: 1
Array: [3, 4, 5, 6]
Output: 0 

X: 15
Array: [0, 15, 32, 2000, 15000]
Output: 1

X: 42
Array: [1, 1, 10, 32, 41]
Output: 2

From looking at the data any numbers larger than X can be ignored (assuming no negative whole numbers)

Was going to create test data in json and then realised I am on a time limit ;-)

1. First step was to parse input and validate usable values in array
2. Then to loop thru 

Running my code I would question the result from X = 42
	1+41 = 42, 1+ 41 = 42, and 10+32=42 => 3 