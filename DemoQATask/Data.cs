using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQATask
{
    class Data
    {
        FormInputs FI;


        public FormInputs DataRecord()
        {
            FI = new FormInputs
            {
                firstname = "Abid",
                lastname = "Ali",
                gender = 'M',
                nummber = "3472467552"
            };

            return FI;
        }
    }
}
