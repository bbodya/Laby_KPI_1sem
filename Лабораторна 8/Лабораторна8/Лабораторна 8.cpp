#include <iostream>
#include <iomanip>
#include<ctime>

using namespace std;

double** create_matrix(int size);
void fill_matrix(double** matrix, int size);
void print_matrix(double** matrix, int size);
double calculate_row_sum(double** matrix, int size);
void average(double element1, double element2);
void delete_matrix(double** matrix, int size);

int main() {
    printf("Vasyliv Bohdan, IS-01, V.6\n");
    srand(time(NULL));

    int n;
    cout << "Enter n(size of matrix A and B): "; cin >> n;

    double** matrixA = create_matrix(n);
    double** matrixB = create_matrix(n);

    fill_matrix(matrixA, n);
    fill_matrix(matrixB, n);

    cout << "Matrix A is:\n";
    print_matrix(matrixA, n);
    cout << "Matrix B is:\n";
    print_matrix(matrixB, n);

   
    double mNorm_matrixA = calculate_row_sum(matrixA, n);
    double mNorm_matrixB = calculate_row_sum(matrixB, n);

    cout << "M-norm of matrix A: " << mNorm_matrixA << endl;
    cout << "M-norm of matrix B: " << mNorm_matrixB <<endl;

    average(mNorm_matrixA, mNorm_matrixB);

    delete_matrix(matrixA, n);
    delete_matrix(matrixB, n);

    return 0;
}

double** create_matrix(int size) {
    double** matrix = new double* [size];

    for (int i = 0; i < size; i++) {
        matrix[i] = new double[size];
    }

    return matrix;
}

void fill_matrix(double** matrix, int size) {
    for (int i = 0; i < size; i++) {
        for (int j = 0; j < size; j++) {
            matrix[i][j] = ((rand() % 101)-50);
        }
    }
}

void print_matrix(double** matrix, int size) {
    for (int i = 0; i < size; i++) {
        for (int j = 0; j < size; j++) {
            cout << setw(6) << matrix[i][j];
        }
        cout << endl;
    }
}

double calculate_row_sum(double** matrix, int size) {
    double max_sum = 0;
    double current_sum = 0;

    for (int i = 0; i < size; i++) {
        current_sum = 0;

        for (int j = 0; j < size; j++) {
            current_sum += fabs(matrix[i][j]);

            if (current_sum > max_sum) {
                max_sum = current_sum;
            }
        }
    }

    return max_sum;
}

void average(double element1, double element2) {
    double result;
    result = (element1 + element2) / 2;

    cout << "Average sum: " <<result<< endl;
}

void delete_matrix(double** matrix, int size) {
    for (int i = 0; i < size; i++) {
        delete[] matrix[i];
    }

    delete[] matrix;
}