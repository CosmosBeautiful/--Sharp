using System;
using System.Collections.Generic;
using System.Linq;

namespace _17_Linq
{
    class Controller
    {
        List<User> users;
        List<Car> cars;
        List<UserCar> user_cars;

        public Controller()
        {
            users = new List<User>
            {
                new User {Id = 0,  FirstName = "Иван",LastName = "Иванов",  Phone = "+7(748)785-78-74"},
                new User {Id = 1,  FirstName = "Олег",LastName = "Олегов",  Phone = "+7(455)365-78-25"},
                new User {Id = 2,  FirstName = "Петр",LastName = "Петров",  Phone = "+7(985)254-78-95"}
            };

            cars = new List<Car>
            {
                new Car {Id = 0, Mark = "Toyota", Model = "Corolla", Year = DateTime.Parse("2/11/2015"), Color = "White"},
                new Car {Id = 1, Mark = "BMW", Model = "M5", Year = DateTime.Parse("21/02/2016"), Color = "Black"},
                new Car {Id = 2, Mark = "Lada", Model = "Vesta", Year = DateTime.Parse("9/05/2004"), Color = "Red"},
                new Car {Id = 3, Mark = "Audi", Model = "A5", Year = DateTime.Parse("15/12/1998"), Color = "Green"}
            };

            user_cars = new List<UserCar>
            {
                new UserCar{ Id = 0, UserId = 0, CarId = 1, Date = DateTime.Parse("4/04/2017") },
                new UserCar{ Id = 1, UserId = 1, CarId = 1, Date = DateTime.Parse("17/06/2017") },
                new UserCar{ Id = 2, UserId = 2, CarId = 0, Date = DateTime.Parse("28/06/2017") },
                new UserCar{ Id = 3, UserId = 1, CarId = 2, Date = DateTime.Parse("5/07/2017") },
                new UserCar{ Id = 4, UserId = 1, CarId = 3, Date = DateTime.Parse("7/08/2017") },
                new UserCar{ Id = 5, UserId = 2, CarId = 3, Date = DateTime.Parse("19/08/2017") },

            };
        }


        public dynamic QueryUserCars()
        {
            //var query =    //Анонимный метод
            dynamic query = 
                from uc in user_cars
                join u in users on uc.UserId equals u.Id
                join c in cars on uc.CarId equals c.Id
                where uc.UserId == 1
                select new
                {
                    Id = uc.Id,
                    Name = u.FirstName + " " + u.LastName,
                    Mark = c.Mark,
                    Model = c.Model,
                    Year = c.Year,
                    Color = c.Color
                };

            return query;
        }

    }
}
