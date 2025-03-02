#include <iostream>
#include <stdlib.h>
#include <string.h>
using namespace std ;

class Vector
{
    public :
    int* m_Nums ;
    int m_Size ;

    Vector (int Size , const int* Nums)
    {
        m_Size = Size ;
        m_Nums = (int*) malloc (sizeof (int) * m_Size) ;
        for (int i = 0 ; i < m_Size ; i++)
        {
            m_Nums [i] = Nums [i] ;
        }
    }
    void Push_back ()
    {
        int* Numbers ;
        Numbers = (int*) malloc (sizeof (int) * (m_Size)) ;
        for (int i = 0 ; i < m_Size ; i++)
        {
            Numbers [i] = m_Nums [i] ;
        }
        cout << "Numbers after pushing back: ";
        for (int i = 0; i < m_Size ; i++)
        {
            cout << Numbers[i] << " ";
        }
        cout << endl;
    }

    void Insert (int n , int m)
    {
        int* Numbers ;
        Numbers = (int*) malloc (sizeof (int) * (m_Size+1)) ;
        cout << "Numbers after inserting : " ;
        for (int i = 0 ; i < n-1 ; i++)
        {
            Numbers [i] = m_Nums [i] ;
            cout << Numbers [i] << " " ;
        }
        Numbers [n-1] = m ;
        cout << Numbers [n-1] << " " ;
        for (int i = n ; i < m_Size+1 ; i++)
        {
            Numbers [i] = m_Nums [i-1] ;
            cout << Numbers [i] << " " ;
        }
        cout << endl ;
    }

    void Erase (int n)
    {
        int* Numbers ;
        Numbers = (int*) malloc (sizeof (int) * (m_Size-1)) ;
        cout << "Numbers after erasing : " ;
        for (int i = 0 ; i < n-1 ; i ++)
        {
            Numbers [i] = m_Nums [i] ;
            cout << Numbers [i] << " " ;
        }
        for (int i = n-1 ; i < m_Size-1 ; i++)
        {
            Numbers [i] = m_Nums [i+1] ;
            cout << Numbers [i] << " " ;
        }
        cout << endl ;
    }
};

int main ()
{
    int nums1 [] = {1,2,3,4} ;
    Vector V1 (4 , nums1) ;
    V1.Push_back () ;
    V1.Insert (2,5) ;
    V1.Erase (2) ;
}