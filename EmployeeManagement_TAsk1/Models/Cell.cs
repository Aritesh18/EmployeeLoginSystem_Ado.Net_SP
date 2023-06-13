using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement_TAsk1.Models
{
    public class Cell
    {
        public int Row { get; set; }
        public int Column { get; set; }
        public string Value { get; set; }

        public Cell(int row, int column, string value)
        {
            Row = row;
            Column = column;
            Value = value;
        }
    }
}





   

