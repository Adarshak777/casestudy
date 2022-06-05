using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace casestudy3
{
    public interface UserInterface1
    {
        void showFirstScreen();

         void showStudentScreen();

         void showAdminScreen();

        void showAllStudentsScreen();

         void showStudentRegistrationScreen(); // Execute the register method of AppEngine class

         void introduceNewCourseScreen();

         void showAllCoursesScreen();
        void updateCourse();

    }
}
