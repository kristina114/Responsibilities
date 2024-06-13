using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Responsibilities.Entities
{
    public partial class EmployeeEntities
    {
        private static EmployeeEntities _context;

        public static EmployeeEntities GetContext ()
        {
            if (_context is null)
                _context = new EmployeeEntities();
            return _context;

        }

    }
}
