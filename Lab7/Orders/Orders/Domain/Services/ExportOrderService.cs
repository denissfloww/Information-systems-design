using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orders.Domain.Models;
using Excel = Microsoft.Office.Interop.Excel;

namespace Orders.Domain.Services
{
    public class ExportOrderService
    {
        //TODO: Добавить Export методы, определиться с возвращаемым типом

        public static Excel.Worksheet ExportOrders(List<Order> orders)
        {
            var columns = new List<string>()
            {
                "Номер",
                "Место",
                "Цель",
                "Дата создания",
                "Исполнитель"
            };
            Excel.Application excelApp= new Excel.Application();
            Excel.Workbook workBook;
            Excel.Worksheet workSheet;
            workBook = excelApp.Workbooks.Add();
            workSheet = (Excel.Worksheet)workBook.Worksheets.get_Item(1);

            for (int i = 1; i <= columns.Count; i++)
                workSheet.Cells[1, i] = columns[i-1];


            for (int i = 2; i <= orders.Count; i++)
            {
                workSheet.Cells[i][1] = orders[i-2].Id;
                workSheet.Cells[i][2] = orders[i-2].Plans.Place;
                workSheet.Cells[i][3] = orders[i-2].CatchGoal;
                workSheet.Cells[i][4] = orders[i-2].DateCreate.Value.ToString("dd.MM.yyyy");
                workSheet.Cells[i][5] = orders[i-2].Plans.Organizations.Name;
            }


            return workSheet;
        }
    }
}
