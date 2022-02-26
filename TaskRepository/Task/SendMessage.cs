using DtoTask.Dto;
using ITaskRepository.ITask;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskContext.Context;
using TaskContext.Entities;

namespace TaskRepository.Task
{
    public class SendMessage : GenericRepository<DataContext, tblSendMessage>, ISendMessage
    {
        public async Task<bool> SendSMSMessage(string message, string listUsermessage)
        {
            var listId = listUsermessage.Split(',').ToList();

            if (listId.Count > 0)
            {
                foreach (var item in listId)
                {
                    //any Services send SMS

                    var objMessage = new tblSendMessage()
                    {
                        UserId = new Guid(item),
                        Message = message
                    };

                    Add(objMessage);
                    Save();
                }

                return true;
            }

            return false;
        }
    }
}
