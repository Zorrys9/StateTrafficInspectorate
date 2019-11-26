using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase.EntityModels;

namespace Logic.ViewModels
{
    public class DriverViewModel
    {

        public string Name { get; set; }
        public DateTime DateBirth { get; set; }
        public string Passport { get; set; }
        public string FullAddress { get; set; }
        public string Telephone { get; set; }
        public int? DrivingExperience { get; set; }
        public string Email { get; set; }
        public byte[] Photo { get; set; }
        public string AddressLife { get; set; }
        public int PostCode { get; set; }
        public string Company { get; set; }
        public string JobName { get; set; }

        public static implicit operator DriverViewModel(DriversEntityModels driver)
        {
            return new DriverViewModel
            {
                Name = driver.FirstName + " " + driver.LastName + " " + driver.Patronymic,
                DateBirth = driver.DateBirth,
                Passport = driver.SerialPasp + driver.NumberPasp,
                FullAddress = driver.FullAddress,
                Telephone = driver.Telephone,
                DrivingExperience = driver.DrivingExperience,
                Email = driver.Email,
                Photo = driver.Photo,
                AddressLife = driver.FullAddressLife,
                PostCode = driver.PostCode,
                Company = driver.Company,
                JobName = driver.JobName
            };
        }
    }
}
