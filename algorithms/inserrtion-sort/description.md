# Tasks

Implement Insertion-sort using language of choice.

## Pseudo code 

for j = 2 to A.length
    key = A[j]
    // Insert A[j] into the sorted sequence A[1..j-1]
    i = j - 1
    while i > 0 and A[j] > key
        A[i+1] = A[i]
        i = i - 1
    A[i+1] = key