using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Calendly.Runners.OpenApiClient.Tests;

[Collection("Collection")]
public sealed class CalendlyOpenApiClientRunnerTests : FixturedUnitTest
{
    public CalendlyOpenApiClientRunnerTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
