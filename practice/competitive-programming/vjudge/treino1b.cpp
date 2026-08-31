#include <bits/stdc++.h>
using namespace std;

int main() {
    int s;
    cin>> s;

    set<int> nr;
    bool e;
    for(int i=0; i<s; ++i) {
        int in;
        cin>> in;
        nr.insert(in);
    }

    cout << nr.size() << endl;
}