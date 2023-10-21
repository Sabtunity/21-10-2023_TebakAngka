#include <iostream>
// #include <UnityEngine.UI>
// #include <TMPro>
using namespace std;

int main() {
    // diluar Start dan Update
    int soal;
    int playerInput;

    // ini adalah Start
    srand(time(NULL));
    soal = rand() % 1000 + 1;

    // ini adalah Update
    while (1)
    {
        cout << "Input Tebakan Anda\t: ";

        cin >> playerInput;

        if (playerInput < soal) {
            cout << "Tebakan kurang\n";
        }
        else if (playerInput > soal) {
            cout << "Tebakan lebih\n";
        }
        else {
            cout << "Benarr!\n";
            break;
        }
    }

    return 0;
}