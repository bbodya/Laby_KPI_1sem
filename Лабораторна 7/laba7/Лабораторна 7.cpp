#include <iostream>
#include<ctime>
#include<cmath>
using namespace std;

void genre_array(double* arr, int arrSize);
double find_max(double* arr, int arrSize);
double find_min(double* arr, int arrSize);
void change(double* arr, int arrSize, double elem, double z);
void print_array(double* arr, int arrSize);

int main() {

    printf("Vasyliv Bohdan IS-01 (v.6)\n");
    srand(time(NULL)); 

    int sizeF, sizeG;
    cout << "Input sizes of arrays F and G:" << endl;
    cin >> sizeF >> sizeG;

    double* arrF = new double[sizeF];
    double* arrG = new double[sizeG];

    genre_array(arrF, sizeF);
    genre_array(arrG, sizeG);

    cout << "Our arrays F and G are:\n";
    print_array(arrF, sizeF);
    print_array(arrG, sizeG);
    cout << endl;


    double maxF = find_max(arrF, sizeF);
    double minG = find_min(arrG, sizeG);

    cout << "Maximum element of array F = " << maxF << '\n';
    cout << "Minimum element of array G = " << minG << '\n';

    double z = fabs(maxF + minG) / 2;
    cout <<  "z = " << z << "\n";

    change(arrF, sizeF, maxF, z);
    change(arrG, sizeG, minG, z);

    cout << "Arrays after change:\n";
    print_array(arrF, sizeF);
    print_array(arrG, sizeG);

    delete[] arrF;
    delete[] arrG;

    return 0;
}


void genre_array(double* arr, int arrSize) {
    for (int i = 0; i < arrSize; i++) {
        arr[i] =(rand() % 501) - 250;
    }
}

double find_max(double* arr, int arrSize) {
    double max = arr[0];

    for (int i = 1; i < arrSize; i++) {
        if (arr[i] > max) {
            max = arr[i];
        }
    }

    return max;
}

double find_min(double* arr, int arrSize) {
    double min = arr[0];

    for (int i = 1; i < arrSize; i++) {
        if (arr[i] < min) {
            min = arr[i];
        }
    }

    return min;
}


void change(double* arr, int arrSize, double elem, double z) {
    for (int i = 0; i < arrSize; i++) {
        if (arr[i] == elem) {
            arr[i] = z;
        }
    }
}

void print_array(double* arr, int arrSize) {
    for (int i = 0; i < arrSize; i++) {
        cout<<arr[i] <<"\t";
    }

    cout <<endl;
}