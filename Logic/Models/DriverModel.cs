using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase.EntityModels;
namespace Logic.Models
{
    public class DriverModel
    {

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [StringLength(50)]
        public string Patronymic { get; set; }

        [Required]
        [StringLength(4)]
        public string SerialPasp { get; set; }

        [Required]
        [StringLength(6)]
        public string NumberPasp { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateBirth { get; set; }

        [StringLength(50)]
        public string AddressCity { get; set; }

        [StringLength(100)]
        public string FullAddress { get; set; }

        [Required]
        [StringLength(12)]
        public string Telephone { get; set; }

        public int? DrivingExperience { get; set; }

        public int? InsuranceId { get; set; }

        public int PostCode { get; set; }

        [Required]
        [StringLength(50)]
        public string Company { get; set; }

        [Required]
        [StringLength(50)]
        public string JobName { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        public byte[] Photo { get; set; }

        [StringLength(50)]
        public string AddressLifeCity { get; set; }

        [StringLength(100)]
        public string FullAddressLife { get; set; }

        public static implicit operator DriversEntityModels(DriverModel driver)
        {
            return new DriversEntityModels
            {
                FirstName = driver.FirstName,
                LastName = driver.LastName,
                Patronymic = driver.Patronymic,
                SerialPasp = driver.SerialPasp,
                NumberPasp = driver.NumberPasp,
                DateBirth = driver.DateBirth,
                FullAddress = driver.FullAddress,
                AddressLifeCity = driver.AddressLifeCity,
                FullAddressLife = driver.FullAddressLife,
                AddressCity = driver.AddressCity,
                Telephone = driver.Telephone,
                DrivingExperience = driver.DrivingExperience,
                InsuranceId = driver.InsuranceId,
                PostCode = driver.PostCode,
                Company = driver.Company,
                JobName = driver.JobName,
                Email = driver.Email,
                Photo = driver.Photo
            };
        }

        public static implicit operator DriverModel(DriversEntityModels driver)
        {
            return new DriverModel
            {
                FirstName = driver.FirstName,
                LastName = driver.LastName,
                Patronymic = driver.Patronymic,
                SerialPasp = driver.SerialPasp,
                NumberPasp = driver.NumberPasp,
                DateBirth = driver.DateBirth,
                FullAddress = driver.FullAddress,
                AddressLifeCity = driver.AddressLifeCity,
                FullAddressLife = driver.FullAddressLife,
                AddressCity = driver.AddressCity,
                Telephone = driver.Telephone,
                DrivingExperience = driver.DrivingExperience,
                InsuranceId = driver.InsuranceId,
                PostCode = driver.PostCode,
                Company = driver.Company,
                JobName = driver.JobName,
                Email = driver.Email,
                Photo = driver.Photo
            };
        }
    }
}
