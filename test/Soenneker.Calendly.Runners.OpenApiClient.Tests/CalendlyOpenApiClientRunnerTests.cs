using System.Threading.Tasks;
using Soenneker.Tests.HostedUnit;

namespace Soenneker.Calendly.Runners.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class CalendlyOpenApiClientRunnerTests : HostedUnitTest
{
    public CalendlyOpenApiClientRunnerTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
