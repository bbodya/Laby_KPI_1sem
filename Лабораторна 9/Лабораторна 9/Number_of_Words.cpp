#include "Number_of_Words.h"

void count_numberOf_words(string start_symbols, string line) {
    int slova = 1;

    for (int i = 0; i <= start_symbols.find_last_of(" "); i++) { 
        if (start_symbols[i] == ' ') {
            slova++;
        }
    }

    string* words = new string[slova];
    int current_word = 0;

    for (int i = 0; i < start_symbols.length(); i++) {
        if (start_symbols[i] != ' ') {
            words[current_word] += start_symbols[i];
        }
        else {
            current_word++;
        }
    }

    int count = 0;
    for (int i = 0; i < (slova); i++) {
        bool same = true;
        for (int k = 0; k < line.length(); k++) {
            if (words[i][k] != line[k]) {
                same = false;
            }

        }
        if (same) {
            cout << words[i] << " ";
            count++;
        }
    }

    cout << endl <<"Number of suitable words"<< count;
}