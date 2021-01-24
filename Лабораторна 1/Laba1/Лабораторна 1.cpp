#include<iostream>
using namespace std;

int main()
{
	int k, h, m;
	setlocale(LC_ALL, "rus");//Перекодування символів у потрібну мову
	printf("Vasyliv Bohdan, IS-01, №6\n");
	cout << "введите количество секунд k:";//Введення значення k
	cin >> k;
	h = k / 3600;// Знаходження годин
	m = (k % 3600) / 60;// Знаходження хвилин
	cout << "часов:" << h <<" "<< "минут:" << m << endl;// Виведення результату
	cin.get();
}
