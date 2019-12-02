using Logic.Models;
using Logic.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.LogicsModel
{
    public class LogicInspector
    {

        public static InspectorViewModel GetCurrentInspector()
        {
            var Inspector = from inspector in DbContext.db.Inspector where inspector.Id == SecurityContext.IdUser
                            join position in DbContext.db.Position on inspector.Position equals position.Id
                            select new
                            {
                                inspector.FirstName,
                                inspector.LastName,
                                inspector.Patronymic,
                                Position = position.Name,
                                inspector.Login,
                                inspector.Password
                            };
            InspectorViewModel ViewInspector = new InspectorViewModel
            {
                FirstName = Inspector.FirstOrDefault().FirstName,
                LastName = Inspector.FirstOrDefault().LastName,
                Patronymic = Inspector.FirstOrDefault().Patronymic,
                Position = Inspector.FirstOrDefault().Position,
                Login = Inspector.FirstOrDefault().Login,
                Password = Inspector.FirstOrDefault().Password
            };
            return ViewInspector;
        }
        public static void SaveInspector(InspectorModel inspector)
        {
            DbContext.db.Inspector.Add(inspector);
            DbContext.db.SaveChanges();
        }

        public static InspectorModel GetInfoCurrentInspector()
        {
          return DbContext.db.Inspector.Where(ins => ins.Id == SecurityContext.CurrentInspector).FirstOrDefault();
        }
        public static int GetPositionInspector()
        {
            return (int)DbContext.db.Inspector.Find(SecurityContext.IdUser).Position;
        }

        public static void CurrentInspector(string pasport)
        {
            SecurityContext.CurrentInspector =  DbContext.db.Inspector.Where(ins => ins.PasportSeries == pasport.Substring(0, 4) && ins.PasportNumber == pasport.Substring(4, 6)).FirstOrDefault().Id;
        }

        public static DataTable GetListInspector()
        {
            DataTable dtInspector = new DataTable();
            dtInspector.Columns.Add("ФИО");
            dtInspector.Columns.Add("Паспорт");
            dtInspector.Columns.Add("Логин");
            dtInspector.Columns.Add("Дата рождения");
            dtInspector.Columns.Add("Должность");

            var Query = DbContext.db.Inspector;

            foreach(var ins in Query)
            {
                dtInspector.Rows.Add(ins.FirstName + " " + ins.LastName + " " + ins.Patronymic, ins.PasportSeries + ins.PasportNumber, ins.Login, ins.DateBirth.ToShortDateString(), DbContext.db.Position.Where(pos => pos.Id == ins.Position).FirstOrDefault().Name);
            }
            return dtInspector;
        }

        public static DataTable GetFilterListInspector(string name)
        {
            DataTable dtInspector = new DataTable();
            dtInspector.Columns.Add("ФИО");
            dtInspector.Columns.Add("Паспорт");
            dtInspector.Columns.Add("Логин");
            dtInspector.Columns.Add("Дата рождения");
            dtInspector.Columns.Add("Должность");
            string LastName = "";
            string Patronymic = "";
            string[] NameArray = name.Split(' ');
            if (NameArray.Length <= 3)
            {
                string FirstName = NameArray[0];
                if (NameArray.Length > 1) LastName = NameArray[1];
                if (NameArray.Length > 2) Patronymic = NameArray[2];

                var Query = DbContext.db.Inspector.Where
                (ins=>(ins.FirstName.Contains(FirstName) || ins.LastName.Contains(FirstName) || ins.Patronymic.Contains(FirstName))
                && (ins.FirstName.Contains(LastName) || ins.LastName.Contains(LastName) || ins.Patronymic.Contains(LastName))
                && (ins.FirstName.Contains(Patronymic) || ins.LastName.Contains(Patronymic) || ins.Patronymic.Contains(Patronymic))
                );
                foreach (var ins in Query)
                {
                    dtInspector.Rows.Add(ins.FirstName + " " + ins.LastName + " " + ins.Patronymic, ins.PasportSeries + ins.PasportNumber, ins.Login, ins.DateBirth.ToShortDateString(), DbContext.db.Position.Where(pos => pos.Id == ins.Position).FirstOrDefault().Name);
                }
            }
            return dtInspector;
        }
    }
}
