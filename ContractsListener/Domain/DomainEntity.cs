using System;

namespace ContractsListener.Domain
{
    public class DomainEntity
    {
        // TODO - define your domain entity/entities here
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? VersionNumber { get; set; }
    }
}
