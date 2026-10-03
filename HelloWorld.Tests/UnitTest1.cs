namespace HelloWorld.Tests;

public class UnitTest1
{
    [Fact]
    public void GetMessage_ShouldReturnHelloWorld()
    {
        var result = HelloWorldApp.GetMessage();

        Assert.Equal("Hello, World!", result);
    }
}
