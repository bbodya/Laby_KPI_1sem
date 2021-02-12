/*�������� ����������� ����� � � ������ �����.
�������� ��������� ������� ������������ ������(��������, ���� ������� �������� ���� ��������), ��� ��������� �� ��� ������� �, �������� ���� �� ��������� ������� 0.
��������� ������� ������ �� ��������, ������� ����� ����.³����������  ������� �� ����������*/
#include"Header.h"

int main()
{
	srand(time(NULL));
	int m;
	cout << "Input size of array B:";
	cin >> m;
	int* arrayB = new int[m];
	create_array(arrayB, m);

	int size=ceil(pow(m,0.5));
	int** arrayC = new int* [size];
	cout << "Our matrix:" << endl;
	create_matrix(arrayC, size, arrayB, m);

	cout << "Our sort matrix:\n";
	sort_row(arrayC, size);
	delete_matrix(arrayC, size);
	delete_massive(arrayB);

	return 0;
}