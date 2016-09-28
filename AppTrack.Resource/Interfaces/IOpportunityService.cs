using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppTrack.Resource.Structure;

namespace AppTrack.Resource.Interfaces
{
    interface IOpportunityService
    {
        Task AddOpportunity(string user, byte[] fileToStream, bool searchable);
        Task<byte[]> FindOpportunity(string user, OpportunityTypes type, DateTime searchFrom, DateTime searchTo);
    }
}
