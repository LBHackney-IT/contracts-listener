using Hackney.Core.Testing.Shared;
using Xunit;

namespace ContractsListener.Tests
{
    [CollectionDefinition("LogCall collection")]
    public class LogCallAspectFixtureCollection : ICollectionFixture<LogCallAspectFixture>
    { }
}
