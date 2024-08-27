prev1 = 0;
prev2 = 1;

console.log(prev1 + "\n" + prev2);//ensures prev2 will display on new line just lijke rest of values below

getFibCount = 0;//sets the stage for a condition to be set in the base case

function getFibSequence(prev1, prev2)
{
    getFibCount++;

    let newFib = prev1 + prev2;
    
    if (getFibCount < 19)//base case; ensures recursion will end after 18 iterations
    {
        console.log(newFib);
        
        //updated values for next iteration
        prev1 = prev2;
        prev2 = newFib;

        getFibSequence(prev1, prev2);//recursive call; triggers next iteration    
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