#include "time.h"
#include <iostream>
using namespace std;

Time::Time(int hours, int minutes, int seconds)
{
    if (hours < 0 || minutes < 0 || seconds < 0)
    {
        throw Time::Time::TimeError();
    }

    if (seconds >= 60)
    {
        minutes += seconds / 60;
        seconds %= 60;
    }
    if (minutes >= 60)
    {
        hours += minutes / 60;
        minutes %= 60;
    }
    Time::set_hours(hours);

    Time::set_hours(hours);
    Time::set_minutes(minutes);
    Time::set_seconds(seconds);
}

Time::Time()
{
    Time::set_hours(00);
    Time::set_minutes(00);
    Time::set_seconds(00);
}

//Установка часов, минут, секунд
void Time::set_hours(int hours)
{
    Time::hours = hours;
}

void Time::set_minutes(int minutes)
{
    Time::minutes = minutes;
}

void Time::set_seconds(int seconds)
{
    Time::seconds = seconds;
}

//Получение часов, минут, секунд
int Time::get_hours()
{
    return Time::hours;
}

int Time::get_minutes()
{
    return Time::minutes;
}

int Time::get_seconds()
{
    return Time::seconds;
}

void Time::ShowTime()
{
    cout << "\n" << Time::get_hours() << ":" << Time::get_minutes() << ":" << Time::get_seconds() << "\n";
}

Time Time::PlusTime(Time& t2) {
    int hours = Time::get_hours() + t2.get_hours();
    int minutes = Time::get_minutes() + t2.get_minutes();
    int seconds = Time::get_seconds() + t2.get_seconds();
    return Time(hours, minutes, seconds);
}

Time Time::operator+(const Time& t) const
{
    int h = hours + t.hours;
    int m = minutes + t.minutes;
    int s = seconds + t.seconds;
    if (s >= 60)
    {
        m += s / 60;
        s %= 60;
    }
    if (m >= 60)
    {
        h += m / 60;
        m %= 60;
    }
    return Time(h, m, s);
}
Time Time::operator-(const Time& t) const
{
    int h = hours - t.hours;
    int m = minutes - t.minutes;
    int s = seconds - t.seconds;
    if (t.minutes > minutes)
    {
        m += 60.0;
        h--;
    }
    m = abs(m - t.minutes);
    if (t.seconds > seconds)
    {
        s += 60.0;
        m--;
    }
    s = abs(m - t.seconds);    
    return Time(h, m, s);
}

Time Time::operator=(const Time& t) const
{
    if (hours == t.hours && minutes == t.minutes && seconds == t.seconds)
    {
        cout << "The first time is equal to second time.";
    }
    else {
        cout << "The first time is not equal to second time."; 
        return Time();
    }
    return Time();
}

Time operator+ (float flHours, const Time& t) {
    float h, m;
    float s = modf(modf(flHours, &h) * 60, &m) * 60;

    Time firstTime(static_cast<int>(h), static_cast<int>(m), static_cast<int>(s));
    return (firstTime + t);
}

Time operator+ (const Time& t, float flHours) {
    return flHours + t;
}