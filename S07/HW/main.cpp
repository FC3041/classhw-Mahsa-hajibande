#include<iostream>
#include<string>
#include<stdio.h>
#include<Windows.h>

using namespace std ;

void Clock ()
{
    unsigned long long l1 = GetTickCount64() ;
    int sum = 0 ;
    for (int i = 0 ; i < 10000000 ; i++)
    {
        sum += i ;
    }
    unsigned long long l2 = GetTickCount64() ;
    cout << l2 - l1 << endl ;
}

int main ()
{
    Clock () ;
}