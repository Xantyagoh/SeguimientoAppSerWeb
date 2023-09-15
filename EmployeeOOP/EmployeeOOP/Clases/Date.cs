using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeOOP.Clases
{
    public class Date
    {
        #region Fields

        private int _year;
        private int _month;
        private int _day;

        #endregion

        #region Methods

        public Date(int day, int month, int year)
        {
            _year = year;
            _month = month;
            _day = day;
        }

        public override string ToString()
        {
           //dia/mes/año
            var dateConcatenated1 = _day + "/" + _month + "/" + _year; // La mas vieja y fea
            var dateConcatenated2 = $"{_day}/{_month}/{_year }"; // Interpoblacion
            var dateConcatenated3 =string.Format("{0}/{1}/{2}", _day, _month, _year); // Class String.Format
            return dateConcatenated3;
        }

        #endregion
    }
}
