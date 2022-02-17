using System;
using System.Collections.Generic;
using System.Text;

namespace Task
{
    class PointsTestResult
    {
        private int _numberOfIteration;

        private DateTime _timeExecutingClass;

        private DateTime _timeExecutingStruct;

        public int NumberOfIteration { get => _numberOfIteration; set => _numberOfIteration = value; }

        public DateTime TimeExecutingClass { get => _timeExecutingClass; set => _timeExecutingClass = value; }

        public DateTime TimeExecutingStruct { get => _timeExecutingStruct; set => _timeExecutingStruct = value; }
    }
}
