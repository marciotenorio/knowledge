#include <iostream>
#include "ll.h"

using namespace std;

int main() {
    linked_list* ll = create(10);
    push_back(ll, 11);
    push_back(ll, 12);
    push_back(ll, 13);
    print(ll);
    cout << ll->size << endl;

    return 0;
}