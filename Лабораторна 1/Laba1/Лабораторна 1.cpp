#include<iostream>
using namespace std;

int main()
{
	int k, h, m;
	setlocale(LC_ALL, "rus");//������������� ������� � ������� ����
	printf("Vasyliv Bohdan, IS-01, �6\n");
	cout << "������� ���������� ������ k:";//�������� �������� k
	cin >> k;
	h = k / 3600;// ����������� �����
	m = (k % 3600) / 60;// ����������� ������
	cout << "�����:" << h <<" "<< "�����:" << m << endl;// ��������� ����������
	cin.get();
}
