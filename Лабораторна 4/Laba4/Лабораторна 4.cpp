#include<iostream>
using namespace std;

int main()
{
	setlocale(LC_ALL, "UKR");
	printf("Vasyliv Bohdan, �6\n");

	int f0 = 0, f1 = 1, fn, n;

	cout << "����i�� ����� ����� ���� �i������i n:"; cin >> n;

	if (n == 0)
	{
		cout << "������ ����� � ���� �i������i:" << f0 << endl;
	}

	else if (n == 1)
	{
		cout<< "������ ����� � ���� �i������i:" << f1 << endl;
	}

	else
	{
		for (int i = 2; i <= n; i++) 
		{
			fn = f0 + f1;
			f0 = f1; f1 = fn;
			
			//cout << fn<<endl;
		}
		
		cout <<"������ ����� � ���� �i������i:" <<fn <<endl;
	}
	
	return 0;
}