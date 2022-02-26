using Microsoft.EntityFrameworkCore;
using System;

namespace TaskContext.Entities
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tblUsersPhoneNumbers>().HasData(
                    new tblUsersPhoneNumbers
                    {
                        Id = Guid.NewGuid(),
                        AddedDate = DateTime.Now,
                        NameUser = "Ahmed1",
                        PhoneNumber = "01009615946"
                    },
                    new tblUsersPhoneNumbers
                    {
                        Id = Guid.NewGuid(),
                        AddedDate = DateTime.Now,
                        NameUser = "Ahmed2",
                        PhoneNumber = "01009615946"
                    },
                    new tblUsersPhoneNumbers
                    {
                        Id = Guid.NewGuid(),
                        NameUser = "Alexander Hendrix",
                        PhoneNumber = "(06494) 3685877",
                        AddedDate = DateTime.Now
                    },
                    new tblUsersPhoneNumbers
                   {
                       Id = Guid.NewGuid(),
                       NameUser = "Lamar Robles",
                       PhoneNumber = "(00593) 5308822",
                       AddedDate = DateTime.Now
                   },
                    new tblUsersPhoneNumbers
                   {
                       Id = Guid.NewGuid(),
                       NameUser = "Colorado Dotson",
                       PhoneNumber = "(058) 41455821",
                       AddedDate = DateTime.Now
                   },
                    new tblUsersPhoneNumbers
                   {
                       Id = Guid.NewGuid(),
                       NameUser = "Madaline Vinson",
                       PhoneNumber = "(035) 45331372",
                       AddedDate = DateTime.Now
                   },
                    new tblUsersPhoneNumbers
                   {
                       Id = Guid.NewGuid(),
                       NameUser = "Elijah Mueller",
                       PhoneNumber = "(032476) 601138",
                       AddedDate = DateTime.Now
                   },
                    new tblUsersPhoneNumbers
                   {
                       Id = Guid.NewGuid(),
                       NameUser = "Lana Hudson",
                       PhoneNumber = "(095) 35767831",
                       AddedDate = DateTime.Now
                   },
                    new tblUsersPhoneNumbers
                    {
                        Id = Guid.NewGuid(),
                        NameUser = "Cally Barr",
                        PhoneNumber = "(0857) 53334108",
                        AddedDate = DateTime.Now
                    },
                    new tblUsersPhoneNumbers
                    {
                        Id = Guid.NewGuid(),
                        NameUser = "Tanisha Gutierrez",
                        PhoneNumber = "(01137) 7162891",
                        AddedDate = DateTime.Now
                    },
                    new tblUsersPhoneNumbers
                    {
                        Id = Guid.NewGuid(),
                        NameUser = "Ocean Glenn",
                        PhoneNumber = "(035533) 476735",
                        AddedDate = DateTime.Now
                    },
                    new tblUsersPhoneNumbers
                    {
                        Id = Guid.NewGuid(),
                        NameUser = "Rebekah Mooney",
                        PhoneNumber = "(0977) 85347403",
                        AddedDate = DateTime.Now
                    },
                    new tblUsersPhoneNumbers
                    {
                        Id = Guid.NewGuid(),
                        NameUser = "Alexander Hendrix",
                        PhoneNumber = "(06494) 3685877",
                        AddedDate = DateTime.Now
                    },
                    new tblUsersPhoneNumbers
                    {
                        Id = Guid.NewGuid(),
                        NameUser = "Lamar Robles",
                        PhoneNumber = "(00593) 5308822",
                        AddedDate = DateTime.Now
                    },
                    new tblUsersPhoneNumbers
                    {
                        Id = Guid.NewGuid(),
                        NameUser = "Colorado Dotson",
                        PhoneNumber = "(058) 41455821",
                        AddedDate = DateTime.Now
                    },
                    new tblUsersPhoneNumbers
                    {
                        Id = Guid.NewGuid(),
                        NameUser = "Madaline Vinson",
                        PhoneNumber = "(035) 45331372",
                        AddedDate = DateTime.Now
                    },
                    new tblUsersPhoneNumbers
                    {
                        Id = Guid.NewGuid(),
                        NameUser = "Elijah Mueller",
                        PhoneNumber = "(032476) 601138",
                        AddedDate = DateTime.Now
                    },
                    new tblUsersPhoneNumbers
                    {
                        Id = Guid.NewGuid(),
                        NameUser = "Lana Hudson",
                        PhoneNumber = "(095) 35767831",
                        AddedDate = DateTime.Now
                    },
                    new tblUsersPhoneNumbers
                    {
                        Id = Guid.NewGuid(),
                        NameUser = "Cally Barr",
                        PhoneNumber = "(0857) 53334108",
                        AddedDate = DateTime.Now
                    },
                    new tblUsersPhoneNumbers
                    {
                        Id = Guid.NewGuid(),
                        NameUser = "Tanisha Gutierrez",
                        PhoneNumber = "(01137) 7162891",
                        AddedDate = DateTime.Now
                    },
                    new tblUsersPhoneNumbers
                    {
                        Id = Guid.NewGuid(),
                        NameUser = "Ocean Glenn",
                        PhoneNumber = "(035533) 476735",
                        AddedDate = DateTime.Now
                    },
                    new tblUsersPhoneNumbers
                    {
                        Id = Guid.NewGuid(),
                        NameUser = "Rebekah Mooney",
                        PhoneNumber = "(0977) 85347403",
                        AddedDate = DateTime.Now
                    },
                    new tblUsersPhoneNumbers
                    {
                        Id = Guid.NewGuid(),
                        NameUser = "Alexander Hendrix",
                        PhoneNumber = "(06494) 3685877",
                        AddedDate = DateTime.Now
                    },
                    new tblUsersPhoneNumbers
                    {
                        Id = Guid.NewGuid(),
                        NameUser = "Lamar Robles",
                        PhoneNumber = "(00593) 5308822",
                        AddedDate = DateTime.Now
                    },
                    new tblUsersPhoneNumbers
                    {
                        Id = Guid.NewGuid(),
                        NameUser = "Colorado Dotson",
                        PhoneNumber = "(058) 41455821",
                        AddedDate = DateTime.Now
                    },
                    new tblUsersPhoneNumbers
                    {
                        Id = Guid.NewGuid(),
                        NameUser = "Madaline Vinson",
                        PhoneNumber = "(035) 45331372",
                        AddedDate = DateTime.Now
                    },
                    new tblUsersPhoneNumbers
                    {
                        Id = Guid.NewGuid(),
                        NameUser = "Elijah Mueller",
                        PhoneNumber = "(032476) 601138",
                        AddedDate = DateTime.Now
                    },
                    new tblUsersPhoneNumbers
                    {
                        Id = Guid.NewGuid(),
                        NameUser = "Lana Hudson",
                        PhoneNumber = "(095) 35767831",
                        AddedDate = DateTime.Now
                    },
                    new tblUsersPhoneNumbers
                    {
                        Id = Guid.NewGuid(),
                        NameUser = "Cally Barr",
                        PhoneNumber = "(0857) 53334108",
                        AddedDate = DateTime.Now
                    },
                    new tblUsersPhoneNumbers
                    {
                        Id = Guid.NewGuid(),
                        NameUser = "Tanisha Gutierrez",
                        PhoneNumber = "(01137) 7162891",
                        AddedDate = DateTime.Now
                    },
                    new tblUsersPhoneNumbers
                    {
                        Id = Guid.NewGuid(),
                        NameUser = "Ocean Glenn",
                        PhoneNumber = "(035533) 476735",
                        AddedDate = DateTime.Now
                    },
                    new tblUsersPhoneNumbers
                    {
                        Id = Guid.NewGuid(),
                        NameUser = "Rebekah Mooney",
                        PhoneNumber = "(0977) 85347403",
                        AddedDate = DateTime.Now
                    }, new tblUsersPhoneNumbers
                    {
                        Id = Guid.NewGuid(),
                        NameUser = "Alexander Hendrix",
                        PhoneNumber = "(06494) 3685877",
                        AddedDate = DateTime.Now
                    },
                    new tblUsersPhoneNumbers
                    {
                        Id = Guid.NewGuid(),
                        NameUser = "Lamar Robles",
                        PhoneNumber = "(00593) 5308822",
                        AddedDate = DateTime.Now
                    },
                    new tblUsersPhoneNumbers
                    {
                        Id = Guid.NewGuid(),
                        NameUser = "Colorado Dotson",
                        PhoneNumber = "(058) 41455821",
                        AddedDate = DateTime.Now
                    },
                    new tblUsersPhoneNumbers
                    {
                        Id = Guid.NewGuid(),
                        NameUser = "Madaline Vinson",
                        PhoneNumber = "(035) 45331372",
                        AddedDate = DateTime.Now
                    },
                    new tblUsersPhoneNumbers
                    {
                        Id = Guid.NewGuid(),
                        NameUser = "Elijah Mueller",
                        PhoneNumber = "(032476) 601138",
                        AddedDate = DateTime.Now
                    },
                    new tblUsersPhoneNumbers
                    {
                        Id = Guid.NewGuid(),
                        NameUser = "Lana Hudson",
                        PhoneNumber = "(095) 35767831",
                        AddedDate = DateTime.Now
                    },
                    new tblUsersPhoneNumbers
                    {
                        Id = Guid.NewGuid(),
                        NameUser = "Cally Barr",
                        PhoneNumber = "(0857) 53334108",
                        AddedDate = DateTime.Now
                    },
                    new tblUsersPhoneNumbers
                    {
                        Id = Guid.NewGuid(),
                        NameUser = "Tanisha Gutierrez",
                        PhoneNumber = "(01137) 7162891",
                        AddedDate = DateTime.Now
                    },
                    new tblUsersPhoneNumbers
                    {
                        Id = Guid.NewGuid(),
                        NameUser = "Ocean Glenn",
                        PhoneNumber = "(035533) 476735",
                        AddedDate = DateTime.Now
                    },
                    new tblUsersPhoneNumbers
                    {
                        Id = Guid.NewGuid(),
                        NameUser = "Rebekah Mooney",
                        PhoneNumber = "(0977) 85347403",
                        AddedDate = DateTime.Now
                    },
                                        new tblUsersPhoneNumbers
                                        {
                                            Id = Guid.NewGuid(),
                                            NameUser = "Alexander Hendrix",
                                            PhoneNumber = "(06494) 3685877",
                                            AddedDate = DateTime.Now
                                        },
                    new tblUsersPhoneNumbers
                    {
                        Id = Guid.NewGuid(),
                        NameUser = "Lamar Robles",
                        PhoneNumber = "(00593) 5308822",
                        AddedDate = DateTime.Now
                    },
                    new tblUsersPhoneNumbers
                    {
                        Id = Guid.NewGuid(),
                        NameUser = "Colorado Dotson",
                        PhoneNumber = "(058) 41455821",
                        AddedDate = DateTime.Now
                    },
                    new tblUsersPhoneNumbers
                    {
                        Id = Guid.NewGuid(),
                        NameUser = "Madaline Vinson",
                        PhoneNumber = "(035) 45331372",
                        AddedDate = DateTime.Now
                    },
                    new tblUsersPhoneNumbers
                    {
                        Id = Guid.NewGuid(),
                        NameUser = "Elijah Mueller",
                        PhoneNumber = "(032476) 601138",
                        AddedDate = DateTime.Now
                    },
                    new tblUsersPhoneNumbers
                    {
                        Id = Guid.NewGuid(),
                        NameUser = "Lana Hudson",
                        PhoneNumber = "(095) 35767831",
                        AddedDate = DateTime.Now
                    },
                    new tblUsersPhoneNumbers
                    {
                        Id = Guid.NewGuid(),
                        NameUser = "Cally Barr",
                        PhoneNumber = "(0857) 53334108",
                        AddedDate = DateTime.Now
                    },
                    new tblUsersPhoneNumbers
                    {
                        Id = Guid.NewGuid(),
                        NameUser = "Tanisha Gutierrez",
                        PhoneNumber = "(01137) 7162891",
                        AddedDate = DateTime.Now
                    },
                    new tblUsersPhoneNumbers
                    {
                        Id = Guid.NewGuid(),
                        NameUser = "Ocean Glenn",
                        PhoneNumber = "(035533) 476735",
                        AddedDate = DateTime.Now
                    },
                    new tblUsersPhoneNumbers
                    {
                        Id = Guid.NewGuid(),
                        NameUser = "Rebekah Mooney",
                        PhoneNumber = "(0977) 85347403",
                        AddedDate = DateTime.Now
                    },
                                        new tblUsersPhoneNumbers
                                        {
                                            Id = Guid.NewGuid(),
                                            NameUser = "Alexander Hendrix",
                                            PhoneNumber = "(06494) 3685877",
                                            AddedDate = DateTime.Now
                                        },
                    new tblUsersPhoneNumbers
                    {
                        Id = Guid.NewGuid(),
                        NameUser = "Lamar Robles",
                        PhoneNumber = "(00593) 5308822",
                        AddedDate = DateTime.Now
                    },
                    new tblUsersPhoneNumbers
                    {
                        Id = Guid.NewGuid(),
                        NameUser = "Colorado Dotson",
                        PhoneNumber = "(058) 41455821",
                        AddedDate = DateTime.Now
                    },
                    new tblUsersPhoneNumbers
                    {
                        Id = Guid.NewGuid(),
                        NameUser = "Madaline Vinson",
                        PhoneNumber = "(035) 45331372",
                        AddedDate = DateTime.Now
                    },
                    new tblUsersPhoneNumbers
                    {
                        Id = Guid.NewGuid(),
                        NameUser = "Elijah Mueller",
                        PhoneNumber = "(032476) 601138",
                        AddedDate = DateTime.Now
                    },
                    new tblUsersPhoneNumbers
                    {
                        Id = Guid.NewGuid(),
                        NameUser = "Lana Hudson",
                        PhoneNumber = "(095) 35767831",
                        AddedDate = DateTime.Now
                    },
                    new tblUsersPhoneNumbers
                    {
                        Id = Guid.NewGuid(),
                        NameUser = "Cally Barr",
                        PhoneNumber = "(0857) 53334108",
                        AddedDate = DateTime.Now
                    },
                    new tblUsersPhoneNumbers
                    {
                        Id = Guid.NewGuid(),
                        NameUser = "Tanisha Gutierrez",
                        PhoneNumber = "(01137) 7162891",
                        AddedDate = DateTime.Now
                    },
                    new tblUsersPhoneNumbers
                    {
                        Id = Guid.NewGuid(),
                        NameUser = "Ocean Glenn",
                        PhoneNumber = "(035533) 476735",
                        AddedDate = DateTime.Now
                    },
                    new tblUsersPhoneNumbers
                    {
                        Id = Guid.NewGuid(),
                        NameUser = "Rebekah Mooney",
                        PhoneNumber = "(0977) 85347403",
                        AddedDate = DateTime.Now
                    },
                                        new tblUsersPhoneNumbers
                                        {
                                            Id = Guid.NewGuid(),
                                            NameUser = "Alexander Hendrix",
                                            PhoneNumber = "(06494) 3685877",
                                            AddedDate = DateTime.Now
                                        },
                    new tblUsersPhoneNumbers
                    {
                        Id = Guid.NewGuid(),
                        NameUser = "Lamar Robles",
                        PhoneNumber = "(00593) 5308822",
                        AddedDate = DateTime.Now
                    },
                    new tblUsersPhoneNumbers
                    {
                        Id = Guid.NewGuid(),
                        NameUser = "Colorado Dotson",
                        PhoneNumber = "(058) 41455821",
                        AddedDate = DateTime.Now
                    },
                    new tblUsersPhoneNumbers
                    {
                        Id = Guid.NewGuid(),
                        NameUser = "Madaline Vinson",
                        PhoneNumber = "(035) 45331372",
                        AddedDate = DateTime.Now
                    },
                    new tblUsersPhoneNumbers
                    {
                        Id = Guid.NewGuid(),
                        NameUser = "Elijah Mueller",
                        PhoneNumber = "(032476) 601138",
                        AddedDate = DateTime.Now
                    },
                    new tblUsersPhoneNumbers
                    {
                        Id = Guid.NewGuid(),
                        NameUser = "Lana Hudson",
                        PhoneNumber = "(095) 35767831",
                        AddedDate = DateTime.Now
                    },
                    new tblUsersPhoneNumbers
                    {
                        Id = Guid.NewGuid(),
                        NameUser = "Cally Barr",
                        PhoneNumber = "(0857) 53334108",
                        AddedDate = DateTime.Now
                    },
                    new tblUsersPhoneNumbers
                    {
                        Id = Guid.NewGuid(),
                        NameUser = "Tanisha Gutierrez",
                        PhoneNumber = "(01137) 7162891",
                        AddedDate = DateTime.Now
                    },
                    new tblUsersPhoneNumbers
                    {
                        Id = Guid.NewGuid(),
                        NameUser = "Ocean Glenn",
                        PhoneNumber = "(035533) 476735",
                        AddedDate = DateTime.Now
                    },
                    new tblUsersPhoneNumbers
                    {
                        Id = Guid.NewGuid(),
                        NameUser = "Rebekah Mooney",
                        PhoneNumber = "(0977) 85347403",
                        AddedDate = DateTime.Now
                    }, new tblUsersPhoneNumbers
                    {
                        Id = Guid.NewGuid(),
                        NameUser = "Alexander Hendrix",
                        PhoneNumber = "(06494) 3685877",
                        AddedDate = DateTime.Now
                    },
                    new tblUsersPhoneNumbers
                    {
                        Id = Guid.NewGuid(),
                        NameUser = "Lamar Robles",
                        PhoneNumber = "(00593) 5308822",
                        AddedDate = DateTime.Now
                    },
                    new tblUsersPhoneNumbers
                    {
                        Id = Guid.NewGuid(),
                        NameUser = "Colorado Dotson",
                        PhoneNumber = "(058) 41455821",
                        AddedDate = DateTime.Now
                    },
                    new tblUsersPhoneNumbers
                    {
                        Id = Guid.NewGuid(),
                        NameUser = "Madaline Vinson",
                        PhoneNumber = "(035) 45331372",
                        AddedDate = DateTime.Now
                    },
                    new tblUsersPhoneNumbers
                    {
                        Id = Guid.NewGuid(),
                        NameUser = "Elijah Mueller",
                        PhoneNumber = "(032476) 601138",
                        AddedDate = DateTime.Now
                    },
                    new tblUsersPhoneNumbers
                    {
                        Id = Guid.NewGuid(),
                        NameUser = "Lana Hudson",
                        PhoneNumber = "(095) 35767831",
                        AddedDate = DateTime.Now
                    },
                    new tblUsersPhoneNumbers
                    {
                        Id = Guid.NewGuid(),
                        NameUser = "Cally Barr",
                        PhoneNumber = "(0857) 53334108",
                        AddedDate = DateTime.Now
                    },
                    new tblUsersPhoneNumbers
                    {
                        Id = Guid.NewGuid(),
                        NameUser = "Tanisha Gutierrez",
                        PhoneNumber = "(01137) 7162891",
                        AddedDate = DateTime.Now
                    },
                    new tblUsersPhoneNumbers
                    {
                        Id = Guid.NewGuid(),
                        NameUser = "Ocean Glenn",
                        PhoneNumber = "(035533) 476735",
                        AddedDate = DateTime.Now
                    },
                    new tblUsersPhoneNumbers
                    {
                        Id = Guid.NewGuid(),
                        NameUser = "Rebekah Mooney",
                        PhoneNumber = "(0977) 85347403",
                        AddedDate = DateTime.Now
                    }, new tblUsersPhoneNumbers
                    {
                        Id = Guid.NewGuid(),
                        NameUser = "Alexander Hendrix",
                        PhoneNumber = "(06494) 3685877",
                        AddedDate = DateTime.Now
                    },
                    new tblUsersPhoneNumbers
                    {
                        Id = Guid.NewGuid(),
                        NameUser = "Lamar Robles",
                        PhoneNumber = "(00593) 5308822",
                        AddedDate = DateTime.Now
                    },
                    new tblUsersPhoneNumbers
                    {
                        Id = Guid.NewGuid(),
                        NameUser = "Colorado Dotson",
                        PhoneNumber = "(058) 41455821",
                        AddedDate = DateTime.Now
                    },
                    new tblUsersPhoneNumbers
                    {
                        Id = Guid.NewGuid(),
                        NameUser = "Madaline Vinson",
                        PhoneNumber = "(035) 45331372",
                        AddedDate = DateTime.Now
                    },
                    new tblUsersPhoneNumbers
                    {
                        Id = Guid.NewGuid(),
                        NameUser = "Elijah Mueller",
                        PhoneNumber = "(032476) 601138",
                        AddedDate = DateTime.Now
                    },
                    new tblUsersPhoneNumbers
                    {
                        Id = Guid.NewGuid(),
                        NameUser = "Lana Hudson",
                        PhoneNumber = "(095) 35767831",
                        AddedDate = DateTime.Now
                    },
                    new tblUsersPhoneNumbers
                    {
                        Id = Guid.NewGuid(),
                        NameUser = "Cally Barr",
                        PhoneNumber = "(0857) 53334108",
                        AddedDate = DateTime.Now
                    },
                    new tblUsersPhoneNumbers
                    {
                        Id = Guid.NewGuid(),
                        NameUser = "Tanisha Gutierrez",
                        PhoneNumber = "(01137) 7162891",
                        AddedDate = DateTime.Now
                    },
                    new tblUsersPhoneNumbers
                    {
                        Id = Guid.NewGuid(),
                        NameUser = "Ocean Glenn",
                        PhoneNumber = "(035533) 476735",
                        AddedDate = DateTime.Now
                    },
                    new tblUsersPhoneNumbers
                    {
                        Id = Guid.NewGuid(),
                        NameUser = "Rebekah Mooney",
                        PhoneNumber = "(0977) 85347403",
                        AddedDate = DateTime.Now
                    }, new tblUsersPhoneNumbers
                    {
                        Id = Guid.NewGuid(),
                        NameUser = "Alexander Hendrix",
                        PhoneNumber = "(06494) 3685877",
                        AddedDate = DateTime.Now
                    },
                    new tblUsersPhoneNumbers
                    {
                        Id = Guid.NewGuid(),
                        NameUser = "Lamar Robles",
                        PhoneNumber = "(00593) 5308822",
                        AddedDate = DateTime.Now
                    },
                    new tblUsersPhoneNumbers
                    {
                        Id = Guid.NewGuid(),
                        NameUser = "Colorado Dotson",
                        PhoneNumber = "(058) 41455821",
                        AddedDate = DateTime.Now
                    },
                    new tblUsersPhoneNumbers
                    {
                        Id = Guid.NewGuid(),
                        NameUser = "Madaline Vinson",
                        PhoneNumber = "(035) 45331372",
                        AddedDate = DateTime.Now
                    },
                    new tblUsersPhoneNumbers
                    {
                        Id = Guid.NewGuid(),
                        NameUser = "Elijah Mueller",
                        PhoneNumber = "(032476) 601138",
                        AddedDate = DateTime.Now
                    },
                    new tblUsersPhoneNumbers
                    {
                        Id = Guid.NewGuid(),
                        NameUser = "Lana Hudson",
                        PhoneNumber = "(095) 35767831",
                        AddedDate = DateTime.Now
                    },
                    new tblUsersPhoneNumbers
                    {
                        Id = Guid.NewGuid(),
                        NameUser = "Cally Barr",
                        PhoneNumber = "(0857) 53334108",
                        AddedDate = DateTime.Now
                    },
                    new tblUsersPhoneNumbers
                    {
                        Id = Guid.NewGuid(),
                        NameUser = "Tanisha Gutierrez",
                        PhoneNumber = "(01137) 7162891",
                        AddedDate = DateTime.Now
                    }
                );
        }
    }
}
