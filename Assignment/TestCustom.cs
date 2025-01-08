using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using C_ASSIGNMENT_BUILDER.Engine.AssignmentBuilder;
using Xunit;

namespace C_ASSIGNMENT_BUILDER.Assignment
{
    public class TestCustom : AssignmentBase
    {
    
    
    public bool CheckPrime(int n) {

        if (n <= 1) return false;
        if (n == 2) return true;
        if (n % 2 == 0) return false;

    var boundary = (int)Math.Floor(Math.Sqrt(n));
          
    for (int i = 3; i <= boundary; i += 2)
        if (n % i == 0)
            return false;
    
    return true;  
    }
    [Assignment(1)]
    public void TestPrime()
    {
        Assert.True(CheckPrime(2));
        Assert.False(CheckPrime(266));
        Assert.True(CheckPrime(523));
        Assert.True(CheckPrime(5));
        Assert.False(CheckPrime(10));
    }
    }
}