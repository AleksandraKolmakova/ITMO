#include <iostream>
#include <windows.h>
using namespace std;

struct Time
{
    int hours;
    int minutes;
    int seconds;

    void ShowTime()
    {
        cout << "\n" << hours << ":" << minutes << ":" << seconds << "\n";
    }
};

Time PlusTime(const Time& t1, const Time& t2)
{
    Time t;
    t.hours = t1.hours + t2.hours;
    t.minutes = t1.minutes + t2.minutes;
    if (t.minutes >=60)
    {
        t.hours++;
        t.minutes %= 60;
    }
    t.seconds = t1.seconds + t2.seconds;
    if (t.seconds >= 60)
    {
        t.minutes++;
        t.seconds %= 60;
    }
    return t;
}
Time MinusTime(Time& t1, Time& t2)
{
    Time t;
    t.hours = t1.hours - t2.hours;
    if (t2.minutes > t1.minutes)
    {
        t.minutes += 60.0;
        t.hours--;
    }
    t.minutes = abs(t1.minutes - t2.minutes);
    if (t2.seconds > t1.seconds)
    {
        t.seconds += 60.0;
        t.minutes--;
    }
    t.seconds = abs(t1.seconds - t2.seconds);
    return t;
}

Time InputTime()
{
    Time t;
    cout << "Enter hours : minutes : seconds " << "\n";
    cin >> t.hours >> t.minutes >> t.seconds;
    return t;
}

int main()
{
    Time t1 = InputTime();
    Time t2 = InputTime();
    Time t3 = PlusTime(t1, t2);
    Time t4 = MinusTime(t1, t2);
    t3.ShowTime();
    t4.ShowTime();
}