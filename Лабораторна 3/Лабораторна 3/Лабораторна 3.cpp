#include<iostream>
#include<cmath>
using namespace std;

int main()
{
    setlocale(LC_ALL, "UKR");
    printf("�����i� ������, I�-01, �������� �26\n");

    int n = 0;
    float x0,// �������� � 
        x,// �������� ���������� �
        a,// ������� �����
        c,// ������ �� � � �0
        eps = 0.0001;// �������� ���������� 

    cout << "����i�� �:"; cin >> a;// ��� �����
    if (a == 0)// ������� ������ ������� �� ������ ��� 0, �������� �=0, �� ��������
        cout << "���� �������� x=0\n";
    else// ���� � �� ������� 0
    {
        if (a <= 1)// ����� 1
            x0 = min(2.0 * a, 0.95);// �0 ��� ���� 1
        else if (1 < a && a < 25)// ����� 2
            x0 = a / 5;// �������� �0 ��� ���� 2
        else x0 = a / 25;// �������� �0 ���� �� ���������� ����� 1 � ����� 2

        do
        {
            x = 4. / 5 * x0 + a / (5 * pow(x0, 4));// ���������� � �� ������� ��������
            c = x - x0;// ���������� ������ ������������ � � ���������
            x0 = x;//��������� �������� �0 ��������� �������� �
            n++;
            cout << "x=" << x << endl;//���� ��������� �
        } while (fabs(c) >= eps);// ����� �� ��� ���������� ���������� ��� ������ �������
        cout << "���� �������� �=" << x << endl;// ���� � � �������� ��� �������� 
    }
        return 0;
    
}