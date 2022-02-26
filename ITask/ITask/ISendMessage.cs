using DtoTask.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskContext.Entities;

namespace ITaskRepository.ITask
{
    public interface ISendMessage : IGenericRepository<tblSendMessage>
    {
        Task<bool> SendSMSMessage(string message, string listUsermessage);
    }
}
