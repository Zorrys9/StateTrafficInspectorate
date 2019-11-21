using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase.EntityModels;

namespace Logic.ViewModels
{
    public class DriverView
    {

        public string Name { get; set; }
        public DateTime DateBirth { get; set; }
        public string Passport { get; set; }
        public string FullAddress { get; set; }
        public string Telephone { get; set; }
        public int? DrivingExperience { get; set; }
        public string Email { get; set; }

        public static implicit operator DriverView(DriversEntityModels driver)
        {
            return new DriverView
            {
                Name = driver.FirstName + "." + driver.LastName.Substring(0, 1) + "." + driver.Patronymic.Substring(0, 1),
                DateBirth = driver.DateBirth,
                Passport = driver.SerialPasp + " " + driver.NumberPasp,
                FullAddress = driver.AddressCity + " " + driver.FullAddress,
                Telephone = driver.Telephone,
                DrivingExperience = driver.DrivingExperience,
                Email = driver.Email
            };
        }
    }
}
