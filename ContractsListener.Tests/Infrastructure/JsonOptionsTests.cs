using ContractsListener.Infrastructure;
using FluentAssertions;
using System.Text.Json;
using System.Text.Json.Serialization;
using Xunit;

namespace ContractsListener.Tests.Infrastructure
{
    public class JsonOptionsTests
    {
        [Fact]
        public void CreateJsonOptionsTest()
        {
            var options = JsonOptions.CreateJsonOptions();

            options.PropertyNamingPolicy.Should().Be(JsonNamingPolicy.CamelCase);
            options.WriteIndented.Should().BeTrue();
            options.Converters.Should().ContainEquivalentOf(new JsonStringEnumConverter());
        }
    }
}
