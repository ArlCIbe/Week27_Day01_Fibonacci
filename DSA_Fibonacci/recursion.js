prev1 = 0;
prev2 = 1;
console.log(prev1);
console.log(prev2);

getFibCount = 0;

function getFibSequence(prev1, prev2)
{
    getFibCount++

    let newFib = prev1 + prev2;
    
    if (getFibCount < 19) 
    {
        console.log(newFib);
        prev1 = prev2;
        prev2 = newFib;    
    }
}

getFibSequence(prev1, prev2);
/*
- Two variables to hold the previous two Fibonacci numbers
- A for loop that runs 18 times
- Create new Fibonacci numbers by adding the two previous ones
- Print the new Fibonacci number
- Update the variables that hold the previous two fibonacci numbers
*/