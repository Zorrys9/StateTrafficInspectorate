using Logic.Models;
using Logic.ViewModels;
using System;
using System.Collections.Generic;
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

    }
}
