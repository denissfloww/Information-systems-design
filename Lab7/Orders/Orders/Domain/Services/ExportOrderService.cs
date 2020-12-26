using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Word;
using Orders.Domain.Models;
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;

namespace Orders.Domain.Services
{
    public class ExportOrderService
    {
        //TODO: Добавить Export методы, определиться с возвращаемым типом

        public static Excel.Application ExportOrders(List<Order> orders)
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
            workBook =excelApp.Workbooks.Add();
            workSheet = (Excel.Worksheet)workBook.Worksheets.get_Item(1);

            for (int i = 1; i <= columns.Count; i++)
                workSheet.Cells[1, i] = columns[i-1];


            for (int i = 2; i <= orders.Count+1; i++)
            {
                workSheet.Cells[i,1] = orders[i-2].Id;
                workSheet.Cells[i,2] = orders[i-2].Plans.Place;
                workSheet.Cells[i,3] = orders[i-2].CatchGoal;
                workSheet.Cells[i,4] = orders[i-2].DateCreate.Value.ToString("dd.MM.yyyy");
                workSheet.Cells[i,5] = orders[i-2].Users.Organizations.Name;
            }
    

            return excelApp;
        }

        public static Word.Application ExportOrder(Order order)
        {
            Word.Application wordApp = new Word.Application();
            _Document oDoc = wordApp.Documents.Add(Path.Combine(Environment.CurrentDirectory, "template.dotx"));

            oDoc.Bookmarks["Id"].Range.Text = order.Id.ToString();
            var dd = $"\"{order.DateCreate.Value.ToString("dd")}\"";
            oDoc.Bookmarks["DateCreate"].Range.Text = dd + order.DateCreate.Value.ToString(" MMMM yyyy г.");
            oDoc.Bookmarks["City"].Range.Text = "г. Тюмень";
            oDoc.Bookmarks["Date"].Range.Text = order.Plans.Date.ToShortDateString();
            oDoc.Bookmarks["Place"].Range.Text = order.Plans.Place;
            oDoc.Bookmarks["ClientOrg"].Range.Text = order.Plans.Organizations.Name;
            oDoc.Bookmarks["ClientOrgAddress"].Range.Text = order.Plans.Organizations.Address;
            oDoc.Bookmarks["ClientOrgTel"].Range.Text = order.Plans.Organizations.Number;
            oDoc.Bookmarks["PerformerOrg"].Range.Text = order.Users.Organizations.Name;
            oDoc.Bookmarks["PerformerOrgAddress"].Range.Text = order.Users.Organizations.Address;
            oDoc.Bookmarks["PerformerOrgTel"].Range.Text = order.Users.Organizations.Number;

            return wordApp;
        }
    }
}
