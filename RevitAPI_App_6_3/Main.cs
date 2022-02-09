using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Создайте приложение, которое позволяет расставлять определенное количество элементов
//модели между двумя точками. Приложение должно работать так: приложение
//запрашивает начальную и конечную точку. Далее появляется окно со списком типов
//семейств и количество элементов, которое установится между указанными точками.


namespace RevitAPI_App_6_3

{
    [Transaction(TransactionMode.Manual)]

    public class Main : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            TaskDialog.Show("Внимание!", "Необходимо указать начальную и конечную точку, ограничивающих расстояние вставки элементов. " +
                "Затем появится окно с выбором элементов");

            var mainView = new MainView(commandData);
            mainView.ShowDialog();
            return Result.Succeeded;
        }
    }
}
