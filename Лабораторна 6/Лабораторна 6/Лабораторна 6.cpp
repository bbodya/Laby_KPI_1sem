#include<iostream>
using namespace std;

int facktorial(int i);
int findNumber(int n, int k);
int findMax(int r1, int r2, int r3);


int main()
{
	setlocale(LC_ALL, "ukr");
	printf("�����i� ������, I�-01, �23\n");

	int res1, res2, res3;

	res1 = findNumber(5, 3);
	res2 = findNumber(4, 2);
	res3 = findNumber(5, 4);

	cout << "�i���i��� 3-��� ������� ����� � ���� 1, 2, 3, 4, 5: " << res1 << endl;
	cout << "�i���i��� 2-�� ������� ����� � ���� 2, 4, 6, 8: " << res2 << endl;
	cout << "�i���i��� 4-��� ������� ����� � ���� 1, 3, 7, 8, 9: " << res3 << endl;
	cout << "����������� ��������: " << findMax(res1, res2, res3) << endl;
	

	system("pause");
}

int facktorial(int i)
{
	if (i == 1) {
		return i;
	}
	else {
		return i * facktorial(i - 1);
	}
}

int findNumber(int n, int k)
{
	return facktorial(n) / facktorial(n - k);
}

int findMax(int r1, int r2, int r3)
{
	if ((r1 >= r2) && (r1 >= r3))
		return  r1;
	else if ((r2 >= r1) && (r2 >= r3))
		return  r2;
	else if ((r3 >= r1) && (r3 >= r2))
		return  r3;
}


