#include "time.h"
#include <iostream>

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