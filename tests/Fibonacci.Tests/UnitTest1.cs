using System.Threading.Tasks;
using Xunit;


namespace Fibonacci.Tests{

    
public class FibonacciUnitTests
{
    [Fact]
    public async Task  Execute44ShouldRetrun701408733()
    {
        var result = await Compute.ExecuteAsync(new[] {"6"});
        Assert.Equal(8, result[0]);
    }
}
}