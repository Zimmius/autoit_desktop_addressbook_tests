using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoItX3Lib;

namespace autoit_desktop_addressbook_tests
{
    public class HelperBase
    {
        protected ApplicationManager manager;
        protected string WINTITLE;
        protected AutoItX3 aux;

        public HelperBase(ApplicationManager manager)
        {
            this.manager = manager;
            WINTITLE = ApplicationManager.WINTITLE;
            this.aux = manager.Aux;
        }
    }
}