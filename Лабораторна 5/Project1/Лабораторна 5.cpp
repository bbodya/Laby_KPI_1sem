#include <iostream> 
#include<cmath>
using namespace std;

int main()
{
    setlocale(LC_ALL, "Ukr");
    printf("�����i� ������ I�-01, �������� �23\n");

    int a, b;
    cout << "����i�� ����� ���� �������� �i�������, a:"; cin >> a;
    cout << "����i�� ����� ����� �������� �i�������, b:"; cin >> b;

    for (a; a <= b; a++) {
        cout << "��� �����: " << a << ":\n";
        if (a == 0) {
            cout << "��i ����� ����i�������i �i�����i � �i��������\n";
        }
        else {
            for (int div = 1; div <= abs(a); div++) {
                if (a % div == 0) {
                    int f0 = 0, f1 = 1, fn = 1;
                    while (fn <= div) {
                        fn = f0 + f1;
                        f0 = f1;
                        f1 = fn;
                        if (fn == div) {
                            cout << div << "\n";
                        }
                    }
                }
            }
        }

    }


    return 0;
}