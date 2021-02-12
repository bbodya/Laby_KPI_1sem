#include"Header.h"


int main()
{
	int n;
	cout << "Input number of strings" << endl; cin >> n;//вввід кількості рядків
	string* s = new string[n];
	cin.get();
	for (int i = 0; i < n; i++)
	{

		getline(cin, s[i]);

	}

	output(s, n);

	
	cout<<endl<< "length of first word:" << endl;
	length_of_first_word(s, n);

	cout << endl << "numbers of  words:" << endl;
	countWords(s, n);

	
	return 0;
	
}

	

	
