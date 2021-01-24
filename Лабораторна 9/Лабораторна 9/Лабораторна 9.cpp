#include <iostream>
#include "Number_of_Words.h"

using namespace std;

int main() {
    printf("Vasyliv Bohdan, IS-01, V.6\n");

    string start_symbols, line;

    cout << "Input your string:"; getline(cin, start_symbols);
    cout << "Input first symbols:"; getline(cin, line);

    count_numberOf_words(start_symbols, line);

    return 0;
}