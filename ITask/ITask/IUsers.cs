using DtoTask.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskContext.Entities;

namespace ITaskRepository.ITask
{
    public interface IUsers : IGenericRepository<tblUsersPhoneNumbers>
    {
        Task<int?> GetCountUsers();
        Task<List<DtoUsersPhone>> GetUsersPhoneNumber(int pageNumber);
    }
}
