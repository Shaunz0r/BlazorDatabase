using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using newTest.Data.newTest;

namespace newTest.Data
{
    public class PersonnelService
    {
        private readonly CompanydirectoryContext _context;
        public PersonnelService(CompanydirectoryContext context)
        {
            _context = context;
        }
        public async Task<List<PersonnelNew>> GetPersonnelAsync(string strCurrentUser)
        {
            return await _context.PersonnelNew
                .Where(h => h.UserName == strCurrentUser)
                .AsNoTracking().ToListAsync();
        }

        
    }
}
