# F# Mutable Tuple Swap Bug

This repository demonstrates a subtle bug related to swapping mutable values within a tuple in F#.  When a mutable tuple is passed to a function, a copy of the tuple is made. Therefore, any modifications done to this copy does not reflect on the original tuple.  This can lead to unexpected results.

The `bug.fs` file shows the problem and the `bugSolution.fs` file provides a corrected version using references to achieve the desired behavior.

## Bug
The core issue lies in how F# handles mutability with tuples.  Directly swapping mutable variables works as expected. However, attempting to swap values within a mutable tuple will only modify a copy of the tuple, leaving the original unchanged. This is because tuples are value types in F#; they are copied when passed to functions and assigned to new variables.

## Solution
The solution uses references (`ref`) to create mutable pointers to the integer variables. The swap operation now works on the references, thus modifying the original values.