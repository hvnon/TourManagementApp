namespace DAL.Migrations
{
    using DAL.Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.TourContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DAL.TourContext context)
        {
            context.Cities.AddOrUpdate(x => x.ID,
                new City() { ID = 1, Code = "01", Name = "Hà Nội" },
                new City() { ID = 2, Code = "02", Name = "TP. Hồ Chí Minh" },
                new City() { ID = 3, Code = "03", Name = "TP. Hải Phòng" },
                new City() { ID = 4, Code = "04", Name = "TP. Đà Nẵng" },
                new City() { ID = 5, Code = "05", Name = "Tỉnh Hà Giang" },
                new City() { ID = 6, Code = "33", Name = "Tỉnh Thừa Thiên - Huế" },
                new City() { ID = 7, Code = "34", Name = "Tỉnh Quảng Nam" }

            );
            context.Districts.AddOrUpdate(x => x.ID,
                new District() { ID = 1, CityID = 1, Code = "01", Name = "Quận Ba Đình" },
                new District() { ID = 2, CityID = 2, Code = "01", Name = "Quận 1" },
                new District() { ID = 3, CityID = 3, Code = "01", Name = "Quận Hồng Bàng" },
                new District() { ID = 4, CityID = 4, Code = "01", Name = "Quận Hải Châu" },
                new District() { ID = 5, CityID = 5, Code = "01", Name = "Thành phố Hà Giang" },
                new District() { ID = 6, CityID = 6, Code = "01", Name = "Thành phố Huế" },
                new District() { ID = 7, CityID = 7, Code = "02", Name = "Thành phố Hội An" }
            );
            context.TourTypes.AddOrUpdate(x => x.ID,
               new TourType() { ID = 1, Name = "Du lịch tham quan" },
               new TourType() { ID = 2, Name = "Du lịch văn hóa" },
               new TourType() { ID = 3, Name = "Du lịch ẩm thực" }
            );
            context.Tours.AddOrUpdate(x => x.ID,
               new Tour()
               {
                   ID = 1,
                   Code = "T0001",
                   Name = "Tour đi Huế - Đà nẵng - Hội An",
                   TourTypeID = 1,
                   FromCity = 2,
                   FromDistrict = 2,
                   Day = 3,
                   Night = 2,
                   Status = "Đang bán",
                   Price = 13000000,
                   Description = ""
               },
               new Tour()
               {
                   ID = 2,
                   Code = "T0002",
                   Name = "Tour đi Sài Gòn - Cần Thơ - Cà Mau",
                   TourTypeID = 1,
                   FromCity = 2,
                   FromDistrict = 2,
                   Day = 4,
                   Night = 3,
                   Status = "Đang bán",
                   Price = 17000000,
                   Description = ""
               },
               new Tour()
               {
                   ID = 3,
                   Code = "T0003",
                   Name = "Tour đi Bà Rịa - Vũng Tàu",
                   TourTypeID = 1,
                   FromCity = 2,
                   FromDistrict = 3,
                   Day = 2,
                   Night = 1,
                   Status = "Đang bán",
                   Price = 8000000,
                   Description = ""
               },
               new Tour()
               {
                   ID = 4,
                   Code = "T0004",
                   Name = "Tour đi Nha Trang",
                   TourTypeID = 1,
                   FromCity = 1,
                   FromDistrict = 4,
                   Day = 3,
                   Night = 2,
                   Status = "Đang bán",
                   Price = 13000000,
                   Description = ""
               },
               new Tour()
               {
                   ID = 5,
                   Code = "T0005",
                   Name = "Tour đi Hải Phòng - Hà Nội",
                   TourTypeID = 1,
                   FromCity = 3,
                   FromDistrict = 5,
                   Day = 7,
                   Night = 7,
                   Status = "Đang bán",
                   Price = 30000000,
                   Description = ""
               }

            );

            context.TourPriceHistories.AddOrUpdate(x => x.ID,
               new TourPriceHistory()
               {
                   ID = 1,
                   TourID = 1,
                   Price = 13000000,
                   Date = DateTime.Parse("2017-12-21")
               },
               new TourPriceHistory()
               {
                   ID = 2,
                   TourID = 2,
                   Price = 17000000,
                   Date = DateTime.Parse("2017-12-22")
               }, 
               new TourPriceHistory()
               {
                   ID = 3,
                   TourID = 3,
                   Price = 8000000,
                   Date = DateTime.Parse("2017-12-23")
               }, 
               new TourPriceHistory()
               {
                   ID = 4,
                   TourID = 4,
                   Price = 13000000,
                   Date = DateTime.Parse("2017-12-24")
               }, new TourPriceHistory()
               {
                   ID = 5,
                   TourID = 5,
                   Price = 30000000,
                   Date = DateTime.Parse("2017-12-24")
               }
            );
            context.Locations.AddOrUpdate(x => x.ID,
               new Location()
               {
                   ID = 1,
                   CityID = 6,
                   DistrictID = 6,
                   Name = "Kinh Thành Huế: Ngọ Môn"
               },
               new Location()
               {
                   ID = 2,
                   CityID = 4,
                   DistrictID = 4,
                   Name = "Chùa Thiên Mụ"
               },
               new Location()
               {
                   ID = 3,
                   CityID = 1,
                   DistrictID = 1,
                   Name = "Động Batu"
               },
               new Location()
               {
                   ID = 4,
                   CityID = 1,
                   DistrictID = 1,
                   Name = "Chùa một cột"
               }
            );
            context.TourLocations.AddOrUpdate(
               new TourLocation()
               {
                   TourID = 1,
                   LocationID = 1,
                   Order = 1
               },
               new TourLocation()
               {
                   TourID = 1,
                   LocationID = 2,
                   Order = 2
               }
            );
            context.Customers.AddOrUpdate(x => x.ID,
                new Customer()
                {
                    ID = 1,
                    Code = "KH0001",
                    LastName = "Nguyễn",
                    FirstName = "Văn A",
                    IdentityNumber = "0241522312",
                    Phone = "01677773222",
                    Address = "273 An Dương Vương",
                    BirthDate = DateTime.Parse("1999-11-19"),
                    Gender = true
                },
                new Customer()
                {
                    ID = 2,
                    Code = "KH0002",
                    LastName = "Trần",
                    FirstName = "Thị Bưởi",
                    IdentityNumber = "0233444111",
                    Phone = "01622333111",
                    Address = "142 Trần Bình Trọng",
                    BirthDate = DateTime.Parse("1995-12-09"),
                    Gender = false
                },
                new Customer()
                {
                    ID = 3,
                    Code = "KH0003",
                    LastName = "Trần",
                    FirstName = "Văn Chính",
                    IdentityNumber = "0232444111",
                    Phone = "01622333134",
                    Address = "142 Hoà Hưng",
                    BirthDate = DateTime.Parse("1995-04-09"),
                    Gender = true
                },
                new Customer()
                {
                    ID = 4,
                    Code = "KH0004",
                    LastName = "Nguyễn",
                    FirstName = "Thị Nga",
                    IdentityNumber = "0246444111",
                    Phone = "016223331123",
                    Address = "1 Trường Sa",
                    BirthDate = DateTime.Parse("1995-12-05"),
                    Gender = false
                },
                new Customer()
                {
                    ID = 5,
                    Code = "KH0005",
                    LastName = "Trần",
                    FirstName = "Công Đài",
                    IdentityNumber = "0213444111",
                    Phone = "01622333311",
                    Address = "2 Cộng Hoà",
                    BirthDate = DateTime.Parse("1995-04-03"),
                    Gender = true
                },
                new Customer()
                {
                    ID = 6,
                    Code = "KH0006",
                    LastName = "Đoàn",
                    FirstName = "Dự",
                    IdentityNumber = "0112444111",
                    Phone = "01622333932",
                    Address = "14 Hoà Hưng",
                    BirthDate = DateTime.Parse("1995-12-09"),
                    Gender = true
                },
                new Customer()
                {
                    ID = 7,
                    Code = "KH0007",
                    LastName = "Trần",
                    FirstName = "Thị Cúc",
                    IdentityNumber = "0212444111",
                    Phone = "01622332121",
                    Address = "65 Trần Hưng Đạo",
                    BirthDate = DateTime.Parse("1995-11-09"),
                    Gender = false
                },
                new Customer()
                {
                    ID = 8,
                    Code = "KH0008",
                    LastName = "Trần",
                    FirstName = "Chí Công",
                    IdentityNumber = "0232214111",
                    Phone = "01622332134",
                    Address = "56 Thành Thái",
                    BirthDate = DateTime.Parse("1995-10-05"),
                    Gender = true
                },
                new Customer()
                {
                    ID = 9,
                    Code = "KH0009",
                    LastName = "Nguyễn",
                    FirstName = "Thị Linh",
                    IdentityNumber = "0233314111",
                    Phone = "01622999111",
                    Address = "1 Đa Kao",
                    BirthDate = DateTime.Parse("1995-12-11"),
                    Gender = false
                },
                new Customer()
                {
                    ID = 10,
                    Code = "KH0010",
                    LastName = "Trần",
                    FirstName = "Đào",
                    IdentityNumber = "0244444111",
                    Phone = "01622333888",
                    Address = "44 Nguyễn Trãi",
                    BirthDate = DateTime.Parse("1995-06-01"),
                    Gender = false
                }
            );
            context.Employees.AddOrUpdate(x => x.ID,
                new Employee()
                {
                    ID = 1,
                    LastName = "Đoàn",
                    FirstName = "Văn Long",
                    IdentityNumber = "025379733",
                    Phone = "01685317621",
                    Address = "27 Âu Cơ",
                    BirthDate = DateTime.Parse("1981-10-05"),
                    Gender = true
                },
                new Employee()
                {
                    ID = 2,
                    LastName = "Hoàng",
                    FirstName = "Minh Thi",
                    IdentityNumber = "0254664555",
                    Phone = "0122119145",
                    Address = "17 Lạc Long Quân",
                    BirthDate = DateTime.Parse("1991-08-13"),
                    Gender = false
                }
            );
            context.FeeTypes.AddOrUpdate(x => x.ID,
                new FeeType()
                {
                    ID = 1,
                    Name = "Phí ăn uống"
                },
                new FeeType()
                {
                    ID = 2,
                    Name = "Phí khách sạn"
                },
                new FeeType()
                {
                    ID = 3,
                    Name = "Phí phương tiện"
                },
                new FeeType()
                {
                    ID = 4,
                    Name = "Phí tham quan"
                },
                new FeeType()
                {
                    ID = 5,
                    Name = "Phí khác"
                }
            );
            context.Groups.AddOrUpdate(x => x.ID,
                new Group()
                {
                    ID = 1,
                    Code = "D0001",
                    TourID = 1,
                    Name = "Đoàn Huế - Đà Nẵng - Hội An 01",
                    StartDate = DateTime.Parse("2017-11-19"),
                    EndDate = DateTime.Parse("2017-11-21"),
                    PickupLocation = "21 Trần Quang Khải",
                    DropLocation = "21 Trần Quang Khải",
                    Description = "Ngày 01: TP. HỒ CHÍ MINH - HUẾ (Ăn trưa, chiều) \n Buổi sáng, tập trung tại cổng D3 - Ga đi trong nước...",
                    Policy = "Giá tour bao gồm những gì, không bao gồm những gì, hủy tour thì sao...."
                },
                new Group()
                {
                    ID = 2,
                    Code = "D0002",
                    TourID = 1,
                    Name = "Đoàn Huế - Đà Nẵng - Hội An 02",
                    StartDate = DateTime.Parse("2017-11-26"),
                    EndDate = DateTime.Parse("2017-11-28"),
                    PickupLocation = "145 Nguyễn Bỉnh Khiêm",
                    DropLocation = "101 Mạc Đĩnh Chi",
                    Description = "Mô tả chương trình du lịch ở đây...."
                }
            );
            context.GroupHistories.AddOrUpdate(x => x.ID,
               new GroupHistory()
               {
                   ID = 1,
                   GroupID = 1,
                   Date = DateTime.Parse("2017-12-21")
               },
               new GroupHistory()
               {
                    ID = 2,
                    GroupID = 2,
                    Date = DateTime.Parse("2017-12-21")
               }
            );
            context.GroupFees.AddOrUpdate(x => x.ID,
               new GroupFee()
               {
                   ID = 1,
                   GroupID = 1,
                   FeeTypeID = 4,
                   Description = "Tham quan chùa Thiên Mụ. 30 nghìn 1 vé/ 1 người",
                   Price = 30000
               },
               new GroupFee()
               {
                   ID = 2,
                   GroupID = 1,
                   FeeTypeID = 4,
                   Description = "Tham quan Di sản Văn hóa Thế giới Kinh Thành Huế: Ngọ Môn. 80 nghìn 1 vé/ 1 người",
                   Price = 80000
               },
               new GroupFee()
               {
                   ID = 3,
                   GroupID = 1,
                   FeeTypeID = 1,
                   Description = "Ăn sáng, trưa chiều tại nhà hàng Hương Sen. 1 bàn 5 người 500 nghìn => 1 người 100 nghìn",
                   Price = 100000
               }
            );
            context.CustomerGroups.AddOrUpdate(x => x.ID,
               new CustomerGroup()
               {
                   ID = 1,
                   CustomerID = 1,
                   GroupID = 1
               },
               new CustomerGroup()
               {
                   ID = 2,
                   CustomerID = 2,
                   GroupID = 1
               }
            );
            context.Roles.AddOrUpdate(x => x.ID,
               new Role()
               {
                   ID = 1,
                   EmployeeID = 1,
                   GroupID = 1,
                   RoleName = "Hướng dẫn viên",
               },
               new Role()
               {
                   ID = 2,
                   EmployeeID = 2,
                   GroupID = 1,
                   RoleName = "Tài xế",
               }
            );
        }
    }
}
