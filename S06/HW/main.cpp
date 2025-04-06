#include<iostream>

using namespace std;

class MyStr
{
    public:
    int m_size;
    char* m_PChars;

    MyStr():m_size(0),m_PChars(nullptr){};

    MyStr(const char* chars)
    {
        int i;
        for(i=0;chars[i]!='\0';i++);
        m_size = i+1;

        m_PChars = (char*)malloc(sizeof(char)*(m_size));
        for(i=0; i<m_size;i++)
        {
            m_PChars[i] = chars[i];
        }
        m_PChars[m_size] = '\0';
    }

    MyStr(const char* chars, int start, int count)
    :m_size(count)
    {
        m_PChars = (char*)malloc(sizeof(char)*(m_size+1));

        for(int i=0;i<m_size ;i++)
        {
            m_PChars[i] = chars[start+i];
        }
        m_PChars[count] = '\0';

    }

    void printStr()
    {
        cout << m_PChars << endl;
    }

    int lenStr ()
    {
        int lenStr = 0 ;
        while (m_PChars [lenStr] != '\0')
        {
            lenStr ++ ;
        }
        return lenStr ;
    }

    int length (const char* str)
    {
        int len = 0 ;
        while (str [len] != '\0')
        {
            len ++ ;
        }
        return len ;
    }

    bool CheckSubstr (const char* str)
    {
        int len = length (str) ;
        int MyLen = lenStr () ;
        for (int i = 0 ; i <= MyLen - len ; i++)
        {
            bool found = true;
            for (int j = 0 ; j < len ; j++)
            {
                if (str [j] != m_PChars [i+j])
                {
                    found = false;
                    break;
                }
            }
            if (found)
            {
                return true;
            }
        }
        return false;
    }

    void check (const char* str)
    {
        if (CheckSubstr (str) == true)
        {
            cout << "the second string exists in the first one." << endl ;
        }
        else
        {
            cout << "the second string doesn't exist in the first one." << endl ;
        }
    }

    void add (const char* str)
    {
        char* chars ;
        int newsize = m_size + length(str) + 1 ;
        chars = (char*) malloc (sizeof(char) * (newsize)) ;
        for (int i = 0 ; i < m_size ; i++)
        {
            chars [i] = m_PChars [i] ;
        }
        for (int i = 0 ; i < length (str) ; i++)
        {
            chars [i + length (str)] = str [i] ;
        }
        chars [newsize] = '/0' ;
        cout << chars << endl ;
    }
};


int main()
{
    MyStr s1 ("Mahsa") ;
    cout << s1.lenStr () << endl ;
    s1.check ("sa") ;
    s1.add ("Haji") ;
    return 0 ;
}