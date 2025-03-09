#include <iostream>
#include <string.h>
#include <stdlib.h>
using namespace std ;
class Student
{
    public :
    int m_StudentNumber ;
    char* m_FirstName ;
    char* m_LastName ;
    int m_CoursesPassed ;
    int m_Credits [40] ;
    double m_Grades [40] ;
    char* m_CoursesNames [40] ; //ask

    Student (int StudentNumber , const char* FirstName , const char* LastName)
    {
        cout << "Student's Information : " << FirstName << " " << LastName << endl ;
        m_StudentNumber = StudentNumber ;
        m_FirstName = new char [strlen (FirstName) + 1] ;
        strcpy (m_FirstName , FirstName) ;
        m_LastName = new char [strlen (LastName) + 1] ;
        strcpy (m_LastName , LastName) ;
        m_CoursesPassed = 0 ;
    }

    ~Student ()
    {
        cout << "Deleting " << m_FirstName << " " << m_LastName << "'s" << " information ." << endl ;
        for (int i = 0 ; i < m_CoursesPassed ; i++)
        {
            delete [] m_CoursesNames [i] ;
        }
    }
    double GPA ()
    {
        double sumGrade = 0 ;
        int sumCredits = 0 ;
        for (int i = 0 ; i < m_CoursesPassed ; i++)
        {
            sumGrade += m_Credits [i] * m_Grades [i] ;
            sumCredits += m_Credits [i] ;
        }
        return sumGrade / sumCredits ;
    }

    void MakeList ()
    {
        for (int i = 0 ; i < m_CoursesPassed ; i++)
        {
            cout << m_CoursesNames [i] << " : "
                 << m_Credits [i] << " : "
                 << m_Grades [i] << endl ;
        }
    }

    void RegisterCourse (char* Name , int Credits , double Grade)
    {
        m_Credits [m_CoursesPassed] = Credits ;
        m_Grades [m_CoursesPassed] = Grade ;
        char* NameCopy = new char [strlen (Name) + 1] ;
        strcpy (NameCopy , Name) ;
        m_CoursesNames [m_CoursesPassed] = NameCopy ;
        m_CoursesPassed ++ ;
    }
    Student () {}
};


int main ()
{
    Student s (403521195 , "Mahsa" , "Hajibande") ;
    int CoursesPassed ;
    int Credits ;
    double Grade ;
    char Name [20] ;
    cout << "How many courses have you passed ? " ;
    cin >> CoursesPassed  ;
    for (int i = 0 ; i < CoursesPassed ; i++)
    {
        cout << "Course Name ? " ;
        cin >> Name ;
        cout << "Course Credits ? " ;
        cin >> Credits ;
        cout << "Course Grade ? " ;
        cin >> Grade ;
        s.RegisterCourse (Name , Credits , Grade) ;
    }
    s.MakeList () ;
    cout << s.GPA () << endl ;
    return 0 ;
}
