using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskContext.Entities
{
    //جدول حفظ الرسائل 
    public class tblSendMessage : BaseEntity
    { 
        //المستخدم
        [ForeignKey(nameof(tblUsersPhoneNumbers))]
        public Guid? UserId { get; set; }
        public virtual tblUsersPhoneNumbers tblUsersPhoneNumbers { get; set; }
        //الرسالة
        public string Message { get; set; }
    }
}
