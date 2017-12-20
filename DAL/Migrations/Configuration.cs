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
               }

            );

            context.TourPriceHistories.AddOrUpdate(x => x.ID,
               new TourPriceHistory()
               {
                   ID = 1,
                   TourID = 1,
                   Price = 13000000,
                   Date = DateTime.Now
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
                   LocationID = 1
               },
               new TourLocation()
               {
                   TourID = 1,
                   LocationID = 2
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
                    Description = "Ngày 01: TP. HỒ CHÍ MINH - HUẾ (Ăn trưa, chiều) \n Buổi sáng, tập trung tại cổng D3 - Ga đi trong nước, sân bay Tân Sơn Nhất ra Huế trên chuyến bay VJ302 lúc 05:40. Đến Huế, tham quan Di sản Văn hóa Thế giới Kinh Thành Huế: Ngọ Môn, điện Thái Hoà, Tử Cấm Thành, Thế Miếu, Hiển Lâm Các, Cửu Đỉnh, Bảo tàng Cổ vật Cung đình Huế. Nhận phòng. Buổi chiều, đoàn vãng cảnh chùa Thiên Mụ. Đoàn tiếp tục đến viếng lăng Minh Mạng. Buổi tối quý khách tự do khám phá cố đô về đêm. Nghỉ đêm tại Huế. Ngày 02.....",
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
