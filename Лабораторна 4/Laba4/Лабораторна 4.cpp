#include<iostream>
using namespace std;

int main()
{
	setlocale(LC_ALL, "UKR");
	printf("Vasyliv Bohdan, №6\n");

	int f0 = 0, f1 = 1, fn, n;

	cout << "Введiть номер числа ряду Фiбоначчi n:"; cin >> n;

	if (n == 0)
	{
		cout << "Шукане число з ряду Фiбоначчi:" << f0 << endl;
	}

	else if (n == 1)
	{
		cout<< "Шукане число з ряду Фiбоначчi:" << f1 << endl;
	}

	else
	{
		for (int i = 2; i <= n; i++) 
		{
			fn = f0 + f1;
			f0 = f1; f1 = fn;
			
			//cout << fn<<endl;
		}
		
		cout <<"Шукане число з ряду Фiбоначчi:" <<fn <<endl;
	}
	
	return 0;
}