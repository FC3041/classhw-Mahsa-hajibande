#include<iostream>
#include<string>
#include<stdio.h>
#include<Windows.h>

using namespace std ;

class KeepTime
{
    public :
    const char* name ;
    unsigned long long l1 ;
    KeepTime (const char* FunctionName)
    {
        unsigned long long l1 = GetTickCount64 () ;
        name = FunctionName ;
    }

    ~KeepTime ()
    {
        unsigned long long l2 = GetTickCount64 () ;
        unsigned long long time = l2 - l1 ;
        cout << "the time that " << name << " takes : " << time << " miliseconds" << endl ;
    }
};

int main ()
{
    KeepTime K1 ("sumofint") ;
    int sum = 0 ;
    for (int i = 0 ; i < 100 ; i++)
    {
        sum += i ;
    }
    return 0 ;
}