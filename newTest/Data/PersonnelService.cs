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
        public Task<PersonnelNew> CreatePersonnelAsync(PersonnelNew objPersonnel)
        {
            _context.PersonnelNew.Add(objPersonnel);
            _context.SaveChanges();
            return Task.FromResult(objPersonnel);
        }

        public Task<bool> UpdatePersonnelAsync(PersonnelNew objPersonnel)
        {
            var ExistingPersonnel = _context.PersonnelNew.Where(h => h.Id == objPersonnel.Id)
                .FirstOrDefault();
            if(ExistingPersonnel != null)
            {
                ExistingPersonnel.FirstName = objPersonnel.FirstName;
                ExistingPersonnel.LastName = objPersonnel.LastName;
                ExistingPersonnel.JobTitle = objPersonnel.JobTitle;
                ExistingPersonnel.Email = objPersonnel.Email;
                ExistingPersonnel.DepartmentId = objPersonnel.DepartmentId;
                _context.SaveChanges();
            }
            else
            {
                return Task.FromResult(false);
            }
            return Task.FromResult(true);
        }

        public Task<bool> DeletePersonnelAsync(PersonnelNew objPersonnel)
        {
            var ExistingPersonnel = _context.PersonnelNew.Where(h => h.Id == objPersonnel.Id)
                .FirstOrDefault();
            if (ExistingPersonnel != null)
            {
                _context.PersonnelNew.Remove(ExistingPersonnel);
                _context.SaveChanges();
            }
            else
            {
                return Task.FromResult(false);
            }
            return Task.FromResult(true);
        }
        
    }
}
