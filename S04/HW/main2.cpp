#include <iostream>
#include <string.h>
#include <stdlib.h>
using namespace std ;

class MyList
{
    public :
    int m_size ;
    int* m_members ;

    MyList (int size , int* members)
    {
        m_members = (int*) malloc (sizeof(int) * size);
        m_size = size ;
        for (int i = 0 ; i < size ; i++)
        {
            m_members [i] = members [i] ;
        }
    }

    void resize (int newsize)
    {
        int* NewMember = (int*) malloc (sizeof (int) * newsize) ;
        for (int i = 0 ; i < newsize ; i++)
        {
            NewMember [i] = m_members [i] ;
        }
        free (m_members) ;
        m_size = newsize ;
        m_members = NewMember ;
    }

    void pop ()
    {
        resize (m_size - 1) ;
    }

    void print ()
    {
        cout << "List : " ;
        for (int i = 0 ; i < m_size ; i++)
        {
            cout << m_members [i] << " " ;
        }
    }

    void append (int n)
    {
        resize (m_size + 1) ;
        m_members [m_size - 1] = n ;
    }

    int count ()
    {
        return m_size ;
    }
};

int main ()
{
    int nums [3] = {1,2,3} ;
    MyList List1 (3 , nums) ;
    List1.append (4) ;
    List1.print () ;
}