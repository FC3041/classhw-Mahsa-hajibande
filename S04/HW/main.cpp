#include <iostream>
#include <string.h>
#include <stdlib.h>
using namespace std ;

class Date
{
    public :
    int day ;
    int month ;
    int year ;

    Date (int myday , int mymonth , int myyear)
    {
        day = myday ;
        month = mymonth ;
        year = myyear ;
        cout << "your birth day : " << day << endl ;
        cout << "your birth month : " << month << endl ;
        cout << "your birth year : " << year << endl ;
    }
};

class Person
{
    public :
    int m_NID ;
    char* m_Fname ;
    char* m_Lname ;
    Date m_BD ;

    Person (const char* FirstName , const char* LastName , int ID , Date BirthDay)
    : m_NID(ID), m_BD(BirthDay)
    {
       //m_BD = BirthDay ;
       //m_NID = ID ;
       char* m_Fname = new char [strlen (FirstName) + 1] ;
       strcpy (m_Fname , FirstName) ;
       char* m_Lname = new char [strlen (LastName) + 1] ;
       strcpy (m_Lname , LastName) ;
       cout << "your First name : " << FirstName << endl ;
       cout << "your Last name : " << LastName << endl ;
       cout << "your ID : " << ID << endl ;
       Date d1 () ;
    }
};

int main ()
{
    Date d1 (10 , 01 , 2005) ;
    Person p1 ("Mahsa" , "Hajibande" , 12345 , d1) ;
}