#include"Header.h"

void create_array(int* array, int m) 
{
	for (int i = 0; i < m; i++)
	{
		array[i]=rand()%(100+100+1)-100;
	}

	for (int i = 0; i < m; i++)
	{
		cout<<array[i]<<"\t";

	}

	cout << endl;
}

void create_matrix(int** array, int size, int*arrayB, int sizeB)
{
	for (int i = 0; i < size; i++) 
	{
		array[i] = new int [size];
	}


	int count = 0;
	for (int o = 0; o < size; o++) 
	{
		if ((o % 2) == 1) 
		{
			for (int i = 0; i < size; i++)
			{
				array[i][o] = arrayB[count];
				count++;

				if (count > sizeB)
				{
					array[i][o] = 0;
				}
			}
		}

		if ((o % 2 != 1)) 
		{
			for (int i = size - 1; i >= 0; i--)
			{
				array[i][o] = arrayB[count];
				count++;

				if (count > sizeB)
				{
					array[i][o] = 0;
				}
			}
		}
	}

	for (int i = 0; i < size; i++)
	{
		for (int j = 0; j < size; j++)
		{
			cout<<setw(5)<<array[i][j];
		}
		cout << endl;
	}

	cout << endl;
}


void sort_row(int** array, int size)
{
	int k, a;
	for (int j = 0; j < size; j++) 
	{
		for (k = 0; k < size; k++) 
		{
			for (int i = 0; i < size - 1; i++)
			{
				if (array[i][j] > array[i + 1][j])
				{
					a = array[i][j];
					array[i][j] = array[i + 1][j];
					array[i + 1][j] = a;
				}
			}

		}

	}

		for (int i = 0; i < size; i++)
		{
			for (int j = 0; j < size; j++)
			{
				cout << setw(5) << array[i][j];
			}
			cout << endl;
		}
		cout << endl;
}

void delete_matrix(int** matrix, int size)
{
	for (int i = 0; i < size; i++)
	{
		delete matrix[i];
	}
	delete[]matrix;
 }

void delete_massive(int* massive)
{
	delete[]massive;
}


