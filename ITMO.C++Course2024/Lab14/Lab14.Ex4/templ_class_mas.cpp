#include <iostream>
using namespace std;

template<class T, class T1> class arr
{
public:
    arr(int size);
    T1 sum();
    T average_value();
    void show_array();
    int add_value(T);
private:
    T* data;
    int size;
    int index;
};

template<class T, class T1> arr<T, T1>::arr(int size)
{ 
   data = new T [size]; 
   if (data == NULL) 
   { 
      cerr<< "Error memory ---- exit program" << endl; 
      exit(1); 
   } 
   arr::size = size; 
   arr::index = 0; 
} 

template<class T, class T1> T1 arr<T, T1>::sum()
{ 
   T1 sum = 0; 
   for (int i = 0; i < index; i++) sum += data[i]; 
   return(sum); 
} 

template<class T, class T1> T arr<T, T1>::average_value()
{ 
   T sum = 0; 
   for (int i = 0; i < index; i++) sum += data[i]; 
   return (sum / index); 
} 
template<class T, class T1> void arr<T, T1>::show_array()
{ 
   for (int i = 0; i < index; i++) cout << data[i] << ' '; 
   cout << endl; 
} 
template<class T, class T1>int arr<T, T1>::add_value(T value)
{ 
   if (index == size) return(-1); // ������ ����� 
   else 
   { 
      data[index] = value; 
      index++; 
      return(0); // ������� 
   } 
} 

int main() 
{ 
   arr<int, long> numbers(100);// ������ �� 100 ��-��� 
   arr<float, float> values(200);
   int i; 
   for (i = 0; i < 50; i++) numbers.add_value(i); 
   numbers.show_array(); 
   cout << "Sum = " << numbers.sum () << endl; 
   cout << "Average =  " << numbers.average_value() << endl; 

   for (i = 0; i < 50; i++) values.add_value(i*100);
   values.show_array();
   cout << "Sum = " << values.sum() << endl;
   cout << "Average =  " << values.average_value() << endl;

   return 0;
} 
