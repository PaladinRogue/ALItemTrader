using System;
using Common.Api.Interfaces;

namespace ALItemTrader.Api.Resources.Admin
{
    public class AdminResource : IVersionedResource
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Version { get; set; }
    }
}
