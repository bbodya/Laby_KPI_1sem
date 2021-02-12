#include"Header.h"

void countWords(string *s, int n)
{
	for (int i=0; i < n; i++)
	{
		int times = 0, pos = s[i].find(" ");
		while (pos != string::npos)
		{
			++times;
			s[i].erase(0, pos + 1);
			pos = s[i].find(" ");
		}
		cout << ++times << endl;
	}
}


void output(string *s, int n)
{
	cout << endl;
	for (int i = 0; i < n; i++)//вивід рядків
	{
		cout << s[i] << endl;
	}
}

void length_of_first_word(string *s, int n)
{
	for (int i = 0; i < n; i++)// довжина 1 слова
	{
		string a = s[i].substr(0, s[i].find(" "));
		cout << a.length() << endl;
	}
}
