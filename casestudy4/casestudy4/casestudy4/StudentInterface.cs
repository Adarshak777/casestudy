using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace casestudy4
{
    public interface StudentInterface
    {
        int InsertStudent(student student);
        student GetDetails(int id);
        List<student> Details();
        int DeleteStudent(int id);

    }
}
