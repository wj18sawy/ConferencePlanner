using System.Linq;
 using HotChocolate;
 using ConferencePlanner.GraphQL.Data;
using ConferencePlanner.GraphQL.Extensions;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ConferencePlanner.GraphQL
 {
     public class Query
     {
        [UseApplicationDbContext]
        public Task<List<Speaker>> GetSpeakers([ScopedService] ApplicationDbContext context) =>
            context.Speakers.ToListAsync();
    }
 }