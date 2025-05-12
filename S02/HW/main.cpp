#include <iostream>
#include <math.h>
#define P 3.14159265350979323

using namespace std ;

class Circle
{
    public :
        double x ; double y ;
        double r ;
    double Mohit ()
    {
        return 2 * P * r ;
    }
    double Masahat ()
    {
        return P * r * r ;
    }
    double FaseleMarkaz (Circle Center1)
    {
        double x_diff = x - Center1.x ;
        double y_diff = y - Center1.y ;
        return sqrt (x_diff * x_diff + y_diff * y_diff) ;
    }
    void Makan (Circle Point1)
    {
        double x_diff = x - Point1.x ;
        double y_diff = y - Point1.y ;
        double fasele = sqrt (x_diff * x_diff + y_diff * y_diff) ;
        if (fasele > r)
        {
            cout << "the point is out of the circle ." << endl ;
        }
        else if (fasele == r)
        {
            cout << "the point is on the circumference of the circle ." << endl ;
        }
        else
        {
            cout << "the point is in the circle ." << endl ;
        }
    }
    double FaseleNoghteTaMarkaz (Circle Point2)
    {
        double x_diff = x - Point2.x ;
        double y_diff = y - Point2.y ;
        double fasele = sqrt (x_diff * x_diff + y_diff * y_diff) ;
        return fasele ;
    }

};

int main ()
{
    Circle MainCircle ;
    MainCircle.x = 1 ;
    MainCircle.y = 1 ;
    MainCircle.r = 2 ;

    Circle Center1 ;
    Center1.x = 5 ;
    Center1.y = 4 ;

    Circle Point1 ;
    Point1.x = 20 ;
    Point1.y = 10 ;

    Circle Point2 ;
    Point2.x = 3 ;
    Point2.y = 4 ;

    double Mohit = MainCircle.Mohit () ;
    cout << "Mohit : " << Mohit << endl ;

    double Masahat = MainCircle.Masahat () ;
    cout << "Masahat : " << Masahat << endl ;

    double FaseleDoMarkaz = MainCircle.FaseleMarkaz (Center1) ;
    cout << "Fasele Do Markaz : " << FaseleDoMarkaz << endl ; 

    double FaseleTaMarkaz = MainCircle.FaseleNoghteTaMarkaz (Point2) ;
    cout << "Fasele Noghte Ta Markaz : " << FaseleTaMarkaz << endl ;

    MainCircle.Makan (Point1) ;
}