#include <iostream> 
#include<cmath>
using namespace std;

int main()
{
    setlocale(LC_ALL, "Ukr");
    printf("Василiв Богдан IС-01, завдання №23\n");

    int a, b;
    cout << "Введiть крайнє нижнє значення дiапазону, a:"; cin >> a;
    cout << "Введiть крайнє верхнє значення дiапазону, b:"; cin >> b;

    for (a; a <= b; a++) {
        cout << "Для числа: " << a << ":\n";
        if (a == 0) {
            cout << "Всi числа послiдовностi Фiбоначi є дiльниками\n";
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