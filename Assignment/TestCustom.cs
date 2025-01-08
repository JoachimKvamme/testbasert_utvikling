using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using C_ASSIGNMENT_BUILDER.Engine.AssignmentBuilder;

namespace C_ASSIGNMENT_BUILDER.Assignment
{
    public class TestCustom : AssignmentBase
    {
    
    
    public bool CheckPrime(int i) {

        bool isPrime = false;


        return isPrime;
    }
    [Assignment(1)]
    public void TestPrime()
    {
        Assert.Equal(0, Fibonacci(0));
        Assert.Equal(1, Fibonacci(1));
        Assert.Equal(1, Fibonacci(2));
        Assert.Equal(5, Fibonacci(5));
        Assert.Equal(55, Fibonacci(10));
    }
    }
}