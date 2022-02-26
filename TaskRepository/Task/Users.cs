using DtoTask.Dto;
using ITaskRepository.ITask;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskContext.Context;
using TaskContext.Entities;

namespace TaskRepository.Task
{
    public class Users : GenericRepository<DataContext, tblUsersPhoneNumbers>, IUsers
    {
        public async Task<int?> GetCountUsers()
        {
            int? result = await Context.tblUsersPhoneNumbers.AsNoTracking().Where(x => x.IsDeleted == null).CountAsync();

            return result;
        }

        public async Task<List<DtoUsersPhone>> GetUsersPhoneNumber(int pageNumber)
        {
            int pageSzie = 10;

            var result = await Context.tblUsersPhoneNumbers.AsNoTracking().Where(x => x.IsDeleted == null).Select(x =>
                               new DtoUsersPhone
                               {
                                   Id = x.Id,
                                   Name = x.NameUser,
                                   PhoneNumber = x.PhoneNumber
                               }).Skip(pageSzie * pageNumber).Take(pageSzie).ToListAsync();

            return result;
        }
    }
}
