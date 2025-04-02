using Xunit;

namespace HttpClient;

public class HttpClientTests
{
    [Fact]
    public async Task ShouldReturnMessage()
    {
        var client = new HttpClient();

        var message = await client.GetMessage(":employee:name:");
        
        Assert.Equal("Hello :employee:name:!", message);
    }
}