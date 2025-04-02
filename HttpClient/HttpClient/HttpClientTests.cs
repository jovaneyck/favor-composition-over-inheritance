using Xunit;
using Xunit.Abstractions;

namespace HttpClient;

public class HttpClientTests(ITestOutputHelper output)
{
    [Fact]
    public async Task ShouldReturnMessage()
    {
        var client = new HttpClient();
        output.WriteLine("Hello World!");
        var message = await client.GetMessage(":employee:name:");
        
        Assert.Equal("Hello :employee:name:!", message);
    }
}