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
                dtInspector.Rows.Add(ins.FirstName + " " + ins.LastName + " " + ins.Patronymic, ins.PasportSeries + ins.PasportNumber, ins.Login, ins.DateBirth.ToString(), DbContext.db.Position.Where(pos => pos.Id == ins.Position).FirstOrDefault().Name);
            }
            return dtInspector;
        }
    }
}
