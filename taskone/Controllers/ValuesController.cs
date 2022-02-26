using DtoTask.Dto;
using ITaskRepository.ITask;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace taskone.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IUsers _users;
        private readonly ISendMessage _message;
        public ValuesController(IUsers users, ISendMessage message)
        {
            _users = users;
            _message = message;
        }

        #region users

        [HttpGet]
        [Route("GetCountUsers")]
        public async Task<Responce<int?>> GetCountUsers()
        {
            Responce<int?> res = new Responce<int?>();

            var result = await _users.GetCountUsers();

            res.code = result > 0 ? StaticApiStatus.ApiSuccess.Code : StaticApiStatus.ApiEmpty.Code;
            res.message = result > 0 ? StaticApiStatus.ApiSuccess.MessageAr : StaticApiStatus.ApiEmpty.MessageAr;
            res.status = result > 0 ? StaticApiStatus.ApiSuccess.Status : StaticApiStatus.ApiEmpty.Status;
            res.IsSuccess = result > 0 ? true : false;
            res.payload = result;

            return res;
        }

        [HttpGet]
        [Route("GetUsersPhoneNumber")]
        public async Task<Responce<List<DtoUsersPhone>>> GetUsersPhoneNumber(int pageNumber)
        {
            Responce<List<DtoUsersPhone>> res = new Responce<List<DtoUsersPhone>>();

            var result = await _users.GetUsersPhoneNumber(pageNumber);

            res.code = result.Count > 0 ? StaticApiStatus.ApiSuccess.Code : StaticApiStatus.ApiEmpty.Code;
            res.message = result.Count > 0 ? StaticApiStatus.ApiSuccess.MessageAr : StaticApiStatus.ApiEmpty.MessageAr;
            res.status = result.Count > 0 ? StaticApiStatus.ApiSuccess.Status : StaticApiStatus.ApiEmpty.Status;
            res.IsSuccess = result.Count > 0 ? true : false;
            res.payload = result;

            return res;
        }

        #endregion users


        #region SMSMessage

        [HttpPost]
        [Route("SendSMSMessage")]
        public async Task<Responce<bool>> SendSMSMessage(string message, string listUsermessage)
        {
            Responce<bool> res = new Responce<bool>();

            var result = await _message.SendSMSMessage(message, listUsermessage);

            res.code = result == true ? StaticApiStatus.ApiSuccess.Code : StaticApiStatus.ApiFaild.Code;
            res.message = result == true ? StaticApiStatus.ApiSuccess.MessageAr : StaticApiStatus.ApiFaild.MessageAr;
            res.status = result == true ? StaticApiStatus.ApiSuccess.Status : StaticApiStatus.ApiFaild.Status;
            res.IsSuccess = result == true ? true : false;
            res.payload = result;

            return res;
        }

        #endregion SMSMessage
    }
}
