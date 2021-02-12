#pragma once
#include<iostream>
#include<iomanip>
#include<ctime>
using namespace std;

void create_array(int* array, int m);
void create_matrix(int** array, int size, int* arrayB, int sizeB);
void sort_row(int** array, int size);
void delete_matrix(int** matrix, int size);
void delete_massive(int* massive);

