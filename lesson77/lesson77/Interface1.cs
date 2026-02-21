using System;
using System.Collections.Generic;
using System.Text;

namespace lesson77
{
    interface IDataProvider
    {
        string GetData();
    }
    interface IDataProcessor
    {
        void ProcessData(IDataProvider dataProvider);
    }
}
