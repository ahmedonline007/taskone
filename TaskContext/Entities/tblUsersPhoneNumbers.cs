namespace TaskContext.Entities
{
    //جدول حفظ ارقام التليفوان
    public class tblUsersPhoneNumbers : BaseEntity
    {
        // اسم الشخص
        public string NameUser { get; set; }
        // رقم الهاتف
        public string PhoneNumber { get; set; }
    }
}
