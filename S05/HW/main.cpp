#include <iostream>
#include <stdlib.h>
#include <string.h>
using namespace std ;

class String
{
    public :
    int m_size ;
    char* m_members ;

    void MakeString (int Size , const char* Members)
    {
        m_members = (char*) malloc (sizeof (char) * (Size + 1)) ;
        for (int i = 0 ; i < Size; i++)
        {
            m_members [i] = Members [i] ;
        }
        m_members [Size] = '\0' ;
        cout << "your list : " << m_members << endl ;
    }

    void  Append_String (const char* Name1 , const char* Name2)
    {
        int Size = strlen (Name1) + strlen (Name2) + 1 ;
        char* m_members = (char*) malloc (sizeof (char) * (Size)) ;
        for (int i = 0 ; i < strlen (Name1) ; i++)
        {
            m_members [i] = Name1 [i] ;
        }
        for (int i = 0 ; i < Size ; i++)
        {
            m_members [strlen (Name1) + i] = Name2 [i] ;
        }
        m_members [Size] = '\0' ;
        cout << "new list : " << m_members << endl ;
    }

    void Assign (const char* Name1 , const char* Name2)
    {
        m_members = (char*) malloc (sizeof (char) * (strlen (Name1) + 1)) ;
        for (int i = 0 ; i < strlen (Name1) ; i++)
        {
            m_members [i] = Name1 [i] ;
        }
        cout << "befor assign : " << Name1 << endl ;
        m_members = (char*) malloc (sizeof (char) * (strlen (Name2) + 1)) ;
        for (int i = 0 ; i < strlen (Name2) ; i++)
        {
            m_members [i] = Name2 [i] ;
        }
        cout << "after assign : " << Name2 << endl ;
    }

    void Append_Names (const char* Name1 , const char* Name2)
    {
        int Size = strlen (Name1) + strlen (Name2) + 1 + 3 ;
        char* m_members = (char*) malloc (sizeof (char) * (Size)) ;
        for (int i = 0 ; i < strlen (Name1) ; i++)
        {
            m_members [i] = Name1 [i] ;
        }
        cout << "adding names : " << m_members ;
        cout << " + " ;
        for (int i = 0 ; i < strlen (Name2) ; i++)
        {
            m_members [i] = Name2 [i] ;
        }
        m_members [Size] = '\0' ;
        cout << m_members << endl ;
    }
};

int main ()
{
    String string1 ;
    String string2 ;
    string1.MakeString (3 , "asd") ;
    string2.Append_String ("hello" , "bye") ;
    string2.Assign ("ali" , "hasan") ;
    string2.Append_Names ("ali" , "hasan") ;
}